using Mogre;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace SkyboxVisualizer
{
    public partial class OgreForm 
    {
        // Count of points received
        long TotalPointsReceived = 0;
        long ValidReturn = 0;
        long ValidReturnOverFlow = 0;
        long NoReturn = 0;
        long MissingSample = 0;
        long BeyondThreshold = 0;   // Computed

        int MaxIntensity = 0;  // 0 to 16383
        int MinIntensity = 0;  // "    

        public Vector3 FromSphericalRadians(float r, float theta, float phi)
        {
            float snt = (float)System.Math.Sin(theta);
            float cnt = (float)System.Math.Cos(theta);
            float snp = (float)System.Math.Sin(phi);
            float cnp = (float)System.Math.Cos(phi);

            //Original
            //float x = r * snt * cnp;            
            //float y = r * snp * snt;
            //float z = r * cnt;

            float x = r * snt * cnp;
            float y = r * snp * snt;
            float z = r * snt;

            return new Vector3(x, y, -z);
        }

        public Vector3 LBFromSphericalRadians(float r, float az, float el)
        {
            float x = r * (float)System.Math.Sin(az);
            float y = r * (float)System.Math.Sin(el);
            float z = r * (float)System.Math.Cos(az); // Wrong!

            return new Vector3(x, y, -z);
        }

        public Vector3 CamFromSphericalRadians(float r, float az, float el)
        {
            float x = r * (float)System.Math.Sin(az);
            float y = r * (float)System.Math.Sin(el);
            float w = (float)System.Math.Sqrt(x * x + y * y);
            float z = (float)System.Math.Sqrt(r * r - w * w);

            return new Vector3(x, -y, -z);  // Negate Y for azimuth convention, negate Z for Ogre convention
        }

        public Vector3 FromCylindricalRadians(float r, float theta, float zz)
        {
            float snt = (float)System.Math.Sin(theta);
            float cnt = (float)System.Math.Cos(theta);

            float x = r * cnt;
            float y = r * snt;

            return new Vector3(x, zz, -y);
        }

        // Callback point for background threads (file load, network) to display loaded data.
        public void PlotScanDataThread(List<ScanPoint> ScanPoints)
        {
            updateLidarData(manual, ScanPoints, MinIntensity, MaxIntensity, Threshold.Value, InvertEL.Checked);
            SafeUpdateStatus("Plotted " + ScanPoints.Count + " scan points.", false);
        }

        private void updateLidarData(ManualObject manual, List<ScanPoint> ScanPoints, int intensitymin, int intensitymax, Decimal d_threshold_meters, bool invert)
        {
            if (manual == null) return;
            if (ScanPoints == null) return;

            double threshold = (double)d_threshold_meters*1000d; // convert to mm

            if (intensitymax > IntensityLimitMax.Value)
            {
                intensitymax = (int)IntensityLimitMax.Value;
            }

            if (intensitymin > IntensityLimitMin.Value)
            {
                intensitymin = (int)IntensityLimitMin.Value;
            }

            try
            {
                manual.Begin("BaseWhiteNoLighting", RenderOperation.OperationTypes.OT_POINT_LIST);

                // "Horizon" at threshold
                float r1 = (float)threshold;

                for (float t1 = -PI; t1 <= PI; t1 += 0.001f)
                {
                    //for (float p1 = -50; p1 <= 50; p1 +=10f)
                    {
                        manual.Position(LBFromSphericalRadians(r1, t1, 0.0f));
                        manual.Colour(new ColourValue(0.5f, 0.5f, 1f));
                    }
                }

                // Real data
                foreach (ScanPoint sp in ScanPoints)
                {
                    double r = (double)sp.Range;
                    double az = (double)sp.Azimuth / 1000d;
                    double el = (double)sp.Elevation / 1000d;

                    // Don't plot if past threshold
                    if (r > threshold)
                    {
                        BeyondThreshold++;
                        continue;
                    }

                    ColourValue cv = new ColourValue(1,0,0);                    

                    if (invert)  // Inverted for Wildcat Data or other situations where sensor head was upside down
                    {
                        el = -el;
                        az = -az;
                    }

                    manual.Position(CamFromSphericalRadians((float)r, (float)az, (float)el)); 
                    manual.Colour(cv);
                }
                manual.End();
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception when plotting points: " + e.Message);
                // ignore throw e;
            }
        }
    }
}

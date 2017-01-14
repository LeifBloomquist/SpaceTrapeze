using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyboxVisualizer
{
    ///<summary> 
    ///This class represents a single Scan Point within the scan data.
    ///</summary> 
    public class ScanPoint
    {
        public double Range { get; private set; }
        public double Azimuth { get; private set; }
        public double Elevation { get; private set; }
 

        public ScanPoint(
            double Range,
            double Azimuth,
            double Elevation)       
        {

            this.Range = Range;
            this.Azimuth = Azimuth;
            this.Elevation = Elevation;
        }
    }
}

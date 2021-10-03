using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WJS.Drive.Core
{
    public class Chassis
    {
        public Damper FLDamper { get; set; }
        public Damper FRDamper { get; set; }
        public Damper RLDamper { get; set; }
        public Damper RRDamper { get; set; }

        public ElectricMotor FLMotor { get; set; }
        public ElectricMotor FRMotor { get; set; }
        public ElectricMotor RLMotor { get; set; }
        public ElectricMotor RRMotor { get; set; }
    }
}

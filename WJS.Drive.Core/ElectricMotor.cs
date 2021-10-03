using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WJS.Drive.Core
{
    public class ElectricMotor
    {
        private readonly int _reactionTimeInMs;
        private readonly decimal _maxPowerInWatts;
        private readonly int _rpm;
        public decimal MaxPowerInWatts => _maxPowerInWatts;
        public int RPM => _rpm;
        public int ReactionTimeInMs => _reactionTimeInMs;

    }
}

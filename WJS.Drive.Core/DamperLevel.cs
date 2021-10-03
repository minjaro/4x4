using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WJS.Drive.Core
{
    public struct DamperLevel
    {
        private const byte MIN = 0, MAX = 100;
        private byte _value;
        public byte Value => _value;

        public DamperLevel(byte value)
        {
            if (value < MIN || value > MAX)
                throw new ArgumentException($"Damper level value should be between {MIN} and {MAX}");

            _value = value;
        }
    }
}

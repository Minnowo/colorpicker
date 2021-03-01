using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nsColorPicker
{
    public static class MathHelper
    {
        public static T Clamp<T>(T num, T min, T max) where T : IComparable<T>
        {
            if (num.CompareTo(min) <= 0) return min;
            if (num.CompareTo(max) >= 0) return max;
            return num;
        }
        public static decimal Truncate(decimal d, byte decimals)
        {
            decimal r = Math.Round(d, decimals);

            if (d > 0 && r > d)
            {
                return r - new decimal(1, 0, 0, false, decimals);
            }
            else if (d < 0 && r < d)
            {
                return r + new decimal(1, 0, 0, false, decimals);
            }

            return r;
        }

        public static decimal ExtendToXZeros(decimal d, byte zeros)
        {
            return Truncate(Decimal.Add(d, new decimal(0, 0, 0, false, zeros)), zeros);
        }
    }
}

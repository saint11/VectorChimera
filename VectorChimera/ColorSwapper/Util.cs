using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorChimera
{
    public class Util
    {
        public static int Clamp(int value, int min, int max)
        {
            int ret = value;
            if (ret > max) ret = max;
            if (ret < min) ret = min;
            return ret;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Reflection;

namespace BlackHoleLib
{
    public class DayLog
    {
        public double totalUp;
        public double totalDown;

        public DayLog( double up, double down)
        {
            totalUp = up;
            totalDown = down;
        }
    }
}

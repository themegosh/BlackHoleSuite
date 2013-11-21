using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Reflection;

namespace BlackHoleLib
{
    public class Day
    {
        public double totalUp;
        public double totalDown;

        public Day( double up, double down)
        {
            totalUp = up;
            totalDown = down;
        }
    }
}

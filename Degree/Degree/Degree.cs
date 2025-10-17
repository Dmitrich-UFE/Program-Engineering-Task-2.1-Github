using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degree
{
    public class Degree
    {
        
        public static double GetDegree(double baseint, double total)
        {
            return Math.Log(total) / Math.Log(baseint);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_lab_func
{
    public static class FuncClass
    {
        public static double GetPointY(double a, double x)
             => a * Math.Cosh(x / a);
    }
}

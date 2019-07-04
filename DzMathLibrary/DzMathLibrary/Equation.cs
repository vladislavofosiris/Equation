using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzMathLibrary
{
    public static class Equation
    {
        public static Dictionary<string, object> Parameters (double A, double B, double C)
        {
            double D = 0;
            double X1 = 0;
            double X2 = 0;
            string comment = "";
            Dictionary<string, object> result = new Dictionary<string, object>();
            D = (B*B) - (4 * A * C);
            double d = Math.Sqrt(D);

            if (D>0)
            {
                X1 = ((-1*B) + d) / (2 * A);
                X2 = ((-1*B) - d) / (2 * A);
               
            }
            else if (D<0)
            {
                comment = "Корней нет";               
            }
            else
            {
                comment = "Один корень";
                X1 = ((-1*B) + d) / (2 * A);
            }
            result.Add("D", D);
            result.Add("Comment", comment);
            result.Add("X1", X1);
            result.Add("X2", X2);
            result.Add("A", A);
            result.Add("B", B);
            result.Add("C", C);
            return result;
        }          
    }
}

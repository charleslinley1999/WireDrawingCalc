using System;

namespace CalcService
{
    public class CalcService
    {

        public Double CalculateDrawingForce(double a1, double a2, int k, double n, double r)
        {

            // section 1
            //var x = a2 * (k / (n + 1));

            // inner brackets
            //var t = a1 / a2;
            //var s = x * Math.Log(t);


            // final result
            //var p = Math.Pow(s, n + 1);

            // The full equation
            var p = a2 * (k / (n + 1)) * Math.Pow(((Math.Log(a1 / a2))),n + 1) ;

            // output is p
            return Math.Round(p,2);

            





        }

    }
}

using System;
using System.Collections.Generic;
///<summary>does vector math</summary>
class VectorMath
{
    ///<summary>calculate magnitude for 2d and 3d vectors</summary>
    public static double Magnitude(double[] vector)
    {
        if (vector.Length < 1 || vector.Length > 3)
            return -1;
        double Asqr = vector[0] * vector[0];
        double Bsqr = vector[1] *vector[1];
        if (vector.Length > 2)
        {
            double Csqr = vector[2] * vector[2];
            return (Math.Round(Math.Sqrt(Asqr+Bsqr+Csqr), 2));
        }
        return (Math.Round(Math.Sqrt(Asqr+Bsqr), 2));
    }
}
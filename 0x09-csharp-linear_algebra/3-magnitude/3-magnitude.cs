using System;
using Math;
class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        if (vector.Length() < 2 || vector.Length() > 4)
            return -1;
        double Asqr = Round(vector[1] * vector[1], 2);
        double Bsqr = Round(vector[2] *vector[2], 2);
        Console.WriteLine(Asqr);
        Console.WriteLine(Bsqr);
        return (vector[1]*vector);
    }
}
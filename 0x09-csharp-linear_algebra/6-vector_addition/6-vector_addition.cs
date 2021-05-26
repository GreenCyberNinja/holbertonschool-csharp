using System;
using System.Collections.Generic;

class VectorMath
{
    public static double[] Add(double[] vector1, double[] vector2)
    {
        double[] ans = new double[3];
        if (vector1.Length < 2 || vector1.Length > 3)
            return (ans.SetValue(-1, 0));
            
        if (vector2.Length < 2 || vector2.Length > 3)
            return (ans.SetValue(-1, 0));
        if (vector1.Length != vector2.Length)
            return (ans.SetValue(-1, 0));
        for (int i = 0; i <= vector1.Length;i++)
        {
            ans.SetValue(vector1[i]+vector2[i], i);
        }
        return ans;
    }
}
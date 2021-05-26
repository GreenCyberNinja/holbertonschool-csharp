using System;
using System.Collections.Generic;

class VectorMath
{
    public static double[] Multiply(double[] vector, double scalar)
    {
        List<double> anslist = new List<double>();
        double[] ans = new double[3];
        if (vector.Length < 2 || vector.Length > 3)
        {
            ans.SetValue(-1, 0);
            return ans;
        }
        for (int i = 0; i < vector.Length;i++)
        {
            anslist.Add(vector[i]*scalar);           
        }
        ans = anslist.ToArray();
        return ans;
    }
}
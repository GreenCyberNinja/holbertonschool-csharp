using System;
using System.Collections.Generic;

///<summary>does vector math</summary>
class VectorMath
{
    ///<summary>adds two vectors together</summary>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        List<double> anslist = new List<double>();
        double[] ans = new double[3];
        if (vector1.Length < 2 || vector1.Length > 3)
        {
            ans.SetValue(-1, 0);
            return ans;
        }   
        if (vector2.Length < 2 || vector2.Length > 3)
        {
            ans.SetValue(-1, 0);
            return ans;
        }
        if (vector1.Length != vector2.Length)
        {
            ans.SetValue(-1, 0);
            return ans;
        }
        for (int i = 0; i < vector1.Length;i++)
        {
            anslist.Add(vector1[i]+vector2[i]);           
        }
        ans = anslist.ToArray();
        return ans;
    }
}
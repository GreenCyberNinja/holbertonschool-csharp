using System;
using System.Collections.Generic;

///<summary>does vector math</summary>
class VectorMath
{
    ///<summary>dot product</summary>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        double ans = 0;
        if (vector1.Length < 2 || vector1.Length > 3)
        {
            ans = -1;
            return ans;
        }   
        if (vector2.Length < 2 || vector2.Length > 3)
        {
            ans = -1;
            return ans;
        }
        if (vector1.Length != vector2.Length)
        {
            ans = -1;
            return ans;
        }
        for (int i = 0; i < vector1.Length;i++)
        {
            ans += vector1[i] * vector2[i];           
        }
        return ans;
    }
}
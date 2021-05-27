using System;

///<summary>math done to a matrix</summary>
class MatrixMath
{
    ///<summary>multiplies matrix by scalar</summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        double[,] wrng = {{-1}};
        double[,] ans;
        int chk;

        if (matrix.Length == 4)
        {
            chk = 2;
            ans = new double[2, 2];
        }
        else
        {
            chk = 3;
            ans = new double[3,3];
        }

        if (matrix.Length < 4 || matrix.Length > 9)
            return wrng;
        for (int i=0; i < chk; i++)
        {
            for (int j=0; j < chk; j++)
            {
                ans[i,j] = matrix[i,j] * scalar;
            }
        }
        return ans;
    }
}
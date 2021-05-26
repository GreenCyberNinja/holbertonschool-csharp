using System;

///<summary>does matrix math</summary>
class MatrixMath
{
    ///<summary>adds 2 matrixes together</summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        double[,] wrng = {{-1}};
        double[,] ans;
        int chk;

        if (matrix1.Length == 4)
        {
            chk = 2;
            ans = new double[2, 2];
        }
        else
        {
            chk = 3;
            ans = new double[3,3];
        }

        if (matrix1.Length != matrix2.Length)
            return wrng;
        if (matrix1.Length < 4 || matrix1.Length > 9)
            return wrng;
        if (matrix2.Length < 4 || matrix2.Length > 9)
            return wrng;
        for (int i=0; i < chk; i++)
        {
            for (int j=0; j < chk; j++)
            {
                ans[i,j] = matrix1[i,j] + matrix2[i,j];
            }
        }
        return ans;
    }
}
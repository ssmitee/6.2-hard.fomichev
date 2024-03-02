//
using System;

class Program
{
    static void Main()
    {
        int rows = 8;
        int cols = 3;
        double[,] matrix = new double[rows, cols];
        double[] maxRowValues = new double[rows];
        double G = 0;

        for (int i = 0; i < rows; i++)
        {
            double maxVal = double.MinValue;
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = Math.Pow(-1, i + j) * Math.Log(i + Math.Pow(5, j)) + Math.Sqrt(Math.Abs(Math.Cos(i * j)));
                if (Math.Abs(matrix[i, j]) > maxVal)
                {
                    maxVal = Math.Abs(matrix[i, j]);
                }
            }
            maxRowValues[i] = maxVal;
        }
        for (int k = 1; k <= rows; k++)
        {
            double product = 1;
            for (int n = 1; n <= cols; n++)
            {
                product *= Math.Pow(n, 2) - k;
            }
            G += Math.Pow(k, 2) * product * maxRowValues[k - 1];
        }

        Console.WriteLine($"G = {G}");
    }
}
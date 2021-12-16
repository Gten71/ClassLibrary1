using System;
//5.2 базовый 13 вариант 
namespace ClassLibrary1
{
    public class Class1
    {
        static void Main(string[] args)
        {
            double[,] a = new double[7, 6]
    {
       { 1, 2, 3, 4, 5, 6 },
       { -1, -2, -3, 4, 5, 6 },
        { 7, 8, 9, -10, 1, -9 },
        { -9, -8, -7, 11, -6, -5 },
       { 5, 6, 4, -9, 1, -3 },
        { 3, 5, 3, -7, 1, -2 },
        { 2, 8, 9, 5, 1, -6 }
    };

            double[] b = new double[7];
            double sum = 0;
            double res = 0;

            for (int x = 0; x < 7; x++, b[x - 1] = sum / res, sum = 0, res = 0)
                for (int y = 0; y < 6; y++)
                    if (a[x, y] >= 0)
                    {
                        sum += a[x, y];
                        res++;
                    }
        }
    }
}

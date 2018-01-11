using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2d_array_convert_to_1d
{
    class Twodmatrix
    {
        int m, n;
        int[,] a;
        int[] b;
        Twodmatrix(int x, int y)
        {
            m = x;
            n = y;
            a = new int[m, n];
            b = new int[m * m];
        }

        public void Readmatrix()
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("a[{0}, {1}]=", i, j);
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public void printd()
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", a[i, j]);
                }
                Console.Write("\n");
            }
        }



        public static void Main(string[] args)
        {
            
        }
    }
}

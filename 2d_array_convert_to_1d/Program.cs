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
                    Console.WriteLine("a[{0},{1}]=", i, j);
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public void Printd()
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

        public void Convert()
        {
            int k = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    b[k++] = a[i, j];
                }
            }
        }

        public void Printoned()
        {
            for (int i = 0; i < m * n; i++)
            {
                Console.WriteLine("{0}\t", b[i]);
            }
        }

        public static void Main(string[] args)
        {
            Twodmatrix obj = new Twodmatrix(2, 3);
            Console.WriteLine("Enter the Elements: ");
            obj.Readmatrix();
            Console.WriteLine("\t\t Given 2-D Array(Matrix) is : ");
            obj.Printd();
            obj.Convert();
            Console.WriteLine("\t\t Converted 1-D Array is : ");
            obj.Printoned();
            Console.ReadLine();
        }
    }
}

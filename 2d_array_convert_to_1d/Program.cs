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


        public static void Main(string[] args)
        {
            
        }
    }
}

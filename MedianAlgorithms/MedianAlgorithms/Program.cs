using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedianAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] test = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
            int[] test = new int[] { 16, 4, 9, 18, 6, 1, 11, 12, 14, 8 };
            //[1,4,6,8, 9,  11,12,14,16,18]
            //int[] test = new int[] { 1, 2 };
            int[] testArr5 = new int[] { 16, 16, 8 };
            int[] testArr6 = new int[] { 250, 5, 68 };
            int[] testArr56 = testArr5.Concat(testArr6).ToArray();
            SelectMedian testSel = new SelectMedian();
            BruteForceMedian BF = new BruteForceMedian();
            Console.WriteLine(BF.getMedian(testArr6));
            Console.WriteLine(testSel.getMedian(testArr6));
            Console.ReadLine();
        }
    }
}

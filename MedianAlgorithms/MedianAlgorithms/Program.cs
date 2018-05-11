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
            SelectMedian testSel = new SelectMedian();
            BruteForceMedian BF = new BruteForceMedian();
            Console.WriteLine(BF.getMedian(test));
            Console.WriteLine(testSel.getMedian(test));
            Console.ReadLine();
        }
    }
}

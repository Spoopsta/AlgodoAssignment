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
            int[] test = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
            BruteForceMedian testBrute = new BruteForceMedian(test);
            SelectMedian testSel = new SelectMedian(test);
            Console.WriteLine("brute = " + testBrute.getMedian());
            Console.WriteLine("Select = " + testSel.getMedian());
            Console.ReadLine();
        }
    }
}

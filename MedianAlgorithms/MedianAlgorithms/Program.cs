using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedianAlgorithms
{
    class Program
    {

        public void counterCheck() {
            Random rand = new Random(301);
            string[] BFcounter = new string[100];
            string[] selCounter = new string[100];
            string[] arrLength = new string[100];

            for (int i = 0; i< 100; i++)
            {
                int[] arr = new int[rand.Next(10, 101)];

                for (int q = 0; q<arr.Length; q++)
                {
                    arr[q] = rand.Next(0, 101);
                }

                SelectMedian selM = new SelectMedian();
                BruteForceMedian BF = new BruteForceMedian();
                BF.getMedian(arr);
                selM.getMedian(arr);

                BFcounter[i] = BF.getCounter() + " ";
                selCounter[i] = selM.getCounter() + " ";
                arrLength[i] = arr.Length + " ";
            }
            System.IO.File.WriteAllLines(@"C:\Users\Nicka\Desktop\BF counter.txt", BFcounter);
            System.IO.File.WriteAllLines(@"C:\Users\Nicka\Desktop\Select counter.txt", selCounter);
            System.IO.File.WriteAllLines(@"C:\Users\Nicka\Desktop\arr length.txt", arrLength);
        }

        static void Main(string[] args)
        {
            new Program().counterCheck();
            //int[] test = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
            int[] test = new int[] { 16, 4, 9, 18, 6, 1, 11, 12, 14, 8 };
            //[1,4,6,8, 9,  11,12,14,16,18]
            //int[] test = new int[] { 1, 2 };
            int[] testArr5 = new int[] { 16, 16, 8 };
            int[] testArr6 = new int[] { 250, 5, 68 };
            int[] testArr56 = testArr5.Concat(testArr6).ToArray();
            SelectMedian testSel = new SelectMedian();
            BruteForceMedian BF = new BruteForceMedian();
            Console.WriteLine(BF.getMedian(test));
            Console.WriteLine(testSel.getMedian(test));
            Console.WriteLine(BF.getCounter());
            Console.ReadLine();
        }
    }
}

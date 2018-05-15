using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedianAlgorithms
{
    public class BruteForceMedian
    {
        double medianPosition;
        int numSmaller, numEqual;
        int median;
        int counter = 0;

        public BruteForceMedian() {
            
        }

        public int getMedian(int[] arr) {

            medianPosition = Math.Ceiling((double) arr.Length / 2);

            for (int i = 0; i < arr.Length; i++)
            {
                numSmaller = 0;
                numEqual = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        counter++;
                        numSmaller++;
                    }
                    else
                    {
                        if (arr[j] == arr[i])
                        {
                            counter += 2;
                            numEqual++;
                        }
                        else {
                            counter += 2;
                        }
                    }
                }
                counter++;
                if (numSmaller < medianPosition && medianPosition <= (numSmaller + numEqual))
                {
                    median = arr[i];
                }
            }
            return median;
        }

        public int getCounter() {
            return counter;
        }
    }
}

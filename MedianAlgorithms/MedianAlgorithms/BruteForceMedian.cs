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
                        numSmaller++;
                    }
                    else
                    {
                        if (arr[j] == arr[i])
                        {
                            numEqual++;
                        }
                    }
                }
                if (numSmaller < medianPosition && medianPosition <= (numSmaller + numEqual))
                {
                    median = arr[i];
                }
            }
            //return median;

            //Using this for now until issue is resolved
            return median;
        }
    }
}

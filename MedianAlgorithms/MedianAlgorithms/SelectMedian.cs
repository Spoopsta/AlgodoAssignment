using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedianAlgorithms
{
    public class SelectMedian
    {
        int counter = 0;

        public SelectMedian()
        {

        }

        public int getMedian(int[] arr)
        {

            if (arr.Length == 1) {
                counter++;
                return arr[0];
            }
            else {
                counter++;
                int middle = (int)Math.Floor((decimal)(arr.Length / 2));
                return Select(arr, 0, middle, arr.Length - 1);
            }
        }

        private int Select(int[] arr, int l, int m, int h)
        {
            int pos = Partition(arr, l, h);
            if (pos == m) {
                counter++;
                return arr[pos];
            }
            else if (pos > m) {
                counter++;
                return Select(arr, l, m, pos - 1);
            }
            else if (pos < m) {
                counter++;
                return Select(arr, pos + 1, m, h);
            }
            else {
                return 0;
            }
        }

        private int Partition(int[] arr, int l, int h)
        {
            int pivotVal = arr[l];
            int pivotLoc = l;
            for (int j = (l + 1); j <= h; j++)
            {
                if (arr[j] < pivotVal)
                {
                    pivotLoc++;
                    arr = Swap(arr, pivotLoc, j);
                }
                counter++;
            }
            arr = Swap(arr, l, pivotLoc);
            return pivotLoc;
        }

        private int[] Swap(int[] arr, int val1, int val2)
        {
            int temp = arr[val1];
            arr[val1] = arr[val2];
            arr[val2] = temp;

            return arr;
        }

        public int getCounter() {
            return counter;
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedianAlgorithms
{
    public class SelectMedian
    {
        int[] arr;

        int median;

        public SelectMedian() {

        }

        public int getMedian(int[] arr)
        {
            this.arr = arr;
            if (arr.Length == 1)
            {
                median = arr[0];
                return median;
            }
            else
            {
                double middle = (arr.Length / 2);
                Select(0, (int)(Math.Floor(middle)), arr.Length);
                return median;
            }
        }

        private void Select( int l, int m, int h) {
            int pos = Partition(l,h);
            if (pos == m) {
                median = arr[pos];
            }
            if (pos > m) {
                Select(l,m,pos-1);
            }
            if (pos < m) {
                Select(pos + 1, m, h);
            }
        }

        private int Partition(int l, int h) {
            int pivotVal = arr[l];
            int pivotLoc = l;
            for (int j = (l + 1); j < h; j++) {
                if (arr[j] < pivotVal) {
                    pivotLoc++;
                    Swap(pivotLoc, j);
                }
            }
            Swap(l, pivotLoc);
            return pivotLoc;
        }

        private void Swap(int val1, int val2)
        {
            int temp = arr[val1];
            arr[val1] = arr[val2];
            arr[val2] = temp;
        }

    }
}

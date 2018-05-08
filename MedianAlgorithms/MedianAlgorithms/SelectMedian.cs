using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedianAlgorithms
{
    class SelectMedian
    {
        int[] arr;

        int median;

        int pivotVal, pivotLoc;

        public SelectMedian(int[] arr) {
            this.arr = arr;
            if (arr.Length == 1){
                median = arr[0];
            }
            else {
                double middle = (arr.Length / 2);
                Select(0, (int)(Math.Floor(middle)), arr.Length);
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
            pivotVal = arr[l];
            pivotLoc = l;
            for (int j = (l + 1); j < h; j++) {
                if (arr[j] < pivotVal) {
                    pivotLoc++;
                    swap(pivotLoc, j);
                }
            }
            swap(l, pivotLoc);
            return pivotLoc;
        }

        private void swap(int val1, int val2)
        {
            int temp = arr[val1];
            arr[val1] = arr[val2];
            arr[val2] = arr[temp];
        }

        public int getMedian() {
            //return median;

            //using this until issue is resolved.
            return median - 1;
        }
    }
}

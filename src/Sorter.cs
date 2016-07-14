using System;
using System.Linq;

namespace Learn
{
    public class Sorter
    {
        public int[] BubbleSort(int[] arr)
        {
            bool swapped = true;
            while(swapped)
            {
                swapped = false;
                for(int i = 1; i < arr.Length; ++i)
                {
                    if(arr[i - 1] > arr[i])
                    {
                        swapped = true;
                        int temp = arr[i];
                        arr[i] = arr[i-1];
                        arr[i-1] = temp;
                    }
                }
            }
            return arr;
        }

        public int[] MergeSort(int[] arr)
        {
            int n = arr.Length;
            if(n == 1)
            {
                return arr;
            }
            int[] left = arr.Take(n / 2).ToArray();
            int[] right = arr.Skip(n / 2).ToArray();
            left = MergeSort(left);
            right = MergeSort(right);
            return _Merge(left,right);
        }

        private int[] _Merge(int[] left, int[] right)
        {
            int[] result = new int[left.Length + right.Length];
            bool numbersLeft = true;
            int i = 0;
            while(numbersLeft)
            {
                numbersLeft = left.Length > 0 && right.Length > 0;
                if(left.Length == 0)
                {
                    foreach(var n in right)
                    {
                        result[i++] = n;
                    }
                } else if(right.Length == 0)
                {
                    foreach(var n in left)
                    {
                        result[i++] = n;
                    }
                } else if(right[0] < left[0]){
                    result[i++] = right[0];
                    right = right.Skip(1).ToArray();
                } else if(left[0] <= right[0])
                {
                    result[i++] = left[0];
                    left = left.Skip(1).ToArray();
                }
            }
            return result;
        }
        
        public int[] SelectionSort(int[] arr)
        {
            int[] result = new int[arr.Length];
            int resultIndex = 0;
            while(arr.Length > 0)
            {
                int min = int.MaxValue;
                int minIndex = -1;
                for(int i = 0; i < arr.Length; ++i)
                {
                    if(arr[i] < min)
                    {
                        min = arr[i];
                        minIndex = i;
                    }
                }

                result[resultIndex++] = min;
                arr = arr.Where((src, index) => index != minIndex).ToArray();
            }
            return result;
        }
    }

}


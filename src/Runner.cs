using System;
using System.Linq;

namespace Learn
{
    public class Runner 
    {
        public static void Main(string[] args)
        {
            int[] y = new int[] {4,5,2,1,6,2,8,3,4,1,6,3,2,9,6,5,4,3,9,8,10,6};
            int[] x = (new Sorter()).MergeSort(y);
            Console.WriteLine(string.Join(",",x));
        }
    }

}

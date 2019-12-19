using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.MIT
{
    /// <summary>
    /// Find a Peak if it exist where a[i] is  peak if and only if a[i] >= a[i+1] and a[i]>=a[i-1]
    /// Eg [1,2,3,4,5,6,7,8,9] . Peak is 9
    /// 
    /// </summary>
    public class PeakFinder1DArray
    {
        public int FindPeakIfItExist(int[] arr, int start, int end)
        {
            if(start == end)
            {
                return arr[start];
            }

            

            var mid = (start + end )/ 2;
            if (mid == 0)
            {
                return arr[mid];
            }
            if (arr[mid] < arr[mid + 1])
            {
                return FindPeakIfItExist(arr, mid + 1, end);
            }
            else if (arr[mid] < arr[mid - 1])
            {
                return FindPeakIfItExist(arr, start, mid-1 );
            }
            else
            {
                return arr[mid];
            }

        }
       
    }
}

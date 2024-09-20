using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.NovikovAA.Sprint0.Task7.V0.Lib
{
    public class DataService
    {
        public static object AdditionArrays(int[] nums1, int[] nums2)
        {
        
            int[] resultArray = new int[nums1.Length];
            for (int i = 0; i < nums1.Length; i++)
                {
                    resultArray[i] = nums1[i] + nums2[i];
                }
                return resultArray;
        
        }
    }
}

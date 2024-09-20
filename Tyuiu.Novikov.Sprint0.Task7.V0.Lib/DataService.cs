using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.NovikovAA.Sprint0.Task7.V0.Lib
{
    public class DataService
    {
        public static int[] AdditionArrays(int[] nums1, int[] nums2)
        {
            if (nums1.Length == nums2.Length)
            {
                int[] resultArray = new int[nums1.Length];
                for (int i = 0; i < nums1.Length; i++)
                {
                    resultArray[i] = nums1[i] + nums2[i];
                }
                return resultArray;
            }
            else
            {
                Console.WriteLine("Массивы разной длинны");
                return null;
            }
        }
    }
}

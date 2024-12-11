using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dopka
{
    internal class Program
    {
        static public int[] Summ( int[] nums, int sum)
        {
            int[] a = new int[] {0,0 };
            for (int i =0; i < nums.Length-1;i++)
            {
                for (int j = i+1; j<nums.Length;j++)
                {
                    if (nums[i]+nums[j] == sum)
                    {
                        a[0] = nums[i];
                        a[1] = nums[j];
                        break;
                    }
                }
            }
            return a;
        }
        static public int[] Days(int[] nums)
        {
            int[] a = new int[nums.Length];
            int k = 1;
            for (int i = 0;i<nums.Length-1;i++)
            {
                k = 1;
                for (int j = i+1;j<nums.Length;j++)
                {
                    if (nums[j] > nums[i])
                    {
                        a[i] = k;
                        break;
                    }
                    k++;
                }
            }
            return a;
        }
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 3,15,16,241,15,12,51,3,613,56 };
            foreach (var b in Summ(a,57))
            {
                Console.Write(b+" ");
            }
            Console.WriteLine();
            foreach (var b in Days(a))
            {
                Console.Write(b + " ");
            }
        }

    }
}

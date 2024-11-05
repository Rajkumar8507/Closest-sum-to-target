using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -1, 2, 1, -4 }; 
            int target = 1;

            Program program = new Program();
            int result = program.ThreeSumClosest(nums, target);

            Console.WriteLine($"The closest sum to {target} is {result}");

        }
        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            int closestSum = nums[0] + nums[1] + nums[2];

            for (int i = 0; i < nums.Length - 2; i++)
            {
                int left = i + 1;
                int right = nums.Length - 1;

                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];

                    if (Math.Abs(target - sum) < Math.Abs(target - closestSum))
                    {
                        closestSum = sum;
                    }

                    if (sum > target)
                    {
                        right--;
                    }
                    else if (sum < target)
                    {
                        left++;
                    }
                    else
                    {
                        return sum;
                    }
                }
            }

            return closestSum;
        }
    }





}

    

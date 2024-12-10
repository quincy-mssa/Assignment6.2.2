using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment6._2._2

    //Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].
    //The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
    //You must write an algorithm that runs in O(n) time and without using the division operation.
{
    //PSEUDO CODE
    //-----------//function Product(nums):
    //n = length(nums)  // Length of the input array
    //    answer = array of size n initialized to 1

    //    // Step 1: Calculate the prefix product for each index
    //    prefix = 1
    //    for i from 0 to n - 1:
    //        answer[i] = prefix
    //        prefix = prefix * nums[i]

    //    // Step 2: Calculate the suffix product and multiply with prefix product
    //    suffix = 1
    //    for i from n - 1 to 0 step - 1:
    //        answer[i] = answer[i] * suffix
    //        suffix = suffix * nums[i]

    //    return answer---------------
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4 };
            int[] result = Product(nums);

            //print the result
            Console.WriteLine(string.Join(", ", result));
        }

        public static int[] Product(int[] nums)
        {
            int n = nums.Length;
            int[] answer = new int[n];

            //calculate the prefix product
            int prefix = 1;
            for (int i = 0; i < n; i++)
            {
                answer[i] = prefix;
                prefix *= nums[i];
            }

            //calculate the suffix product and combine with prefix product
            int suffix = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                answer[i] *= suffix;
                suffix *= nums[i];
            }

            return answer;
        }
    }
}



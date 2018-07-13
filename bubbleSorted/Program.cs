using System;

namespace bubbleSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            //array of integers that are not sorted
            int[] nums = { 5, 10, 3, 2, 4, 7, 6 };

            //output the unsorted array to the console
            Console.WriteLine("before:{5,10,3,2,4,7,6} ");

            //use this to know to stop the sorting routine
            bool swapped;

            //here we use a do loop but could have used a for a while
            do
            {
                //swapped to false so that we can ensure at least one pass on the array
                swapped = false;

                //a for loop to iterate over the array
                for(int i =0; i<nums.Length - 1;i++)
                {
                    // here we use the i for the position in the array
                    // So i is the first value to compare and i + 1 compares the adjacent value
                    // Once i is incremented at the end of this loop, we compare the next two sets of values, etc.
                    if (nums[i] > nums[i + 1])
                    {
                        // swap routine.  Could be a separate method as well but is used inline for simplicity here
                        // temp is used to hold the right value in the comparison so we don't lose it.  That value will be replaced in the next step
                        int temp = nums[i + 1];

                        //here we replace the right value with the larger value that was on the left. 
                        nums[i + 1] = nums[i];

                        //now we assign the value that is in temp, the samller value. to the location that was just vaacated by larger number
                        nums[i] = temp;

                        //indicate that we did a swap, which meand we need to continue checking the remaining values.
                        swapped = true;
                    }
                }
            } while (swapped == true);

            //output the sorted array to the console
            Console.WriteLine("after: ");

            for( int i =0; i< nums.Length; i++)
            {
                Console.Write("{0}, ", nums[i]);
            }

            //use readline in the event application
            Console.ReadLine();
        }
    }
}

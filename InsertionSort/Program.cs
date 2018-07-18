using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare an integer array that is not sorted
            int[] arr = { 7, 8, 4, 6, 2, 1 };

            //output the values of the array to the console
            Console.WriteLine(" before: {7, 8, 4, 6, 2, 1}");

            // declare variable for th insertion values
            int newValue;

            //the outer loop allows us to iterate over the complete array that we will use for sorting
            for( int i = 0; i< arr.Length; i++)
            {
                // set newValue equal to the second element in the array
                // we don't start at the first element because it has no preceding value
                // which means we can't move it any further forward in the array
                newValue = arr[i];

                // Also set the start of our inner loop to the same value as i
                int j = i;

                // This loop will check the value of j to ensure we have not reached the end of the iteration (j = 0)
                // but also checks to see if the value preceding the current value is larger.
                // If it is, we "swap" the value before this one, decrement j, and then test against the next value
                // This continues until we run out of numbers in the array (j = 0) or there are no more values larger than
                // the current number (newValue) to it's left (preceding it).
                while (j > 0 && arr[j - 1] > newValue)
                {
                    arr[j] = arr[j - 1];
                    j--;
                }

                arr[j] = newValue;

            }

            Console.Write("array after sort: ");
            foreach( int val in arr)
            {
                Console.Write(val + ",");
            }

            Console.WriteLine();

        }
    }
}

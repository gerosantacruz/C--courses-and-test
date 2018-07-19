using System;

namespace Tut3Test
{
    class Program
    {
        static void Main(string[] args)
        {

            Array.Sort(a);
            int kth = 1;
            int smallest = a[0];
            foreach (int num in a)
            {
                if (num != smallest)
                {
                    kth++;
                }
                if (kth == k)
                {
                    return num;
                }
            }
            // return -1 if not found
            return -1;


        }
    }
}

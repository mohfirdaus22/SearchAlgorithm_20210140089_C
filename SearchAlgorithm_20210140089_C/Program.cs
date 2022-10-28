using System;

namespace SearchAlgorithm
{

    class Program
    {
        //Array to be searched
        int[] arr = new int[20];
        //Number of element in the array 
        int n;
        //get number of element to store in the array
        int i;

        public void input()
        {
            while (true)
            {
                Console.Write(" Enter the number of the element in array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20))
                    break;
                else
                    Console.WriteLine("\n Array should have minimum 1 and maximum 20 element. \ n");

            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    Console.WriteLine("\n Array should have minimum 1 and maximum 20 element. \n");
            }
            // Accept array element 
            Console.WriteLine("");
            Console.WriteLine("-------------------");
            Console.WriteLine(" Enter the element ");
            Console.WriteLine("-------------------");
            for ( i = 0; i< n; i++ )
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }
        public void BinarySearch()
        {
            char ch;
            do
            {
                //accept the number to be searched
                Console.Write("\n Enter element want to you search : ");
                int item = Convert.ToInt32(Console.ReadLine());

                //apply binary search
                int lowerbound = 0;
                int upperbound = n - 1;

                //obtain the index of the elemnt in the array
                int mid = (lowerbound + upperbound) / 2;
                int ctr = 1;

                // loop to search for the element in the array
                while ((item != arr[mid]) && (lowerbound <= upperbound))
                {
                    if (item > arr[mid])
                        lowerbound = mid + 1;
                    else
                        upperbound = mid - 1;
                    mid = (lowerbound + upperbound) / 2;
                    ctr++;
                }
                if (item == arr[mid])
                    Console.WriteLine("\n" + item.ToString() + "found at position " + (mid + 1).ToString());
                else
                    Console.WriteLine("\n" + item.ToString() + "not found in the array\n");
                Console.WriteLine("\n Number of comparasion :" + ctr);

                Console.Write("\n Continue Search (y/n) :");
                ch = char.Parse(Console.ReadLine());

            } while ((ch == 'y') || (ch == 'Y'));
        }
        public void LinearSearch()
        {
            char ch;
            //search number of comparation
            int ctr;
            do
            {
                //accept the number to be searched
                Console.Write("\n Enter the element you want to search : ");
                int item = Convert.ToInt32(Console.ReadLine());

                ctr = 0;
                for (i = 0; i < n; i++)
                {
                    ctr++;
                    if (arr[i] == item)
                    {
                        Console.WriteLine("\n" + item.ToString() + "found st position" + (i + 1).ToString());
                        break;
                    }
                }
                if (i == n)
                    Console.WriteLine("\n" + item.ToString() + "not found in the array");
                Console.WriteLine("\n Number of comparison : " + ctr);
                Console.Write("\n Continue search (y/n): ");
                    ch = char.Parse(Console.ReadLine());

            } while ((ch == 'y') || (ch == 'Y'));
        }
        static void Main(string[]args)
        {
            Program myList = new Program();
            int pilihanmenu;
            char ch;

            Console.WriteLine(" Menu Option ");
            Console.WriteLine(" =============== ");
            Console.WriteLine(" 1.Linear Search ");
            Console.WriteLine(" 2.Binary Search ");
            Console.WriteLine(" 3.Exit ");
            Console.WriteLine(" Enter Your Choice  (1,2,3) : ");
            pilihanmenu = Convert.ToInt32(Console.ReadLine());

        switch (pilihanmenu)
            {
                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("-------------------");
                    Console.WriteLine("Linear Search");
                    Console.WriteLine("-------------------");
                    myList.input();
                    myList.LinearSearch();
                    break;

                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("-------------------");
                    Console.WriteLine("Binary Search");
                    Console.WriteLine("-------------------");
                    myList.input();
                    myList.BinarySearch();
                    break ;
                case 3:
                    Console.WriteLine("Exit.");
                    break;
                default:
                    Console.WriteLine("Error");
                    break ;
            }
        }
    }
}
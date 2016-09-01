using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_sorting
{
    class Program
    {
        static void Main(string[] arguments)
        {
            Random rnd = new Random();
            // initializing array of ints
            int[] randomlist = new int[10];
            // putting a random number in a box (box is randomlist)
            for (int i = 0; i < 10; i++)
            {
                randomlist[i] = rnd.Next(0, 100);
            }

            Print(randomlist);
            Console.WriteLine();
            Print(SelectionSort(randomlist));

            // waits for the user to push any key to end the program
            Console.ReadKey();
        }

        private static int[] BubbleSort(int[] unsortedList)
        {
            // reset loop
            for (int i = 0; i < unsortedList.Length - 1; i++)
            {
                // comparing & swapping loop
                for (int j = 0; j < unsortedList.Length - 1 - i; j++)
                {
                    int firstNumber = unsortedList[j];
                    int secondNumber = unsortedList[j + 1];
                    if (firstNumber > secondNumber)
                    {
                        int temp = unsortedList[j];
                        unsortedList[j] = unsortedList[j + 1];
                        unsortedList[j + 1] = temp;
                    }
                }   
            }
            return unsortedList;
        }

        private static int[] SelectionSort(int[] unsortedList)
        {

            // reset loop
            for (int j = 0; j < unsortedList.Length; j++)
            {
                int minimumNumber = unsortedList[j];
                int minimumNumberLocation = j;
                // finding our minimum number & location
                for (int i = 1 + j; i < unsortedList.Length; i++)
                {
                    if (unsortedList[i] < minimumNumber)
                    {
                        minimumNumber = unsortedList[i];
                        minimumNumberLocation = i;

                    }
                }
                // swapping
                int oldMinimumNumber = unsortedList[j];
                unsortedList[j] = minimumNumber;
                unsortedList[minimumNumberLocation] = oldMinimumNumber;
            }

            return unsortedList;
            
        }

        private static void Print(int[] numbersToPrint)
        {
            // put the numbers in the boxes on the screen
            for (int i = 0; i < numbersToPrint.Length; i++)
            {
                Console.WriteLine(numbersToPrint[i]);
            }
        }
    }
}

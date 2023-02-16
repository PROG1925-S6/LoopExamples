using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LoopExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.  Create a loop that displays all values inclusive between 1-5.

            for(int i = 1; i <= 5; i++)
            {
                Console.Write($"{i} ");
            }

            //2.  Create a loop that displays all values inclusive between 10-6.
            Console.WriteLine();

            for(int i = 10; i >= 6; i--)
            {
                Console.Write($"{i} ");
            }

            //3.  Create a loop that displays even numbers inclusive between 2 and 10
            Console.WriteLine();

            for (int i = 2; i <= 10; i = i + 2)  // i += 2
            {
                Console.Write($"{i} ");
            }

            //4.  Create a loop that displays the sum of all numbers inclusive 
            //    between 1 and 10. The answers should be 55.
            Console.WriteLine();

            int sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                sum = sum + i;                
            }

            Console.Write($"{sum} ");

            //5. Create a loop that displays all leap years inclusive between 
            //   1990 and 2010. The output should be: 1992 1996 2000 2004 2008   
            Console.WriteLine();    

            for(int i = 1990; i <= 2010; i++)
            {
                if (i % 4 == 0)
                {
                    Console.Write($"{i} ");
                }
            }

            //1. counting to 10 with a while loop
            Console.WriteLine();

            int counter = 1;

            while(counter <= 10)
            {
                Console.Write($"{counter} ");
                counter++;
            }

            //2. counting program
            Console.WriteLine();

            bool keepGoing = true;
            int loopCounter = 0;

            while (keepGoing) 
            {
                Console.Write("Do you want to keep counting? (y/n)");
                string userAnswer = Console.ReadLine(); 

                if(userAnswer == "y")
                {
                    loopCounter++;
                    Console.Write($"{loopCounter} ");
                }
                else if (userAnswer== "n")
                {
                    keepGoing = false;
                }
                else 
                {
                    Console.WriteLine("ERROR: only y or n");
                }
                
            }

            Console.WriteLine("That was fun");

            //1. Counting with do while
            Console.WriteLine();

            int startingNumber = 5;

            do
            {
                Console.Write($"{startingNumber} ");
                startingNumber++;
            } while (startingNumber <= 10);


            //2. Create a menu system.
            Console.WriteLine();

            string choice;

            do
            {
                Console.WriteLine("Please select an option");
                Console.WriteLine("1. Display values between 1 and 5");
                Console.WriteLine("2. Find Area of a Rectangle");
                Console.WriteLine("3. Exit");
                choice = Console.ReadLine();    

                if (choice =="1")
                {
                    for(int i = 1; i <= 5; i++)
                    {
                        Console.Write($"{i} ");
                    }
                }
                else if (choice == "2")
                {
                    int length, width, area;

                    Console.Write("Enter a length: ");
                    length = Convert.ToInt16(Console.ReadLine());

                    Console.Write("Enter a width: ");
                    width = Convert.ToInt16(Console.ReadLine());

                    area = RectangleArea(length, width);
                    Console.WriteLine($"The area is : {area} units^2");
                }

                Console.WriteLine();

            } while (choice != "3");

            Console.ReadKey();
        }

        /// <summary>
        /// Calculate the area of a rectangle
        /// </summary>
        /// <param name="length">The length of the rectangle</param>
        /// <param name="width">The width of the rectangle</param>
        /// <returns>returns the area as an integer</returns>
        static int RectangleArea(int length, int width)
        {
            int area = length * width;
            return area;
        }
    }
}

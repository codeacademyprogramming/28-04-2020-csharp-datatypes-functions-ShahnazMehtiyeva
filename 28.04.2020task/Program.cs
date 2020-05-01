using System;

namespace _28._04._2020task
{
    class Program
    {
        static void Main(string[] args)
        {

            //Task1
            //GetInput();


            //Task2
            //GetInput();


            // Task3 
            GetInput();
        }

        //Task1 started

        //static void GetInput()
        //{
        //    Console.WriteLine("Enter number");
        //    int.TryParse(Console.ReadLine(), out int Number);
        //    CalcDigitOfNumber(Number);
        //}

        //static void CalcDigitOfNumber(int number)
        //{
        //    int number2 = number;
        //    int count = 0;
        //    while (number > 0)
        //    {
        //        count++;
        //        number /= 10;
        //    }
        //    Console.WriteLine($"The number of digits of {number2}  is {count}");
        //}

        //Task1 ended




        //Task2 started

        //static void GetInput()
        //{
        //    Console.WriteLine("Enter number");
        //    int.TryParse(Console.ReadLine(), out int Number);
        //    PrimeOrNot(Number);
        //}


        //static void PrimeOrNot(int number)
        //{
        //    int count = 0;
        //    for(int i =1; i <=number; i++)
        //    {
        //        if (number % i == 0)
        //        {
        //            count++;
        //        }
        //    }

        //    if (count == 2)
        //    {
        //        Console.WriteLine($"The number {number} is prime");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"The number {number} is not prime");
        //    }
        //}

        //Task2 ended



        //Task3 started

        static void GetInput()
        {
            Console.WriteLine("Enter number");
            int.TryParse(Console.ReadLine(), out int Number);
            GetSeason(Number);
        }

        static void GetSeason(int number)
        {

            switch (number)
            {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine("Winter");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Spring");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Summer");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Autumn");
                    break;
                default:
                    Console.WriteLine("There is no such month");
                    break;
            }

        }

    }
}




using System;

namespace StringNotNull
{
    class Program
    {
        static void Main(string[] args)
        {

            string text1 = Read();

            if (string.IsNullOrWhiteSpace(text1))
            {
                string text2 = Read();

                if (string.IsNullOrWhiteSpace(text2))
                {
                    string text3=Read();

                    if (string.IsNullOrWhiteSpace(text3))
                    {
                        Console.WriteLine("Nu am continut!");
                    }
                    else
                    {
                        Console.WriteLine(text3);
                    }
                }
                else
                {
                    Console.WriteLine(text2);
                }
            }
            else
            {
                Console.WriteLine(text1);
            }


            //ReadANonNullString();
        }
        private static string Read()
        {
            Console.WriteLine("Please enter a phrase");
            string input = Console.ReadLine();
            return input;
        }

        /*
         * SAU
         * 
         public static void ReadANonNullString()
        {
            string input1;
            int i = 0;
            do
            {
                Console.WriteLine("Please enter a phrase");
                input1 = Console.ReadLine();

                switch (input1)
                {
                    case null:
                    case " ":
                    case "":
                        break;
                    default:
                        Console.WriteLine(input1);
                        return;
                }

                i++;
            } while (i<3);
          
            Console.WriteLine("Nu am continut!");

        }
         */
    }
}

using System;

namespace StringNotNull
{
    class Program
    {
        static void Main(string[] args)
        {

            string text1 = Read();
            string text2 = Read();
            string text3 = Read();

            string result = string.IsNullOrWhiteSpace(text1) ? text1 : string.IsNullOrWhiteSpace(text2) ? text2 : string.IsNullOrWhiteSpace(text3) ? text3 : "Nu am continut";
            Console.WriteLine($"The written text is: {result}");

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

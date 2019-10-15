using System;

namespace Day_1___Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
                Console.WriteLine("Welcome to the Grand Circus Room Detail Generator!");
                Console.WriteLine("");

            //declaring varible for while loop
            String yesNo;
            bool doOver = true;
            while (doOver == true)
            {
                //take in user data
                //prompt
                Console.Write("Enter Length: ");
                //input
                String roomLength = Console.ReadLine();
                //prompt
                Console.Write("Enter Width: ");
                //input
                String roomWidth = Console.ReadLine();
                //prompt
                Console.Write("Enter Height: ");
                //input
                String roomHeight = Console.ReadLine();

                //convert strings to double
                double length = double.Parse(roomLength);
                double width = double.Parse(roomWidth);
                double height = double.Parse(roomHeight);

                //calculate area, perimeter & volume
                double area = length * width;
                double perimeter = length + length + width + width;
                double volume = length * height * width;

                //ouput
                Console.WriteLine("Area: {0}", area);
                Console.WriteLine("Perimeter: {0}", perimeter);
                Console.WriteLine("Volume: {0}", volume);

                Console.WriteLine("");

                Console.Write("Continue? (y/n) ");
                yesNo = Console.ReadLine();

                if (yesNo.Equals("y") || yesNo.Equals("Y"))
                {
                    doOver = true;
                }
                else
                {
                    doOver = false;
                }
                Console.WriteLine("");
            }
            //} 
        }
    }
}

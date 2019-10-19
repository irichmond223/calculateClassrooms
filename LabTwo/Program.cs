using System;

namespace LabTwo
{
    class Program
    {
        static void Main(string[] args)
        {

            bool playAgain = true;
            
            Console.WriteLine("Welcome to Grand Circus’ Room Detail Generator!");

            while (playAgain)
            {
                Console.WriteLine("Enter Length: ");
                double lengthNumInput = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Width: ");
                double widthNumInput = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Height: ");
                double heightNumInput = double.Parse(Console.ReadLine());

                Console.WriteLine("Area: ");

                double area = lengthNumInput * widthNumInput;
                Console.WriteLine(area);

                Console.WriteLine("Perimeter: ");
                double perimeter = (lengthNumInput) * 2 + (widthNumInput * 2);
                Console.WriteLine(perimeter);

                Console.WriteLine("Volume: ");
                double volume = lengthNumInput * widthNumInput * heightNumInput;
                Console.WriteLine(volume);
                
            

            Console.WriteLine("Continue (y/n): ");
            string stringUserInput = Console.ReadLine().ToLower();
            char charUserInput;




                if (char.TryParse(stringUserInput, out charUserInput))
                {

                    if (charUserInput == 'y' || charUserInput == 'Y')
                    {
                        playAgain = true;

                    }
                    else if (charUserInput == 'n' || charUserInput == 'N')
                    {
                        Console.WriteLine("Goodbye.");
                        playAgain = false;
                    }
                    else
                    {
                        Console.WriteLine($"You entered:{charUserInput}.Try again.");
                        Console.WriteLine("Goodbye.");
                        playAgain = false;

                    }
                }
            }
        }
    }
}

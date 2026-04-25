using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CBasics
{
    internal class OOP_Interface_Exception_TryCatch
    {
        static void Main()
        {
            // ============ Interface ============
            Console.WriteLine("Enter Number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            ICalculator calculator = new Calculator();
            calculator.Add(num1, num2);

            // ============ task 1 ============
            string[] lines = File.ReadAllLines("data.txt");
            try
            {
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }

                File.WriteAllText("data.txt", "Hello World");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"File not found: {ex.Message}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"IO error: {ex.Message}");
            }

            // ============ task 2 ============
            string fileName = "profile_summary.txt";

            Console.WriteLine("--- File Content ---");
            string[] MyInfo = File.ReadAllLines(fileName);

            foreach (string line in MyInfo)
            {
                Console.WriteLine(line);
            }

            string fullText = File.ReadAllText(fileName);
            int charCount = Regex.Matches(fullText, @"\S").Count; // Count non-space characters
            int wordCount = Regex.Matches(fullText, @"\w+").Count; // Count words 

            Console.WriteLine("\n--- Statistics ---");
            Console.WriteLine($"Total characters (no spaces): {charCount}");
            Console.WriteLine($"Total words: {wordCount}");

        }

        // Task for Interface
        interface ICalculator
        {
            int Add(int a, int b);
        }

        public class Calculator : ICalculator
        {
            public int Add(int a, int b)
            {
                try
                {
                    Console.WriteLine($"The sum of {a} and {b} is: {a + b}");
                    return a + b;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                    return 0;
                }
            }
        }



    }
}

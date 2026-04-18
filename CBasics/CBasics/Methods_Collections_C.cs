using System;
using System.Linq;

namespace CBasics
{
    internal class Methods_Collections_C
    {
        static void Main()
        {
            // ==  Task 1 – Method ==
            CalculateAverage(10, 20, 30);

            // ============= Task 2 – List =============
            Console.WriteLine("\n======== Task 2: List ========");
            List<string> students = new List<string>();
            students.Add("heba");
            students.Add("laila");
            students.Add("leen");
            students.Add("lujain");
            students.Add("hanan");

            foreach (string student in students)
            {
                Console.WriteLine(student);
            }

            // ============= Task 3 – Dictionary =============
            Console.WriteLine("\n======== Task 3: Dictionary ========");
            Dictionary<string, int> Users = new Dictionary<string, int>();
            Users.Add("Heba", 1);
            Users.Add("Laila", 2);
            Users.Add("Hanan", 3);

            foreach (KeyValuePair<string, int> user in Users)
            {
                Console.WriteLine($"Username: {user.Key}, ID: {user.Value}");
            }

            // ============= Task 4 – LINQ =============
            Console.WriteLine("\n======== Task 4: LINQ ========");
            int[] numbers = { 5, 10, 15, 20, 25, 30 };
            string[] names = { "Ahmad", "Ali", "Sara", "Mona", "Omar" };

            // ===== Q1: Filter Numbers =====
            Console.WriteLine("======== Q1 ========");
            var result = numbers.Where(n => n > 15);
            foreach (int num in result)
            {
                Console.WriteLine(num);
            }

            // ===== Q2: Even Numbers =====
            Console.WriteLine("\n======== Q2 ========");
            var evenNumbers = numbers.Where(n => n % 2 == 0);
            foreach (int num in evenNumbers)
            {
                Console.WriteLine(num);
            }

            // ===== Q3: Sorting =====
            Console.WriteLine("\n======== Q3 ========");
            var sortedAscending = numbers.OrderBy(n => n); // ascending
            var sortedDescending = numbers.OrderByDescending(n => n); // descending 

            Console.WriteLine("=== Ascending ===");
            foreach (int num in sortedAscending)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("\n=== Descending ===");
            foreach (int num in sortedDescending)
            {
                Console.WriteLine(num);
            }

            // ===== Q4: Names Filtering =====
            Console.WriteLine("\n======== Q4 ========");
            var filteredNames = names.Where(name => name.StartsWith("A"));
            foreach (string name in filteredNames)
            {
                Console.WriteLine(name);
            }

            // ===== Q5: First Value =====
            Console.WriteLine("\n======== Q5 ========");
            var first = numbers.FirstOrDefault(n => n > 10);

            Console.WriteLine($"First number > 10 is: {first}");

            // ===== Bonus =====
            Console.WriteLine("\n======== Bonus ========");
            int[] multipliedArray = numbers.Select(n => n * 2).ToArray();

            foreach (int num in multipliedArray)
            {
                Console.WriteLine(num);
            }

            // ======  Task 5 – Methods ======
            Console.WriteLine("\n======== Task 5: Methods ========");
            Welcome();
            Greeting("Hanan");
            Age(27);
            Sum(23, 25);
            int[] arr = { 1, 2, 3, 4, 5 };
            Array(arr);
        }

        // ======  Task 1 – Method ======
        static void CalculateAverage(int a, int b, int c)
        {
            int sum = a + b + c;
            double average = (double)sum / 3;
            Console.WriteLine("======== Task 1: Method ========");
            Console.WriteLine($"The average of {a}, {b}, and {c} is: {average}");
        }

        // ======  Task 5 – Methods ======
        // ===== Q1 =====
        static void Welcome()
        {
            Console.WriteLine("======== Q1 ========");
            Console.WriteLine("Welcome!");
        }

        static void Greeting(string name)
        {
            Console.WriteLine("\n======== Q2 ========");
            Console.WriteLine($"Hello, {name}!");
        }

        static void Age(int age = 23)
        {
            Console.WriteLine("\n======== Q3 ========");
            Console.WriteLine($"Your age is: {age}");
        }

        static void Sum(int a, int b)
        {
            Console.WriteLine("\n======== Q4 ========");
            int sum = a + b;
            Console.WriteLine($"The sum of {a} and {b} is: {sum}");
        }

        static void Array(int[] arr)
        {
            Console.WriteLine("\n======== Q5 ========");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}

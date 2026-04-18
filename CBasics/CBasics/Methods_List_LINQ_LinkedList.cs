using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBasics
{
    internal class Methods_List_LINQ_LinkedList
    {
        static void Main()
        {
            // ============= Section 1 – List =============
            Console.WriteLine("======== Section 1: List ========");
            // ============= Task 1  =============
            Console.WriteLine("\n======== Task 1: Even Numbers Filter ========");
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> evenNumbers = new List<int>(numbers.Where(n => n % 2 == 0));
            foreach (int num in evenNumbers)
            {
                Console.WriteLine(num);
            }

            // ============= Task 2 – Remove Duplicates =============
            Console.WriteLine("\n======== Task 2: Remove Duplicates (Using Distinct) ========");
            List<int> Duplicates = new List<int> { 1, 2, 2, 3, 4, 4, 5 };

            List<int> uniqueNumber = new List<int>(Duplicates.Distinct());
            foreach (int num in uniqueNumber)
            {
                Console.Write(num + ",");
            }

            // ============= Task 2 – Remove Duplicates (another way using conatin) =============
            Console.WriteLine("\n\n======== Task 2: Remove Duplicates (using Contain) ========");
            List<int> uniqueNumbers = new List<int>();

            foreach (int num in Duplicates)
            {
                if (!uniqueNumbers.Contains(num))
                {
                    uniqueNumbers.Add(num);
                }
            }

            foreach (int num in uniqueNumbers)
            {
                Console.Write(num + ",");
            }

            // ============= Task 3  =============
            Console.WriteLine("\n\n======== Task 3: Find Maximum Number ========");
            List<int> numbers3 = new List<int> { 5, 10, 15, 20, 25 };
            int maxNumber = numbers3.Max();
            Console.WriteLine("Maximum Number: " + maxNumber);

            // ============= Task 4  =============
            Console.WriteLine("\n======== Task 4: Reverse List ========");
            List<int> numbers4 = new List<int> { 1, 2, 3, 4, 5 };
            numbers4.Reverse();
            foreach (int num in numbers4)
            {
                Console.WriteLine(num);
            }

            // ============= Task 5  =============
            Console.WriteLine("\n======== Task5: Count Numbers Greater Than X ========");
            List<int> numbers5 = new List<int> { 1, 5, 10, 15, 20, 25 };
            int x = 10;
            int countX = numbers5.Count(n => n > x);
            Console.WriteLine($"Count of numbers greater than {x}: {countX}");


            // ============= Section 2: Dictionary =============
            Console.WriteLine("======== Section 2: Dictionary ========");
            // ============= Task 6: Student Scores  =============
            Console.WriteLine("\n======== Task 6: Student Scores ========");
            Dictionary<string, int> Students = new Dictionary<string, int>
            {
                { "Amal", 64 }, // key: Amal, value: 64
                { "Nour", 90 },
                { "Raghad", 51 },
                { "Yara", 35 },
                { "Sara", 40 },
                { "Laila", 88   },
                { "Hanan", 92   },
                { "Lujain", 78  },
                { "Leen", 82    },
                { "Heba", 89 }
            };

            var filter6 = Students.Where(s => s.Value > 80);
            foreach (var student in filter6)
            {
                Console.WriteLine($"{student.Key}: {student.Value}");
            }

            // ============= Task 7: Search by Key  =============
            Console.WriteLine("\n======== Task 7: Search by Key ========");
            Console.Write("Enter student name to search: ");
            string searchKey = "Amal";//Console.ReadLine();

            if (Students.ContainsKey(searchKey))
            {
                Console.WriteLine($"{searchKey}: {Students[searchKey]}");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }

            // ============= Task 8: Sum of Values  =============
            Console.WriteLine("\n======== Task 8: Sum of Values ========");
            int sumScores = Students.Values.Sum();
            Console.WriteLine("Sum of Scores: " + sumScores);

            // ============= Task 9: Remove Low Scores  =============
            Console.WriteLine("\n======== Task 9: Remove Low Scores ========");
            var lowScoreStudents = Students.Where(s => s.Value < 50).Select(s => s.Key); // Select [key => (student name)] from Students where [value => (Score)] < 50;
            foreach (var student in lowScoreStudents)
            {
                Students.Remove(student);
            }

            foreach (var student in Students)
            {
                Console.WriteLine($"{student.Key}: {student.Value}");
            }

            // ============= Task 10: Highest Score  =============
            Console.WriteLine("\n======== Task 10: Highest Score ========");
            var highestScoreStudent = Students.OrderByDescending(s => s.Value).FirstOrDefault(); // SELECT TOP 1 Key, Value FROM Students ORDER BY Value DESC;
            Console.WriteLine($"{highestScoreStudent.Key}: {highestScoreStudent.Value}");

            // ============= Section 3: LinkedList =============
            Console.WriteLine("======== Section 3: LinkedList ========");
            // ============= Task 11: Add Elements  =============
            Console.WriteLine("\n======== Task 11: Add Elements ========");
            LinkedList<string> linkedList = new LinkedList<string>();
            linkedList.AddFirst("Services");
            linkedList.AddLast("About");
            linkedList.AddFirst("Home");
            linkedList.AddLast("Contact");

            Console.WriteLine("LinkedList Elements:");

            foreach (string item in linkedList)
            {
                Console.WriteLine(" - " + item);
            }

            // ============= Task 12: Remove Middle Element  =============
            Console.WriteLine("\n======== Task 12: Remove Middle Element ========");
            linkedList.Remove("About");

            Console.WriteLine("LinkedList Elements After Removal:");
            foreach (string item in linkedList)
            {
                Console.WriteLine(" - " + item);
            }

            // ============= Task 13: Add Before/After =============
            Console.WriteLine("\n======== Task 13: Add Before/After ========");
            LinkedListNode<string> homeNode = linkedList.Find("Home");
            if (homeNode != null)
            {
                linkedList.AddBefore(homeNode, "Blog");
                linkedList.AddAfter(homeNode, "Portfolio");
            }

            Console.WriteLine("LinkedList Elements After Adding Before/After:");
            foreach (string item in linkedList)
            {
                Console.WriteLine(" - " + item);
            }

            // ============= Task 14: Traverse LinkedList =============
            Console.WriteLine("\n======== Task 14: Traverse LinkedList ========");
            foreach (string item in linkedList)
            {
                Console.WriteLine(" - " + item);
            }

            // ============= Task 15: First and Last =============
            Console.WriteLine("\n======== Task 15: First and Last ========");
            if (linkedList.First != null && linkedList.Last != null)
            {
                Console.WriteLine("First Element: " + linkedList.First.Value);
                Console.WriteLine("Last Element: " + linkedList.Last.Value);
            }

            // ============= Section 4: LINQ =============
            Console.WriteLine("\n======== Section 4: LINQ ========");
            // ============= Task 16: Odd Numbers  =============
            Console.WriteLine("======== Task 16: Odd Numbers ========");
            int[] originalNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var oddNumbers = originalNumbers.Where(n => n % 2 != 0);
            Console.WriteLine("Odd Numbers:");
            foreach (var item in oddNumbers)
            {
                Console.Write(item + ",");
            }

            // ============= Task 17: Multiply All Numbers  =============
            Console.WriteLine("\n\n======== Task 17: Multiply All Numbers ========");
            var multipliedNumbers = originalNumbers.Select(n => n * 2);
            Console.WriteLine("Multiplied Numbers:");
            foreach (var item in multipliedNumbers)
            {
                Console.Write(item + ",");
            }

            // ============= Task 18: Sort Descending  =============
            Console.WriteLine("\n\n======== Task 18: Sort Descending ========");
            var sortedDescending = originalNumbers.OrderByDescending(n => n);
            Console.WriteLine("Sorted Descending:");
            foreach (var item in sortedDescending)
            {
                Console.Write(item + ",");
            }

            // ============= Task 19: SorFirst Number Greater Than 100  =============
            Console.WriteLine("\n\n======== Task 19: First Number Greater Than 100 ========");
            int[] numbers19 = { 10, 50, 100, 150, 200 };
            var firstGreaterThan100 = numbers19.Where(n => n > 100).FirstOrDefault();
            if (firstGreaterThan100 != 0)
            {
                Console.WriteLine("First Number Greater Than 100: " + firstGreaterThan100);
            }
            else
            {
                Console.WriteLine("No number greater than 100 found.");
            }

            // ============= Task 20: Average Calculation  =============
            Console.WriteLine("\n======== Task 20: Average Calculation ========");
            double average = originalNumbers.Average();
            Console.WriteLine("Average: " + average);


            // ======================================= Section 5: Mixed =======================================
            Console.WriteLine("\n======== Section 5: Mixed  ========");

            // ============= Task 21: Compare Two Lists =============
            Console.WriteLine("======== Task 21: Compare Two Lists ========");
            List<int> list1 = new List<int> { 1, 2, 3, 4, 5 };
            List<int> list2 = new List<int> { 5, 4, 3, 2, 1 };

            var commonNumbers = list1.Intersect(list2);
            Console.WriteLine("Common Numbers:");
            foreach (var num in commonNumbers)
            {
                Console.Write(num + ",");
            }

            // ============= Task 22: Merge Two Lists =============
            Console.WriteLine("\n\n======== Task 22: Merge Two Lists ========");
            List<int> mergedList = list1.Concat(list2).ToList();
            Console.WriteLine("Merged List:");
            foreach (var num in mergedList)
            {
                Console.Write(num + " ,");
            }

            // ============= Task 23:  Unique Values Only =============
            Console.WriteLine("\n\n======== Task 23:  Unique Values Only ========");
            List<int> uniqueValues = mergedList.Distinct().ToList();
            Console.WriteLine("Unique Values:");
            foreach (var num in uniqueValues)
            {
                Console.Write(num + " ,");
            }

            // ============= Task 24: Dictionary to List =============
            Console.WriteLine("\n\n======== Task 24: Dictionary to List ========");
            Dictionary<string, int> dict24 = new Dictionary<string, int>
            {
                { "A", 1 },
                { "B", 2 },
                { "C", 3 }
            };

            List<string> keysList = dict24.Keys.ToList();
            Console.WriteLine("Keys List:");
            foreach (var key in keysList)
            {
                Console.Write(key + " ,");
            }

            List<int> valuesList = dict24.Values.ToList();
            Console.WriteLine("\nValues List:");
            foreach (var value in valuesList)
            {
                Console.Write(value + " ,");
            }

            // ============= Task 25: Filter Dictionary =============
            Console.WriteLine("\n\n======== Task 25: Filter Dictionary ========");
            Dictionary<string, int> dict25 = new Dictionary<string, int>
            {
                { "A", 10 },
                { "B", 20 },
                { "C", 30 },
                { "D", 40 }
            };

            var filteredDict = dict25.Where(d_value => d_value.Value > 15).ToDictionary(new_key => new_key.Key, new_value => new_value.Value);
            Console.WriteLine("Filtered Dictionary:");
            foreach (var keyValue in filteredDict)
            {
                Console.WriteLine(keyValue.Key + ": " + keyValue.Value);
            }

            // ======================================= Section 6: Thinking Tasks =======================================
            Console.WriteLine("\n======== Section 6: Thinking Tasks ========");

            // ============= Task 26: Manual Search =============
            Console.WriteLine("======== Task 26: Manual Search ========");
            List<string> names26 = new List<string> { "Alice", "Bob", "Charlie", "David", "Eve" };
            string searchName = "Charlie";
            foreach (var name in names26)
            {
                if (name == searchName)
                {
                    Console.WriteLine($"{searchName} found in the list.");
                    break;
                }
            }

            // ============= Task 27: Count Even Without LINQ =============
            Console.WriteLine("\n======== Task 27: Count Even Without LINQ ========");
            List<int> numbers27 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int evenCount = 0;
            for (int i = 0; i < numbers27.Count; i++)
            {
                if (i % 2 == 0)
                {
                    evenCount++;
                }
            }
            Console.WriteLine("Count of Even Numbers: " + evenCount);

            // ============= Task 28: Remove While Looping =============
            Console.WriteLine("\n======== Task 28: Remove While Looping ========");
            List<int> numbers28 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.Write("Before Deleting: ");
            foreach (var num in numbers28)
            {
                Console.Write(num + " ,");
            }

            Console.Write("\n\nWhile Deleting: \n");
            for (int i = numbers28.Count - 1; i >= 0; i--)
            {
                Console.WriteLine("Removing Element: " + i);
                numbers28.RemoveAt(i);
            }

            // ============= Task 29: Find Second Largest Number =============
            Console.WriteLine("\n======== Task 29: Find Second Largest Number ========");
            List<int> numbers29 = new List<int> { 10, 20, 30, 40, 50 };
            int largest = numbers29.Max();
            int secondLargest = numbers29.Where(n => n < largest).Max();
            Console.WriteLine("Second Largest Number: " + secondLargest);

            // ======================================= Section 7: Advanced Logic Tasks (List & Array) =======================================
            Console.WriteLine("\n======== Section 7: Advanced Logic Tasks (List & Array) ========");

        }
    }
}

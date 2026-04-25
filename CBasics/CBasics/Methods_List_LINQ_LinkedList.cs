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

            // Task 1: Hidden Pattern Finder
            Console.WriteLine("======== Task 1: Hidden Pattern Finder ========");
            int[] arr1_1 = { 1, 3, 7, 3, 2, 3, 1 };
            int counter = 0;
            int maxFrequency = arr1_1[0];

            Dictionary<int, int> frequency = new Dictionary<int, int>();

            for (int i = 0; i < arr1_1.Length; i++)
            {
                int number = arr1_1[i];
                if (frequency.ContainsKey(number))
                {
                    frequency[number]++;
                }
                else
                {
                    frequency.Add(number, 1);
                }

                if (frequency[number] > counter)
                {
                    counter = frequency[number];
                    maxFrequency = number;
                }
            }

            Console.WriteLine("Most Frequent Number: " + maxFrequency + " (appears " + counter + " times)");

            // Task 2: Rotation Puzzle
            Console.WriteLine("\n======== Task 2: Rotation Puzzle ========");
            int swap = 29;
            int[] arr2_1 = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Array Before rotation:");
            foreach (var num in arr2_1)
            {
                Console.Write(num + " ,");
            }

            swap = swap % arr2_1.Length;

            // Reverse all the array
            int left = 0;
            int right = arr2_1.Length - 1;

            while (left < right)
            {
                int temp = arr2_1[left];
                arr2_1[left] = arr2_1[right];
                arr2_1[right] = temp;

                left++;
                right--;
            }

            // Reverse the first swap elements
            left = 0;
            right = swap - 1;

            while (left < right)
            {
                int temp = arr2_1[left];
                arr2_1[left] = arr2_1[right];
                arr2_1[right] = temp;

                left++;
                right--;
            }

            // Reverse the rest of the array
            left = swap;
            right = arr2_1.Length - 1;

            while (left < right)
            {
                int temp = arr2_1[left];
                arr2_1[left] = arr2_1[right];
                arr2_1[right] = temp;

                left++;
                right--;
            }

            Console.WriteLine("\nArray after rotation with swap = " + swap + ":");
            foreach (var num in arr2_1)
            {
                Console.Write(num + " ,");
            }

            // Task 3: Mirror Check
            Console.WriteLine("\n\n======== Task 3: Mirror Check ========");
            int[] arr3_1 = { 1, 2, 3, 2, 1 };
            int[] arr3_2 = { 1, 2, 3, 4 };

            bool isPalindrome = true;

            //array 1
            left = 0;
            right = arr3_1.Length - 1;
            while (left < right)
            {
                if (arr3_1[left] != arr3_1[right])
                {
                    isPalindrome = false;
                    break;
                }
                left++;
                right--;
            }

            Console.WriteLine("Is The first array a mirror? " + isPalindrome);

            // array 2
            left = 0;
            right = arr3_2.Length - 1;
            while (left < right)
            {
                if (arr3_2[left] != arr3_2[right])
                {
                    isPalindrome = false;
                    break;
                }
                left++;
                right--;
            }

            Console.WriteLine("Is The Second array a mirror? " + isPalindrome);

            // Task 4: Missing Number Detective
            Console.WriteLine("\n\n======== Task 4: Missing Number Detective ========");
            int N = 5;
            int[] arr4_1 = { 1, 2, 3, 5 }; // 1+2+3+4+5 = 15, 1+2+3+5 = 11, missing number = 15 - 11 = 4

            int expectedSum = N * (N + 1) / 2;
            int actualSum = 0;

            for (int i = 0; i < arr4_1.Length; i++)
            {
                actualSum += arr4_1[i];
            }

            foreach (var num in arr4_1)
            {
                Console.Write(num + " ,");
            }

            int missingNumber = expectedSum - actualSum;
            Console.WriteLine("\nMissing Number: " + missingNumber);

            // Task 5: Split List into Balanced Parts
            Console.WriteLine("\n\n======== Task 5: Split List into Balanced Parts ========");
            List<int> nums = new List<int> { 10, 20, 30, 5, 25 };

            double leftSum = 0;
            double rightSum = 0;
            double totalSum = nums.Sum();
            double bestDiff = double.MaxValue;
            double different = 0;
            int splitIndex = 0;

            for (int i = 0; i < nums.Count - 1; i++)
            {
                leftSum += nums[i];
                rightSum = totalSum - leftSum;
                different = Math.Abs(leftSum - rightSum);

                if (different < bestDiff)
                {
                    bestDiff = different;
                    splitIndex = i + 1;
                }
            }
            // Output the results
            var leftPart = nums[..splitIndex]; // From start to splitIndex (take)
            var rightPart = nums[splitIndex..]; // From splitIndex to the end (skip)

            Console.WriteLine($"Best Split: [{string.Join(", ", leftPart)}] | [{string.Join(", ", rightPart)}]");
            Console.WriteLine($"Minimal Difference: {bestDiff}");

            // ============= Task 6: Longest Increasing Sequence =============
            Console.WriteLine("\n======== Task 6: Longest Increasing Sequence ========");
            int[] arr6 = { 1, 2, 2, 3, 4, 1, 2, 3 };

            List<int> current6 = new List<int>();
            List<int> best6 = new List<int>();

            foreach (int n in arr6)
            {
                if (current6.Count == 0 || n > current6.Last())
                {
                    current6.Add(n);
                }
                else
                {
                    if (current6.Count > best6.Count) best6 = new List<int>(current6);
                    current6 = new List<int> { n };
                }
            }

            if (current6.Count > best6.Count) best6 = current6;

            Console.WriteLine("Longest Increasing Sequence: " + string.Join(", ", best6));


            // ============= Task 7: Duplicate Distance =============
            Console.WriteLine("\n======== Task 7: Duplicate Distance ========");
            int[] arr7 = { 1, 2, 3, 1, 4, 2, 1 }; // len = 7
            int minDistance = int.MaxValue;

            for (int i = 0; i < arr7.Length; i++) // i = 0
            {
                for (int j = i + 1; j < arr7.Length; j++) // j = 1 , 2 , 3 , 4 , 5 , 6
                {
                    if (arr7[i] == arr7[j])
                    // begin 1 == 2 (false) , i = 0, j = 1 // ||==> 1 == 3 (false) , i = 0, j = 2 
                    // ||==> 1 == 1 (true) , i = 0, j= 3
                    // ||==> 1 == 4 (false) , i = 0, j = 4 // ||==> 1 == 2 (false) , i = 0, j = 5  
                    // ||==> 1 == 1 (true) , i = 0, j = 6
                    {
                        int distance = j - i;  // distance = 3 - 0 = 3 // ||==> distance = 6 - 0 = 6
                        if (distance < minDistance) // distance = 3 < minDistance = int.MaxValue (true) // ||==> distance = 6 < minDistance = 3 (false)
                            minDistance = distance; // minDistance = 3 // donesn't change
                    }
                }
            }

            Console.WriteLine("Shortest Distance Between Duplicates: " + minDistance);


            // ============= Task 8: Reorder by Rule (Evens First, Then Odds) =============
            Console.WriteLine("\n======== Task 8: Reorder by Rule ========");
            int[] arr8 = { 1, 2, 3, 4, 5, 6, 7, 8 };

            List<int> evens = new List<int>();
            List<int> odds = new List<int>();

            foreach (int n in arr8)
            {
                if (n % 2 == 0) evens.Add(n);
                else odds.Add(n);
            }

            List<int> reordered = new List<int>(evens);
            foreach (var n in odds)
            {
                reordered.Add(n);
            }

            Console.WriteLine("Reordered: " + string.Join(", ", reordered));


            // ============= Task 9: Peaks Finder =============
            Console.WriteLine("\n======== Task 9: Peaks Finder ========");
            int[] arr9 = { 1, 3, 2, 4, 1 };
            List<int> peaks = new List<int>();

            for (int i = 1; i < arr9.Length - 1; i++)
            {
                if (arr9[i] > arr9[i - 1] && arr9[i] > arr9[i + 1])
                {
                    peaks.Add(arr9[i]);
                }
            }

            Console.WriteLine("Peaks: " + string.Join(", ", peaks));


            // ============= Task 10: Two Sum =============
            Console.WriteLine("\n======== Task 10: Two Sum ========");
            int[] arr10 = { 2, 7, 11, 15 };
            int target10 = 9;

            Dictionary<int, int> seen = new Dictionary<int, int>();

            foreach (int n in arr10) // n = 2 // ||==> n = 7 // ||==> n = 11 // ||==> n = 15
            {
                int result = target10 - n; // result = 9 - 2 = 7 // ||==> result = 9 - 7 = 2 // ||==> result = 9 - 11 = -2 // ||==> result = 9 - 15 = -6
                if (seen.ContainsKey(result)) // does seen contain 7 (false) // ||==> does seen contain 2 (true) // ||==> does seen contain -2 (false) // ||==> does seen contain -6 (false)
                {
                    Console.WriteLine($"Pair Found: {result} + {n} = {target10}"); // Pair Found: 2 + 7 = 9
                    break;
                }
                seen[n] = n; // seen[2] = 2 // ||==> seen[7] = 7 // ||==> seen[11] = 11 // ||==> seen[15] = 15
            }


            // ============= Task 11: Shift Zeros =============
            // same as evens and odds but with zeros and non-zeros
            Console.WriteLine("\n======== Task 11: Shift Zeros ========");
            int[] arr11 = { 0, 1, 0, 3, 12 };

            List<int> nonZeros = new List<int>();
            int zeroCount = 0;

            // removing the zeros and counting them
            foreach (int n in arr11)
            {
                if (n != 0) nonZeros.Add(n);
                else zeroCount++;
            }

            // then adding the zeros at the end of the non-zeros list
            for (int i = 0; i < zeroCount; i++)
                nonZeros.Add(0);

            Console.WriteLine("Shifted Zeros: " + string.Join(", ", nonZeros));


            // ============= Task 12: Alternating Merge =============
            Console.WriteLine("\n======== Task 12: Alternating Merge ========");
            int[] arr12a = { 1, 2, 3 };
            int[] arr12b = { 4, 5, 6 };

            List<int> merged = new List<int>();
            int maxLen = Math.Max(arr12a.Length, arr12b.Length);

            for (int i = 0; i < maxLen; i++)
            {
                if (i < arr12a.Length) merged.Add(arr12a[i]);
                if (i < arr12b.Length) merged.Add(arr12b[i]);
            }

            Console.WriteLine("Alternating Merge: " + string.Join(", ", merged));


            // ============= Task 13: Count Frequencies Without Dictionary =============
            Console.WriteLine("\n======== Task 13: Count Frequencies Without Dictionary ========");
            int[] arr13 = { 1, 2, 2, 3, 3, 3, 4 };

            List<int> counted = new List<int>();

            foreach (int n in arr13) // n = 1 // ||==> n = 2 // ||==> n = 2 // ||==> n = 3 // ||==> n = 3 // ||==> n = 3 // ||==> n = 4
            {
                if (!counted.Contains(n)) // same as dict.ContainsKey(n) but with list  
                                          // does counted contain 1 (false) n = 1 // ||==> does counted contain 2 (false) n = 2 // ||==> does counted contain 2 (true) n = 2 // ||==> does counted contain 3 (false) n = 3
                {
                    int freq = 0;
                    foreach (int m in arr13) // m = 1 // ||==> m = 2 // ||==> m = 2 // ||==> m = 3 // ||==> m = 3 // ||==> m = 3 // ||==> m = 4
                    {
                        if (m == n) freq++;  
                        // m = 1 n = 1 (true) freq = 1 // ||==> m = 2 n = 1 (false) freq=1 ...
                        // ||==> m = 2 n = 2 (true) freq = 2 // ||==> m = 3 n = 3 (true) freq = 1 
                        // ||==> m = 3 n = 3 (true) freq = 2 // ||==> m = 3 n = 3 (true) freq = 3 
                        // ||==> m = 4 n = 4 (true) freq = 1
                    }
                    Console.WriteLine($"{n} appears {freq} times");
                    counted.Add(n);
                }
            }


            // ============= Task 14: Find Second Maximum Without Sorting =============
            Console.WriteLine("\n======== Task 14: Find Second Maximum ========");
            int[] arr14 = { 5, 1, 9, 3, 7 };
            int first = int.MinValue;
            int second = int.MinValue;

            foreach (int n in arr14) // n = 5 //  n = 1 // n = 9 //  n = 3 //  n = 7
            {
                if (n > first)
                // n = 5 > first = int.MinValue (true) // n = 1 > first = 5 (false) 
                // n = 9 > first = 5 (true) // n = 3 > first = 9 (false) // n = 7 > first = 9 (false)
                {
                    // n = 5 , n = 9
                    second = first; // second = int.MinValue // second = 5
                    first = n;      // first = 5            // first = 9
                }
                else if (n > second && n != first) 
                    // n = 1 > second = int.MinValue && n = 1 != first = 5 (true) // n = 3 > second = 5 (false) 
                    // n = 7 > second = 5 && n = 7 != first = 9 (true)
                {
                    second = n;
                }
            }

            Console.WriteLine("Second Maximum: " + second);

            // ============= Task 20: Build Your Own Remove Method =============
            Console.WriteLine("\n======== Task 20: Build Your Own Remove Method ========");
            int[] arr20 = { 1, 2, 3, 2, 4, 2, 5 };
            int removeValue = 2;

            List<int> result20 = new List<int>();

            foreach (int n in arr20) // n = 1 // ||==> n = 2 // ||==> n = 3 // ||==> n = 2 // ||==> n = 4 // ||==> n = 2 // ||==> n = 5
            {
                if (n != removeValue) // n = 1 != 2 (true) // ||==> n = 3 != 2 (true) // ||==> n = 4 != 2 (true) // ||==> n = 5 != 2 (true)
                    result20.Add(n); // result20 = { 1 } // ||==> result20 = { 1, 3 } // ||==> result20 = { 1, 3, 4 } // ||==> result20 = { 1, 3, 4, 5 }
            }

            Console.WriteLine("After Removing " + removeValue + ": " + string.Join(", ", result20));
        }
    }
}

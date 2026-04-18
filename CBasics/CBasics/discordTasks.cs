using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace CBasics
{
    internal class ProblemSolving_Tasks
    {
        static void Main()
        {
            // ======================================= File: Function_1_.pdf =======================================
            // ======================================= Task 1 – Problem Solving =======================================
            Console.WriteLine("======== Task 1: Problem Solving ========");

            // ===== Q1: Minutes to Seconds =====
            Console.WriteLine("\n======== Q1: Minutes to Seconds ========");
            Console.WriteLine(MinutesToSeconds(5));   // 300
            Console.WriteLine(MinutesToSeconds(3));   // 180

            // ===== Q2: Increment by 1 =====
            Console.WriteLine("\n======== Q2: Increment by 1 ========");
            Console.WriteLine(Increment(5));    // 6
            Console.WriteLine(Increment(0));    // 1

            // ===== Q3: First Element =====
            Console.WriteLine("\n======== Q3: First Element ========");
            int[] arr1 = { 10, 20, 30, 40 };
            Console.WriteLine(FirstElement(arr1));  // 10

            // ===== Q4: Triangle Area =====
            Console.WriteLine("\n======== Q4: Triangle Area ========");
            Console.WriteLine(TriangleArea(5, 10));  // 25

            // ===== Q5: Even Number in Even Index =====
            Console.WriteLine("\n======== Q5: Even Number in Even Index ========");
            int[] nums5 = { 5, 2, 2, 1, 8, 66, 55, 77, 34, 9, 55, 1 };
            int[] result5 = EvenNumberEvenIndex(nums5);
            foreach (int num in result5)
                Console.Write(num + " ");  // 2 8 34
            Console.WriteLine();

            // ===== Q6: Even Index Odd Length =====
            Console.WriteLine("\n======== Q6: Even Index Odd Length ========");
            string[] strings6 = { "alex", "mercer", "madrasa", "rashed2", "emad", "hala" };
            string[] result6 = EvenIndexOddLength(strings6);
            foreach (string s in result6)
                Console.Write(s + " ");  // madrasa
            Console.WriteLine();

            // ===== Q8: Multiplication Using Sum =====
            Console.WriteLine("\n======== Q8: Multiplication Using Sum ========");
            Console.WriteLine(Multiplication2(5, 4));   // 20
            Console.WriteLine(Multiplication2(2, 8));   // 16

            // ===== Q10: Average of Array =====
            Console.WriteLine("\n======== Q10: Average of Array ========");
            int[] nums10a = { 1, 2, 3, 8, 9 };
            int[] nums10b = { 1, 2, 3, 8, 9, 77 };
            Console.WriteLine(AveArray(nums10a));   // 4.6
            Console.WriteLine(AveArray(nums10b));   // 16.6


            // ======================================= File: Function_2_.pdf =======================================
            // ======================================= Task 2 – Problem Solving =======================================
            Console.WriteLine("\n======== Task 2: Problem Solving ========");

            // ===== Q1: Days Between Dates =====
            Console.WriteLine("\n======== Q1: Days Between Dates ========");
            Console.WriteLine(GetDays(new DateTime(2019, 6, 14), new DateTime(2019, 6, 20)));   // 6
            Console.WriteLine(GetDays(new DateTime(2018, 12, 29), new DateTime(2019, 1, 1)));   // 3

            // ===== Q2: Strings With Numbers =====
            Console.WriteLine("\n======== Q2: Strings With Numbers ========");
            string[] strArr2a = { "1a", "a", "2b", "b" };
            string[] strArr2b = { "abc", "abc10" };
            string[] filteredNums2a = NumInStr(strArr2a);
            string[] filteredNums2b = NumInStr(strArr2b);
            Console.WriteLine("[" + string.Join(", ", filteredNums2a) + "]");   // [1a, 2b]
            Console.WriteLine("[" + string.Join(", ", filteredNums2b) + "]");   // [abc10]

            // ===== Q3: Reverse Odd Length Words =====
            Console.WriteLine("\n======== Q3: Reverse Odd Length Words ========");
            Console.WriteLine(ReverseOdd("Bananas"));              // sananaB
            Console.WriteLine(ReverseOdd("One two three four"));   // enO owt eerht four

            // ===== Q4: Is Pandigital =====
            Console.WriteLine("\n======== Q4: Is Pandigital ========");
            Console.WriteLine(IsPandigital(98140723568910));    // True
            Console.WriteLine(IsPandigital(90864523148909));    // False
            Console.WriteLine(IsPandigital(112233445566778899));// False


            // ======================================= File: Function_3_.pdf =======================================
            // ======================================= Task 3 – Problem Solving =======================================
            Console.WriteLine("\n======== Task 3: Problem Solving ========");

            // ===== Q1: Add(n)(m) =====
            Console.WriteLine("\n======== Q1: Add(n)(m) ========");
            Console.WriteLine(Add(10)(20));     // 30
            Console.WriteLine(Add(0)(20));      // 20
            Console.WriteLine(Add(-30)(80));    // 50

            // ===== Q3: Second Largest =====
            Console.WriteLine("\n======== Q3: Second Largest ========");
            Console.WriteLine(SecondLargest(new int[] { 10, 40, 30, 20, 50 }));      // 40
            Console.WriteLine(SecondLargest(new int[] { 25, 143, 89, 13, 105 }));    // 105

            // ===== Q4: Is Repdigit =====
            Console.WriteLine("\n======== Q4: Is Repdigit ========");
            Console.WriteLine(IsRepdigit(66));    // True
            Console.WriteLine(IsRepdigit(0));     // True
            Console.WriteLine(IsRepdigit(-11));   // False

            // ===== Q5: Reverse Words =====
            Console.WriteLine("\n======== Q5: Reverse Words ========");
            Console.WriteLine(ReverseWords("  the sky is blue"));   // blue is sky the
            Console.WriteLine(ReverseWords("hello world!  "));      // world! hello
            Console.WriteLine(ReverseWords("a good   example"));    // example good a

            // ===== Q6: Seven Boom =====
            Console.WriteLine("\n======== Q6: Seven Boom ========");
            Console.WriteLine(SevenBoom(new int[] { 1, 2, 3, 4, 5, 6, 7 }));      // Boom!
            Console.WriteLine(SevenBoom(new int[] { 8, 6, 33, 100 }));             // there is no 7 in the array
            Console.WriteLine(SevenBoom(new int[] { 2, 55, 60, 97, 86 }));         // Boom!

            // ===== Q7: Insert Whitespace =====
            Console.WriteLine("\n======== Q7: Insert Whitespace ========");
            Console.WriteLine(InsertWhitespace("SheWalksToTheBeach"));         // She Walks To The Beach
            Console.WriteLine(InsertWhitespace("MarvinTalksTooMuch"));         // Marvin Talks Too Much

            // ===== Q8: Count True =====
            Console.WriteLine("\n======== Q8: Count True ========");
            Console.WriteLine(CountTrue(new bool[] { true, false, false, true, false }));  // 2
            Console.WriteLine(CountTrue(new bool[] { false, false, false, false }));        // 0
            Console.WriteLine(CountTrue(new bool[] { }));                                   // 0

            // ===== Q11: Find NaN =====
            Console.WriteLine("\n======== Q11: Find NaN ========");
            Console.WriteLine(FindNaN(new double[] { 1, 2, double.NaN }));              // 2
            Console.WriteLine(FindNaN(new double[] { double.NaN, 1, 2, 3, 4 }));       // 0
            Console.WriteLine(FindNaN(new double[] { 0, 1, 2, 3, 4 }));                // -1

            // ===== Q12: Remove Duplicates =====
            Console.WriteLine("\n======== Q12: Remove Duplicates ========");
            int[] noDup1 = RemoveDups(new int[] { 1, 0, 1, 0 });
            Console.WriteLine("[" + string.Join(", ", noDup1) + "]");    // [1, 0]

            // ===== Q15: Sum of Cubes =====
            Console.WriteLine("\n======== Q15: Sum of Cubes ========");
            Console.WriteLine(SumOfCubes(new int[] { 1, 5, 9 }));    // 855
            Console.WriteLine(SumOfCubes(new int[] { 3, 4, 5 }));    // 216
            Console.WriteLine(SumOfCubes(new int[] { }));             // 0


            // ======================================= File: Task_4__C_.docx =======================================
            // ======================================= Task 4 – Methods =======================================
            Console.WriteLine("\n======== Task 4: Methods ========");

            // ===== Q1: Sum and Average of 10 Numbers =====
            Console.WriteLine("\n======== Q1: Sum & Average ========");
            int[] ten = { 2, 3, 5, 7, 8, 4, 6, 9, 9, 2 };
            SumAndAverage(ten);

            // ===== Q2: Cube up to N =====
            Console.WriteLine("\n======== Q2: Cubes up to N ========");
            CubeUpToN(5);

            // ===== Q3: Years Greater Than 1950 =====
            Console.WriteLine("\n======== Q3: Years > 1950 ========");
            int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            int[] filteredYears = GetYears(years);
            foreach (int y in filteredYears)
                Console.WriteLine(y);

            // ===== Q4: Age in Days =====
            Console.WriteLine("\n======== Q4: Age in Days ========");
            Console.WriteLine(AgeToDays(25));   // 9125

            // ===== Q5: Animal Legs =====
            Console.WriteLine("\n======== Q5: Animal Legs ========");
            Console.WriteLine(Animals(2, 3, 5));  // 36

            // ===== Q6: Login =====
            Console.WriteLine("\n======== Q6: Login ========");
            Console.WriteLine(Login("Heba", "1234"));    // pass
            Console.WriteLine(Login("Heba", "wrong"));   // failed

            // ===== Q7: Power =====
            Console.WriteLine("\n======== Q7: Power ========");
            Console.WriteLine(Power(2, 10));  // 1024

            // ===== Q8: Leap Year =====
            Console.WriteLine("\n======== Q8: Leap Year ========");
            Console.WriteLine(IsLeapYear(2000));  // True
            Console.WriteLine(IsLeapYear(1900));  // False
            Console.WriteLine(IsLeapYear(2024));  // True

            // ===== Q9: Is Prime =====
            Console.WriteLine("\n======== Q9: Is Prime ========");
            Console.WriteLine(IsPrime(7));    // True
            Console.WriteLine(IsPrime(10));   // False

            // ======================================= File: Task_5__C_.docx =======================================
            // ======================================= Task 5 – OOP =======================================
            Console.WriteLine("\n======== Task 5: OOP ========");

            // ===== Q1: MyClass Initialized =====
            Console.WriteLine("\n======== Q1: MyClass ========");
            MyClass myClass = new MyClass();
            myClass.Display();

            // ===== Q2: Greeting Class =====
            Console.WriteLine("\n======== Q2: Greeting Class ========");
            Greeter greeter = new Greeter();
            greeter.Greet("Scott");

            // ===== Q3: Factorial Class =====
            Console.WriteLine("\n======== Q3: Factorial Class ========");
            FactorialCalc factCalc = new FactorialCalc();
            Console.WriteLine($"Factorial of 5: {factCalc.Calculate(5)}");  // 120

            // ===== Q4: Array Sort Class =====
            Console.WriteLine("\n======== Q4: Array Sort Class ========");
            ArraySorter sorter = new ArraySorter();
            int[] arrayToSort = { 11, -2, 4, 35, 0, 8, -9 };
            sorter.SortAndDisplay(arrayToSort);

            // ===== Q6: String to Date Class =====
            Console.WriteLine("\n======== Q6: String to Date Class ========");
            DateConverter dateConverter = new DateConverter();
            dateConverter.Convert("12-08-2004");
        }


        // ======================================= File: Function_1_.pdf =======================================
        // ======================================= Task 1 – Methods =======================================

        // ===== Q1 =====
        static int MinutesToSeconds(int minutes)
        {
            return minutes * 60;
        }

        // ===== Q2 =====
        static int Increment(int number)
        {
            return number + 1;
        }

        // ===== Q3 =====
        static int FirstElement(int[] arr)
        {
            return arr[0];
        }

        // ===== Q4 =====
        static double TriangleArea(double baseVal, double height)
        {
            return 0.5 * baseVal * height;
        }

        // ===== Q5 =====
        static int[] EvenNumberEvenIndex(int[] nums)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (i % 2 == 0 && nums[i] % 2 == 0)
                    result.Add(nums[i]);
            }
            return result.ToArray();
        }

        // ===== Q6 =====
        static string[] EvenIndexOddLength(string[] strings)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < strings.Length; i++)
            {
                if (i % 2 == 0 && strings[i].Length % 2 != 0)
                    result.Add(strings[i]);
            }
            return result.ToArray();
        }

        // ===== Q8 =====
        static int Multiplication2(int a, int b)
        {
            int result = 0;
            for (int i = 0; i < b; i++)
                result += a;
            return result;
        }

        // ===== Q10 =====
        static double AveArray(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
                sum += nums[i];
            return (double)sum / nums.Length;
        }


        // ======================================= File: Function_2_.pdf =======================================
        // ======================================= Task 2 – Methods =======================================

        // ===== Q1 =====
        static int GetDays(DateTime date1, DateTime date2)
        {
            return (int)(date2 - date1).TotalDays;
        }

        // ===== Q2 =====
        static string[] NumInStr(string[] arr)
        {
            List<string> result = new List<string>();
            foreach (string s in arr)
            {
                foreach (char c in s)
                {
                    if (char.IsDigit(c))
                    {
                        result.Add(s);
                        break;
                    }
                }
            }
            return result.ToArray();
        }

        // ===== Q3 =====
        static string ReverseOdd(string sentence)
        {
            string[] words = sentence.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length % 2 != 0)
                {
                    char[] chars = words[i].ToCharArray();
                    System.Array.Reverse(chars);
                    words[i] = new string(chars);
                }
            }
            return string.Join(" ", words);
        }

        // ===== Q4 =====
        static bool IsPandigital(long number)
        {
            string s = number.ToString();
            for (char c = '0'; c <= '9'; c++)
            {
                if (!s.Contains(c))
                    return false;
            }
            return true;
        }


        // ======================================= File: Function_3_.pdf =======================================
        // ======================================= Task 3 – Methods =======================================

        // ===== Q1 =====
        static Func<int, int> Add(int n)
        {
            return m => n + m;
        }

        // ===== Q3 =====
        static int SecondLargest(int[] arr)
        {
            int largest = arr.Max();
            return arr.Where(n => n < largest).Max();
        }

        // ===== Q4 =====
        static bool IsRepdigit(int n)
        {
            if (n < 0) return false;
            string s = n.ToString();
            char first = s[0];
            foreach (char c in s)
            {
                if (c != first) return false;
            }
            return true;
        }

        // ===== Q5 =====
        static string ReverseWords(string sentence)
        {
            string[] words = sentence.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            System.Array.Reverse(words);
            return string.Join(" ", words);
        }

        // ===== Q6 =====
        static string SevenBoom(int[] arr)
        {
            foreach (int num in arr)
            {
                if (num.ToString().Contains('7'))
                    return "Boom!";
            }
            return "there is no 7 in the array";
        }

        // ===== Q7 =====
        static string InsertWhitespace(string s)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length - 1; i++)
            {
                sb.Append(s[i]);
                if (char.IsLower(s[i]) && char.IsUpper(s[i + 1]))
                    sb.Append(' ');
            }
            sb.Append(s[s.Length - 1]);
            return sb.ToString();
        }

        // ===== Q8 =====
        static int CountTrue(bool[] arr)
        {
            int count = 0;
            foreach (bool b in arr)
            {
                if (b) count++;
            }
            return count;
        }

        // ===== Q11 =====
        static int FindNaN(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (double.IsNaN(arr[i])) return i;
            }
            return -1;
        }

        // ===== Q12 =====
        static int[] RemoveDups(int[] arr)
        {
            List<int> result = new List<int>();
            foreach (int num in arr)
            {
                if (!result.Contains(num))
                    result.Add(num);
            }
            return result.ToArray();
        }

        // ===== Q15 =====
        static int SumOfCubes(int[] arr)
        {
            int sum = 0;
            foreach (int num in arr)
                sum += num * num * num;
            return sum;
        }


        // ======================================= File: Task_4__C_.docx =======================================
        // ======================================= Task 4 – Methods =======================================

        // ===== Q1 =====
        static void SumAndAverage(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
                sum += numbers[i];
            double average = (double)sum / numbers.Length;
            Console.WriteLine($"The sum of 10 no is: {sum}");
            Console.WriteLine($"The Average is: {average:F6}");
        }

        // ===== Q2 =====
        static void CubeUpToN(int n)
        {
            for (int i = 1; i <= n; i++)
                Console.WriteLine($"Number is: {i} and cube of the {i} is: {i * i * i}");
        }

        // ===== Q3 =====
        static int[] GetYears(int[] years)
        {
            return years.Where(y => y > 1950).ToArray();
        }

        // ===== Q4 =====
        static int AgeToDays(int age)
        {
            return age * 365;
        }

        // ===== Q5 =====
        static int Animals(int chickens, int cows, int pigs)
        {
            if (chickens % 2 != 0 || cows % 2 != 0 || pigs % 2 != 0)
                throw new ArgumentException("Function doesn't accept odd numbers.");
            return (chickens * 2) + (cows * 4) + (pigs * 4);
        }

        // ===== Q6 =====
        static string Login(string username, string password)
        {
            Dictionary<string, string> users = new Dictionary<string, string>
            {
                { "Heba",   "1234" },
                { "Laila",  "abcd" },
                { "Hanan",  "pass" }
            };

            if (users.ContainsKey(username) && users[username] == password)
                return "pass";

            return "failed";
        }

        // ===== Q7 =====
        static double Power(double baseNum, int exp)
        {
            return Math.Pow(baseNum, exp);
        }

        // ===== Q8 =====
        static bool IsLeapYear(int year)
        {
            if (year < 1900 || year > 2024)
                throw new ArgumentOutOfRangeException("Year must be between 1900 and 2024.");
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        // ===== Q9 =====
        static bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

    }


    // ======================================= File: Task_5__C_.docx =======================================
    // ======================================= Task 5 – OOP Classes =======================================

    // ===== Q1 =====
    internal class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("MyClass class has initialized!");
        }

        public void Display()
        {
            Console.WriteLine("MyClass class has initialized!");
        }
    }

    // ===== Q2 =====
    internal class Greeter
    {
        public void Greet(string name)
        {
            Console.WriteLine($"Hello All, I am {name}");
        }
    }

    // ===== Q3 =====
    internal class FactorialCalc
    {
        public long Calculate(int n)
        {
            if (n < 0) throw new ArgumentException("Factorial is not defined for negative numbers.");
            long result = 1;
            for (int i = 2; i <= n; i++)
                result *= i;
            return result;
        }
    }

    // ===== Q4 =====
    internal class ArraySorter
    {
        public void SortAndDisplay(int[] array)
        {
            Array.Sort(array);
            Console.Write("Sorted array: { ");
            Console.Write(string.Join(", ", array));
            Console.WriteLine(" }");
        }
    }

    // ===== Q5 =====
    // ===== Q6 =====
    internal class DateConverter
    {
        public void Convert(string dateString)
        {
            // '-' means d-M-yyyy format in C#
            DateTime date = DateTime.ParseExact(dateString, "d-MM-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine($"Converted Date: {date:yyyy-MM-dd}");
        }
    }
}
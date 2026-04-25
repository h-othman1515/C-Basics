using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace CBasics
{
    internal class discordTasks
    {
        static void Main()
        {
            // ======================================= File: Function(1).pdf =======================================
            // ========================== Task 1 – Problem Solving ==========================
            Console.WriteLine("========================== Task 1: Problem Solving ==========================");

            // ===== Q1: Minutes to Seconds =====
            Console.WriteLine("\n======== Q1: Minutes to Seconds ========");
            Console.WriteLine(MinutesToSeconds(5));
            Console.WriteLine(MinutesToSeconds(3));

            // ===== Q2: Increment by 1 =====
            Console.WriteLine("\n======== Q2: Increment by 1 ========");
            Console.WriteLine(Increment(5));
            Console.WriteLine(Increment(0));

            // ===== Q3: First Element =====
            Console.WriteLine("\n======== Q3: First Element ========");
            int[] arr1 = { 10, 20, 30, 40 };
            Console.WriteLine(FirstElement(arr1));

            // ===== Q4: Triangle Area =====
            Console.WriteLine("\n======== Q4: Triangle Area ========");
            Console.WriteLine(TriangleArea(5, 10));

            // ===== Q5: Even Number in Even Index =====
            Console.WriteLine("\n======== Q5: Even Number in Even Index ========");
            int[] nums5 = { 5, 2, 2, 1, 8, 66, 55, 77, 34, 9, 55, 1 };
            int[] result5 = EvenNumberEvenIndex(nums5);
            foreach (int num in result5)
                Console.Write(num + " ");
            Console.WriteLine();

            // ===== Q6: Even Index Odd Length =====
            Console.WriteLine("\n======== Q6: Even Index Odd Length ========");
            string[] strings6 = { "alex", "mercer", "madrasa", "rashed2", "emad1", "hala" };
            string[] result6 = EvenIndexOddLength(strings6);
            foreach (string s in result6)
                Console.Write(s + " ");
            Console.WriteLine();

            // ===== Q7: Power Element Index =====
            Console.WriteLine("\n======== Q7: Power Element Index ========");
            int[] nums7 = { 1, 2, 3, 4 };
            int[] result7 = powerElementIndex(nums7);
            foreach (int num in result7)
                Console.Write(num + ", ");
            Console.WriteLine();

            // ===== Q8: Multiplication Using Sum =====
            Console.WriteLine("\n======== Q8: Multiplication Using Sum ========");
            Console.WriteLine(Multiplication2(5, 4));
            Console.WriteLine(Multiplication2(2, 8));

            // ===== Q9: Multiplication Last saved =====
            Console.WriteLine("\n======== Q9: Multiplication Last Saved ========");
            Console.WriteLine(muti2(5, 4));

            // ===== Q10: Average of Array =====
            Console.WriteLine("\n======== Q10: Average of Array ========");
            int[] nums10a = { 1, 2, 3, 8, 9 };
            int[] nums10b = { 1, 2, 3, 8, 9, 77 };
            Console.WriteLine(AveArray(nums10a));
            Console.WriteLine(AveArray(nums10b));


            // ======================================= File: Function_2_.pdf =======================================
            // ========================== Task 2 – Problem Solving ==========================
            Console.WriteLine("\n========================== Task 2: Problem Solving ==========================");

            // ===== Q1: Days Between Dates =====
            Console.WriteLine("\n======== Q1: Days Between Dates ========");
            Console.WriteLine(GetDays(new DateTime(2019, 6, 14), new DateTime(2019, 6, 20)));
            Console.WriteLine(GetDays(new DateTime(2018, 12, 29), new DateTime(2019, 1, 1)));

            // ===== Q2: Strings With Numbers =====
            Console.WriteLine("\n======== Q2: Strings With Numbers ========");
            string[] strArr2a = { "1a", "a", "2b", "b" };
            string[] strArr2b = { "abc", "abc10" };
            string[] filteredNums2a = NumInStr(strArr2a);
            string[] filteredNums2b = NumInStr(strArr2b);
            Console.WriteLine("[" + string.Join(", ", filteredNums2a) + "]");
            Console.WriteLine("[" + string.Join(", ", filteredNums2b) + "]");

            // ===== Q3: Reverse Odd Length Words =====
            Console.WriteLine("\n======== Q3: Reverse Odd Length Words ========");
            Console.WriteLine(ReverseOdd("Apples"));
            Console.WriteLine(ReverseOdd("Bananas"));
            Console.WriteLine(ReverseOdd("One two three four"));

            // ===== Q4: Is Pandigital =====
            Console.WriteLine("\n======== Q4: Is Pandigital ========");
            Console.WriteLine(IsPandigital(98140723568910));
            Console.WriteLine(IsPandigital(90864523148909));
            Console.WriteLine(IsPandigital(112233445566778899));


            // ======================================= File: Function_3_.pdf =======================================
            // ========================== Task 3 – Problem Solving =========================
            Console.WriteLine("\n======================== Task 3: Problem Solving ========================");

            // ===== Q1: Add(n,m) =====
            Console.WriteLine("\n======== Q1: Add(n,m) ========");
            Console.WriteLine(Add(10, 20));
            Console.WriteLine(Add(0, 20));
            Console.WriteLine(Add(-30, 80));

            // ===== Q2: Remove Leading and Trailing Zeros =====
            Console.WriteLine("\n======== Q2: Remove Leading and Trailing Zeros ========");
            Console.WriteLine(removeLeadingTrailing("000123.45000"));


            // ===== Q3: Second Largest =====
            Console.WriteLine("\n======== Q3: Second Largest ========");
            int[] arr_1 = { 10, 40, 30, 20, 50 };
            int[] arr_2 = { 25, 143, 89, 13, 105 };
            Console.WriteLine(SecondLargest(arr_1));
            Console.WriteLine(SecondLargest(arr_2));

            // ===== Q4: Is Repdigit =====
            Console.WriteLine("\n======== Q4: Is Repdigit ========");
            Console.WriteLine(IsRepdigit(66));    // True
            Console.WriteLine(IsRepdigit(0));     // True
            Console.WriteLine(IsRepdigit(-11));   // False

            // ===== Q5: Reverse Words =====
            Console.WriteLine("\n======== Q5: Reverse Words ========");
            Console.WriteLine(ReverseWords("  the sky is blue"));
            Console.WriteLine(ReverseWords("hello world!  "));
            Console.WriteLine(ReverseWords("a good   example"));

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

            // ===== Q9: Cap to Front =====
            Console.WriteLine("\n======== Q9: Cap to Front ========");
            Console.WriteLine(CapToFront("hApPy"));
            Console.WriteLine(CapToFront("moveMENT"));
            Console.WriteLine(CapToFront("shOrtCAKE"));

            // ===== Q10: Match Last Item =====
            Console.WriteLine("\n======== Q10: Match Last Item ========");
            Console.WriteLine(MatchLastItem(new object[] { "rsq", "6hi", "g", "rsq6hig" }));
            Console.WriteLine(MatchLastItem(new object[] { 1, 1, 1, "11" }));
            Console.WriteLine(MatchLastItem(new object[] { 8, "thunder", true, "8thundertrue" }));

            // ===== Q11: Find NaN =====
            Console.WriteLine("\n======== Q11: Find NaN ========");
            Console.WriteLine(FindNaN(new double[] { 1, 2, double.NaN }));
            Console.WriteLine(FindNaN(new double[] { double.NaN, 1, 2, 3, 4 }));
            Console.WriteLine(FindNaN(new double[] { 0, 1, 2, 3, 4 }));

            // ===== Q12: Remove Duplicates =====
            Console.WriteLine("\n======== Q12: Remove Duplicates ========");
            Console.WriteLine("[" + string.Join(", ", RemoveDups(new object[] { 1, 0, 1, 0 })) + "]");
            Console.WriteLine("[" + string.Join(", ", RemoveDups(new object[] { "John", "Taylor", "John" })) + "]");

            // ===== Q13: Convert Time =====
            Console.WriteLine("\n======== Q13: Convert Time ========");
            Console.WriteLine(ConvertTime("07:05:45PM"));
            Console.WriteLine(ConvertTime("12:00:00AM"));
            Console.WriteLine(ConvertTime("12:45:54PM"));

            // ===== Q14: Remove Last Vowel =====
            Console.WriteLine("\n======== Q14: Remove Last Vowel ========");
            Console.WriteLine(removeLastVowel("Those who dare to fail miserably can achieve greatly."));
            Console.WriteLine(removeLastVowel("Love is a serious mental disease."));

            // ===== Q15: Sum of Cubes =====
            Console.WriteLine("\n======== Q15: Sum of Cubes ========");
            Console.WriteLine("The sum of cubes is: " + SumOfCubes(new int[] { 1, 5, 9 }));
            Console.WriteLine("The sum of cubes is: " + SumOfCubes(new int[] { 3, 4, 5 }));
            Console.WriteLine("The sum of cubes is: " + SumOfCubes(new int[] { }));


            // ======================================= File: Task_4__C_.docx =======================================
            // ======================================= Task 4 – Methods =======================================
            Console.WriteLine("\n======================== Task 4: Methods ========================");

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
            Console.WriteLine(AgeToDays(25));  

            // ===== Q5: Animal Legs =====
            Console.WriteLine("\n======== Q5: Animal Legs ========");
            Console.WriteLine(Animals(2, 3, 5)); 

            // ===== Q6: Login =====
            Console.WriteLine("\n======== Q6: Login ========");
            Console.WriteLine(Login("Heba", "1234"));   
            Console.WriteLine(Login("Heba", "wrong"));   

            // ===== Q7: Power =====
            Console.WriteLine("\n======== Q7: Power ========");
            Console.WriteLine(Power(2, 10)); 

            // ===== Q8: Leap Year =====
            Console.WriteLine("\n======== Q8: Leap Year ========");
            CheckLeapYear(2020);  
            CheckLeapYear(1900);  
            CheckLeapYear(2000);  

            // ===== Q9: Is Prime =====
            Console.WriteLine("\n======== Q9: Is Prime ========");
            Console.WriteLine(IsPrime(7));   
            Console.WriteLine(IsPrime(10));   

            // ======================================= File: Task_5__C_.docx =======================================
            // ======================================= Task 5 – OOP =======================================
            Console.WriteLine("\n======================== Task 5: OOP Classes ========================");
            Console.WriteLine("======== Task 1 ========");
            testClass myTest = new testClass();

            Console.WriteLine("\n======== Task 2 ========");
            User user1 = new User { Name = "Hanan" };
            user1.PrintName();

            Console.WriteLine("\n======== Task 3 ========");
            factorial fact = new factorial();
            Console.WriteLine(fact.calculateFact(5));

            Console.WriteLine("\n======== Task 4 ========");
            sorted sorted = new sorted();
            int[] unsorted = { 11, -2, 4, 35, 0, 8, -9 };
            sorted.SortedNumbers(unsorted);
            Console.WriteLine("Sorted Array: " + string.Join(", ", unsorted));

            Console.WriteLine("\n======== Task 5 ========");
            Days days = new Days();
            Console.WriteLine(days.GetDays(new DateTime(1978, 11, 3), new DateTime(2003, 4, 29)));

            Console.WriteLine("\n======== Task 6 ========");
            DateConverter newDate = new DateConverter();
            Console.WriteLine(newDate.fromStringToDate("29-04-2003"));
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

        // ===== Q7 =====
        static int[] powerElementIndex(int[] arr_num)
        {
            int[] result = new int[arr_num.Length];
            for (int i = 0; i < arr_num.Length; i++)
                result[i] = (int)Math.Pow(arr_num[i], i);
            return result;
        }

        // ===== Q8 =====
        static int Multiplication2(int a, int b)
        {
            int result = 0;
            for (int i = 0; i < b; i++)
                result += a;
            return result;
        }

        // ===== Q9 =====
        static int muti2(int a, int b) // a is the start , and b is the end
        {
            int result = 1;
            for (int i = 0; i < b; i++)
                result *= a;
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
            for (int i = 0; i < arr.Length; i++)
            {
                string currentString = arr[i];
                for (int j = 0; j < currentString.Length; j++)
                {
                    if (char.IsDigit(currentString[j]))
                    {
                        result.Add(currentString);
                        break;
                    }
                }
            }
            return result.ToArray();
            // or
            //return arr.Where(s => Regex.IsMatch(s, @"\d")).ToArray();
        }


        // ===== Q3 =====
        static string ReverseOdd(string sentence)
        {
            string[] words = sentence.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length % 2 != 0)
                {
                    string reversed = new string(words[i].Reverse().ToArray());
                    words[i] = reversed;
                }
            }
            return string.Join(" ", words);
        }

        // ===== Q4 =====
        static bool IsPandigital(long number)
        {
            return number.ToString().Where(char.IsDigit).Distinct().Count() == 10;
            // ToString () to convert number to string
            // Where(char.IsDigit) to filter only digits
            // Distinct() to get unique digits ; Delete the duplicates 
            // Count() to count them. If the count is 10, it means all digits from 0 to 9 are present.
        }


        // ======================================= File: Function_3_.pdf =======================================
        // ======================================= Task 3 – Methods =======================================

        // ===== Q1 =====
        static int Add(int n1, int n2)
        {
            int result = n1 + n2;
            return result;
        }

        // ===== Q2 =====
        static string removeLeadingTrailing(string s)
        {
            return s.Trim('0');
        }

        // ===== Q3 =====
        static int SecondLargest(int[] arr)
        {
            int max = arr.Max();
            return arr.Where(n => n < max).Max();
        }

        // ===== Q4 =====
        static bool IsRepdigit(int n)
        {
            if (n < 0) return false;
            string s = n.ToString();
            char first = s[0];
            foreach (char c in s)
            {
                if (c != first)
                    return false;
            }
            return true;
            // or 
            //return n.ToString().Distinct().Count() == 1;
        }

        // ===== Q5 =====
        static string ReverseWords(string sentence)
        {
            string[] words = sentence.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                string reversed = new string(words[i].Reverse().ToArray());
                words[i] = reversed;
            }
            return string.Join(" ", words);
        }

        // ===== Q6 =====
        static string SevenBoom(int[] arr)
        {
            foreach (int num in arr)
            {
                string seven = num.ToString();
                if (seven.Contains('7'))
                    return seven + ": Boom!";
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
                if (b == true)
                    count++;
            }
            return count;
        }

        // ===== Q9 =====
        static string CapToFront(string s)
        {
            string lower = new string(s.Where(char.IsLower).ToArray());
            string upper = new string(s.Where(char.IsUpper).ToArray());
            return upper + lower;
        }

        // ===== Q10 =====
        static bool MatchLastItem(Object[] arr)
        {
            string joined = "";
            for (int i = 0; i < arr.Length - 1; i++)
                joined += arr[i].ToString();
            if (joined == arr[arr.Length - 1].ToString())
                return true;
            return false;
        }

        // ===== Q11 =====
        static int FindNaN(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (double.IsNaN(arr[i]))
                    return i;
            }
            return -1;
        }

        // ===== Q12 =====
        static object[] RemoveDups(object[] arr)
        {
            return arr.Distinct().ToArray();
        }

        // ===== Q13 =====
        static string ConvertTime(string time)
        {
            string amPm = time.Substring(time.Length - 2);
            int hour = int.Parse(time.Substring(0, 2));
            string minSec = time.Substring(2, 6);
            if (amPm == "AM")
            {
                if (hour == 12) hour = 0;
            }
            else
            {
                if (hour != 12) hour += 12;
            }
            return hour.ToString() + minSec;
        }

        // ===== Q14 =====
        static string removeLastVowel(string sentence)
        {
            string[] words = sentence.Split(' ');
            string vowels = "aeiouAEIOU";

            for (int i = words.Length - 1; i >= 0; i--)
            {
                string currentWord = words[i];
                for (int j = currentWord.Length - 1; j >= 0; j--)
                {
                    if (vowels.Contains(currentWord[j]))
                    {
                        words[i] = currentWord.Remove(j, 1);
                        break;
                    }
                }
            }

            return string.Join(" ", words);
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
        public static void CheckLeapYear(int year)
        {
            if (year < 1900 || year > 2024)
            {
                Console.WriteLine("Please enter a year between 1900 and 2024.");
                return;
            }

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine($"{year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year.");
            }
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
    // ============================ Task 5 – OOP Classes =============================
    // ===== Q1 =====
    public class testClass
    {
        public testClass()
        {
            Console.WriteLine("'MyClass class has initialized!'");
        }
    }

    // ===== Q2 =====
    public class User
    {
        public string Name { get; set; }
        public void PrintName()
        {
            Console.WriteLine($"Hello My name is: {Name}");
        }
    }

    // ===== Q3 =====
    public class factorial
    {
        public int calculateFact(int a) // 5 
        {
            if (a <= 1) return 1; // Base case: factorial of 0 or 1 is 1
            return a * calculateFact(a - 1); // 5 * calculateFact(4) => 5 * (4 * calculateFact(3)) => 5 * (4 * (3 * calculateFact(2))) => 5 * (4 * (3 * (2 * calculateFact(1)))) => 5 * (4 * (3 * (2 * 1))) => 120
        }
    }

    // ===== Q4 =====
    public class sorted
    {
        public int[] SortedNumbers(int[] numbers)
        {
            Array.Sort(numbers);
            return numbers;
        }
    }

    // ===== Q5 =====
    public class Days
    {
        public int years { get; set; }
        public int months { get; set; }
        public int days { get; set; }

        public string GetDays(DateTime date1, DateTime date2)
        {
            days = (int)(date2 - date1).TotalDays;
            years = days / 365;
            months = (days % 365) / 30;
            days = (days % 365) % 30;
            return $"Difference: {years} years, {months} months, and {days} days.";
        }
    }

    // ===== Q6 =====
    public class DateConverter
    {
        public string fromStringToDate(string Date)
        {
            DateTime convertedDate = DateTime.ParseExact(Date, "d-MM-yyyy", null);

            return "Converted Date: " + convertedDate.ToString("yyyy-MM-dd");
        }
    }
}
using System;
using System.Text;

class Program
{
    static void Main()
    {
        //// Task 1
        //String name = "Hanan";
        //int age = 22;
        //Console.WriteLine("My name is " + name + " and I am " + age + " years old");

        //// Task 2
        //Console.WriteLine("Enter Any Number:");
        //int number = Convert.ToInt32(Console.ReadLine());
        //if (number % 2 == 0)
        //{
        //    Console.WriteLine(number + " is an Even Number");
        //}
        //else
        //{
        //    Console.WriteLine(number + " is an Odd Number");
        //}

        //// Task 3
        //Console.WriteLine("Enter Any Word:");
        //String Word = Console.ReadLine();
        //Console.WriteLine("The Word is: " + Word);

        //// Task 4
        ////int num = Convert.ToInt32(Console.ReadLine());
        //int num = 10;
        //if (num > 0)
        //{
        //    Console.WriteLine(num + " is a Positive Number");
        //}
        //else if (num < 0)
        //{
        //    Console.WriteLine(num + " is a Negative Number");
        //}
        //else
        //{
        //    Console.WriteLine(num + " is Zero");
        //}

        //// Task 5
        //Console.WriteLine("Enter Any Year: ");
        //int Year = Convert.ToInt32(Console.ReadLine());
        //if ((Year % 4 == 0 || Year % 400 == 0) && (Year % 100 != 0)) // (Year % 4 == 0 && Year % 100 != 0) && (Year % 400 == 0)
        //{
        //    Console.WriteLine(Year + " is a Leap Year");
        //}
        //else
        //{
        //    Console.WriteLine(Year + " is not a Leap Year");
        //}

        //// Task 6
        //Console.WriteLine("Enter a Grade:");
        //int grade = Convert.ToInt32(Console.ReadLine());
        //if (grade > 50)
        //{
        //    Console.WriteLine("Your Grade is " + grade + ", You Passed!");
        //}
        //else
        //{
        //    Console.WriteLine("Your Grade is " + grade + ", You Failed!");
        //}

        //// Task 7
        //int num1 = Convert.ToInt32(Console.ReadLine());
        //int num2 = Convert.ToInt32(Console.ReadLine());
        //if (num1 > num2)
        //{
        //    Console.WriteLine(num1 + " is Greater than " + num2);
        //}
        //else if (num1 < num2)
        //{
        //    Console.WriteLine(num1 + " is Less than " + num2);
        //}
        //else
        //{
        //    Console.WriteLine(num1 + " is Equal to " + num2);
        //}

        //// Task 8
        //int number1 = Convert.ToInt32(Console.ReadLine());
        //if (number1 % 5 == 0 && number1 % 3 == 0)
        //{
        //    Console.WriteLine(number1 + " is Divisible by both 5 and 3");
        //}
        //else
        //{
        //    Console.WriteLine(number1 + " is not Divisible by both 5 and 3");
        //}

        //// Task 9
        //char character = Convert.ToChar(Console.ReadLine().ToLower());
        //if (character == 'a' || character == 'o' || character == 'i' || character == 'e' || character == 'u')
        //{
        //    Console.WriteLine(character + " Is a Vowel");
        //}
        //else
        //{
        //    Console.WriteLine(character + " Is a Constant");
        //}

        //// Task 10
        //int age10 = Convert.ToInt32(Console.ReadLine());
        //if (age10 < 12)
        //{
        //    Console.WriteLine("You are a Child");
        //}
        //else if (age10 >= 12 && age10 < 18)
        //{
        //    Console.WriteLine("You are a Teenager");
        //}
        //else
        //{
        //    Console.WriteLine("You are an Adult");
        //}

        //// Task 11
        //int day = Convert.ToInt32(Console.ReadLine());
        //switch (day)
        //{
        //    case 1:
        //        Console.WriteLine("Sunday");
        //        break;
        //    case 2:
        //        Console.WriteLine("Monday");
        //        break;
        //    case 3:
        //        Console.WriteLine("Tuesday");
        //        break;
        //    case 4:
        //        Console.WriteLine("Wednesday");
        //        break;
        //    case 5:
        //        Console.WriteLine("Thursday");
        //        break;
        //    case 6:
        //        Console.WriteLine("Friday");
        //        break;
        //    case 7:
        //        Console.WriteLine("Saturday");
        //        break;
        //    default:
        //        Console.WriteLine("Invalid Day Number");
        //        break;
        //}

        //// Task 12
        //int month = Convert.ToInt32(Console.ReadLine());
        //switch (month)
        //{
        //    case 1:
        //        Console.WriteLine("January");
        //        break;
        //    case 2:
        //        Console.WriteLine("February");
        //        break;
        //    case 3:
        //        Console.WriteLine("March");
        //        break;
        //    case 4:
        //        Console.WriteLine("April");
        //        break;
        //    case 5:
        //        Console.WriteLine("May");
        //        break;
        //    case 6:
        //        Console.WriteLine("June");
        //        break;
        //    case 7:
        //        Console.WriteLine("July");
        //        break;
        //    case 8:
        //        Console.WriteLine("August");
        //        break;
        //    case 9:
        //        Console.WriteLine("September");
        //        break;
        //    case 10:
        //        Console.WriteLine("October");
        //        break;
        //    case 11:
        //        Console.WriteLine("November");
        //        break;
        //    case 12:
        //        Console.WriteLine("December");
        //        break;
        //    default:
        //        Console.WriteLine("Invalid Day Number");
        //        break;
        //}

        //// Task 13
        //Console.WriteLine("Enter Number 1: ");
        //int FNumber = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter Number 2: ");
        //int SNumber = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Operation: ");
        //char op = Convert.ToChar(Console.ReadLine());
        //switch (op)
        //{
        //    case '+':
        //        Console.WriteLine(FNumber + SNumber);
        //        break;
        //    case '-':
        //        Console.WriteLine(FNumber - SNumber);
        //        break;
        //    case '/':
        //        Console.WriteLine(FNumber / SNumber);
        //        break;
        //    case '*':
        //        Console.WriteLine(FNumber * SNumber);
        //        break;
        //    default:
        //        Console.WriteLine("Invalid Operator");
        //        break;
        //}

        //// Task 14
        //Console.WriteLine("Enter a Grade:");
        //int grade14 = Convert.ToInt32(Console.ReadLine());
        //switch (grade14)
        //{
        //    case (>= 90):
        //        Console.WriteLine("Your Grade is A");
        //        break;
        //    case (>= 80 and < 90):
        //        Console.WriteLine("Your Grade is B");
        //        break;
        //    case (>= 70 and < 80):
        //        Console.WriteLine("Your Grade is C");
        //        break;
        //    case (>= 60 and < 70):
        //        Console.WriteLine("Your Grade is D");
        //        break;
        //    case (>= 50 and < 60):
        //        Console.WriteLine("Your Grade is E");
        //        break;
        //    case (< 50):
        //        Console.WriteLine("Your Grade is F, You Failed!!");
        //        break;
        //    default:
        //        Console.WriteLine("Invalid Input");
        //        break;
        //}

        //// task 15
        //Console.WriteLine("Enter a number between 1-3:");
        //int num15 = Convert.ToInt32(Console.ReadLine());
        //switch (num15)
        //{
        //    case 1:
        //        Console.WriteLine("one");
        //        break;
        //    case 2:
        //        Console.WriteLine("two");
        //        break;
        //    case 3:
        //        Console.WriteLine("three");
        //        break;
        //    default:
        //        Console.WriteLine("Invalid number");
        //        break;
        //}

        //// Task 16
        //Console.WriteLine("Enter a number:");
        //int num16 = Convert.ToInt32(Console.ReadLine());
        //switch (num16 % 2)
        //{
        //    case 0:
        //        Console.WriteLine("Is Even");
        //        break;
        //    case 1:
        //        Console.WriteLine("Is odd");
        //        break;
        //    default:
        //        Console.WriteLine("Invalid Number");
        //        break;
        //}

        //// Task 17
        //Console.WriteLine("Enter Your Role (Admin, User, Guest)");
        //string role = Console.ReadLine().ToLower();
        //switch (role)
        //{
        //    case "admin":
        //        Console.WriteLine("Welcome back, Admin!");
        //        break;
        //    case "user":
        //        Console.WriteLine("Welcome back, User!");
        //        break;
        //    case "guest":
        //        Console.WriteLine("Welcome back, Guest!");
        //        break;
        //    default:
        //        Console.WriteLine("Invalid Role");
        //        break;
        //}

        //// Task 18
        //Console.WriteLine("1. Say Hello");
        //Console.WriteLine("2. Add Two Numbers");
        //Console.WriteLine("3. Check Even or Odd");
        //Console.WriteLine("4. Exit");
        //Console.Write("Choose an option (1-4): ");

        //bool running = true;

        //int choice = Convert.ToInt32(Console.ReadLine());

        //while (running)
        //{
        //    switch (choice)
        //    {
        //        case 1:
        //            Console.Write("Enter your name: ");
        //            string name = Console.ReadLine();
        //            Console.WriteLine("Hello, " + name + "! Welcome!");
        //            break;

        //        case 2:
        //            Console.Write("Enter first number: ");
        //            double num1 = double.Parse(Console.ReadLine());
        //            Console.Write("Enter second number: ");
        //            double num2 = double.Parse(Console.ReadLine());
        //            Console.WriteLine("Result: " + num1 + " + " + num2 + " = " + (num1 + num2));
        //            break;

        //        case 3:
        //            Console.Write("Enter a number: ");
        //            int number = int.Parse(Console.ReadLine());
        //            if (number % 2 == 0)
        //                Console.WriteLine(number + " is Even.");
        //            else
        //                Console.WriteLine(number + " is Odd.");
        //            break;

        //        case 4:
        //            Console.WriteLine("Goodbye! See you next time.");
        //            running = false;
        //            break;

        //        default:
        //            Console.WriteLine("Invalid option. Please choose 1 to 4.");
        //            break;
        //    }
        //}

        //// ================= Advanced  Questions =================
        //// Task 1
        //Console.Write("Enter employee performance rating (0 - 100): ");
        //int rating = Convert.ToInt32(Console.ReadLine());

        //if (rating >= 90 && rating <= 100)
        //{
        //    Console.WriteLine("Performance: Excellent");
        //    Console.WriteLine("Bonus: 20%");
        //}
        //else if (rating >= 75 && rating < 90)
        //{
        //    Console.WriteLine("Performance: Very Good");
        //    Console.WriteLine("Bonus: 15%");
        //}
        //else if (rating >= 60 && rating < 75)
        //{
        //    Console.WriteLine("Performance: Good");
        //    Console.WriteLine("Bonus: 10%");
        //}
        //else if (rating >= 0 && rating < 60)
        //{
        //    Console.WriteLine("Performance: Below Average");
        //    Console.WriteLine("Bonus: No bonus");
        //}
        //else
        //{
        //    Console.WriteLine("Invalid rating. Please enter a value between 0 and 100.");
        //}

        //// Task 2
        //Console.WriteLine("Enter GPA: ");
        //double GPA = Convert.ToDouble(Console.ReadLine());

        //Console.WriteLine("Enter your English Test result: ");
        //int testResult = Convert.ToInt32(Console.ReadLine());
        //bool isPassed = false;
        //if (testResult >= 50)
        //{
        //    isPassed = true;
        //}
        //else
        //{
        //    isPassed = false;
        //}

        //Console.WriteLine("Do you Have a special recommendation? (Yes/No)");
        //string recommendation = Console.ReadLine().ToLower();
        //bool isRecommendation;
        //if (recommendation == "yes")
        //{
        //    isRecommendation = true;
        //}
        //else
        //{
        //    isRecommendation = false;
        //}

        //if (isRecommendation == true || (GPA >= 85 && isPassed == true))
        //{
        //    Console.WriteLine("A student is eligible for university admission");
        //}
        //else
        //{
        //    Console.WriteLine("A student is NOT eligible for university admission");
        //}

        //// Task 3
        //Console.Write("Enter package weight (kg): ");
        //double weight = double.Parse(Console.ReadLine());

        //if (weight <= 1)
        //{
        //    Console.WriteLine("Delivery Cost: $5");
        //}
        //else if (weight <= 5)
        //{
        //    Console.WriteLine("Delivery Cost: $10");
        //}
        //else if (weight <= 10)
        //{
        //    Console.WriteLine("Delivery Cost: $20");
        //}
        //else
        //{
        //    Console.WriteLine("Delivery Cost: $50");
        //    Console.WriteLine("Warning! Heavy package!");
        //}

        //// Task 4
        //string correctUsername = "admin";
        //string correctPassword = "1234";
        //int maxAttempts = 3;
        //int attempts = 0;

        //while (attempts < maxAttempts)
        //{
        //    Console.Write("Enter username: ");
        //    string username = Console.ReadLine();

        //    Console.Write("Enter password: ");
        //    string password = Console.ReadLine();

        //    if (username == correctUsername && password == correctPassword)
        //    {
        //        Console.WriteLine("✅ Login successful! Welcome.");
        //        return;
        //    }
        //    else
        //    {
        //        attempts++;
        //        int remaining = maxAttempts - attempts;

        //        if (remaining > 0)
        //            Console.WriteLine("Invalid credentials. " + remaining + "attempt(s) remaining.");
        //    }
        //}

        //Console.WriteLine("Account is locked. Too many failed attempts.");

        //// ================= Switch Statements – Advanced Questions =================
        //// Task 1
        //Console.WriteLine("1. Burger ($5)");
        //Console.WriteLine("2. Pizza  ($8)");
        //Console.WriteLine("3. Pasta  ($7)");
        //Console.WriteLine("4. Salad  ($4)");
        //Console.Write("Choose an option (1-4): ");

        //int mrnuChoice = Convert.ToInt32(Console.ReadLine());
        //switch (mrnuChoice)
        //{
        //    case 1:
        //        Console.WriteLine("Burger ($5)");
        //        break;
        //    case 2:
        //        Console.WriteLine("Pizza  ($8)");
        //        break;
        //    case 3:
        //        Console.WriteLine("Pasta  ($7)");
        //        break;
        //    case 4:
        //        Console.WriteLine("Salad  ($4)");
        //        break;

        //    default:
        //        Console.WriteLine("Invalid Number");
        //        break;
        //}

        //// Task 2
        //Console.Write("Enter your grade (A, B, C, D, F): ");
        //string grade = Console.ReadLine().ToUpper().Trim();

        //switch (grade)
        //{
        //    case "A":
        //        Console.WriteLine("Grade A , Excellent");
        //        break;

        //    case "B":
        //        Console.WriteLine("Grade B , Very Good");
        //        break;

        //    case "C":
        //        Console.WriteLine("Grade C , Good");
        //        break;

        //    case "D":
        //        Console.WriteLine("Grade D , Pass");
        //        break;

        //    case "F":
        //        Console.WriteLine("Grade F, Fail");
        //        break;

        //    default:
        //        Console.WriteLine("Invalid grade.");
        //        break;
        //}

        //// Task 3
        //Console.WriteLine("1. Check Balance");
        //Console.WriteLine("2. Deposit Money");
        //Console.WriteLine("3. Withdraw Money");
        //Console.WriteLine("4. Exit");
        //Console.Write("Choose an option (1-4): ");
        //int ATMChoice = Convert.ToInt32(Console.ReadLine());

        //bool atmOP = true;
        //while (atmOP)
        //{
        //    double balance = 2500.77;
        //    switch (ATMChoice)
        //    {
        //        case 1:
        //            Console.WriteLine("Your Balance: " + balance);
        //            break;
        //        case 2:
        //            Console.WriteLine("Enter the amount you want to add: ");
        //            double addMoney = Convert.ToDouble(Console.ReadLine());
        //            balance = balance + addMoney;
        //            Console.WriteLine("Your New Total Balance: " + balance);
        //            break;
        //        case 3:
        //            Console.WriteLine("Enter the amount you want to Take: ");
        //            double getMoney = Convert.ToDouble(Console.ReadLine());
        //            balance = balance - getMoney;
        //            Console.WriteLine("Your New Total Balance: " + balance);
        //            break;
        //        case 4:
        //            Console.WriteLine("Come Agian!!");
        //            atmOP = false;
        //            break;

        //        default:
        //            Console.WriteLine("Invalid Operation");
        //            break;
        //    }
        //}

        ////Task 4
        //Console.Write("Enter first number: ");
        //double num1 = double.Parse(Console.ReadLine());

        //Console.Write("Enter second number: ");
        //double num2 = double.Parse(Console.ReadLine());

        //Console.WriteLine("\n1. Addition");
        //Console.WriteLine("2. Subtraction");
        //Console.WriteLine("3. Multiplication");
        //Console.WriteLine("4. Division");
        //Console.Write("Choose operation (1-4): ");
        //string choice = Console.ReadLine();

        //switch (choice)
        //{
        //    case "1":
        //        Console.WriteLine($"Result: {num1} + {num2} = {num1 + num2}");
        //        break;

        //    case "2":
        //        Console.WriteLine($"Result: {num1} - {num2} = {num1 - num2}");
        //        break;

        //    case "3":
        //        Console.WriteLine($"Result: {num1} * {num2} = {num1 * num2}");
        //        break;

        //    case "4":
        //        if (num2 == 0)
        //            Console.WriteLine("Error: Cannot divide by zero.");
        //        else
        //            Console.WriteLine($"Result: {num1} / {num2} = {num1 / num2}");
        //        break;

        //    default:
        //        Console.WriteLine("Invalid choice. Please select 1 to 4.");
        //        break;
        //}

        // ================================= C#(Array,String,Loops) =================================
        // =========================  Task 1: Analyze an Array with Loops =========================
        //Console.WriteLine("=========== Task 1 ===========");
        //int[] integers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        //int even = 0;
        //int odd = 0;
        //int sum = 0;

        //for (int i = 0; i < integers.Length; i++)
        //{
        //    if (integers[i] % 2 == 0)
        //    {
        //        even++;
        //    }
        //    else if (integers[i] % 2 != 0)
        //    {
        //        odd++;
        //    }
        //    sum = sum + integers[i];
        //}

        //// for 2
        //double avg = sum / integers.Length;
        //int[] newInt = new int[integers.Length];
        //int index = 0;
        //for (int i = 0; i < newInt.Length; i++)
        //{
        //    if (integers[i] > avg)
        //    {
        //        newInt[index++] = integers[i];
        //    }
        //}
        //Console.WriteLine("The Sum of all numbers: " + sum);
        //Console.WriteLine("The Count of Even numbers: " + even);
        //Console.WriteLine("The Count of Odd numbers: " + odd);
        //Console.WriteLine("The AVG of All numbers: " + avg);
        //Console.WriteLine("Numbers greater than average: [");
        //for (int i = 0; i < index; i++)
        //{
        //    Console.Write(newInt[i] + ",");
        //}

        //// =========================  Task 2: Find the Largest Number in an Array =========================
        //Console.WriteLine("\n=========== Task 2 ===========");
        //int[] numbers = [12, 45, 7, 23, 56, 19];
        //int max = numbers[0];
        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    if (numbers[i] > max)
        //    {
        //        max = numbers[i];
        //    }
        //}
        //Console.WriteLine("Largest Number: " + max);

        //// =========================  Task 3 =========================
        //Console.WriteLine("=========== Task 3 ===========");
        //for (int i = 1; i <= 10; i++)
        //{
        //    if (i % 2 == 0)
        //    {
        //        Console.Write(i + ",");
        //    }
        //}

        //// =========================  Task 4: Data Conversion Using Convert =========================
        //Console.WriteLine("\n=========== Task 4 ===========");
        //try
        //{
        //    Console.WriteLine("What is your Full Name?");
        //    string Fullname = Console.ReadLine();
        //    Console.WriteLine("How Old Are You?");
        //    int age = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("How much is your Height? (in meter e.x: 1.75m)");
        //    double height = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("Are you Employed? (true / false)");
        //    bool IsEmployed = Convert.ToBoolean(Console.ReadLine());

        //    Console.WriteLine("--- User Profile ---");
        //    Console.WriteLine("Name: " + Fullname);
        //    Console.WriteLine("Age: " + age);
        //    Console.WriteLine("Height: " + height);
        //    Console.WriteLine("Is Employed? " + IsEmployed);
        //}
        //catch
        //{
        //    Console.WriteLine("Invalid Data Type!");
        //}

        //// =========================  Task 5: Strings =========================
        //Console.WriteLine("=========== Task 5 ===========");
        //Console.WriteLine("Enter Your name:");
        //string name = Console.ReadLine();
        //Console.WriteLine("Name Lower Case: " + name.ToLower());
        //Console.WriteLine("Name Upper Case : " + name.ToUpper());

        //Console.WriteLine("Enter Your Age: ");
        //int age5 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine($"My name is {name} and I am {age5} years old.");

        //Console.WriteLine($"The First Letter of your name {name[0]}");

        //Console.WriteLine("Name: " + name);
        //Console.WriteLine("Age: " + age5);

        //// =========================  Task – Break & Continue =========================
        //Console.WriteLine("=========== Break & Continue ===========");
        //for (int i = 1; i < 10; i++)
        //{
        //    if (i % 3 == 0)
        //    {
        //        continue;
        //    }
        //    if (i == 8)
        //    {
        //        break;
        //    }
        //    Console.WriteLine(i);
        //}

        // =========================  C# Task - (Loops,String,Array) 30# =========================
        // task 1: ZigZag Numbers
        //Console.WriteLine("=========== Task 1 ===========");
        //int n = 5;
        //for (int i = 1; i <= n; i++)
        //{
        //    if (i % 2 != 0) // odd
        //    {
        //        for (int j = 1; j <= i; j++)
        //            Console.Write(j);
        //    }
        //    else // even
        //    {
        //        for (int j = i; j >= 1; j--)
        //            Console.Write(j);
        //    }

        //    Console.WriteLine();
        //}

        //// task 2: Mirror Number Pattern
        //Console.WriteLine("=========== Task 2 ===========");
        //n = 4;
        //for (int r = 1; r <= n; r++)
        //{
        //    // left
        //    for (int i = 1; i <= r; i++)
        //        Console.Write(i);
        //    //Console.Write(" ");

        //    //// middle space
        //    for (int s = 0; s < 2 * (n - r); s++)
        //        Console.Write(' ');

        //    // right
        //    for (int i = r; i >= 1; i--)
        //        Console.Write(i);

        //    Console.WriteLine();
        //}

        //// task 3: Centered Number Pyramid
        //Console.WriteLine("=========== Task 3 ===========");
        //n = 4;

        //for (int r = 1; r <= n; r++)
        //{
        //    //  the space
        //    for (int i = 1; i <= n - r; i++)
        //    {
        //        Console.Write(" ");
        //    }

        //    //  increasing numbers [from 1 to r]
        //    for (int j = 1; j <= r; j++)
        //    {
        //        Console.Write(j);
        //    }

        //    // decreasing numbers [from r-1 to 1]
        //    for (int j = r - 1; j >= 1; j--)
        //    {
        //        Console.Write(j);
        //    }

        //    // Move to the next line
        //    Console.WriteLine();
        //}

        //// task 4: Skip Numbers Pattern
        //Console.WriteLine("=========== Task 4 ===========");
        //n = 5;
        //for (int i = 1; i <= n; i++)
        //{
        //    for (int j = 1; j < i; j++)
        //    {
        //        Console.Write(2 * j - 1);
        //    }
        //    Console.WriteLine();
        //}

        //// task 5: Row Sum Pattern
        //Console.WriteLine("=========== Task 5 ===========");
        //int n = 4;
        //int sum = 1;
        //for (int i = 1; i <= n; i++)
        //{
        //    for (int j = 0; j < i; j++)
        //    {
        //        Console.Write(sum + " "); // 1 22 444 8888
        //    }
        //    Console.WriteLine();
        //    sum = sum + sum; // 2 4 8
        //}

        //// task 6: Alternating Direction Triangle
        //Console.WriteLine("=========== Task 6 ===========");
        //n = 5;
        //for (int i = 1; i <= n; i++)
        //{
        //    if (i % 2 != 0) // odd
        //    {
        //        for (int j = 1; j <= i; j++)
        //            Console.Write(j);
        //    }
        //    else // even
        //    {
        //        for (int j = i; j >= 1; j--)
        //            Console.Write(j);
        //    }

        //    Console.WriteLine();
        //}

        //// task 7:  Hollow Pyramid Numbers
        //Console.WriteLine("=========== Task 7 ===========");
        //n = 4;
        //for (int i = 1; i <= n; i++)
        //{
        //    //  the space
        //    for (int j = 1; j <= n - i; j++)
        //    {
        //        Console.Write(" ");
        //    }

        //    int totalColumns = 2 * i - 1;
        //    for (int j = 1; j <= totalColumns; j++)
        //    {
        //        if (j == 1 || j == totalColumns || i == n)
        //        {
        //            Console.Write("1");
        //        }
        //        else
        //        {
        //            Console.Write(" ");
        //        }
        //    }
        //    // Move to the next line
        //    Console.WriteLine();
        //}

        //// task 8: Diagonal Cross Pattern
        //Console.WriteLine("=========== Task 8 ===========");
        //n = 5;
        //for (int i = 1; i <= n; i++)
        //{
        //    for (int j = 1; j <= n; j++)
        //    {
        //        if (j == i || j == n - i + 1)
        //        {
        //            Console.Write(i);
        //        }
        //        else
        //        {
        //            Console.Write(" ");
        //        }
        //    }
        //    // Move to the next line
        //    Console.WriteLine();
        //}

        //// task 9: Incremental Blocks
        //Console.WriteLine("=========== Task 9 ===========");
        //n = 4;
        //int current_number = 1;

        //// rows i = row number
        //for (int i = 1; i < n; i++)
        //{
        //    // cols, run i times
        //    for (int j = 0; j < i; j++)
        //    {
        //        Console.Write(current_number + " ");
        //        current_number++;
        //    }
        //    Console.WriteLine();
        //}

        //// task 10: Pattern with Gaps
        //Console.WriteLine("=========== Task 10 ===========");
        //n = 5;
        //// i = row
        //for (int i = 1; i <= n; i++)
        //{
        //    // col = j
        //    for (int j = 1; j <= i; j++)
        //    {
        //        if (j == 1 || j == i || i == n)
        //        {
        //            Console.Write("1");
        //        }
        //        else
        //        {
        //            Console.Write(" ");
        //        }
        //    }
        //    // Move to the next line
        //    Console.WriteLine();
        //}

        // ========================= Arrays =========================
        // task 1: First Non-Repeating Subarray
        Console.WriteLine("=========== Task 1 ===========");
        int[] numbers = [1, 2, 1, 3, 4];
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] != numbers[i + 1])
            {
                Console.WriteLine("[" + numbers[i + 1] + "," + numbers[i] + "]");
                break;
            }

        }

        // task 2: Equal Distance Elements
        //Console.WriteLine("=========== Task 2 ===========");
        //int index;
        //List<int> indexes = new List<int>();
        //for (int i = 0; i < indexes.Count; i++)
        //{
        //    for (int j = 0; j < i; j++)
        //    {

        //    }
        //}


        // task 3: First Non-Repeating Subarray
        //Console.WriteLine("=========== Task 3 ===========");
        //int[] mainArr = [1, 1, 2, 2, 3, 1];

        //List<List<int>> itemList = new List<List<int>>();

        //List<int> currentGroup = new List<int> { mainArr[0] };

        //for (int i = 1; i < mainArr.Length; i++)
        //{
        //    if (mainArr[i] == mainArr[i - 1])
        //    {
        //        currentGroup.Add(mainArr[i]);
        //    }
        //    else
        //    {
        //        itemList.Add(currentGroup);
        //        currentGroup = new List<int> { mainArr[i] };
        //    }

        //}
        //itemList.Add(currentGroup);
        //foreach (var item in itemList)
        //{
        //    Console.Write("[" + string.Join(", ", item) + "]");
        //}

        //// Task 7: Progressive Difference
        //Console.WriteLine("\n=========== Task 7 ===========");
        //List<int> result = new List<int>();
        //int[] arr = [5, 7, 10];
        //int[] newArr = new int [5];
        //result.Add(arr[0]);
        //for (int i = 1; i < arr.Length; i++)
        //{
        //    newArr[i] = arr[i] - arr[i - 1];
        //    result.Add(newArr[i]);
        //}
        //Console.Write("[");
        //foreach (var item in result)
        //{
        //    Console.Write(string.Join(" ",item) + ",");
        //}
        //Console.Write("]");

        // ========================= Strings =========================
        // task 6: Longest Repeating Block
        Console.WriteLine("\n=========== Task 6 ===========");
        string letters = "aaabbccccd";
        int maxCount = 0;
        int currentCount = 1;

        for (int i = 1; i < letters.Length; i++)
        {
            if (letters[i] == letters[i - 1])
            {
                currentCount++;
            }
            else
            {
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                }
                currentCount = 1;
            }
        }
        if (currentCount > maxCount)
        {
            maxCount = currentCount;
        }
        Console.WriteLine("Longest block length: " + maxCount);

        // task 7: Shift Characters
        Console.WriteLine("\n=========== Task 7 ===========");
        string alpha = "abc";
        string res_alpha = "";

        foreach (char c in alpha)
        {
            char nextChar = (char)(c + 1);
            res_alpha += nextChar;
        }
        Console.WriteLine("Original Alpha: " + alpha);
        Console.WriteLine("Result Alpha: " + res_alpha);
    }
}
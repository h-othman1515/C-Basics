using System;

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

        // Task 2
        Console.WriteLine("Enter GPA: ");
        double GPA = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter your English Test result: ");
        int testResult = Convert.ToInt32(Console.ReadLine());
        bool isPassed = false;
        if (testResult >= 50)
        {
            isPassed = true;
        }
        else
        {
            isPassed = false;
        }

        Console.WriteLine("Do you Have a special recommendation? (Yes/No)");
        string recommendation = Console.ReadLine().ToLower();
        bool isRecommendation;
        if (recommendation == "yes")
        {
            isRecommendation = true;
        }
        else
        {
            isRecommendation = false;
        }

        if (isRecommendation == true || (GPA >= 85 && isPassed == true))
        {
            Console.WriteLine("A student is eligible for university admission");
        }
        else
        {
            Console.WriteLine("A student is NOT eligible for university admission");
        }

        // Task 3
        Console.Write("Enter package weight (kg): ");
        double weight = double.Parse(Console.ReadLine());

        if (weight <= 1)
        {
            Console.WriteLine("Delivery Cost: $5");
        }
        else if (weight <= 5)
        {
            Console.WriteLine("Delivery Cost: $10");
        }
        else if (weight <= 10)
        {
            Console.WriteLine("Delivery Cost: $20");
        }
        else
        {
            Console.WriteLine("Delivery Cost: $50");
            Console.WriteLine("Warning! Heavy package!");
        }

        // Task 4
        string correctUsername = "admin";
        string correctPassword = "1234";
        int maxAttempts = 3;
        int attempts = 0;

        while (attempts < maxAttempts)
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            if (username == correctUsername && password == correctPassword)
            {
                Console.WriteLine("✅ Login successful! Welcome.");
                return;
            }
            else
            {
                attempts++;
                int remaining = maxAttempts - attempts;

                if (remaining > 0)
                    Console.WriteLine("Invalid credentials. " + remaining + "attempt(s) remaining.");
            }
        }

        Console.WriteLine("Account is locked. Too many failed attempts.");

        // ================= Switch Statements – Advanced Questions =================
        // Task 1
        Console.WriteLine("1. Burger ($5)");
        Console.WriteLine("2. Pizza  ($8)");
        Console.WriteLine("3. Pasta  ($7)");
        Console.WriteLine("4. Salad  ($4)");
        Console.Write("Choose an option (1-4): ");

        int mrnuChoice = Convert.ToInt32(Console.ReadLine());
        switch (mrnuChoice)
        {
            case 1:
                Console.WriteLine("Burger ($5)");
                break;
            case 2:
                Console.WriteLine("Pizza  ($8)");
                break;
            case 3:
                Console.WriteLine("Pasta  ($7)");
                break;
            case 4:
                Console.WriteLine("Salad  ($4)");
                break;

            default:
                Console.WriteLine("Invalid Number");
                break;
        }

        // Task 2
        Console.Write("Enter your grade (A, B, C, D, F): ");
        string grade = Console.ReadLine().ToUpper().Trim();

        switch (grade)
        {
            case "A":
                Console.WriteLine("Grade A , Excellent");
                break;

            case "B":
                Console.WriteLine("Grade B , Very Good");
                break;

            case "C":
                Console.WriteLine("Grade C , Good");
                break;

            case "D":
                Console.WriteLine("Grade D , Pass");
                break;

            case "F":
                Console.WriteLine("Grade F, Fail");
                break;

            default:
                Console.WriteLine("Invalid grade.");
                break;
        }

        // Task 3
        Console.WriteLine("1. Check Balance");
        Console.WriteLine("2. Deposit Money");
        Console.WriteLine("3. Withdraw Money");
        Console.WriteLine("4. Exit");
        Console.Write("Choose an option (1-4): ");
        int ATMChoice = Convert.ToInt32(Console.ReadLine());

        bool atmOP = true;
        while (atmOP)
        {
            double balance = 2500.77;
            switch (ATMChoice)
            {
                case 1:
                    Console.WriteLine("Your Balance: " + balance);
                    break;
                case 2:
                    Console.WriteLine("Enter the amount you want to add: ");
                    double addMoney = Convert.ToDouble(Console.ReadLine());
                    balance = balance + addMoney;
                    Console.WriteLine("Your New Total Balance: " + balance);
                    break;
                case 3:
                    Console.WriteLine("Enter the amount you want to Take: ");
                    double getMoney = Convert.ToDouble(Console.ReadLine());
                    balance = balance - getMoney;
                    Console.WriteLine("Your New Total Balance: " + balance);
                    break;
                case 4:
                    Console.WriteLine("Come Agian!!");
                    atmOP = false;
                    break;

                default:
                    Console.WriteLine("Invalid Operation");
                    break;
            }
        }

        //Task 4
        Console.Write("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("\n1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.Write("Choose operation (1-4): ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.WriteLine($"Result: {num1} + {num2} = {num1 + num2}");
                break;

            case "2":
                Console.WriteLine($"Result: {num1} - {num2} = {num1 - num2}");
                break;

            case "3":
                Console.WriteLine($"Result: {num1} * {num2} = {num1 * num2}");
                break;

            case "4":
                if (num2 == 0)
                    Console.WriteLine("Error: Cannot divide by zero.");
                else
                    Console.WriteLine($"Result: {num1} / {num2} = {num1 / num2}");
                break;

            default:
                Console.WriteLine("Invalid choice. Please select 1 to 4.");
                break;
        }

    }
}
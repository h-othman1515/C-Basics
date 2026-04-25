using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBasics
{
    internal class OOPPrinciples
    {
        // Task 1 Description: Static Class
        public static class MathUtilities
        {
            public static int square(int a)
            {
                return a * a;
            }

            public static double squareRoot(int a)
            {
                return Math.Sqrt(a);
            }

            public static int max2(int a, int b)
            {
                return Math.Max(a, b);
            }
        }


        // task 2 : Static Method
        public class Converter
        {
            public static double CelsiusToFahrenheit(double c)
            {
                return (c * 9 / 5) + 32;
            }
            public static double KilometersToMiles(double kms)
            {
                return kms * 0.621371;
            }
        }

        // task 3 : Static Field
        public class VisitorCounter
        {
            public static int countVisitors = 0;
            public VisitorCounter()
            {
                countVisitors++;
            }
        }

        // task 4: Static Property
        public class Company
        {
            public static string companyName { get; set; } = "Company 1";
            public string employeeName { get; set; }
        }

        // task 5: OOP Principles
        // task 5.1: overloading
        public class Calculator
        {
            public int Add(int a, int b)
            {
                return a + b;
            }

            public int Add(int a, int b, int c)
            {
                return a + b + c;
            }

            public double Add(double a, double b)
            {
                return a + b;
            }
        }

        // task 5.2
        public class Animal
        {
            public virtual void MakeSound()
            {
                Console.WriteLine("Animal makes a sound");
            }

            // task 5.3
            public class Cat : Animal
            {
                public override void MakeSound()
                {
                    Console.WriteLine("Cat meows");
                }
            }

            public class Dog : Animal
            {
                public override void MakeSound()
                {
                    Console.WriteLine("Dog barks");
                }
            }
        }

        // task 5.4
        public class Person
        {
            public string Name { get; set; }
            private int age;
            public int Age
            {
                get { return age; }
                set
                {
                    if (value >= 0)
                    {
                        age = value;
                    }
                    else
                    {
                        Console.WriteLine("Age cannot be negative.");
                    }
                }
            }
        }

        // task 5.5
        public abstract class Shape
        {
            public abstract double GetArea();
        }

        // task 5.6
        public class Regtangle : Shape
        {
            public double Width { get; set; }
            public double Height { get; set; }
            public Regtangle(double width, double height)
            {
                Width = width;
                Height = height;
            }
            public override double GetArea()
            {
                return Width * Height;
            }
        }

        // task 6: Abstraction
        public abstract class Appliance
        {
            public abstract void TurnOn();
            public abstract void TurnOff();
            public string brand { get; set; }
        }

        public class WashingMachine : Appliance
        {
            public override void TurnOn()
            {
                Console.WriteLine("Washing machine is now ON.");
            }
            public override void TurnOff()
            {
                Console.WriteLine("Washing machine is now OFF.");
            }
        }

        public class AirConditioner : Appliance
        {
            public override void TurnOn()
            {
                Console.WriteLine("Air Conditioner is now ON.");
            }
            public override void TurnOff()
            {
                Console.WriteLine("Air Conditioner is now OFF.");
            }
        }

        // task 7: Encapsulation
        public class BankAccount
        {
            private double balance;

            public double Balance
            {
                get { return balance; }
            }

            public void Deposit(double amount)
            {
                if (amount > 0)
                {
                    balance += amount;
                    Console.WriteLine($"Deposited: {amount}, New Balance: {balance}");
                }
                else
                {
                    Console.WriteLine("Deposit amount must be positive.");
                }
            }

            public void Withdraw(double amount)
            {
                if (amount > 0 && amount <= balance)
                {
                    balance -= amount;
                    Console.WriteLine($"Withdrew: {amount}, New Balance: {balance}");
                }
                else
                {
                    Console.WriteLine("Invalid withdrawal amount.");
                }
            }
        }

        // task 8: Abstract Class
        public abstract class Employee
        {
            public string Name { get; set; }
            public abstract void CalculateSalary();
        }

        public class FullTimeEmployee : Employee
        {
            public double MonthlySalary { get; set; }
            public override void CalculateSalary()
            {
                Console.WriteLine($"Full-time employee {Name} has a monthly salary of {MonthlySalary}");
            }
        }

        public class PartTimeEmployee : Employee
        {
            public double HourlyRate { get; set; }
            public int HoursWorked { get; set; }
            public override void CalculateSalary()
            {
                double salary = HourlyRate * HoursWorked;
                Console.WriteLine($"Part-time employee {Name} has a salary of {salary}");
            }
        }

        static void Main()
        {
            // task 1
            Console.WriteLine("=============== Task 1 – Static Class ===============");
            Console.WriteLine(MathUtilities.square(5));
            Console.WriteLine(MathUtilities.squareRoot(5));
            Console.WriteLine(MathUtilities.max2(5, 20));

            // task 2
            Console.WriteLine("\n=============== Task 2 – Static Method ===============");
            Console.WriteLine(Converter.CelsiusToFahrenheit(25));
            Console.WriteLine(Converter.KilometersToMiles(100));

            // task 3
            Console.WriteLine("\n=============== Task 3 – Static Field ===============");
            VisitorCounter v1 = new VisitorCounter();
            VisitorCounter v2 = new VisitorCounter();
            VisitorCounter v3 = new VisitorCounter();

            Console.WriteLine(VisitorCounter.countVisitors);

            // task 4
            Console.WriteLine("\n=============== Task 4 – Static Property ===============");
            Company.companyName = "Company 2";
            Company emp1 = new Company { employeeName = "Hanan" };
            Company emp2 = new Company { employeeName = "Rawan" };

            Console.WriteLine($"Company: {Company.companyName}, Employee 1: {emp1.employeeName}");
            Console.WriteLine("Company: " + Company.companyName + ", Employee 2: " + emp2.employeeName);

            // task 5
            Console.WriteLine("\n=============== Task – OOP Principles ===============");
            // 5.1
            Console.WriteLine("====== Task 5.1: Overloading ======");
            Calculator calc = new Calculator();
            Console.WriteLine(calc.Add(5, 10));
            Console.WriteLine(calc.Add(5, 10, 15));
            Console.WriteLine(calc.Add(5.5, 10.7));

            // 5.2 & 5.3
            Console.WriteLine("\n====== Task 5.2 & 5.3: Inheritance and Polymorphism ======");
            Animal animal = new Animal();
            animal.MakeSound();
            Animal cat = new Animal.Cat();
            cat.MakeSound();
            Animal dog = new Animal.Dog();
            dog.MakeSound();

            // 5.4
            Console.WriteLine("\n====== Task 5.4: Encapsulation ======");
            Person p1 = new Person { Name = "Hanan", Age = 23 }; // Or
            Person p2 = new Person();
            p2.Name = "Rawan";
            p2.Age = 20;
            Console.WriteLine($"Name: {p1.Name}, Age: {p1.Age}");
            Console.WriteLine($"Name: {p2.Name}, Age: {p2.Age}");

            // 5.5 & 5.6
            Console.WriteLine("\n====== Task 5.5 & 5.6: Abstraction and Implementation ======");
            Regtangle rect = new Regtangle(5, 10);
            Console.WriteLine($"Area of the rectangle: {rect.GetArea()}");

            // task 6: Abstraction
            Console.WriteLine("\n=============== Task 6: Abstraction ===============");
            WashingMachine wm = new WashingMachine();
            wm.brand = "LG";

            AirConditioner ac = new AirConditioner();
            ac.brand = "Samsung";

            Console.WriteLine($"Washing Machine Brand: {wm.brand}");
            wm.TurnOn();
            wm.TurnOff();

            Console.WriteLine($"Air Conditioner Brand: {ac.brand}");
            ac.TurnOn();
            ac.TurnOff();

            // task 7: Encapsulation
            Console.WriteLine("\n=============== Task 7: Encapsulation ===============");
            BankAccount account = new BankAccount();
            account.Deposit(1000);
            account.Withdraw(200);


            // task 8: Abstract Class
            Console.WriteLine("\n=============== Task 8: Abstract Class ===============");
            FullTimeEmployee Femp1 = new FullTimeEmployee();
            Femp1.Name = "Hanan";
            Femp1.MonthlySalary = 5000;
            PartTimeEmployee Pemp2 = new PartTimeEmployee { Name = "Rawan", HourlyRate = 20, HoursWorked = 80 };
            Femp1.CalculateSalary();
            Pemp2.CalculateSalary();
        }
    }
}

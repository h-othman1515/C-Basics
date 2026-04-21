using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace CBasics
{
    internal class AdvancedOOP
    {
        class Person
        {
            public string name { get; set; }
            private int age { get; set; }

            // Default constructor
            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            // Getter for age
            public int GetAge()
            {
                return age;
            }

            // setter for age
            public void SetAge(int age)
            {
                this.age = age;
            }
        }

        static void PrintData(Student student)
        {
            Console.WriteLine(student.name + " is " + student.GetAge() + " years old and has a grade of " + student.grade + ".");
        }

        class Student : Person
        {
            public string grade { get; set; }
            public Student(string name, int age, string grade) : base(name, age)
            {
                this.grade = grade;
            }
        }

        sealed class Teacher : Person
        {
            public string subject { get; set; }
            public Teacher(string name, int age, string subject) : base(name, age)
            {
                this.subject = subject;
            }
        }



        // ========================= Task 2 =========================
        class Car
        {
            public string make { get; set; }
            public string model { get; set; }
            public string color { get; set; }
            public string type { get; set; }
            public int year { get; set; }
            public double price { get; set; }
            public int pallet_no { get; set; }

            // Constructor
            public Car(string make, string model, string type, string color, int year, double price, int pallet_no)
            {
                this.make = make;
                this.model = model;
                this.type = type;
                this.color = color;
                this.year = year;
                this.price = price;
                this.pallet_no = pallet_no;
            }

            // ToString method
            public override string ToString()
            {
                return $"Year: {year} Make: {make} Model: {model} Type: {type} Color: {color} Price: ${price} (Pallet No: {pallet_no})";
            }
        }

        static void Main()
        {
            Student s1 = new Student("Bob", 20, "A");
            PrintData(s1);
            Teacher t1 = new Teacher("Alice", 35, "Math");
            Console.WriteLine(t1);

            Car c1 = new Car("Toyota", "Camry", "Sedan", "Red", 2020, 24000, 12345);
            Console.WriteLine(c1);
        }
    }
}

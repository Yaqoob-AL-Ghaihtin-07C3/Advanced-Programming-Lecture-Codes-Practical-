using System;

namespace lab1
{
    // الفئة الأساسية
    public class Person
    {
        public string Name { get; set; }
        public virtual void Speak()
        {
            Console.WriteLine($"{Name} is speaking...");
        }
    }

    // الوراثة والتعدد الشكلي
    public class Student : Person
    {
        public override void Speak()
        {
            Console.WriteLine($"{Name} says: I'm studying C#!");
        }
    }

    public class Teacher : Person
    {
        public override void Speak()
        {
            Console.WriteLine($"{Name} says: I'm teaching advanced OOP.");
        }
    }

    internal class Program
    {
        static void Main()
        {
            Person ap = new Person();
            ap.Name = "aaaaa";
            Person[] people = {
                new Student { Name = "Ali" },
                new Teacher { Name = "Ahmed" }
            };

            foreach (Person p in people)
            {
                p.Speak();
            }
            Console.ReadKey();
        }
    }
}

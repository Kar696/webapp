using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person mard = new Student()
            {
                Name = "Karen"
            };


            mard.SayHello();
            
            //Console.WriteLine(mard.Name);
            Console.Read();
        }
    }

    public class Person
    {
        public string Name { get; set; }

        public virtual void SayHello()
        {
            Console.WriteLine($"Barev {Name}.");
        }
    }


    public class Student : Person
    {
        public string SchoolName { get; set; }

        public override void SayHello()
        {
            Console.WriteLine($"Barev {Name}. You are a mice student.");
        }
    }

    public class Worker : Person
    {
        public string CompanyName { get; set; }
    }

    public class MAStudent: Student
    {
        public override void SayHello()
        {
            Console.WriteLine($"Barev {Name}. You are a mice MA student.");
        }
    }
}

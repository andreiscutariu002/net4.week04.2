namespace StudentAndWorkers.Models
{
    using System;

    internal class Student : Human
    {
        public Student(string firstName, string lastName, double grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public double Grade { get; set; }

        public new void Print()
        {
            base.Print();
            Console.WriteLine($"\tGrade: {this.Grade}");
            Console.WriteLine();
        }
    }
}
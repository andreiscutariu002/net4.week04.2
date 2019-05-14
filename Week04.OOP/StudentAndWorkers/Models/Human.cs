namespace StudentAndWorkers.Models
{
    using System;

    internal abstract class Human
    {
        internal Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        internal void Print()
        {
            Console.WriteLine($"Human: {this.FirstName} {this.LastName}");
        }
    }
}

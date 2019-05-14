namespace StudentAndWorkers.Models
{
    using System;

    public abstract class Human
    {
        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public void Print()
        {
            Console.WriteLine($"Human: {this.FirstName} {this.LastName}");
        }
    }
}

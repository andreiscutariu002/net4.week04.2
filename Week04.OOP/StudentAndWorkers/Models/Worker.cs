namespace StudentAndWorkers.Models
{
    using System;

    public class Worker : Human
    {
        public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WeekSalary { get; set; }

        public double WorkHoursPerDay { get; set; }

        public double MoneyPerHour()
        {
            return this.WeekSalary / (this.WorkHoursPerDay * 5);
        }

        public new void Print()
        {
            base.Print();

            Console.WriteLine($"\tWeekSalary: {this.WeekSalary}  WorkHoursPerDay: {this.WorkHoursPerDay}  Salariu/ora: {this.MoneyPerHour():0.00}");
            Console.WriteLine();
        }
    }
}

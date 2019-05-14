namespace StudentAndWorkers
{
    using System.Collections.Generic;
    using Models;

    internal class Program
    {
        private static void Main(string[] args)
        {
            // read & print students
            var student1 = new Student("Catalin", "Stanciu", 7.5);
            var student2 = new Student("Andrei", "Teodorescu", 7.9);
            var student3 = new Student("Dan", "Irimia", 9.2);

            var students = new List<Student> {student1, student2, student3};

            foreach (var student in students)
            {
                student.Print();
            }

            // read & print workers
            var worker1 = new Worker("Zoltan", "Argesanu", 750, 8);
            var worker2 = new Worker("Paul", "Odobescu", 650, 8);
            var worker3 = new Worker("Mioara", "Bruma", 800, 8);

            var workers = new List<Worker> { worker1, worker2, worker3 };

            foreach (var worker in workers)
            {
                worker.Print();
            }

            // merge lists

            var list = new List<Human>();

            foreach (var student in students)
            {
                list.Add(student); // can do that, student is a human
            }

            foreach (var worker in workers)
            {
                list.Add(worker); // can do that, worker is a human
            }

            // todo - sort list using bubble sort for now

            foreach (var human in list)
            {
                human.Print();
            }
        }
    }
}

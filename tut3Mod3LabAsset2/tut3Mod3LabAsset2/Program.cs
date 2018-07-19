using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tut3Mod3LabAsset2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList studentList = new ArrayList();

            Student student1 = new Student("juan", "Perez", 5);
            Student student2 = new Student("Laura", "Ramirez", 7);
            Student student3 = new Student("Fabio", "Mendoza", 17);

            Random rand = new Random();

            for (int i= 0; i< 5; i++)
            {
                student1.Addgrade(Math.Round(rand.NextDouble() * 20 + 80, 2));
                student2.Addgrade(Math.Round(rand.NextDouble() * 20 + 80, 2));
                student3.Addgrade(Math.Round(rand.NextDouble() * 20 + 80, 2));
            }

            studentList.Add(student1);
            studentList.Add(student2);
            studentList.Add(student3);

            Console.WriteLine("Student in student list: \n");

            foreach(Student student in studentList)
            {
                Console.WriteLine($"{student.Name} {student.LastName} with id of {student.Id}");
                Console.Write("Grades: ");

                foreach(double grade in student.Grades)
                {
                    Console.Write($"{grade}, ");
                }

                Console.WriteLine("\n");
            }

        }
    }
}

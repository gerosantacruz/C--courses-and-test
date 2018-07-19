using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace tut3Mod3LabAsset2
{
    class Student
    {
        private string name;
        private string lastName;
        private int id;

        private Stack grades = new Stack();

        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Id { get => id; set => id = value; }
        public Stack Grades { get => grades; }

        public Student(string name, string lastName, int Id)
        {
            Name = name;
            LastName = lastName;
            id = Id;
        }

        public void Addgrade(double grade)
        {
            Grades.Push(grade);
        }
    }
}

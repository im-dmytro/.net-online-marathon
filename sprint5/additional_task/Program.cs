using System;
using System.Collections;
using System.Collections.Generic;

namespace additional_task
{

    class Student
    {
        public int Id { get; }
        public string Name { get; }

        public Student(int id, string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                name = "";
            }

            Id = id;
            Name = name;
        }
        public static HashSet<Student> GetCommonStudents(List<Student> studentsList1, List<Student> studentsList2)
        {

            HashSet<Student> students = new HashSet<Student>(studentsList1);
            students.IntersectWith(studentsList2);
            return students;
        }
        public override bool Equals(object obj)
        {

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            else
            {
                Student student = (Student)obj;
                return GetHashCode().Equals(student.GetHashCode());
            }
        }
        public override int GetHashCode() => $"{Id} {Name}".GetHashCode();

    }
    internal class Program
    {

    static void Main(string[] args)
    {

            List<int> numbers = new List<int>();
        numbers.Add(19);
        numbers.Add(21);
        numbers.Add(13);
        numbers.Add(9);
        numbers.Add(32);
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] > 20)
            {
                numbers.RemoveAt(i);
                i--;
            }

        }
        numbers.Insert(2, 1);
        numbers.Sort();
        foreach (var number in numbers)
        {
            Console.Write(number);
        }
    }
}
}

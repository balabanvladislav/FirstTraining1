using System;
using System.Collections;
using System.Collections.Generic;

namespace FirstTraining1
{
    class Program
    {
        public static void Display(SortedList<Student, String> list)
        {
            Console.WriteLine("\nSorted by Surname:");
            Display(new List<Student>(list.Keys));
        }
        public static void Display(List<Student> list)
        {
            foreach (var student in list)
            {
                Console.WriteLine(student.GetInfo());
            }
        }
        static void Main(string[] args)
        {
            var SortedList = new SortedList<Student, string>(new DescComparer());


            List<Student> NotSortedList = new List<Student> {
                new Student("Ovidiu", "Doviciuc"),
                new Student("Ion", "Gorgos", 23, "MI"),
                new Student("Vladislav", "Balaban", 20, "TI")
            };

            // umplem lista sortata cu elementle listei initiale
            foreach (var student in NotSortedList)
            {
                SortedList.Add(student, student.Surname);
            }

            Console.WriteLine("Unsorted List:");
            Display(NotSortedList);

            Display(SortedList);

        }
    }
}

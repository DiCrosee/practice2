using System;
using System.Collections.Generic;

namespace practice2
{
    public class StudentFinder
    {
        public static void FindStudent(List<addstudent> studentsList)
        {
            Console.WriteLine("Введите ФИО ученика для поиска:");
            string fullNameToFind = Console.ReadLine();

            bool found = false;

            foreach (var student in studentsList)
            {
                if (student.FullName == fullNameToFind)
                {
                    Console.WriteLine($"Ученик с ФИО {fullNameToFind} найден:");
                    student.PrintInfo();
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine($"Ученик с ФИО {fullNameToFind} не найден.");
            }
        }
    }
}
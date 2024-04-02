using System;
using System.Collections.Generic;

namespace practice2
{
    public class StudentRemover
    {
        public static void RemoveStudent(List<addstudent> studentsList)
        {
            Console.WriteLine("Введите ФИО ученика для удаления:");
            string fullNameToRemove = Console.ReadLine();

            for (int i = 0; i < studentsList.Count; i++)
            {
                if (studentsList[i].FullName == fullNameToRemove)
                {
                    studentsList.RemoveAt(i);
                    Console.WriteLine($"Ученик с ФИО {fullNameToRemove} удален.");
                    return;
                }
            }

            Console.WriteLine($"Ученик с ФИО {fullNameToRemove} не найден.");
        }
    }
}
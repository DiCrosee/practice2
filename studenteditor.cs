using System;
using System.Collections.Generic;

namespace practice2
{
    public class StudentEditor
    {
        public static void EditStudent(List<addstudent> studentsList)
        {
            Console.WriteLine("Введите ФИО ученика для редактирования:");
            string fullNameToEdit = Console.ReadLine();

            foreach (var student in studentsList)
            {
                if (student.FullName == fullNameToEdit)
                {
                    Console.WriteLine($"Найден ученик {fullNameToEdit}. Введите новые данные:");

                    Console.Write("Номер телефона: ");
                    student.PhoneNumber = Console.ReadLine();
                    Console.Write("Email: ");
                    student.Email = Console.ReadLine();
                    Console.Write("Паспорт: ");
                    student.Passport = Console.ReadLine();
                    Console.Write("Год рождения: ");
                    student.BirthYear = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Данные ученика {fullNameToEdit} успешно обновлены.");
                    return;
                }
            }

            Console.WriteLine($"Ученик с ФИО {fullNameToEdit} не найден.");
        }
    }
}
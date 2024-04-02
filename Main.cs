using System;
using System.Collections.Generic;

namespace practice2
{
    internal class Mains
    {
        static void Main(string[] args)
        {
            List<addstudent> studentsList = new List<addstudent>();

            int menu = -1;
            while (menu != 0)
            {
                Console.WriteLine("\nДобро пожаловать в приложение управления учениками\n\n");
                Console.WriteLine("Что вы хотете сделать?:");
                Console.WriteLine("1. Просмотреть информацию об учениках");
                Console.WriteLine("2. Добавить ученика");
                Console.WriteLine("3. Редактировать ученика");
                Console.WriteLine("4. Найти ученика по ФИО");
                Console.WriteLine("5. Удалить ученика");
                Console.WriteLine("0. Выйти");
                Console.Write("\nВыберите вариант: ");
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("\nИнформация об учениках:");
                        foreach (var student in studentsList)
                        {
                            Console.WriteLine("----------------------------------------------------------");
                            student.PrintInfo();
                            Console.WriteLine("----------------------------------------------------------");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Введите данные студента:");
                        Console.Write("ФИО: ");
                        string fullName = Console.ReadLine();
                        Console.Write("Номер телефона: ");
                        string phoneNumber = Console.ReadLine();
                        Console.Write("Email: ");
                        string email = Console.ReadLine();
                        Console.Write("Паспорт: ");
                        string passport = Console.ReadLine();
                        Console.Write("Год рождения: ");
                        int birthYear = int.Parse(Console.ReadLine());
                        addstudent newStudent = new addstudent(fullName, phoneNumber, email, passport, birthYear);
                        studentsList.Add(newStudent);
                        break;
                    case 3:
                        StudentEditor.EditStudent(studentsList);
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 0:
                        break;
                }
            }
        }
    }
}

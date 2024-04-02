using System;
using System.Collections.Generic;

namespace practice2
{
    internal class Mains
    {
        static void Main(string[] args)
        {

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
                        break;
                    case 2:
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

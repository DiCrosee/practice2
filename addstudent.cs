using System;

namespace practice2
{
    public class addstudent
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Passport { get; set; }
        public int BirthYear { get; set; }

        public addstudent(string fullName, string phoneNumber, string email, string passport, int birthYear)
        {
            FullName = fullName;
            PhoneNumber = phoneNumber;
            Email = email;
            Passport = passport;
            BirthYear = birthYear;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"ФИО: {FullName}");
            Console.WriteLine($"Год рождения: {BirthYear}");
            Console.WriteLine($"Номер телефона: {PhoneNumber}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Паспорт: {Passport}");
        }
    }
}
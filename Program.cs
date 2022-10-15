using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Буторин Валерий Валерьевич";
            string email = "Henry.brooks@mail.ru";

            byte age = 27;
            double pointProgramm = 5;
            double pointMath = 4;
            double pointPhys = 5;
            double allSubjects = 3;

            double avgResult = (pointMath + pointPhys + pointProgramm) / allSubjects;

            string avgResultFormated = avgResult.ToString("#.#");

            string pattern = "ФИО: {0} \nEmail: {1} \nВозраст: {2} лет \n\nБалл по программированию: {3} \nБалл по Математике: {4} \nБалл по Физике: {5}";
            Console.WriteLine(pattern,
                              fullName,
                              email,
                              age,
                              pointProgramm,
                              pointMath,
                              pointPhys);
            Console.ReadKey();

            Console.WriteLine("\nСредний балл по предметам: " + avgResultFormated);
        }
    }
}

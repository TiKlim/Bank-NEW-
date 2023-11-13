using Bank;
using System;
using System.Runtime.CompilerServices;

namespace ConsoleApp2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            SchetInBank schet1 = new SchetInBank();
            SchetInBank schet2 = new SchetInBank();

            while (true)
            {
                Console.WriteLine("> Меню счетов: 1 - Создать первый счёт; 2 - Создать второй счёт; 3 - Открыть первый счёт; 4 - Открыть второй счёт; 5 - Осуществить перевод средств между существующими счетами.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                int scheta = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;
                if (scheta == 1)
                {
                    Console.WriteLine("Здравствуйте. Пожалуйста введите информацию по текущему счёту \n(Номер счёта, Фамилия, Сумма на текщем счёте):");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    schet1.Info(Convert.ToInt32(Console.ReadLine()), Console.ReadLine(), float.Parse(Console.ReadLine()));
                    Console.ForegroundColor = ConsoleColor.White;
                    schet1.Out();
                }
                else if (scheta == 2)
                {
                    Console.WriteLine("Здравствуйте. Пожалуйста введите информацию по текущему счёту \n(Номер счёта, Фамилия, Сумма на текщем счёте):");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    schet2.Info(Convert.ToInt32(Console.ReadLine()), Console.ReadLine(), float.Parse(Console.ReadLine()));
                    Console.ForegroundColor = ConsoleColor.White;
                    schet2.Out();
                }
                else if (scheta == 3)
                {
                    schet1.Otk();
                    schet1.Out();
                }
                else if (scheta == 4) 
                {
                    schet2.Otk();
                    schet2.Out();
                }
                else if (scheta == 5)
                {
                    Console.WriteLine("Введите счёт для перевода первый(1) или второй(2).");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    int schet = Convert.ToInt32(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;
                    if (schet == 1)
                    {
                        Console.WriteLine($"\nВведите сумму которую желаете перевести на другой счет?");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        schet1.Perenos(Convert.ToSingle(Console.ReadLine()), schet2);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (schet == 2)
                    {
                        Console.WriteLine($"\nВведите сумму которую желаете перевести на другой счет?");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        schet2.Perenos(Convert.ToSingle(Console.ReadLine()), schet1);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
            
        }
    }
}


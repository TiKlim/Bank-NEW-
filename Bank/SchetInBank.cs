using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class SchetInBank
    {
        private int nomchet; //Номер счёта
        private string? fio; //ФИО владельца счёта
        private float sum; //Сумма на счету

        public void Info(int nomchet, string? fio, float sum)
        {
            this.nomchet = nomchet;
            this.fio = fio;
            this.sum = sum;

            if (nomchet < 0) //Проверка ввода номера счёта
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("! ОШИБКА !");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Read();
            }
            if (sum < 0) //Проверка ввода суммы 
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("! ОШИБКА !");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Read();
            }
            Console.WriteLine("x-----------------------------");
            Console.WriteLine($"|Информация по текущему счёту: \n|Номер счёта: {nomchet}; \n|Фамилия: {fio}; \n|Сумма на счету: {sum}.");
            Console.WriteLine("x-----------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("> Счёт открыт.");
            Console.ForegroundColor = ConsoleColor.White;

            
        }
        public void Out()
        {
            Console.WriteLine("> Меню операций Вашего счёта: 1 - Добавить деньги на счёт; 2 - Снять деньги со счёта; 3 - Закрыть счёт; 4 - Меню счетов.");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string? vybor = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            switch (vybor)
            {
                case "1":
                    this.Dob(sum);
                    break;
                case "2":
                    this.Umen(sum);
                    break;
                case "3":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("> Счёт закрыт.");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "4":
                    Console.WriteLine("");
                    break;
            }
        }
        public void Otk()
        {
            Console.WriteLine("x-----------------------------");
            Console.WriteLine($"|Информация по текущему счёту: \n|Номер счёта: {nomchet}; \n|Фамилия: {fio}; \n|Сумма на счету: {sum}.");
            Console.WriteLine("x-----------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("> Счёт открыт.");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void Dob(float sum) //Положить на счёт
        {
            Console.WriteLine("> Сколько Вы хотите положить на счёт?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            float dob = float.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            if (dob < 0)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("! ОШИБКА !");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Read();
            }
            sum = dob += sum;
            this.Info(nomchet, fio, sum);
            this.Out();
        }
        public void Umen(float sum) //Снять со счёта
        {
            Console.WriteLine("> Сколько Вы хотите снять со счёта?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            float umen = float.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            if (umen < 0) //Проверки далее
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("! ОШИБКА !");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Read();
            }
            if (umen < sum)
            {
                sum -= umen;
            }
            else if (umen > sum)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("! ОШИБКА !");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine();
                this.Info(nomchet, fio, sum);
            }
            else if (umen == sum)
            {
                this.Obnul(sum);
            }
            this.Info(nomchet, fio, sum);
            this.Out();
        }
        public void Obnul(float sum) //Взять всю сумму
        {
            sum = sum - sum;
            this.Info(nomchet, fio, sum);
            this.Out();
        }
        public void Perenos(float perenos, SchetInBank recipient) // Совершаем перевод денег между двумя счетами
        {
            if (perenos <= sum) // sumPerevod - деньги для перевода
            {
                sum -= perenos; // отнимаем от общ.
                recipient.sum += perenos;
                Console.WriteLine($"На счет: {recipient.nomchet} было переведено: {perenos} рублей");
            }
            else
            {
                Console.WriteLine("Недостаточно средств на счете.");
            }
        }       
    }
}

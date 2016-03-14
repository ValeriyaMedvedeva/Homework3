using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string login;
            string action;
            int act;
            Regex log = new Regex(@"^[A-Za-z](\w[^_]{1,9}$)"); //^-требуем,чтобы в начале строки была буква,\w[^_]{1,9}-от 1 до 10 произвольных алфавитно-цифровых знака без _;
            do
            {
                Console.Clear();
                Console.WriteLine("-Введите 1,чтобы проверить на соответствие с нормами вводимый с консоли пароль");
                Console.WriteLine("-Для выхода выберите режим 0.");
                action = Console.ReadLine();
                if (Int32.TryParse(action, out act))
                {
                    switch (act)
                    {
                        case 1:
                            Console.WriteLine("Введите логин:");
                            login = Console.ReadLine();
                            if (log.IsMatch(login))
                                Console.WriteLine("Логин соответствует всем требованиям");
                            else
                                Console.WriteLine("Логин не соответствует всем требованиям");
                            break;
                        default: act = 0; break;
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели не число!");
                    act = 0;
                }
                Console.ReadKey();
            } while (act != 0);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        public static int Abs(int a)
        {
            if (a < 0) return -a;
            else return a;
        }
        public static double Abs(double a)
        {
            if (a < 0) return -a;
            else return a;
        }
        public static long Abs(long a)
        {
            if (a < 0) return -a;
            else return a;
        }
        public static int PrintfInt()
        {
            bool f = false;
            int chislo = 0;
            while (f == false)
            {
                if (!int.TryParse(Console.ReadLine(), out chislo))
                    Console.WriteLine("Вы ввели не правильный формат числа! Пожалуйста,повторите ввод:");
                else f = true;
            }
            return chislo;
        }
        public static double PrintfDouble()
        {
            bool f = false;
            double chislo = 0;
            while (f == false)
            {
                if (!double.TryParse(Console.ReadLine(), out chislo))
                    Console.WriteLine("Вы ввели не правильный формат числа! Пожалуйста,повторите ввод:");
                else f = true;
            }
            return chislo;
        }
        public static long PrintfLong()
        {
            bool f = false;
            long chislo = 0;
            while (f == false)
            {
                if (!long.TryParse(Console.ReadLine(), out chislo))
                    Console.WriteLine("Вы ввели не правильный формат числа! Пожалуйста,повторите ввод:");
                else f = true;
            }
            return chislo;
        }
        static void Main(string[] args)
        {
            int chislo1;
            double chislo2;
            long chislo3;
            Console.WriteLine("Введите число типа int");
            chislo1 = PrintfInt();
            Console.WriteLine("Введите число типа double");
            chislo2 = PrintfDouble();
            Console.WriteLine("Введите число типа long");
            chislo3 = PrintfLong();
            chislo1 = Abs(chislo1);
            chislo2 = Abs(chislo2);
            chislo3 = Abs(chislo3);
            Console.WriteLine("Данные числа после взятия абсолютного значения:\n{0}   {1}   {2}", chislo1, chislo2, chislo3);
            Console.ReadKey();
        }
    }
}

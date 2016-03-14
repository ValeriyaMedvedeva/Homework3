using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Numbers
    {
        public float x;
        public float y;
        public float z;
        public Numbers()
        {
            x = y = z = 0;
        }
        public static Numbers operator +(Numbers ob1, Numbers ob2)
        {
            Numbers ob3 = new Numbers();
            ob3.x = ob1.x + ob2.x;
            ob3.y = ob1.y + ob2.y;
            ob3.z = ob1.z + ob2.z;
            return ob3;
        }
        public static Numbers operator -(Numbers ob1, Numbers ob2)
        {
            Numbers ob3 = new Numbers();
            ob3.x = ob1.x - ob2.x;
            ob3.y = ob1.y - ob2.y;
            ob3.z = ob1.z - ob2.z;
            return ob3;
        }

    }
    class Program
    {
        public static float Printf()
        {
            bool f = false;
            float chislo = 0;
            while (f == false)
            {
                if (!Single.TryParse(Console.ReadLine(), out chislo))
                    Console.WriteLine("Вы ввели не правильный формат числа! Пожалуйста,повторите ввод:");
                else f = true;
            }
            return chislo;
        }
        static void Main(string[] args)
        {
            Numbers ob1 = new Numbers();
            Numbers ob2 = new Numbers();
            Numbers ob3 = new Numbers();
            Console.WriteLine("Введите 3 координаты первой точки(через Enter):");
            Console.WriteLine("x={0},y={1},z={2}", ob1.x = Printf(), ob1.y = Printf(), ob1.z = Printf());
            Console.WriteLine("Введите 3 координаты второй точки(через Enter):");
            Console.WriteLine("x={0},y={1},z={2}", ob2.x = Printf(), ob2.y = Printf(), ob2.z = Printf());
            ob3 = ob1 + ob2;
            Console.WriteLine("Координаты точки,которая получилась путем сложения двух первых:x={0}, y={1}, z={2}", ob3.x, ob3.y, ob3.z);
            ob3 = ob1 - ob2;
            Console.WriteLine("Координаты точки,которая получилась путем вычетания из первой точки второй:x={0}, y={1}, z={2}", ob3.x, ob3.y, ob3.z);
            Console.Read();
        }
    }
}

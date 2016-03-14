using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            Console.WriteLine("Введите исходный текст:");
            text = Console.ReadLine();
            Console.WriteLine("Исходный текст:\n");
            Console.WriteLine(text);
            Regex Search = new Regex(@"(\b{0,1})([А-Яа-я]|[-]){0,15}[М,м]еталл([А-Яа-я]{0,15})\b{0,1}");   //Ищем слово,начинающееся после слова или первое в строке,оно может начинаться с приставки,далее идет корень слова с большой или
            //маленькой буквы,предусматриваем возможность большого продолжения слова от 0-15 символов,слово заканчивается границей.
            if (Search.IsMatch(text))                            //Если нашли хотя бы одно нужное слово
            {
                MatchCollection mc = Search.Matches(text);      //Создали коллекцию нужных нам слов
                Console.WriteLine("\nИскомые слова:\n");       //Чтобы текст не сливался,два раза перешла на новую строчку
                foreach (var match in mc)
                {
                    Console.WriteLine(match);
                }
            }
            else
                Console.WriteLine("Таких слов в данном тексте не существует");
            Console.Read();
        }
    }
}

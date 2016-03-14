using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    public static class IList
    {
        public static string Enum(this List<string> list)
        {
            string str = "";
            for (int i = 0; i < list.Count; i++)
            {
                if (i != list.Count - 1) str += list[i].ToString() + ",";
                else str += list[i].ToString();
            }
            return str;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>(new string[] { "One", "two", "fhree", "four", "five" });
            Console.WriteLine("Элементы списка:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            string str = list.Enum();
            Console.WriteLine("Элементы списка через запятую в виде строки:");
            Console.WriteLine(str);
            Console.Read();
        }
    }
}

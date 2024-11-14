using System;

namespace param
{
    class Program
    {
        static void ShowColors(string name = "Dima", params string[] favcolors)
        {
            Console.WriteLine("Ваши любимые цвета:");
            foreach (var color in favcolors)
            {
                Console.WriteLine(color);
            }
        }

        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string[] favcolors = new string[3] { "Красный", "Синий", "Зеленый" };

            ShowColors();
        }
    }
}

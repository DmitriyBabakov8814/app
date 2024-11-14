using System.Drawing;

namespace recursion
{
    internal class Program
    {
        static string ShowColor(string username, int userage)
        {
            Console.WriteLine("{0}, вам {1} лет\nНапишите свой любимый цвет на английском с маленькой буквы", username, userage);

            var color = Console.ReadLine();

            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }
            return color;
        }

        static void PrintColors( string[] favcolors)
        {
            Console.WriteLine("Ваши любимые цвета:");
            foreach (string fav in favcolors)
            {
                Console.WriteLine(fav);

            }
        }

        static void Main(string[] args)
        {
            (string name, int age) anketa;
            Console.WriteLine("Введите свое имя");
            anketa.name = Console.ReadLine();
            Console.WriteLine("Введите возраст");
            anketa.age = int.Parse(Console.ReadLine());
            string[] favcolors = new string[3];
            for (int i = 0; i < favcolors.Length; i++)
            {
                
                favcolors[i] = ShowColor(anketa.name, anketa.age);
                
            }
            

            
            PrintColors(favcolors);
            
        }
    }
}

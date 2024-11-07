using System.Xml.Linq;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            int i = 0;


            while (true) 
            {
                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
                Console.WriteLine("Iteration {0}", i);
                string text = Console.ReadLine();
                
                switch (text)
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
                        continue;

                }
                if (text == "stop")
                {
                    Console.WriteLine("Цикл остановлен");
                    break;
                }
                i++;
            }
        }
    }
}

enum DayOfWeek : byte
{
    Monday = 1,
    Tuesday, 
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}
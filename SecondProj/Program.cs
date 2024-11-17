namespace SecondProj
{
    internal class Program
    {

        static void Main(string[] args)
        {



            int x = int.Parse(Console.ReadLine());
            byte y = byte.Parse(Console.ReadLine());

            Console.WriteLine(PowerUp(x, y));
        }


        private static int PowerUp(int x, byte y)
        {

            if (y == 0)
            {
                return 1;
            }
            
            else
            {

                if (y == 1)
                {
                    return x;
                }
                else
                {
                    return x * PowerUp(x, --y);


                }

            }

            
        }


        static decimal Factoriala(decimal x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factoriala(x - 1);
            }
        }




        static void Echo(string phrase, int deep)
        {
            string modif = phrase;
            
            if (modif.Length > 2)
            {
                
                modif = modif.Remove(0, 2);
            }

            Console.BackgroundColor = (ConsoleColor)deep;
            Console.WriteLine("..." + modif);

            if (deep > 1)
            {
                
                Echo(modif, deep - 1);
                
            }


        }


    }


}



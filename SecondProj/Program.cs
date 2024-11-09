namespace SecondProj
{
    internal class Program
    {
        static void Main(string[] args)
        {

            (string name, string surname, string login, int lenlogin, bool pet, double age, string[] favcolors) User;

            for (int i = 0; i < 3; i++)
            {
                
                Console.WriteLine("Введите имя");

                User.name = Console.ReadLine();

                Console.WriteLine("Введите фамилию");

                User.surname = Console.ReadLine();

                Console.WriteLine("Введите логин");

                User.login = Console.ReadLine();

                User.lenlogin = User.login.Length;

                Console.WriteLine("Есть ли у вас животные? Да или Нет");

                if (Console.ReadLine() == "Да")
                {
                    User.pet = true;
                }
                else
                {
                    User.pet = false;
                }

                Console.WriteLine("Введите возраст пользователя");

                User.age = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите три любимых цвета пользователя");

                User.favcolors = new string[3];

                for (int j = 0; j < User.favcolors.Length; j++)
                {
                    User.favcolors[j] = Console.ReadLine();
                }
            }
            
            
            

        }
    }
}

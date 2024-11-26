using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;

namespace oop
{

    class User
    {
        private int age;
        private string login;
        private string email;


        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                if(value.Contains('@'))
                {
                    email = value;
                }
                else
                {
                    Console.WriteLine("Не содержит @");
                }
                
            }
        }

        public string Login
        {
            get
            {
                return login;
            }

            set
            {
                if(value.Length >= 3)
                {
                    login = value;
                }
                else
                {
                    Console.WriteLine("Не менее 3х символов");
                }
            }
        }


        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if(value < 18)
                {
                    Console.WriteLine("нет 18");
                }
                else
                {
                    age = value;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            user.Login = "s24";
            user.Email = "dsm@akdsma";
        }
    }

}

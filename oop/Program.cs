namespace oop
{


    class Human
    {
        public string name;
        public int age;

        public void print()
        {
            Console.WriteLine("Имя: {0}, возраст {1}", name, age);
        }


        public Human()
        {
            name = "null";
            age = 20;
        }



        public Human(string n)
        {
            name = n;
            age = 20;
        }


        public Human(string n, int a)
        {
            name = n;
            age = a;
        }

    }


    struct Animal
    {
        public string petname;
        public int petage;
        public void info()
        {
            Console.WriteLine("Имя {} Возраст {]");
        }

        public Animal(string t)
        {

            petname = t;

        }

    }


    class Pen
    {
        public string color;
        public int cost;

        public void Show()
        {
            Console.WriteLine("Color: {0}, Cost: {1}", color, cost);
        } 

        public Pen()
        {
            color = "Черный";
            cost = 100;

        }

        public Pen(string penColor, int PenCost)
        {
            color = penColor;
            cost = PenCost;
        }



    }




    class Rectangle
    {
        public int x;
        public int y;

        public int Square()
        {
            return x * y;
        }

        public Rectangle()
        {
            x = 6;
            y = 4;
        }



        public Rectangle(int data)
        {
            x = data;
            y = data;
        }

        public Rectangle(int first, int second)
        {
            x = first; 
            y = second;
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            Pen pen = new Pen();
            pen.Show();

            pen = new Pen("Black", 100);
            pen.Show();

            Rectangle rect = new Rectangle();
            Console.WriteLine(rect.Square());

        }
    }
}

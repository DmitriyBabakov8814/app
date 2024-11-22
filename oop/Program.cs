using System.Runtime.Intrinsics.Arm;

namespace oop
{
    class Company
    {
        public string Type;
        public string Name;
    }

    class Department
    {
        public Company company;
        public City city;
    }

    class City
    {
        public string Name;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Department department = GetCurrentDepartment();

            if (department != null)
            {
                Console.WriteLine("У банка {0} есть отделение в {1}", department.company.Name, department.city.Name);

            }

        }

        static Department GetCurrentDepartment()
        {
            Department dep = new Department
            {
                company = new Company { Name = "тесла", Type = "Банк" },
                city = new City { Name = null }
            }; 
            
            


            if (dep.company.Type != null && dep.city.Name != null)
            {
                if (dep.company.Type == "Банк" && dep.city.Name == "Питер")
                {

                   return dep;

                }

                else
                {
                    Console.WriteLine("Неизвестная компания");
                    
                }
            }
            else
            {
                Console.WriteLine("Значения пустые");
            }
            return null;


            
        }
    }


}

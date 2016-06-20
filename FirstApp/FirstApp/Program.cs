using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "Taira";
            string Surname = "Junusova";
            int Age = 25;
            double Salary = 10000.5;
            bool ShortTerm = true;
            if (Age < 10)
            {
                Console.WriteLine("Toddler");
            }
                else if (Age >=18 && Age < 65 && Age != 25)
            {
                Console.WriteLine("young adult"); 
            }
                        else if (Age < 18)
            {
                Console.WriteLine("Teenager");
            }

            Console.WriteLine(Name + " " + Surname + " " + " " + Age + " " + " " + Salary + " " + ShortTerm);
            Console.ReadLine();
        }
    }
}

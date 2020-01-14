using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3
{
    class Program
    {
        static void Main(string[] args)
        {
            City city1 = new City();

            Citizen p1 = new Citizen("John Snow");
            Police police1 = new Police("Not Batman");
            Vampire v1 = new Vampire("Draccula");
            Citizen p2 = new Citizen("Van Helsing");

            city1.addResident(p1);
            city1.addResident(p2);
            city1.addResident(police1);
            city1.addResident(v1);

            string tourAgain;

            

            do
            {
                city1.tourResidents();
                Console.WriteLine("Do you want to tour again? (y/n)");
                tourAgain = Console.ReadLine();
            } while (tourAgain == "y"||tourAgain == "Y");

        }
    }
}

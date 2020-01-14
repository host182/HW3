using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EX3
{
    class City
    {
        private List<Person> residents = new List<Person>();

        public delegate void cityDelegate(Person p);
        cityDelegate handleBecomeVampire;

        public City()
        {
            handleBecomeVampire = (Person p) => { residents.Add(p); };
        }

        public void addResident(Person p)
        {
            residents.Add(p);
        }


        //Modify
        public void tourResidents()
        {
            bool addVampire = false;

            Console.WriteLine("Welcome to our city! Let our citizens introduce themselves!");
            for (int i = 0; i < residents.Count; i++)
            {
                if (residents[i] is Vampire)
                {
                    Console.Write("Something feels evil about the approaching citizen. Do you still approach (Y/N)? : ");
                    string yn = Console.ReadLine();
                    if (yn != "Y")
                    {
                        Console.WriteLine("Good call! That guy gave me the heebie jeebies.");
                    }
                    else
                    {

                        //Capture a pointer to the former tourist's self, and add it as a new vampire to the city
                        Person newVampire = residents[i].speak();
                        handleBecomeVampire(newVampire);
                        break;
                    }
                }
                else
                {
                    residents[i].speak();
                }
                
            }

        }

        public void addVampire(Person v)
        {
            residents.Add(v);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3
{
    class Vampire : Person
    {
        public Vampire() { }
        public Vampire(string nomen) : base(nomen) { }

        public override Person speak()
        {
            Console.WriteLine("Ssssssss! <Bite!> <Bite!> <Bite!>");
            Console.WriteLine("You've been bitten by a vampire and now are a cursed undead.");
            Console.Write("What was your name in life, former mortal? : ");
            string name;
            name = Console.ReadLine();

            Vampire spawn = new Vampire(name);
            return spawn;
        }
    }
}

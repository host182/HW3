using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3
{
    class Citizen : Person
    {
        public Citizen() { }
        public Citizen(string nomen) : base(nomen) { }

		public override Person speak()
		{
			Console.WriteLine("What a beautiful day! Surely nothing could go wrong.");
			return this;
		}
	}
}

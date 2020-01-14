using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3
{
    class Police : Person
    {
        public Police(){ }
        public Police(string nomen) : base(nomen) { }

		public override Person speak()
		{
			Console.WriteLine("I'm Batman!");
			return this;

		}
	}
}

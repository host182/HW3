using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3
{
	class Person
	{
		public string name { get; set; }

		public Person()
		{
			name = "John Doe";
		}

		public Person(string nomen)
		{
			name = nomen;
		}

		public virtual Person speak()
		{
			Console.WriteLine("Hello, I am a Person.");
			return this;
		}

    }
}

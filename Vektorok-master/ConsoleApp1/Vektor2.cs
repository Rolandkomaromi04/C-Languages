using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Vektor2
	{
		public int x;
		public int y;
		public string nev;

		public Vektor2(int x, int y, string nev)
		{
			this.x = x;
			this.y = y;
			this.nev = nev;
		}

		static double Hossz(int x, int y)
		{
			return Math.Sqrt(x * x + y * y);
		}


		public override string ToString()
		{
			return $"{nev}({x},{y})";
		}

		public static bool Meroleges(Vektor2 V1, Vektor2 V2)
		{
			return V1.x * V2.x + V1.y * V2.y == 0;
		}

		

	}
}

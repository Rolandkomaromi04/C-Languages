using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Komplex : AdatXY, IComparable<Komplex>
	{
		string síknegyed;

		public Komplex(double y, double x, string síknegyed) : base(y, x)
		{
			this.síknegyed = síknegyed;
			this.síknegyed = SíknegyedMeghatározás();
		}
		public override double AbszolútÉrték()
		{
			return Math.Sqrt(x*y +  y*y);
		}

		public override string ToString()
		{
			return $"{x} + {y}*i, abszulútérték: {AbszolútÉrték()}";
		}

		public string SíknegyedMeghatározás()
		{
			if (x >= 0 && y >= 0) return "TopRight";
			if (x >= 0 && y <= 0) return "BottomRight";
			if (x <= 0 && y >= 0) return "TopLeft";
			if (x <= 0 && y <= 0) return "BottomLeft";
			return "None";
		}

		public int CompareTo(Komplex? other)
		{
			return this.AbszolútÉrték().CompareTo(other.AbszolútÉrték());
		}
	}
}

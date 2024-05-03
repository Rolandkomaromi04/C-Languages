using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Háromszög : Sokszög
	{
		
		public Háromszög(double[] oldalak) : base(oldalak)
		{
			if (oldalak.Length < 3)
			{
				this.oldalak = new double[3] {-1, -1,  -1};
			}


				if (!OldalakJók(this.oldalak))
			{
				for (int i = 0; i < 3; i++)
				{
					Console.Write(i + ". oldal: ");
					this.oldalak[i] = double.Parse(Console.ReadLine());
				}
			}
		}

		public bool OldalakJók(double[] oldalak)
		{
			if (oldalak[0] <= 0) return false;
			if (oldalak[1] <= 0) return false;
			if (oldalak[2] <= 0) return false;
			if (oldalak[0] + oldalak[1] < oldalak[2]) return false;
			if (oldalak[1] + oldalak[2] < oldalak[0]) return false;
			if (oldalak[0] + oldalak[2] < oldalak[1]) return false;
			return true;
		}

		public override double Terület()
		{
			double s = Kerület() / 2;
			double T = Math.Sqrt(s * (s - oldalak[0]) * (s - oldalak[1]) * (s - oldalak[2]));
			return T;
		}

		public override string? ToString()
		{
			return $"({oldalak[0]},{oldalak[1]},{oldalak[2]}), T={Terület()}";
		}
	}
}

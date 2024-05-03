using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal abstract class Sokszög
	{
		protected double[] oldalak;

		public Sokszög(double[] oldalak)
		{
			this.oldalak = oldalak;
		}

		public double Kerület()
		{
			double k = 0;
			for (int i = 0; i <oldalak.Length; i++)
			{
				k += oldalak[i];

			}
			return k;
		}
		public abstract double Terület();
		
	}
}

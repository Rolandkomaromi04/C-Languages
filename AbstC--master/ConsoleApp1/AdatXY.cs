using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal abstract class AdatXY
	{
		protected double x, y;

		public AdatXY(double y, double x)
		{
			this.y = y;
			this.x = x;
		}
		public void Setx(double x)
		{
			this.x = x;
		}
		public void Sety(double y)
		{
			this.y = y;
		}
		public double Getx()
		{
			return this.x;
		}
		public double Gety()
		{
			return this.y;
		}
		public abstract double AbszolútÉrték();
	}
}

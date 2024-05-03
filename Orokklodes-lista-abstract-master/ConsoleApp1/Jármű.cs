using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal abstract class Jármű
	{
		protected int teljesítmény;
		protected int kerekek_száma;

		public Jármű(int teljesítmény, int kerekek_száma)
		{
			this.teljesítmény = teljesítmény;
			this.kerekek_száma = kerekek_száma;
		}

		public override string? ToString()
		{
			return $"Teljesítmény: {teljesítmény}, Kerekek száma: {kerekek_száma} db";
		}
		public void Megy()
		{
			Console.WriteLine("Megyek");
		}

		public abstract void Hangot_ad();

	}
}

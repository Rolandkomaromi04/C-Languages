using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Személygépkocsi : Jármű
	{
		string rendszám;
		string üzemeltető;

		public Személygépkocsi(int teljesítmény, string rendszám, string üzemeltető) : base(teljesítmény, 4)
		{
			this.rendszám = rendszám;
			this.üzemeltető = üzemeltető;
		}

		public override void Hangot_ad()
		{
			Console.WriteLine("Brrrrrrrrrrr..."); ;
		}

		public override string? ToString()
		{
			return $"Teljesítmény: {teljesítmény}, Rendszám: {rendszám}, üzemeltető: {üzemeltető}";
		}
	}
}

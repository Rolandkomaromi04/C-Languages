namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");

			//Jármű j0 = new Jármű(30, 2);
			//Console.WriteLine(j0);


			Személygépkocsi gk = new Személygépkocsi(110, "AAJS-074", "Gipsz Jakab");
			Console.WriteLine(gk);


			gk.Megy();

			gk.Hangot_ad();

			List<int> lista = new List<int>();
			Console.WriteLine(lista.Count);

			lista.Add(12);
			lista.Add(23);
			lista.Add(9);
			lista.Insert(1, 114);
			lista.RemoveAt(0);

			for (int i = 0; i < lista.Count; i++)
			{
				Console.Write(lista[i] + ", ");
			}

			Console.WriteLine();
			Console.WriteLine("Foreachel");

			foreach (var item in lista)
			{
				Console.WriteLine(item);
			}
		}
	}
}

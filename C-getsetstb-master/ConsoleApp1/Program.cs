namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");

			Versenyző v = new Versenyző (3, "Próba Péter");

			v.eredmények.Add(244);
			v.eredmények.Add(212);
			v.eredmények.Add(333);

			Console.WriteLine(v);

			StreamReader sr = new StreamReader("C:/Munka/VS/ConsoleApp1/teszt.txt");

			List<Versenyző> lista = new List<Versenyző>();

			while (!sr.EndOfStream)
			{
				string line = sr.ReadLine();
				string[] d = line.Split();
				int id = int.Parse(d[0].Substring(1));
				string név = d[1] + " " + d[2];
				Versenyző v0 = new Versenyző(id, név);

				for (int i = 3; i < d.Length; i++)
				{
					v0.eredmények.Add(int.Parse(d[i]));
				}

				lista.Add(v0);
			}

			sr.Close();

			foreach (var item in lista)
			{
				Console.WriteLine(item);
			}

			Console.WriteLine("Rendezve: ");

			lista.Sort();

			foreach (var item in lista)
			{
				Console.WriteLine(item);
			}
		}
	}
}

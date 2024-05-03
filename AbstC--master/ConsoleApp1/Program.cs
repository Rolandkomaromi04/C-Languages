namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");

			Komplex k = new Komplex(3.0, 4.0, "TopRight");
			Console.WriteLine(k);

			StreamReader sr = new StreamReader("C:/Munka/komplex.txt");

			List<Komplex> klista = new List<Komplex>();

			while(!sr.EndOfStream)
			{
				string line = sr.ReadLine();
				string[] d = line.Split();

				double x = double.Parse(d[0]);
				double y = double.Parse(d[1]);
				string sínegyed = d[2];

				Komplex k1 = new Komplex(x, y, sínegyed);
				klista.Add(k1);
			}

			sr.Close();
			Console.WriteLine("Eredeti: ");
			foreach (var item in klista)
			{
				Console.WriteLine(item);
			}

			klista.Sort();
			Console.WriteLine("Rendezett: ");
			foreach (var item in klista)
			{
				Console.WriteLine(item);
			}
		}

	}
}

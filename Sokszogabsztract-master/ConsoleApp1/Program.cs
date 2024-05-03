namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double[] oldalak = new double[2] {3, 4};

			

			Háromszög h = new Háromszög(oldalak);

			Console.WriteLine(h);

			Console.WriteLine(h.Kerület());

			Console.WriteLine(h.Terület());

			StreamReader sr = new StreamReader("C:/Munka/teszt.txt");

			List<Háromszög> lista = new List<Háromszög>();

			while(!sr.EndOfStream)
			{
				string sor = sr.ReadLine();
				string[] d = sor.Split();
				double[] old = new double[3];
				old[0] = double.Parse(d[0]);
				old[1] = double.Parse(d[1]);
				old[2] = double.Parse(d[2]);
				Háromszög h1 = new Háromszög(old);
				lista.Add(h1);
			}
			sr.Close();

			foreach (var item in lista)
			{
				Console.WriteLine(item);
			}
		}
	}
}

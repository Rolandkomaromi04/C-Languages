namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{

			StreamReader sr = new StreamReader("C:/Munka/teszt.txt");

			int n = int.Parse(sr.ReadLine());

			Vektor2[] tmb = new Vektor2[n];
			int i = 0;

			while(!sr.EndOfStream)
			{
				string sor = sr.ReadLine();
				string[] d = sor.Split();
				string név = d[0].Substring(0, d[0].Length-1);
				int x = int.Parse((string)d[1]);
				int y = int.Parse((string)d[2]);

				Vektor2 v = new Vektor2(név, x, y);

				tmb[i] = v;
				i++;

				for (int j = 0; j < tmb.Length; j++)
				{
					Console.WriteLine(tmb[j]);
				}
			}
		}
	}
}

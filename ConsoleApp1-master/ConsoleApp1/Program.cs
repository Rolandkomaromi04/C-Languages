namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] teszt1 = new int[] { 3, 5, 11, 7, 9 };
			int[] teszt2 = new int[] { 5, 2, 11, 7, 4, 9, 2, 0, 1 };

			Sor a = new Sor("A1", 8, teszt1);

			Console.WriteLine(a.ToString());

			a.Push(13);

			Console.WriteLine(a.ToString());

			Console.WriteLine(a.Read());

			a.RandomFill();
			Console.WriteLine(a);

			Console.WriteLine(Sor.ContainsPair(a, 3, 11));
		}
	}
}

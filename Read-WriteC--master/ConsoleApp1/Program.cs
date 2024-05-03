namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("Hello, World!");

			//string[] sorok = File.ReadAllLines("c:/Munka/teszt.txt");

			//for (int i = 0; i < sorok.Length; i++)
			//{
			//	Console.WriteLine($"{i}. sor: {sorok[i]}");
			//}
			string text = "";
			try
			{
				text = File.ReadAllText("c:/Munka/teszt.txt");
				Console.WriteLine("Az egész fájl egyben: ");
				Console.WriteLine(text);

			}
			catch(Exception e) {
				Console.WriteLine(e.Message);
			}

			try
			{

				string text_with_coma = text.Replace(".", ",");

				StreamWriter sw = new StreamWriter("C:/Munka/write_teszt.txt");

				sw.WriteLine(text_with_coma);

				sw.Close();

				//vagy


				File.WriteAllText("C:/Munka/write_teszt.txt", text_with_coma);
				//File.AppendAllText("C:/Munka/write_teszt.txt", text_with_coma);

			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}

		}
	}
}

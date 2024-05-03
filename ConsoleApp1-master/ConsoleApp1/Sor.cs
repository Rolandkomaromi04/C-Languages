using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Sor
	{
		string név;
		int hossz;
		int[] data;

		public Sor(string név, int hossz, int[] data)
		{
			this.név = név;
			this.hossz = hossz;
			

			if(hossz > 0 )
			{
				this.hossz = hossz;
			}
			else
			{
				this.hossz = 10;
			}

			this.data = new int[this.hossz];

			for (int i = 0; i < this.data.Length; i++)
			{
				this.data[i] = -1;
			}
			for (int i = 0; i < data.Length; i++)
			{
				if (i >= this.data.Length) break;
				if (data[i] > 0)
					this.data[i] = data[i];
			}
		}
		public override string ToString()
		{
			string s = név + " ";
			for (int i = 0; i < data.Length; i++)
			{
				s += data[i] + " ";
			}
			return s;
		}

		public void RandomFill()
		{
			Random r = new Random();

			for (int i = 0; i < data.Length; i++)
			{
				data[i] = r.Next(1, 101);
			}
		}

		public void Push(int n)
		{
			for (int i = data.Length-2; i <= 0; i--)
			{
				data[i + 1] = data[i]; 
			}
			data[0] = n;
		}

		public int Read()
		{
			for (int i = data.Length - 1; i <= 0; i--)
			{
				if (data[i] > -1)
					return data[i];
			}
			return data[0];
		}

		public static bool ContainsPair(Sor s, int x, int y)
		{
			return true;
		}

	}

}

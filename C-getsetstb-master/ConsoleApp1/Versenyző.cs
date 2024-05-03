using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Versenyző : IComparable<Versenyző>
	{
		private int id;
		private string név;
		public List<int> eredmények;

		public Versenyző(int id, string név)
		{
			this.id = id;
			this.név = név;
			eredmények = new List<int>();
		}
		public void SetId(int id)
		{
			this.id = id;
		}
		public void SetNév(string név)
		{
			this.név = név;
		}
		public int LegjobbUgrás()
		{
			if(eredmények.Count == 0)
				return -1;
			return eredmények.Max();
		}
		public override string ToString()
		{
			int legjobb = LegjobbUgrás();
			string eredményekStr = string.Join(", ", eredmények);
			return $"{id} {név}, eredményei: {eredményekStr},Legjobb: {legjobb}";
		}

		public int CompareTo(Versenyző? other)
		{
			return other.LegjobbUgrás().CompareTo(this.LegjobbUgrás());
		}
	}
}

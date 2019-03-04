using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Count8Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			NumberCounter counter = new NumberCounter();

			int total = 0;
			for (int i = 1; i <= 10000; ++i)
			{
				total += counter.Count(i);
			}

			Console.WriteLine("total count: " + total.ToString());
		}
	}
}

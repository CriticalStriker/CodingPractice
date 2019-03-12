using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * 1부터 10,000까지 8이라는 숫자가 총 몇번 나오는가?

 * 8이 포함되어 있는 숫자의 갯수를 카운팅 하는 것이 아니라 8이라는 숫자를 모두 카운팅 해야 한다.
 * (※ 예를들어 8808은 3, 8888은 4로 카운팅 해야 함)
 * 
 */

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

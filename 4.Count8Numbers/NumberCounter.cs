using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Count8Numbers
{
	public class NumberCounter
	{
		private char Number = '8';

		public NumberCounter()
		{
		}

		public NumberCounter(char number)
		{
			this.Number = number;
		}

		public int Count(int value)
		{
			int count = 0;
			string valueText = System.Convert.ToString(value);

			foreach (char c in valueText)
			{
				if (c == Number)
				{
					count += 1;
				}
			}

			return count;
		}
	}
}

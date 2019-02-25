using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplesOf3And5
{
	public class MultiplesFinder
	{
		protected List<int> Numbers = new List<int>() { 3, 5 };

		public void Init(int[] numbers)
		{
			this.Numbers.AddRange(numbers);
		}

		protected bool IsMultiple(List<int> numbers, int value)
		{
			bool isMultiple = false;

			numbers.ForEach(elem => isMultiple = (isMultiple || (value % elem == 0)));

			return isMultiple;
		}

		public virtual int DoIt(int limit)
		{
			int result = 0;
			for (int i = 1; i < limit; ++i)
			{
				if (IsMultiple(this.Numbers, i))
				{
					result += i;
				}
			}

			return result;
		}
	}
}

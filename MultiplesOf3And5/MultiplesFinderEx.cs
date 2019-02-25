using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplesOf3And5
{
	public class MultiplesFinderEx : MultiplesFinder
	{
		
		public override int DoIt(int limit)
		{
			int result = 0;

			List<int> numbersClone = new List<int>(this.Numbers);
			List<int> passedStepNumbers = new List<int>();

			foreach (var number in numbersClone)
			{
				int stepNumber = 0;
				int originNumber = number;

				for (int step = 1; stepNumber < limit; ++step)
				{
					if (IsMultiple(passedStepNumbers, stepNumber) == false)
					{
						result += stepNumber;
					}

					stepNumber = originNumber * step;
				}

				passedStepNumbers.Add(number);
			}

			return result;
		}
	}
}

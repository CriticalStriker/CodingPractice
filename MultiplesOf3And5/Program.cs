using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 
/// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
/// Find the sum of all the multiples of 3 or 5 below 1000.
/// 
/// 10미만의 자연수에서 3과 5의 배수를 구하면 3,5,6,9이다. 이들의 총합은 23이다.
/// 1000미만의 자연수에서 3,5의 배수의 총합을 구하라.
/// 
/// </summary>
namespace MultiplesOf3And5
{
	class Program
	{
		static void Main(string[] args)
		{
			int limitNumber = System.Convert.ToInt32(args[0]);

			Console.WriteLine("below: " + limitNumber.ToString());

			var finder = new MultiplesFinder();
			var sum1 = finder.DoIt(limitNumber);

			Console.WriteLine("sum: " + sum1.ToString());

			var finderEx = new MultiplesFinderEx();
			var sum2 = finderEx.DoIt(limitNumber);

			Console.WriteLine("sum: " + sum2.ToString());
		}
	}
}

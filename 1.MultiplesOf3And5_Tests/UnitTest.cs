using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using MultiplesOf3And5;

namespace MultiplesOf3And5_Tests
{
	[TestClass]
	public class UnitTest
	{
		int limitNumber = 1000;
		int solvedResult = 233168;

		[TestMethod]
		public void ExecuteMultiplesFinder()
		{
			var finder = new MultiplesFinder();
			var sum = finder.DoIt(limitNumber);

			Assert.IsTrue(sum == solvedResult);
		}

		[TestMethod]
		public void ExecuteMultiplesFinderEx()
		{
			var finder = new MultiplesFinderEx();
			var sum = finder.DoIt(limitNumber);

			Assert.IsTrue(sum == solvedResult);
		}
	}
}

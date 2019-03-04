using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using _4.Count8Numbers;

namespace _4.Count8Numbers_Tests
{
	[TestClass]
	public class UnitTest
	{
		[TestMethod]
		public void Count8Numbers()
		{
			NumberCounter counter = new NumberCounter();

			var result = counter.Count(8888);

			Assert.IsTrue(result == 4);
		}
	}
}

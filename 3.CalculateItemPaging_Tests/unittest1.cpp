#include "stdafx.h"
#include "CppUnitTest.h"

#include <assert.h>
#include "../3.CalculateItemPaging/PagingCalculater.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace My3CalculateItemPaging_Tests
{		
	TEST_CLASS(UnitTest1)
	{
	public:
		
		TEST_METHOD(TestMethod_M0N1)
		{
			PagingCalculater calculater;
			int pageCount = calculater.Calculate(0, 1);

			Assert::IsTrue(pageCount == 0);
		}

		TEST_METHOD(TestMethod_M1N1)
		{
			PagingCalculater calculater;
			int pageCount = calculater.Calculate(1, 1);

			Assert::IsTrue(pageCount == 1);
		}

		TEST_METHOD(TestMethod_M2N1)
		{
			PagingCalculater calculater;
			int pageCount = calculater.Calculate(2, 1);

			Assert::IsTrue(pageCount == 2);
		}

		TEST_METHOD(TestMethod_M1N10)
		{
			PagingCalculater calculater;
			int pageCount = calculater.Calculate(1, 10);

			Assert::IsTrue(pageCount == 1);
		}

		TEST_METHOD(TestMethod_M10N10)
		{
			PagingCalculater calculater;
			int pageCount = calculater.Calculate(10, 10);

			Assert::IsTrue(pageCount == 1);
		}

		TEST_METHOD(TestMethod_M11N10)
		{
			PagingCalculater calculater;
			int pageCount = calculater.Calculate(11, 10);

			Assert::IsTrue(pageCount == 2);
		}

	};
}
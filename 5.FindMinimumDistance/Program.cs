using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 1차원의 점들이 주어졌을 때, 그 중 가장 거리가 짧은 것의 쌍을 출력하는 함수를 작성하시오. (단 점들의 배열은 모두 정렬되어있다고 가정한다.)

 예를들어 S={1, 3, 4, 8, 13, 17, 20} 이 주어졌다면, 결과값은 (3, 4)가 될 것이다.
 * 
 */

namespace _5.FindMinimumDistance
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] s = new int[] { 1, 3, 4, 8, 13, 17, 20 };

			var distanceCalculator = new DistanceCalculator();

			distanceCalculator.Calculate(s);

			/// Console.WriteLine("maximum distance: " + distanceCalculator.MaxHolder);
			Console.WriteLine("minimum distance: " + distanceCalculator.MinHolder);
		}
	}
}

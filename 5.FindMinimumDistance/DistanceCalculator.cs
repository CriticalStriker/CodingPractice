using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.FindMinimumDistance
{
#pragma warning disable CS0660 // 형식은 == 연산자 또는 != 연산자를 정의하지만 Object.Equals(object o)를 재정의하지 않습니다.
#pragma warning disable CS0661 // 형식은 == 연산자 또는 != 연산자를 정의하지만 Object.GetHashCode()를 재정의하지 않습니다.
	public class DistanceHolder
#pragma warning restore CS0661 // 형식은 == 연산자 또는 != 연산자를 정의하지만 Object.GetHashCode()를 재정의하지 않습니다.
#pragma warning restore CS0660 // 형식은 == 연산자 또는 != 연산자를 정의하지만 Object.Equals(object o)를 재정의하지 않습니다.
	{
		public int A, B = 0;
		public int Distance = 0;

		public DistanceHolder(int a, int b)
		{
			this.A = a;
			this.B = b;

			this.Distance = B - A;
		}

		public override string ToString()
		{
			return string.Format("({0}, {1}) -> {2}", this.A, this.B, this.Distance);
		}

		public static bool operator <(DistanceHolder lhs, DistanceHolder rhs)
		{
			return (lhs.Distance < rhs.Distance);
		}

		public static bool operator >(DistanceHolder lhs, DistanceHolder rhs)
		{
			return (lhs.Distance > rhs.Distance);
		}

		public static bool operator ==(DistanceHolder lhs, DistanceHolder rhs)
		{
			return (lhs.Distance == rhs.Distance);
		}

		public static bool operator !=(DistanceHolder lhs, DistanceHolder rhs)
		{
			return (lhs.Distance != rhs.Distance);
		}

		public static bool operator <=(DistanceHolder lhs, DistanceHolder rhs)
		{
			return (lhs.Distance <= rhs.Distance);
		}

		public static bool operator >=(DistanceHolder lhs, DistanceHolder rhs)
		{
			return (lhs.Distance >= rhs.Distance);
		}
	}

	public class DistanceCalculator
	{
		private List<DistanceHolder> Holders = new List<DistanceHolder>();

		public DistanceHolder MinHolder = null;
		public DistanceHolder MaxHolder = null;

		public void Calculate(int[] points)
		{
			MinHolder = new DistanceHolder(points[0], points[1]);
			MaxHolder = new DistanceHolder(points[0], points[1]);

			for (int i = 2; i < points.Length; ++i)
			{
				var holder = new DistanceHolder(points[i - 1], points[i]);

				if (MinHolder > holder)
				{
					MinHolder = holder;
				}

				if (MaxHolder < holder)
				{
					MaxHolder = holder;
				}
			}
		}
	}
}

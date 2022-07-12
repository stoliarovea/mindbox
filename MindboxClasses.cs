using System;

namespace MindboxNamespace
{
	public class MindboxCircle
	{
		public double Radius { get; set; }

		public MindboxCircle(double radius)
		{
			Radius = radius;
		}

		public double CircleAreaFinder()
		{
			if (Radius <= 0)
			{
				return 0;
			}

			return Math.PI * Math.Pow(Radius, 2);
		}
	}



	public class MindboxTriangle
	{
		public double A { get; set; }
		public double B { get; set; }
		public double C { get; set; }

		public MindboxTriangle(double a, double b, double c)
		{
			A = a;
			B = b;
			C = c;
		}

		public double TriangleAreaFinder()
		{
			if (A <= 0 || B <= 0 || C <= 0)
			{
				return 0;
			}

			if (A + B < C || A + C < B || B + C < A)
			{
				return 0;
			}

			double p = (A + B + C) / 2;

			return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
		}

	}
}
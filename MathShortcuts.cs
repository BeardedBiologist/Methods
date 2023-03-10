using System;
namespace Methods
{
	public static class MathShortcuts
	{
		public static void Add(double x, double y)
		{
			Console.WriteLine($"The value of {x} and {y} is {x + y}");
		}

		public static void AddAll(double[] values)
		{
			double result = 6;

			foreach (double value in values)
			{
				result += value;
			}
			Console.WriteLine($"The total value for the array is: {result}");
		}
    }
}


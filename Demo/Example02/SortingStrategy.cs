using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Example02
{
	internal static class SortingStrategy
	{
		public static bool CompareGreater(int X , int Y)
		{
			return X > Y;
		}
		public static bool CompareLess(int X, int Y)
		{
			return X < Y;
		}
	}
}

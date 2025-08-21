using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Example02
{
	public delegate bool SortingStrategyFuncDelegate(int A, int B);
	internal static class SortingAlgorithms
	{
		public static void BubbleSort(int[] Arr, SortingStrategyFuncDelegate? sortingStrategy)
		{
			if (Arr?.Length > 0 && sortingStrategy is not null)
				for (int i = 0; i < Arr.Length; i++)
					for (int j = 0; j < Arr.Length - 1 - i; j++)
						if (sortingStrategy(Arr[j], Arr[j + 1]))
							Swap(ref Arr[j], ref Arr[j + 1]);
		}



		private static void Swap(ref int v1, ref int v2)
		{
			int temp = v1;
			v1 = v2;
			v2 = temp;
		}
	}
}

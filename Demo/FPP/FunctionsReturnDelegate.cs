using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.FPP
{
	internal static class FunctionsReturnDelegate
	{
		public static Action DelegateAction()
		{
			return delegate () { Console.WriteLine("Hello Route"); };
		}
		public static Predicate<int> DelegatePredicate()
		{
			return delegate(int X) { return X > 0;  };
		}

		public static Func<char[] , string> DelegateFunc()
		{
			return delegate (char[] chars) { return new string(chars);};
		}

	}
}

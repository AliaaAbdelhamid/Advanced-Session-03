using Demo.Example01;
using Demo.Example02;

namespace Demo
{
	// Step 0 : Defining a Delegate
	public delegate int StringFuncDelegate(string s);
    // New Delegate [Class]
    // Reference From This Delegate Can Refer To 
    // One Function Or More [Pointer To Function]
    // This Functions May Be Static Function Or Non Static Function 
    // But These Function Must Be With The Same Signature Of Delegate
    // Regardless Function Name and Access Modifier 

    internal class Program
    {    
        static void Main(string[] args)
        {
			#region Example 01
			//         // Step 01 : Declare reference From Delegate 
			//         StringFuncDelegate? stringFunc;

			//// Step 02 : Initialize Reference From Delegate[Pointer To Function]

			//         stringFunc = StringFunctions.GetCountOfUpperCaseChar; // Syntax Sugar

			//         stringFunc += StringFunctions.GetCountOfLowerCaseChar;
			//         // Add New Reference For Function To Reference From Delegate 

			//         stringFunc -= StringFunctions.GetCountOfUpperCaseChar;
			//// Remove Reference Of GetCountOfUpperCaseChar() Method

			//// Step 03 : Use Delegate Reference [Invoke Method]

			//int Result = stringFunc?.Invoke("RoutE") ?? 0;

			//         //Result = stringFunc("RoutE");
			//if (stringFunc != null)
			//	Result = stringFunc("RoutE");
			//else
			//	Result = 0;

			//Console.WriteLine(Result); // 2 
			#endregion

			#region Example 02
			
			//int[] Numbers = { 7, 6, 5, 8, 9, 4, 1, 3, 2 };

			//SortingAlgorithms.BubbleSort(Numbers , SortingStrategy.CompareGreater); // To Sort In Asc

			//SortingStrategyFuncDelegate? sortingStrategy = default;

			//SortingAlgorithms.BubbleSort(Numbers , sortingStrategy); // To Sort In Desc

			//foreach (int item in Numbers) Console.Write($"{item} ");

			#endregion

		}
	}
}

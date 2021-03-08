using System;
using System.Runtime.InteropServices;

namespace ConsoleApp4
{
	class Program
	{
		public struct MyStruct
		{
			public int a,b;
			public MyStruct(int v1 , int v2)
			{
				a = v1;
				b = v2;
			}
		}
		public const string CppFunctionsDLL=@"..\..\..\Debug\test.dll";
		[DllImport(CppFunctionsDLL , CallingConvention = CallingConvention.Cdecl)]
		public static extern int AddNumbers(MyStruct vals);
		[DllImport(CppFunctionsDLL , CallingConvention = CallingConvention.Cdecl)]
		public static extern int SubtractNumbers(MyStruct vals);
		static void Main()
		{
			//return;
			int x,y;
			if(Int32.TryParse(Console.ReadLine() , out x) && Int32.TryParse(Console.ReadLine() , out y))
			{
				MyStruct testVals= new MyStruct(x,y);
				Console.WriteLine(AddNumbers(testVals));
				Console.WriteLine(SubtractNumbers(testVals));
			}
		}
	}
}

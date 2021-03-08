#define MyFunctions _declspec(dllexport)

struct MyStruct
{
	int a, b;
};

extern "C"
{
	MyFunctions int AddNumbers(MyStruct vals)
	{
		return vals.a + vals.b;
	}

	MyFunctions int SubtractNumbers(MyStruct vals)
	{
		return vals.a - vals.b;
	}
}
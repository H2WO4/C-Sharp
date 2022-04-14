namespace Cursed;

public static unsafe class Program
{
	public static void Main(string[] args)
	{
		var foo = "Hello World";
		fixed(char* p = foo)
			Caesar(p, 1);

		Console.WriteLine(foo); // Ifmmp Xpsme
	}

	private static void Caesar(char* c, int offset)
	{
		for (; *c != '\0'; c++)
		{
			if (*c is >= 'A' and <= 'Z' or >= 'a' and <= 'z')
				*c += (char)offset;
		}
	}
}
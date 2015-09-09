using System;

namespace RandomUtils.Sample
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("bool\t" + RandomUtils.NextBoolean());
			Console.WriteLine("int\t" + RandomUtils.NextInt());
			Console.WriteLine("long\t" + RandomUtils.NextLong());
			Console.WriteLine("float\t" + RandomUtils.NextFloat());
			Console.WriteLine("double\t" + RandomUtils.NextDouble());
		}
	}
}

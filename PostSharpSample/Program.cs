using System;

namespace PostSharpSample
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Start Main");

				new Sample().Execute();

			Console.WriteLine("End Main");
			Console.Read();
		}
	}
}

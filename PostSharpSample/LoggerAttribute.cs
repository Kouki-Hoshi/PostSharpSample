using PostSharp.Aspects;
using PostSharp.Serialization;
using System;

namespace PostSharpSample
{
	[PSerializable]
	class LoggerAttribute : OnMethodBoundaryAspect
	{

		public override void OnEntry(MethodExecutionArgs args)
		{
			Console.WriteLine("OnEntry {0}", args.Exception);
		}

		public override void OnExit(MethodExecutionArgs args)
		{
			Console.WriteLine("OnExit {0}", args.Exception);
		}
	}
}

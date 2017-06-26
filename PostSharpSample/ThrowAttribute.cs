using PostSharp.Aspects;
using PostSharp.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostSharpSample
{
    [PSerializable]
	class ThrowAttribute : OnMethodBoundaryAspect
	{

		public override void OnException(MethodExecutionArgs args)
		{
			Console.WriteLine("OnException {0}", args.Exception.Message);
		}

	}
}

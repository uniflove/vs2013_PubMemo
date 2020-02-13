using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrWebMemo01
{
	class Logger
	{
		public static void mark()
		{
			StackTrace stackTrace = new StackTrace();
			Debug.WriteLine(stackTrace.GetFrame(1).GetMethod().Name + "()");
		}
	}
}

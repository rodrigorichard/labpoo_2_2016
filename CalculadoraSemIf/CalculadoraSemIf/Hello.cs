using System;

namespace CalculadoraSemIf
{
	public abstract class Hello
	{
		public Hello ()
		{
		}

		public string sayHello(){
			return "Good " + moment ();
		}

		public abstract string moment();
	}
}


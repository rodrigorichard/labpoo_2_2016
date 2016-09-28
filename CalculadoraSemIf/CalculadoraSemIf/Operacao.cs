using System;

namespace CalculadoraSemIf
{
	public abstract class Operacao
	{
		public Operacao ()
		{
		}

		public abstract int executa (Numero n1, Numero n2);
	}
}


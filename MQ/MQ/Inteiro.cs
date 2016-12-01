using System;

namespace MQ
{
	public class Inteiro : Tipo
	{
		public Inteiro (object valor): base(valor){}

		public static Tipo operator +(Inteiro i1, Inteiro i2){
			return new Tipo((int) i1.valor + (int) i2.valor);
		}

		public static Tipo operator -(Inteiro i1, Inteiro i2){
			return new Tipo((int) i1.valor - (int) i2.valor);
		}

		public override string ToString ()
		{
			return this.valor.ToString ();
		}
	}
}


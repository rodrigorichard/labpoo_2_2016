using System;

namespace TipoParametrizado
{
	public class Podio<T> where T : TemNome
	{
		private T[] elementos;

		public Podio (T[] elementos)
		{
			this.elementos = elementos;
		}

		public T primeiro(){
			return elementos [0];
		}
		public T segundo(){
			return elementos [1];
		}
		public T terceiro(){
			return elementos [2];
		}

		public void imprimePodio(){
			Console.WriteLine("Primeiro Lugar:{0}",this.primeiro().meuNome());
			Console.WriteLine("Segundo Lugar:{0}",this.segundo().meuNome());
			Console.WriteLine("Terceiro Lugar:{0}",this.terceiro().meuNome());

		}

	}
}


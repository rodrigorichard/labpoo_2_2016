using System;

namespace Xatty
{
	public class Usuario : IUser
	{

		public string Id { get;set;}
		private string nome;
		private string sobrenome;



		public string getId ()
		{
			return this.Id;
		}

		public string getDisplayName ()
		{
			return nome + " " + sobrenome;
		}

		public Usuario (string nome, string sobrenome)
		{
			this.Id = System.Guid.NewGuid ().ToString();
			this.nome = nome;
			this.sobrenome = sobrenome;

		}

		public void setNome (string nome)
		{
			this.nome = nome;
		}
	}
}


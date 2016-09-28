using System;

namespace AgendaTelefonica
{
	public class Pessoa
	{
		string nome;

		public string Nome { 
			get{ return nome + " " + Sobrenome; } 
			set{ nome = value.ToUpper (); }
		}

		public string Sobrenome{ get; set; }

		public int idade;

		public Pessoa (string nome, string sobrenome)
		{
			this.Nome = nome;
			this.Sobrenome = sobrenome;
		}

		public static Pessoa operator+(Pessoa p1, Pessoa p2){
			Pessoa nova = new Pessoa (p2.nome, p1.Sobrenome);
			return nova;
		}

		public override string ToString ()
		{
			return string.Format ("[Pessoa: Nome={0}, Sobrenome={1}]", Nome, Sobrenome);
		}

		//contato@rarolabs.com.br
	}
}


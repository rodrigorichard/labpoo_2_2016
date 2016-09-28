using System;

namespace CalculadoraSemIf
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			String[] linhas = leiaDoArquivo ();
			Numero n1 = instanciaNumero ("CalculadoraSemIf." + linhas[0]);
			Numero n2 = instanciaNumero ("CalculadoraSemIf." + linhas[1]);
			Operacao op = instanciaOperacao ("CalculadoraSemIf." + linhas[2]);

			Console.WriteLine (op.executa (n1, n2));

		}

		public static Numero instanciaNumero(String numero){
			return (Numero) System.Reflection.Assembly.GetExecutingAssembly ().CreateInstance (numero);
		}
		public static Operacao instanciaOperacao(String operacao){
			return (Operacao) System.Reflection.Assembly.GetExecutingAssembly ().CreateInstance (operacao);
		}

		public static String[] leiaDoArquivo(){

			string[] lines = new string[3];

			// Read the file and display it line by line.
			System.IO.StreamReader file = 
				new System.IO.StreamReader("/Users/rodrigosol/puc/poo/labpoo_2_2016/CalculadoraSemIf/Test2.txt");
			lines[0] = file.ReadLine ();
			lines[1] = file.ReadLine ();
			lines[2] = file.ReadLine ();
			file.Close();
			return lines;

		}

	}
}

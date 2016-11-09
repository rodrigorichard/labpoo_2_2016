using System;

namespace TipoParametrizado
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			CarroDeCorrida[] carros = new CarroDeCorrida[] {
				new CarroDeCorrida ("Uno", "Com Escada"),
				new CarroDeCorrida ("Fusca", "Azul"),
				new CarroDeCorrida ("Ferrari", "California"),
				new CarroDeCorrida ("Fitinho", "147")
			};

			Podio<CarroDeCorrida> podioDeCarros = new Podio<CarroDeCorrida> (carros);


			CavaloDeCorrida[] cavalos = new CavaloDeCorrida[] {
				new CavaloDeCorrida ("Pé de Pano"),
				new CavaloDeCorrida ("My Little Poney"),
				new CavaloDeCorrida ("Spirit"),
				new CavaloDeCorrida ("Agro")
			};

			Podio<CavaloDeCorrida> podioDeCavalos = new Podio<CavaloDeCorrida> (cavalos);
		

			podioDeCarros.imprimePodio ();
			podioDeCavalos.imprimePodio ();


			CarroDeCorrida carro = new CarroDeCorrida ("Relampago", "Marquinhos");

			CavaloDeCorrida cavalo = new CavaloDeCorrida ("Corcel");

			carro.meuNome ();
			carro.meuSobrenome();

			Object o = carro;
			TemNome t1 = carro;
			t1.meuNome ();
			TemSobrenome t2 = carro;
			t2.meuSobrenome ();
			TemNome t3 = cavalo;
			TemSobrenome t4 = (TemSobrenome)o;


		   
		}
	}
}

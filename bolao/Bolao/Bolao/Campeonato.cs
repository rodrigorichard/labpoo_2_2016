using System;
using System.Collections;
using System.Collections.Generic;

namespace Bolao
{
	public class Campeonato
	{
		public int edicao;

		public Dictionary<int,Turno> turnos = 
			new Dictionary<int,Turno>();

		public Dictionary<int,Rodada> rodadas = 
			new Dictionary<int,Rodada>();

		public Dictionary<string,Time> times = 
			new Dictionary<string,Time>();



		public Campeonato ()
		{
		}

		public int pontos(Time time){
			int somaDePontos = 0;
			foreach (Turno t in turnos.Values) {
				foreach (Rodada r in t.rodadas) {
					foreach (Jogo j in r.jogos) {
						somaDePontos += j.pontos (time);
					}
				}
			}
			return somaDePontos;
			
		}

		public void mostrarJogosDaRodada(int numero){
			Rodada r = rodadas [numero];
			foreach (Jogo jogo in r.jogos) {
				Console.WriteLine (jogo);
			}
		}

		public void mostraTimes(){
			foreach (Time t in times.Values) {
				Console.WriteLine (t);
			}

		}


		public void registrar(int turno, int rodada,
			string mandante, string visitante,
			int golsMandante, int golsVisitantes){

			Turno t;
			if (!turnos.ContainsKey (turno)) {
				t = new Turno ();
				t.numero = turno;
				t.campeonato = this;
				t.rodadas = new List<Rodada> ();

				turnos.Add (turno, t);
			} else {
				t = turnos [turno];
			}



			Rodada r;
			if (!rodadas.ContainsKey (rodada)) {
				r = new Rodada ();
				r.numero = rodada;
				r.turno = t;
				t.rodadas.Add (r);
				rodadas.Add (rodada, r);
			} else {
				r = rodadas [rodada];
			}


			Time timeMandante;

			if (!times.ContainsKey (mandante)) {
				timeMandante = new Time ();
				timeMandante.nome = mandante;
				times.Add (mandante, timeMandante);
			} else {
				timeMandante = times [mandante];
			}

			Time timeVisitante;

			if (!times.ContainsKey (visitante)) {
				timeVisitante = new Time ();
				timeVisitante.nome = visitante;
				times.Add (visitante, timeVisitante);
			} else {
				timeVisitante = times [visitante];
			}

			Jogo j = new Jogo ();
			j.mandante = timeMandante;
			j.visitante = timeVisitante;
			j.rodada = r;
			j.golsMandante = golsMandante;
			j.golsVisitante = golsVisitantes;

			r.jogos.Add (j);

		}
	}
}


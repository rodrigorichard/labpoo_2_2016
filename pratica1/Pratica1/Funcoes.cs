using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Pratica1
{
    class Funcoes
    {
        /**
         * Filtra um vetor de formas geometricas pelo tipo:
         * 1 - Pontos
         * 2 - Linhas
         * 3 - Triangulos
         * 4 - Retangulos
         * */
        public List<FormaGeometrica> filtrar(List<FormaGeometrica> formas, Type tipo)
        {
            return formas.FindAll(forma => forma.GetType().Equals(tipo));
            List<int> l = new List<int>();
            l.Add(1);
            l.Add(2);
            l.Add(3);
            l.Add(4);
            l.Add(5);
            l.Add(6);
            foreach(int dobro in l.Select(i => i * 2))
            {
                Console.WriteLine(dobro);
            }

        }

        public void mostraMenu()
        {

        }

        public List<FormaGeometrica> lerArquivo(String nomeArquivo)
        {
            List<FormaGeometrica> formas = new List<FormaGeometrica>();
            Ponto ponto = new Ponto();
            ponto.coordenada = 256;

            formas.Add(ponto);

            Ponto ponto2 = new Ponto();
            ponto2.coordenada = 1024;

            formas.Add(ponto2);

            Linha linha = new Linha();

            Ponto x = new Ponto();
            x.coordenada = 1;
          
            Ponto y = new Ponto();
            y.coordenada = 2;

            linha.origem = x;
            linha.destino = y;

            formas.Add(linha);

            return formas;
        }

        public int areaRetangulo(int b, int a)
        {
            return b * a;
        }
        public float areaTriangulo(int b, int a)
        {
            return (b * a) / 2.0f;
        }

        public void imprimeLista(List<FormaGeometrica> formas) {
            
            foreach (FormaGeometrica forma in formas)
            {
                Console.WriteLine(forma);
            }
                        
        }
    }
}

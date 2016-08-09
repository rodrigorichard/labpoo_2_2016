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
        public List<FormaGeometrica> filtrar(List<FormaGeometrica> formas, int tipo)
        {
            List<FormaGeometrica> encontrados = new List<FormaGeometrica>();
            foreach(FormaGeometrica forma in formas)
            {
                if(tipo == 1 && forma is Ponto)
                {
                    encontrados.Add(forma);
                }else if(tipo == 2 && forma is Linha)
                {
                    encontrados.Add(forma);
                }
            }

            return encontrados;
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

            Ponto origem = new Ponto();
            origem.coordenada = 1;
          
            Ponto destino = new Ponto();
            destino.coordenada = 2;

            linha.origem = origem;
            linha.destino = destino;

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
            foreach(FormaGeometrica forma in formas)
            {
                Console.WriteLine(forma);
            }
        }
    }
}

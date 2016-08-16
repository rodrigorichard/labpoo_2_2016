using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica1
{
    class Program
    {
        static void Main(string[] args)
        {

            //lista.findAll (nome-var => criterio)

            List<int> lista = new List<int>();
            List<int> pares = new List<int>();
            lista.Add(1);
            lista.Add(2);
            lista.Add(3);
            lista.Add(4);
            lista.Add(5);
            lista.Add(6);
            lista.Add(7);
            lista.Add(8);
            lista.Add(9);
            lista.Add(10);

            //lista.FindAll(i => i % 2 == 0).ForEach(par => Console.WriteLine(par));
            Console.WriteLine(lista.Select(i => i * i).Take(3).Sum());
            lista.ForEach(i => Console.WriteLine(Math.Pow(2,i)));





            //Funcoes f = new Funcoes();
            //List<FormaGeometrica> formasLidasDoArquivo = f.lerArquivo("");

            //f.imprimeLista(formasLidasDoArquivo);


            //List<FormaGeometrica> encontrados = f.filtrar(formasLidasDoArquivo, typeof(Triangulo));


            //Console.WriteLine("Quantidade de elementos encontrados:" + encontrados.Count);
            //f.imprimeLista(encontrados);
            Console.ReadKey();

        }
    }
}



///Console.WriteLine(l.Select(i => i* i).Take(3).Sum());
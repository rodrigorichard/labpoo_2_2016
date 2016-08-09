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
            Funcoes f = new Funcoes();
            List<FormaGeometrica> formasLidasDoArquivo = f.lerArquivo("");
            f.imprimeLista(formasLidasDoArquivo);
            List<FormaGeometrica> encontrados = f.filtrar(formasLidasDoArquivo, 1);
            Console.WriteLine("Quantidade de elementos encontrados:" + encontrados.Count);
            f.imprimeLista(encontrados);
            Console.ReadKey();

        }
    }
}

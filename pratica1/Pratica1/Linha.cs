using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica1
{
    class Linha : FormaGeometrica
    {
        public Ponto origem;
        public Ponto destino;

        public override string ToString()
        {
            return "Linha: [" + origem.coordenada + "," + destino.coordenada + "]";
        }
    }
}

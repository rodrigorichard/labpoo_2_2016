using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica1
{
    class Ponto : FormaGeometrica
    {
        public int coordenada;

        public override string ToString()
        {
            return "Ponto: " + coordenada;
        }
    }
}

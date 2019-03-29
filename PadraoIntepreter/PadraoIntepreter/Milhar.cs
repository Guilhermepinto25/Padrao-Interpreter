using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoIntepreter
{
    class Milhar : NumeroRomanoInterpreter
    {
        public override string Nove() => " ";
        public override string Cinco() => " ";
        public override string Quatro() => " ";
        public override string Um() => "M";

        public override int Multiplicador() => 1000;
        
    }
}

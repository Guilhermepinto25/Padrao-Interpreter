using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoIntepreter
{
    class Centena : NumeroRomanoInterpreter
    {
        public override string Nove() => "CM";
        public override string Cinco() => "D";
        public override string Quatro() => "CD";
        public override string Um() => "C";

        public override int Multiplicador() => 100;

    }
}

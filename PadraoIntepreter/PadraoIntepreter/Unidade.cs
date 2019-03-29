using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoIntepreter
{
    class Unidade : NumeroRomanoInterpreter
    {
        public override string Nove() => "IX";
        public override string Cinco() => "V";
        public override string Quatro() => "IV";
        public override string Um() => "I";

        public override int Multiplicador() => 1;

    }
}

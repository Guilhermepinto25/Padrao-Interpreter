using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoIntepreter
{
    class Dezena : NumeroRomanoInterpreter
    {
        public override string Nove() => "XC";
        public override string Cinco() => "L";
        public override string Quatro() => "XL";
        public override string Um() => "X";

        public override int Multiplicador() => 10;

    }
}

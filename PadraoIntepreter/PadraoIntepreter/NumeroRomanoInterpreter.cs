using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoIntepreter
{
    abstract class NumeroRomanoInterpreter
    {
        public void Interpret(Contexto contexto)
        {
            if (contexto.Input.Length == 0)
                return;

            if (contexto.Input.StartsWith(Nove()))
            {
                contexto.Output += (9 * Multiplicador());
                contexto.Input = contexto.Input.Substring(2); //Valores de 9 possuem duas casas em número Romano. Ex: IX, XC, CM
            }

            if (contexto.Input.StartsWith(Quatro()))
            {
                contexto.Output += (4 * Multiplicador());
                contexto.Input = contexto.Input.Substring(2); //Valores de 4 possuem duas casas em número Romano. Ex: IV, XL, CD
            }

            if (contexto.Input.StartsWith(Cinco()))
            {
                contexto.Output += (5 * Multiplicador());
                contexto.Input = contexto.Input.Substring(1); //Valores de 5 possuem uma casa em número Romano. Ex: V, L, D
            }

            while (contexto.Input.StartsWith(Um())) //Os valores de 1 são os únicos que se repetem. Ex: III, XXX, CCC, MMM
            {
                contexto.Output += (1 * Multiplicador());
                contexto.Input = contexto.Input.Substring(1); //Valores de 1 possuem uma casa em número Romano. Ex: I, X, C, M
            }

        }

        public abstract string Um();
        public abstract string Quatro();
        public abstract string Cinco();
        public abstract string Nove();
        public abstract int Multiplicador();
    }
}

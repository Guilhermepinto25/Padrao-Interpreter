using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoIntepreter
{
    class Contexto
    {
        private String input;
        private int output;

        public Contexto(String input)
        {
            this.input = input;
        }

        public String Input { get => input; set => input = value; }

        public int Output { get => output; set => output = value; }
    }
}

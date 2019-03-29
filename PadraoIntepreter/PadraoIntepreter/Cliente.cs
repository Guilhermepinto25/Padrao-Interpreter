using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoIntepreter
{
    class CLiente
    {
        static void Main(string[] args)
        {
            string romano = "MMMDCCCLXXXIV";
            Contexto contexto = new Contexto(romano);

            List<NumeroRomanoInterpreter> interpreters = new List<NumeroRomanoInterpreter>();
            interpreters.Add(new Milhar());
            interpreters.Add(new Centena());
            interpreters.Add(new Dezena());
            interpreters.Add(new Unidade());

            foreach(NumeroRomanoInterpreter numeroRomanoInterpreter in interpreters)
            {
                numeroRomanoInterpreter.Interpret(contexto);
            }

            Console.WriteLine("{0} = {1}", romano, contexto.Output);
            Console.ReadKey();


        }
    }
}

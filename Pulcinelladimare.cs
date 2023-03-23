using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Pulcinelladimare : Animale,Inuotante,IVolante
    {
        public override void Dormi()
        {
            Console.WriteLine("Zzz");
        }

        public override void Verso()
        {
            Console.WriteLine("Jamm'bell");
        }

        public override void Mangia()
        {
            Console.WriteLine("Pesci");
        }
        public void Nuota()
        {
            Console.WriteLine("Sto nuotando!");
        }
        public void Vola()
        {
            Console.WriteLine("Sto volando!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Delfino : Animale,Inuotante
    {
        public override void Dormi()
        {
            Console.WriteLine("Zzz");
        }

        public override void Verso()
        {
            Console.WriteLine("Triiiiii");
        }

        public override void Mangia()
        {
            Console.WriteLine("Molluschi");
        }
        public void Nuota()
        {
            Console.WriteLine("Sto nuotando!");
        }
    }
}

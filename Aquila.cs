using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Aquila : Animale,IVola
    {
        public override void Dormi()
        {
            Console.WriteLine("Zzz");
        }

        public override void Verso()
        {
            Console.WriteLine("Cipcip");
        }

        public override void Mangia()
        {
            Console.WriteLine("Carne");
        }
        public  void Vola()
        {
            Console.WriteLine("Sto volando!");
        }
    }
}

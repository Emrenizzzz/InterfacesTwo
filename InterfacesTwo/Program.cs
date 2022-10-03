using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Focus focus = new Focus();
            Console.WriteLine(focus.HangiMarkaninAraci().ToString());
            Console.WriteLine(focus.StandartRengiNe().ToString());
            Console.WriteLine(focus.KacTekerlek());

            Civic civic = new Civic();
            Console.WriteLine(civic.HangiMarkaninAraci().ToString());
            Console.WriteLine(civic.StandartRengiNe().ToString());
            Console.WriteLine(civic.KacTekerlek());

            Corolla corolla = new Corolla();
            Console.WriteLine(corolla.HangiMarkaninAraci().ToString());
            Console.WriteLine(corolla.StandartRengiNe().ToString());
            Console.WriteLine(corolla.KacTekerlek());
        }
    }
}

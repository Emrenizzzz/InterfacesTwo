using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InterfacesTwo.Sabitler;

namespace InterfacesTwo
{
    public interface IOtomobil
    {
        int KacTekerlek();

        Marka HangiMarkaninAraci();

        Renk StandartRengiNe();
    }
}

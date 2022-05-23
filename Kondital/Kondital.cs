using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonditalClass
{


    public class Kondital
    {

        static public double BeregnKondital(int hvilePuls, int maxPuls)
        {
            return ((maxPuls / hvilePuls) * 15.3);
        }
    }
}

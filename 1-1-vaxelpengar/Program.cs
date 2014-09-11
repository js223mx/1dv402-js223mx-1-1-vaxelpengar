using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1_vaxelpengar
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ange variabel för totalsumman samt erhållet belopp
            double price= 371.38;
            int amount_received= 1000;

                //Uträkning av erhållet belopp - priset, bör dock inte vara double
                 double total = (int)amount_received-(double)price;
                 Console.Write((double)total);
                

            
            //skapa ett kvitto

        }
    }
}

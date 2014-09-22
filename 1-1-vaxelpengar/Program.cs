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
            double totalsum; 
            int amountReceived;

            while (true)
            
            {
                try
            }


            Console.Write("Ange totalsumma:");
            totalsum = double.Parse(Console.ReadLine());

           if (totalsum >=1)
           {
               break;
           }

           else
               Console.BackgroundColor=ConsoleColor.Red;
                Console.Write("FEL! Erhållet beopp felaktigt.");
                Console.ResetColor();

          //  Console.Write("Ange erhållet belopp:");
           // amountReceived = int.Parse(Console.ReadLine());

               
               

            
            

        }
    }
}

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
               {
                Console.Write("Vänligen ange belopp för köp: ");
                totalsum=double.Parse(Console.ReadLine());

                if (totalsum >0)
                {
                    break;
                }

                    else
                {
                    Console.BackgroundColor=ConsoleColor.Red;
                    Console.Write("FEL! Vänligen ange giltigt belopp.");
                    Console.ResetColor();
                }
               }
                
                   catch
                   {
                    Console.BackgroundColor=ConsoleColor.Red;
                    Console.Write("FEL! Ogiltig inmatning, vänligen ange giltigt belopp.");
                    Console.ResetColor();
                   }
            }


            while (true)
            {
                try
                {
                    Console.Write("Vänligen ange belopp för köp: ");
                    amountReceived = int.Parse(Console.ReadLine());

                    if (amountReceived >totalsum)
                    {
                        break;
                    }

                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("FEL! Vänligen ange giltigt belopp.");
                        Console.ResetColor();
                    }
                }

                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write("FEL! Ogiltig inmatning, vänligen ange giltigt belopp.");
                    Console.ResetColor();
                }
            }



        }
    }
}

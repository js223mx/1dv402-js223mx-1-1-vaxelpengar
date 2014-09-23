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
            uint amountReceived;
            

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

uint subTotalPrice = (uint)Math.Round(totalsum);

            while (true)
            {
                try
                {
                    Console.Write("Vänligen ange mottaget belopp: ");
                    amountReceived = uint.Parse(Console.ReadLine());

                    if (amountReceived >= subTotalPrice)
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
            
            
            double roundingOffAmount = subTotalPrice - totalsum;
            uint amountBack = amountReceived - subTotalPrice;

            uint fivehundred = amountBack / 500;
            uint cash = amountBack % 500;
            uint hundra = cash / 100;
            cash = cash % 100;
            uint femtio = cash / 50;
            cash = cash % 50;
            uint tjugo = cash / 20;
            cash = cash % 20;
            uint tio = cash /10;
            cash = cash % 10;
            uint fem = cash / 5;
            cash = cash % 5;
            uint en = cash / 1;
            cash = cash % 1;


        }
    }
}

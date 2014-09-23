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

                    else //fångar fel inmatning
                {
                    Console.BackgroundColor=ConsoleColor.Red;
                    Console.Write("FEL! Vänligen ange giltigt belopp.");
                    Console.ResetColor();
                }
               }
                
                   catch //fångar fel inmatning av typen string
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

                    else //fångar fel inmatning  
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("FEL! Vänligen ange giltigt belopp.");
                        Console.ResetColor();
                    }
                }

                catch //fångar fel intmatning av typen string
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write("FEL! Ogiltig inmatning, vänligen ange giltigt belopp.");
                    Console.ResetColor();
                }
            }
            
            
            double roundingOffAmount = subTotalPrice - totalsum;
            uint amountBack = amountReceived - subTotalPrice;

            uint fivehundred = amountBack / 500; //modelus tar hand om resten
            uint cash = amountBack % 500;
            uint hundred = cash / 100;
            cash = cash % 100;
            uint fifty = cash / 50;
            cash = cash % 50;
            uint twenty = cash / 20;
            cash = cash % 20;
            uint ten = cash /10;
            cash = cash % 10;
            uint five = cash / 5;
            cash = cash % 5;
            uint one = cash / 1;
            cash = cash % 1;


            //skriv ut ett kvitto

            Console.WriteLine("\nKVITTO");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Totalt               :       {0:c}", totalsum);
            Console.WriteLine("Öresavrundning       :       {0:c}", roundingOffAmount);
            Console.WriteLine("Att betala           :       {0:c}", subTotalPrice);
            Console.WriteLine("Betalat              :       {0:c}", amountReceived);
            Console.WriteLine("Tillbaka             :       {0:c}", amountBack);
            Console.WriteLine("-----------------------------------");

            //tala om hur mycket av varje peng som ska tillbaka

            if (fivehundred > 0);
            Console.WriteLine("500-lappar          : {0}", fivehundred);
            if (hundred > 0);
            Console.WriteLine("100-lappar          : {0}", hundred);
            if (fifty > 0);
            Console.WriteLine("50-lappar           : {0}", fifty);
            if (twenty > 0);
            Console.WriteLine("20-lappar           : {0}", twenty);
            if (ten > 0);
            Console.WriteLine("10-kronor           : {0}", ten);
            if (five > 0);
            Console.WriteLine("5-kronor            : {0}", five);
            if (one > 0);
            Console.WriteLine("1-kronor            : {0}", one);   

        }
    }
}

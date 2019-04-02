using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KraacksLotto
{
    public class Print
    {
        RowGenerator rg = new RowGenerator();
        
        public void OutputTicket(int[][] ticket)
        {
            ticket = rg.GenerateTicket();
            rg.GenerateNumbers(ticket);

            string dato = DateTime.Now.ToShortDateString();
            Console.WriteLine("    Lotto " + dato + "\n\t1-uge" + "\n      LYN-LOTTO");

            for (int i = 0; i < ticket.Length; i++)
            {
                if (i < 9)
                {
                    Console.Write($" {i + 1}. ");
                }
                else
                {
                    Console.Write($"{i + 1}. ");
                }
                foreach (int number in ticket[i])
                {
                    Console.Write(number.ToString("D2") + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
}

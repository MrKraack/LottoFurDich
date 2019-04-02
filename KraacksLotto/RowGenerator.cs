using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KraacksLotto
{
    public class RowGenerator
    {
        static Random rnd = new Random();
        public int[][] GenerateTicket()
        {
            int[][] ticket = new int[10][];

            for (int i = 0; i < ticket.Length; i++)
            {
                ticket[i] = new int[7];
            }
            return ticket;
        }

        public void GenerateNumbers(int[][] ticket)
        {
            for (int i = 0; i < ticket.Length; i++)
            {
                for (int j = 0; j < ticket[i].Length; j++)
                {
                    ticket[i][j] = rnd.Next(1, 37);

                    int k = 0;

                    while (k < j)
                    {
                        if (ticket[i][k] == ticket[i][j])
                        {
                            j--;
                        }
                        else
                        {
                            k++;
                        }
                    }
                }
                Array.Sort(ticket[i]);
            }
        }
        public int[][] JokerNumbers()
        {
            int[][] jokerticket = new int[2][];

            for (int i = 0; i < jokerticket.Length; i++)
            {
                jokerticket[i] = new int[7];
            }
            for (int i = 0; i < jokerticket.Length; i++)
            {
                for (int j = 0; j < jokerticket[i].Length; j++)
                {
                    jokerticket[i][j] = rnd.Next(1, 10);

                }
                Array.Sort(jokerticket[i]);
            }
            return jokerticket;
        }
    }
}

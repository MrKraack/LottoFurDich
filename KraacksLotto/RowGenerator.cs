using System;
using System.Collections.Generic;
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
    }
}

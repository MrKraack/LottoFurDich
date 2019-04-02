using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KraacksLotto
{
    class NormalLotto
    {
        public void StreamWriter(string path, bool append, int[][] ticket)
        {
            StreamWriter sw = new StreamWriter(path, append);

            string dato = DateTime.Now.ToShortDateString();

            sw.WriteLine("    Lotto " + dato + "\n\t1-uge" + "\n      LYN-LOTTO");

            for (int i = 0; i < ticket.Length; i++)
            {
                if (i < 9)
                {
                    sw.Write($" {i + 1}. ");
                }
                else
                {
                    sw.Write($"{i + 1}. ");
                }
                foreach (int number in ticket[i])
                {
                    sw.Write(number.ToString("D2") + " ");
                }
                sw.WriteLine();
                sw.Flush();

            }
            sw.Close();
        }
    }
}

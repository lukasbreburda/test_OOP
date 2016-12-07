using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Seznam_aut> Auta =  new List<Seznam_aut>();
            for (int r = 0; r<5; r++)
            {
                Seznam_aut auto = new Seznam_aut();
                auto.color = "red" +r;
                auto.tachometr = 183563+r;
                auto.rok = 2000;
                auto.stav = true;
                Auta.Add(auto); 
            }
            int v = 0;
            string jede;
            int tach = 0;
            string oznaceni = "";
            foreach(var Value in Auta)
            {
                if (Value.stav == true)
                {
                    jede = "V provozu";
                }
                else
                {
                    jede = "Mimo provoz";
                }
                if (tach < Value.tachometr)
                {
                    tach = Value.tachometr;
                }

                
                v++;
                Console.WriteLine(v + ".  Auto barvy: " + Value.color + " Stav tachometru: " + Value.tachometr + " Rok výroby: " + Value.rok + " Stav: " + jede + "  " + oznaceni);
                Console.WriteLine();
                
            }
            Console.WriteLine("Nejvíce ujelo auto ze stavem tachometru: " + tach.ToString());
            Console.ReadLine();
        }
    }
}

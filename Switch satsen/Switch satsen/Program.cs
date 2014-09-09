using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_satsen
{
    class Program
    {
        static void Main(string[] args)
        {
            string u = "mycket mera enna"; // test för att se om jag förstår vad som händer

            for (int i = 0; i < 5; ++i)
            {
                switch (i)
                {
                    case 1: // om i är lika med 1
                        Console.WriteLine ("i = {0} och {1} -> i case 1 och u", i, u);
                        break;
                    case 4: // om i är lika med 4
                        Console.WriteLine ("i = {0} -> i case 4", i);
                        break;
                    default: // om i inte är lika med 1 eller 4
                        Console.WriteLine ("i = {0} -> i default", i);
                        break;
                }
            }
        }
    }
}

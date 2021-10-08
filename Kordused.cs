using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine
{
    class Kordused
    {
        public void Main(string[] args)
        {
            string[] nimed = new string[17] { "Artem", "Artjom", "Danill", "Georgij", "Maksim.L", "Jaan", "Nikita", "Aleksei", "Nicole", "Aljona", "Isabel", "Nikolai", "Erik", "Maksim.T", "Ilja", "Andrei", "Rolan" };
            int nr = 0;
            while (nr<=19)
            {
                
                Console.WriteLine("Tere, {0} õpilane", nimed[nr]);
                nr = nr + 1;
            }
            Console.ReadLine();
        }
        
    }
}

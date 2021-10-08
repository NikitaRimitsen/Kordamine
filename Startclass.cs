using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine
{
    class Startclass
    {
        public static void Main(string[] args)/*public - чтобы обратиться, если он понадобиться*/
        {
            /*string[] nimed = new string[17] { "Artem", "Artjom", "Danill", "Georgij", "Maksim.L", "Jaan", "Nikita", "Aleksei", "Nicole", "Aljona", "Isabel", "Nikolai", "Erik", "Maksim.T", "Ilja", "Andrei", "Rolan" };
            nimed[2] = "Nikita";
            int nr = 0;

            while (nr < 17)
            {
                Console.WriteLine("Tere, {0} õpilane", nimed[nr]);
                nr = nr + 1;
            }

            for (int i = 0; i < nimed.Length; i++)
            {
                Console.WriteLine("Tere, {0} õpilane", nimed[i]);
            }

            foreach (var nimi in nimed)
            {
                Console.WriteLine("Tere, {0} õpilane", nimed);
                nr = nr + 1;
            }
            nr = 0;

            do
            {
                Console.WriteLine("Tere, {0} õpilane", nimed[nr]);
                nr++;
            } while (nr!=nimed.Length);

            Console.ReadLine();*/

            Random rnd = new Random();

            Console.WriteLine("Ülesanne 1 ");
            int N = rnd.Next(2, 8);
            int M = rnd.Next(9, 15);
            int[] mass = new int[M+1 - N];
            Console.WriteLine(N);
            Console.WriteLine(M);
            int j = 0;
            for (int i = N; i < M + 1; i++)
            {
                Console.Write(i-M);
                Console.ReadLine();
                mass[j] = i;
                Console.WriteLine(" {0} ", i * i);
            }

            foreach (var m in mass)
            {
                Console.Write(" {0}", m);
            }

            /*---------------------------*/

            Console.WriteLine("Напишите первое число: ");
            string number1 = Console.ReadLine();
            Console.WriteLine("Напишите второе число: ");
            string number2 = Console.ReadLine();
            Console.WriteLine("Напишите третье число: ");
            string number3 = Console.ReadLine();
            Console.WriteLine("Напишите четвётрое число: ");
            string number4 = Console.ReadLine();
            Console.WriteLine("Напишите пятое число: ");
            string number5 = Console.ReadLine();

            Console.ReadLine();

            

        }
    }
}

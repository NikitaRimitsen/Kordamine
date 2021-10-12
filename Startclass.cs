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

            /*-----------------Zadanie--------------*/

            /*Random rnd = new Random();

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
            }*/

            /*---------------------------*/
            /*Ülessane 2*/
            /*int arr = int cislo = 5;
            

            for (int i = 0; i < 5; i++)
	        {
                Console.WriteLine("Kirjuta number: ");
                int cislo = Convert.ToInt32(Console.ReadLine());
                arr[i] = cislo;
	        }
            int summa = 0;
            int multi = 1;
            foreach (var item in arr)
	        {
                summa += item;
                multi = item * multi;
	        }
            Console.WriteLine($"Nums AVG = {arr.Average()}\nNums Summa = {summa}nNums multiplied = {multi}");*/

            
            
            /*int mult = 1;
            int sum = 0;
            for (int i = 0; i < 5; i++)
			{
                Console.WriteLine("Kirjuta number: ");
                int sim = Convert.ToInt32(Console.ReadLine());
                sum += sim;
                mult = smt * mult;
			}
            double avg = sum / 5;
            Console.WriteLine($"Nums AVG = {avg}\nNums Summa = {sum}nNums multiplied = {mult}");*/


            /*----------------------------*/
            /*Ülessane 3*/
            /*string slon;
            do{

                Console.WriteLine("Kupi slona:");
                slon =Console.ReadLine();

            } while(slon != "slon");
            Console.WriteLine("Spasibo");*/


            Random rnd = new Random();

            int cifra = rnd.Next(1,10);
            Console.WriteLine(cifra);
            int podcet = 0;
            int cisla;
            do{

                Console.WriteLine("Kakoe cislo ja zagadal?:");
                cisla =Console.ReadLine();
                podcet + 1;

            } while(podcet != 5 || cisla==cifra);
            if (podcet = 5 || cisla==cifra)
	        {
                Console.WriteLine("Ne ugadal");
	        }
            else
	        {
                Console.WriteLine("Ugadal");
	        }




            Console.ReadLine();
        }
    }
}

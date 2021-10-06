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
            /*Console.WriteLine("Tere tulemast!");
            string eesnimi = Console.ReadLine();/*переменая - создаётся обращение к человеку через консоль*/
            /*Console.WriteLine("Tere, " + eesnimi);
            if (eesnimi.ToLower() == "nikita")
            {
                Console.WriteLine("Rad vas videt! \n");
                Console.WriteLine("Tule minu juurde külla! Lähme kinno! Kui vana sa oled?");
                int aasta = int.Parse(Console.ReadLine());

                if (aasta<0 || aasta>120)
                {
                    Console.WriteLine("Viga andmetega!");
                }
                else if (aasta < 6)
                {
                    Console.WriteLine("piletit on tasuta");
                }
                else if (aasta >6 && aasta<14)
                {
                    Console.WriteLine("piletit on lastepilet");
                }
                else if (aasta>15 && aasta<65)
                {
                    Console.WriteLine("piletit on täispilet");
                }
                else if (aasta>= 65)
                {
                    Console.WriteLine("piletit on sooduspilet");
                }
                else
                {
                    Console.WriteLine("Vale aasta");
                }
            }
            else
            {
                Console.WriteLine("Hästi, pogoda! \n");
            }
            Console.WriteLine("Calculate");/*moi*/
            /*int arv1 = Convert.ToInt32(Console.ReadLine());
            int arv2 = Convert.ToInt32(Console.ReadLine());
            int otvet = arv1 * arv2;
            Console.WriteLine("Otvet: " + otvet.ToString());


            Console.WriteLine("Calculate2");/*ne moi*/
            /*int arv11 = int.Parse(Console.ReadLine());
            int arv22 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Arvude {arv11} ja {arv22} korrutis võrdub {arv11 * arv22}");/* Console.WriteLine($"Arvude {1} ja {2} korrutis võrdub {2}, arv11, arv22, arv11 * arv22");*/

            Console.WriteLine("Tere tulemast!");
            Console.WriteLine("Eesnimi õpilane 1: ");
            string nimi1 = Console.ReadLine();
            Console.WriteLine("Eesnimi õpilane 2: ");
            string nimi2 = Console.ReadLine();
            if (nimi1=="Jaan" || nimi2=="Nikita")
            {
                Console.WriteLine("Ve sosedi po parte!");
            }
            else if (nimi1 == "Nikita" || nimi2 == "Artjom")
            {
                Console.WriteLine("Ve sosedi po parte!");
            }
            else if (nimi1 == "Georg" || nimi2 == "Nastya")
            {
                Console.WriteLine("Ve sosedi po parte!");
            }
            else if (nimi1 == "Artjom" || nimi2 == "Georg")
            {
                Console.WriteLine("Ve sosedi po parte!");
            }
            else
            {
                Console.WriteLine("Ve ne sosedi po parte!");
            }
            Console.WriteLine("\n");
            /*------------------------------*/

            Console.WriteLine("Ristkülikukujulise \n");

        

            Console.WriteLine("Sein 1, on: ");
            decimal cislo1 = Math.Abs(decimal.Parse(Console.ReadLine()));/*Math.Abs() - превращает отрицательно число в положительное*/
            Console.WriteLine("Sein 2, on: ");
            decimal cislo2 = Math.Abs(decimal.Parse(Console.ReadLine()));
            Console.WriteLine($"Sein {cislo1} ja {cislo2},\n Pindala on {cislo1 * cislo2} cm2\n");

            Console.WriteLine("Kas tahad remondi teha?");
            string otvet2 = Console.ReadLine();
            if (otvet2=="jah")
            {
                Console.WriteLine("Kui suur ruud meetri hind");
                decimal hind = decimal.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(hind * ((cislo1/100) * (cislo2/100)),2) + " - summa");/*MathRound(...,2) - сколько чисел нужно после запятой*/
            }
            else
            {
                Console.WriteLine("Head aega");
            }


            /*--------------------------------*/


            Console.WriteLine("Soodus");
            Console.WriteLine("Nacalnaja hinna: ");
            decimal cena = decimal.Parse(Console.ReadLine());
            if (cena >0)
            {
                Console.WriteLine("Hinna co ckidkoj v 30%\n");
                decimal otvet = (cena * 30 / 100);
                Console.WriteLine($"Hinna {cena}\n Cena co soodus {Math.Round(otvet, 2)}");
            }
            else
            {
                Console.WriteLine("Head aega");
            }

 

            /*--------------------------------*/

            Console.WriteLine("temperatuur\n");
            Console.WriteLine("Mis on temperatuur on tuba?");
            decimal temperat = decimal.Parse(Console.ReadLine());
            if (temperat <18)
            {
                Console.WriteLine("See on väike temperatuur");
            }
            else if (temperat ==18)
            {
                Console.WriteLine("See normaalne temperatuut");
            }
            else if (temperat >18)
            {
                Console.WriteLine("See on väike temperatuur");
            }

            /*---------------------------------*/

            Console.WriteLine("Pikkus\n");
            Console.WriteLine("Mis on pikkus?");
            decimal pikk = decimal.Parse(Console.ReadLine());
            if (pikk <150)
            {
                Console.WriteLine("Lühike");
            }
            else if (pikk >150 || pikk <180)
            {
                Console.WriteLine("Keskmine");
            }
            else if (pikk >180 || pikk < 300)
            {
                Console.WriteLine("Pikk");
            }
            else
            {
                Console.WriteLine("Väge");
            }

            Console.ReadLine();
        }
    }
}

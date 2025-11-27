using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sombrero_kifőzde
{
    internal class Program
    {
        public double Budzse = 0;
        static List<Etel> etelLista = new List<Etel>();
        static void Main(string[] args)
        {

            VonalDisz(12);


            Szunet(1);
            etlapCim();
            
            Induljmeg();


        }

        private static void etlapCim()
        {
            Console.WriteLine("EEEEEEEEEEEEEEEEEEEEEE         tttt          lllllll");
            Console.WriteLine("E::::::::::::::::::::E      ttt:::t          l:::::l");
            Console.WriteLine("E::::::::::::::::::::E      t:::::t          l:::::l");
            Console.WriteLine("E::::::::::::::::::::E      t:::::t          l:::::l");
            Console.WriteLine("EE::::::EEEEEEEEE::::E      t:::::t          l:::::l");
            Console.WriteLine("  E:::::E       EEEEEEttttttt:::::ttttttt     l::::l   aaaaaaaaaaaaa  ppppp   ppppppppp");
            Console.WriteLine("  E:::::E             t:::::::::::::::::t     l::::l   a::::::::::::a p::::ppp:::::::::p  ");
            Console.WriteLine("  E::::::EEEEEEEEEE   t:::::::::::::::::t     l::::l   aaaaaaaaa:::::ap:::::::::::::::::p ");
            Console.WriteLine("  E:::::::::::::::E   tttttt:::::::tttttt     l::::l            a::::app::::::ppppp::::::p");
            Console.WriteLine("  E:::::::::::::::E         t:::::t           l::::l     aaaaaaa:::::a p:::::p     p:::::p");
            Console.WriteLine("  E::::::EEEEEEEEEE         t:::::t           l::::l   aa::::::::::::a p:::::p     p:::::p");
            Console.WriteLine("  E:::::E                   t:::::t           l::::l  a::::aaaa::::::a p:::::p     p:::::p");
            Console.WriteLine("  E:::::E       EEEEEE      t:::::t    tttttt l::::l a::::a    a:::::a p:::::p    p::::::p");
            Console.WriteLine("EE::::::EEEEEEEE:::::E      t::::::tttt:::::tl::::::la::::a    a:::::a p:::::ppppp:::::::p ");
            Console.WriteLine("E::::::::::::::::::::E      tt::::::::::::::tl::::::la:::::aaaa::::::a p::::::::::::::::p  ");
            Console.WriteLine("EEEEEEEEEEEEEEEEEEEEEE          ttttttttttt  llllllll  aaaaaaaaaa  aaaap::::::pppppppp ");
            Console.WriteLine("                                                                       p:::::p        ");
            Console.WriteLine("                                                                       p:::::p        ");
            Console.WriteLine("                                                                      p:::::::p        ");
            Console.WriteLine("                                                                      p:::::::p        ");
            Console.WriteLine("                                                                      p:::::::p        ");
            Console.WriteLine("                                                                      ppppppppp        ");
        }

        private static void Induljmeg()
        {
            //Ez a függvény indítja el az egész programot
            try
            {
                double Budzse = Convert.ToInt32(PenzBeker());
                PenzKiiras(Budzse);
                LapKezeles(0);
                for (int i = 0; i < etelLista.Count; i++)
                {
                    VonalDisz(3);
                    Console.WriteLine("\n"+"ID:" +(i+1)+"\n"+etelLista[i].ToString());
                    VonalDisz(3);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Annyira nem mély.");
            }
        }

        private static void LapKezeles(int v)
        {

            //Ez a függvény kezeli az étlapot, itallapot illetve a rendeléseket switch case-el

            switch (v)
            {
                case 0:
                    string[] etlap= File.ReadAllLines("etlap.txt");
                    for (int i = 1; i < etlap.Length; i++) 
                    {
                        string[] etel = etlap[i].Split(';');
                        if (etel[1] == "csirke") 
                        {
                            CsirkesEtel csirkesEtel = new CsirkesEtel(etel[0], etel[3], Convert.ToInt32(etel[2]), etel[1]);
                            etelLista.Add(csirkesEtel);
                        }
                        else if (etel[1] == "disznó")
                        {
                            DisznosEtel disznoEtel = new DisznosEtel(etel[0], etel[3], Convert.ToInt32(etel[2]), etel[1]);
                            etelLista.Add(disznoEtel);
                        }
                        else if (etel[1] == "Húsmentes")
                        {
                            Husmentes HmentesEtel = new Husmentes(etel[0], etel[3], Convert.ToInt32(etel[2]),etel[1]);
                            etelLista.Add (HmentesEtel);
                        }
                        else
                        {
                            Console.WriteLine("Van egy kivételes paca is");
                        }
                    }
                    
                    break;
                case 1:
                    break;
            }
        }

        private static void PenzKiiras(double budzse)
            
        {
            //Ez a függvény fogja kiíratni a felhasználó által megadott büdzsét
            VonalDisz(1);
            Console.WriteLine(" Büdzsé : " + budzse);
            
        }

        private static void Szunet(int v)
        {

            //Ez a függvény csak egy szünetet csinál a konzolon
            for (int i = 0; i < v; i++)
            {
                Console.WriteLine("\n");
            }
        }

        private static string PenzBeker()
        {

            //Ez a függvény kéri be a felhasználótól a büdzsét
            VonalDisz(2);
            Console.WriteLine("\n -> Kérlek add meg mennyi pénzt szeretnél ma elkölteni? Számmal, elválasztás nélkül");
            VonalDisz(2);
            Console.WriteLine();
            Console.Write(" -> ");
            return Console.ReadLine();
        }

        private static void VonalDisz(int v)
        {

            //Ez a függvény vonaldíszítést csinál a konzolon
            for (int i = 0; i < v; i++)
            {
                Console.Write("----------");
            }

        }
    }
}

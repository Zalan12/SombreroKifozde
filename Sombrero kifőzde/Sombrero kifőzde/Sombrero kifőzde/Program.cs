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
        static public double Budzse = 0;
        static List<Etel> etelLista = new List<Etel>();
        static List<Int32> rendeltLista = new List<Int32>();
        static void Main(string[] args)
        {

            VonalDisz(12);


            Szunet(1);
            
            Induljmeg();


        }

        private static void etlapCim()
        {
            Console.WriteLine("             EEEEEEEEEEEEEEEEEEEEEE         tttt          lllllll");
            Console.WriteLine("             E::::::::::::::::::::E      ttt:::t          l:::::l");
            Console.WriteLine("             E::::::::::::::::::::E      t:::::t          l:::::l");
            Console.WriteLine("             E::::::::::::::::::::E      t:::::t          l:::::l");
            Console.WriteLine("            EE::::::EEEEEEEEE::::E      t:::::t          l:::::l");
            Console.WriteLine("            E:::::E       EEEEEEttttttt:::::ttttttt     l::::l   aaaaaaaaaaaaa  ppppp   ppppppppp");
            Console.WriteLine("            E:::::E             t:::::::::::::::::t     l::::l   a::::::::::::a p::::ppp:::::::::p  ");
            Console.WriteLine("            E::::::EEEEEEEEEE   t:::::::::::::::::t     l::::l   aaaaaaaaa:::::ap:::::::::::::::::p ");
            Console.WriteLine("            E:::::::::::::::E   tttttt:::::::tttttt     l::::l            a::::app::::::ppppp::::::p");
            Console.WriteLine("            E:::::::::::::::E         t:::::t           l::::l     aaaaaaa:::::a p:::::p     p:::::p");
            Console.WriteLine("            E::::::EEEEEEEEEE         t:::::t           l::::l   aa::::::::::::a p:::::p     p:::::p");
            Console.WriteLine("            E:::::E                   t:::::t           l::::l  a::::aaaa::::::a p:::::p     p:::::p");
            Console.WriteLine("            E:::::E       EEEEEE      t:::::t    tttttt l::::l a::::a    a:::::a p:::::p    p::::::p");
            Console.WriteLine("            EE::::::EEEEEEEE:::::E      t::::::tttt:::::tl::::::la::::a    a:::::a p:::::ppppp:::::::p ");
            Console.WriteLine("            E::::::::::::::::::::E      tt::::::::::::::tl::::::la:::::aaaa::::::a p::::::::::::::::p  ");
            Console.WriteLine("            EEEEEEEEEEEEEEEEEEEEEE          ttttttttttt  llllllll  aaaaaaaaaa  aaaap::::::pppppppp ");
            Console.WriteLine("                                                                                    p:::::p        ");
            Console.WriteLine("                                                                                    p:::::p        ");
            Console.WriteLine("                                                                                   p:::::::p        ");
            Console.WriteLine("                                                                                   p:::::::p        ");
            Console.WriteLine("                                                                                   p:::::::p        ");
            Console.WriteLine("                                                                                   ppppppppp        ");
        }

        private static void Induljmeg()
        {
            //Ez a függvény indítja el az egész programot
            try
            {
                double Budzse = Convert.ToInt32(PenzBeker());

                LapKezeles(0);
                LapKezeles(2);
                PenzKiiras(Budzse);
                Szunet(2);
                Console.Write("\nKérlek írd ide a választott étel ID-jét ~ ------------> [");
                string[] rendelesek=Console.ReadLine().Split(',');
                for (int i = 0; i < rendelesek.Length; i++)
                {
                    rendeltLista.Add(Convert.ToInt32(rendelesek[i]));
                }
                Console.WriteLine("\nAz általad rendelt ételek:\n");
                for (int i = 0; i < rendeltLista.Count; i++)
                {
                   
                    Console.WriteLine(etelLista[rendeltLista[i]].ToString());
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
                            CsirkesEtel csirkesEtel = new CsirkesEtel(etel[0], etel[3], Convert.ToInt32(etel[2]), etel[1], etel[4]);
                            etelLista.Add(csirkesEtel);
                        }
                        else if (etel[1] == "disznó")
                        {
                            DisznosEtel disznoEtel = new DisznosEtel(etel[0], etel[3], Convert.ToInt32(etel[2]), etel[1], etel[4]);
                            etelLista.Add(disznoEtel);
                        }
                        else if (etel[1] == "Húsmentes")
                        {
                            Husmentes HmentesEtel = new Husmentes(etel[0], etel[3], Convert.ToInt32(etel[2]),etel[1], etel[4]);
                            etelLista.Add (HmentesEtel);
                        }
                        else
                        {
                            Console.WriteLine("Van egy kivételes paca is");
                        }
                    }
                    
                    break;
                case 1:
                    Console.WriteLine("Italok");
                    break;
                case 2:
                    Szunet(1);
                    VonalDisz(12);
                    etlapCim();
                    Szunet(2);

                    int Leghosszabb = 0;
                    int LegDragabb = 0;
                    for (int i = 0; i < etelLista.Count; i++)
                    {
                        if (etelLista[i].Nev.Length >= Leghosszabb)
                        {
                            Leghosszabb = etelLista[i].Nev.Length;
                        }
                    }
                    for (int i = 0; i < etelLista.Count; i++)
                    {
                        if (etelLista[i].Ar >= LegDragabb)
                        {
                            LegDragabb= etelLista[i].Ar.ToString().Length;
                        }
                    }

                    Leghosszabb += 2;
                    LegDragabb += 2;
                    VonalDisz(12);
                    
                    Console.WriteLine(" |  ID   |                   Név                    | Hús típusa|  Tészta  |    Ár     | Hozzávalók");
                    VonalDisz(12);
                    Szunet(1);
                    VonalDisz(12);
                    for (int i = 0; i < etelLista.Count; i++)
                    {
                        if(i < 9)
                        {
                            Console.Write(" |  " + (i + 1) + "    |");
                        }
                        else
                        {
                            Console.Write(" |  " + (i + 1) + "   |");
                        }
        
                        Console.Write("  " + etelLista[i].Nev);
                        for (int j = 0; j < Leghosszabb - etelLista[i].Nev.Length; j++)
                        {
                            Console.Write(' ');
                        }
                        Console.Write('|');
                        Console.Write(" " + etelLista[i].HusIras());
                        for (int k = 0; k < 10 - etelLista[i].HusIras().Length; k++)
                        {
                            Console.Write(' ');
                        } 
                        Console.Write('|');
                        Console.Write(" " + etelLista[i].Tortilla);
                        for (int l = 0; l < 9 - etelLista[i].Tortilla.Length; l++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write('|');
                        Console.Write("  " + etelLista[i].Ar);
                        Console.Write(" Ft");
                        for (int t = 0; t < LegDragabb - etelLista[i].Ar.ToString().Length; t++)
                        {
                            Console.Write(' ');
                        }
                        Console.Write('|');
                        Console.Write(" Hozzávalókért válassz engem! ");
                        Console.Write('|');
                        VonalDisz(12);
                        Console.WriteLine();
                    }
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

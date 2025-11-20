using System;
using System.Collections.Generic;
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
            Console.WriteLine("                                            Üdvözlünk a Sombrero Kifőzdében!");
            VonalDisz(12);


            Szunet(1);
            try
            {
                double Budzse = Convert.ToDouble(PenzBeker());
                PenzKiiras(Budzse);
                LapKezeles(0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); 
                Console.WriteLine("Annyira nem mély.");
            }
            
        }



        private static void LapKezeles(int v) // sih seveh knee guah
        {
            switch (v)
            {
                case 0:
                    string[] etlap= File.ReadAllLines("etlap.txt");
                    for (int i = 1; i < etlap.Length; i++) 
                    {
                        string[] etel = etlap[i].Split(';');
                        if (etel[1] == "Csirkés") 
                        {
                            CsirkesEtel csirkesEtel = new CsirkesEtel(etel[0], etel[3], Convert.ToInt32(etel[1]), etel[2]);
                            etelLista.Add(csirkesEtel);
                        }
                        else if (etel[1] == "disznó")
                        {
                            DisznosEtel disznoEtel = new DisznosEtel(etel[0], etel[3], Convert.ToInt32(etel[1]), etel[2]);
                            etelLista.Add(disznoEtel);
                        }

                    }
                    
                    break;
                case 1:
                    break;
            }
        }

        private static void PenzKiiras(double budzse)
        {
            VonalDisz(1);
            Console.WriteLine(" Büdzsé : " + budzse);
            
        }

        private static void Szunet(int v)
        {
            for (int i = 0; i < v; i++)
            {
                Console.WriteLine("\n");
            }
        }

        private static string PenzBeker()
        {
            VonalDisz(2);
            Console.WriteLine("\n -> Kérlek add meg mennyi pénzt szeretnél ma elkölteni? Számmal, elválasztás nélkül");
            VonalDisz(2);
            Console.WriteLine();
            Console.Write(" -> ");
            return Console.ReadLine();
        }

        private static void VonalDisz(int v)
        {
            for (int i = 0; i < v; i++)
            {
                Console.Write("----------");
            }

        }
    }
}

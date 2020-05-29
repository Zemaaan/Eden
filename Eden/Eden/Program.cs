using System;
using System.IO;

namespace Eden
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string Putanja = Directory.GetCurrentDirectory();
            
            string[] PopisDirektorija = Directory.GetDirectories(Directory.GetCurrentDirectory());
            string[] PopisDatoteka = Directory.GetFiles(Directory.GetCurrentDirectory());

            int BrojIzbrisanihDatoteka = 0;
            int BrojIzbrisanihDirektorija = 0;

            if (PopisDirektorija.Length > 0) {
                for (int Brojac = 0; Brojac < PopisDirektorija.Length; Brojac++)
                {
                    Console.WriteLine("Brišem: " + PopisDirektorija[Brojac]);
                    BrojIzbrisanihDirektorija++;
                    Directory.Delete(PopisDirektorija[Brojac]);
                }
            }
            
            if (PopisDatoteka.Length > 0) {
                for (int Brojac = 0; Brojac < PopisDatoteka.Length; Brojac++)
                {
                    Console.WriteLine("Brišem: " + PopisDirektorija[Brojac]);
                    BrojIzbrisanihDatoteka++;
                    File.Delete(PopisDatoteka[Brojac]);
                }
            }

            
            Console.WriteLine("Brisanje završeno.");
            Console.WriteLine("Ukupno je izbrisano {0} mapa i {1} datoteka",BrojIzbrisanihDirektorija, BrojIzbrisanihDatoteka);
            
            Console.WriteLine(Putanja);
            
            Console.ReadKey();
        }
    }
}
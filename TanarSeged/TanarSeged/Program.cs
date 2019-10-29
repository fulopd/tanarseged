using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanarSeged.Repository;

namespace TanarSeged
{
    class Program
    {
        static void Main(string[] args)
        {
            DiakokRepository dr = new DiakokRepository();

            //1. Feladat
            Console.WriteLine("1. Feladat:");
            dr.beolvas("diakok.csv");
            //2. Feladat
            Console.WriteLine("2. Feladat:");
            dr.randomJegyek();
            Console.WriteLine("Random jegyek osztása kész.");
            //3. Feladat
            Console.WriteLine("3. Feladat:");            
            Console.WriteLine("Osztály létszám: " + dr.getDiakokSzama());
            //4. Feladat
            Console.WriteLine("4. Feladat:");
            Console.WriteLine("Osztály átlag: " + dr.getOsztalyAtlag());
            //5. Feladat
            Console.WriteLine("5. Feladat:");
            Console.WriteLine("Osztályzatok statisztika: ");
            dr.getJegyekStatisztika();
            //6. Feladat
            Console.WriteLine("6. Feladat:");
            dr.setHianyzas();
            Console.WriteLine("Hiányzól beállítása kész. ");
            //7. - 8. Feladat
            Console.WriteLine("7. - 8. Feladat:");            
            Console.WriteLine("Exportálás: "+ dr.export());



            //dr.kiir();
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanarSeged.Model;

namespace TanarSeged.Repository
{
    class DiakokRepository
    {
        List<Diak> Diakok;

        public DiakokRepository()
        {
            Diakok = new List<Diak>();
        }

        public void beolvas(string filename) {

            if (File.Exists(filename))
            {
                StreamReader sr = new StreamReader(filename, Encoding.Default, true);
                bool tartalmazza = false;
                sr.ReadLine();

                while (!sr.EndOfStream)
                {
                    string[] item = sr.ReadLine().Split(';');

                    foreach (Diak i in Diakok)
                    {
                        if (item[0] == i.Nev)
                        {
                            tartalmazza = true;
                            break;
                        }
                    }

                    if (!tartalmazza)
                    {
                        Diak d = new Diak(item[0]);
                        Diakok.Add(d);
                    }
                }
                Console.WriteLine(filename + " beolvasása megtörtént");
            }
            else
            {
                Debug.WriteLine(filename + " file nem létezik.");
            }
            
            
        }

        public void kiir()
        {

            foreach (Diak item in Diakok)
            {
                Console.WriteLine(item.Nev + " " + item.Osztalyzat + " " + item.Hianyzas);
            }
        }

        public void randomJegyek() {

            Random r = new Random();
            foreach (Diak item in Diakok)
            {
                item.Osztalyzat = r.Next(1, 6);
            }
        }

        public int getDiakokSzama() {
            return Diakok.Count;
        }

        public double getOsztalyAtlag() {
            double sum = 0;
            foreach (Diak item in Diakok)
            {
                sum += item.Osztalyzat;
            }

            return sum / Diakok.Count;
        }

        public void getJegyekStatisztika() {

            var JegyekLista = Diakok
                .GroupBy(x => x.Osztalyzat)
                .Select(x => new
                    {
                        Jegyek = x.Key,
                        Darab = x.Count()
                    }
                )
                .OrderBy(x => x.Jegyek);

            foreach (var item in JegyekLista)
            {
                Console.WriteLine("\t" + item.Jegyek +": " + item.Darab);
            }
        }

        
    }
}

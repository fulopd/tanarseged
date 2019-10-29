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
                StreamReader sr = new StreamReader(filename);
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
            }
            else
            {
                Debug.WriteLine(filename + " file nem létezik.");
            }
            
            
        }


    }
}

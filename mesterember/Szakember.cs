using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mesterember
{
    internal class Szakember
    {
        public List<Mesterember> mesterembers;

        public Szakember() {
            mesterembers = new List<Mesterember>();
        }

        public void FajlBeolvasas(string path)
        {

            string[] sorok = File.ReadAllLines(path);

            foreach (string item in sorok)
            {
                string[] adatok = item.Split(';');
                if (adatok.Length >= 4)
                {
                    string tipus = adatok[0];
                    string nev = adatok[1];
                    int napiDij = int.Parse(adatok[2]);

                    if (tipus == "Burkoló")
                    {
                        if (adatok[3] == "Belso")
                        {
                            mesterembers.Add(new Burkolo(nev, napiDij, Helyszin.Belso));
                        }
                        else if (adatok[3] == "Kulso")
                        {
                            mesterembers.Add(new Burkolo(nev, napiDij, Helyszin.Kulso));
                        }
                        
                    }
                    else if (tipus == "VízvezetékSzerelő")
                    {
                        int tapasztalat = int.Parse(adatok[4]);
                        mesterembers.Add(new VizvezetekSzerelo(tapasztalat, nev, napiDij));
                    }
                }
            }
        }
        public void Kiiratas()
        {
            Console.WriteLine("Melyik típusú mesteremberek adataira vagy kíváncsi?");
            string tipus = Console.ReadLine();
            
            foreach (var mesterember in mesterembers)
            {
                if(mesterember is Burkolo)
                {
                    if(tipus == "Burkoló")
                    {
                        Console.WriteLine(mesterember);
                    }
                }
                else if(mesterember is VizvezetekSzerelo)
                {
                    if(tipus == "Vízvezetékszerelő")
                    {
                        Console.WriteLine(mesterember);
                    }
                }
            }
        }

        public void Szimulacio()
        {
            Helyszin helyszin = Helyszin.Kulso;
            Burkolo burkolo = new Burkolo("Asd", 3000, helyszin);
            burkolo.MunkatVallal(4);
            burkolo.MunkatVallal(8);
            burkolo.MunkatVallal(12);

            Console.WriteLine(burkolo.ToString() + $"\n{burkolo.Nev1} Szabad napjai: " + burkolo.OsszesSzabadnap());
            

        }

    }
}

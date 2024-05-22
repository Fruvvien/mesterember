using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mesterember
{
    internal abstract class Mesterember
    {
        private string Nev;
        private int NapiDij;
        private bool[] FoglaltNapok;

        

        public Mesterember(string nev, int napiDij ) 
        {
            this.Nev = nev;
            this.NapiDij = napiDij;
            this.FoglaltNapok = new bool[31];
            for (int i = 0; i < this.FoglaltNapok.Length; i++)
            {
                this.FoglaltNapok[i] = true;
            }
        }
        public string Nev1
        {
            get => Nev;
            set => Nev = value;
        }


        public int NapiDij1
        {
            get => NapiDij;
            set => NapiDij = value;
        }


        public bool[] FoglaltNapok1
        {
            get => FoglaltNapok;
            set => FoglaltNapok = value;
        }

        public override string ToString()
        {
            string foglaltnap = "";
            for (int i = 0; i < this.FoglaltNapok.Length; i++)
            {
                if (!FoglaltNapok[i])
                {
                    foglaltnap += "\n\tszabad";
                }
                else
                {
                    foglaltnap += "\n\tfoglalt";
                }
            }
            return $"{this.Nev} {this.NapiDij} {foglaltnap}";
        }

        public abstract bool MunkatVallal(int number);

       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mesterember
{
    internal class VizvezetekSzerelo : Mesterember
    {
        private int Tapasztalat;

        public VizvezetekSzerelo(int tapasztalat, string nev, int napiDij) : base(nev, napiDij) 
        {
            this.Tapasztalat = tapasztalat;
        }

        public override string ToString()
        {
            string foglaltnap = "";
            for (int i = 0; i < this.FoglaltNapok1.Length; i++)
            {
                if (!FoglaltNapok1[i])
                {
                    foglaltnap += "\n\tszabad";
                }
                else
                {
                    foglaltnap += "\n\tfoglalt";
                }
            }
            return $"{Nev1} {NapiDij1} {Tapasztalat} {foglaltnap}";
        }
        public override bool MunkatVallal(int number)
        {
            for (int i = 0; i < FoglaltNapok1.Length; i++)
            {
                if (i == number && i!= 0 && i != FoglaltNapok1.Length -1)
                {
                    if (FoglaltNapok1[i] == true && FoglaltNapok1[i - 1] == true && FoglaltNapok1[i + 1] == true)
                    {
                        FoglaltNapok1[i] = false;
                        FoglaltNapok1[i - 1] = false;
                        FoglaltNapok1[i + 1] = false;
                        return true;
                    }
                }
                if(i == 0)
                {
                    if (FoglaltNapok1[0] == true && FoglaltNapok1[i + 1] == true && FoglaltNapok1[i + 2] == true)
                    {
                        FoglaltNapok1[0] = false;
                        FoglaltNapok1[i + 1] = false;
                        FoglaltNapok1[i + 2] = false;
                        return true;

                    }
                }
                if (i == FoglaltNapok1.Length - 1)
                {
                    if (FoglaltNapok1[FoglaltNapok1.Length - 1] == true && FoglaltNapok1[FoglaltNapok1.Length - 2] == true && FoglaltNapok1[FoglaltNapok1.Length - 3] == true)
                    {
                        FoglaltNapok1[FoglaltNapok1.Length - 1] = false;
                        FoglaltNapok1[FoglaltNapok1.Length - 2] = false;
                        FoglaltNapok1[FoglaltNapok1.Length - 3] = false;
                        return true;

                    }
                }
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mesterember
{
    internal class Burkolo : Mesterember
    {
        private Helyszin Szakterulet;

        public Burkolo(string nev, int napiDij, Helyszin szakterulet) : base(nev, napiDij)
        { 
            this.Szakterulet = szakterulet;
        }


        public int OsszesSzabadnap()
        {
            int count = 0; 
            foreach (bool item in FoglaltNapok1)
            {
                if (item)
                {
                    count++;
                }   
            }
            return count;

        }

        public override string ToString()
        {
            return $"{Nev1} {NapiDij1} {Szakterulet}";
        }
        public override bool MunkatVallal(int number)
        {
            for (int i = 0; i < FoglaltNapok1.Length; i++)
            {
                if(i == number)
                {
                    if (FoglaltNapok1[i])
                    {
                        FoglaltNapok1[i] = false;
                        return true;
                    }
                }
            }
            return false;
        }

    }
}

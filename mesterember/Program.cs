using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mesterember
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Szakember szakember = new Szakember();
            szakember.FajlBeolvasas("szakember.txt");
            szakember.Kiiratas();
            szakember.Szimulacio();
        }
    }
}

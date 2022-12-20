using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokBicimlilik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Sekil> sekiller = new List<Sekil>
            {
                new Daire(),
                new Kare(),
                new Ucgen()
            };
            foreach (var sekil in sekiller)
            {
                sekil.Ciz();
            }
        }
    }
    interface Sekil
    {
        void Ciz();
    }
    class Kare : Sekil
    {
        public void Ciz()
        {
            Console.WriteLine("Kare çizildi.");
        }
    }
    class Daire : Sekil
    {
        public void Ciz()
        {
            Console.WriteLine("Daire çizildi.");
        }
    }
    class Ucgen : Sekil
    {
        public void Ciz()
        {
            Console.WriteLine("Üçgen çizildi.");
        }
    }
}

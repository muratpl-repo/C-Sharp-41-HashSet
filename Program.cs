using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _89DersHashSets // HashSets, verileri kumelememize yarar. Ornegin iki hashsets olusturup, birbiri aralarinda karsilastirma yapabiliriz.
{                         // Ornegin kesisim, birlesim, fark kumelerine ulasabiliriz...
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> sayilar1 = new HashSet<int>();
            HashSet<int> sayilar2 = new HashSet<int>();

            sayilar1.Add(5);
            sayilar1.Add(6);
            sayilar1.Add(7);

            sayilar2.Add(6);
            sayilar2.Add(7);
            sayilar2.Add(8);

            sayilar1.IntersectWith(sayilar2);
            foreach (var item in sayilar1)
            {
                Console.WriteLine(item);
            }

        }
    }
}

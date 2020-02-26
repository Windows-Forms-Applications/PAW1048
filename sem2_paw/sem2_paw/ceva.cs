using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem2_paw
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            Animal a2 = new Animal(10, "Azorel", 9.5f);
            a2.Nume = "Grivei";
            Console.WriteLine(a2.Nume);

            Console.WriteLine(a2);

            Animal a3 = (Animal)a2.Clone();
            a3.Varsta = 5;

            Pisica p1 = new Pisica(5, "Felix", 2, "rosu", 7);
            Girafa g1 = new Girafa(7, "Sophie", 100, 2, 4);

            Zoo z1 = new Zoo();
            z1.ListaAnimale.Add(a1);
            z1.ListaAnimale.Add(a2);
            z1.ListaAnimale.Add(a3);
            z1.ListaAnimale.Add(p1);
            z1.ListaAnimale.Add(g1);

            Console.WriteLine(z1);

            Zoo z2 = (Zoo)z1.Clone();
            z2.Denumire = "Baneasa";
            foreach (Animal a in z2.ListaAnimale)
                a.Nume += " copie";
            z1.ListaAnimale.Sort();
            Console.WriteLine(z1);
            z2.ListaAnimale.Sort();
            Console.WriteLine(z2);
        }
    }
}

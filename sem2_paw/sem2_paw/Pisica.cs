using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem2_paw
{
    class Pisica: Animal
    {
        private string culoare;
        private int nrVieti;

        public Pisica()
            : base()
        {
            culoare = "alb";
            nrVieti = 9;
        }

        public Pisica(int v, string n, float g, string c, int nr)
            : base(v, n, g)
        {
            culoare = c;
            nrVieti = nr;
        }

        public override string ToString()
        {
            return base.ToString()+" culoarea "+culoare+
                " si nr vieti "+nrVieti;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem2_paw
{
    class Girafa: Animal
    {
        private int lungimeGat;
        private int nrPui;

        public Girafa()
            : base()
        {
            lungimeGat = 0;
            nrPui = 0;
        }

        public Girafa(int v, string n, float g, int lg, int nr)
            : base(v, n, g)
        {
            lungimeGat = lg;
            nrPui = nr;
        }

        public override string ToString()
        {
            return base.ToString()+" si lungime gat "+lungimeGat+
                " si are "+nrPui+" pui";
        }
    }
}

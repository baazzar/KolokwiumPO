using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K1
{
    class DomJednorodzinny : ProjektDomu
    {
        public override void PomalujElewacje(Kolor kolor)
        {
            dom.PomalujElewacje(Kolor.Czerwony);
        }
        public override string ToString()
        {
            return String.Format("Dom jednorodzinny {0}", dom.ToString());
        }
    }
}

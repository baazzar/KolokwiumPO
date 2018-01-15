using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K1
{
    class Biurowiec : ProjektDomu
    {
        public override void PomalujElewacje(Kolor kolor)
        {
            dom.PomalujElewacje(kolor);
        }
        public override void ZamontujDrzwi(string rodzajDrzwi)
        {
            dom.ZamontujDrzwi("Szklane");
        }
        public override string ToString()
        {
            return String.Format("Biurowiec {0}", dom.ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K1
{
    class SzefBudowy
    {
        ProjektDomu projektDomu;

        public void WybierzProjekt(ProjektDomu projekt)
        {
            this.projektDomu = projekt;
        }

        public void Buduj(string rodzajOkien, string rodzajDrzwi, Kolor kolor)
        {
            projektDomu.NowyDom();
            projektDomu.WstawOkna(rodzajOkien);
            projektDomu.ZamontujDrzwi(rodzajDrzwi);
            projektDomu.PomalujElewacje(kolor);
        }
        public override string ToString()
        {
            return String.Format("Projekt: {0}", projektDomu);
        }
    }
}

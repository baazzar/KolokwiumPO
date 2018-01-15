using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K1
{
    class Dom
    {
        private string drzwi;
        private Kolor kolorElewacji;
        private string okno;

        public void PomalujElewacje(Kolor kolor)
        {
            this.kolorElewacji = kolor;
        }
        public void WstawOkna(string okno)
        {
            this.okno = okno;
        }
        public void ZamontujDrzwi(string drzwi) 
        {
            this.drzwi = drzwi;
        }
        public override string ToString()
        {
            return String.Format("Okna: {0}, Drzwi: {1}, Kolor elewacji: {2} ", okno, drzwi, kolorElewacji);
        }
    }
}

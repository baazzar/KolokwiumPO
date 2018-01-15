using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K1
{
    abstract class ProjektDomu
    {
        protected Dom dom;
        public void NowyDom()
        {
            dom = new Dom();
        }
        public virtual void WstawOkna(string okno)
        {
            dom.WstawOkna(okno);
        }
        public virtual void ZamontujDrzwi(string drzwi)
        {
            dom.ZamontujDrzwi(drzwi);
        }
        public abstract void PomalujElewacje(Kolor kolor);

        public override string ToString()
        {
            return dom.ToString();
        }
    }
}

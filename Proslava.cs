using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Proslava
{

    public abstract class Proslava
    {

        protected string ime, prezime;
        protected int godiste;
        protected string telefon;

        public Proslava(string i, string p, int g, string t)
        {
            if (i.Equals(string.Empty))
                throw new Exception("Nema ime!");
            else if (p.Equals(string.Empty))
                throw new Exception("Nema prezime!");
            else if (t.Equals(string.Empty))
                throw new Exception("Nema telefon!");

            ime = i;
            prezime = p;
            telefon = t;
            godiste = g;


        }
        public bool StarijeOd(Proslava pr)
        {
            return godiste > pr.godiste;
        }
        public string Prikaz()
        {
            return ime + " " + prezime + " " + godiste + " " + telefon;
        }

        public abstract string Info();

    }
    public class Osoba : Proslava
    {
        private int godine;
        public Osoba(string i, string p, int g, string t)
            : base(i, p, g, t)
        {
            if (g < 0 || g > 66)
                throw new Exception("Neispravno unete godine!");
            godine = g;
        }
        public override string Info()
        {
            string s = ime + " " + prezime;
            s += ", tel: " + telefon;
            s += ", god: " + godine;
            return s;
        }

    }
}


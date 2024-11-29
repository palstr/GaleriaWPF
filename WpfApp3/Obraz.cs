using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    public class Obraz
    {
        //internal, klasa wewnętrzna, taki PRIVATE

        public string urlObrazka { get; set; }
        //OD RAZU WYGENERUJEMY GETTER I SETTER

        public int LicznikPobran { get; set; }

        public Obraz(string urlObrazka)
        {
            this.urlObrazka = urlObrazka;
            LicznikPobran = 0;
        }

        //ŚRUBOKRĘT OBOK, TAM KONSTRUKTOR



    }
}

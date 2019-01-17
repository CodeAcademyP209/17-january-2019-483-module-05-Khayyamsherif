using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class Workers
    {
        public Workers(string ad, int yas, int iseGelmeVaxti, int isdenCixmaVaxti, int maas,int id)
        {  
            this.id = id;
            this.ad = ad;
            this.yas = yas;
            this.iseGelmeVaxti = iseGelmeVaxti;
            this.isdenCixmaVaxti = isdenCixmaVaxti;
            this.maas = maas;
        }

        public int id { get; set; }
        public string ad { get; set; }
        public int yas { get; set; }
        public int iseGelmeVaxti { get; set; }
        public  int isdenCixmaVaxti { get; set; }
        public int maas { get; set; }
    }
}
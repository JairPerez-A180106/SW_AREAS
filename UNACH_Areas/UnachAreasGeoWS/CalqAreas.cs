using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnachAreasGeoWS
{
    public class CalqAreas
    {
        public decimal clado { get; set; }
        public decimal tbase { get; set; }
        public decimal taltura { get; set; }
        public decimal cradio { get; set; }


        public decimal cuadrado()
        {
            return (clado * clado);
        }

        public decimal triangulo()
        {
            return ((tbase * taltura) / 2);
        }

        public decimal circulo()
        {
            decimal pi = Convert.ToDecimal(Math.PI);
            return (pi * (cradio * cradio));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Services;

namespace UnachAreasGeoWS
{
    /// <summary>
    /// Este es un web service para entregar el cálculo de el área de figuras geométricas
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class AreasGeoWS : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public decimal cuadrado(decimal LADO)
        {
            CalqAreas A = new CalqAreas();
            A.clado = LADO;
            return A.cuadrado();
        }

        [WebMethod]
        public decimal triangulo(decimal BASE, decimal ALTURA)
        {
            CalqAreas A = new CalqAreas();
            A.tbase = BASE;
            A.taltura = ALTURA;
            return A.triangulo();
        }

        [WebMethod]
        public decimal circulo(decimal RADIO)
        {
            CalqAreas A = new CalqAreas();
            A.cradio = RADIO;
            return A.circulo();
        }
    }
}

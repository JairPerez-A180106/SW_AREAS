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

        //[WebMethod]
        //public string HelloWorld()
        //{
        //    return "Hola a todos";
        //}

        /// <summary>
        /// Método para calcular el área de un Cuadrado
        /// </summary>
        /// <param name="LADO">Dato numérico decimal, de la medida de cualquier lado del cuadrado</param>
        /// <returns>Área de la figura, en tipo Decimal</returns>
        [WebMethod (Description = "Calcular el área de un Cuadrado")]
        public decimal cuadrado(decimal LADO)
        {
            CalqAreas A = new CalqAreas();
            A.clado = LADO;
            return A.cuadrado();
        }

        /// <summary>
        /// Método para calcular el área de un Triángulo
        /// </summary>
        /// <param name="BASE">Dato numérico decimal, de la medida de la base del triángulo</param>
        /// <param name="ALTURA">Dato numérico decimal, de la medida de la altura del triángulo</param>
        /// <returns>Área de la figura, en tipo Decimal</returns>
        [WebMethod (Description = "Calcular el área de un Triángulo")]
        public decimal triangulo(decimal BASE, decimal ALTURA)
        {
            CalqAreas A = new CalqAreas();
            A.tbase = BASE;
            A.taltura = ALTURA;
            return A.triangulo();
        }

        /// <summary>
        /// Método para calcular el área de un Círculo
        /// </summary>
        /// <param name="RADIO">Dato numérico decimal, de la medida del radio del círculo, del centro a un borde</param>
        /// <returns>Área de la figura, en tipo Decimal</returns>
        [WebMethod (Description = "Calcular el área de un Círculo")]
        public decimal circulo(decimal RADIO)
        {
            CalqAreas A = new CalqAreas();
            A.cradio = RADIO;
            return A.circulo();
        }
    }
}

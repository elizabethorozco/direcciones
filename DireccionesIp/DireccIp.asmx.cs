using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace DireccionesIp
{
    //claseA 0.0.0.0 - 127.255.255.255
    //claseB 128.0.0.0 - 191.255.255.255.255
    //claseC 192.0.0.0 - 223.255.255.255
    /// <summary>
    /// Descripción breve de DireccIp
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class DireccIp : System.Web.Services.WebService
    {

        [WebMethod]
        public string DiagnosticoIp(int ip)
        {
            var direcc = "";
            if (ip >= 0 && ip <= 127)
            {
                direcc = "La direccion es Clase A";
            }
            else {
                if (ip >= 128 && ip <= 191)
                {
                    direcc = "La direccion es Clase B";
                }
                else {
                    if (ip >= 192 && ip <= 223)
                    {
                        direcc = "La direccion es Clase C";
                    }
                    else {
                        direcc = "la direccion se encuentra entre la clase D o E";
                    }
                }
            }
            
            return direcc;
        }
    }
}

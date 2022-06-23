using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebServiceCSharp.Model.DAO;
using WebServiceCSharp.Model.VO;

namespace WebServiceCSharp
{
    /// <summary>
    /// Summary description for wssoap
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class wssoap : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public string InserirCargo(string cargo, int vlrmin, int vlrmax)
        {
            string feadback;
            Cargos objcargo = new Cargos();
            CargosDAO objCargosDAO = new CargosDAO();
            objcargo.cargo = cargo;
            objcargo.vlrmin = vlrmin;
            objcargo.vlrmax = vlrmax;
            feadback = objCargosDAO.InserirCargo(objcargo);
            return feadback;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SoapSample
{
    /// <summary>
    /// Summary description for CalculatorService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CalculatorService : System.Web.Services.WebService
    {

        [WebMethod(Description  = "Adds two integers")]
        public int Add(int a, int b)
        {
            return a + b;
        }

        [WebMethod(Description = "Subtracts the second integer argument from the first")]
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        [WebMethod(Description = "Multiplies two integers")]
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        [WebMethod(Description = "Adds two integers")]
        public int Divide(int a, int b)
        {
            if (b == 0) return -1;
            return a / b;
        }
    }
}

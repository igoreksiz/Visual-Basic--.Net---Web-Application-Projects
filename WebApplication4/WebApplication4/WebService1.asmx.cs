using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.OleDb;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace WebApplication4
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    /// 
    public class UserCredentials : System.Web.Services.Protocols.SoapHeader
    {
        public string userName;
        public string password;
    }

    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(Name = "TestService", ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

       

//Apply a SoapHeader attribute to each Web service method that intends to //process the SOAP header
       public UserCredentials consumer;
[SoapHeader("consumer")]
        [WebMethod(Description = "Soap data ")]
        public DataSet show()
        {
            if (consumer.userName == "m" && consumer.password == "222")
            {
                OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users/Lokesh Raja/Documents/Database1.accdb");
                OleDbDataAdapter oda = new OleDbDataAdapter("select * from employee", con);
                DataSet ds = new DataSet();
                oda.Fill(ds);
                return ds;
            }
            else
            {
                return null;
            }
        }
    }
}

    


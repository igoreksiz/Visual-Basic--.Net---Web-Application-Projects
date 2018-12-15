using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.OleDb;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;


namespace WebApplication1
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
   public class UserCredentials : System.Web.Services.Protocols.SoapHeader
    {
        public string userName;
        public string password;
    }


    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(Name="TestService", ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        public UserCredentials consumer;
        [SoapHeader ("consumer")]
        [WebMethod  (Description="SoapHeader")]
        public DataSet show()
        {
            if (consumer.userName == "mani" && consumer.password == "176")
            {
                OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users/Lokesh Raja/Documents/student.accdb");
                OleDbDataAdapter oda = new OleDbDataAdapter("select * from student", con);
                DataSet ds = new DataSet();
                
                return ds;
            }
            else
            {
                return null;
            }
        }

[WebMethod]
public void insert(int sid, string sname, int age, string department,int mark1,int mark2,int mark3,int mark4,int mark5,int total,int avg,string remark)
{
    OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users/Lokesh Raja/Documents/student.accdb");
    con.Open();
    OleDbCommand cmd = new OleDbCommand("insert into student values(" + sid + ",'" + sname + "'," + age + ",'" + department +"',"+mark1+"," +mark2+","+mark3+","+mark4+","+mark5+","+total+","+avg+",'"+remark+"')", con);
    cmd.ExecuteNonQuery();
    con.Close();
}
[WebMethod]
public void update(int sid, string remark)
{
    OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users/Lokesh Raja/Documents/student.accdb");
    con.Open();
    OleDbCommand cmd = new OleDbCommand("update student set remark = '" + remark + "' where sid=" + sid, con);

    con.Close();
}
[WebMethod]
public void delete(int sid)
{
    OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users/Lokesh Raja/Documents/student.accdb");
    con.Open();
    OleDbCommand cmd = new OleDbCommand("delete from student where sid=" + sid, con);
    cmd.ExecuteNonQuery();
    con.Close();
}




    }
}

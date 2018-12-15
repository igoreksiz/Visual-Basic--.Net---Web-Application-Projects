using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            WebApplication4.WebService1 ws = new WebApplication4.WebService1();
            WebApplication4.UserCredentials uc = new WebApplication4.UserCredentials();
            uc.userName = TextBox1.Text;
            uc.password = TextBox2.Text;
            ws.consumer = uc;
            DataSet ds = ws.show();
            GridView1.DataSource = ds;
            GridView1.DataBind();


        }

       
    }
}
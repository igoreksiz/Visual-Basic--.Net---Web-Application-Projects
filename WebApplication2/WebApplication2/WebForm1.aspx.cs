using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
           

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            WebApplication1.WebService1 obj = new WebApplication1.WebService1();
            int id = int.Parse(TextBox1.Text);
            string rem = TextBox12.Text;
            obj.update(id, rem);


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int s1 = int.Parse(TextBox1.Text);
            string s2 = TextBox2.Text;
            int s3 = int.Parse(TextBox3.Text);
            string dep = TextBox4.Text;
            int m1 = int.Parse(TextBox5.Text);
            int m2 = int.Parse(TextBox6.Text);
            int m3 = int.Parse(TextBox7.Text);
            int m4 = int.Parse(TextBox8.Text);
            int m5 = int.Parse(TextBox9.Text);
            int t = m1 + m2 + m3 + m4 + m5;
            TextBox10.Text = t.ToString();
            int avg = t / 5;
            TextBox11.Text = avg.ToString();
            string rem = TextBox12.Text;
            WebApplication1.WebService1 obj = new WebApplication1.WebService1();
            obj.insert(s1, s2, s3, dep, m1, m2, m3, m4, m5, t, avg, rem);   
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            WebApplication1.WebService1 obj = new WebApplication1.WebService1();
            int id = int.Parse(TextBox1.Text);
            obj.delete(id);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            WebApplication1.WebService1 ws = new WebApplication1.WebService1();
            WebApplication1.UserCredentials uc = new WebApplication1.UserCredentials();
            uc.userName = TextBox13.Text;
            uc.password = TextBox14.Text;
            ws.consumer = uc;
            DataSet ds = ws.show();
            GridView1.DataSource = ds;
            GridView1.DataBind();

            }
    }
}
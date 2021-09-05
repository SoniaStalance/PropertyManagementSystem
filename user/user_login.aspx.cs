using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace PropertyManagementSystem.user
{
    public partial class user_login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\PropertyManagementSystem\App_Data\pms.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        protected void b1_Click(object sender, EventArgs e)
        {
            int i = 0,id=0;
        
            SqlCommand cmd6 = con.CreateCommand();
            cmd6.CommandType = CommandType.Text;
            cmd6.CommandText = "select id from user_registeration where username='" + username.Text + "'";
            DataTable dt6 = new DataTable();
            SqlDataAdapter da6 = new SqlDataAdapter(cmd6);
            da6.Fill(dt6);

            foreach (DataRow dr in dt6.Rows)
            {
                id = Convert.ToInt32(dr["id"]);
            }

            

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from user_registeration where id='" + id + "' and password='" + password.Text + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (i > 0)
            {
                Session["user"] = id;
                Response.Redirect("myProfile.aspx");

            }
            else
            {
                error.Style.Add("display", "block");
            }
        }

        protected void b2_Click(object sender, EventArgs e)
        {
            Response.Redirect("user_registeration.aspx");
        }

        protected void b3_Click(object sender, EventArgs e)
        {
            Response.Redirect("../admin/login.aspx");
        }
    }
}
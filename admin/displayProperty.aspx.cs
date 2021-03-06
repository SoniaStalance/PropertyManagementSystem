using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace PropertyManagementSystem.admin
{
    public partial class displayProperty : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\PropertyManagementSystem\App_Data\pms.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            if (Session["admin"] == null)
                Response.Redirect("login.aspx");

            DataTable dt = new DataTable();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Property";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
           
            r1.DataSource = dt;
            r1.DataBind();

            DataTable dt1 = new DataTable();

            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from PropertyRegisteration";
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);

            r2.DataSource = dt1;
            r2.DataBind();
        }
    }
}
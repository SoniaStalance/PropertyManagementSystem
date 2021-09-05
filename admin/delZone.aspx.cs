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
    public partial class delZone : System.Web.UI.Page
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
            int f = 0;

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete Zone where id='" + Request.QueryString["id"].ToString() + "'";
            try
            {
                cmd.ExecuteNonQuery();
                f = 1;
            }
            catch (Exception)
            {

            }
            finally
            {
                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select * from Zone";
                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                da1.Fill(dt1);
                r1.DataSource = dt1;
                r1.DataBind();

                if (f == 0)
                    error.Style.Add("display", "block");
                else
                    success.Style.Add("display", "block");

                
            }
        }
    }
}
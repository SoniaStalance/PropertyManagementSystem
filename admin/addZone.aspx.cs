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
    public partial class add : System.Web.UI.Page
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
        }

        protected void b1_Click(object sender, EventArgs e)
        {
            int count = 0;
            

            
                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select * from Zone where name='" + (name.Text).ToLower() + "'";
                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                da1.Fill(dt1);

                count = Convert.ToInt32(dt1.Rows.Count.ToString());

                if (count == 0)
                {

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp";
                cmd.Parameters.Add("@name",SqlDbType.VarChar).Value=name.Text;
                    cmd.ExecuteNonQuery();
                Response.Redirect("displayZone.aspx");

                }
                else
            {
                error.Style.Add("display", "block");
            }
            
            

               
                    
               

        }
    }
}
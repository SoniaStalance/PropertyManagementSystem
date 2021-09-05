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
    public partial class editZone : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\PropertyManagementSystem\App_Data\pms.mdf;Integrated Security=True");
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            if (Session["admin"] == null)
                Response.Redirect("login.aspx");

            id = Convert.ToInt32(Request.QueryString["id"].ToString());
            if (IsPostBack) return;

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Zone where id="+id+"";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach(DataRow dr in dt.Rows)
            {
                zoneName.Text = dr["name"].ToString();
            }
        }

        protected void b1_Click(object sender, EventArgs e)
        {
            int count1 = 0,count2=0;

            string zn = (zoneName.Text).ToLower();

            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from Zone where name='" + zn + "' and id='"+id+"'";
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);

            count1 = Convert.ToInt32(dt1.Rows.Count.ToString());
            if (count1==1)
            {
                Response.Redirect("displayZone.aspx");
            }
            else
            {
                SqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "select * from Zone where name='" + zn + "'";
                DataTable dt2 = new DataTable();
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                da2.Fill(dt2);

                count2 = Convert.ToInt32(dt2.Rows.Count.ToString());

                if (count2 > 0)
                {
                    Response.Write("<script>alert('Zone already exists')</script>");

                }
                else
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update Zone set name='" + zn + "' where id=" + id + "";
                    cmd.ExecuteNonQuery();
                    Response.Redirect("displayZone.aspx");
                }
            }
        }
    }
}
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
    public partial class addWard : System.Web.UI.Page
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

            if (IsPostBack)
                return;


            zone.Items.Clear();
            zone.Items.Add("Select");
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select name from Zone";
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);

            foreach (DataRow dr in dt1.Rows)
            {
                zone.Items.Add(dr["name"].ToString());
            }
        }

        protected void b1_Click(object sender, EventArgs e)
        {

            int count = 0;

            if(((zone.SelectedItem).ToString())=="Select")
            {
                Response.Write("<script>alert('Select zone id')</script>");

            }
            else
            {
                try
                {
                    string wn = (wardName.Text).ToLower();

                    SqlCommand cmd2 = con.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "select * from Ward where name='" + wn + "'";
                    DataTable dt2 = new DataTable();
                    SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                    da2.Fill(dt2);

                    count = Convert.ToInt32(dt2.Rows.Count.ToString());

                    if (count > 0)
                    {
                        Response.Write("<script>alert('Ward already exists')</script>");

                    }
                    else
                    {

                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "insert into Ward values('" + Convert.ToInt32(zoneID.Text) + "','" + wn + "')";
                        cmd.ExecuteNonQuery();


                        Response.Redirect("displayWard.aspx");
                    }

                }
                catch
                {
                    Response.Write("<script>alert('Enter ward name')</script>");

                }
            }
        }

        protected void zone_SelectedIndexChanged(object sender, EventArgs e)
        {
            zoneID.Text = " ";
            SqlCommand cmd4 = con.CreateCommand();
            cmd4.CommandType = CommandType.Text;
            cmd4.CommandText = "select id from Zone where name='" + (zone.SelectedItem).ToString() + "'";
            DataTable dt4 = new DataTable();
            SqlDataAdapter da4 = new SqlDataAdapter(cmd4);
            da4.Fill(dt4);

            foreach (DataRow dr in dt4.Rows)
            {
                zoneID.Text = dr["id"].ToString();
            }
        }
    }
}
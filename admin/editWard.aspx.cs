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
    public partial class editWard : System.Web.UI.Page
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
            cmd.CommandText = "select * from Ward where id=" + id + "";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                zoneID.Text = dr["zid"].ToString();
                wardName.Text = dr["name"].ToString();
            }

            zone.Items.Clear();
            zone.Items.Add("Select zone");
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
            int count2 = 0, count3 = 0, count4 = 0;

            if (((zone.SelectedItem).ToString()) == "Select zone")
            {
                Response.Write("<script>alert('Select zone')</script>");

            }
            else
            { 
                try
                {
                string wn = (wardName.Text).ToLower();

                    SqlCommand cmd2 = con.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "select * from Ward where name='" + wn + "' and zid='" + zoneID.Text + "' and id='" + id + "'";
                    DataTable dt2 = new DataTable();
                    SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                    da2.Fill(dt2);

                    count2 = Convert.ToInt32(dt2.Rows.Count.ToString());

                    if (count2 == 1)
                    {
                        Response.Redirect("displayWard.aspx");
                    }
                    else
                    {

                        SqlCommand cmd3 = con.CreateCommand();
                        cmd3.CommandType = CommandType.Text;
                        cmd3.CommandText = "select * from Ward where name='" + wn + "' and zid!='" + zoneID.Text + "' and id='" + id + "'";
                        DataTable dt3 = new DataTable();
                        SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
                        da3.Fill(dt3);

                        count3 = Convert.ToInt32(dt3.Rows.Count.ToString());

                        if (count3 == 1)
                        {
                            SqlCommand cmd = con.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "update Ward set name='" + wn + "', zid='" + zoneID.Text + "' where id=" + id + "";
                            cmd.ExecuteNonQuery();
                            Response.Redirect("displayWard.aspx");

                        }
                        else
                        {
                            SqlCommand cmd4 = con.CreateCommand();
                            cmd4.CommandType = CommandType.Text;
                            cmd4.CommandText = "select * from Ward where name='" + wn + "'";
                            DataTable dt4 = new DataTable();
                            SqlDataAdapter da4 = new SqlDataAdapter(cmd4);
                            da4.Fill(dt4);

                            count4 = Convert.ToInt32(dt4.Rows.Count.ToString());

                            if (count4 > 0)
                            {
                                Response.Write("<script>alert('Ward already exists')</script>");
                            }
                            else
                            {
                                SqlCommand cmd5 = con.CreateCommand();
                                cmd5.CommandType = CommandType.Text;
                                cmd5.CommandText = "update Ward set name='" + wn + "', zid='" + zoneID.Text + "' where id=" + id + "";
                                cmd5.ExecuteNonQuery();
                                Response.Redirect("displayWard.aspx");
                            }
                        }
                    }
                }


            catch
            {
                Response.Write("<script>alert('Ward name cannot be empty')</script>");

            }
        }
        }
            
        

        protected void zone_SelectedIndexChanged(object sender, EventArgs e)
        {
            zoneID.Text = "";
            SqlCommand cmd6 = con.CreateCommand();
            cmd6.CommandType = CommandType.Text;
            cmd6.CommandText = "select id from Zone where name='" + (zone.SelectedItem).ToString() + "'";
            DataTable dt6 = new DataTable();
            SqlDataAdapter da6 = new SqlDataAdapter(cmd6);
            da6.Fill(dt6);

            foreach (DataRow dr in dt6.Rows)
            {
                zoneID.Text = dr["id"].ToString();
            }
        }
    }
}
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
    public partial class user_registeration : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\pms.mdf;Integrated Security=True");

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
            int count = 0;
            int count2 = 0;
            string un = (username.Text).ToLower();
            string p = (phone.Text).ToString();
            int l = p.Length;

            if(un.Equals("")||(password.Text).Equals("")||p.Equals(""))
            {
                Response.Write("<script>alert('Invaild entries')</script>");
            }
            else
            { 

            if (l > 10)
                Response.Write("<script>alert('Phone no is exceeding 10 digits')</script>");
            else
            { 

            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from user_registeration where username='" + un + "'";
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);

            count = Convert.ToInt32(dt1.Rows.Count.ToString());

                if (count > 0)
                {
                    Response.Write("<script>alert('username already exists')</script>");

                }
                else
                {
                    SqlCommand cmd2 = con.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "select * from user_registeration where phone='" + phone.Text + "'";
                    DataTable dt2 = new DataTable();
                    SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                    da2.Fill(dt2);

                    count2 = Convert.ToInt32(dt2.Rows.Count.ToString());

                        if (count2 > 0)
                        {
                            Response.Write("<script>alert('phone no is already registered')</script>");

                        }
                        else
                        {
                            try
                            {
                                SqlCommand cmd = con.CreateCommand();
                                cmd.CommandType = CommandType.Text;
                                cmd.CommandText = "insert into user_registeration values('" + fname.Text + "','" + lname.Text + "','" + phone.Text + "','" + un + "','" + password.Text + "')";
                                cmd.ExecuteNonQuery();

                                Response.Redirect("user_login.aspx");
                            }
                            catch
                            {
                                Response.Write("<script>alert('Error!')</script>");
                            }
                        }
                    }
                }
            }
        }
    }
}
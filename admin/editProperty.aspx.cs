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
    public partial class editProperty : System.Web.UI.Page
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
            cmd.CommandText = "select * from Property where id=" + id + "";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                wardID.Text = dr["ward"].ToString();
                ownerID.Text = dr["owner"].ToString();
                pa.Text = dr["size"].ToString();
                ba.Text = dr["built"].ToString();
            }

            ward.Items.Clear();
            ward.Items.Add("Select ward");
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select name from Ward";
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);

            foreach (DataRow dr in dt1.Rows)
            {
                ward.Items.Add(dr["name"].ToString());
            }

            
            owner.Items.Clear();
            owner.Items.Add("Select owner");
            SqlCommand cmd0 = con.CreateCommand();
            cmd0.CommandType = CommandType.Text;
            cmd0.CommandText = "select username from user_registeration";
            DataTable dt0 = new DataTable();
            SqlDataAdapter da0 = new SqlDataAdapter(cmd0);
            da0.Fill(dt0);

            foreach (DataRow dr in dt0.Rows)
            {
                owner.Items.Add(dr["username"].ToString());
            }
        }

        protected void ward_SelectedIndexChanged(object sender, EventArgs e)
        {
            wardID.Text = " ";

            SqlCommand cmd3 = con.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "select id from Ward where name='" + (ward.SelectedItem).ToString() + "'";
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
            da3.Fill(dt3);

            foreach (DataRow dr in dt3.Rows)
            {
                wardID.Text = dr["id"].ToString();
            }
        }

        protected void owner_SelectedIndexChanged(object sender, EventArgs e)
        {
            ownerID.Text = "";

            SqlCommand cmd4 = con.CreateCommand();
            cmd4.CommandType = CommandType.Text;
            cmd4.CommandText = "select id from user_registeration where username='" + (owner.SelectedItem).ToString() + "'";
            DataTable dt4 = new DataTable();
            SqlDataAdapter da4 = new SqlDataAdapter(cmd4);
            da4.Fill(dt4);

            foreach (DataRow dr in dt4.Rows)
            {
                ownerID.Text = dr["id"].ToString();
            }
        }
        float calTax(int size, int built, int u, int c)
        {
            float tax = 2 * ((size / 5) + (built / 5));

            if (u == 1)
                tax += (tax / 2);

            if (c == 1)
                tax += (tax / 4);
            return tax;
        }
        protected void b1_Click(object sender, EventArgs e)
        {

           

            if ((((ward.SelectedItem).ToString()) == "Select") || (((owner.SelectedItem).ToString()) == "Select"))
            {
                Response.Write("<script>alert('Invaild entries')</script>");
            }
            else
            {
             try
               {
                    int size = Convert.ToInt32(pa.Text);
                    int built = Convert.ToInt32(ba.Text);
                    int u = Convert.ToInt32(use.SelectedItem.Value);
                    int c = Convert.ToInt32(occ.SelectedItem.Value);
                    float tax = calTax(size, built, u, c);

                    string uu, cc;
                    if (u == 0)
                        uu = "residential";
                    else
                        uu = "commercial";

                    if (c == 0)
                        cc = "self";
                    else
                        cc = "tenanted";

                    int wid, uid;
                    wid = Convert.ToInt32(wardID.Text);
                    uid = Convert.ToInt32(ownerID.Text);

                    if (built > size)
                    {
                        Response.Write("<script>alert('Invalid entry')</script>");
                    }
                    else
                    {
                        SqlCommand cmd5 = con.CreateCommand();
                        cmd5.CommandType = CommandType.Text;
                        cmd5.CommandText = "update Property set ward=" + wid + ",owner=" + uid + ",size=" + size + ",built=" + built + ",occupancy='" + cc + "',type='" + uu + "',tax=" + tax + " where id=" + id + "";

                        cmd5.ExecuteNonQuery();
                        Response.Redirect("displayProperty.aspx");
                    }
                }
                catch (Exception)
                {
                    Response.Write("<script>alert('All fields must be filled')</script>");
                }
            }
        }
    }
}
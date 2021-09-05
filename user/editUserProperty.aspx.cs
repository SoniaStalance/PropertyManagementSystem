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
    public partial class editProperty : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\PropertyManagementSystem\App_Data\pms.mdf;Integrated Security=True");
        int id;

        float calTax(int size, int built, int u, int c)
        {
            float tax = 2 * ((size / 5) + (built / 5));

            if (u == 1)
                tax += (tax / 2);

            if (c == 1)
                tax += (tax / 4);
            return tax;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            if (Session["user"] == null)
                Response.Redirect("user_login.aspx");

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
                pa.Text = dr["size"].ToString();
                ba.Text = dr["built"].ToString();
            }
        }

        protected void b1_Click(object sender, EventArgs e)
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

            

            if (built > size)
            {
                Response.Write("<script>alert('Invaild entry')</script>");
            }
            else
            {
                try
                {
                    SqlCommand cmd5 = con.CreateCommand();
                    cmd5.CommandType = CommandType.Text;
                    cmd5.CommandText = "update Property set built=" + built + ",occupancy='" + cc + "',type='" + uu + "',tax=" + tax + " where id=" + id + "";

                    cmd5.ExecuteNonQuery();
                    Response.Redirect("myProfile.aspx");
                }
                catch (Exception)
                {
                    Response.Write("<script>alert('Enter built area')</script>");
                }
            }
        }
    }
}
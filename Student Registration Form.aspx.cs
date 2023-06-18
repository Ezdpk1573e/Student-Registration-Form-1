using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Student_Registration_Form1
{
    public partial class Student_Registration_Form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Student_Name, Father_Name, Mother_Name, Date_of_Birth, Mobile_No, Gmail, Full_Address;
            Student_Name = TextBox1.Text;
            Father_Name = TextBox2.Text;
            Mother_Name = TextBox3.Text;
            Date_of_Birth = TextBox4.Text;
            Mobile_No = TextBox5.Text;
            Gmail = TextBox6.Text;
            Full_Address = TextBox7.Text;


            String s = "Insert into Stu_Reg1 values('" +TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text+ "','" + TextBox7.Text + "')";

            SqlConnection sq = new SqlConnection(@"Data Source=DEV;Initial Catalog=SHUBHAM;Integrated Security=True");
            sq.Open();

            SqlCommand sc = new SqlCommand(s, sq);
            int i = sc.ExecuteNonQuery();
            if (i > 0)
            {
                Response.Write("inserted......");
            }
            else
            {
                Response.Write("not inserted !");
            }

            TextBox1.Text = string.Empty;
            TextBox2.Text = string.Empty;
            TextBox3.Text = string.Empty;
            TextBox4.Text = string.Empty;
            TextBox5.Text = string.Empty;
            TextBox6.Text = string.Empty;
            TextBox7.Text = string.Empty;
        }
    }
}
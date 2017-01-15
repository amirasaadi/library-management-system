using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Form1 : Form
    {
        SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-9UL50MI;Initial Catalog=Library;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandType = CommandType.StoredProcedure;
            //اسم تابعی که در فایل های sql نوشته ایم

            sqlcmd.CommandText = "Logedin";
            sqlcmd.Parameters.Add("@UserName", SqlDbType.NVarChar, 15).Value = txtUsername.Text;
            sqlcmd.Parameters.Add("@PassWord", SqlDbType.NVarChar, 15).Value = txtPassword.Text;
            sqlcmd.Parameters.Add("@r", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            sqlcon.Open();
            sqlcmd.ExecuteNonQuery();
            string id = sqlcmd.Parameters["@r"].Value.ToString();
            if (id == "1")
            {
                admin mya = new admin();
                mya.Show();
                this.Hide();
            }
            else if(id == "0")
            {
                MessageBox.Show("نام کاربری یا کلمه عبور اشتباه میباشد","هشدار",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                Members mym = new Members();
                mym.ID = id;
                mym.Show();
                this.Hide();
            }
            sqlcon.Close();
            txtPassword.Text = "";
            txtUsername.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-V0Q63QM;Initial Catalog=Library;Integrated Security=True");

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

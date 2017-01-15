using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Library
{
    public partial class lending_managment : Form
    {
        SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-9UL50MI;Initial Catalog=Library;Integrated Security=True");
        public lending_managment()
        {
            InitializeComponent();
        }
        public void defaultview()
        {
            SqlDataAdapter SQLDa = new SqlDataAdapter("select * from Book", sqlcon);
            DataSet Ds = new DataSet();
            SQLDa.Fill(Ds, "Book");
            dataGridView1.DataSource = Ds.Tables["Book"];
        }

        private void txtLend_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "Lending";
                sqlcmd.Parameters.Add("@N_Code", SqlDbType.NVarChar, 10).Value = txtNationalKod.Text;
                sqlcmd.Parameters.Add("@Book_Code", SqlDbType.NVarChar, 10).Value = txtBookID.Text;
                sqlcmd.Parameters.Add("@r", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                sqlcon.Open();
                sqlcmd.ExecuteNonQuery();
                string result = sqlcmd.Parameters["@r"].Value.ToString();
                if (result == "0")
                {
                    MessageBox.Show("عدم رعایت محدودیت تعداد کتاب");

                }
                else if ( result == "1")
                {
                    MessageBox.Show("با موفقیت امانت داده شد");
                }
                else if (result == "2")
                {
                    MessageBox.Show("این کتاب رزرو شده است");
                }
                else if (result == "3")
                {
                    MessageBox.Show("کد کتاب اشتباه است");
                }
                else if (result == "4")
                {
                    MessageBox.Show("این کتاب در امانت است");
                }
                else if (result == "5")
                {
                    MessageBox.Show("این کد ملی وجود ندارد");
                }
                sqlcon.Close();
                defaultview();

            }
            catch
            {
                MessageBox.Show("عملیات ناموفق بود");
            }
            finally
            {
                txtBookID.Text = "";
                txtNationalKod.Text = "";
            }
        }
    }
}

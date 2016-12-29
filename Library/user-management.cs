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
    public partial class user_management : Form
    {
        SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-9UL50MI;Initial Catalog=Library;Integrated Security=True");
        public void GetList()
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = "Member_View";
            SqlDataAdapter a = new SqlDataAdapter();
            a.SelectCommand = sqlcmd;
            DataTable b = new DataTable();
            a.Fill(b);
            dataGridView1.DataSource = b;

            dataGridView1.Columns[0].HeaderText = "کد ملی";
            dataGridView1.Columns[1].HeaderText = "شماره شناسنامه";
            dataGridView1.Columns[2].HeaderText = "نام";
            dataGridView1.Columns[3].HeaderText = "نام خانوادگی";
            dataGridView1.Columns[4].HeaderText = "نام پدر";
            dataGridView1.Columns[5].HeaderText = "کد پستی";
            dataGridView1.Columns[6].HeaderText = "تاریخ تولد";
            dataGridView1.Columns[7].HeaderText = "شماره تلفن";
            dataGridView1.Columns[8].HeaderText = "آدرس";
            dataGridView1.Columns[9].HeaderText = "شناسه";
        }
        public user_management()
        {
            InitializeComponent();
        }

        private void user_management_Load(object sender, EventArgs e)
        {
            GetList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtFamily.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtFathername.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtIDKodMeli.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtPostalcodeKodPosti.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtBirthdayTT.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtPhoneNumber.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtAddress.Text= dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtIDShomareOzviat.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtUserName.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtPassword.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandType = CommandType.StoredProcedure;
            //اسم تابعی که در فایل های sql نوشته ایم

            sqlcmd.CommandText = "Delete_Member";
            sqlcmd.Parameters.Add("@NC", SqlDbType.NVarChar, 50).Value = txtIDKodMeli.Text;
            sqlcmd.Parameters.Add("@r", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            sqlcon.Open();
            sqlcmd.ExecuteNonQuery();

            if (sqlcmd.Parameters["@r"].Value.ToString() == "1")
            {
                MessageBox.Show("با موفیت حذف شد");
            }
            else
            {
                MessageBox.Show("این کاربر وجود ندارد");
            }
            sqlcon.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtPassword2.Text==txtPassword.Text)
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "Update_Member";
                sqlcmd.Parameters.Add("@National_Code", SqlDbType.NVarChar, 10).Value = txtIDKodMeli.Text;
                sqlcmd.Parameters.Add("@First_Name", SqlDbType.NVarChar, 10).Value = txtName.Text;
                sqlcmd.Parameters.Add("@Certificate_Number", SqlDbType.NVarChar, 10).Value = txtce.Text;
                sqlcmd.Parameters.Add("@Last_Name", SqlDbType.NVarChar, 10).Value = txtFamily.Text;
                sqlcmd.Parameters.Add("@Father_Name", SqlDbType.NVarChar, 10).Value = txtFathername.Text;
                sqlcmd.Parameters.Add("@Postal_Code", SqlDbType.NVarChar, 10).Value = txtPostalcodeKodPosti.Text;
                sqlcmd.Parameters.Add("@Birth_Date", SqlDbType.NVarChar, 10).Value = txtBirthdayTT.Text;
                sqlcmd.Parameters.Add("@Phone_Number", SqlDbType.NVarChar, 11).Value = txtPhoneNumber.Text;
                sqlcmd.Parameters.Add("@Address", SqlDbType.NVarChar, 50).Value = txtAddress.Text;
                sqlcmd.Parameters.Add("@UserID", SqlDbType.NVarChar, 10).Value = txtIDShomareOzviat.Text;
                sqlcmd.Parameters.Add("@r", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                sqlcmd.Parameters.Add("@UserName", SqlDbType.NVarChar, 15).Value = txtUserName.Text;
                sqlcmd.Parameters.Add("@PassWord", SqlDbType.NVarChar, 15).Value = txtPassword.Text;
                sqlcon.Open();
                sqlcmd.ExecuteNonQuery();
                if (sqlcmd.Parameters["@r"].Value.ToString() == "1")
                {
                    MessageBox.Show("با موفیت بروز شد");

                }
                else
                {
                    MessageBox.Show("این کاربر وجود دارد");
                }
                sqlcon.Close();
                txtIDKodMeli.Text = "";
                txtName.Text = "";
                txtFamily.Text = "";
                txtFathername.Text = "";
                txtPostalcodeKodPosti.Text = "";
                txtBirthdayTT.Text = "";
                txtPhoneNumber.Text = "";
                txtAddress.Text = "";
                txtIDShomareOzviat.Text = "";
                txtUserName.Text = "";
                txtPassword.Text = "";
            }
            else
            {
                MessageBox.Show("رمز های عبور با هم مطابقت ندارند ");
                txtPassword.Text = "";
                txtPassword2.Text = "";
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtPassword2.Text == txtPassword.Text)
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "Insert_Member";
                sqlcmd.Parameters.Add("@National_Code", SqlDbType.NVarChar, 10).Value = txtIDKodMeli.Text;
                sqlcmd.Parameters.Add("@Certificate_Number", SqlDbType.NVarChar, 10).Value = txtce.Text;
                sqlcmd.Parameters.Add("@First_Name", SqlDbType.NVarChar, 10).Value = txtName.Text;
                sqlcmd.Parameters.Add("@Last_Name", SqlDbType.NVarChar, 10).Value = txtFamily.Text;
                sqlcmd.Parameters.Add("@Father_Name", SqlDbType.NVarChar, 10).Value = txtFathername.Text;
                sqlcmd.Parameters.Add("@Postal_Code", SqlDbType.NVarChar, 10).Value = txtPostalcodeKodPosti.Text;
                sqlcmd.Parameters.Add("@Birth_Date", SqlDbType.NVarChar, 10).Value = txtBirthdayTT.Text;
                sqlcmd.Parameters.Add("@Phone_Number", SqlDbType.NVarChar, 11).Value = txtPhoneNumber.Text;
                sqlcmd.Parameters.Add("@Address", SqlDbType.NVarChar, 50).Value = txtAddress.Text;
                sqlcmd.Parameters.Add("@UserID", SqlDbType.NVarChar, 10).Value = txtIDShomareOzviat.Text;
                sqlcmd.Parameters.Add("@r", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                sqlcmd.Parameters.Add("@UserName", SqlDbType.NVarChar, 15).Value = txtUserName.Text;
                sqlcmd.Parameters.Add("@PassWord", SqlDbType.NVarChar, 15).Value = txtPassword.Text;
                sqlcon.Open();
                sqlcmd.ExecuteNonQuery();
                if (sqlcmd.Parameters["@r"].Value.ToString() == "1")
                {
                    MessageBox.Show("با موفیت بروز شد");

                }
                else
                {
                    MessageBox.Show("این کاربر وجود دارد");
                }
                sqlcon.Close();
                txtIDKodMeli.Text = "";
                txtName.Text = "";
                txtFamily.Text = "";
                txtFathername.Text = "";
                txtPostalcodeKodPosti.Text = "";
                txtBirthdayTT.Text = "";
                txtPhoneNumber.Text = "";
                txtAddress.Text = "";
                txtIDShomareOzviat.Text = "";
                txtUserName.Text = "";
                txtPassword.Text = "";
            }
            else
            {
                MessageBox.Show("رمز های عبور با هم مطابقت ندارند ");
                txtPassword.Text = "";
                txtPassword2.Text = "";
            }
        }
        private void clear()
        {
            txtIDKodMeli.Text = "";
            txtName.Text = "";
            txtFamily.Text = "";
            txtFathername.Text = "";
            txtPostalcodeKodPosti.Text = "";
            txtBirthdayTT.Text = "";
            txtPhoneNumber.Text = "";
            txtAddress.Text = "";
            txtIDShomareOzviat.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtPassword2.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}

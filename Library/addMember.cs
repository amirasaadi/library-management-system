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
    public partial class addMember : Form
    {
        SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-V0Q63QM;Initial Catalog=Library;Integrated Security=True");
        public addMember()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if(txtName.Text.Length!=0)
            {
                lblnameR.Hide();
            }
        }

        private void txtLastname_TextChanged(object sender, EventArgs e)
        {
            if(txtLastname.Text.Length!=0)
            {
                lblLstanameR.Hide();
            }
        }

        private void txtFatherName_TextChanged(object sender, EventArgs e)
        {
            if(txtFatherName.Text.Length!=0)
            {
                lblshomareozviyatR.Hide();
                
            }
        }

        private void افزودنکاربرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addMember mya = new addMember();
            mya.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtPass.Text==txtPass2.Text)
            {
                ///
                

                ///
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "Insert_Member";
                sqlcmd.Parameters.Add("@Certificate_Number", SqlDbType.NVarChar, 10).Value = txtNumber.Text;
                sqlcmd.Parameters.Add("@National_Code", SqlDbType.NVarChar, 10).Value = txtNationalCode.Text;
                sqlcmd.Parameters.Add("@First_Name", SqlDbType.NVarChar, 10).Value = txtName.Text;
                sqlcmd.Parameters.Add("@Last_Name", SqlDbType.NVarChar, 10).Value = txtLastname.Text;
                sqlcmd.Parameters.Add("@Father_Name", SqlDbType.NVarChar, 10).Value = txtFatherName.Text;
                sqlcmd.Parameters.Add("@Postal_Code", SqlDbType.NVarChar, 10).Value = txtPostalCode.Text;
                sqlcmd.Parameters.Add("@Birth_Date", SqlDbType.NVarChar, 10).Value = txtBorn.Text;
                sqlcmd.Parameters.Add("@Phone_Number", SqlDbType.NVarChar, 11).Value = txtPhoneNumber.Text;
                sqlcmd.Parameters.Add("@Address", SqlDbType.NVarChar, 50).Value = txtAddress.Text;
                sqlcmd.Parameters.Add("@UserID", SqlDbType.NVarChar, 10).Value = txtNationalCode.Text;
                sqlcmd.Parameters.Add("@r", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                sqlcmd.Parameters.Add("@UserName", SqlDbType.NVarChar, 15).Value = txtUsername.Text;
                sqlcmd.Parameters.Add("@PassWord", SqlDbType.NVarChar, 15).Value = txtPass.Text;
                sqlcon.Open();
                sqlcmd.ExecuteNonQuery();
                if (sqlcmd.Parameters["@r"].Value.ToString() == "1")
                {
                    MessageBox.Show("با موفیت درج شد");

                }
                else
                {
                    MessageBox.Show("این کاربر وجود دارد");
                }
                sqlcon.Close();
                txtNumber.Text = "";
                txtNationalCode.Text = "";
                txtName.Text = "";
                txtLastname.Text = "";
                txtFatherName.Text = "";
                txtPostalCode.Text = "";
                txtBorn.Text = "";
                txtPhoneNumber.Text = "";
                txtAddress.Text = "";
                txtNationalCode.Text = "";
                txtUsername.Text = "";
                txtPass.Text = "";
                txtPass2.Text = "";
            }
            else
            {
                MessageBox.Show("رمز های عبور با هم مطابقت ندارند ");
                txtPass.Text = "";
                txtPass2.Text = "";
            }
            
        }

        private void txtNationalCode_TextChanged(object sender, EventArgs e)
        {
            //txtUserID.Text = txtNationalCode.Text;
            if(txtNationalCode.Text.Length!=0)
            {
                lblkodmeliR.Hide();
            }
        }

        private void addMember_Load(object sender, EventArgs e)
        {

        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtNumber.Text.Length != 0)
            {
                lblshomareozviyatR.Hide();

            }
            
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if(txtPass.Text.Length!=0)
            {
                lblpassR.Hide();
                if(txtPass.Text.Length<3)
                {
                    lblpasslevel.Text = "آسان";
                    lblpasslevel.ForeColor = System.Drawing.Color.Red;
                }
                else if(txtPass.Text.Length>3&&txtPass.Text.Length<6)
                {
                    lblpasslevel.Text = "متوسط";
                    lblpasslevel.ForeColor = System.Drawing.Color.Orange;
                }
                else if (txtPass.Text.Length > 6 )
                {
                    lblpasslevel.Text = "سخت";
                    lblpasslevel.ForeColor = System.Drawing.Color.Green;
                }
            }
        }
    }
}

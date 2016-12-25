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
    public partial class deleteMember : Form
    {
        SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-V0Q63QM;Initial Catalog=Library;Integrated Security=True");
        public deleteMember()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(txtDelete.Text.Length>0)
            {
                var d = MessageBox.Show("آیا مطمئن هستید میخواهید "+txtDelete.Text+" حذف شود", "حذف کاربر", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {


                    SqlCommand sqlcmd = new SqlCommand();
                    sqlcmd.Connection = sqlcon;
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    //اسم تابعی که در فایل های sql نوشته ایم

                    sqlcmd.CommandText = "Delete_Member";
                    sqlcmd.Parameters.Add("@NC", SqlDbType.NVarChar, 50).Value = txtDelete.Text;
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
                    txtDelete.Text = "";
                }
            }
            else
            {
                MessageBox.Show("لطفا کد ملی را وارد کنید");
            }
            
        }
    }
}

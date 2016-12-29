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
    public partial class addbook : Form
    {
        SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-9UL50MI;Initial Catalog=Library;Integrated Security=True");
        public addbook()
        {
            InitializeComponent();
        }

        private void addbook_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBookcode.Text == "" || txtBookname.Text == "" || txtbookauthor.Text == "" || txtpublisher.Text == "" || txtyear.Text == "" || txtPublish_Number.Text == "" || txtPublish_Number.Text == "")
            {
                MessageBox.Show("لطفا فیلد های ستاره دار را پر نمایید ");
            }
            else
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "Insert_Book";
                sqlcmd.Parameters.Add("@Code", SqlDbType.Int).Value = int.Parse(txtBookcode.Text);
                sqlcmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = txtBookname.Text;
                sqlcmd.Parameters.Add("@Author", SqlDbType.NVarChar, 50).Value = txtbookauthor.Text;
                sqlcmd.Parameters.Add("@Title", SqlDbType.NVarChar, 50).Value = txtbooktitle.Text;
                sqlcmd.Parameters.Add("@Translater", SqlDbType.NVarChar, 50).Value = txtbooktranslater.Text;
                sqlcmd.Parameters.Add("@Publisher", SqlDbType.NVarChar, 50).Value = txtpublisher.Text;
                sqlcmd.Parameters.Add("@Publish_Year", SqlDbType.NVarChar, 50).Value = txtyear.Text;
                sqlcmd.Parameters.Add("@SHABAK", SqlDbType.NVarChar, 50).Value = txtshabak.Text;
                sqlcmd.Parameters.Add("@Category", SqlDbType.NVarChar, 50).Value = txtbookcategory.Text;
                sqlcmd.Parameters.Add("@Publish_Number", SqlDbType.Int).Value = txtPublish_Number.Text;
                sqlcmd.Parameters.Add("@r", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                sqlcmd.Parameters.Add("@Reserved", SqlDbType.Bit).Value = false;
                sqlcmd.Parameters.Add("@Deposited", SqlDbType.Bit).Value = false;
                sqlcon.Open();
                sqlcmd.ExecuteNonQuery();
                if (sqlcmd.Parameters["@r"].Value.ToString() == "1")
                {
                    MessageBox.Show("با موفیت درج شد");
                    lib lib1 = new lib(1);
                }
                else
                {
                    MessageBox.Show("این کتاب وجود دارد");
                }
                sqlcon.Close();
            }
        }

        private void txtBookcode_TextChanged(object sender, EventArgs e)
        {
            if(txtBookcode.Text.Length!=0)
            {
                lkod.Hide();
            }
        }

        private void txtBookname_TextChanged(object sender, EventArgs e)
        {
            if(txtBookname.Text.Length!=0)
            {
                lnam.Hide();
            }
        }

        private void txtbookauthor_TextChanged(object sender, EventArgs e)
        {
            if (txtbookauthor.Text.Length != 0)
            {
                lath.Hide();
            }
        }

        private void txtpublisher_TextChanged(object sender, EventArgs e)
        {
            if (txtpublisher.Text.Length != 0)
            {
                lpubli.Hide();
            }
        }

        private void txtyear_TextChanged(object sender, EventArgs e)
        {
            if (txtyear.Text.Length != 0)
            {
                lsal.Hide();
            }
        }

        private void txtshabak_TextChanged(object sender, EventArgs e)
        {
            if (txtshabak.Text.Length != 0)
            {
                lsha.Hide();
            }
        }

        private void txtPublish_Number_TextChanged(object sender, EventArgs e)
        {
            if (txtPublish_Number.Text.Length != 0)
            {
                lnum.Hide();
            }
        }
    }
}

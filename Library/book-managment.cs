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
    public partial class book_managment : Form
    {
        SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-9UL50MI;Initial Catalog=Library;Integrated Security=True");
        public book_managment()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBookcode.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtBookname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtbookauthor.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtbooktitle.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtbooktranslater.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtpublisher.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtyear.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtshabak.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtbookcategory.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtPublish_Number.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if()
            {

            }
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
            defaultview();
        }
        public void defaultview()
        {
            SqlDataAdapter SQLDa = new SqlDataAdapter("select * from Book", sqlcon);
            DataSet Ds = new DataSet();
            SQLDa.Fill(Ds, "Book");
            dataGridView1.DataSource = Ds.Tables["Book"];
        }
        public void GetList(int input)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandType = CommandType.StoredProcedure;


        }
        private void book_managment_Load(object sender, EventArgs e)
        {
            defaultview();
            dataGridView1.Columns[0].HeaderText = "کد کتاب";
            dataGridView1.Columns[1].HeaderText = "نام کتاب";
            dataGridView1.Columns[2].HeaderText = "نویسنده";
            dataGridView1.Columns[3].HeaderText = "عنوان";
            dataGridView1.Columns[4].HeaderText = "مترجم";
            dataGridView1.Columns[5].HeaderText = "انتشارات";
            dataGridView1.Columns[6].HeaderText = "سال انتشار";
            dataGridView1.Columns[7].HeaderText = "شابک";
            dataGridView1.Columns[8].HeaderText = "موضوع";
            dataGridView1.Columns[9].HeaderText = "شماره انتشار";
            dataGridView1.Columns[10].HeaderText = "وضعیت رزرو";
            dataGridView1.Columns[11].HeaderText = "وضعیت امانت";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBookcode.Text.Length > 0)
            {
                var d = MessageBox.Show("آیا مطمئن هستید میخواهید " + txtBookcode.Text + " حذف شود", "حذف کتاب", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {


                    SqlCommand sqlcmd = new SqlCommand();
                    sqlcmd.Connection = sqlcon;
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    //اسم تابعی که در فایل های sql نوشته ایم

                    sqlcmd.CommandText = "Delete_book";
                    sqlcmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = txtBookcode.Text;
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
                    txtBookcode.Text = "";
                }
            }
            else
            {
                MessageBox.Show("لطفا کد ملی را وارد کنید");
            }
            defaultview();
        }

        private void updatebook_Click(object sender, EventArgs e)
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
                sqlcmd.CommandText = "Update_Book";
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
                    MessageBox.Show("با موفیت بروز شد");
                    lib lib1 = new lib(1);
                }
                else
                {
                    MessageBox.Show("این کتاب وجود دارد");
                }
                sqlcon.Close();
            }
            defaultview();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void clear()
        {
            txtbookauthor.Text = "";
            txtbookcategory.Text = "";
            txtBookcode.Text = "";
            txtBookname.Text = "";
            txtbooktitle.Text = "";
            txtbooktranslater.Text = "";
            txtpublisher.Text = "";
            txtPublish_Number.Text = "";
            txtshabak.Text = "";
            txtyear.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}


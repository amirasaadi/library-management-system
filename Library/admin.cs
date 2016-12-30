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
    public partial class admin : Form
    {
        SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-9UL50MI;Initial Catalog=Library;Integrated Security=True");
        public admin()
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
        public void GetList(int input)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandType = CommandType.StoredProcedure;
            switch (input)
            {
                case 0:
                    {
                        //neveisande
                        sqlcmd.CommandText = "Serach_Book_Author";
                        sqlcmd.Parameters.Add("@Item", SqlDbType.NVarChar, 50).Value = txtSearch.Text;
                        SqlDataAdapter a = new SqlDataAdapter();
                        a.SelectCommand = sqlcmd;
                        DataTable b = new DataTable();
                        a.Fill(b);
                        dataGridView1.DataSource = b;
                        break;
                    }
                case 1:
                    {
                        //kod ketab
                        sqlcmd.CommandText = "Serach_Book_Code";
                        sqlcmd.Parameters.Add("@Item", SqlDbType.Int).Value = int.Parse(txtSearch.Text);
                        SqlDataAdapter a = new SqlDataAdapter();
                        a.SelectCommand = sqlcmd;
                        DataTable b = new DataTable();
                        a.Fill(b);
                        dataGridView1.DataSource = b;
                        break;
                    }
                case 2:
                    {
                        sqlcmd.CommandText = "Serach_Book_Name";
                        sqlcmd.Parameters.Add("@Item", SqlDbType.NVarChar, 50).Value = txtSearch.Text;
                        SqlDataAdapter a = new SqlDataAdapter();
                        a.SelectCommand = sqlcmd;
                        DataTable b = new DataTable();
                        a.Fill(b);
                        dataGridView1.DataSource = b;
                        //nam
                        break;
                    }
                case 3:
                    {
                        sqlcmd.CommandText = "Serach_Book_Publish_Year";
                        sqlcmd.Parameters.Add("@Item", SqlDbType.Int).Value = int.Parse(txtSearch.Text);
                        SqlDataAdapter a = new SqlDataAdapter();
                        a.SelectCommand = sqlcmd;
                        DataTable b = new DataTable();
                        a.Fill(b);
                        dataGridView1.DataSource = b;
                        //sal
                        break;
                    }
                case 4:
                    {

                        sqlcmd.CommandText = "Serach_Book_Publisher";
                        sqlcmd.Parameters.Add("@Item", SqlDbType.NVarChar, 50).Value = txtSearch.Text;
                        SqlDataAdapter a = new SqlDataAdapter();
                        a.SelectCommand = sqlcmd;
                        DataTable b = new DataTable();
                        a.Fill(b);
                        dataGridView1.DataSource = b;
                        //enteshar
                        break;
                    }
                case 5:
                    {
                        sqlcmd.CommandText = "Serach_Book_Translater";
                        sqlcmd.Parameters.Add("@Item", SqlDbType.NVarChar, 50).Value = txtSearch.Text;
                        SqlDataAdapter a = new SqlDataAdapter();
                        a.SelectCommand = sqlcmd;
                        DataTable b = new DataTable();
                        a.Fill(b);
                        dataGridView1.DataSource = b;
                        //motar
                        break;
                    }
                default:
                    break;
            }
            
        }

        private void افزودنکاربرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addMember mya = new addMember();
            mya.ShowDialog();
            
        }

        private void حذفکاربرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteMember mya = new deleteMember();
            mya.ShowDialog();
            
        }

        private void بروزرسانیاطلاعاتکاربرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addMember mya = new addMember();
            mya.ShowDialog();
        }

        private void لیستکاربرانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memberlist mya = new memberlist();
            mya.ShowDialog();
        }

        private void افزودنکتابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addbook mya = new addbook();
            mya.ShowDialog();
        }

        private void حذفکتابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deletebook mya = new deletebook();
            mya.ShowDialog();
        }

        private void ویرایشاطلاعاتکتابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editbook mya = new editbook();
            mya.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void admin_Load(object sender, EventArgs e)
        {
            groupBox1.Width = this.Width;
            timer1.Start();
           
            lib lib1 = new lib();
            if (lib1.check()==1)
            {
                defaultview();
            }
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
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            comboBox1.SelectedIndex = 2;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int selected = comboBox1.SelectedIndex;
            if(txtSearch.Text.Length>0)
            {
                GetList(selected);
            }
            else
            {
                MessageBox.Show("لطفا عبارت جستجو را وارد کنید","احتیاط",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = System.DateTime.Now.ToString();
            /*
            if(txtSearch.Text!=null)
            {
                GetList();
            }
            else
            {
                defaultview();
            }*/
            
        }

        private void خروجToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var d = MessageBox.Show("آیا برای خروج اطمینان دارید؟","خروج",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (d==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            defaultview();
        }

        private void admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void مدیریتکاربرانToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            user_management mya = new user_management();
            mya.ShowDialog();
        }

        private void تستسرچکتابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_Book a = new Search_Book();
            a.ShowDialog();
        }

        private void مدیریتکتابهاToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            book_managment a = new book_managment();
            a.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void admin_Activated(object sender, EventArgs e)
        {
            defaultview();
        }

        private void admin_Deactivate(object sender, EventArgs e)
        {
            defaultview();
        }

        private void admin_EnabledChanged(object sender, EventArgs e)
        {
            defaultview();
        }
    }
}

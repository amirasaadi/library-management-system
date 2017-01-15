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
    public partial class Members : Form
    {
        SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-9UL50MI;Initial Catalog=Library;Integrated Security=True");
        string s = "";
        private string _name;
        private string _National_code; 
        private string _id;
        public string ID
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
        public Members()
        {
            InitializeComponent();
        }

        public void defaultview()
        {
            SqlDataAdapter SQLDa = new SqlDataAdapter("select * from Book", sqlcon);
            DataSet Ds = new DataSet();
            SQLDa.Fill(Ds, "Book");
            dataGridView1.DataSource = Ds.Tables["Book"];
            dataGridView2.DataSource = Ds.Tables["Book"];
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

        /*
        private void خروجToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var d = MessageBox.Show("آیا برای خروج اطمینان دارید؟", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Application.Exit();
            }
        }*/



        private void admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textname.Text != "")
            {
                if (s == "")
                    s = "Name=" + "'" + textname.Text + "'";
                else
                    s += "AND Name=" + "'" + textname.Text + "'";
            }
            if (textpub.Text != "")
            {
                if (s == "")
                    s = "Publisher=" + "'" + textpub.Text + "'";
                else
                    s += "AND Publisher=" + "'" + textpub.Text + "'";
            }
            if (textauthor.Text != "")
            {
                if (s == "")
                    s = "Author=" + "'" + textauthor.Text + "'";
                else
                    s += "AND Author=" + "'" + textauthor.Text + "'";
            }
            if (textcode.Text != "")
            {
                if (s == "")
                    s = "Code=" + "'" + textcode.Text + "'";
                else
                    s += "AND Code=" + "'" + textcode.Text + "'";
            }
            if (textyear.Text != "")
            {
                if (s == "")
                    s = "Publish_Year=" + "'" + textyear.Text + "'";
                else
                    s += "AND Publish_Year=" + "'" + textyear.Text + "'";
            }
            if (texttra.Text != "")
            {
                if (s == "")
                    s = "Translater=" + "'" + texttra.Text + "'";
                else
                    s += "AND Translater=" + "'" + texttra.Text + "'";
            }
            label10.Text = s;

            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandType = CommandType.StoredProcedure;
            //neveisande
            sqlcmd.CommandText = "Big_Search";
            sqlcmd.Parameters.Add("@String", SqlDbType.NVarChar, 150).Value = s;
            SqlDataAdapter a = new SqlDataAdapter();
            a.SelectCommand = sqlcmd;
            DataTable b = new DataTable();
            a.Fill(b);
            dataGridView2.DataSource = b;
            s = "";
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            int selected = comboBox1.SelectedIndex;
            if (txtSearch.Text.Length > 0)
            {
                GetList(selected);
            }
            else
            {
                MessageBox.Show("لطفا عبارت جستجو را وارد کنید", "احتیاط", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            defaultview();
        }

        private void Members_Load(object sender, EventArgs e)
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
            //for advance search
            dataGridView2.Columns[0].HeaderText = "کد کتاب";
            dataGridView2.Columns[1].HeaderText = "نام کتاب";
            dataGridView2.Columns[2].HeaderText = "نویسنده";
            dataGridView2.Columns[3].HeaderText = "عنوان";
            dataGridView2.Columns[4].HeaderText = "مترجم";
            dataGridView2.Columns[5].HeaderText = "انتشارات";
            dataGridView2.Columns[6].HeaderText = "سال انتشار";
            dataGridView2.Columns[7].HeaderText = "شابک";
            dataGridView2.Columns[8].HeaderText = "موضوع";
            dataGridView2.Columns[9].HeaderText = "شماره انتشار";
            dataGridView2.Columns[10].HeaderText = "وضعیت رزرو";
            dataGridView2.Columns[11].HeaderText = "وضعیت امانت";

            comboBox1.SelectedIndex = 2;
            
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandType = CommandType.StoredProcedure;
            //male first name
            /*sqlcmd.CommandText = "return_member_name";
            sqlcmd.Parameters.Add("@id", SqlDbType.NVarChar, 10).Value = _id;
            sqlcmd.Parameters.Add("@return", SqlDbType.NVarChar , 50).Direction = ParameterDirection.ReturnValue;*/
            //sqlcon.Open();
            //sqlcmd.ExecuteNonQuery();
            //_name = sqlcmd.Parameters["@return"].Value.ToString();
            // male national code 
            sqlcmd.CommandText = "return_member_nationalcode";
            sqlcmd.Parameters.Add("@id", SqlDbType.NVarChar, 10).Value = _id;
            //sqlcmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50);
            //sqlcmd.Parameters("@Name").Direction = ParameterDirection.Output;
            sqlcmd.Parameters.Add("@ncode", SqlDbType.NVarChar, 10).Direction = ParameterDirection.ReturnValue;
            sqlcon.Open();
            sqlcmd.ExecuteNonQuery();
            _National_code = sqlcmd.Parameters["@ncode"].Value.ToString();
            //_name = sqlcmd.Parameters["@Name"];
            sqlcon.Close();
            //label11.Text = _name;
            label12.Text = _National_code;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label1.Text = System.DateTime.Now.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int bookkode = 12345;
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = "Reserv_Book";
            sqlcmd.Parameters.Add("@Book_Code", SqlDbType.Int).Value = bookkode;
            sqlcmd.Parameters.Add("@N_Code", SqlDbType.NVarChar,10).Value = _National_code;

            sqlcmd.Parameters.Add("@r", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            sqlcon.Open();
            sqlcmd.ExecuteNonQuery();
            string result = sqlcmd.Parameters["@r"].Value.ToString();
            if (result == "1")
            {
                MessageBox.Show("با موفیت رزور شد");

            }
            else if (result == "2")
            {
                MessageBox.Show("این کتاب رزرو شده است");
            }
            else
            {
                MessageBox.Show("بیش از چهار کتاب نمی توان رزرو کرد");
            }
            sqlcon.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (true)
            {

            }
        }
    }
}


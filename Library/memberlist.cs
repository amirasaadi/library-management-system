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
    public partial class memberlist : Form
    {
        SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-9UL50MI;Initial Catalog=Library;Integrated Security=True");
        public memberlist()
        {
            InitializeComponent();
        }
        public void GetList()
        {

            SqlDataAdapter SQLDa = new SqlDataAdapter("select * from Member", sqlcon);
            DataSet Ds = new DataSet();

            SQLDa.Fill(Ds, "Member");

            dataGridView1.DataSource = Ds.Tables["Member"];
            
            dataGridView1.Columns[0].HeaderText = "کد ملی";
            dataGridView1.Columns[1].HeaderText = "شماره عضویت";
            dataGridView1.Columns[2].HeaderText = "نام";
            dataGridView1.Columns[3].HeaderText = "نام خانوادگی";
            dataGridView1.Columns[4].HeaderText = "نام پدر";
            dataGridView1.Columns[5].HeaderText = "کد پستی";
            dataGridView1.Columns[6].HeaderText = "تاریخ تولد";
            dataGridView1.Columns[7].HeaderText = "شماره تلفن";
            dataGridView1.Columns[8].HeaderText = "آدرس";
            dataGridView1.Columns[9].HeaderText = "شناسه";
        }

        private void memberlist_Load(object sender, EventArgs e)
        {
            
            GetList();
        }
    }
}

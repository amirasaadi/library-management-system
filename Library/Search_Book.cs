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
    public partial class Search_Book : Form
    {
        string s = "";
        SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-9UL50MI;Initial Catalog=Library;Integrated Security=True");
        public Search_Book()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
                    s = "Publisher=" +"'"+ textpub.Text+"'";
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
            label1.Text = s;
           
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
            dataGridView1.DataSource = b;
            s = "";
        }

        private void textname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

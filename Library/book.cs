using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Library
{
    class book
    {
        public book()
        {
        }
        int _code;
        string _name;
        string _author;
        string _title;
        string _translater;
        string _publisher;
        string _year;
        public Boolean addbook(string txtBookcode, string txtBookname, string txtbookauthor, string txtbooktitle, string txtbooktranslater, string txtpublisher, string txtyear, string txtshabak, string txtbookcategory,int txtPublish_Number)
        {
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "Insert_Book";
                sqlcmd.Parameters.Add("@Code", SqlDbType.Int).Value = int.Parse(txtBookcode);
                sqlcmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = txtBookname;
                sqlcmd.Parameters.Add("@Author", SqlDbType.NVarChar, 50).Value = txtbookauthor;
                sqlcmd.Parameters.Add("@Title", SqlDbType.NVarChar, 50).Value = txtbooktitle;
                sqlcmd.Parameters.Add("@Translater", SqlDbType.NVarChar, 50).Value = txtbooktranslater;
                sqlcmd.Parameters.Add("@Publisher", SqlDbType.NVarChar, 50).Value = txtpublisher;
                sqlcmd.Parameters.Add("@Publish_Year", SqlDbType.NVarChar, 50).Value = txtyear;
                sqlcmd.Parameters.Add("@SHABAK", SqlDbType.NVarChar, 50).Value = txtshabak;
                sqlcmd.Parameters.Add("@Category", SqlDbType.NVarChar, 50).Value = txtbookcategory;
                sqlcmd.Parameters.Add("@Publish_Number", SqlDbType.Int).Value = txtPublish_Number;
                sqlcmd.Parameters.Add("@r", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                sqlcmd.Parameters.Add("@Reserved", SqlDbType.Bit).Value = false;
                sqlcmd.Parameters.Add("@Deposited", SqlDbType.Bit).Value = false;
                sqlcon.Open();
                sqlcmd.ExecuteNonQuery();
                if (sqlcmd.Parameters["@r"].Value.ToString() == "1")
                {
                    return true;
                    lib lib1 = new lib(1);
                }
                else
                {
                    return false;
                }
                sqlcon.Close();
            }
            

        }
    }
}

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

namespace LoginTest01
{
    public partial class Loginfrm : Form
    {
        public Loginfrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=INFORMATICS;Initial Catalog=Komac_Test;User ID=sa;Password=komac11234");
            string query = "Select * FROM KomacUSer WHERE UserID = '" + txtID.Text.Trim() + "' and UserPassword = '" + txtPW.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count == 1)
            {
                DataRow dr = dt.Rows[0];
                Mainframe.CurrentID = Convert.ToInt32(dr["UserID"]);
                //MessageBox.Show(dr["UserID"].ToString());
                Mainframe objMain = new Mainframe();
                this.Hide();
                objMain.Show();
            }
            else
            {
                MessageBox.Show("Check your Id and password");
            }

        }
    }
}

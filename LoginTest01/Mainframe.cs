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
    public partial class Mainframe : Form
    {
        public static int CurrentID;
        public Mainframe()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=INFORMATICS;Initial Catalog=Komac_Test;User ID=sa;Password=komac11234");
        private void Mainframe_Load(object sender, EventArgs e)
        {
            getKomacuser();
        }
        private void getKomacuser()
        {
            SqlCommand cmd = new SqlCommand("Select * from KomacUSer Where UserID = " + CurrentID , con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataGridView1.DataSource = dt;
            //string query = ("Select * FROM KomacUSer WHERE UserID = '" + txtID.Text.Trim() + "' and UserPassword = '" + txtPW.Text.Trim() + "'");
        }
    }
}

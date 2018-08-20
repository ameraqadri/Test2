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

namespace LoginForm
{
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Experiment\LoginForm\LoginForm\Database1.mdf;Integrated Security=True");

        public Form3()
        {
            InitializeComponent();
        }

        SqlDataAdapter da;
        DataSet ds;

        private void button1_Click(object sender, EventArgs e)
        {



             da = new SqlDataAdapter("Select * from Student", con);
           ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cmd = new SqlCommandBuilder(da);

            da.Update(ds);
            

        }
    }
}

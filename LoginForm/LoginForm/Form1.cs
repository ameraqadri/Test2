using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private void username_cb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pwd_tx.UseSystemPasswordChar = true;
        }

        private void pwd_tx_KeyPress(object sender, KeyPressEventArgs e)
        {
             int d = Convert.ToInt32(e.KeyChar);
             if (d == 13)
             {
                 MessageBox.Show("Enter the Password !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                
             }
           
        }
    }
}

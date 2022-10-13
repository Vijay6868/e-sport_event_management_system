using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace week2
{
    public partial class LoginPage : Form
    {   
        mainForm frmMain;
        public LoginPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(UserName.Text=="ISCG6421" && Password.Text == "gui")
            {
                
                
                /*if(frmMain == null)
                {
                    frmMain = new mainForm();
                    frmMain.Show();
                    Close();
                }*/
                Close();
                
            }
            else
            {
                MessageBox.Show("Wrong credentials !!");
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}

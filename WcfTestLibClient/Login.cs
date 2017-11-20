using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WcfTestLibClient
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxDomain.Text) && !string.IsNullOrEmpty(tbxUser.Text) && !string.IsNullOrEmpty(maskTbxPassword.Text))
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Hide();                
            }
        }

        public string Domain
        {
            get
            {
                return tbxDomain.Text;
            }
        }

        public string User
        {
            get
            {
                return tbxUser.Text;
            }
        }

        public string Password
        {
            get
            {
                return maskTbxPassword.Text;
            }
        }
    }
}

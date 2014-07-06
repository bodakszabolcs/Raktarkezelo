using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using Raktarkezelo.User;


namespace Raktarkezelo
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }
        Raktarkezelo main = new Raktarkezelo();
           
        private void Login_Load(object sender, EventArgs e)
        {
             main.Visible = false;
            
           
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            if (superValidator1.Validate())
            {

                this.Hide();
                main.Visible = true;
            }

        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customValidator1_ValidateValue(object sender, DevComponents.DotNetBar.Validator.ValidateValueEventArgs e)
        {
            Users u = new Users();

           e.IsValid = u.userLogin(tb_userName.Text, tb_pwd.Text);
        }
    }
}

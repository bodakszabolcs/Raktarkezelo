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
using Raktarkezelo.DataBase;
using Raktarkezelo.Security;

namespace Raktarkezelo.User
{
    public partial class UserSettings : Office2007Form
    {
        public UserSettings()
        {
            InitializeComponent();
        }

        private void UserSettings_Load(object sender, EventArgs e)
        {

        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            if (superValidator1.Validate())
            {
                MySQLDB conn = new MySQLDB();
                CryptoLib cl = new CryptoLib();
                conn.Insert("Insert into users values('','" + textBoxX1.Text + "','" + cl.MD5Hash(textBoxX2.Text) + "')");
            }
            
        }
    }
}

using DevComponents.DotNetBar.Metro;
using Raktarkezelo.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raktarkezelo.Dictionerys
{
    public partial class DictioneryEdit : MetroForm
    {
        public string id;
        MySQLDB db = new MySQLDB();

        public DictioneryEdit()
        {
            InitializeComponent();
        }

       

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (comboBoxEx1.Enabled == true)
            {
                db.OpenConnection();
                db.Insert("Insert into szotar values('','"+comboBoxEx1.Text+"','"+textBoxX1.Text+"',NOW(),'admin','0')");

            }
            else
            {
                db.OpenConnection();
                db.Update("Update szotar set szt_name='" + textBoxX1.Text + "' where id='" + id + "'");
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

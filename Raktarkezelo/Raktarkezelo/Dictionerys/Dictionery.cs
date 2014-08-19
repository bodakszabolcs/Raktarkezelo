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

namespace Raktarkezelo
{
    public partial class Dictionery : MetroForm
    {
        private System.Data.DataTable categoryTable;

        private MySQLDB db;
        public Dictionery()
        {
            InitializeComponent();
            db = new MySQLDB();
            db.OpenConnection();
            categoryTable = db.selectTable("SELECT DISTINCT( szt_cat) from szotar");

            for (int i = 0; i <= categoryTable.Rows.Count; i++)
            {

                comboBoxEx1.Items.Add(categoryTable.Rows[i][0].ToString());
                i++;

            }

        }



        private void Dictionery_Load(object sender, EventArgs e)
        {
            db.OpenConnection();
            dataGridViewX1.DataSource = db.GetDataGried("SELECT szt_id,szt_cat, szt_name,Date(szt_created) as created, szt_user FROM szotar  where szt_del='0' ");

        }

        private void textBoxX1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataGridViewX1.DataSource = db.GetDataGried("SELECT szt_id,szt_cat, szt_name,Date(szt_created) as created, szt_user FROM szotar  where szt_del='0' and szt_cat Like'%"+comboBoxEx1.Text+"%' and szt_name LIKE '%"+textBoxX1.Text+"%'");

            
            }
        }

        private void comboBoxEx1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataGridViewX1.DataSource = db.GetDataGried("SELECT szt_id,szt_cat, szt_name,Date(szt_created) as created, szt_user FROM szotar  where szt_del='0' and szt_cat Like'%" + comboBoxEx1.Text + "%' and szt_name LIKE '%" + textBoxX1.Text + "%'");


            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Dictionerys.DictioneryEdit dedit = new Dictionerys.DictioneryEdit();
            dedit.id = this.dataGridViewX1.SelectedRows[0].Cells["szt_cat"].Value.ToString();
            for (int i = 0; i < categoryTable.Rows.Count; i++)
            {

                dedit.comboBoxEx1.Items.Add(categoryTable.Rows[i][0].ToString());
                i++;

            }
            dedit.ShowDialog();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Dictionerys.DictioneryEdit dedit = new Dictionerys.DictioneryEdit();
            dedit.id = this.dataGridViewX1.SelectedRows[0].Cells["szt_cat"].Value.ToString();
            dedit.comboBoxEx1.Text = this.dataGridViewX1.SelectedRows[0].Cells["szt_cat"].Value.ToString();
            dedit.comboBoxEx1.Enabled = false;
            dedit.textBoxX1.Text = this.dataGridViewX1.SelectedRows[0].Cells["szt_name"].Value.ToString();
            dedit.ShowDialog();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.SelectedRows[0].Index > -1)
            {
                //tudo ide még kellesz egy ellenőrzés azokra a táblákra amikben szerepel 
                DialogResult res = MessageBox.Show("Biztosan törli a kategóriát?", "Figyelem!", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    MySQLDB db = new MySQLDB();
                    db.OpenConnection();
                    db.Delete("delete  from szotar where szt_id='" + dataGridViewX1.SelectedRows[0].Cells["szt_id"] + "'");
                }
                
            }
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            dataGridViewX1.DataSource = db.GetDataGried("SELECT szt_id,szt_cat, szt_name,Date(szt_created) as created, szt_user FROM szotar  where szt_del='0' and szt_cat Like'%" + comboBoxEx1.Text + "%' and szt_name LIKE '%" + textBoxX1.Text + "%'");
        }

    }
}

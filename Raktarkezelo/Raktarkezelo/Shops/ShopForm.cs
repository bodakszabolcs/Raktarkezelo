using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using Raktarkezelo.DataBase;
using Raktarkezelo.Shops;
using DevComponents.DotNetBar;
    
namespace Raktarkezelo
{
    public partial class ShopForm : MetroForm
    {
        MySQLDB conn = new MySQLDB();
        public ShopForm()
        {
            InitializeComponent();
            
            dg_shop.DataSource = conn.GetDataGried("select shop_id,shop_name,shop_sort_name,shop_cim,shop_telefon from shop");
        }

        private void Shop_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            Raktarkezelo main = new Raktarkezelo();
            main.Show();
            this.Close();

        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            expandablePanel1.Expanded = true;
            buttonX5.Text = "Új";
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            expandablePanel1.Expanded = false;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if (dg_shop.SelectedRows.Count > 0)
            {
                if (dg_shop.SelectedRows[0].Index > -1)
                {
                    expandablePanel1.Expanded = true;
                    buttonX5.Text = "Módosít";
                    textBoxX1.Text = dg_shop.SelectedRows[0].Cells["shop_name"].Value.ToString();
                    textBoxX2.Text = dg_shop.SelectedRows[0].Cells["shop_sort_name"].Value.ToString();
                    textBoxX3.Text = dg_shop.SelectedRows[0].Cells["shop_cim"].Value.ToString();
                    textBoxX4.Text = dg_shop.SelectedRows[0].Cells["shop_telefon"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Kérem válassza ki melyik üzletet szeretné módosítani!");
                }
            }
            else
            {
                MessageBox.Show("Kérem válassza ki melyik üzletet szeretné módosítani!");
            }
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            if (superValidator1.Validate())
            {
                Shop sh;
                if (dg_shop.SelectedRows.Count > 0)
                {
                     sh = new Shop(dg_shop.SelectedRows[0].Cells["shop_id"].Value.ToString(), textBoxX1.Text, textBoxX2.Text, textBoxX3.Text, textBoxX4.Text);
                }
                else
                {
                     sh = new Shop("1", textBoxX1.Text, textBoxX2.Text, textBoxX3.Text, textBoxX4.Text);
                }
                if (buttonX5.Text == "Új")
                {
                    sh.Insert();
                }
                if (buttonX5.Text == "Módosít")
                {
                    sh.Update();
                }
                dg_shop.DataSource = conn.GetDataGried("select shop_id,shop_name,shop_sort_name,shop_cim,shop_telefon from shop");
                expandablePanel1.Expanded = false;
            }
        }

        private void buttonX6_Click_1(object sender, EventArgs e)
        {
            expandablePanel1.Expanded = false;
        }

        
    }
}

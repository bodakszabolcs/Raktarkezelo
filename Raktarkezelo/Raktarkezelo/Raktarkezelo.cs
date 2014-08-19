using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DevComponents.DotNetBar;
using MySql.Data.MySqlClient;
using Raktarkezelo.DataBase;
using Raktarkezelo.User;
using DevComponents.DotNetBar.Metro;
using Raktarkezelo.Dictionerys;


namespace Raktarkezelo
{
    public partial class Raktarkezelo : MetroForm

    {
        MySQLDB conn = new MySQLDB();

        public Raktarkezelo()
        {
            InitializeComponent();
            

            if (conn.OpenConnection() == true)
            {
                dataGridViewX1.DataSource = conn.GetDataGried("select * from shop_phone");
               
                
                //close connection
                conn.CloseConnection();
            }
        }
       


        private void Raktarkezelo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_BOLT.arpadhid' table. You can move, or remove it, as needed.
            dataGridViewX1.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            dataGridViewX1.EnableHeadersVisualStyles = false;
           

        }

        private void Raktarkezelo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       

       

      

        private void buttonX1_Click(object sender, EventArgs e)
        {
            MySQLDB conn = new MySQLDB();

            if (conn.OpenConnection() == true)
            {
                dataGridViewX1.DataSource = conn.GetDataGried("select * from arpadhid_tartozek");
                dataGridViewX1.Columns["tel_eladasi_ar"].DefaultCellStyle.Format = "C";
                dataGridViewX1.Columns["tel_veteli_ar"].DefaultCellStyle.Format = "C";
                dataGridViewX1.Columns["tel_akcios_ar"].DefaultCellStyle.Format = "C";
                //close connection
                conn.CloseConnection();
            }
        }

              private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                string name = dataGridViewX1.SelectedRows[0].Cells["tel_marka"].Value.ToString();
                lb_marka.Text = name;
                label1.Text = "Szín: "+dataGridViewX1.SelectedRows[0].Cells["tel_szin"].Value.ToString();
                label3.Text = "Állapot: "+dataGridViewX1.SelectedRows[0].Cells["tel_allapot"].Value.ToString();
                label2.Text = "Függőség: " + dataGridViewX1.SelectedRows[0].Cells["tel_fuggo"].Value.ToString();
                label4.Text = "Vételi ár: " + dataGridViewX1.SelectedRows[0].Cells["tel_veteli_ar"].Value.ToString();
                label5.Text = "Eladási ár: " + dataGridViewX1.SelectedRows[0].Cells["tel_eladasi_ar"].Value.ToString();
                label6.Text = "Bejött: " + dataGridViewX1.SelectedRows[0].Cells["tel_vetel"].Value.ToString();
                label7.Text = "Eladva: " + dataGridViewX1.SelectedRows[0].Cells["tel_eladas"].Value.ToString();
                Thread thread = new Thread(new ThreadStart(WorkThreadFunction));
                 if (thread.ThreadState == ThreadState.Running)
                {
                    thread.Abort();
                    return;
                }
                 thread.Start();
        
              
               
                
            }
        }

        private void buttonX1_Click_1(object sender, EventArgs e)
        {
            try
            {
                XElement root = XElement.Load("adatbazis.xml");
                IEnumerable<XElement> address =
                    from el in root.Elements("telefon")
                    where el.Element("name").Value == lb_marka.Text
                    select el;
                dataGridViewX2.Rows.Clear();
                foreach (XElement el in address)
                {
                    foreach (XElement i in el.Elements())
                    {
                        dataGridViewX2.Rows.Add(new object[] { i.Name, i.Value });


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        public void WorkThreadFunction()
        {
            try
            {
                pictureBox1.ImageLocation = "http://mobiladasvetel.hu/sites/default/files/styles/uc_product_full/public/" + lb_marka.Text + ".png";
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserSettings us = new UserSettings();
            us.Show();
        }

        private void dataGridViewX1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewX1.Columns["tel_eladasi_ar"].DefaultCellStyle.Format = "C0";
            dataGridViewX1.Columns["tel_veteli_ar"].DefaultCellStyle.Format = "C0";
            dataGridViewX1.Columns["tel_akcios_ar"].DefaultCellStyle.Format = "C0";
        }

        private void textBoxItem1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxItem1.Text.Length == 0)
            {
                if (conn.OpenConnection() == true)
                {
                    dataGridViewX1.DataSource = conn.GetDataGried("select * from shop_phone");

                    //close connection
                    conn.CloseConnection();
                }
            }
            
        }

        private void textBoxItem1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                if (conn.OpenConnection() == true)
                {
                    dataGridViewX1.DataSource = conn.GetDataGried("select * from shop_phone where tel_marka LIKE'%" + textBoxItem1.Text + "%'");

                    //close connection
                    conn.CloseConnection();
                }
            }
        }

        private void buttonItem4_Click(object sender, EventArgs e)
        {
            if (conn.OpenConnection() == true)
            {
                dataGridViewX1.DataSource = conn.GetDataGried("select * from shop_phone where tel_marka LIKE'%" + textBoxItem1.Text + "%'");

                //close connection
                conn.CloseConnection();
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Add_product adprod = new Add_product();
            adprod.ShowDialog();
        }

              
        private void szótárToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Dictionery ds = new Dictionery();
            ds.ShowDialog();
        }

        private void dataGridViewX1_Scroll(object sender, ScrollEventArgs e)
        {

        }

      

        

        

       
          

       
    }
}

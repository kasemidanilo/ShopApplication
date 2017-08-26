using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApplication
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {

        DatabaseConnection conn = new DatabaseConnection();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'offlineShopDataSet3.ARTIKULLI' table. You can move, or remove it, as needed.
            this.aRTIKULLITableAdapter.Fill(this.offlineShopDataSet3.ARTIKULLI);
            // TODO: This line of code loads data into the 'offlineShopDataSet2.KATEGORIA' table. You can move, or remove it, as needed.
            this.kATEGORIATableAdapter.Fill(this.offlineShopDataSet2.KATEGORIA);
            // TODO: This line of code loads data into the 'offlineShopDataSet1.ARTIKULLI' table. You can move, or remove it, as needed.

            searchBox();
            searchKlient();

            //fillListView();


        }

        //private void fillListView() {

        //    SqlConnection conn = new SqlConnection();
        //    conn.ConnectionString = @"Data Source=DANILO-PC\SQLEXPRESS;Initial Catalog=OfflineShop;Integrated Security=True";

        //    conn.Open();
        //    SqlCommand cmd = new SqlCommand("GetArtikuj", conn);

        //    cmd.CommandType = CommandType.StoredProcedure;

        //    SqlDataReader reader = cmd.ExecuteReader();

           
        //    while (reader.Read ()) {

        //        ListViewItem item = new ListViewItem(reader["Artikulli"].ToString());
        //        item.SubItems.Add(reader["ID"].ToString());
        //        listView1.Items.Add(item);

            
              
        //    }


        //    conn.Close();


                  
        //}

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_Click(object sender, EventArgs e)
        {
          listBox2.DataSource =  conn.GetArtikujt(listBox1.SelectedValue.ToString());
            listBox2.DisplayMember = "Artikulli";
            listBox2.ValueMember = "ID";                       
        }

        private void listBox2_Click(object sender, EventArgs e)
        {
            bool test = false;
            int sum = 0;
           DataTable tb =  conn.getArtikulliCmimi(listBox2.SelectedValue.ToString());
         
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                object val1 = row.Cells[0].Value;

                if (val1 != null && val1.ToString() == listBox2.SelectedValue.ToString())
                {
                    int sasia = Convert.ToInt32(row.Cells[3].Value) + 1;

                    row.Cells[3].Value = sasia;
                    row.Cells[4].Value = sasia * Convert.ToInt32(tb.Rows[0][1].ToString());
                    test = true;
                    break;
                }
            }

            if (test == false)
            {

                int sasia = 1;

                dataGridView1.Rows.Add(Convert.ToInt32(listBox2.SelectedValue.ToString()), tb.Rows[0][0].ToString(), tb.Rows[0][1].ToString(), sasia, sasia * Convert.ToInt32(tb.Rows[0][1].ToString()));

            }


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                          
                sum += Convert.ToInt32(row.Cells[4].Value);
            }
            metroLabel2.Text =  String.Format("{0:C}", sum);
          
            }

        
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int sum = 0;
            dataGridView1.CurrentRow.Cells[4].Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value) * Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                sum += Convert.ToInt32(row.Cells[4].Value);
            }
            metroLabel2.Text = String.Format("{0:C}", sum);


        }

        int rowIndex;
        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                this.dataGridView1.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.dataGridView1.CurrentCell = this.dataGridView1.Rows[e.RowIndex].Cells[1];
                this.contextMenuStrip1.Show(this.dataGridView1, e.Location);
                contextMenuStrip1.Show(Cursor.Position);



            }
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            if (!this.dataGridView1.Rows[this.rowIndex].IsNewRow)
            {
                this.dataGridView1.Rows.RemoveAt(this.rowIndex);
                int sum = 0;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    sum += Convert.ToInt32(row.Cells[4].Value);
                }
                metroLabel2.Text = String.Format("{0:C}", sum);




            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
             
        }



        // dataGridView1.CurrentRow.Cells[4].Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value) * Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);


        private void searchKlient() {

            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = @"Data Source=DANILO-PC\SQLEXPRESS;Initial Catalog=OfflineShop;Integrated Security=True";


            SqlCommand cmd = new SqlCommand("SELECT EmerMbimer FROM KLIENTI  ", conn);
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            System.Windows.Forms.AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();

            while (reader.Read())
            {


                MyCollection.Add(reader.GetString(0));
               

            }

            metroTextBox1.AutoCompleteCustomSource = MyCollection;
            listBox2.DataSource = null;
            conn.Close();




        }
        private void searchBox()
        {

            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = @"Data Source=DANILO-PC\SQLEXPRESS;Initial Catalog=OfflineShop;Integrated Security=True";


            SqlCommand cmd = new SqlCommand("SELECT Artikulli, ID, Cmimi FROM ARTIKULLI  ", conn);
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            System.Windows.Forms.AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();

            while (reader.Read())
            {


                MyCollection.Add(reader.GetString(0));

            }

            Kerko.AutoCompleteCustomSource = MyCollection;
           
            conn.Close();

        }

        private void metroButton10_Click(object sender, EventArgs e)
        {



             bool test = false;
            int sum = 0;
            DataTable tb = conn.getIDCmimiFromArtikulli(Kerko.Text);
         
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                object val1 = row.Cells[1].Value;

                if (val1 != null && val1.ToString() == Kerko.Text  )
                {
                    int sasia = Convert.ToInt32(row.Cells[3].Value) + 1;

                    row.Cells[3].Value = sasia;
                    row.Cells[4].Value = sasia * Convert.ToInt32(tb.Rows[0][1].ToString());
                    test = true;
                    break;
                }
            }

            if (test == false)
            {

                int sasia = 1;

                dataGridView1.Rows.Add(Convert.ToInt32(tb.Rows[0][0].ToString()), Kerko.Text, tb.Rows[0][1].ToString(), sasia, sasia * Convert.ToInt32(tb.Rows[0][1].ToString()));

            }


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                          
                sum += Convert.ToInt32(row.Cells[4].Value);
            }
            metroLabel2.Text =  String.Format("{0:C}", sum);
          

        }

        private void metroButton11_Click(object sender, EventArgs e)
        {

        }

        //private void listView1_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show(listView1.SelectedItems[0].SubItems[1].Text);
        //}
    }
}

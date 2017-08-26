using Microsoft.AnalysisServices;
using ShopApplication.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ShopApplication
{
    public partial class Form2 : Form
    {

        DatabaseConnection conn = new DatabaseConnection();
        int IDsporteli;
        string sporteli;
        string name;
        string surname;
        int perdoruesID;

        public Form2(int IDsporteli, string sporteli, string name, string surname, int perdoruesID)
        {
            InitializeComponent();
            FillKategoria();
            searchBox();
            fillArtikujtFull();
            searchKlient();

            this.IDsporteli = IDsporteli;
            this.sporteli = sporteli;
            this.name = name;
            this.surname = surname;
            this.perdoruesID = perdoruesID;

            perdoruesilbl.Text = name + " " + surname;
            sportelilbl.Text = "Sporteli: "+sporteli;
            sporteliID.Text = IDsporteli+"";
        }

        private void fillArtikujtFull() {

            groupBox1.Controls.Clear();
            List<Button> bt = new List<Button>();
         
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DANILO-PC\SQLEXPRESS;Initial Catalog=OfflineShop;Integrated Security=True";

            conn.Open();
            SqlCommand cmd = new SqlCommand("GetArtikuj", conn);
            
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = cmd.ExecuteReader();
            int l = 0;
            int h = 90;
            int i = 0;
            int f = 10;
            int zz = 43;
            while (reader.Read())
            {
                Button a = new Button()
                {
                    Text = reader["Artikulli"].ToString(),
                    Name = reader["ID"].ToString(),
                    Size = new System.Drawing.Size(176, 100),
                    UseVisualStyleBackColor = true,
                    BackgroundImage = Image.FromFile("C:/Users/Danilo/documents/visual studio 2015/Projects/ShopApplication/ShopApplication/Photo/" + reader["Foto"].ToString()),
                    ForeColor = System.Drawing.Color.White,
                    BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch,
                    Location = new System.Drawing.Point(l = l + zz, h)


                };



                a.Click += new System.EventHandler(this.button2_Click);

                f = f + 188;
                i++;
                groupBox1.Controls.Add(a);


                if (i == 1)
                {

                    zz = 178;

                }
                if (i == 4)
                {
                    i = 0;
                    zz = 43;
                    l = 0;
                    h = h + 102;

                }
            }

            conn.Close();
        }

        private void FillKategoria() {

            List<Button> bt = new List<Button>();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DANILO-PC\SQLEXPRESS;Initial Catalog=OfflineShop;Integrated Security=True";

            conn.Open();
            SqlCommand cmd = new SqlCommand("GetKategoria", conn);
            
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = cmd.ExecuteReader();

            int l = 0;
            int h = 90;
            int i = 0;
            int f = 10;
            int zz = 43;
            while (reader.Read())
            {
                Button a = new Button()
                {
                    Text = reader["Kategoria"].ToString(),
                    Name = reader["ID"].ToString(),
                    Size = new System.Drawing.Size(176, 100),                       
                    UseVisualStyleBackColor = true,
                    BackgroundImage = Image.FromFile("C:/Users/Danilo/documents/visual studio 2015/Projects/ShopApplication/ShopApplication/Photo/" + reader["Foto"].ToString()),
                    ForeColor = System.Drawing.Color.White,
                    BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch,
                    Location = new System.Drawing.Point(l = l + zz, h)
                    

            };
             
                a.Click += new System.EventHandler(this.button1_Click);
               
                f = f + 188;
                i++;
                groupBox2.Controls.Add(a);


                if (i ==1) {

                    zz = 178;

                }
                if (i == 4)
                {
                    i = 0;
                    zz = 43;
                    l = 0;
                    h = h + 102;

                }

            }

            conn.Close();
        }




        private void FillArtikujt(int kategoriID) {

            groupBox1.Controls.Clear();

            List<Button> bt = new List<Button>();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DANILO-PC\SQLEXPRESS;Initial Catalog=OfflineShop;Integrated Security=True";

            conn.Open();
            SqlCommand cmd = new SqlCommand("GetArtikujWithKategoriId", conn);
            cmd.Parameters.Add("kategoria", kategoriID);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = cmd.ExecuteReader();

            int l = 0;
            int h = 100;
            int i = 0;
            while (reader.Read())
            {
                Button a = new Button()
                {
                    Text = reader["Artikulli"].ToString(),
                    Name = reader["ID"].ToString(),
                    Size = new System.Drawing.Size(176, 100),
                    Location = new System.Drawing.Point(l = l + 178, h ),
                    UseVisualStyleBackColor = true,
                    BackgroundImage = Image.FromFile("C:/Users/Danilo/documents/visual studio 2015/Projects/ShopApplication/ShopApplication/Photo/"+ reader["Foto"].ToString()),
                    ForeColor = System.Drawing.Color.White,
                    BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch,
                
                };
                a.Click += new System.EventHandler(this.button2_Click);

                i++;

                groupBox1.Controls.Add(a);
             
                if (i == 3)
                {
                    i = 0;

                    l = 0;
                    h = h + 102;

                }

            }

           

            conn.Close();

                           
        }



     

        //private void fillListView()
        //{

        //    SqlConnection conn = new SqlConnection();
        //    conn.ConnectionString = @"Data Source=DANILO-PC\SQLEXPRESS;Initial Catalog=OfflineShop;Integrated Security=True";

        //    conn.Open();
        //    SqlCommand cmd = new SqlCommand("GetArtikuj", conn);

        //    cmd.CommandType = CommandType.StoredProcedure;

        //    SqlDataReader reader = cmd.ExecuteReader();


        //    while (reader.Read())
        //    {               
        //        ListViewItem item = new ListViewItem( reader["Artikulli"].ToString());
        //        item.SubItems.Add(reader["ID"].ToString());
        //        listView1.Items.Add(item);
        //    }
        //    conn.Close();

        //}

        private void button1_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            FillArtikujt(Convert.ToInt16(bt.Name));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;



            bool test = false;
            int sum = 0;
            DataTable tb = conn.getArtikulliCmimi(bt.Name);

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                object val1 = row.Cells[0].Value;

                if (val1 != null && val1.ToString() == bt.Name)
                {
                    int sasia = Convert.ToInt32(row.Cells[3].Value) + 1;

                    row.Cells[3].Value = sasia;
                    row.Cells[5].Value = sasia * Convert.ToInt32(tb.Rows[0][1].ToString());
                    test = true;
                    break;
                }
            }

            if (test == false)
            {

                int sasia = 1;

                dataGridView1.Rows.Add(Convert.ToInt32(bt.Name), tb.Rows[0][0].ToString(), tb.Rows[0][1].ToString(), sasia, tb.Rows[0][2].ToString(), sasia * Convert.ToInt32(tb.Rows[0][1].ToString()));

            }


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                sum += Convert.ToInt32(row.Cells[5].Value);
            }
            label3.Text = String.Format("{0:C}", sum);

        }



        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int sum = 0;
            dataGridView1.CurrentRow.Cells[5].Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value) * Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                sum += Convert.ToInt32(row.Cells[5].Value);
            }
            label3.Text = String.Format("{0:C}", sum);


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


            textBox1.AutoCompleteCustomSource = MyCollection;

            conn.Close();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            fillArtikujtFull();


     

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

                    sum += Convert.ToInt32(row.Cells[5].Value);
                }
                label3.Text = String.Format("{0:C}", sum);

            }
        }


        private void metroButton2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            int sum = 0;
            label3.Text = String.Format("{0:C}", sum);
        }


        private void searchKlient()
        {

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

            textBox2.AutoCompleteCustomSource = MyCollection;
           
            conn.Close();




        }


        private void printoFaturen(int fletedaljeId) {

            FleteDaljePrint flPrint = new FleteDaljePrint();
            DataTable tb = conn.GETFleteDalje(fletedaljeId);

            flPrint.SetParameterValue("Nr", tb.Rows[0][0].ToString());

            flPrint.SetParameterValue("shitesi", tb.Rows[0][2].ToString() +" "+ tb.Rows[0][3].ToString());

            flPrint.SetParameterValue("Sporteli", tb.Rows[0][1].ToString());
      
            flPrint.SetParameterValue("Data", tb.Rows[0][4].ToString());
            flPrint.SetParameterValue("@id", fletedaljeId);

            var dialog = new PrintDialog();

            CrRep cs = new CrRep();

            cs.crystalReportViewer1.ReportSource = flPrint;

            flPrint.PrintOptions.PrinterName = dialog.PrinterSettings.PrinterName;
            flPrint.PrintToPrinter(1, false, 0, 0);
            cs.Show();



        }

        private void button5_Click(object sender, EventArgs e)
        {


            bool test = false;
            int sum = 0;
            DataTable tb = conn.getIDCmimiFromArtikulli(textBox1.Text);

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                object val1 = row.Cells[1].Value;

                if (val1 != null && val1.ToString() == textBox1.Text)
                {
                    int sasia = Convert.ToInt32(row.Cells[3].Value) + 1;

                    row.Cells[3].Value = sasia;
                    row.Cells[5].Value = sasia * Convert.ToInt32(tb.Rows[0][1].ToString());
                    test = true;
                    break;
                }
            }

            if (test == false)
            {

                int sasia = 1;

                dataGridView1.Rows.Add(Convert.ToInt32(tb.Rows[0][0].ToString()), textBox1.Text, tb.Rows[0][1].ToString(), sasia, tb.Rows[0][2].ToString(), sasia * Convert.ToInt32(tb.Rows[0][1].ToString()));

            }


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                sum += Convert.ToInt32(row.Cells[5].Value);
            }
            label3.Text = String.Format("{0:C}", sum);


        }

        private void shtoKategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modifikoPerdoruesinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void raportMujorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listaEArtikujveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            //int fletedaljeID = conn.InsertFleteDalje(conn.GetIdKlienti(textBox2.Text), Convert.ToInt16(sporteliID.Text), Convert.ToInt16(perdoruesiID.Text), DateTime.Now.ToString("M/d/yyyy"), 1);


            //    foreach (DataGridViewRow row in dataGridView1.Rows)
            //    {
            //        if (row.Cells[0].Value != null && row.Cells[2].Value != null)
            //        {
            //            conn.InsertFletehyrjeArtikull(Convert.ToInt32(row.Cells[0].Value), fletehyrjeID, Convert.ToInt32(row.Cells[2].Value));
            //            conn.InsertOrUpdateMagazinaGjendje(Convert.ToInt32(cmbMagazina.SelectedValue.ToString()), Convert.ToInt32(row.Cells[0].Value), Convert.ToInt32(row.Cells[2].Value));
            //        }

            //    }

            //    dataGridView1.Rows.Clear();


            //    DialogResult dr = MessageBox.Show("Flete Hyrja u ruajt me sukses. Deshironi te printoni Flete Hyrjen?",
            //          "", MessageBoxButtons.YesNo);
            //    switch (dr)
            //    {
            //        case DialogResult.Yes:
            //            printFleteHyrje(fletehyrjeID);
            //            //printGETFletehyrje_Artikull(fletehyrjeID);
            //            break;
            //        case DialogResult.No: break;
            //    }
            //}
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            int magazina = conn.GetMagazinaFromSporteli(Convert.ToInt16(sporteliID.Text));
            int fletedaljeID = conn.InsertFleteDalje(conn.GetIdKlienti(textBox2.Text), Convert.ToInt16(sporteliID.Text), perdoruesID, DateTime.Now.ToString("M/d/yyyy"), 1);
            int sasia;
            int test = 1;

           foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[3].Value != null)
                {
                    sasia = conn.CHECKMagazinaGjendje(magazina, Convert.ToInt16( row.Cells[0].Value));
                    if (sasia - Convert.ToInt32(row.Cells[3].Value) < 5 && sasia != 0 && sasia - Convert.ToInt32(row.Cells[3].Value) > 0)
                    {
                        int cnt = sasia - Convert.ToInt32(row.Cells[3].Value);
                        MessageBox.Show("Kane mbetur vetem " + cnt + " " + row.Cells[4].Value + " " + row.Cells[1].Value, " ne magazine", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.InsertFleteDalje_Artikull(Convert.ToInt32(row.Cells[0].Value), fletedaljeID, Convert.ToInt32(row.Cells[3].Value));
                        int a = conn.RemoveOrUpdateMagazinaGjendje(magazina, Convert.ToInt32(row.Cells[0].Value), Convert.ToInt32(row.Cells[3].Value));
                       
                    }
                    else if (sasia - Convert.ToInt32(row.Cells[3].Value) == 0)
                    {

                        MessageBox.Show("Ne magazine kane mbaruar  " + row.Cells[1].Value, " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conn.InsertFleteDalje_Artikull(Convert.ToInt32(row.Cells[0].Value), fletedaljeID, Convert.ToInt32(row.Cells[3].Value));
                        int a = conn.RemoveOrUpdateMagazinaGjendje(magazina, Convert.ToInt32(row.Cells[0].Value), Convert.ToInt32(row.Cells[3].Value));
                    
                       
                    }

                    else if (sasia - Convert.ToInt32(row.Cells[3].Value) < 0)
                    {
                       
                        DialogResult dr = MessageBox.Show("Deshiron ta anullosh faturen?  "," Ne magazine nuk ka sasi te mjaftueshme te " + row.Cells[1].Value, MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                        if (dr == DialogResult.Yes)
                        {
                         

                            row.Cells[3].Value = sasia;
                                 

                            for (int i = (row.Index -1); i >= 0; i--)
                            {
                               
                                conn.InsertOrUpdateMagazinaGjendje(magazina, Convert.ToInt16(dataGridView1.Rows[i].Cells[0].Value), Convert.ToInt16(dataGridView1.Rows[i].Cells[3].Value));

                                conn.CancelFleteDalje(fletedaljeID);
                                test = 0;
                            }
                            break;
                        }
                        else
                        {
                            continue;
                         
                        }


                    }
                   else {
                        conn.InsertFleteDalje_Artikull(Convert.ToInt32(row.Cells[0].Value), fletedaljeID, Convert.ToInt32(row.Cells[3].Value));
                        int a = conn.RemoveOrUpdateMagazinaGjendje(magazina, Convert.ToInt32(row.Cells[0].Value), Convert.ToInt32(row.Cells[3].Value));
                        
                        
                    }


                }
                
            }

            if (test == 1 ) {
                printoFaturen(fletedaljeID);
                dataGridView1.Rows.Clear();
            }
        }

        private void perdoruesilbl_Click(object sender, EventArgs e)
        {

        }

        private void dilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login lg = new Login();
            lg.Show();
        }

        private void raportDitorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            XhiroDitore flPrint = new XhiroDitore();
           
              flPrint.SetParameterValue("@idPerdorues", perdoruesID);
            flPrint.SetParameterValue("@_data", DateTime.Now.ToString("yyyy-M-d"));

            var dialog = new PrintDialog();

            CrRep cs = new CrRep();

            cs.crystalReportViewer1.ReportSource = flPrint;

            flPrint.PrintOptions.PrinterName = dialog.PrinterSettings.PrinterName;
            flPrint.PrintToPrinter(1, false, 0, 0);
            cs.Show();





        }
    }
}

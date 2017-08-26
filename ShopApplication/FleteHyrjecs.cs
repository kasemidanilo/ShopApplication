using CrystalDecisions.Shared;
using System;
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
    public partial class FleteHyrjecs : Form
    {
        string menaxheri;
        int idMenaxheri;

        DatabaseConnection conn;

        public FleteHyrjecs(string menaxheri, int idMenaxheri)
        {
            this.menaxheri = menaxheri;
            this.idMenaxheri = idMenaxheri;

           

            InitializeComponent();
            conn = new DatabaseConnection();

            label3.Text = DateTime.Now.ToString("M/d/yyyy");

        }


      


        private void FleteHyrjecs_Load(object sender, EventArgs e)
        {

            menaxherilbl.Text = menaxheri;
            idMenaxherilbl.Text = idMenaxheri + "";
            // TODO: This line of code loads data into the 'database.ARTIKULLI' table. You can move, or remove it, as needed.
            this.aRTIKULLITableAdapter.Fill(this.database.ARTIKULLI);
            // TODO: This line of code loads data into the 'database.MAGAZINA' table. You can move, or remove it, as needed.
            this.mAGAZINATableAdapter.Fill(this.database.MAGAZINA);
            // TODO: This line of code loads data into the 'database.FURNITORI' table. You can move, or remove it, as needed.
            this.fURNITORITableAdapter.Fill(this.database.FURNITORI);

       
        }

        private void button5_Click(object sender, EventArgs e)
        {

          
           
        }

        private void printGETFletehyrje_Artikull(int fletehyrjeID) {
            FleteHyrjePrint flPrint = new FleteHyrjePrint();
            DataTable tb = conn.GETFletehyrje_Artikull(fletehyrjeID);
            DataSet ds = new DataSet();
          
            flPrint.SetDataSource(tb);

            CrRep cs = new CrRep();

            cs.crystalReportViewer1.ReportSource = flPrint;


            cs.Show();

        }
        private void printFleteHyrje(int fletehyrjeID) {
            FleteHyrjePrint flPrint = new FleteHyrjePrint();
            DataTable tb = conn.GETFletehyrje(fletehyrjeID);

            flPrint.SetParameterValue("FletehyrjeID", tb.Rows[0][0].ToString());

            flPrint.SetParameterValue("Furnitori", tb.Rows[0][2].ToString());

            flPrint.SetParameterValue("Magazina", tb.Rows[0][3].ToString());

            flPrint.SetParameterValue("Menaxheri", tb.Rows[0][4].ToString() +" "+ tb.Rows[0][4].ToString());

            flPrint.SetParameterValue("Data", tb.Rows[0][1].ToString());
            flPrint.SetParameterValue("@id", fletehyrjeID);

            CrRep cs = new CrRep();

            cs.crystalReportViewer1.ReportSource = flPrint;


            cs.Show();
        }


        private void GetArtikullFleteHyrje(int id) {

           
          
           



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
                
        
               
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox3.Text != null)

            {
                bool test = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    object val1 = row.Cells[0].Value;

                    if (val1 != null && val1.ToString() == cmbArtikulli.SelectedValue.ToString())
                    {

                        test = true;
                        break;
                    }
                }

                if (test == false)
                {
                    dataGridView1.Rows.Add(cmbArtikulli.SelectedValue.ToString(), 4 , textBox3.Text);
                }
            }

            else
            {

                MessageBox.Show("Ju lutem vendosni sasine e produktit.");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //try
            //{

                int fletehyrjeID = conn.InsertFleteHyrje(Convert.ToInt16(cmbFurnitori.SelectedValue.ToString()), Convert.ToInt16(cmbMagazina.SelectedValue.ToString()), Convert.ToInt16(idMenaxherilbl.Text), DateTime.Now.ToString("M/d/yyyy"));


                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[2].Value != null)
                    {
                        conn.InsertFletehyrjeArtikull(Convert.ToInt32(row.Cells[0].Value), fletehyrjeID, Convert.ToInt32(row.Cells[2].Value));
                        conn.InsertOrUpdateMagazinaGjendje(Convert.ToInt32(cmbMagazina.SelectedValue.ToString()), Convert.ToInt32(row.Cells[0].Value), Convert.ToInt32(row.Cells[2].Value));
                    }

                }

                dataGridView1.Rows.Clear();

               
                DialogResult dr = MessageBox.Show("Flete Hyrja u ruajt me sukses. Deshironi te printoni Flete Hyrjen?",
                      "", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        printFleteHyrje(fletehyrjeID);
                    //printGETFletehyrje_Artikull(fletehyrjeID);
                        break;
                    case DialogResult.No: break;
                }
                //MessageBox.Show("Fletehyrja u ruajt me sukses!");

        //}


            //catch (Exception c) {


            //    MessageBox.Show("Fletehyrja nuk u ruajt!");

            //}
}

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbArtikulli_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

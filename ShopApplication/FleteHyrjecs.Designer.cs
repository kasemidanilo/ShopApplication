namespace ShopApplication
{
    partial class FleteHyrjecs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FleteHyrjecs));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMagazina = new System.Windows.Forms.ComboBox();
            this.mAGAZINABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database = new ShopApplication.Database();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbArtikulli = new System.Windows.Forms.ComboBox();
            this.aRTIKULLIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbFurnitori = new System.Windows.Forms.ComboBox();
            this.fURNITORIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artikulli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menaxherilbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.fURNITORITableAdapter = new ShopApplication.DatabaseTableAdapters.FURNITORITableAdapter();
            this.mAGAZINATableAdapter = new ShopApplication.DatabaseTableAdapters.MAGAZINATableAdapter();
            this.aRTIKULLITableAdapter = new ShopApplication.DatabaseTableAdapters.ARTIKULLITableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fshiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idMenaxherilbl = new System.Windows.Forms.Label();
            this.offlineShopDataSet4 = new ShopApplication.OfflineShopDataSet4();
            this.gETFletehyrjeArtikullBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gETFletehyrje_ArtikullTableAdapter = new ShopApplication.OfflineShopDataSet4TableAdapters.GETFletehyrje_ArtikullTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mAGAZINABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRTIKULLIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fURNITORIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offlineShopDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gETFletehyrjeArtikullBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbMagazina);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cmbArtikulli);
            this.groupBox1.Controls.Add(this.cmbFurnitori);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 627);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Flete Hyrje";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "label1";
            // 
            // cmbMagazina
            // 
            this.cmbMagazina.DataSource = this.mAGAZINABindingSource;
            this.cmbMagazina.DisplayMember = "Magazina";
            this.cmbMagazina.FormattingEnabled = true;
            this.cmbMagazina.Location = new System.Drawing.Point(166, 49);
            this.cmbMagazina.Name = "cmbMagazina";
            this.cmbMagazina.Size = new System.Drawing.Size(226, 24);
            this.cmbMagazina.TabIndex = 34;
            this.cmbMagazina.ValueMember = "ID";
            // 
            // mAGAZINABindingSource
            // 
            this.mAGAZINABindingSource.DataMember = "MAGAZINA";
            this.mAGAZINABindingSource.DataSource = this.database;
            // 
            // database
            // 
            this.database.DataSetName = "Database";
            this.database.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ShopApplication.Properties.Resources.add;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(410, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 38);
            this.button1.TabIndex = 33;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbArtikulli
            // 
            this.cmbArtikulli.DataSource = this.aRTIKULLIBindingSource;
            this.cmbArtikulli.DisplayMember = "Artikulli";
            this.cmbArtikulli.FormattingEnabled = true;
            this.cmbArtikulli.Location = new System.Drawing.Point(166, 131);
            this.cmbArtikulli.Name = "cmbArtikulli";
            this.cmbArtikulli.Size = new System.Drawing.Size(226, 24);
            this.cmbArtikulli.TabIndex = 29;
            this.cmbArtikulli.ValueMember = "ID";
            this.cmbArtikulli.SelectedIndexChanged += new System.EventHandler(this.cmbArtikulli_SelectedIndexChanged);
            // 
            // aRTIKULLIBindingSource
            // 
            this.aRTIKULLIBindingSource.DataMember = "ARTIKULLI";
            this.aRTIKULLIBindingSource.DataSource = this.database;
            // 
            // cmbFurnitori
            // 
            this.cmbFurnitori.DataSource = this.fURNITORIBindingSource;
            this.cmbFurnitori.DisplayMember = "Furnitori";
            this.cmbFurnitori.FormattingEnabled = true;
            this.cmbFurnitori.Location = new System.Drawing.Point(166, 90);
            this.cmbFurnitori.Name = "cmbFurnitori";
            this.cmbFurnitori.Size = new System.Drawing.Size(226, 24);
            this.cmbFurnitori.TabIndex = 27;
            this.cmbFurnitori.ValueMember = "ID";
            // 
            // fURNITORIBindingSource
            // 
            this.fURNITORIBindingSource.DataMember = "FURNITORI";
            this.fURNITORIBindingSource.DataSource = this.database;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(42, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "Magazina";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(58, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "Furnitori";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(78, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Sasia";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(166, 170);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(226, 22);
            this.textBox3.TabIndex = 19;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(66, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Artikulli";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Artikulli,
            this.Sasia});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(6, 279);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.DefaultCellStyle.NullValue = null;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(503, 342);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseUp);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Artikulli
            // 
            this.Artikulli.HeaderText = "Artikulli";
            this.Artikulli.Name = "Artikulli";
            this.Artikulli.ReadOnly = true;
            this.Artikulli.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Artikulli.Width = 250;
            // 
            // Sasia
            // 
            this.Sasia.HeaderText = "Sasia";
            this.Sasia.Name = "Sasia";
            this.Sasia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Sasia.Width = 250;
            // 
            // menaxherilbl
            // 
            this.menaxherilbl.AutoSize = true;
            this.menaxherilbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menaxherilbl.Location = new System.Drawing.Point(7, 9);
            this.menaxherilbl.Name = "menaxherilbl";
            this.menaxherilbl.Size = new System.Drawing.Size(138, 25);
            this.menaxherilbl.TabIndex = 17;
            this.menaxherilbl.Text = "Danilo Kasemi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(402, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "16.12.1993";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(311, 688);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 36);
            this.button2.TabIndex = 19;
            this.button2.Text = "Shto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(422, 688);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 36);
            this.button3.TabIndex = 20;
            this.button3.Text = "Anullo";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // fURNITORITableAdapter
            // 
            this.fURNITORITableAdapter.ClearBeforeFill = true;
            // 
            // mAGAZINATableAdapter
            // 
            this.mAGAZINATableAdapter.ClearBeforeFill = true;
            // 
            // aRTIKULLITableAdapter
            // 
            this.aRTIKULLITableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fshiToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(110, 30);
            this.contextMenuStrip1.Click += new System.EventHandler(this.contextMenuStrip1_Click);
            // 
            // fshiToolStripMenuItem
            // 
            this.fshiToolStripMenuItem.Name = "fshiToolStripMenuItem";
            this.fshiToolStripMenuItem.Size = new System.Drawing.Size(109, 26);
            this.fshiToolStripMenuItem.Text = "Fshi";
            // 
            // idMenaxherilbl
            // 
            this.idMenaxherilbl.AutoSize = true;
            this.idMenaxherilbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idMenaxherilbl.Location = new System.Drawing.Point(126, 34);
            this.idMenaxherilbl.Name = "idMenaxherilbl";
            this.idMenaxherilbl.Size = new System.Drawing.Size(23, 25);
            this.idMenaxherilbl.TabIndex = 21;
            this.idMenaxherilbl.Text = "1";
            this.idMenaxherilbl.Visible = false;
            // 
            // offlineShopDataSet4
            // 
            this.offlineShopDataSet4.DataSetName = "OfflineShopDataSet4";
            this.offlineShopDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gETFletehyrjeArtikullBindingSource
            // 
            this.gETFletehyrjeArtikullBindingSource.DataMember = "GETFletehyrje_Artikull";
            this.gETFletehyrjeArtikullBindingSource.DataSource = this.offlineShopDataSet4;
            // 
            // gETFletehyrje_ArtikullTableAdapter
            // 
            this.gETFletehyrje_ArtikullTableAdapter.ClearBeforeFill = true;
            // 
            // FleteHyrjecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(539, 736);
            this.Controls.Add(this.idMenaxherilbl);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menaxherilbl);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FleteHyrjecs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FleteHyrjecs";
            this.Load += new System.EventHandler(this.FleteHyrjecs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mAGAZINABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRTIKULLIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fURNITORIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.offlineShopDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gETFletehyrjeArtikullBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artikulli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sasia;
        private System.Windows.Forms.ComboBox cmbArtikulli;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label menaxherilbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbMagazina;
        private System.Windows.Forms.ComboBox cmbFurnitori;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private Database database;
        private System.Windows.Forms.BindingSource fURNITORIBindingSource;
        private DatabaseTableAdapters.FURNITORITableAdapter fURNITORITableAdapter;
        private System.Windows.Forms.BindingSource mAGAZINABindingSource;
        private DatabaseTableAdapters.MAGAZINATableAdapter mAGAZINATableAdapter;
        private System.Windows.Forms.BindingSource aRTIKULLIBindingSource;
        private DatabaseTableAdapters.ARTIKULLITableAdapter aRTIKULLITableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fshiToolStripMenuItem;
        private System.Windows.Forms.Label idMenaxherilbl;
        private OfflineShopDataSet4 offlineShopDataSet4;
        private System.Windows.Forms.BindingSource gETFletehyrjeArtikullBindingSource;
        private OfflineShopDataSet4TableAdapters.GETFletehyrje_ArtikullTableAdapter gETFletehyrje_ArtikullTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}
namespace ShopApplication
{
    partial class Login
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
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.sportelicmb = new System.Windows.Forms.ComboBox();
            this.sPORTELIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database = new ShopApplication.Database();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sPORTELITableAdapter = new ShopApplication.DatabaseTableAdapters.SPORTELITableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sPORTELIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usernametxt
            // 
            this.usernametxt.Location = new System.Drawing.Point(300, 101);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(223, 22);
            this.usernametxt.TabIndex = 0;
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(300, 145);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.PasswordChar = '*';
            this.passwordtxt.Size = new System.Drawing.Size(223, 22);
            this.passwordtxt.TabIndex = 1;
            // 
            // sportelicmb
            // 
            this.sportelicmb.DataSource = this.sPORTELIBindingSource;
            this.sportelicmb.DisplayMember = "Emri";
            this.sportelicmb.FormattingEnabled = true;
            this.sportelicmb.Location = new System.Drawing.Point(300, 193);
            this.sportelicmb.Name = "sportelicmb";
            this.sportelicmb.Size = new System.Drawing.Size(223, 24);
            this.sportelicmb.TabIndex = 2;
            this.sportelicmb.ValueMember = "ID";
            // 
            // sPORTELIBindingSource
            // 
            this.sPORTELIBindingSource.DataMember = "SPORTELI";
            this.sPORTELIBindingSource.DataSource = this.database;
            // 
            // database
            // 
            this.database.DataSetName = "Database";
            this.database.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sporteli";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sign In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ShopApplication.Properties.Resources.shop;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::ShopApplication.Properties.Resources.shop;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 89);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // sPORTELITableAdapter
            // 
            this.sPORTELITableAdapter.ClearBeforeFill = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 338);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sportelicmb);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.usernametxt);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sPORTELIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.ComboBox sportelicmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Database database;
        private System.Windows.Forms.BindingSource sPORTELIBindingSource;
        private DatabaseTableAdapters.SPORTELITableAdapter sPORTELITableAdapter;
    }
}
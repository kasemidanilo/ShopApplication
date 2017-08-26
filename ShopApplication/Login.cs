using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Text;
using System.Security.Cryptography;

namespace ShopApplication
{
    public partial class Login : Form
    {

       public bool loginSuccess = false;

        DatabaseConnection conn = new DatabaseConnection();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)

        {
            // TODO: This line of code loads data into the 'database.SPORTELI' table. You can move, or remove it, as needed.
            this.sPORTELITableAdapter.Fill(this.database.SPORTELI);
            Console.WriteLine(Encrypt("Kasemi"));

        }





        public static string Encrypt(string clearText)
        {
            string EncryptionKey = "abc123";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }



        public static string Decrypt(string cipherText)
        {
            string EncryptionKey = "abc123";
            cipherText = cipherText.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DataTable tb = conn.LoginProc(usernametxt.Text,passwordtxt.Text);
            int roli = Convert.ToInt16(tb.Rows[0][0].ToString());
            string name = tb.Rows[0][1].ToString();
            string surname = tb.Rows[0][2].ToString();
            int perdoruesID = Convert.ToInt16(tb.Rows[0][3].ToString());
            int IDsport = Convert.ToUInt16(sportelicmb.SelectedValue.ToString());
            string sport = sportelicmb.Text;

            Menaxheri mnxh = new Menaxheri(name+" "+surname, perdoruesID);

            Form2 seller = new Form2(IDsport, sport, name, surname, perdoruesID);
            switch (roli)
            {

                case 1:
                    mnxh.Show();
                   
                    this.Hide();
                    break;
                case 3:                 
                    seller.Show();
                 
                    this.Hide();
                    break;


            }

          


        }
    }
}

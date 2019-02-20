using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LenaProject
{
    public partial class girisEkrani : System.Windows.Forms.Form
    {
        public girisEkrani()
        {
            InitializeComponent();
            
        }

      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void btnGiris_Click(object sender, EventArgs e)
        {

            SqlConnection sql = new SqlConnection(@"Data Source=DESKTOP-6VUJ8QA\SQLEXPRESS;Initial Catalog=login;Integrated Security=True");
            String query = "Select * from dbo.loginTable Where username = '" + txtUserName.Text.Trim() + " 'and password= '"  +txtPassword.Text.Trim() +"'"   ;
            SqlDataAdapter sd = new SqlDataAdapter(query,sql);
            DataTable dtbl = new DataTable();
            sd.Fill(dtbl);


            if(dtbl.Rows.Count==1)
            {
                Form form = new Form();
                this.Hide();
                form.Show();

            }

            else
            {
                MessageBox.Show("Kullanıcı adı ve şifreyi kontrol ediniz.");

            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
    }
}

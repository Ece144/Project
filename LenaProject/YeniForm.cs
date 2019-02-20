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
    public partial class YeniForm : System.Windows.Forms.Form
    {
        public YeniForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void YeniForm_Load(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            string giris = txtFormismi.Text;
            string isim = txtisim.Text;
            string soyisim = txtsoyisim.Text;

            if (giris.Length <= 1 || isim.Length<=1 || soyisim.Length <= 1)
            {
                errorProvider1.SetError(txtFormismi, "Bu alan boş bırakılamaz!");
            }


            else { 


            SqlConnection sql = new SqlConnection(@"Data Source=DESKTOP-6VUJ8QA\SQLEXPRESS;Initial Catalog=form;Integrated Security=True");
            

            if (sql.State==ConnectionState.Closed)
            {
                sql.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sql;
                cmd.CommandText = "INSERT INTO formTable(formName,description,createdAt,createdBy,name,surname,age) VALUES('"+ txtFormismi.Text + "','"+ txtAciklama.Text + "','"+ txtcreatedAt.Text + "','"+ txtcreatedBy.Text + "','"+ txtisim.Text + "','"+ txtsoyisim.Text + "','"+ int.Parse(txtage.Text) + "') ";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                sql.Close();

                


                MessageBox.Show("Form kaydedildi.","İşlem Başarılı",MessageBoxButtons.OK);
             


                Form obj = (Form)Application.OpenForms["Form"];

                obj.BindDataGrid();

                obj.dataGridView1.Update();
                obj.dataGridView1.Refresh();

                
                this.Hide();
                
            }


            }

        }

        private void txtFormismi_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

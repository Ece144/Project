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
    public partial class Form : System.Windows.Forms.Form
    {
        SqlConnection sql = new SqlConnection(@"Data Source=DESKTOP-6VUJ8QA\SQLEXPRESS;Initial Catalog=form;Integrated Security=True");       
        DataTable dt = new DataTable();
        SqlDataAdapter da;


        public Form()
        {
            InitializeComponent();
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void BindDataGrid()
        {
            
            String query = "Select * from formTable";
            da = new SqlDataAdapter(query, sql);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form_Load(object sender, EventArgs e)
        {
          
            this.formTableTableAdapter.Fill(this.formDataSet.formTable);
            //BindDataGrid();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string aranan = textBox1.Text.Trim().ToUpper();
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                    {
                        if (cell.Value != null)
                        {
                            if (cell.Value.ToString().ToUpper() == aranan)
                            {
                                cell.Style.BackColor = Color.DarkTurquoise;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YeniForm form = new YeniForm();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formGoruntuleme form = new formGoruntuleme();
            this.Hide();
            form.Show();
        }
    }
}

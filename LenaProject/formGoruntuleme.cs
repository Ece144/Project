using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LenaProject
{
    public partial class formGoruntuleme : System.Windows.Forms.Form
    {
        public formGoruntuleme()
        {
            InitializeComponent();
        }

        private void formGoruntuleme_Load(object sender, EventArgs e)
        {
          
            this.formTableTableAdapter.Fill(this.formDataSet.formTable);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            this.Hide();
            form.Show();
        }
    }
}

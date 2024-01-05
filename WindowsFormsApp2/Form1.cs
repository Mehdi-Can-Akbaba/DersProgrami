using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _1036 form1 = new _1036();
            form1.Show();
 

            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _1044 form4 = new _1044();
            form4.Show();

            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            _1040 form2 = new _1040();
            form2.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _1041 form3 = new _1041();
            form3.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Z023 form5 = new Z023();
            form5.Show();

            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Z025 form6 = new Z025();
            form6.Show();

            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

  
    }
}

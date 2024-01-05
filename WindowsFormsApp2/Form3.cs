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
    public partial class Form3 : Form
    {
        private Panel panel1;
        private Panel panel2;
        public Form3()
        {
            InitializeComponent();

            // Panel 1 oluştur
            panel1 = new Panel();
            panel1.Size = new System.Drawing.Size(1000, 1000);
            panel1.BackColor = System.Drawing.Color.LightGray;
            panel1.Location = new System.Drawing.Point(50, 50);
            this.Controls.Add(panel1);

            // Panel 2 oluştur
            panel2 = new Panel();
            panel2.Size = new System.Drawing.Size(1000, 1000);
            panel2.BackColor = System.Drawing.Color.LightBlue;
            panel2.Location = new System.Drawing.Point(50, 50);
            this.Controls.Add(panel2);

            // Panel 1'i göster, Panel 2'yi gizle
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Panel 1'i göster, Panel 2'yi gizle
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Panel 2'yi göster, Panel 1'i gizle
            panel1.Visible = false;
            panel2.Visible = true;
        }
    }
}

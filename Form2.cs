using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartAssistant
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        bool closed = true;

        private void button1_Click(object sender, EventArgs e)
        {
            if (closed)
            {
                label1.Text = "Το καλοριφέρ\nείναι ανοιχτό";
                button1.Text = "Off";
                label3.Text = "Πάτησε στο Off\nγια να κλείσει\nτο καλοριφέρ";
                comboBox1.Visible = true;
                label4.Visible = true;
                closed = false;
            }
            else
            {
                label1.Text = "Το καλοριφέρ\nείναι κλειστό";
                button1.Text = "On";
                label3.Text = "Πάτησε στο On\nγια να ανοίξει\nτο καλοριφέρ";
                comboBox1.Visible = false;
                label4.Visible = false;
                closed = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            Close();
        }
    }
}

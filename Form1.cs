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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Επιλέξτε Διαχείριση Καλοριφέρ αν θέλετε να διαχειριστείτε το καλοριφέρ σας." + "\n" + " Επιλέξτε Διαχείριση φωτών αν θέλετε να διαχειριστείτε τα φώτα σε κάποιο δωμάτιο του σπιτιού σας." + "\n" + "Επιλέξτε Διαχείριση Παπουτσοθήκης αν θέλετε να δείτε ποια παπούτσια να φορέσετε.");
        }
    }
}

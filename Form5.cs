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
    public partial class Form5 : Form
    {
        

        public Form5()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            Hide();
            Form7 f7 = new Form7();
            f7.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form9 f9 = new Form9();
            f9.ShowDialog();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Επιλέξτε Διαχείριση Πλάνου ημέρας αν θέλετε να διαχειριστείτε το πλάνο ημέρας.\nΕπιλέξτε Διαχείριση συσκευών αν θέλετε να διαχειριστείτε κάποια συσκευή που είναι συνδεδεμένη με την εφαρμογή.\nΕπιλέξτε Διαχείριση Ταΐστρας αν θέλετε να διασειστείτε την έξυπνη ταΐστρα σας.");
        }
    }
}

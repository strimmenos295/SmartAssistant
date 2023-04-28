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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text.Equals("Όχι"))
            {
                label7.Visible = false;
            }
            else
            {
                label7.Visible = true;
            }
            linkLabel1.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label8.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form7 f7 = new Form7();
            f7.ShowDialog();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Απαντήστε στις ερωτήσεις που σας γίνονται και κατόπιν πατήστε Βρες λύση. Ανάλογα με τις απαντήσεις σας θα σας εμφανιστούν πληροφορίες για την διαδρομή σας.\nΑν θέλετε να γυρίσετε στην λίστα με τις δραστηριότητες πατήστε Εμφάνιση Δραστηριοτήτων.");

        }
    }
}

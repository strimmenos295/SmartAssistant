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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            label2.Visible = false;
            button2.Visible = false;
            pictureBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();

            if (comboBox1.Text.Equals("βόλτα με φίλους"))
            {
                label2.Visible = true;
                label2.Text = "για να πατε βόλτα φορέστε αυτά τα παπούτσια";
                pictureBox1.Visible = true;
                button2.Visible = false;

                player.SoundLocation = @"on.wav";
                player.Load();
                player.Play();
            }
            else
            {
                label2.Visible = true;
                label2.Text = "δεν έχω να σου δώσω κατάλληλα παπούτσια!";
                button2.Visible = true;
                pictureBox1.Visible = false;

                player.SoundLocation = @"off.wav";
                player.Load();
                player.Play();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Επιλέξτε ποια δραστηριότητα θέλετε να κάνετε και κατόπιν πατήστε Αναζήτηση Παπουτσιών. Αν βρεθούν θα σας βγουν τα προτεινόμενα σε μία φωτογραφία. Αν όχι πατήστε το κουμπί «Πάτα για να αγοράσεις» προκειμένου να σας εμφανιστούν προτεινόμενα παπούτσια στο Skroutz.");
        }
    }
}

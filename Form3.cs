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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        bool bedroom = false;
        bool childroom = false;
        bool kitchen = false;
        bool livingroom = false;
        bool wc = false;

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();

            if (button1.Text.Equals("On"))
            {
                player.SoundLocation = @"on.wav";
                player.Load();
                player.Play();
            }
            else
            {
                player.SoundLocation = @"off.wav";
                player.Load();
                player.Play();
            }

            if (comboBox1.Text.Equals("Υπνοδωμάτιο")&&bedroom)
            {
                bedroom = false;
                label1.Text = "Τα φώτα στο Υπνοδωμάτιο\nείναι κλειστά";
                label3.Text = "Πάτησε στο On\nγια να ανοίξουν\nτα φώτα";
                button1.Text = "On";

                BackgroundImage = Image.FromFile("ipnodomatio1.png");
            }
            else if (comboBox1.Text.Equals("Υπνοδωμάτιο") && !bedroom)
            {
                bedroom = true;
                label1.Text = "Τα φώτα στο Υπνοδωμάτιο\nείναι ανοιχτά";
                label3.Text = "Πάτησε στο Off\nγια να κλείσουν\nτα φώτα";
                button1.Text = "Off";

                BackgroundImage = Image.FromFile("ipnodomatio.png");
            }
            else if (comboBox1.Text.Equals("Παιδικό δωμάτιο") && childroom)
            {
                childroom = false;
                label1.Text = "Τα φώτα στο Παιδικό\nδωμάτιο είναι κλειστά";
                label3.Text = "Πάτησε στο On\nγια να ανοίξουν\nτα φώτα";
                button1.Text = "On";

                BackgroundImage = Image.FromFile("child1.jpg");
            }
            else if (comboBox1.Text.Equals("Παιδικό δωμάτιο") && !childroom)
            {
                childroom = true;
                label1.Text = "Τα φώτα στο Παιδικό\nδωμάτιο είναι ανοιχτά";
                label3.Text = "Πάτησε στο Off\nγια να κλείσουν\nτα φώτα";
                button1.Text = "Off";

                BackgroundImage = Image.FromFile("child.jpg");
            }
            else if (comboBox1.Text.Equals("Κουζίνα") && kitchen)
            {
                kitchen = false;
                label1.Text = "Τα φώτα στην Κουζίνα\nείναι κλειστά";
                label3.Text = "Πάτησε στο On\nγια να ανοίξουν\nτα φώτα";
                button1.Text = "On";

                BackgroundImage = Image.FromFile("kitchen1.jpg");
            }
            else if (comboBox1.Text.Equals("Κουζίνα") && !kitchen)
            {
                kitchen = true;
                label1.Text = "Τα φώτα στην Κουζίνα\nείναι ανοιχτά";
                label3.Text = "Πάτησε στο Off\nγια να κλείσουν\nτα φώτα";
                button1.Text = "Off";

                BackgroundImage = Image.FromFile("kitchen.jpg");
            }
            else if (comboBox1.Text.Equals("Σαλόνι") && livingroom)
            {
                livingroom = false;
                label1.Text = "Τα φώτα στο Σαλόνι\nείναι κλειστά";
                label3.Text = "Πάτησε στο On\nγια να ανοίξουν\nτα φώτα";
                button1.Text = "On";

                BackgroundImage = Image.FromFile("sallon1.jpg");
            }
            else if (comboBox1.Text.Equals("Σαλόνι") && !livingroom)
            {
                livingroom = true;
                label1.Text = "Τα φώτα στο Σαλόνι\nείναι ανοιχτά";
                label3.Text = "Πάτησε στο Off\nγια να κλείσουν\nτα φώτα";
                button1.Text = "Off";

                BackgroundImage = Image.FromFile("sallon.jpg");
            }
            else if (comboBox1.Text.Equals("WC") && wc)
            {
                wc = false;
                label1.Text = "Τα φώτα στο WC\nείναι κλειστά";
                label3.Text = "Πάτησε στο On\nγια να ανοίξουν\nτα φώτα";
                button1.Text = "On";

                BackgroundImage = Image.FromFile("wc1.jpg");
            }
            else if (comboBox1.Text.Equals("WC") && !wc)
            {
                wc = true;
                label1.Text = "Τα φώτα στο WC\nείναι ανοιχτά";
                label3.Text = "Πάτησε στο Off\nγια να κλείσουν\nτα φώτα";
                button1.Text = "Off";

                BackgroundImage = Image.FromFile("wc.jpg");
            }
        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("WC") && wc)
            {
                label1.Text = "Τα φώτα στο WC\nείναι ανοιχτά";
                label3.Text = "Πάτησε στο Off\nγια να κλείσουν\nτα φώτα";
                button1.Text = "Off";

                BackgroundImage = Image.FromFile("wc.jpg");
            }
            else if (comboBox1.Text.Equals("WC") && !wc)
            {
                label1.Text = "Τα φώτα στο WC\nείναι κλειστά";
                label3.Text = "Πάτησε στο On\nγια να ανοίξουν\nτα φώτα";
                button1.Text = "On";

                BackgroundImage = Image.FromFile("wc1.jpg");
            }
            else if (comboBox1.Text.Equals("Υπνοδωμάτιο") && !bedroom)
            {
                
                label1.Text = "Τα φώτα στο Υπνοδωμάτιο\nείναι κλειστά";
                label3.Text = "Πάτησε στο On\nγια να ανοίξουν\nτα φώτα";
                button1.Text = "On";

                BackgroundImage = Image.FromFile("ipnodomatio1.png");
            }
            else if (comboBox1.Text.Equals("Υπνοδωμάτιο") && bedroom)
            {
                
                label1.Text = "Τα φώτα στο Υπνοδωμάτιο\nείναι ανοιχτά";
                label3.Text = "Πάτησε στο Off\nγια να κλείσουν\nτα φώτα";
                button1.Text = "Off";

                BackgroundImage = Image.FromFile("ipnodomatio.png");
            }
            else if (comboBox1.Text.Equals("Παιδικό δωμάτιο") && !childroom)
            {
                
                label1.Text = "Τα φώτα στο Παιδικό\nδωμάτιο είναι κλειστά";
                label3.Text = "Πάτησε στο On\nγια να ανοίξουν\nτα φώτα";
                button1.Text = "On";

                BackgroundImage = Image.FromFile("child1.jpg");
            }
            else if (comboBox1.Text.Equals("Παιδικό δωμάτιο") && childroom)
            {
                label1.Text = "Τα φώτα στο Παιδικό\nδωμάτιο είναι ανοιχτά";
                label3.Text = "Πάτησε στο Off\nγια να κλείσουν\nτα φώτα";
                button1.Text = "Off";

                BackgroundImage = Image.FromFile("child.jpg");
            }
            else if (comboBox1.Text.Equals("Κουζίνα") && !kitchen)
            {
                label1.Text = "Τα φώτα στην Κουζίνα\nείναι κλειστά";
                label3.Text = "Πάτησε στο On\nγια να ανοίξουν\nτα φώτα";
                button1.Text = "On";

                BackgroundImage = Image.FromFile("kitchen1.jpg");
            }
            else if (comboBox1.Text.Equals("Κουζίνα") && kitchen)
            {
                label1.Text = "Τα φώτα στην Κουζίνα\nείναι ανοιχτά";
                label3.Text = "Πάτησε στο Off\nγια να κλείσουν\nτα φώτα";
                button1.Text = "Off";

                BackgroundImage = Image.FromFile("kitchen.jpg");
            }
            else if (comboBox1.Text.Equals("Σαλόνι") && !livingroom)
            {
                label1.Text = "Τα φώτα στο Σαλόνι\nείναι κλειστά";
                label3.Text = "Πάτησε στο On\nγια να ανοίξουν\nτα φώτα";
                button1.Text = "On";

                BackgroundImage = Image.FromFile("sallon1.jpg");
            }
            else if (comboBox1.Text.Equals("Σαλόνι") && livingroom)
            {
                label1.Text = "Τα φώτα στο Σαλόνι\nείναι ανοιχτά";
                label3.Text = "Πάτησε στο Off\nγια να κλείσουν\nτα φώτα";
                button1.Text = "Off";

                BackgroundImage = Image.FromFile("sallon.jpg");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Επιλέξτε το δωμάτιο που σας ενδιαφέρει και κατόπιν πατήστε on/off για να ανοίξετε ή να κλείσετε τα φώτα στο συγκεκριμένο δωμάτιο.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartAssistant
{
    public partial class Form6 : Form
    {
        String connectionString = "Data Source=plano.db;Version=3;";
        SQLiteConnection conn; 
        Plano p1 = new Plano();

        public Form6()
        {
            InitializeComponent();
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
            Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            conn = new SQLiteConnection(connectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();

            if (comboBox1.Text.Equals("") || comboBox2.Text.Equals("") || comboBox3.Text.Equals(""))
            {
                player.SoundLocation = @"off.wav";
                player.Load();
                player.Play();
                MessageBox.Show("Πρέπει να δώσεις όλες τις πληροφορίες!");

            }
            else
            {

                p1.apo = comboBox1.Text;
                p1.eos = comboBox3.Text;
                p1.topos = comboBox2.Text;

                bool done = false;
                conn.Open();
                String insertQuery = "Insert into plano(apo, eos, topothesia) values('"
                    + p1.apo + "','" + p1.eos + "','" + p1.topos + "' )";
                try
                {
                    SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn);
                    cmd.ExecuteNonQuery();
                    done = true;
                }
                catch (SQLiteException)
                {
                    player.SoundLocation = @"off.wav";
                    player.Load();
                    player.Play();
                    MessageBox.Show("Παρακαλώ επιλέξτε διαφορετική ώρα.");
                }


                if (done)
                {
                    player.SoundLocation = @"on.wav";
                    player.Load();
                    player.Play();
                    MessageBox.Show("Η δραστηριότητα αποθηκεύτηκε!");
                    conn.Close();
                }
                conn.Close();
            }
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
            MessageBox.Show("Εκχωρήστε την ώρα έναρξης και λήξης της δραστηριότητας καθώς και την ίδια Δραστηριότητα στα διαθέσιμα πεδία. Κατόπιν πατήστε Εισαγωγή Δραστηριότητας. Αν όλα πάνε καλά τα καταφέρατε. Διαφορετικά θα σας βγει μήνυμα για το τι πήγε στραβά.\nΑν θέλετε να γυρίσετε στην λίστα με τις δραστηριότητες πατήστε Εμφάνιση Δραστηριοτήτων.");
        }
    }
}

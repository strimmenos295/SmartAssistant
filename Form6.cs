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
            if (comboBox1.Text.Equals("") || comboBox2.Text.Equals("") || comboBox3.Text.Equals(""))
            {
                MessageBox.Show("You must give all the information needed!");
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
                    MessageBox.Show("Παρακαλώ επιλέξτε διαφορετική ώρα.");
                }


                if (done)
                {
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
    }
}

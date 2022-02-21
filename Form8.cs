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
    public partial class Form8 : Form
    {

        String connectionString = "Data Source=plano.db;Version=3;";
        SQLiteConnection conn;
        Plano p1 = new Plano();

        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("") )
            {
                MessageBox.Show("Δεν έδωσες ώρα έναρξης δραστηριότητας!");
            }
            else
            {
                int num = 0;
                bool done = false;
                conn.Open();
                String deleteQuery = "Delete from plano where apo='"+comboBox1.Text+"'";
                try
                {
                    SQLiteCommand cmd = new SQLiteCommand(deleteQuery, conn);
                    num = cmd.ExecuteNonQuery();
                    done = true;
                }
                catch (SQLiteException)
                {
                    MessageBox.Show("Αποτυχία.");
                }


                if (done&&num!=0)
                {
                    MessageBox.Show("Η δραστηριότητα διαγραφτηκε!");
                    conn.Close();
                }
                else if (done&&num==0)
                {
                    MessageBox.Show("Η δραστηριότητα δεν υπήρχε!");
                    conn.Close();
                }
                conn.Close();
            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            conn = new SQLiteConnection(connectionString);
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
    }
}

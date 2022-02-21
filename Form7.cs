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
    public partial class Form7 : Form
    {
        String connectionString = "Data Source=plano.db;Version=3;";
        SQLiteConnection conn;
        Plano p1 = new Plano();
        StringBuilder builder = new StringBuilder();
        List<Plano> list = new List<Plano>();
        String result = "";
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            conn = new SQLiteConnection(connectionString);
            Functions f1 = new Functions();
            list = f1.DataBaseSelectAll(conn);

            int i,lessapoj1,lessapoj;

            //taksinomisi algorithmos FISALLIDA start
            int n = list.Count() - 1;
            for (i = 1; i <= n; i++)
            {
                for (int j = n; j >= i; j--)
                {
                    lessapoj1 = int.Parse(list.ElementAt(j - 1).apo);
                    lessapoj = int.Parse(list.ElementAt(j).apo);
                    if (lessapoj < lessapoj1)
                    {
                        p1.apo = list.ElementAt(j - 1).apo;
                        p1.eos = list.ElementAt(j - 1).eos;
                        p1.topos = list.ElementAt(j - 1).topos;

                        list.ElementAt(j - 1).apo = list.ElementAt(j).apo;
                        list.ElementAt(j - 1).eos = list.ElementAt(j).eos;
                        list.ElementAt(j - 1).topos = list.ElementAt(j).topos;

                        list.ElementAt(j).apo = p1.apo;
                        list.ElementAt(j).eos = p1.eos;
                        list.ElementAt(j).topos = p1.topos;
                    }
                }
            }
            //taksinomisi algorithmos FISALLIDA end


            if (list.Count() < 1)
            {
                builder.Append("Δεν έχετε για σήμερα καποια δραστηριότητα.Προσθέστε!");
            }
            else
            {
                foreach(Plano plano in list)
                {
                    builder.Append("Από: ").Append(plano.apo).Append(" έως: ").Append(plano.eos)
                        .Append(" δραστηριότητα: ").Append(plano.topos).Append("\n");
                }
            }

            result = builder.ToString();
            richTextBox1.Text = result;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form6 f6 = new Form6();
            f6.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form8 f8 = new Form8();
            f8.ShowDialog();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
            Close();
        }
    }
}

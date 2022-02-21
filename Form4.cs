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
            if (comboBox1.Text.Equals("βόλτα με φίλους"))
            {
                label2.Visible = true;
                label2.Text = "για να πατε βόλτα φορέστε αυτά τα παπούτσια";
                pictureBox1.Visible = true;
                button2.Visible = false;
            }
            else
            {
                label2.Visible = true;
                label2.Text = "δεν έχω να σου δώσω κατάλληλα παπούτσια!";
                button2.Visible = true;
                pictureBox1.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            Close();
        }
    }
}

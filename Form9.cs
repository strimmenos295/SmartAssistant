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
    public partial class Form9 : Form
    {
        String connectionString = "Data Source=plano.db;Version=3;";
        SQLiteConnection conn;
        Plano p1 = new Plano();
        StringBuilder builder = new StringBuilder();
        List<Plano> list = new List<Plano>();

        int timeInSec = 0;
        int elapsedTimeForFood = 0;
        int elapsedTimeForWater = 0;


        float amountForFood = 1;
        int timeForFood = 10;
        bool foodButtonWasPressed;

        float amountForWater = 1;
        int timeForWater = 10;
        bool waterButtonWasPressed;

        bool autoCare1;
        bool autoCare2;

        int mins = 0;
        int hours = 0;

        public Form9()
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeInSec++;

            if (timeInSec == 15 || timeInSec == 40) // για ζημια
            {
                label1.Visible = true;
            }
            if ((label1.Visible && timeInSec == 20) || label1.Visible && timeInSec == 45)
            {
                label1.Visible = false;
            }

            if (timeInSec % 20 == 0) // trone kai pinoun
            {
                if (int.Parse(label4.Text) == 10)
                {
                    label4.Text = "0";
                }
                else if (int.Parse(label4.Text) == 0)
                {

                }
                else
                {
                    label4.Text = (int.Parse(label4.Text) - 20).ToString();
                }
            }
            if (timeInSec % 10 == 0)
            {
                if (int.Parse(label5.Text) == 10)
                {
                    label5.Text = "0";
                }
                else if (int.Parse(label5.Text) == 0)
                {

                }
                else
                {
                    label5.Text = (int.Parse(label5.Text) - 20).ToString();
                }
            }

            if (foodButtonWasPressed) //manual taisma
            {
                elapsedTimeForFood++;
                if (elapsedTimeForFood == timeForFood)
                {
                    label4.Text = (int.Parse(label4.Text) + (100 * amountForFood)).ToString();
                    elapsedTimeForFood = 0;
                    foodButtonWasPressed = false;
                }

            }
            if (waterButtonWasPressed)
            {
                elapsedTimeForWater++;
                if (elapsedTimeForWater == timeForWater)
                {
                    label5.Text = (int.Parse(label5.Text) + (100 * amountForWater)).ToString();
                    elapsedTimeForWater = 0;
                    waterButtonWasPressed = false;
                }

            }

            if (autoCare1) //auto taisma
            {
                label14.Visible = true;
                label15.Visible = true;

                if (label18.Text.Equals("9"))
                {
                    label4.Text = "100";
                    label5.Text = "100";
                    autoCare1 = false;
                }
            }
            if (autoCare2) //auto taisma
            {
                label14.Visible = true;
                label16.Visible = true;

                if (label18.Text.Equals("18"))
                {
                    label4.Text = "100";
                    label5.Text = "100";
                    autoCare2 = false;
                }
            }
            if (autoCare1 && autoCare2)
            {
                label17.Visible = true;
            }

            if (label19.Text.Equals("59") && label21.Text.Equals("59")) //timer
            {
                label19.Text = "0";
                hours++;
                label18.Text = (hours % 25).ToString();
            }      
            if (label21.Text.Equals("59"))
            {
                mins++;
                label19.Text = (mins % 60).ToString();
            }
            label21.Text = (timeInSec % 60).ToString(); 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foodButtonWasPressed = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            waterButtonWasPressed = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            amountForFood = float.Parse(comboBox1.Text);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            timeForFood = int.Parse(comboBox2.Text);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            amountForWater = float.Parse(comboBox4.Text);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            timeForWater = int.Parse(comboBox3.Text);
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            conn = new SQLiteConnection(connectionString);
            Functions f1 = new Functions();
            list = f1.DataBaseSelectAll(conn);

            int i, lessapoj1, lessapoj;

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

            int apo = 0;
            int eos = 0;
            for (i = 0; i < list.Count; i++)
            {
                eos = int.Parse(list.ElementAt(i).eos);
                apo = int.Parse(list.ElementAt(i).apo);
                if (apo <= 9 && eos >= 9 && !( list.ElementAt(i).topos.Equals("Σπίτι") || list.ElementAt(i).topos.Equals("Ύπνος") || list.ElementAt(i).topos.Equals("Διάβασμα") ))
                {
                    autoCare1 = true;     
                }
                if (apo <= 18 && eos >= 18 && !(list.ElementAt(i).topos.Equals("Σπίτι") || list.ElementAt(i).topos.Equals("Ύπνος") || list.ElementAt(i).topos.Equals("Διάβασμα")))
                {
                    autoCare2 = true;
                    break;
                }
            }
        }
    }
}

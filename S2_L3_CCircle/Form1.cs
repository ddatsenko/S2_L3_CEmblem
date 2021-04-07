using System;
using System.Drawing;
using System.Windows.Forms;

namespace S2_L3_CCircle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            emblems = new CEmblem[100];
        }

        CEmblem[] emblems;
        int emblemCount = 0;
        int currentEmblemIndex;

        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            if (emblemCount >= 99)
            {
                MessageBox.Show("You've reached the maximum amount of objects."); return;
            }
            Graphics graphics = Main.CreateGraphics();
            currentEmblemIndex = emblemCount;
            // Створення нового об'єкта - екземпляра класу CCircle
            emblems[currentEmblemIndex] = new CEmblem(graphics, Main.Width / 2, Main.Height / 2, 50);
            emblems[currentEmblemIndex].Show();
            emblemCount++;
            comboBox1.Items.Add("Emblem №" + (emblemCount).ToString());
            comboBox1.SelectedIndex = emblemCount - 1;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            emblems[comboBox1.SelectedIndex].Hide();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            emblems[comboBox1.SelectedIndex].Show();
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            emblems[comboBox1.SelectedIndex].Expand(5);
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            emblems[comboBox1.SelectedIndex].Collapse(5);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            emblems[comboBox1.SelectedIndex].Move(0, -10);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            emblems[comboBox1.SelectedIndex].Move(0, 10);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            emblems[comboBox1.SelectedIndex].Move(-10, 0);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            emblems[comboBox1.SelectedIndex].Move(10, 0);
        }

        private void btn2Right_Click(object sender, EventArgs e)
        {
            emblems[comboBox1.SelectedIndex].Move(20, 0);
        }

        private void btn2Left_Click(object sender, EventArgs e)
        {
            emblems[comboBox1.SelectedIndex].Move(-20, 0);
        }

        private void btn2Up_Click(object sender, EventArgs e)
        {
            emblems[comboBox1.SelectedIndex].Move(0, -20);
        }

        private void btn2Down_Click(object sender, EventArgs e)
        {
            emblems[comboBox1.SelectedIndex].Move(0, 20);
        }
    }
}

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
        int lengthX = 0;
        int lengthY = 0;

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
            lengthY += 1;
            if (lengthY > 13)
            {
                btnUp.Enabled = false;
                btn2Up.Enabled = false;
            }
            btnDown.Enabled = true;
            btn2Down.Enabled = true;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            emblems[comboBox1.SelectedIndex].Move(0, 10);
            lengthY -= 1;
            if (lengthY < -13)
            {
                btnDown.Enabled = false;
                btn2Down.Enabled = false;
            }
            btnUp.Enabled = true;
            btn2Up.Enabled = true;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            emblems[comboBox1.SelectedIndex].Move(-10, 0);
            lengthX -= 1;
            if (lengthX < -34)
            {
                btnLeft.Enabled = false;
                btn2Left.Enabled = false;
            }
            btnRight.Enabled = true;
            btn2Right.Enabled = true;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            emblems[comboBox1.SelectedIndex].Move(10, 0);
            lengthX += 1;
            if (lengthX > 7)
            {
                btnRight.Enabled = false;
                btn2Right.Enabled = false;
            }
            btnLeft.Enabled = true;
            btn2Left.Enabled = true;
        }

        private void btn2Right_Click(object sender, EventArgs e)
        {
            emblems[comboBox1.SelectedIndex].Move(20, 0);
            lengthX += 2;
            if (lengthX > 7)
            {
                btnRight.Enabled = false;
                btn2Right.Enabled = false;
            }
            btnLeft.Enabled = true;
            btn2Left.Enabled = true;
        }

        private void btn2Left_Click(object sender, EventArgs e)
        {
            emblems[comboBox1.SelectedIndex].Move(-20, 0);
            lengthX -= 2;
            if (lengthX < -34)
            {
                btnLeft.Enabled = false;
                btn2Left.Enabled = false;
            }
            btnRight.Enabled = true;
            btn2Right.Enabled = true;
        }

        private void btn2Up_Click(object sender, EventArgs e)
        {
            emblems[comboBox1.SelectedIndex].Move(0, -20);
            lengthY += 2;
            if (lengthY > 13)
            {
                btnUp.Enabled = false;
                btn2Up.Enabled = false;
            }
            btnDown.Enabled = true;
            btn2Down.Enabled = true;
        }

        private void btn2Down_Click(object sender, EventArgs e)
        {
            emblems[comboBox1.SelectedIndex].Move(0, 20);
            lengthY -= 2;
            if (lengthY < -13)
            {
                btnDown.Enabled = false;
                btn2Down.Enabled = false;
            }
            btnUp.Enabled = true;
            btn2Up.Enabled = true;
        }
    }
}

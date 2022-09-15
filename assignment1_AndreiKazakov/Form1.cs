using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment1_AndreiKazakov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowMessageButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a test message.\nHello world!");
        }

        private void ChangeLabelButton_Click(object sender, EventArgs e)
        {
            switch (Label.Text)
            {
                case "Label":
                    Label.Text = "Changed Label";
                    break;
                case "Changed Label":
                    Label.Text = "Label";
                    break;
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox.Visible = false;
            ShowPictureButton.Visible = true;
        }

        private void ShowPictureButton_Click(object sender, EventArgs e)
        {
            PictureBox.Visible = true;
            ShowPictureButton.Visible = false;
        }
    }
}

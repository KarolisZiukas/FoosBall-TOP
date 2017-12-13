using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedBallTracker
{
    public partial class IntroductionForms : Form
    {
        private string FirstPlayerName = string.Empty;
        private string SecondPlayerName = string.Empty;
        bool bothPlayersAreSet { get; set; }

        //private static string VIDEO_DIR = "..\\projectFiles\\foosball_no_logo.jpg";

        public IntroductionForms()
        {
            InitializeComponent();
        }

        private void IntroductionForms_Load(object sender, EventArgs e)
        {
            string VIDEO_DIR = "..\\projectFiles\\foosball_no_logo.jpg";
            pictureBox5.ImageLocation = VIDEO_DIR; //path to image
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FirstPlayerName = textBox1.Text;
            SecondPlayerName = textBox2.Text;
            setFristPlayerName(FirstPlayerName);
            setSecondPlayerName(SecondPlayerName);

            if (this.FirstPlayerName != "" && SecondPlayerName != "")
            {
                bothPlayersAreSet = true;
                Close();
            }


        }

        public string GetFirstPlayerName()
        {
            return this.FirstPlayerName;
        }

        public string GetSecondPlayerName()
        {
            return this.SecondPlayerName;
        }

        public void setFristPlayerName(string FirstPlayerName)
        {
            this.FirstPlayerName = FirstPlayerName;
        }

        public void setSecondPlayerName(string SecondPlayerName)
        {
            SecondPlayerName = this.SecondPlayerName;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FirstPlayerName = textBox1.Text;
            SecondPlayerName = textBox2.Text;
            setFristPlayerName(FirstPlayerName);
            setSecondPlayerName(SecondPlayerName);

            if (this.FirstPlayerName != "" && SecondPlayerName != "")
            {
                bothPlayersAreSet = true;
                Close();
            }
        }

        private void IntroductionForms_Load_1(object sender, EventArgs e)
        {
            string VIDEO_DIR = "..\\projectFiles\\foosball_no_logo.jpg";
            pictureBox5.ImageLocation = VIDEO_DIR; //path to image
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
        }
    }
}

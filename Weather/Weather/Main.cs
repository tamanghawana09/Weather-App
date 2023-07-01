using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Start entering city name, US zip code, Canada postal code, UK postcode, ip, metar, etc.")
            {
                textBox1.Text = " ";
            }
            else if (textBox1.Text == " ")
            {
                textBox1.Text = "Start entering city name, US zip code, Canada postl code, UK postcode, ip, metar, etc.";
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 1000; //1000 milliseconds
            timer.Tick += Timer_Tick;
            timer.Start();
            comboBox1.Size = new System.Drawing.Size(223, 32);

            label1.Text = DateTime.Now.ToString("dddd, MMMM M, yyyy");
            
        }

        private void iconButton2_MouseHover(object sender, EventArgs e)
        {
            iconButton2.ForeColor = Color.PaleTurquoise;
            iconButton2.BackColor = Color.PaleTurquoise;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            Timer.Text = DateTime.Now.ToString("HH:MM:ss");
        }
    }
}
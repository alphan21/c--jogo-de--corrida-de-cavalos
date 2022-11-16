using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogodecorridadecavalos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int primeirocavalodistançia, segundocavalodistançia, terceirocavalodistançia;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int primeirocavalolargura = pictureBox1.Width;
            int segundocavalolargura = pictureBox2.Width;
            int terceirocavalolargura = pictureBox3.Width;

            int distançiafinal = label5.Left;

            pictureBox1.Left = pictureBox1.Left + aleatoria.Next(5, 15);
            pictureBox2.Left = pictureBox2.Left + aleatoria.Next(5, 15);
            pictureBox3.Left = pictureBox3.Left + aleatoria.Next(5, 15);

            if (primeirocavalolargura + pictureBox1.Left >= distançiafinal)
            {
                timer1.Enabled = false;
                MessageBox.Show("1 corrida de cavalos ganha!!!");
                
            }

            if(segundocavalolargura+pictureBox2.Left>= distançiafinal)
            {
                timer1.Enabled = false;
                MessageBox.Show("2 corrida de cavalos ganha");
            }
            if (terceirocavalolargura + pictureBox3.Left >= distançiafinal)
            {
                timer1.Enabled = false;
                MessageBox.Show("3 corrida de cavalos ganha");
            }
        }

        Random aleatoria = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            primeirocavalodistançia = pictureBox1.Left;
            segundocavalodistançia = pictureBox2.Left;
            terceirocavalodistançia = pictureBox3.Left;
        }
    }
}

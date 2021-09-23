using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingOnImage
{
    public partial class Form1 : Form
    {
        private SolidBrush Brush = new SolidBrush(Color.White);
        private Graphics graph;
        public Form1()
        {
            InitializeComponent() ;
            pictureBox2.Focus();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                graph = Graphics.FromImage(pictureBox1.Image);
            }


        }
        

        private bool Validationpassed(int x,int y)
        {
            return x >= 0 && x <= pictureBox1.Width && y >= 0 && y <= pictureBox1.Height;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            graph = pictureBox1.CreateGraphics();
            int x, y;
            if (e.Button == MouseButtons.Left)
            {
                x = e.Location.X;
                y = e.Location.Y;
                graph.DrawEllipse(new Pen(Brush,(float)numericUpDown2.Value), x, y, 2, 2);
            }
        }


        private void splitContainer1_SplitterMoved_1(object sender, SplitterEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Brush = new SolidBrush(pictureBox2.BackColor);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Brush = new SolidBrush(pictureBox4.BackColor);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Brush = new SolidBrush(pictureBox7.BackColor);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Brush = new SolidBrush(pictureBox3.BackColor);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Brush = new SolidBrush(pictureBox5.BackColor);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Brush = new SolidBrush(pictureBox6.BackColor);
        }
    }
}

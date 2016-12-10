using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakePoint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics g;
        ColorDialog colorDialog = new ColorDialog();
        int kalinlik = 3;
        int baslaX, baslaY;
        bool ciz;

        private void renksecBtn_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ciz = true;
            baslaX = e.X;
            baslaY = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            ciz = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            g = CreateGraphics();
            Pen P = new Pen(colorDialog.Color, kalinlik);
            Point Point1 = new Point(baslaX, baslaY);
            Point Point2 = new Point(e.X, e.Y);

            if (ciz == true)
            {
                g.DrawLine(P, Point1, Point2);
                baslaX = e.X;
                baslaY = e.Y;
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Timer LDPTimer;
        public Form1()
        {
            InitializeComponent();
            LDPTimer = new Timer();
            LDPTimer.Interval = 1000;
            LDPTimer.Tick += LDPTimer_Tick;
            LDPTimer.Start();
        }

        private void LDPTimer_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            List<Pen> PenList = new List<Pen> {
            new Pen(new SolidBrush(Color.Red)),
            new Pen(new SolidBrush(Color.Green)),
            new Pen(new SolidBrush (Color.Blue)),
            };
            Rectangle rectangle1 = new Rectangle(125, 125, 70, 50);
            Rectangle rectangle2 = new Rectangle(25, 225, 70, 50);
            Rectangle rectangle3 = new Rectangle(225, 225, 70, 50);

            e.Graphics.DrawRectangle(Pens.Blue, rectangle1);
            e.Graphics.DrawRectangle(Pens.Red, rectangle2);
            e.Graphics.DrawRectangle(Pens.Green, rectangle3);

            Point point1 = new Point(rectangle1.Bottom, rectangle2.Top);
            Point point2 = new Point(rectangle1.Bottom, rectangle3.Top);

            e.Graphics.DrawLine(Pens.Black, rectangle1.Location, rectangle2.Location);
            e.Graphics.DrawLine(Pens.Black, rectangle1.Location, rectangle3.Location);

        }
    }
}

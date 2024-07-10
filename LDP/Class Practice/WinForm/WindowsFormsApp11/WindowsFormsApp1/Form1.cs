using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //public Timer timer;
        public Form1()
        {
            InitializeComponent();
            //timer = new Timer();
            //timer.Interval = 1000;
            //timer.Tick += timerTick;
            //timer.Start();
        }

        //private void timerTick(object sender, EventArgs e)
        //{
        //    Refresh();
        //}

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rectangle1 = new Rectangle(250, 50, 70, 50);
            Rectangle rectangle2 = new Rectangle(175, 150, 70, 50);
            Rectangle rectangle3 = new Rectangle(325, 150, 70, 50);
            Rectangle rectangle4 = new Rectangle(400, 250, 70, 50);
            Rectangle rectangle5 = new Rectangle(250, 250, 70, 50);

            SolidBrush blueBrush1 = new SolidBrush(Color.Blue);
            SolidBrush blueBrush2 = new SolidBrush(Color.Red);
            SolidBrush blueBrush3 = new SolidBrush(Color.Yellow);
            e.Graphics.FillRectangle(blueBrush1, rectangle1);
            e.Graphics.FillRectangle(blueBrush2, rectangle2);
            e.Graphics.FillRectangle(blueBrush2, rectangle3);
            e.Graphics.FillRectangle(blueBrush3, rectangle4);
            e.Graphics.FillRectangle(blueBrush3, rectangle5);

            e.Graphics.DrawRectangle(Pens.Black, rectangle1);
            e.Graphics.DrawRectangle(Pens.Black, rectangle2);
            e.Graphics.DrawRectangle(Pens.Black, rectangle3);
            e.Graphics.DrawRectangle(Pens.Black, rectangle4);
            e.Graphics.DrawRectangle(Pens.Black, rectangle5);

            e.Graphics.DrawLine(Pens.Black, new Point(285, 100), new Point(210, 150));
            e.Graphics.DrawLine(Pens.Black, new Point(285, 100), new Point(360, 150));
            e.Graphics.DrawLine(Pens.Black, new Point(360, 200), new Point(435, 250));
            e.Graphics.DrawLine(Pens.Black, new Point(360, 200), new Point(285, 250));




        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Point mousePosition = Cursor.Position;

            Console.WriteLine("(x, y) = ({0}, {1}).", mousePosition.X, mousePosition.Y);
            Console.ReadLine();
        }

    }
}

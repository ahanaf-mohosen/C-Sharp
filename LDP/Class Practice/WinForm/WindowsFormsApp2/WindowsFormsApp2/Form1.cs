using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LDPRenderingFPS
{
    public partial class Form1 : Form
    {
        public Timer LDPTimer;
        public Form1()
        {
            InitializeComponent();

            LDPTimer = new Timer();
            LDPTimer.Interval = 10;
            LDPTimer.Tick += LDPTimer_Tick;
            LDPTimer.Start();
        }

        private void LDPTimer_Tick(object sender, EventArgs e)
        {
            //TODO
            Refresh();
        }

        public int count = 1;
        Random Random = new Random(Guid.NewGuid().GetHashCode());
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            List<Pen> PenList = new List<Pen> {
                new Pen(new SolidBrush(Color.Red), 15),
                new Pen(new SolidBrush(Color.Blue), 15),
                new Pen(new SolidBrush(Color.Green), 15),
            };

            Rectangle rectangle = new Rectangle(100, 100, 50, 50);

            e.Graphics.DrawEllipse(PenList[Random.Next(0, PenList.Count - 1)], rectangle);

            Rectangle rectangle2 = new Rectangle(500, 100, 50, 50);
            e.Graphics.DrawEllipse(PenList[Random.Next(0, PenList.Count - 1)], rectangle2);

            Console.WriteLine(count++);
        }
    }
}

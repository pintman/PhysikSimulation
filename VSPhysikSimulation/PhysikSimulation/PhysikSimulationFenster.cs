using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace PhysikSimulation
{
    public partial class PhysikSimulationFenster : Form
    {
        private Welt welt;
        private Thread thread;

        public PhysikSimulationFenster()
        {
            InitializeComponent();
            welt = new Welt(new Size(pbWelt.Width - 30, pbWelt.Height - 30));

            WeltFuellen();
        }

        private void WeltFuellen()
        {
            Random rand = new Random();

            for (int i = 1; i <= 5; i++)
            {
                Ball b = new Ball();
                b.position.X = rand.Next(pbWelt.Width - 20);
                b.position.Y = rand.Next(pbWelt.Height - 20);

                welt.BallHinzufuegen(b);
            }
        }

        private void btnSchritt_Click(object sender, EventArgs e)
        {
            Einzelschritt();
        }

        private void pbWelt_Paint(object sender, PaintEventArgs e)
        {
            welt.HoleBaelle().ForEach(b =>
                e.Graphics.FillEllipse(Brushes.Red, b.ErstelleBoundingBox()));
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            thread = new Thread(new System.Threading.ThreadStart(start));
            thread.Start();
            btnStart.Enabled = false;
            btnSchritt.Enabled = false;
        }

        private void start()
        {
            while (true)
            {
                Einzelschritt();

                System.Threading.Thread.Sleep(50);
            }
        }

        private void Einzelschritt()
        {
            welt.Einzelschritt();
            pbWelt.Invalidate();
        }

        private void PhysikSimulationFenster_FormClosed(object sender, FormClosedEventArgs e)
        {
            thread.Abort();
        }
    }
}

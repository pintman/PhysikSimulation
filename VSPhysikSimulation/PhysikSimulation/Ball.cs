using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PhysikSimulation
{
    class Ball
    {
        public Point position;
        private Point geschwindigkeit;
        private Size groesse;

        private static Random rand = new Random();

        public Ball()
        {
            position = new Point(10, 0);
            geschwindigkeit = new Point(2, 3);
            groesse = new Size(20, 20);
        }

        public void Bewegen()
        {
            position.X += geschwindigkeit.X;
            position.Y += geschwindigkeit.Y;
        }

        public Boolean BewegtSichNachLinks()
        {
            return geschwindigkeit.X < 0;
        }

        public Boolean BewegtSichNachRechts()
        {
            return geschwindigkeit.X > 0;
        }

        public Boolean BewegtSichNachUnten()
        {
            return geschwindigkeit.Y > 0;
        }
        public Boolean BewegtSichNachOben()
        {
            return geschwindigkeit.Y < 0;
        }

        public void GeschwindigkeitVeraendern(int deltaX, int deltaY)
        {
            this.geschwindigkeit.X += deltaX;
            this.geschwindigkeit.Y += deltaY;
        }

        public void GeschwindigkeitXUmkehren()
        {
            this.geschwindigkeit.X *= -1;
        }
        public void GeschwindigkeitYUmkehren()
        {
            this.geschwindigkeit.Y *= -1;
        }

        public bool FindetKollisionStatt(Ball andererBall)
        {
            return ErstelleBoundingBox().IntersectsWith(andererBall.ErstelleBoundingBox());
        }

        public void KollidiereMitRechtemRand(int iDaempfung)
        {
            GeschwindigkeitVeraendern(-iDaempfung, 0);
            GeschwindigkeitXUmkehren();
        }
        public void KollidiereMitLinkemRand(int iDaempfung)
        {
            GeschwindigkeitVeraendern(-iDaempfung, 0);
            GeschwindigkeitXUmkehren();
        }
        public void BeruehreBoden(int iDaempfung)
        {
            GeschwindigkeitVeraendern(0, -iDaempfung);
            GeschwindigkeitYUmkehren();
        }

        public void KollidiereMit(Ball that)
        {
            if (this == that)
                return;

            this.RichtungUm180GradDrehen();
        }

        public Rectangle ErstelleBoundingBox()
        {
            Rectangle rec = new Rectangle(position, groesse);
            return rec;
        }

        public void RichtungUm180GradDrehen()
        {
            this.GeschwindigkeitXUmkehren();
            this.GeschwindigkeitYUmkehren();
        }

        public void ZufaelligeRichtungEinschlagen()
        {            
            if(rand.Next(2) == 0)
            {
                this.GeschwindigkeitXUmkehren();
            }
            if (rand.Next(2) == 0)
            {
                this.GeschwindigkeitYUmkehren();
            }

            if (this.geschwindigkeit.X == 0)
            {
                if (rand.Next(2) == 0)
                {
                    this.GeschwindigkeitVeraendern(1, 0);
                }
                if (rand.Next(2) == 0)
                {
                    this.GeschwindigkeitVeraendern(-1, 0);
                }
            }
        }
    }
}

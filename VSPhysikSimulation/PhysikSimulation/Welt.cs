using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PhysikSimulation
{
    class Welt
    {
        private List<Ball> baelle;
        private Size groesse;
        private int iDaempfung;

        public Welt(Size groesse)
        {
            baelle = new List<Ball>();
            this.groesse = groesse;
            this.iDaempfung = 1;
        }

        public void BallHinzufuegen(Ball b)
        {
            baelle.Add(b);
        }

        public void Einzelschritt(){
            baelle.ForEach(b =>
                {
                    b.Bewegen();

                    // Erdanziehung
                    b.GeschwindigkeitVeraendern(0, 1);                    
                });
           
            baelle.FindAll(b => KollidiertMitRechterWand(b) && b.BewegtSichNachRechts()).ForEach(b => 
                {
                    b.KollidiereMitRechtemRand(iDaempfung);
                });
            baelle.FindAll(b => KollidiertMitLinkerWand(b) && b.BewegtSichNachLinks()).ForEach(b =>
                {
                    b.KollidiereMitLinkemRand(iDaempfung);
                });
            baelle.FindAll(b => KollidiertMitBoden(b) && b.BewegtSichNachUnten()).ForEach(b =>
                {
                    b.BeruehreBoden(iDaempfung);
                });

            // kollision mit anderen Baellen
            baelle.ForEach(b1 => 
                baelle.ForEach(b2 =>
                    {
                        if (b1.FindetKollisionStatt(b2))
                        {
                            b1.KollidiereMit(b2);
                        }
                    }));
        }

        private bool KollidiertMitBoden(Ball b)
        {
            return b.position.Y > groesse.Height;
        }

        private bool KollidiertMitRechterWand(Ball b)
        {
            return b.position.X > groesse.Width;
        }

        private bool KollidiertMitLinkerWand(Ball b)
        {
            return b.position.X < 0;
        }

        public List<Ball> HoleBaelle()
        {
            return baelle;
        }
    }
}

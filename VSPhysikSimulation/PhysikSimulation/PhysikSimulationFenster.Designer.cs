namespace PhysikSimulation
{
    partial class PhysikSimulationFenster
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbWelt = new System.Windows.Forms.PictureBox();
            this.btnSchritt = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbWelt)).BeginInit();
            this.SuspendLayout();
            // 
            // pbWelt
            // 
            this.pbWelt.Location = new System.Drawing.Point(12, 12);
            this.pbWelt.Name = "pbWelt";
            this.pbWelt.Size = new System.Drawing.Size(400, 400);
            this.pbWelt.TabIndex = 0;
            this.pbWelt.TabStop = false;
            this.pbWelt.Paint += new System.Windows.Forms.PaintEventHandler(this.pbWelt_Paint);
            // 
            // btnSchritt
            // 
            this.btnSchritt.Location = new System.Drawing.Point(21, 418);
            this.btnSchritt.Name = "btnSchritt";
            this.btnSchritt.Size = new System.Drawing.Size(75, 23);
            this.btnSchritt.TabIndex = 1;
            this.btnSchritt.Text = "Schritt";
            this.btnSchritt.UseVisualStyleBackColor = true;
            this.btnSchritt.Click += new System.EventHandler(this.btnSchritt_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(103, 418);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // PhysikSimulationFenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 450);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSchritt);
            this.Controls.Add(this.pbWelt);
            this.Name = "PhysikSimulationFenster";
            this.Text = "Physik Simulation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PhysikSimulationFenster_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbWelt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbWelt;
        private System.Windows.Forms.Button btnSchritt;
        private System.Windows.Forms.Button btnStart;
    }
}


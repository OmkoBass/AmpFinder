namespace AmpFinder
{
    partial class window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ComponentPanel = new MetroFramework.Controls.MetroPanel();
            this.voltgen = new MetroFramework.Controls.MetroLabel();
            this.ampgen = new MetroFramework.Controls.MetroLabel();
            this.cap = new MetroFramework.Controls.MetroLabel();
            this.res = new MetroFramework.Controls.MetroLabel();
            this.VoltGeneratorToggle = new MetroFramework.Controls.MetroToggle();
            this.AmpGeneratorToggle = new MetroFramework.Controls.MetroToggle();
            this.CapacitorToggle = new MetroFramework.Controls.MetroToggle();
            this.ResistorToggle = new MetroFramework.Controls.MetroToggle();
            this.CircuitDraw = new System.Windows.Forms.PictureBox();
            this.ComponentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CircuitDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // ComponentPanel
            // 
            this.ComponentPanel.Controls.Add(this.voltgen);
            this.ComponentPanel.Controls.Add(this.ampgen);
            this.ComponentPanel.Controls.Add(this.cap);
            this.ComponentPanel.Controls.Add(this.res);
            this.ComponentPanel.Controls.Add(this.VoltGeneratorToggle);
            this.ComponentPanel.Controls.Add(this.AmpGeneratorToggle);
            this.ComponentPanel.Controls.Add(this.CapacitorToggle);
            this.ComponentPanel.Controls.Add(this.ResistorToggle);
            this.ComponentPanel.HorizontalScrollbarBarColor = true;
            this.ComponentPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.ComponentPanel.HorizontalScrollbarSize = 10;
            this.ComponentPanel.Location = new System.Drawing.Point(12, 12);
            this.ComponentPanel.Name = "ComponentPanel";
            this.ComponentPanel.Size = new System.Drawing.Size(135, 729);
            this.ComponentPanel.TabIndex = 0;
            this.ComponentPanel.VerticalScrollbarBarColor = true;
            this.ComponentPanel.VerticalScrollbarHighlightOnWheel = false;
            this.ComponentPanel.VerticalScrollbarSize = 10;
            // 
            // voltgen
            // 
            this.voltgen.AutoSize = true;
            this.voltgen.Location = new System.Drawing.Point(0, 228);
            this.voltgen.Name = "voltgen";
            this.voltgen.Size = new System.Drawing.Size(99, 20);
            this.voltgen.TabIndex = 8;
            this.voltgen.Text = "Volt Generator";
            // 
            // ampgen
            // 
            this.ampgen.AutoSize = true;
            this.ampgen.Location = new System.Drawing.Point(3, 153);
            this.ampgen.Name = "ampgen";
            this.ampgen.Size = new System.Drawing.Size(105, 20);
            this.ampgen.TabIndex = 7;
            this.ampgen.Text = "Amp Generator";
            // 
            // cap
            // 
            this.cap.AutoSize = true;
            this.cap.Location = new System.Drawing.Point(3, 78);
            this.cap.Name = "cap";
            this.cap.Size = new System.Drawing.Size(67, 20);
            this.cap.TabIndex = 6;
            this.cap.Text = "Capacitor";
            // 
            // res
            // 
            this.res.AutoSize = true;
            this.res.Location = new System.Drawing.Point(3, 3);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(57, 20);
            this.res.TabIndex = 1;
            this.res.Text = "Resistor";
            // 
            // VoltGeneratorToggle
            // 
            this.VoltGeneratorToggle.AutoSize = true;
            this.VoltGeneratorToggle.Location = new System.Drawing.Point(3, 251);
            this.VoltGeneratorToggle.Name = "VoltGeneratorToggle";
            this.VoltGeneratorToggle.Size = new System.Drawing.Size(80, 21);
            this.VoltGeneratorToggle.TabIndex = 5;
            this.VoltGeneratorToggle.Text = "Off";
            this.VoltGeneratorToggle.UseVisualStyleBackColor = true;
            this.VoltGeneratorToggle.CheckedChanged += new System.EventHandler(this.VoltGeneratorToggle_CheckedChanged);
            // 
            // AmpGeneratorToggle
            // 
            this.AmpGeneratorToggle.AutoSize = true;
            this.AmpGeneratorToggle.Location = new System.Drawing.Point(3, 176);
            this.AmpGeneratorToggle.Name = "AmpGeneratorToggle";
            this.AmpGeneratorToggle.Size = new System.Drawing.Size(80, 21);
            this.AmpGeneratorToggle.TabIndex = 4;
            this.AmpGeneratorToggle.Text = "Off";
            this.AmpGeneratorToggle.UseVisualStyleBackColor = true;
            this.AmpGeneratorToggle.CheckedChanged += new System.EventHandler(this.AmpGeneratorToggle_CheckedChanged);
            // 
            // CapacitorToggle
            // 
            this.CapacitorToggle.AutoSize = true;
            this.CapacitorToggle.Location = new System.Drawing.Point(3, 101);
            this.CapacitorToggle.Name = "CapacitorToggle";
            this.CapacitorToggle.Size = new System.Drawing.Size(80, 21);
            this.CapacitorToggle.TabIndex = 3;
            this.CapacitorToggle.Text = "Off";
            this.CapacitorToggle.UseVisualStyleBackColor = true;
            this.CapacitorToggle.CheckedChanged += new System.EventHandler(this.CapacitorToggle_CheckedChanged);
            // 
            // ResistorToggle
            // 
            this.ResistorToggle.AutoSize = true;
            this.ResistorToggle.Location = new System.Drawing.Point(3, 26);
            this.ResistorToggle.Name = "ResistorToggle";
            this.ResistorToggle.Size = new System.Drawing.Size(80, 21);
            this.ResistorToggle.TabIndex = 2;
            this.ResistorToggle.Text = "Off";
            this.ResistorToggle.UseVisualStyleBackColor = true;
            this.ResistorToggle.CheckedChanged += new System.EventHandler(this.ResistorToggle_CheckedChanged);
            // 
            // CircuitDraw
            // 
            this.CircuitDraw.BackColor = System.Drawing.Color.White;
            this.CircuitDraw.Location = new System.Drawing.Point(160, 12);
            this.CircuitDraw.Name = "CircuitDraw";
            this.CircuitDraw.Size = new System.Drawing.Size(1010, 729);
            this.CircuitDraw.TabIndex = 1;
            this.CircuitDraw.TabStop = false;
            this.CircuitDraw.Click += new System.EventHandler(this.CircuitDraw_Click);
            this.CircuitDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.CircuitDraw_Paint);
            // 
            // window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.CircuitDraw);
            this.Controls.Add(this.ComponentPanel);
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "window";
            this.Text = "AmpFinder";
            this.ComponentPanel.ResumeLayout(false);
            this.ComponentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CircuitDraw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected MetroFramework.Controls.MetroPanel ComponentPanel;
        private MetroFramework.Controls.MetroToggle ResistorToggle;
        private MetroFramework.Controls.MetroToggle VoltGeneratorToggle;
        private MetroFramework.Controls.MetroToggle AmpGeneratorToggle;
        private MetroFramework.Controls.MetroToggle CapacitorToggle;
        private MetroFramework.Controls.MetroLabel voltgen;
        private MetroFramework.Controls.MetroLabel ampgen;
        private MetroFramework.Controls.MetroLabel cap;
        private MetroFramework.Controls.MetroLabel res;
        private System.Windows.Forms.PictureBox CircuitDraw;
    }
}


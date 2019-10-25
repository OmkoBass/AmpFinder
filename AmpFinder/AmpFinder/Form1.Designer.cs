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
            this.components = new System.ComponentModel.Container();
            this.ComponentPanel = new MetroFramework.Controls.MetroPanel();
            this.btnRotate = new System.Windows.Forms.Button();
            this.btnCursor = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.voltgen = new MetroFramework.Controls.MetroLabel();
            this.ampgen = new MetroFramework.Controls.MetroLabel();
            this.cap = new MetroFramework.Controls.MetroLabel();
            this.res = new MetroFramework.Controls.MetroLabel();
            this.VoltGeneratorToggle = new MetroFramework.Controls.MetroToggle();
            this.AmpGeneratorToggle = new MetroFramework.Controls.MetroToggle();
            this.CapacitorToggle = new MetroFramework.Controls.MetroToggle();
            this.ResistorToggle = new MetroFramework.Controls.MetroToggle();
            this.CircuitDraw = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DrawTimer = new System.Windows.Forms.Timer(this.components);
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.lblValue = new MetroFramework.Controls.MetroLabel();
            this.ComponentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CircuitDraw)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComponentPanel
            // 
            this.ComponentPanel.Controls.Add(this.btnRotate);
            this.ComponentPanel.Controls.Add(this.btnCursor);
            this.ComponentPanel.Controls.Add(this.btnConnect);
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
            this.ComponentPanel.HorizontalScrollbarSize = 8;
            this.ComponentPanel.Location = new System.Drawing.Point(11, 26);
            this.ComponentPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ComponentPanel.Name = "ComponentPanel";
            this.ComponentPanel.Size = new System.Drawing.Size(109, 654);
            this.ComponentPanel.TabIndex = 0;
            this.ComponentPanel.VerticalScrollbarBarColor = true;
            this.ComponentPanel.VerticalScrollbarHighlightOnWheel = false;
            this.ComponentPanel.VerticalScrollbarSize = 8;
            // 
            // btnRotate
            // 
            this.btnRotate.Location = new System.Drawing.Point(0, 299);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(56, 67);
            this.btnRotate.TabIndex = 14;
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.BtnRotate_Click);
            // 
            // btnCursor
            // 
            this.btnCursor.Location = new System.Drawing.Point(0, 226);
            this.btnCursor.Name = "btnCursor";
            this.btnCursor.Size = new System.Drawing.Size(56, 67);
            this.btnCursor.TabIndex = 13;
            this.btnCursor.UseVisualStyleBackColor = true;
            this.btnCursor.Click += new System.EventHandler(this.BtnCursor_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(54, 226);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(56, 67);
            this.btnConnect.TabIndex = 12;
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // voltgen
            // 
            this.voltgen.AutoSize = true;
            this.voltgen.Location = new System.Drawing.Point(0, 185);
            this.voltgen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.voltgen.Name = "voltgen";
            this.voltgen.Size = new System.Drawing.Size(94, 19);
            this.voltgen.TabIndex = 8;
            this.voltgen.Text = "Volt Generator";
            // 
            // ampgen
            // 
            this.ampgen.AutoSize = true;
            this.ampgen.Location = new System.Drawing.Point(2, 124);
            this.ampgen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ampgen.Name = "ampgen";
            this.ampgen.Size = new System.Drawing.Size(101, 19);
            this.ampgen.TabIndex = 7;
            this.ampgen.Text = "Amp Generator";
            // 
            // cap
            // 
            this.cap.AutoSize = true;
            this.cap.Location = new System.Drawing.Point(2, 63);
            this.cap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cap.Name = "cap";
            this.cap.Size = new System.Drawing.Size(66, 19);
            this.cap.TabIndex = 6;
            this.cap.Text = "Capacitor";
            // 
            // res
            // 
            this.res.AutoSize = true;
            this.res.Location = new System.Drawing.Point(2, 2);
            this.res.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(54, 19);
            this.res.TabIndex = 1;
            this.res.Text = "Resistor";
            // 
            // VoltGeneratorToggle
            // 
            this.VoltGeneratorToggle.AutoSize = true;
            this.VoltGeneratorToggle.Location = new System.Drawing.Point(2, 204);
            this.VoltGeneratorToggle.Margin = new System.Windows.Forms.Padding(2);
            this.VoltGeneratorToggle.Name = "VoltGeneratorToggle";
            this.VoltGeneratorToggle.Size = new System.Drawing.Size(80, 17);
            this.VoltGeneratorToggle.TabIndex = 5;
            this.VoltGeneratorToggle.Text = "Off";
            this.VoltGeneratorToggle.UseVisualStyleBackColor = true;
            this.VoltGeneratorToggle.CheckedChanged += new System.EventHandler(this.VoltGeneratorToggle_CheckedChanged);
            // 
            // AmpGeneratorToggle
            // 
            this.AmpGeneratorToggle.AutoSize = true;
            this.AmpGeneratorToggle.Location = new System.Drawing.Point(2, 143);
            this.AmpGeneratorToggle.Margin = new System.Windows.Forms.Padding(2);
            this.AmpGeneratorToggle.Name = "AmpGeneratorToggle";
            this.AmpGeneratorToggle.Size = new System.Drawing.Size(80, 17);
            this.AmpGeneratorToggle.TabIndex = 4;
            this.AmpGeneratorToggle.Text = "Off";
            this.AmpGeneratorToggle.UseVisualStyleBackColor = true;
            this.AmpGeneratorToggle.CheckedChanged += new System.EventHandler(this.AmpGeneratorToggle_CheckedChanged);
            // 
            // CapacitorToggle
            // 
            this.CapacitorToggle.AutoSize = true;
            this.CapacitorToggle.Location = new System.Drawing.Point(2, 82);
            this.CapacitorToggle.Margin = new System.Windows.Forms.Padding(2);
            this.CapacitorToggle.Name = "CapacitorToggle";
            this.CapacitorToggle.Size = new System.Drawing.Size(80, 17);
            this.CapacitorToggle.TabIndex = 3;
            this.CapacitorToggle.Text = "Off";
            this.CapacitorToggle.UseVisualStyleBackColor = true;
            this.CapacitorToggle.CheckedChanged += new System.EventHandler(this.CapacitorToggle_CheckedChanged);
            // 
            // ResistorToggle
            // 
            this.ResistorToggle.AutoSize = true;
            this.ResistorToggle.Location = new System.Drawing.Point(2, 21);
            this.ResistorToggle.Margin = new System.Windows.Forms.Padding(2);
            this.ResistorToggle.Name = "ResistorToggle";
            this.ResistorToggle.Size = new System.Drawing.Size(80, 17);
            this.ResistorToggle.TabIndex = 2;
            this.ResistorToggle.Text = "Off";
            this.ResistorToggle.UseVisualStyleBackColor = true;
            this.ResistorToggle.CheckedChanged += new System.EventHandler(this.ResistorToggle_CheckedChanged);
            // 
            // CircuitDraw
            // 
            this.CircuitDraw.BackColor = System.Drawing.Color.White;
            this.CircuitDraw.Location = new System.Drawing.Point(126, 26);
            this.CircuitDraw.Margin = new System.Windows.Forms.Padding(2);
            this.CircuitDraw.Name = "CircuitDraw";
            this.CircuitDraw.Size = new System.Drawing.Size(761, 654);
            this.CircuitDraw.TabIndex = 1;
            this.CircuitDraw.TabStop = false;
            this.CircuitDraw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CircuitDraw_MouseClick);
            this.CircuitDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CircuitDraw_MouseMove);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1,
            this.exitToolStripMenuItem2});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.newToolStripMenuItem.Text = "Project";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.projectToolStripMenuItem.Text = "New";
            this.projectToolStripMenuItem.Click += new System.EventHandler(this.ProjectToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveToolStripMenuItem.Text = "Load";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(109, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem1.Text = "Save as";
            // 
            // exitToolStripMenuItem2
            // 
            this.exitToolStripMenuItem2.Name = "exitToolStripMenuItem2";
            this.exitToolStripMenuItem2.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem2.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // DrawTimer
            // 
            this.DrawTimer.Interval = 50;
            this.DrawTimer.Tick += new System.EventHandler(this.DrawTimer_Tick);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(892, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 0);
            this.lblName.TabIndex = 4;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(892, 89);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(0, 0);
            this.lblValue.TabIndex = 6;
            // 
            // window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 691);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.CircuitDraw);
            this.Controls.Add(this.ComponentPanel);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "window";
            this.Text = "AmpFinder";
            this.ComponentPanel.ResumeLayout(false);
            this.ComponentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CircuitDraw)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected MetroFramework.Controls.MetroPanel ComponentPanel;
        private MetroFramework.Controls.MetroLabel voltgen;
        private MetroFramework.Controls.MetroLabel ampgen;
        private MetroFramework.Controls.MetroLabel cap;
        private MetroFramework.Controls.MetroLabel res;
        private System.Windows.Forms.PictureBox CircuitDraw;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Timer DrawTimer;
        internal MetroFramework.Controls.MetroToggle ResistorToggle;
        internal MetroFramework.Controls.MetroToggle VoltGeneratorToggle;
        internal MetroFramework.Controls.MetroToggle AmpGeneratorToggle;
        internal MetroFramework.Controls.MetroToggle CapacitorToggle;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ToolStripSeparator saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem2;
        private System.Windows.Forms.Button btnCursor;
        private System.Windows.Forms.Button btnRotate;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroLabel lblValue;
    }
}


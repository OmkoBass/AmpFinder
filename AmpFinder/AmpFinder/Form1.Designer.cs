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
            this.edit = new MetroFramework.Controls.MetroLabel();
            this.EditToggle = new MetroFramework.Controls.MetroToggle();
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
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DrawTimer = new System.Windows.Forms.Timer(this.components);
            this.ComponentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CircuitDraw)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComponentPanel
            // 
            this.ComponentPanel.Controls.Add(this.edit);
            this.ComponentPanel.Controls.Add(this.EditToggle);
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
            // edit
            // 
            this.edit.AutoSize = true;
            this.edit.Location = new System.Drawing.Point(0, 244);
            this.edit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(31, 19);
            this.edit.TabIndex = 10;
            this.edit.Text = "Edit";
            // 
            // EditToggle
            // 
            this.EditToggle.AutoSize = true;
            this.EditToggle.Location = new System.Drawing.Point(2, 265);
            this.EditToggle.Margin = new System.Windows.Forms.Padding(2);
            this.EditToggle.Name = "EditToggle";
            this.EditToggle.Size = new System.Drawing.Size(80, 17);
            this.EditToggle.TabIndex = 9;
            this.EditToggle.Text = "Off";
            this.EditToggle.UseVisualStyleBackColor = true;
            this.EditToggle.CheckedChanged += new System.EventHandler(this.EditToggle_CheckedChanged);
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
            this.menuStrip1.Size = new System.Drawing.Size(898, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToolStripMenuItem,
            this.toolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.newToolStripMenuItem.Text = "New";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1,
            this.loadToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.newToolStripMenuItem1.Text = "New";
            this.newToolStripMenuItem1.Click += new System.EventHandler(this.NewToolStripMenuItem1_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(109, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
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
            this.DrawTimer.Tick += new System.EventHandler(this.DrawTimer_Tick);
            // 
            // window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 691);
            this.Controls.Add(this.CircuitDraw);
            this.Controls.Add(this.ComponentPanel);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(914, 730);
            this.MinimumSize = new System.Drawing.Size(914, 730);
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
        private MetroFramework.Controls.MetroToggle ResistorToggle;
        private MetroFramework.Controls.MetroToggle VoltGeneratorToggle;
        private MetroFramework.Controls.MetroToggle AmpGeneratorToggle;
        private MetroFramework.Controls.MetroToggle CapacitorToggle;
        private MetroFramework.Controls.MetroLabel voltgen;
        private MetroFramework.Controls.MetroLabel ampgen;
        private MetroFramework.Controls.MetroLabel cap;
        private MetroFramework.Controls.MetroLabel res;
        private System.Windows.Forms.PictureBox CircuitDraw;
        private MetroFramework.Controls.MetroLabel edit;
        private MetroFramework.Controls.MetroToggle EditToggle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.Timer DrawTimer;
    }
}


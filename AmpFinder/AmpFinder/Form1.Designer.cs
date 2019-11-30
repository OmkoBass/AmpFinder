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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(window));
            this.ComponentPanel = new MetroFramework.Controls.MetroPanel();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnVoltGenerator = new System.Windows.Forms.Button();
            this.btnAmpGenerator = new System.Windows.Forms.Button();
            this.btnCapacitor = new System.Windows.Forms.Button();
            this.btnResistor = new System.Windows.Forms.Button();
            this.btnRotate = new System.Windows.Forms.Button();
            this.btnCursor = new System.Windows.Forms.Button();
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
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.lblValue = new MetroFramework.Controls.MetroLabel();
            this.lblElementValue = new System.Windows.Forms.TextBox();
            this.btnChangeValue = new MetroFramework.Controls.MetroButton();
            this.ComponentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CircuitDraw)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComponentPanel
            // 
            this.ComponentPanel.Controls.Add(this.btnConnect);
            this.ComponentPanel.Controls.Add(this.btnVoltGenerator);
            this.ComponentPanel.Controls.Add(this.btnAmpGenerator);
            this.ComponentPanel.Controls.Add(this.btnCapacitor);
            this.ComponentPanel.Controls.Add(this.btnResistor);
            this.ComponentPanel.Controls.Add(this.btnRotate);
            this.ComponentPanel.Controls.Add(this.btnCursor);
            this.ComponentPanel.HorizontalScrollbarBarColor = true;
            this.ComponentPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.ComponentPanel.HorizontalScrollbarSize = 8;
            this.ComponentPanel.Location = new System.Drawing.Point(11, 26);
            this.ComponentPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ComponentPanel.Name = "ComponentPanel";
            this.ComponentPanel.Size = new System.Drawing.Size(139, 654);
            this.ComponentPanel.TabIndex = 0;
            this.ComponentPanel.VerticalScrollbarBarColor = true;
            this.ComponentPanel.VerticalScrollbarHighlightOnWheel = false;
            this.ComponentPanel.VerticalScrollbarSize = 8;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(8, 73);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(61, 67);
            this.btnConnect.TabIndex = 19;
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // btnVoltGenerator
            // 
            this.btnVoltGenerator.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltGenerator.Image")));
            this.btnVoltGenerator.Location = new System.Drawing.Point(78, 287);
            this.btnVoltGenerator.Name = "btnVoltGenerator";
            this.btnVoltGenerator.Size = new System.Drawing.Size(56, 67);
            this.btnVoltGenerator.TabIndex = 18;
            this.btnVoltGenerator.UseVisualStyleBackColor = true;
            // 
            // btnAmpGenerator
            // 
            this.btnAmpGenerator.Image = ((System.Drawing.Image)(resources.GetObject("btnAmpGenerator.Image")));
            this.btnAmpGenerator.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAmpGenerator.Location = new System.Drawing.Point(8, 287);
            this.btnAmpGenerator.Name = "btnAmpGenerator";
            this.btnAmpGenerator.Size = new System.Drawing.Size(64, 67);
            this.btnAmpGenerator.TabIndex = 17;
            this.btnAmpGenerator.UseVisualStyleBackColor = true;
            // 
            // btnCapacitor
            // 
            this.btnCapacitor.Image = ((System.Drawing.Image)(resources.GetObject("btnCapacitor.Image")));
            this.btnCapacitor.Location = new System.Drawing.Point(78, 214);
            this.btnCapacitor.Name = "btnCapacitor";
            this.btnCapacitor.Size = new System.Drawing.Size(56, 67);
            this.btnCapacitor.TabIndex = 16;
            this.btnCapacitor.UseVisualStyleBackColor = true;
            // 
            // btnResistor
            // 
            this.btnResistor.Image = ((System.Drawing.Image)(resources.GetObject("btnResistor.Image")));
            this.btnResistor.Location = new System.Drawing.Point(8, 214);
            this.btnResistor.Name = "btnResistor";
            this.btnResistor.Size = new System.Drawing.Size(64, 67);
            this.btnResistor.TabIndex = 15;
            this.btnResistor.UseVisualStyleBackColor = true;
            // 
            // btnRotate
            // 
            this.btnRotate.Image = ((System.Drawing.Image)(resources.GetObject("btnRotate.Image")));
            this.btnRotate.Location = new System.Drawing.Point(72, 0);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(62, 67);
            this.btnRotate.TabIndex = 14;
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.BtnRotate_Click);
            // 
            // btnCursor
            // 
            this.btnCursor.Image = ((System.Drawing.Image)(resources.GetObject("btnCursor.Image")));
            this.btnCursor.Location = new System.Drawing.Point(8, 0);
            this.btnCursor.Name = "btnCursor";
            this.btnCursor.Size = new System.Drawing.Size(61, 67);
            this.btnCursor.TabIndex = 13;
            this.btnCursor.UseVisualStyleBackColor = true;
            this.btnCursor.Click += new System.EventHandler(this.BtnCursor_Click);
            // 
            // CircuitDraw
            // 
            this.CircuitDraw.BackColor = System.Drawing.Color.White;
            this.CircuitDraw.Location = new System.Drawing.Point(154, 26);
            this.CircuitDraw.Margin = new System.Windows.Forms.Padding(2);
            this.CircuitDraw.Name = "CircuitDraw";
            this.CircuitDraw.Size = new System.Drawing.Size(732, 650);
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
            this.DrawTimer.Interval = 60;
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
            // lblElementValue
            // 
            this.lblElementValue.Location = new System.Drawing.Point(892, 129);
            this.lblElementValue.Name = "lblElementValue";
            this.lblElementValue.Size = new System.Drawing.Size(80, 20);
            this.lblElementValue.TabIndex = 7;
            // 
            // btnChangeValue
            // 
            this.btnChangeValue.Location = new System.Drawing.Point(892, 155);
            this.btnChangeValue.Name = "btnChangeValue";
            this.btnChangeValue.Size = new System.Drawing.Size(75, 23);
            this.btnChangeValue.TabIndex = 8;
            this.btnChangeValue.Text = "Change";
            this.btnChangeValue.Click += new System.EventHandler(this.BtnChangeValue_Click);
            // 
            // window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 691);
            this.Controls.Add(this.btnChangeValue);
            this.Controls.Add(this.lblElementValue);
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
            ((System.ComponentModel.ISupportInitialize)(this.CircuitDraw)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected MetroFramework.Controls.MetroPanel ComponentPanel;
        private System.Windows.Forms.PictureBox CircuitDraw;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Timer DrawTimer;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem2;
        private System.Windows.Forms.Button btnCursor;
        private System.Windows.Forms.Button btnRotate;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroLabel lblValue;
        private System.Windows.Forms.Button btnVoltGenerator;
        private System.Windows.Forms.Button btnAmpGenerator;
        private System.Windows.Forms.Button btnCapacitor;
        private System.Windows.Forms.Button btnResistor;
        private System.Windows.Forms.TextBox lblElementValue;
        private MetroFramework.Controls.MetroButton btnChangeValue;
        private System.Windows.Forms.Button btnConnect;
    }
}


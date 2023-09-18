namespace ClockUTC
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelLocalTime = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBoxLocal = new System.Windows.Forms.GroupBox();
            this.labelLocalDate = new System.Windows.Forms.Label();
            this.groupBoxUTC = new System.Windows.Forms.GroupBox();
            this.labelUTCDate = new System.Windows.Forms.Label();
            this.labelUTCTime = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.callsignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.callsignToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelCallsign = new System.Windows.Forms.Label();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxLocal.SuspendLayout();
            this.groupBoxUTC.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelLocalTime
            // 
            this.labelLocalTime.AutoSize = true;
            this.labelLocalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocalTime.Location = new System.Drawing.Point(8, 20);
            this.labelLocalTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLocalTime.Name = "labelLocalTime";
            this.labelLocalTime.Size = new System.Drawing.Size(182, 46);
            this.labelLocalTime.TabIndex = 0;
            this.labelLocalTime.Text = "00:00:00";
            this.labelLocalTime.DoubleClick += new System.EventHandler(this.labelLocalTime_DoubleClick);
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // groupBoxLocal
            // 
            this.groupBoxLocal.Controls.Add(this.labelLocalDate);
            this.groupBoxLocal.Controls.Add(this.labelLocalTime);
            this.groupBoxLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLocal.Location = new System.Drawing.Point(16, 112);
            this.groupBoxLocal.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxLocal.Name = "groupBoxLocal";
            this.groupBoxLocal.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxLocal.Size = new System.Drawing.Size(256, 105);
            this.groupBoxLocal.TabIndex = 1;
            this.groupBoxLocal.TabStop = false;
            this.groupBoxLocal.Text = "Local Time";
            this.groupBoxLocal.DoubleClick += new System.EventHandler(this.groupBoxLocal_DoubleClick);
            // 
            // labelLocalDate
            // 
            this.labelLocalDate.AutoSize = true;
            this.labelLocalDate.Location = new System.Drawing.Point(8, 76);
            this.labelLocalDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLocalDate.Name = "labelLocalDate";
            this.labelLocalDate.Size = new System.Drawing.Size(41, 13);
            this.labelLocalDate.TabIndex = 1;
            this.labelLocalDate.Text = "label1";
            this.labelLocalDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelLocalDate.DoubleClick += new System.EventHandler(this.labelLocalDate_DoubleClick);
            // 
            // groupBoxUTC
            // 
            this.groupBoxUTC.Controls.Add(this.labelUTCDate);
            this.groupBoxUTC.Controls.Add(this.labelUTCTime);
            this.groupBoxUTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUTC.Location = new System.Drawing.Point(280, 112);
            this.groupBoxUTC.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxUTC.Name = "groupBoxUTC";
            this.groupBoxUTC.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxUTC.Size = new System.Drawing.Size(256, 105);
            this.groupBoxUTC.TabIndex = 2;
            this.groupBoxUTC.TabStop = false;
            this.groupBoxUTC.Text = "UTC Time";
            this.groupBoxUTC.DoubleClick += new System.EventHandler(this.groupBoxUTC_DoubleClick);
            // 
            // labelUTCDate
            // 
            this.labelUTCDate.AutoSize = true;
            this.labelUTCDate.Location = new System.Drawing.Point(8, 76);
            this.labelUTCDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUTCDate.Name = "labelUTCDate";
            this.labelUTCDate.Size = new System.Drawing.Size(41, 13);
            this.labelUTCDate.TabIndex = 1;
            this.labelUTCDate.Text = "label1";
            this.labelUTCDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelUTCDate.DoubleClick += new System.EventHandler(this.labelUTCDate_DoubleClick);
            // 
            // labelUTCTime
            // 
            this.labelUTCTime.AutoSize = true;
            this.labelUTCTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUTCTime.Location = new System.Drawing.Point(8, 20);
            this.labelUTCTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUTCTime.Name = "labelUTCTime";
            this.labelUTCTime.Size = new System.Drawing.Size(182, 46);
            this.labelUTCTime.TabIndex = 0;
            this.labelUTCTime.Text = "00:00:00";
            this.labelUTCTime.DoubleClick += new System.EventHandler(this.labelUTCTime_DoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.callsignToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(549, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // callsignToolStripMenuItem
            // 
            this.callsignToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.callsignToolStripMenuItem.Name = "callsignToolStripMenuItem";
            this.callsignToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.callsignToolStripMenuItem.Text = "&File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.callsignToolStripMenuItem1,
            this.colorsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.settingsToolStripMenuItem.Text = "&Settings";
            // 
            // callsignToolStripMenuItem1
            // 
            this.callsignToolStripMenuItem1.Name = "callsignToolStripMenuItem1";
            this.callsignToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.callsignToolStripMenuItem1.Text = "&Callsign";
            this.callsignToolStripMenuItem1.Click += new System.EventHandler(this.callsignToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // labelCallsign
            // 
            this.labelCallsign.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCallsign.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCallsign.Location = new System.Drawing.Point(0, 24);
            this.labelCallsign.Name = "labelCallsign";
            this.labelCallsign.Size = new System.Drawing.Size(549, 81);
            this.labelCallsign.TabIndex = 4;
            this.labelCallsign.Text = "label1";
            this.labelCallsign.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelCallsign.DoubleClick += new System.EventHandler(this.labelCallsign_DoubleClick);
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundToolStripMenuItem,
            this.textColorToolStripMenuItem});
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorsToolStripMenuItem.Text = "Colors";
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.backgroundToolStripMenuItem.Text = "Background";
            this.backgroundToolStripMenuItem.Click += new System.EventHandler(this.backgroundToolStripMenuItem_Click);
            // 
            // textColorToolStripMenuItem
            // 
            this.textColorToolStripMenuItem.Name = "textColorToolStripMenuItem";
            this.textColorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.textColorToolStripMenuItem.Text = "TextColor";
            this.textColorToolStripMenuItem.Click += new System.EventHandler(this.textColorToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 230);
            this.Controls.Add(this.labelCallsign);
            this.Controls.Add(this.groupBoxUTC);
            this.Controls.Add(this.groupBoxLocal);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(50, 50);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Clock UTC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.groupBoxLocal.ResumeLayout(false);
            this.groupBoxLocal.PerformLayout();
            this.groupBoxUTC.ResumeLayout(false);
            this.groupBoxUTC.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLocalTime;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.GroupBox groupBoxLocal;
        private System.Windows.Forms.Label labelLocalDate;
        private System.Windows.Forms.GroupBox groupBoxUTC;
        private System.Windows.Forms.Label labelUTCDate;
        private System.Windows.Forms.Label labelUTCTime;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem callsignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem callsignToolStripMenuItem1;
        private System.Windows.Forms.Label labelCallsign;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textColorToolStripMenuItem;
    }
}


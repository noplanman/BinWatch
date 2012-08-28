namespace BinWatch
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.menuOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStyle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStyleGreen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStyleRed = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStyleBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.menuOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "off");
            this.imgList.Images.SetKeyName(1, "red");
            this.imgList.Images.SetKeyName(2, "blue");
            this.imgList.Images.SetKeyName(3, "green");
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // menuOptions
            // 
            this.menuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStyle,
            this.toolStripSeparator1,
            this.menuExit});
            this.menuOptions.Name = "contextMenuStrip1";
            this.menuOptions.Size = new System.Drawing.Size(110, 54);
            // 
            // menuStyle
            // 
            this.menuStyle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStyleGreen,
            this.menuStyleRed,
            this.menuStyleBlue});
            this.menuStyle.Name = "menuStyle";
            this.menuStyle.Size = new System.Drawing.Size(109, 22);
            this.menuStyle.Text = "Style";
            // 
            // menuStyleGreen
            // 
            this.menuStyleGreen.Checked = true;
            this.menuStyleGreen.CheckOnClick = true;
            this.menuStyleGreen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuStyleGreen.Name = "menuStyleGreen";
            this.menuStyleGreen.Size = new System.Drawing.Size(160, 22);
            this.menuStyleGreen.Text = "Green (Default)";
            this.menuStyleGreen.Click += new System.EventHandler(this.greenDefaultToolStripMenuItem_Click);
            // 
            // menuStyleRed
            // 
            this.menuStyleRed.CheckOnClick = true;
            this.menuStyleRed.Name = "menuStyleRed";
            this.menuStyleRed.Size = new System.Drawing.Size(160, 22);
            this.menuStyleRed.Text = "Red";
            this.menuStyleRed.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // menuStyleBlue
            // 
            this.menuStyleBlue.CheckOnClick = true;
            this.menuStyleBlue.Name = "menuStyleBlue";
            this.menuStyleBlue.Size = new System.Drawing.Size(160, 22);
            this.menuStyleBlue.Text = "Blue";
            this.menuStyleBlue.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(106, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(109, 22);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.Transparent;
            this.pnlForm.BackgroundImage = global::BinWatch.Properties.Resources.bg;
            this.pnlForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.ForeColor = System.Drawing.Color.Transparent;
            this.pnlForm.Location = new System.Drawing.Point(0, 0);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(104, 74);
            this.pnlForm.TabIndex = 1;
            this.pnlForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlForm_MouseDown);
            this.pnlForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlForm_MouseMove);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(104, 74);
            this.ContextMenuStrip = this.menuOptions;
            this.ControlBox = false;
            this.Controls.Add(this.pnlForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(104, 74);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(104, 74);
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "BinWatch";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.ContextMenuStrip menuOptions;
        private System.Windows.Forms.ToolStripMenuItem menuStyle;
        private System.Windows.Forms.ToolStripMenuItem menuStyleGreen;
        private System.Windows.Forms.ToolStripMenuItem menuStyleRed;
        private System.Windows.Forms.ToolStripMenuItem menuStyleBlue;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.ImageList imgList;
    }
}


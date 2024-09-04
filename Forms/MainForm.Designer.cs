namespace LoanCalculator
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
            this.WindowElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ContextMenuStrip = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsLight = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDark = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Step = new System.Windows.Forms.Timer(this.components);
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdvanceLoan = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnSimpleLoan = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // WindowElipse
            // 
            this.WindowElipse.BorderRadius = 8;
            this.WindowElipse.TargetControl = this;
            // 
            // ContextMenuStrip
            // 
            this.ContextMenuStrip.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeToolStripMenuItem,
            this.historyToolStripMenuItem});
            this.ContextMenuStrip.Name = "ContextMenuStrip";
            this.ContextMenuStrip.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ContextMenuStrip.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.ContextMenuStrip.RenderStyle.ColorTable = null;
            this.ContextMenuStrip.RenderStyle.RoundedEdges = true;
            this.ContextMenuStrip.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.ContextMenuStrip.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ContextMenuStrip.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.ContextMenuStrip.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.ContextMenuStrip.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.ContextMenuStrip.Size = new System.Drawing.Size(131, 52);
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsLight,
            this.cmsDark});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // cmsLight
            // 
            this.cmsLight.Name = "cmsLight";
            this.cmsLight.Size = new System.Drawing.Size(114, 24);
            this.cmsLight.Text = "Light";
            this.cmsLight.Click += new System.EventHandler(this.cmsLight_Click);
            // 
            // cmsDark
            // 
            this.cmsDark.Name = "cmsDark";
            this.cmsDark.Size = new System.Drawing.Size(114, 24);
            this.cmsDark.Text = "Dark";
            this.cmsDark.Click += new System.EventHandler(this.cmsDark_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Animated = true;
            this.btnClose.BorderRadius = 5;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(143)))), ((int)(((byte)(239)))));
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(69)))), ((int)(((byte)(125)))));
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(743, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 29);
            this.btnClose.TabIndex = 5;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Animated = true;
            this.btnMinimize.BorderRadius = 5;
            this.btnMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMinimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(143)))), ((int)(((byte)(239)))));
            this.btnMinimize.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(69)))), ((int)(((byte)(125)))));
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(692, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(45, 29);
            this.btnMinimize.TabIndex = 5;
            // 
            // DragControl1
            // 
            this.DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl1.TargetControl = this;
            this.DragControl1.UseTransparentDrag = true;
            // 
            // DragControl2
            // 
            this.DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl2.TargetControl = this.guna2PictureBox1;
            this.DragControl2.UseTransparentDrag = true;
            // 
            // Step
            // 
            this.Step.Enabled = true;
            this.Step.Tick += new System.EventHandler(this.Step_Tick);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // btnAdvanceLoan
            // 
            this.btnAdvanceLoan.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAdvanceLoan.HoverState.Image = global::LoanCalculator.Properties.Resources._2;
            this.btnAdvanceLoan.HoverState.ImageSize = new System.Drawing.Size(300, 300);
            this.btnAdvanceLoan.Image = global::LoanCalculator.Properties.Resources._2;
            this.btnAdvanceLoan.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAdvanceLoan.ImageRotate = 0F;
            this.btnAdvanceLoan.ImageSize = new System.Drawing.Size(250, 250);
            this.btnAdvanceLoan.Location = new System.Drawing.Point(398, 248);
            this.btnAdvanceLoan.Name = "btnAdvanceLoan";
            this.btnAdvanceLoan.PressedState.Image = global::LoanCalculator.Properties.Resources._2;
            this.btnAdvanceLoan.PressedState.ImageSize = new System.Drawing.Size(350, 350);
            this.btnAdvanceLoan.Size = new System.Drawing.Size(204, 178);
            this.btnAdvanceLoan.TabIndex = 4;
            this.btnAdvanceLoan.Click += new System.EventHandler(this.btnAdvanceLoan_Click);
            // 
            // btnSimpleLoan
            // 
            this.btnSimpleLoan.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSimpleLoan.HoverState.Image = global::LoanCalculator.Properties.Resources._3;
            this.btnSimpleLoan.HoverState.ImageSize = new System.Drawing.Size(250, 250);
            this.btnSimpleLoan.Image = global::LoanCalculator.Properties.Resources._3;
            this.btnSimpleLoan.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSimpleLoan.ImageRotate = 0F;
            this.btnSimpleLoan.ImageSize = new System.Drawing.Size(200, 200);
            this.btnSimpleLoan.Location = new System.Drawing.Point(188, 248);
            this.btnSimpleLoan.Name = "btnSimpleLoan";
            this.btnSimpleLoan.PressedState.Image = global::LoanCalculator.Properties.Resources._3;
            this.btnSimpleLoan.PressedState.ImageSize = new System.Drawing.Size(260, 260);
            this.btnSimpleLoan.Size = new System.Drawing.Size(204, 178);
            this.btnSimpleLoan.TabIndex = 3;
            this.btnSimpleLoan.Click += new System.EventHandler(this.btnSimpleLoan_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.ContextMenuStrip = this.ContextMenuStrip;
            this.guna2PictureBox1.Image = global::LoanCalculator.Properties.Resources.loan;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(267, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(264, 265);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdvanceLoan);
            this.Controls.Add(this.btnSimpleLoan);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse WindowElipse;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ImageButton btnSimpleLoan;
        private Guna.UI2.WinForms.Guna2ImageButton btnAdvanceLoan;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimize;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2DragControl DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl DragControl2;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmsLight;
        private System.Windows.Forms.ToolStripMenuItem cmsDark;
        private System.Windows.Forms.Timer Step;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
    }
}


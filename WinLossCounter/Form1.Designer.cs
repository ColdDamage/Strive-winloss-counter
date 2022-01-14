
namespace WinLossCounter
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.customLabel6 = new WinLossCounter.CustomLabel();
            this.customLabel5 = new WinLossCounter.CustomLabel();
            this.LossesCount = new WinLossCounter.CustomLabel();
            this.WinsCount = new WinLossCounter.CustomLabel();
            this.WinRate = new WinLossCounter.CustomLabel();
            this.customLabel4 = new WinLossCounter.CustomLabel();
            this.customLabel3 = new WinLossCounter.CustomLabel();
            this.customLabel2 = new WinLossCounter.CustomLabel();
            this.chrLabel = new WinLossCounter.CustomLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sPanel2 = new WinLossCounter.SPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.colorOrange = new System.Windows.Forms.Panel();
            this.colorBlack = new System.Windows.Forms.Panel();
            this.colorViolet = new System.Windows.Forms.Panel();
            this.colorGreen = new System.Windows.Forms.Panel();
            this.colorBlue = new System.Windows.Forms.Panel();
            this.colorRed = new System.Windows.Forms.Panel();
            this.sPanel1 = new WinLossCounter.SPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.sPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.sPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.LossesCount);
            this.panel1.Controls.Add(this.WinsCount);
            this.panel1.Controls.Add(this.WinRate);
            this.panel1.Controls.Add(this.customLabel4);
            this.panel1.Controls.Add(this.customLabel3);
            this.panel1.Controls.Add(this.customLabel2);
            this.panel1.Controls.Add(this.chrLabel);
            this.panel1.Location = new System.Drawing.Point(333, 692);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 162);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.customLabel6);
            this.panel3.Controls.Add(this.customLabel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 126);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 36);
            this.panel3.TabIndex = 20;
            // 
            // customLabel6
            // 
            this.customLabel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.customLabel6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel6.Location = new System.Drawing.Point(0, 0);
            this.customLabel6.Name = "customLabel6";
            this.customLabel6.Size = new System.Drawing.Size(300, 19);
            this.customLabel6.TabIndex = 17;
            this.customLabel6.Text = "Show controls: F2";
            this.customLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.customLabel6.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // customLabel5
            // 
            this.customLabel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.customLabel5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel5.Location = new System.Drawing.Point(0, 17);
            this.customLabel5.Name = "customLabel5";
            this.customLabel5.Size = new System.Drawing.Size(300, 19);
            this.customLabel5.TabIndex = 16;
            this.customLabel5.Text = "Character/Color select: F3";
            this.customLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.customLabel5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // LossesCount
            // 
            this.LossesCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LossesCount.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LossesCount.Location = new System.Drawing.Point(177, 90);
            this.LossesCount.Name = "LossesCount";
            this.LossesCount.Size = new System.Drawing.Size(103, 24);
            this.LossesCount.TabIndex = 19;
            this.LossesCount.Text = "0";
            this.LossesCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LossesCount.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // WinsCount
            // 
            this.WinsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WinsCount.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinsCount.Location = new System.Drawing.Point(158, 66);
            this.WinsCount.Name = "WinsCount";
            this.WinsCount.Size = new System.Drawing.Size(122, 24);
            this.WinsCount.TabIndex = 18;
            this.WinsCount.Text = "0";
            this.WinsCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.WinsCount.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // WinRate
            // 
            this.WinRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WinRate.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinRate.Location = new System.Drawing.Point(186, 42);
            this.WinRate.Name = "WinRate";
            this.WinRate.Size = new System.Drawing.Size(94, 24);
            this.WinRate.TabIndex = 17;
            this.WinRate.Text = "0%";
            this.WinRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.WinRate.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // customLabel4
            // 
            this.customLabel4.AutoSize = true;
            this.customLabel4.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel4.Location = new System.Drawing.Point(29, 90);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(94, 24);
            this.customLabel4.TabIndex = 15;
            this.customLabel4.Text = "Losses:";
            this.customLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customLabel4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // customLabel3
            // 
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel3.Location = new System.Drawing.Point(29, 66);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(70, 24);
            this.customLabel3.TabIndex = 14;
            this.customLabel3.Text = "Wins:";
            this.customLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customLabel3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel2.Location = new System.Drawing.Point(29, 42);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(106, 24);
            this.customLabel2.TabIndex = 13;
            this.customLabel2.Text = "Winrate:";
            this.customLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customLabel2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // chrLabel
            // 
            this.chrLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.chrLabel.Font = new System.Drawing.Font("Consolas", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chrLabel.Location = new System.Drawing.Point(0, 0);
            this.chrLabel.Name = "chrLabel";
            this.chrLabel.Size = new System.Drawing.Size(300, 32);
            this.chrLabel.TabIndex = 10;
            this.chrLabel.Text = "Zato-1";
            this.chrLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chrLabel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // sPanel2
            // 
            this.sPanel2.AutoSize = true;
            this.sPanel2.Controls.Add(this.panel2);
            this.sPanel2.Location = new System.Drawing.Point(300, 12);
            this.sPanel2.Name = "sPanel2";
            this.sPanel2.Padding = new System.Windows.Forms.Padding(15, 15, 35, 55);
            this.sPanel2.Size = new System.Drawing.Size(380, 357);
            this.sPanel2.TabIndex = 14;
            this.sPanel2.Visible = false;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.colorOrange);
            this.panel2.Controls.Add(this.colorBlack);
            this.panel2.Controls.Add(this.colorViolet);
            this.panel2.Controls.Add(this.colorGreen);
            this.panel2.Controls.Add(this.colorBlue);
            this.panel2.Controls.Add(this.colorRed);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(15, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 287);
            this.panel2.TabIndex = 13;
            this.panel2.Visible = false;
            // 
            // colorOrange
            // 
            this.colorOrange.BackColor = System.Drawing.Color.OrangeRed;
            this.colorOrange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorOrange.Location = new System.Drawing.Point(307, 104);
            this.colorOrange.Name = "colorOrange";
            this.colorOrange.Size = new System.Drawing.Size(20, 20);
            this.colorOrange.TabIndex = 5;
            this.colorOrange.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colorOrange_MouseClick);
            // 
            // colorBlack
            // 
            this.colorBlack.BackColor = System.Drawing.Color.DimGray;
            this.colorBlack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorBlack.Location = new System.Drawing.Point(307, 130);
            this.colorBlack.Name = "colorBlack";
            this.colorBlack.Size = new System.Drawing.Size(20, 20);
            this.colorBlack.TabIndex = 4;
            this.colorBlack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colorBlack_MouseClick);
            // 
            // colorViolet
            // 
            this.colorViolet.BackColor = System.Drawing.Color.MediumVioletRed;
            this.colorViolet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorViolet.Location = new System.Drawing.Point(307, 78);
            this.colorViolet.Name = "colorViolet";
            this.colorViolet.Size = new System.Drawing.Size(20, 20);
            this.colorViolet.TabIndex = 3;
            this.colorViolet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colorViolet_MouseClick);
            // 
            // colorGreen
            // 
            this.colorGreen.BackColor = System.Drawing.Color.Green;
            this.colorGreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorGreen.Location = new System.Drawing.Point(307, 52);
            this.colorGreen.Name = "colorGreen";
            this.colorGreen.Size = new System.Drawing.Size(20, 20);
            this.colorGreen.TabIndex = 2;
            this.colorGreen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colorGreen_MouseClick);
            // 
            // colorBlue
            // 
            this.colorBlue.BackColor = System.Drawing.Color.SteelBlue;
            this.colorBlue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorBlue.Location = new System.Drawing.Point(307, 26);
            this.colorBlue.Name = "colorBlue";
            this.colorBlue.Size = new System.Drawing.Size(20, 20);
            this.colorBlue.TabIndex = 1;
            this.colorBlue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colorBlue_MouseClick);
            // 
            // colorRed
            // 
            this.colorRed.BackColor = System.Drawing.Color.Firebrick;
            this.colorRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorRed.Location = new System.Drawing.Point(307, 0);
            this.colorRed.Name = "colorRed";
            this.colorRed.Size = new System.Drawing.Size(20, 20);
            this.colorRed.TabIndex = 0;
            this.colorRed.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colorRed_MouseClick);
            // 
            // sPanel1
            // 
            this.sPanel1.Controls.Add(this.label6);
            this.sPanel1.Controls.Add(this.label15);
            this.sPanel1.Controls.Add(this.label14);
            this.sPanel1.Controls.Add(this.label13);
            this.sPanel1.Controls.Add(this.label12);
            this.sPanel1.Controls.Add(this.label11);
            this.sPanel1.Controls.Add(this.label10);
            this.sPanel1.Controls.Add(this.label8);
            this.sPanel1.Location = new System.Drawing.Point(300, 387);
            this.sPanel1.Name = "sPanel1";
            this.sPanel1.Size = new System.Drawing.Size(378, 273);
            this.sPanel1.TabIndex = 12;
            this.sPanel1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label6.Location = new System.Drawing.Point(16, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "Hide control help: F2";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label15.Location = new System.Drawing.Point(16, 188);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(177, 24);
            this.label15.TabIndex = 22;
            this.label15.Text = "Exit: CTRL + Enter";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label14.Location = new System.Drawing.Point(16, 164);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(288, 24);
            this.label14.TabIndex = 21;
            this.label14.Text = "Remove loss: CTRL + Numpad -";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label13.Location = new System.Drawing.Point(16, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(292, 24);
            this.label13.TabIndex = 20;
            this.label13.Text = "Remove win: CTRL + Numpad +";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label12.Location = new System.Drawing.Point(16, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(263, 24);
            this.label12.TabIndex = 19;
            this.label12.Text = "Manually add loss: Numpad -";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label11.Location = new System.Drawing.Point(16, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(267, 24);
            this.label11.TabIndex = 18;
            this.label11.Text = "Manually add win: Numpad +";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label10.Location = new System.Drawing.Point(16, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(325, 24);
            this.label10.TabIndex = 17;
            this.label10.Text = "Change character: Arrows up/down";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label8.Location = new System.Drawing.Point(16, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "Open statistics: F1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1043, 866);
            this.Controls.Add(this.sPanel2);
            this.Controls.Add(this.sPanel1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.sPanel2.ResumeLayout(false);
            this.sPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.sPanel1.ResumeLayout(false);
            this.sPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private CustomLabel chrLabel;
        private CustomLabel LossesCount;
        private CustomLabel WinsCount;
        private CustomLabel WinRate;
        private CustomLabel customLabel5;
        private CustomLabel customLabel4;
        private CustomLabel customLabel3;
        private CustomLabel customLabel2;
        private SPanel sPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private SPanel sPanel2;
        private System.Windows.Forms.Panel colorOrange;
        private System.Windows.Forms.Panel colorBlack;
        private System.Windows.Forms.Panel colorViolet;
        private System.Windows.Forms.Panel colorGreen;
        private System.Windows.Forms.Panel colorBlue;
        private System.Windows.Forms.Panel colorRed;
        private System.Windows.Forms.Panel panel3;
        private CustomLabel customLabel6;
    }
}


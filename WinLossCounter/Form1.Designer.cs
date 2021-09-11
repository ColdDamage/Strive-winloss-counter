
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chrLabel = new WinLossCounter.CustomLabel();
            this.customLabel1 = new WinLossCounter.CustomLabel();
            this.label5 = new WinLossCounter.CustomLabel();
            this.customLabel2 = new WinLossCounter.CustomLabel();
            this.customLabel3 = new WinLossCounter.CustomLabel();
            this.customLabel4 = new WinLossCounter.CustomLabel();
            this.customLabel5 = new WinLossCounter.CustomLabel();
            this.WinRate = new WinLossCounter.CustomLabel();
            this.WinsCount = new WinLossCounter.CustomLabel();
            this.LossesCount = new WinLossCounter.CustomLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LossesCount);
            this.panel1.Controls.Add(this.WinsCount);
            this.panel1.Controls.Add(this.WinRate);
            this.panel1.Controls.Add(this.customLabel5);
            this.panel1.Controls.Add(this.customLabel4);
            this.panel1.Controls.Add(this.customLabel3);
            this.panel1.Controls.Add(this.customLabel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.customLabel1);
            this.panel1.Controls.Add(this.chrLabel);
            this.panel1.Location = new System.Drawing.Point(333, 689);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 165);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(301, 433);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(362, 249);
            this.panel2.TabIndex = 11;
            this.panel2.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.SteelBlue;
            this.label15.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label15.Location = new System.Drawing.Point(19, 208);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(177, 24);
            this.label15.TabIndex = 13;
            this.label15.Text = "Exit: CTRL + Enter";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.SteelBlue;
            this.label14.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label14.Location = new System.Drawing.Point(19, 184);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(288, 24);
            this.label14.TabIndex = 12;
            this.label14.Text = "Remove loss: CTRL + Numpad -";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.SteelBlue;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label13.Location = new System.Drawing.Point(19, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(292, 24);
            this.label13.TabIndex = 11;
            this.label13.Text = "Remove win: CTRL + Numpad +";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.SteelBlue;
            this.label12.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label12.Location = new System.Drawing.Point(19, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(263, 24);
            this.label12.TabIndex = 10;
            this.label12.Text = "Manually add loss: Numpad -";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.SteelBlue;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label11.Location = new System.Drawing.Point(19, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(267, 24);
            this.label11.TabIndex = 9;
            this.label11.Text = "Manually add win: Numpad +";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SteelBlue;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label10.Location = new System.Drawing.Point(19, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(325, 24);
            this.label10.TabIndex = 8;
            this.label10.Text = "Change character: Arrows up/down";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label9.Location = new System.Drawing.Point(19, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(319, 24);
            this.label9.TabIndex = 7;
            this.label9.Text = "Change timeline: Arrows left/right";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label8.Location = new System.Drawing.Point(19, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 24);
            this.label8.TabIndex = 6;
            this.label8.Text = "Open statistics: F1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label6.Location = new System.Drawing.Point(19, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Hide control help: F2";
            // 
            // chrLabel
            // 
            this.chrLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.chrLabel.Font = new System.Drawing.Font("Consolas", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chrLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.chrLabel.Location = new System.Drawing.Point(0, 0);
            this.chrLabel.Name = "chrLabel";
            this.chrLabel.Size = new System.Drawing.Size(300, 32);
            this.chrLabel.TabIndex = 10;
            this.chrLabel.Text = "Zato-1";
            this.chrLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chrLabel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // customLabel1
            // 
            this.customLabel1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel1.ForeColor = System.Drawing.Color.SteelBlue;
            this.customLabel1.Location = new System.Drawing.Point(48, 33);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(87, 24);
            this.customLabel1.TabIndex = 11;
            this.customLabel1.Text = "From";
            this.customLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customLabel1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(102, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "current month";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel2.ForeColor = System.Drawing.Color.SteelBlue;
            this.customLabel2.Location = new System.Drawing.Point(29, 57);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(106, 24);
            this.customLabel2.TabIndex = 13;
            this.customLabel2.Text = "Winrate:";
            this.customLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customLabel2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // customLabel3
            // 
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel3.ForeColor = System.Drawing.Color.SteelBlue;
            this.customLabel3.Location = new System.Drawing.Point(29, 84);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(70, 24);
            this.customLabel3.TabIndex = 14;
            this.customLabel3.Text = "Wins:";
            this.customLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customLabel3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // customLabel4
            // 
            this.customLabel4.AutoSize = true;
            this.customLabel4.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel4.ForeColor = System.Drawing.Color.SteelBlue;
            this.customLabel4.Location = new System.Drawing.Point(29, 110);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(94, 24);
            this.customLabel4.TabIndex = 15;
            this.customLabel4.Text = "Losses:";
            this.customLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customLabel4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // customLabel5
            // 
            this.customLabel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.customLabel5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel5.ForeColor = System.Drawing.Color.SteelBlue;
            this.customLabel5.Location = new System.Drawing.Point(0, 146);
            this.customLabel5.Name = "customLabel5";
            this.customLabel5.Size = new System.Drawing.Size(300, 19);
            this.customLabel5.TabIndex = 16;
            this.customLabel5.Text = "Show controls: F2";
            this.customLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.customLabel5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // WinRate
            // 
            this.WinRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WinRate.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinRate.ForeColor = System.Drawing.Color.SteelBlue;
            this.WinRate.Location = new System.Drawing.Point(186, 57);
            this.WinRate.Name = "WinRate";
            this.WinRate.Size = new System.Drawing.Size(94, 24);
            this.WinRate.TabIndex = 17;
            this.WinRate.Text = "0%";
            this.WinRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.WinRate.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // WinsCount
            // 
            this.WinsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WinsCount.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinsCount.ForeColor = System.Drawing.Color.SteelBlue;
            this.WinsCount.Location = new System.Drawing.Point(158, 84);
            this.WinsCount.Name = "WinsCount";
            this.WinsCount.Size = new System.Drawing.Size(122, 24);
            this.WinsCount.TabIndex = 18;
            this.WinsCount.Text = "0";
            this.WinsCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.WinsCount.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // LossesCount
            // 
            this.LossesCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LossesCount.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LossesCount.ForeColor = System.Drawing.Color.SteelBlue;
            this.LossesCount.Location = new System.Drawing.Point(177, 110);
            this.LossesCount.Name = "LossesCount";
            this.LossesCount.Size = new System.Drawing.Size(103, 24);
            this.LossesCount.TabIndex = 19;
            this.LossesCount.Text = "0";
            this.LossesCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LossesCount.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1043, 866);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinLossCounter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private CustomLabel chrLabel;
        private CustomLabel label5;
        private CustomLabel customLabel1;
        private CustomLabel LossesCount;
        private CustomLabel WinsCount;
        private CustomLabel WinRate;
        private CustomLabel customLabel5;
        private CustomLabel customLabel4;
        private CustomLabel customLabel3;
        private CustomLabel customLabel2;
    }
}


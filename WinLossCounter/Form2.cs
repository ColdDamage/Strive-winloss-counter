using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinLossCounter
{
    public partial class Form2 : Form
    {
        public static class tableClass
        {
            public static DataTable table { get; set; }
        }

        public Form2()
        {
            InitializeComponent();
        }
        public static System.Collections.Generic.IEnumerable<String> characters = File.ReadLines("characters.txt");
        public static List<string> charList = new List<string>(characters);

        private void Form2_Load(object sender, EventArgs e)
        {
            DataTable table = tableClass.table;
            int i = 0;
            int width = panel2.Width - 50;

            Panel listcontainer = new Panel();
            listcontainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listcontainer.Size = new System.Drawing.Size(panel2.Width, panel2.Height - 10);
            listcontainer.Location = new System.Drawing.Point(0, 0);
            listcontainer.MaximumSize = new System.Drawing.Size(this.MaximumSize.Width, SystemInformation.VirtualScreen.Height);
            listcontainer.MinimumSize = new System.Drawing.Size(panel2.Width, 30);
            listcontainer.Padding = new Padding(5, 5, 5, 5);
            listcontainer.AutoScroll = true;
            width = listcontainer.Width - 50;

            TableLayoutPanel list = new TableLayoutPanel();
            list.RowCount = charList.Count();
            list.Dock = DockStyle.Top;
            list.Size = new System.Drawing.Size(width, panel2.Height - 10);
            list.Location = new System.Drawing.Point(0, 0);
            list.MaximumSize = new System.Drawing.Size(this.MaximumSize.Width, SystemInformation.VirtualScreen.Height);
            list.MinimumSize = new System.Drawing.Size(width, 30);
            list.AutoSize = true;

            panel2.Controls.Add(listcontainer);
            listcontainer.Controls.Add(list);
            foreach (string c in charList)
            {
                Panel charpanel1 = new Panel();
                charpanel1.Location = new System.Drawing.Point(0, 0);
                charpanel1.Size = new System.Drawing.Size(list.Width, 30);
                charpanel1.MaximumSize = new System.Drawing.Size(this.MaximumSize.Width, 30);
                charpanel1.MinimumSize = new System.Drawing.Size(width, 30);
                charpanel1.Name = c + "Pan";
                charpanel1.TabIndex = i;
                charpanel1.Dock = DockStyle.Fill;
                charpanel1.AutoSize = true;
                charpanel1.BackColor = Color.FromName("SteelBlue");
                charpanel1.BorderStyle = BorderStyle.FixedSingle;
                charpanel1.Margin = new Padding(0, 0, 0, 0);

                list.Controls.Add(charpanel1, 0, i);
                i++;

                Panel charpanel2 = new Panel();
                charpanel2.Location = new System.Drawing.Point(0, 0);
                charpanel2.Size = new System.Drawing.Size(width, 0);
                charpanel2.MaximumSize = new System.Drawing.Size(this.MaximumSize.Width, SystemInformation.VirtualScreen.Height);
                charpanel2.MinimumSize = new System.Drawing.Size(width, 0);
                charpanel2.Name = c + "Pan2";
                charpanel2.TabIndex = i;
                charpanel2.Dock = DockStyle.Bottom;
                charpanel2.BackColor = Color.FromName("LightSkyBlue");
                charpanel2.AutoSizeMode = AutoSizeMode.GrowOnly;
                charpanel2.AutoSize = true;
                charpanel2.Margin = new Padding(10, 0, 0, 5);
                charpanel2.Visible = false;
                charpanel2.Font = new Font("Consolas", 10, FontStyle.Bold);
                list.Controls.Add(charpanel2, 0, i);

                TableLayoutPanel statlist2 = new TableLayoutPanel();
                statlist2.ColumnCount = 5;
                statlist2.Dock = DockStyle.Fill;
                statlist2.Size = new System.Drawing.Size(width, 0);
                statlist2.MaximumSize = new System.Drawing.Size(this.MaximumSize.Width, SystemInformation.VirtualScreen.Height);
                statlist2.MinimumSize = new System.Drawing.Size(width, 0);
                statlist2.AutoSize = true;
                charpanel2.Controls.Add(statlist2);

                int i2 = 0;
                string ch;
                string yr;
                string mo;
                double w;
                double l;
                foreach (DataRow dr in table.Rows)
                {
                    ch = dr["character"].ToString();
                    if (ch == c) // if id==2
                    {
                        yr = dr["year"].ToString();
                        mo = dr["month"].ToString();
                        w = Convert.ToDouble(dr["wins"]);
                        l = Convert.ToDouble(dr["losses"]);

                        statlist2.RowCount = statlist2.RowCount + 1;
                        string month = "";
                        switch (mo)
                        {
                            case "1":
                                month = "1 (Jan)";
                                break;
                            case "2":
                                month = "2 (Feb)";
                                break;
                            case "3":
                                month = "3 (Mar)";
                                break;
                            case "4":
                                month = "4 (Apr)";
                                break;
                            case "5":
                                month = "5 (May)";
                                break;
                            case "6":
                                month = "6 (Jun)";
                                break;
                            case "7":
                                month = "7 (Jul)";
                                break;
                            case "8":
                                month = "8 (Aug)";
                                break;
                            case "9":
                                month = "9 (Sep)";
                                break;
                            case "10":
                                month = "10 (Oct)";
                                break;
                            case "11":
                                month = "11 (Nov)";
                                break;
                            case "12":
                                month = "12 (Dec)";
                                break;
                        }
                        Label time = new Label();
                        time.Text = yr + ", " + month;
                        time.Dock = DockStyle.Top;
                        time.Location = new System.Drawing.Point(0, 0);
                        time.AutoSize = true;
                        time.TextAlign = ContentAlignment.MiddleLeft;

                        Label wins2 = new Label();
                        wins2.Text = w.ToString();
                        wins2.Dock = DockStyle.Top;
                        wins2.Location = new System.Drawing.Point(0, 0);
                        wins2.AutoSize = true;
                        wins2.TextAlign = ContentAlignment.MiddleLeft;

                        Label losses2 = new Label();
                        losses2.Text = l.ToString();
                        losses2.Dock = DockStyle.Top;
                        losses2.Location = new System.Drawing.Point(0, 0);
                        losses2.AutoSize = true;
                        losses2.TextAlign = ContentAlignment.MiddleLeft;

                        Label winrate2 = new Label();
                        string winrateval = Math.Round((w / (w + l) * 100), 1).ToString();
                        if(winrateval != "NaN")
                        {
                            winrate2.Text = winrateval + "%";
                        }
                        else
                        {
                            winrate2.Text = "0%";
                        }
                        winrate2.Dock = DockStyle.Top;
                        winrate2.Location = new System.Drawing.Point(0, 0);
                        winrate2.AutoSize = true;
                        winrate2.TextAlign = ContentAlignment.MiddleLeft;

                        statlist2.Controls.Add(time, 0, i2);
                        statlist2.Controls.Add(winrate2, 1, i2);
                        statlist2.Controls.Add(wins2, 2, i2);
                        statlist2.Controls.Add(losses2, 3, i2);
                        statlist2.ColumnStyles.Clear();
                        for (int col = 0; col < statlist2.ColumnCount; col++)
                        {
                            ColumnStyle cs = new ColumnStyle(SizeType.Percent, 100 / statlist2.ColumnCount);
                            statlist2.ColumnStyles.Add(cs);
                        }
                    }
                    i2++;
                }

                TableLayoutPanel statlist = new TableLayoutPanel();
                statlist.ColumnCount = 5;
                statlist.Dock = DockStyle.Fill;
                statlist.Size = new System.Drawing.Size(width, 30);
                statlist.MaximumSize = new System.Drawing.Size(this.MaximumSize.Width, 30);
                statlist.MinimumSize = new System.Drawing.Size(width, 30);
                statlist.AutoSize = true;

                Label character = new Label();
                character.Name = c + "Cont";
                character.Text = c;
                character.Dock = DockStyle.Left;
                character.TextAlign = ContentAlignment.MiddleLeft;
                character.Location = new System.Drawing.Point(0, 0);
                character.AutoSize = true;

                Label wins = new Label();
                int windata = 0;
                if (table.Compute("SUM(wins)", "character = '" + c + "'") != DBNull.Value)
                {
                    windata = Convert.ToInt32(table.Compute("SUM(wins)", "character = '" + c + "'"));
                }
                wins.Text = "Wins: " + windata;
                wins.Dock = DockStyle.Left;
                wins.TextAlign = ContentAlignment.MiddleCenter;
                wins.Name = c + "Wins";
                wins.Location = new System.Drawing.Point(0, 0);
                wins.AutoSize = true;


                Label losses = new Label();
                double lossdata = 0.00;
                double winrateVal = 0.00;
                if (table.Compute("SUM(losses)", "character = '" + c + "'") != DBNull.Value)
                {
                    lossdata = Convert.ToInt32(table.Compute("SUM(losses)", "character = '" + c + "'"));
                    if (windata + lossdata > 0)
                    {
                        winrateVal = windata / (windata + lossdata) * 100;
                    }
                }
                else
                {
                    winrateVal = 0;
                }
                losses.Text = "Losses: " + lossdata;
                losses.Dock = DockStyle.Left;
                losses.TextAlign = ContentAlignment.MiddleCenter;
                losses.Name = c + "Losses";
                losses.Location = new System.Drawing.Point(0, 0);
                losses.AutoSize = true;

                Label winrate = new Label();
                winrate.Text = "Winrate: " + Math.Round(winrateVal, 1).ToString() + "%";
                winrate.Dock = DockStyle.Left;
                winrate.TextAlign = ContentAlignment.MiddleCenter;
                winrate.Name = c + "Winrate";
                winrate.Location = new System.Drawing.Point(0, 0);
                winrate.AutoSize = true;

                Label plus = new Label();
                plus.Text = "+";
                plus.Dock = DockStyle.Right;
                //plus.Anchor = AnchorStyles.Right;
                plus.TextAlign = ContentAlignment.MiddleRight;
                plus.Name = c + "Plus";
                plus.Location = new System.Drawing.Point(0, 0);
                plus.Cursor = Cursors.Hand;
                plus.Click += new EventHandler(this.label_Click);

                charpanel1.Controls.Add(statlist);
                statlist.Controls.Add(character, 0, 0);
                statlist.Controls.Add(winrate, 1, 0);
                statlist.Controls.Add(wins, 2, 0);
                statlist.Controls.Add(losses, 3, 0);
                statlist.Controls.Add(plus, 4, 0);
                statlist.ColumnStyles.Clear();
                for (int col = 0; col < statlist.ColumnCount; col++)
                {
                    ColumnStyle cs = new ColumnStyle(SizeType.Percent, 100 / statlist.ColumnCount);
                    statlist.ColumnStyles.Add(cs);
                }
                i++;
            }
            Activate();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        void label_Click(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            TableLayoutPanel tbl = lbl.Parent as TableLayoutPanel;
            Panel pnl1 = tbl.Parent as Panel;
            TableLayoutPanel list = pnl1.Parent as TableLayoutPanel;
            Panel pnl2 = list.Controls.Find(pnl1.Name + "2", true)[0] as Panel;
            if (lbl.Text == "+")
            {
                lbl.Text = "-";
                pnl2.Visible = true;
            }
            else
            {
                lbl.Text = "+";
                pnl2.Visible = false;
            }
        }

        private void btnForm1_Click_1(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }
    }
}

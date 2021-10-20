using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinLossCounter
{
    public partial class Form1 : Form
    {
        const int Win = 1;
        const int Loss = 2;
        const int Exit = 3;
        const int RevertLoss = 4;
        const int RevertWin = 5;
        const int ModePlus = 6;
        const int ModeMinus = 7;
        const int CharPlus = 8;
        const int CharMinus = 9;
        const int ChangeForm = 10;
        const int ShowControls = 11;
        const int ShowCharSelect = 12;
        double Wins = 0.00;
        double Losses = 0.00;
        public double Ratio = 0.00;
        public System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public static class tableClass
        {
            public static DataTable tbl { get; set; }
        }
        public DataTable table = new DataTable("XmlData");
        public static System.Collections.Generic.IEnumerable<String> characters = File.ReadLines("characters.txt");
        public static List<string> charList = new List<string>(characters);
        private Color WinColor = new Color();
        private Color LoseColor = new Color();
        double screenwidth;
        double screenheight;
        Point[] winpoints;
        Point[] losspoints;


        // DLL libraries used to manage hotkeys
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        public string WinText
        {
            get { return WinsCount.Text; }
            set { WinsCount.Text = value; }
        }
        public string LossesText
        {
            get { return LossesCount.Text; }
            set { LossesCount.Text = value; }
        }

        public Form1()
        {
            InitializeComponent();
            //Modifier keys codes: Alt = 1, Ctrl = 2, Shift = 4, Win = 8
            RegisterHotKey(this.Handle, Win, 0, (int)Keys.Add);
            RegisterHotKey(this.Handle, Loss, 0, (int)Keys.Subtract);
            RegisterHotKey(this.Handle, ModePlus, 0, (int)Keys.Right);
            RegisterHotKey(this.Handle, ModeMinus, 0, (int)Keys.Left);
            RegisterHotKey(this.Handle, CharPlus, 0, (int)Keys.Up);
            RegisterHotKey(this.Handle, CharMinus, 0, (int)Keys.Down);
            RegisterHotKey(this.Handle, Exit, 2, (int)Keys.Enter);
            RegisterHotKey(this.Handle, RevertLoss, 2, (int)Keys.Subtract);
            RegisterHotKey(this.Handle, RevertWin, 2, (int)Keys.Add);
            RegisterHotKey(this.Handle, ChangeForm, 0, (int)Keys.F1);
            RegisterHotKey(this.Handle, ShowControls, 0, (int)Keys.F2);
            RegisterHotKey(this.Handle, ShowCharSelect, 0, (int)Keys.F3);
            this.TopMost = true;
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == Win)
            {
                //Do something here, the key pressed matches our listener
                Wins++;
                updateTable(chrLabel.Text);
                updateStats(label5.Text);
            }
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == Loss)
            {
                //Do something here, the key pressed matches our listener
                Losses++;
                updateTable(chrLabel.Text);
                updateStats(label5.Text);
            }
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == RevertWin)
            {
                //Do something here, the key pressed matches our listener
                Wins--;
                //if (Wins > 0)
                //{
                //    Ratio = Math.Round((Wins / (Wins + Losses))*100, 1);
                //}
                //else
                //{
                //    Ratio = 0.00;
                //}
                //WinRate.Text = Ratio.ToString() + "%";
                //WinsCount.Text = Wins.ToString();
                updateTable(chrLabel.Text);
                updateStats(label5.Text);
            }
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == RevertLoss)
            {
                //Do something here, the key pressed matches our listener
                Losses--;
                //if (Wins > 0)
                //{
                //    Ratio = Math.Round((Wins / (Wins + Losses))*100, 1);
                //}
                //else
                //{
                //    Ratio = 0.00;
                //}
                //WinRate.Text = Ratio.ToString() + "%";
                //LossesCount.Text = Losses.ToString();
                updateTable(chrLabel.Text);
                updateStats(label5.Text);
            }
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == ModeMinus)
            {
                //Do something here, the key pressed matches our listener
                ModeSwitch("minus");
            }
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == ModePlus)
            {
                //Do something here, the key pressed matches our listener
                ModeSwitch("plus");
            }
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == CharMinus)
            {
                //Do something here, the key pressed matches our listener
                CharSwitch("minus");
            }
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == CharPlus)
            {
                //Do something here, the key pressed matches our listener
                CharSwitch("plus");
            }
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == Exit)
            {
                //Do something here, the key pressed matches our listener
                table.WriteXml("WinLossData.xml");
                Close();
                Application.Exit();
            }
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == ShowControls)
            {
                //Do something here, the key pressed matches our listener
                sPanel1.Visible = !sPanel1.Visible;
                panel2.Visible = false;
                sPanel2.Visible = false;
            }
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == ShowCharSelect)
            {
                //Do something here, the key pressed matches our listener
                sPanel1.Visible = false;
                panel2.Visible = !panel2.Visible;
                sPanel2.Visible = !sPanel2.Visible;
            }
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == ChangeForm)
            {
                //Do something here, the key pressed matches our listener
                Form2.tableClass.table = table;
                Form2 frm2 = new Form2();
                Loading();
                frm2.Show();
                Close();
            }
            base.WndProc(ref m);
        }

        public async void Loading()
        {
            Loading loading = new Loading();
            await Task.Run(() =>
            {
                loading.ShowDialog();
            });
        }

        public void ModeSwitch(string modeChange)
        {
            switch(modeChange)
            {
                case "plus":
                    switch(label5.Text)
                    {
                        case "current month":
                            label5.Text = "current year";
                            break;
                        case "current year":
                            label5.Text = "all time";
                            break;
                        case "all time":
                            label5.Text = "current month";
                            break;
                    }
                    break;

                case "minus":
                    switch (label5.Text)
                    {
                        case "current month":
                            label5.Text = "all time";
                            break;
                        case "current year":
                            label5.Text = "current month";
                            break;
                        case "all time":
                            label5.Text = "current year";
                            break;
                    }
                    break;
            }
            updateStats(label5.Text);
        }

        public void CharSwitch(string charchange)
        {
            int place = 0;
            int i = 0;
            foreach (string c in characters)
            {
                if (c == chrLabel.Text)
                {
                    place = i;
                }
                i++;
            }
            switch (charchange)
            {
                case "minus":
                    place--;
                    break;

                case "plus":
                    place++;
                    break;
            }
            if(place >= 0 && place <= charList.Count - 1)
            {
                chrLabel.Text = charList[place];
            }
            else if(place < 0)
            {
                place = charList.Count - 1;
                chrLabel.Text = charList[place];
            }
            else
            {
                place = 0;
                chrLabel.Text = charList[place];
            }
            File.WriteAllText("lastchar.txt", chrLabel.Text);
            table = ReadXML();
            DataColumnCollection columns = table.Columns;
            if (columns.Count < 1)
            {
                //create the table with the appropriate column names
                DataColumn column = new DataColumn("year", typeof(System.Int32));
                table.Columns.Add(column);

                column = new DataColumn("month", typeof(System.String));
                table.Columns.Add(column);

                column = new DataColumn("character", typeof(System.String));
                table.Columns.Add(column);

                column = new DataColumn("wins", typeof(System.Int32));
                table.Columns.Add(column);

                column = new DataColumn("losses", typeof(System.Int32));
                table.Columns.Add(column);

                updateTable(chrLabel.Text);
            }
            updateStats(label5.Text);
            Wins = Convert.ToDouble(WinsCount.Text);
            Losses = Convert.ToDouble(LossesCount.Text);
            Ratio = Math.Round((Wins / (Wins + Losses)) * 100, 1);
        }

        public DataTable ReadXML()
        {
            //create the DataTable that will hold the data
            try
            {
                //open the file using a Stream
                using (Stream stream = new FileStream("WinLossData.xml", FileMode.Open, FileAccess.Read))
                {
                    //create the table with the appropriate column names
                    DataColumn column = new DataColumn("year", typeof(System.Int32));
                    table.Columns.Add(column);

                    column = new DataColumn("month", typeof(System.String));
                    table.Columns.Add(column);

                    column = new DataColumn("character", typeof(System.String));
                    table.Columns.Add(column);

                    column = new DataColumn("wins", typeof(System.Int32));
                    table.Columns.Add(column);

                    column = new DataColumn("losses", typeof(System.Int32));
                    table.Columns.Add(column);

                    //use ReadXml to read the XML stream
                    table.ReadXml(stream);

                    //return the results
                    return table;
                }
            }
            catch (Exception ex)
            {
                return table;
            }
        }

        public void updateTable(string character)
        {
            System.DateTime now = new System.DateTime();
            now = DateTime.Today;
            int month = now.Month;
            int year = now.Year;
            bool found = false;
            foreach (DataRow dr in table.Rows) // search whole table
            {
                var yr = dr["year"].ToString();
                var mo = dr["month"].ToString();
                var ch = dr["character"].ToString();
                if (yr == year.ToString() && mo == month.ToString() && ch == character) // if id==2
                {
                    found = true;
                    dr["wins"] = Wins;
                    dr["losses"] = Losses;
                    table.AcceptChanges();
                }
            }
            if(found == false)
            {
                AddRows(character);
            }
            updateStats(label5.Text);
            table.WriteXml("WinLossData.xml");
        }

        public void updateStats(string mode)
        {
            System.DateTime now = new System.DateTime();
            now = DateTime.Today;
            int month = now.Month;
            int year = now.Year;
            string character = chrLabel.Text;
            bool found = false;
            switch (mode)
            {
                case "current month":
                    {
                        double datawins = 0.00;
                        double datalosses = 0.00;
                        foreach (DataRow dr in table.Rows) // search whole table
                        {
                            var yr = dr["year"].ToString();
                            var mo = dr["month"].ToString();
                            var ch = dr["character"].ToString();
                            if (yr == year.ToString() && mo == month.ToString() && ch == character) // if id==2
                            {
                                found = true;

                                datawins = Convert.ToInt32(table.Compute("SUM(wins)", "year = '" + yr + "'" + " AND month = '" + mo + "'" + " AND character = '" + ch + "'"));
                                datalosses = Convert.ToInt32(table.Compute("SUM(losses)", "year = '" + yr + "'" + " AND month = '" + mo + "'" + " AND character = '" + ch + "'"));

                                WinsCount.Text = datawins.ToString();
                                LossesCount.Text = datalosses.ToString();
                                if (datawins > 0)
                                {
                                    Ratio = Math.Round((datawins / (datawins + datalosses)) * 100, 1);
                                }
                                else
                                {
                                    Ratio = 0.00;
                                }
                                WinRate.Text = Ratio.ToString() + "%";
                            }
                        }
                        break;
                    }

                case "current year":
                    {
                        double datawins = 0.00;
                        double datalosses = 0.00;
                        foreach (DataRow dr in table.Rows) // search whole table
                        {
                            var yr = dr["year"].ToString();
                            var mo = dr["month"].ToString();
                            var ch = dr["character"].ToString();
                            if (yr == year.ToString() && ch == character) // if id==2
                            {
                                found = true;

                                datawins = Convert.ToInt32(table.Compute("SUM(wins)", "year = '" + yr + "'" + " AND character = '" + ch + "'"));
                                datalosses = Convert.ToInt32(table.Compute("SUM(losses)", "year = '" + yr + "'" + " AND character = '" + ch + "'"));

                                WinsCount.Text = datawins.ToString();
                                LossesCount.Text = datalosses.ToString();
                                if (datawins > 0)
                                {
                                    Ratio = Math.Round((datawins / (datawins + datalosses)) * 100, 1);
                                }
                                else
                                {
                                    Ratio = 0.00;
                                }
                                WinRate.Text = Ratio.ToString() + "%";
                            }
                        }
                        break;
                    }

                case "all time":
                    {
                        double datawins = 0.00;
                        double datalosses = 0.00;
                        foreach (DataRow dr in table.Rows) // search whole table
                        {
                            var yr = dr["year"].ToString();
                            var mo = dr["month"].ToString();
                            var ch = dr["character"].ToString();
                            if (ch == character) // if id==2
                            {
                                found = true;

                                datawins = Convert.ToInt32(table.Compute("SUM(wins)", "character = '" + ch + "'"));
                                datalosses = Convert.ToInt32(table.Compute("SUM(losses)", "character = '" + ch + "'"));

                                WinsCount.Text = datawins.ToString();
                                LossesCount.Text = datalosses.ToString();
                                if (datawins > 0)
                                {
                                    Ratio = Math.Round((datawins / (datawins + datalosses)) * 100, 1);
                                }
                                else
                                {
                                    Ratio = 0.00;
                                }
                                WinRate.Text = Ratio.ToString() + "%";
                            }
                        }
                        break;
                    }
            }
            if (found == false)
            {
                WinsCount.Text = "0";
                LossesCount.Text = "0";
                WinRate.Text = "0%";
                Wins = 0.00;
                Losses = 0.00;
                Ratio = 0.00;
            }
        }

        public void AddRows(string character)
        {
            System.DateTime now = new System.DateTime();
            now = DateTime.Today;
            // Add row
            DataRow row;
            row = table.NewRow();
            int month = now.Month;
            row["year"] = now.Year;
            row["month"] = month;
            row["character"] = character;
            row["wins"] = Wins;
            row["losses"] = Losses;
            table.Rows.Add(row);
            table.AcceptChanges();
        }

        public void CustomLabel()
        {
            OutlineForeColor = Color.FromName("ControlText");
            OutlineWidth = 2;
        }
        public Color OutlineForeColor { get; set; }
        public float OutlineWidth { get; set; }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(BackColor), ClientRectangle);
            using (GraphicsPath gp = new GraphicsPath())
            using (Pen outline = new Pen(OutlineForeColor, OutlineWidth)
            { LineJoin = LineJoin.Round })
            using (StringFormat sf = new StringFormat())
            using (Brush foreBrush = new SolidBrush(ForeColor))
            {
                gp.AddString(Text, Font.FontFamily, (int)Font.Style,
                    Font.Size, ClientRectangle, sf);
                e.Graphics.ScaleTransform(1.3f, 1.35f);
                e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                e.Graphics.DrawPath(outline, gp);
                e.Graphics.FillPath(foreBrush, gp);
            }
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            Hide();
            this.TransparencyKey = Color.Black;
            this.ForeColor = Color.FromName(System.IO.File.ReadAllText("color.txt"));
            int i = 0;
            TableLayoutPanel list = new TableLayoutPanel();
            list.RowCount = charList.Count();
            list.Dock = DockStyle.Top;
            list.Size = new System.Drawing.Size(panel2.Width, panel2.Height - 10);
            list.Location = new System.Drawing.Point(0, 0);
            list.MaximumSize = new System.Drawing.Size(this.MaximumSize.Width, SystemInformation.VirtualScreen.Height);
            list.MinimumSize = new System.Drawing.Size(panel2.Width, 30);
            list.AutoSize = true;

            panel2.Controls.Add(list);

            foreach (string c in charList)
            {
                Panel charpanel1 = new Panel();
                charpanel1.Location = new System.Drawing.Point(0, 0);
                charpanel1.Size = new System.Drawing.Size(300, 30);
                charpanel1.MaximumSize = new System.Drawing.Size(this.MaximumSize.Width, 30);
                charpanel1.MinimumSize = new System.Drawing.Size(300, 30);
                charpanel1.Name = c + "Pan";
                //charpanel1.Dock = DockStyle.Top;
                charpanel1.AutoSize = true;
                charpanel1.Margin = new Padding(0, 0, 0, 0);

                list.Controls.Add(charpanel1, 0, i);
                i++;

                Label character = new Label();
                character.Name = c + "Cont";
                character.Text = c;
                character.Dock = DockStyle.Left;
                character.TextAlign = ContentAlignment.MiddleLeft;
                character.Location = new System.Drawing.Point(0, 0);
                character.Cursor = Cursors.Hand;
                character.Click += new EventHandler(this.label_Click);

                charpanel1.Controls.Add(character);
            }
            Show();
            string lastChar = System.IO.File.ReadAllText("lastchar.txt");
            chrLabel.Text = lastChar;
            this.Size = Screen.FromControl(this).Bounds.Size;
            screenwidth = Screen.FromControl(this).Bounds.Width;
            screenheight = Screen.FromControl(this).Bounds.Height;
            panel1.Location = new Point(Convert.ToInt32(screenwidth / 2 - 150), Convert.ToInt32(screenheight - 200));
            sPanel1.Location = new Point(Convert.ToInt32(screenwidth / 2 - sPanel1.Width / 2 + 20), Convert.ToInt32(screenheight / 2));
            sPanel2.Location = new Point(Convert.ToInt32(screenwidth / 2 - sPanel2.Width / 2 + 20), Convert.ToInt32(screenheight / 2 - sPanel2.Height / 2));
            winpoints = new Point[]{ new Point { X = Convert.ToInt32(screenwidth * 0.27695), Y = Convert.ToInt32(screenheight * 0.24444) }, new Point { X = Convert.ToInt32(screenwidth * 0.28828), Y = Convert.ToInt32(screenheight * 0.24653) }, new Point { X = Convert.ToInt32(screenwidth * 0.31211), Y = Convert.ToInt32(screenheight * 0.24514) }, new Point { X = Convert.ToInt32(screenwidth * 0.33320), Y = Convert.ToInt32(screenheight * 0.24583) } };
            losspoints = new Point[] { new Point { X = Convert.ToInt32(screenwidth * 0.27734), Y = Convert.ToInt32(screenheight * 0.24444) }, new Point { X = Convert.ToInt32(screenwidth * 0.29648), Y = Convert.ToInt32(screenheight * 0.26319) }, new Point { X = Convert.ToInt32(screenwidth * 0.32226), Y = Convert.ToInt32(screenheight * 0.26319) }, new Point { X = Convert.ToInt32(screenwidth * 0.33867), Y = Convert.ToInt32(screenheight * 0.28333) } };
            table = ReadXML();
            DataColumnCollection columns = table.Columns;
            if (columns.Count < 1)
            {
                //create the table with the appropriate column names
                DataColumn column = new DataColumn("year", typeof(System.Int32));
                table.Columns.Add(column);

                column = new DataColumn("month", typeof(System.String));
                table.Columns.Add(column);

                column = new DataColumn("character", typeof(System.String));
                table.Columns.Add(column);

                column = new DataColumn("wins", typeof(System.Int32));
                table.Columns.Add(column);

                column = new DataColumn("losses", typeof(System.Int32));
                table.Columns.Add(column);

                updateTable(chrLabel.Text);
            }
            updateStats(label5.Text);
            Wins = Convert.ToDouble(WinsCount.Text);
            Losses = Convert.ToDouble(LossesCount.Text);
            Ratio = Math.Round((Wins / (Wins + Losses)) * 100, 1);
            if(Ratio.ToString() != "NaN")
            {
                WinRate.Text = Ratio.ToString() + "%";
            }
            else
            {
                WinRate.Text = "0%";
            }

            WinColor = Color.FromArgb(255, 250, 0, 0);
            LoseColor = Color.FromArgb(255, 0, 108, 218);
            timer1.Interval = 500;
            timer1.Start();
        }

        void label_Click(object sender, EventArgs e)
        {
            Label lbl = sender as Label;

            chrLabel.Text = lbl.Text;
            File.WriteAllText("lastchar.txt", chrLabel.Text);
            table = ReadXML();
            DataColumnCollection columns = table.Columns;
            if (columns.Count < 1)
            {
                //create the table with the appropriate column names
                DataColumn column = new DataColumn("year", typeof(System.Int32));
                table.Columns.Add(column);

                column = new DataColumn("month", typeof(System.String));
                table.Columns.Add(column);

                column = new DataColumn("character", typeof(System.String));
                table.Columns.Add(column);

                column = new DataColumn("wins", typeof(System.Int32));
                table.Columns.Add(column);

                column = new DataColumn("losses", typeof(System.Int32));
                table.Columns.Add(column);

                updateTable(chrLabel.Text);
            }
            updateStats(label5.Text);
            Wins = Convert.ToDouble(WinsCount.Text);
            Losses = Convert.ToDouble(LossesCount.Text);
            Ratio = Math.Round((Wins / (Wins + Losses)) * 100, 1);
        }

        protected override void OnLoad(EventArgs e)
        {
            PlaceLowerRight();
            base.OnLoad(e);
        }

        private void PlaceLowerRight()
        {
            //Determine "rightmost" screen
            Screen rightmost = Screen.AllScreens[0];
            foreach (Screen screen in Screen.AllScreens)
            {
                if (screen.WorkingArea.Right > rightmost.WorkingArea.Right)
                    rightmost = screen;
            }

            this.Left = rightmost.WorkingArea.Right - this.Width;
            this.Top = rightmost.WorkingArea.Bottom - this.Height;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            table.WriteXml("WinLossData.xml");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void chrLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        static Color GetPixel(Point position)
        {
            using (var bitmap = new Bitmap(1, 1))
            {
                using (var graphics = Graphics.FromImage(bitmap))
                {
                    graphics.CopyFromScreen(position, new Point(0, 0), new Size(1, 1));
                }
                return bitmap.GetPixel(0, 0);
            }
        }

        private string CheckPoints()
        {
            int result = 0;
            foreach (Point p in winpoints)
            {
                if (GetPixel(p) == WinColor)
                {
                    result++;
                }
            }
            foreach (Point p in losspoints)
            {
                if (GetPixel(p) == LoseColor)
                {
                    result--;
                }
            }
            if (result == 4)
            {
                return "Win";
            }
            else if (result == -4)
            {
                return "Loss";
            }
            else
            {
                return null;
            }
        }

        public static bool triggered = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (triggered == false)
            {
                string result = CheckPoints();
                if (result != null)
                {
                    triggered = true;
                    if (result == "Win")
                    {
                        Wins++;
                        updateTable(chrLabel.Text);
                        updateStats(label5.Text);
                    }
                    if (result == "Loss")
                    {
                        Losses++;
                        updateTable(chrLabel.Text);
                        updateStats(label5.Text);
                    }
                }
            }
            else if (triggered == true && CheckPoints() == null)
            {
                triggered = false;
            }
        }

        private void colorRed_MouseClick(object sender, MouseEventArgs e)
        {
            this.ForeColor = Color.Maroon;
            File.WriteAllText("color.txt", this.ForeColor.Name);
        }

        private void colorBlue_MouseClick(object sender, MouseEventArgs e)
        {
            this.ForeColor = Color.SteelBlue;
            File.WriteAllText("color.txt", this.ForeColor.Name);
        }

        private void colorGreen_MouseClick(object sender, MouseEventArgs e)
        {
            this.ForeColor = Color.Green;
            File.WriteAllText("color.txt", this.ForeColor.Name);
        }

        private void colorViolet_MouseClick(object sender, MouseEventArgs e)
        {
            this.ForeColor = Color.MediumVioletRed;
            File.WriteAllText("color.txt", this.ForeColor.Name);
        }

        private void colorOrange_MouseClick(object sender, MouseEventArgs e)
        {
            this.ForeColor = Color.OrangeRed;
            File.WriteAllText("color.txt", this.ForeColor.Name);
        }

        private void colorBlack_MouseClick(object sender, MouseEventArgs e)
        {
            this.ForeColor = Color.DimGray;
            File.WriteAllText("color.txt", this.ForeColor.Name);
        }
    }
}

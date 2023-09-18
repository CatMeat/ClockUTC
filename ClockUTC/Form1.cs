﻿using System;
using System.Drawing;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClockUTC
{
    public partial class Form1 : Form
    {
        DateTime localDateTime, utcDateTime;
        string Callsign;
        bool TitleBar;
        Color TextColor, BackgroundColor;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Clock UTC v1.0";
            Location = Properties.Settings.Default.Location;
            FormBorderStyle = Properties.Settings.Default.FormBorderStyle;
            Callsign = Properties.Settings.Default.Callsign;
            labelCallsign.Text = Callsign;
            TitleBar= Properties.Settings.Default.TitleBar;
            if (TitleBar)
            {
                menuStrip1.Show();
            }
            else
            {
                menuStrip1.Hide();
            }
            TextColor = Properties.Settings.Default.TextColor;
            BackgroundColor = Properties.Settings.Default.BackgroundColor;
            UpdateColors();
        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Location = Location;
            Properties.Settings.Default.FormBorderStyle = FormBorderStyle;
            Properties.Settings.Default.Callsign=Callsign;
            Properties.Settings.Default.TitleBar=TitleBar;
            Properties.Settings.Default.BackgroundColor=BackgroundColor;
            Properties.Settings.Default.TextColor=TextColor;

            Properties.Settings.Default.Save();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            localDateTime = DateTime.Now;
            utcDateTime = localDateTime.ToUniversalTime();

            UpdateLocalDateTime();
            UpdateUTCDateTime();

            //Text = Properties.Settings.Default.Size.ToString();


        }

        private void UpdateLocalDateTime()
        {
            string formattedTime = localDateTime.ToString("HH:mm:ss");
            labelLocalTime.Text = formattedTime;
            Console.WriteLine("Current time: " + formattedTime);

            string formattedDate = localDateTime.ToString("dddd, dd MMMM yyyy");
            labelLocalDate.Text = formattedDate;
            Console.WriteLine("Current date: " + formattedDate);
        }

        private void ToggleTitleBar()
        {
            if (FormBorderStyle == FormBorderStyle.None)
            {
                FormBorderStyle = FormBorderStyle.FixedSingle;
                menuStrip1.Show();
                TitleBar = true;    
            }
            else
            {
                FormBorderStyle = FormBorderStyle.None;
                menuStrip1.Hide();
                TitleBar= false;
            }
        }
        
        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            ToggleTitleBar();
        }

        private void labelLocalTime_DoubleClick(object sender, EventArgs e)
        {
            ToggleTitleBar();
        }

        private void labelUTCTime_DoubleClick(object sender, EventArgs e)
        {
            ToggleTitleBar();
        }

        private void labelLocalDate_DoubleClick(object sender, EventArgs e)
        {
            ToggleTitleBar();
        }

        private void labelUTCDate_DoubleClick(object sender, EventArgs e)
        {
            ToggleTitleBar();
        }

        private void groupBoxLocal_DoubleClick(object sender, EventArgs e)
        {
            ToggleTitleBar();
        }

        private void groupBoxUTC_DoubleClick(object sender, EventArgs e)
        {
            ToggleTitleBar();
        }

        private void labelCallsign_DoubleClick(object sender, EventArgs e)
        {
            ToggleTitleBar();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void callsignToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Callsign = Prompt.ShowDialog("Enter your callsign",  "caption").ToUpper();
            Properties.Settings.Default.Callsign = Callsign;
            labelCallsign.Text = Callsign;
        }

        private void UpdateUTCDateTime()
        {
            string formattedTime = utcDateTime.ToString("HH:mm:ss");
            labelUTCTime.Text = formattedTime;
            Console.WriteLine("Current time: " + formattedTime);

            string formattedDate = utcDateTime.ToString("dddd, dd MMMM yyyy");
            labelUTCDate.Text = formattedDate;
            Console.WriteLine("Current date: " + formattedDate);
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                BackgroundColor = colorDlg.Color;
                UpdateColors(); 
            }
        }

        private void textColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                TextColor = colorDlg.Color;
                UpdateColors();
            }
        }

        private void UpdateColors()
        {
            BackColor = BackgroundColor;
            ForeColor = TextColor;
            groupBoxLocal.ForeColor = TextColor;
            groupBoxUTC.ForeColor = TextColor;

        }

        public static class Prompt
        {
            public static string ShowDialog(string text, string caption)
            {
                Form prompt = new Form()
                {
                    Width = 500,
                    Height = 150,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = caption,
                    StartPosition = FormStartPosition.CenterScreen
                };
                Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
                TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
                Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
                confirmation.Click += (sender, e) => { prompt.Close(); };
                prompt.Controls.Add(textBox);
                prompt.Controls.Add(confirmation);
                prompt.Controls.Add(textLabel);
                prompt.AcceptButton = confirmation;

                return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
            }
        }

    }
}
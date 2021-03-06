﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gra3
{
    public partial class Form1 : Form
    {
        public int speed_left = 4;
        public int speed_top = 4;
        public int points = 0;



        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            Cursor.Hide();

            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            paletka.Top = boisko.Bottom - (boisko.Bottom / 10);
            gameover_lbl.Left = (boisko.Width / 2) - (gameover_lbl.Width);
            gameover_lbl.Top = (boisko.Height / 2) - (gameover_lbl.Height / 2);
            gameover_lbl.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            paletka.Left = Cursor.Position.X - (paletka.Width/2);
            pilka.Left += speed_left;
            pilka.Top += speed_top;
            if (pilka.Bottom >= paletka.Top && pilka.Bottom <= paletka.Bottom &&  pilka.Left >=paletka.Left &&pilka.Right <=paletka.Right)

            {
                speed_top += 2;
                speed_left += 2;
                speed_top = -speed_top;
                points += 1;
                points_lbl.Text = points.ToString();
            }
            if (pilka.Left <= boisko.Left)
            {
                speed_left = -speed_left;
            }
            if (pilka.Right >= boisko.Right)
            {
                speed_left = -speed_left;
            }
            if (pilka.Top <= boisko.Top)
            {
                speed_top = -speed_top;
            }

            if (pilka.Bottom >= boisko.Bottom)
            {
                timer1.Enabled = false;
                gameover_lbl.Visible = true;
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.Escape) { this.Close(); }
            if (e.KeyCode == Keys.F)
            {
                pilka.Top = 50;
                pilka.Left = 50;
                speed_left = 4;
                speed_top = 4;
                points = 0;
                points_lbl.Text = "0";
                timer1.Enabled = true;
                gameover_lbl.Visible = false;
            }
        }

        
    }
}

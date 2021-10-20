﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionProyectosSoftware
{
    public partial class Pizarra : Form
    {

        Graphics L;
        int x = -1;
        int y = -1;
        bool Mov = false;
        Pen Lapiz;
        bool borrador = false;

        public Pizarra()
        {
            InitializeComponent();
            L = Lienzo.CreateGraphics();
            Lapiz = new Pen(Color.Black, 8);
            L.SmoothingMode = SmoothingMode.AntiAlias;
            Lapiz.StartCap = Lapiz.EndCap = LineCap.Round;
        }

        private void Lienzo_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = true;
            x = e.X;
            y = e.Y;
            Lienzo.Cursor = Cursors.Cross;
            if (borrador == true)
            {
                Lapiz.Width = 90;
            }
        }

        private void Lienzo_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = false;
            x = -1;
            y = -1;
            Lienzo.Cursor = Cursors.Default;
        }

        private void Lienzo_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov && x != -1 && y != -1)
            {
                L.DrawLine(Lapiz, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
        }

        private void btnRojo_Click(object sender, EventArgs e)
        {
            borrador = false;
            Lapiz.Color = Color.Red;
            Lapiz.StartCap = Lapiz.EndCap = LineCap.Round;
            lblColor.Text = "Rojo";
            lblColor.ForeColor = Color.Red;
        }

        private void btnAzul_Click(object sender, EventArgs e)
        {
            borrador = false;
            Lapiz.Color = Color.Blue;
            Lapiz.StartCap = Lapiz.EndCap = LineCap.Round;
            lblColor.Text = "Azul";
            lblColor.ForeColor = Color.Blue;
        }

        private void btnVerde_Click(object sender, EventArgs e)
        {
            borrador = false;
            Lapiz.Color = Color.Green;
            Lapiz.StartCap = Lapiz.EndCap = LineCap.Round;
            lblColor.Text = "Verde";
            lblColor.ForeColor = Color.Green;
        }

        private void btnNaranja_Click(object sender, EventArgs e)
        {
            borrador = false;
            Lapiz.Color = Color.Orange;
            Lapiz.StartCap = Lapiz.EndCap = LineCap.Round;
            lblColor.Text = "Naranja";
            lblColor.ForeColor = Color.Orange;
        }

        private void btnNegro_Click(object sender, EventArgs e)
        {
            borrador = false;
            Lapiz.Color = Color.Black;
            Lapiz.StartCap = Lapiz.EndCap = LineCap.Round;
            lblColor.Text = "Negro";
            lblColor.ForeColor = Color.Black;
        }

        private void btnPurpura_Click(object sender, EventArgs e)
        {
            borrador = false;
            Lapiz.Color = Color.Purple;
            Lapiz.StartCap = Lapiz.EndCap = LineCap.Round;
            lblColor.Text = "Púrpura";
            lblColor.ForeColor = Color.Purple;
        }
    }
}

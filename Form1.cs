using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PaintDrawX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Comment this out to see the annoying affect when you resize the form.
        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw, true);
        }

        // Draw an X that fills the form.
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
            e.Graphics.DrawLine(Pens.Blue, 0, 0, this.ClientSize.Width, this.ClientSize.Height);
            e.Graphics.DrawLine(Pens.Blue, this.ClientSize.Width, 0, 0, this.ClientSize.Height);
        }
    }
}

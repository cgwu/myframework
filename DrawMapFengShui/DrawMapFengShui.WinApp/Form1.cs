using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DrawMapFengShui.WinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("User32.dll")]
        public extern static IntPtr GetDC(System.IntPtr hWnd);

        private void btnDraw_Click(object sender, EventArgs e)
        {
            var brush = new SolidBrush(Color.Blue);
            Pen penBlue = new Pen(Color.Blue);

            IntPtr DesktopHandle = GetDC(IntPtr.Zero);
            Graphics g = System.Drawing.Graphics.FromHdc(DesktopHandle);
            g.FillRectangle(new SolidBrush(Color.Red), 0, 0, 100, 100);

            PointF pb = new PointF(0f, 0f);

            PointF pe = new PointF(100f, 200f);
            g.DrawLine(penBlue, pb, pe);

        }
    }
}

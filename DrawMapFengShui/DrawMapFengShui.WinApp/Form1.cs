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
    /// <summary>
    /// 参考：
    /// http://dcxl.blog.sohu.com/113453543.html
    /// 
    /// </summary>
    public partial class frmFS : Form
    {
        public frmFS()
        {
            InitializeComponent();
        }

        PointF Str2PointF(string strXY)
        {
            string[] pos = strXY.Split(',');
            return new PointF(float.Parse(pos[0]), float.Parse(pos[1]));
        }


        [DllImport("User32.dll")]
        public extern static IntPtr GetDC(System.IntPtr hWnd);

        private void btnDraw_Click(object sender, EventArgs e)
        {
            Pen penBlue = new Pen(Color.Red);

            IntPtr DesktopHandle = GetDC(IntPtr.Zero);
            Graphics g = System.Drawing.Graphics.FromHdc(DesktopHandle);

            //g.FillRectangle(new SolidBrush(Color.Red), 0, 0, 100, 100);

            PointF pb = Str2PointF(this.txtBegin.Text.Trim());

            PointF pe = Str2PointF(this.txtEnd.Text.Trim());
            //斜线
            g.DrawLine(penBlue, pb, pe);

            //水平线
            g.DrawLine(penBlue,pb.X,pb.Y,pe.X,pb.Y);

            //垂直线
            g.DrawLine(penBlue, pe.X, pe.Y, pe.X, pb.Y);

            double dTanA = Math.Abs(pb.Y - pe.Y) / Math.Abs(pb.X - pe.X);
            //正切值
            this.txtTanA.Text = dTanA.ToString();

            //角度
            double dAngle = Math.Atan(dTanA) / Math.PI * 180;
            this.txtAngle.Text = Math.Round(dAngle, 2).ToString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtCurrent.Text = System.Windows.Forms.Control.MousePosition.X.ToString() + "," +
                System.Windows.Forms.Control.MousePosition.Y.ToString();
        }

        private TextBox txtCurrent;

        private void btnBegin_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            txtCurrent = this.txtBegin;
        }

        private void btnBegin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                this.timer1.Enabled = false;
                MessageBox.Show("成功取得起始点！");
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            txtCurrent = this.txtEnd;
        }

        private void btnEnd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                this.timer1.Enabled = false;
                MessageBox.Show("成功取得结束点！");
            }
        }

        private void btnCenter_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            txtCurrent = this.txtCenter;
        }

        private void btnCenter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                this.timer1.Enabled = false;
                MessageBox.Show("成功取得中心点！");
            }
        }

        private void btnDrawCenter_Click(object sender, EventArgs e)
        {
            Pen penBlue = new Pen(Color.Blue);
            Pen penRed = new Pen(Color.Red);

            IntPtr DesktopHandle = GetDC(IntPtr.Zero);
            Graphics g = System.Drawing.Graphics.FromHdc(DesktopHandle);

            PointF pc = Str2PointF(this.txtCenter.Text.Trim());

            //水平线
            g.DrawLine(penBlue, 0, pc.Y, 800, pc.Y);
            //竖线
            g.DrawLine(penBlue, pc.X, 0, pc.X, 800);

            //取正切值
            float deltaY = 600;
            float deltaX = deltaY * float.Parse(this.txtTanA.Text.Trim());

            //斜线
            g.DrawLine(penRed, pc.X, pc.Y, pc.X + deltaX, pc.Y + deltaY);

        }

    }
}

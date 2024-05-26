namespace lab1
{
    public partial class lab_1 : Form
    {
        Graphics g;
        Pen p;
        float ps;
        Brush b;

        public lab_1()
        {
            InitializeComponent();
            ps = 1.0f;
            b = new SolidBrush(Color.Orange);
            btncolor.BackColor = ((SolidBrush)b).Color;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(Color.WhiteSmoke);
            g.Dispose();
        }

        private void btndraw_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            p = new Pen(Color.BlueViolet, ps);
            g.DrawRectangle(p, 50, 50, 200, 200);
            g.FillRectangle(b, 51, 51, 198, 198);
            g.DrawEllipse(p, 300, 50, 200, 200);
            g.FillEllipse(b, 301, 51, 198, 198);
            Font t = new Font("Phetsarath OT", 16);
            g.DrawString("ວິຊາ ຄອມພິວເຕີກຣາຟຟິກ", t, Brushes.Black, 200, 300);
            g.Dispose();

        }

        private void btncolor_Click(object sender, EventArgs e)
        {
            ColorDialog clr = new ColorDialog();
            if (clr.ShowDialog() == DialogResult.OK)
            {
                btncolor.BackColor = clr.Color;
                b = new SolidBrush(clr.Color);
                Invalidate();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ps = (float)numericUpDown1.Value;
            Invalidate();

        }

    }
}
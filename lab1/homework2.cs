using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace computer_graphic
{
    public partial class homework2 : Form
    {
        Graphics g;
        Pen p;
        float ps;
        Color lightBlue;
        SolidBrush blueBrush;
        public homework2()
        {
            InitializeComponent();
            ps = 3.0f;
            lightBlue = Color.FromArgb(189, 188, 200);
            blueBrush = new SolidBrush(lightBlue);
        }

        private void House(Pen pen, Graphics g)
        {
            PointF[] roofPoints1 = {
        new PointF(282.49f, 115.23f),
        new PointF(400.75f, 233.5f),
        new PointF(660.61f, 233.5f),
        new PointF(542.36f, 115.23f),
        new PointF(282.49f, 115.23f)
    };
            PointF[] roofPoints2 = {
        new PointF(164.22f, 233.5f),
        new PointF(282.49f, 115.23f),
        new PointF(400.75f, 233.5f),
        new PointF(400.75f, 256.96f),
        new PointF(282.49f, 138.69f),
        new PointF(164.22f, 256.96f),
        new PointF(164.22f, 233.5f)
    };
            PointF[] roofPoints3 = {
        new PointF(400.73f, 233.37f),
        new PointF(660.67f, 233.37f),
        new PointF(660.67f, 256.96f),
        new PointF(400.73f, 256.96f),
        new PointF(400.73f, 233.37f)
    };
            PointF[] roofPoints4 = {
        new PointF(177.44f, 243.72f),
        new PointF(282.49f, 138.69f),
        new PointF(400.75f, 256.96f),
        new PointF(400.75f, 280.42f),
        new PointF(282.49f, 162.15f),
        new PointF(177.44f, 267.18f),
        new PointF(177.44f, 243.72f)
    };
            PointF[] roofPoints5 = {
        new PointF(400.73f, 256.83f),
        new PointF(647.24f, 256.83f),
        new PointF(647.24f, 279.21f),
        new PointF(400.73f, 279.21f),
        new PointF(400.73f, 256.83f)
    };
            PointF[] roofPoints6 = {
        new PointF(450.43f, 82.76f),
        new PointF(479.9f, 82.76f),
        new PointF(479.9f, 97.43f),
        new PointF(450.43f, 97.43f),
        new PointF(450.43f, 82.76f)
    };
            PointF[] roofPoints7 = {
        new PointF(479.9f, 82.74f),
        new PointF(534.11f, 82.74f),
        new PointF(534.11f, 97.41f),
        new PointF(479.9f, 97.41f),
        new PointF(479.9f, 82.74f)
    };
            PointF[] roofPoints8 = {
        new PointF(458.26f, 97.5f),
        new PointF(479.9f, 97.5f),
        new PointF(479.9f, 157.04f),
        new PointF(458.26f, 135.4f),
        new PointF(458.26f, 97.5f)
    };
            PointF[] roofPoints9 = {
        new PointF(479.9f, 97.41f),
        new PointF(527.81f, 97.41f),
        new PointF(527.81f, 157),
        new PointF(479.9f, 157),
        new PointF(479.9f, 97.41f)
    };
            // House body points
            PointF[] bodyPoints1 = {
        new PointF(177.44f, 266.87f),
        new PointF(282.49f, 162.15f),
        new PointF(400.75f, 280.06f),
        new PointF(400.75f, 435.76f),
        new PointF(177.44f, 435.76f),
        new PointF(177.44f, 266.87f)
    };
            PointF[] bodyPoints2 = {
        new PointF(400.75f, 233.5f),
        new PointF(647.19f, 233.5f),
        new PointF(647.19f, 435.76f),
        new PointF(400.75f, 435.76f),
        new PointF(400.75f, 233.5f)
    };
            PointF[] bodyPoints3 = {
        new PointF(177.34f, 435.75f),
        new PointF(400.75f, 435.75f),
        new PointF(400.75f, 474.45f),
        new PointF(177.34f, 474.45f),
        new PointF(177.34f, 435.75f)
    };
            PointF[] bodyPoints4 = {
        new PointF(400.75f, 435.76f),
        new PointF(647.19f, 435.76f),
        new PointF(647.19f, 474.47f),
        new PointF(400.75f, 474.47f),
        new PointF(400.75f, 435.76f)
    };
            PointF[] bodyPoints5 = {
        new PointF(434.95f, 313.12f),
        new PointF(495.76f, 313.12f),
        new PointF(495.76f, 373.94f),
        new PointF(434.95f, 373.94f),
        new PointF(434.95f, 313.12f)
    };
            PointF[] bodyPoints6 = {
        new PointF(400.75f, 435.76f),
        new PointF(647.19f, 435.76f),
        new PointF(647.19f, 474.47f),
        new PointF(400.75f, 474.47f),
        new PointF(400.75f, 435.76f)
    };
            PointF[] bodyPoints7 = {
        new PointF(548.94f, 313.12f),
        new PointF(609.76f, 313.12f),
        new PointF(609.76f, 373.38f),
        new PointF(548.94f, 373.38f),
        new PointF(548.94f, 313.12f)
    };
            PointF[] bodyPoints8 = {
        new PointF(196.93f, 435.66f),
        new PointF(303.51f, 435.66f),
        new PointF(303.51f, 455.81f),
        new PointF(196.93f, 455.81f),
        new PointF(196.93f, 435.66f)
    };
            PointF[] bodyPoints9 = {
        new PointF(150.63f, 455.45f),
        new PointF(257.21f, 455.45f),
        new PointF(257.21f, 474.27f),
        new PointF(150.63f, 474.27f),
        new PointF(150.63f, 455.45f)
    };
            PointF[] bodyPoints10 = {
        new PointF(303.28f, 435.76f),
        new PointF(338.9f, 435.76f),
        new PointF(338.9f, 455.85f),
        new PointF(303.28f, 455.85f),
        new PointF(303.28f, 435.76f)
    };
            PointF[] bodyPoints11 = {
        new PointF(257.21f, 455.85f),
        new PointF(338.92f, 455.85f),
        new PointF(338.92f, 474.27f),
        new PointF(257.21f, 474.27f),
        new PointF(257.21f, 455.85f)
    };
            // Door points
            PointF[] doorPoints1 = {
        new PointF(239.69f, 296.73f),
        new PointF(338.67f, 296.73f),
        new PointF(338.67f, 436.81f),
        new PointF(239.69f, 436.81f),
        new PointF(239.69f, 296.73f)
    };
            PointF[] doorPoints2 = {
        new PointF(224.42f, 296.73f),
        new PointF(338.69f, 296.73f),
        new PointF(338.69f, 436.81f),
        new PointF(224.42f, 436.81f),
        new PointF(224.42f, 296.73f)
    };
            // Draw the house body
            g.FillPolygon(Brushes.Brown, bodyPoints4);
            g.FillPolygon(Brushes.DarkGray, bodyPoints6); // Side floor
            g.FillPolygon(Brushes.BlanchedAlmond, bodyPoints1); // Front wall
            g.FillPolygon(Brushes.BlanchedAlmond, bodyPoints2); // Side wall
            g.FillPolygon(Brushes.DarkGray, bodyPoints3); // Front floor
            g.FillPolygon(Brushes.Brown, bodyPoints5); // Windows
            g.FillPolygon(Brushes.Brown, bodyPoints7); // Windows 2

            g.FillPolygon(Brushes.LightGray, bodyPoints8); // Stairs
            g.FillPolygon(Brushes.LightGray, bodyPoints9); // Stairs
            g.FillPolygon(Brushes.DarkGray, bodyPoints10); // Side steps
            g.FillPolygon(Brushes.DarkGray, bodyPoints11); // Side steps

            // Draw the doors
            g.FillPolygon(Brushes.Brown, doorPoints1);
            g.FillPolygon(Brushes.Brown, doorPoints2);

            // Draw the roof
            g.FillPolygon(Brushes.Black, roofPoints1);
            g.FillPolygon(Brushes.Black, roofPoints2);
            g.FillPolygon(Brushes.Black, roofPoints3);
            g.FillPolygon(Brushes.Black, roofPoints4);
            g.FillPolygon(Brushes.Black, roofPoints5);
            g.FillPolygon(Brushes.Brown, roofPoints6);
            g.FillPolygon(Brushes.Brown, roofPoints7);
            g.FillPolygon(Brushes.Brown, roofPoints8);
            g.FillPolygon(Brushes.Brown, roofPoints9);
        }
        private Matrix TranslateG(float x, float y)
        {
            Matrix tran = new Matrix();
            tran.Translate(x, y);
            return tran;
        }
        private Matrix ScaleG(float x, float y)
        {
            Matrix sc = new Matrix();
            sc.Scale(x, y);
            return sc;
        }
        private Matrix RotateAroundPoint(float angle, Point center)
        {
            // Translate the point to the origin.
            Matrix result = new Matrix();
            //result.Translate(100, 100);
            //result.Scale(3, 3);
            result.RotateAt(angle, center);
            return result;
        }


        private void btnsave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Title = "Save Drawed Image";
            sf.DefaultExt = "*.jpg";
            sf.Filter = "Jpeg Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|BNP Files(*.bmp)|*.bmp";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(sf.FileName);
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            House(Pens.Blue, g);
            g.Transform = ScaleG(2, 2);
            //pictureBox1.Image = bmp;
            g.Dispose();
        }

        private void btntranslate_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            House(Pens.Blue, g);
            g.Transform = TranslateG(500, 100);
            House(Pens.Tomato, g);
            g.Transform = ScaleG(2, 2);
            pictureBox1.Image = bmp;
            g.Dispose();
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            float angle = float.Parse(txtangle.Text.ToString());
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Point center = new Point(500, 400);
            g.FillEllipse(Brushes.Red,
            center.X - 3, center.Y - 3, 6, 6);

            g.Transform = RotateAroundPoint(angle, center);
            House(Pens.Green, g);

            pictureBox1.Image = bmp;
            g.Dispose();
        }

        private void btnScale_Click(object sender, EventArgs e)
        {
            float x = float.Parse(txtX.Text);
            float y = float.Parse(txtY.Text);
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Transform = ScaleG(x, y);
            House(Pens.Tomato, g);
            pictureBox1.Image = bmp;
            g.Dispose();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            House(Pens.Blue, g);
            pictureBox1.Image = bmp;
            g.Dispose();
        }
    }
}

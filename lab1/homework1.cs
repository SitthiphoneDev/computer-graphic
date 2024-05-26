using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;

namespace computer_graphic
{
    public partial class homework1 : Form
    {
        Graphics g;
        Pen p;
        float ps;
        Color lightBlue;
        SolidBrush blueBrush;

        public homework1()
        {
            InitializeComponent();
            ps = 3.0f;
            lightBlue = Color.FromArgb(189, 188, 200);
            blueBrush = new SolidBrush(lightBlue);
        }

        private void lab2_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            p = new Pen(Color.Black, ps);
            House();
        }

        private void House()
        {
            // Roof points
            PointF[] roofPoints1 = {
        new PointF(382.49f, 115.23f),
        new PointF(500.75f, 233.5f),
        new PointF(760.61f, 233.5f),
        new PointF(642.36f, 115.23f),
        new PointF(382.49f, 115.23f)
    };

            PointF[] roofPoints2 = {
        new PointF(264.22f, 233.5f),
        new PointF(382.49f, 115.23f),
        new PointF(500.75f, 233.5f),
        new PointF(500.75f, 256.96f),
        new PointF(382.49f, 138.69f),
        new PointF(264.22f, 256.96f),
        new PointF(264.22f, 233.5f)
    };

            PointF[] roofPoints3 = {
        new PointF(500.73f, 233.37f),
        new PointF(760.67f, 233.37f),
        new PointF(760.67f, 256.96f),
        new PointF(500.73f, 256.96f),
        new PointF(500.73f, 233.37f)
    };

            PointF[] roofPoints4 = {
        new PointF(277.44f, 243.72f),
        new PointF(382.49f, 138.69f),
        new PointF(500.75f, 256.96f),
        new PointF(500.75f, 280.42f),
        new PointF(382.49f, 162.15f),
        new PointF(277.44f, 267.18f),
        new PointF(277.44f, 243.72f)
    };

            PointF[] roofPoints5 = {
        new PointF(500.73f, 256.83f),
        new PointF(747.24f, 256.83f),
        new PointF(747.24f, 279.21f),
        new PointF(500.73f, 279.21f),
        new PointF(500.73f, 256.83f)
    };

            PointF[] roofPoints6 = {
        new PointF(550.43f, 82.76f),
        new PointF(579.9f, 82.76f),
        new PointF(579.9f, 97.43f),
        new PointF(550.43f, 97.43f),
        new PointF(550.43f, 82.76f)
    };

            PointF[] roofPoints7 = {
        new PointF(579.9f, 82.74f),
        new PointF(634.11f, 82.74f),
        new PointF(634.11f, 97.41f),
        new PointF(579.9f, 97.41f),
        new PointF(579.9f, 82.74f)
    };

            PointF[] roofPoints8 = {
        new PointF(558.26f, 97.5f),
        new PointF(579.9f, 97.5f),
        new PointF(579.9f, 157.04f),
        new PointF(558.26f, 135.4f),
        new PointF(558.26f, 97.5f)
    };

            PointF[] roofPoints9 = {
        new PointF(579.9f, 97.41f),
        new PointF(627.81f, 97.41f),
        new PointF(627.81f, 157),
        new PointF(579.9f, 157),
        new PointF(579.9f, 97.41f)
    };

            // House body points
            PointF[] bodyPoints1 = {
        new PointF(277.44f, 266.87f),
        new PointF(382.49f, 162.15f),
        new PointF(500.75f, 280.06f),
        new PointF(500.75f, 435.76f),
        new PointF(277.44f, 435.76f),
        new PointF(277.44f, 266.87f)
    };

            PointF[] bodyPoints2 = {
        new PointF(500.75f, 233.5f),
        new PointF(747.19f, 233.5f),
        new PointF(747.19f, 435.76f),
        new PointF(500.75f, 435.76f),
        new PointF(500.75f, 233.5f)
    };

            PointF[] bodyPoints3 = {
        new PointF(277.34f, 435.75f),
        new PointF(500.75f, 435.75f),
        new PointF(500.75f, 474.45f),
        new PointF(277.34f, 474.45f),
        new PointF(277.34f, 435.75f)
    };

            PointF[] bodyPoints4 = {
        new PointF(500.75f, 435.76f),
        new PointF(747.19f, 435.76f),
        new PointF(747.19f, 474.47f),
        new PointF(500.75f, 474.47f),
        new PointF(500.75f, 435.76f)
    };

            PointF[] bodyPoints5 = {
        new PointF(534.95f, 313.12f),
        new PointF(595.76f, 313.12f),
        new PointF(595.76f, 373.94f),
        new PointF(534.95f, 373.94f),
        new PointF(534.95f, 313.12f)
    };

            PointF[] bodyPoints6 = {
        new PointF(500.75f, 435.76f),
        new PointF(747.19f, 435.76f),
        new PointF(747.19f, 474.47f),
        new PointF(500.75f, 474.47f),
        new PointF(500.75f, 435.76f)
    };

            PointF[] bodyPoints7 = {
        new PointF(648.94f, 313.12f),
        new PointF(709.76f, 313.12f),
        new PointF(709.76f, 373.38f),
        new PointF(648.94f, 373.38f),
        new PointF(648.94f, 313.12f)
    };

            PointF[] bodyPoints8 = {
        new PointF(296.93f, 435.66f),
        new PointF(403.51f, 435.66f),
        new PointF(403.51f, 455.81f),
        new PointF(296.93f, 455.81f),
        new PointF(296.93f, 435.66f)
    };

            PointF[] bodyPoints9 = {
        new PointF(250.63f, 455.45f),
        new PointF(357.21f, 455.45f),
        new PointF(357.21f, 474.27f),
        new PointF(250.63f, 474.27f),
        new PointF(250.63f, 455.45f)
    };

            PointF[] bodyPoints10 = {
        new PointF(403.28f, 435.76f),
        new PointF(438.9f, 435.76f),
        new PointF(438.9f, 455.85f),
        new PointF(403.28f, 455.85f),
        new PointF(403.28f, 435.76f)
    };

            PointF[] bodyPoints11 = {
        new PointF(357.21f, 455.85f),
        new PointF(438.92f, 455.85f),
        new PointF(438.92f, 474.27f),
        new PointF(357.21f, 474.27f),
        new PointF(357.21f, 455.85f)
    };

            // Door points
            PointF[] doorPoints1 = {
        new PointF(339.69f, 296.73f),
        new PointF(438.67f, 296.73f),
        new PointF(438.67f, 436.81f),
        new PointF(339.69f, 436.81f),
        new PointF(339.69f, 296.73f)
    };

            PointF[] doorPoints2 = {
        new PointF(324.42f, 296.73f),
        new PointF(438.69f, 296.73f),
        new PointF(438.69f, 436.81f),
        new PointF(324.42f, 436.81f),
        new PointF(324.42f, 296.73f)
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
    }
}
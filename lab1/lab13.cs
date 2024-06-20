using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace computer_graphic
{
    public partial class lab13 : Form
    {
        Region rg1, rg2;
        Graphics g;

        public lab13()
        {
            InitializeComponent();
        }

        private Region TestRegion(Region region1)
        {
            GraphicsPath path1 = new GraphicsPath();
            Point[] pt = { new Point(0, 0), new Point(0, 300), new Point(300, 300) };
            path1.AddPolygon(pt);
            region1 = new Region(path1);
            return region1;
        }

        private Region TestRegion2(Region region2)
        {
            GraphicsPath path2 = new GraphicsPath();
            path2.AddEllipse(100, 0, 300, 300);
            region2 = new Region(path2);
            return region2;
        }

        private Region TestComplement(Region region1, Region region2)
        {
            region1.Complement(region2);
            return region1;
        }

        private Region TestIntersect(Region region1, Region region2)
        {
            region1.Intersect(region2);
            return region1;
        }

        private Region TestUnion(Region region1, Region region2)
        {
            region1.Union(region2);
            return region1;
        }

        private Region TestExclude(Region region1, Region region2)
        {
            region1.Exclude(region2);
            return region1;
        }

        private Region TestXor(Region region1, Region region2)
        {
            region1.Xor(region2);
            return region1;
        }

        private void DrawGrap(Region rg, Graphics g)
        {
            g.Clip = rg;
            Bitmap img = new Bitmap(@"C:\Users\Sitth\source\3CS1\computer graphic\lab1\images\Dokchampa.jpg");
            g.DrawImage(img, 30, 0);
        }

        private void btncomplement_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(Color.WhiteSmoke);
            rg1 = TestRegion(rg1);
            rg2 = TestRegion2(rg2);
            TestIntersect(rg1, rg2);
            DrawGrap(rg1, g);
            g.Dispose();
        }

        private void btnInterSect_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(Color.WhiteSmoke);
            rg1 = TestRegion(rg1);
            rg2 = TestRegion2(rg2);
            TestUnion(rg1, rg2);
            DrawGrap(rg1, g);
            g.Dispose();
        }

        private void bitUnion_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(Color.WhiteSmoke);
            rg1 = TestRegion(rg1);
            rg2 = TestRegion2(rg2);
            TestExclude(rg1, rg2);
            DrawGrap(rg1, g);
            g.Dispose();
        }

        private void btnExclude_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(Color.WhiteSmoke);
            rg1 = TestRegion(rg1);
            rg2 = TestRegion2(rg2);
            TestXor(rg1, rg2);
            DrawGrap(rg1, g);
            g.Dispose();
        }

        private void Xor_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(Color.WhiteSmoke);
            rg1 = TestRegion(rg1);
            rg2 = TestRegion2(rg2);
            TestComplement(rg1, rg2);
            DrawGrap(rg1, g);
            g.Dispose();
        }
    }
}

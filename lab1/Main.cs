using lab1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace computer_graphic
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void lab1_Click(object sender, EventArgs e)
        {
            lab_1 lab1Form = new lab_1();
            lab1Form.Show();
        }

        private void Homework1_Click(object sender, EventArgs e)
        {
            homework1 lab1Form = new homework1();
            lab1Form.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace COCOMO_Backup
{
    public partial class opening : Form
    {
        private void set_background(Object sender, PaintEventArgs e)
        {
            Graphics graph = e.Graphics;
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);

            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(101, 78, 163), Color.FromArgb(234, 175, 200), 45f);

            graph.FillRectangle(b, gradient_rectangle);
        }
        public opening()
        {
            this.Paint += new PaintEventHandler(set_background);
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Start_btn_Click(object sender, EventArgs e)
        {
            Intermediate i = new Intermediate();
            i.Show();
        }
    }
}

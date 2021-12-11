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
    public partial class Form1 : Form
    {
        private void set_background(Object sender, PaintEventArgs e)
        {
            Graphics graph = e.Graphics;
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, 145);

            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(101, 78, 163), Color.FromArgb(234, 175, 200), 50f);

            graph.FillRectangle(b, gradient_rectangle);
        }
        public Form1()
        {
            this.Paint += new PaintEventHandler(set_background);

            InitializeComponent();
        }
        float[] organic = { 2.4f, 1.05f, 2.5f, 0.38f };
        float[] semi_detached = { 3.0f, 1.12f, 2.5f, 0.35f };
        float[] embedded = { 3.6f, 1.20f, 2.5f, 0.32f };
        float calc_effort(string type, int kloc)
        {
            float effort;
            if (type == "Organic")
            {
                effort = (float)(organic[0] * Math.Pow(kloc, organic[1]));
            }
            else if (type == "Semi_detached")
            {
                effort = (float)(semi_detached[0] * Math.Pow(kloc, semi_detached[1]));
            }
            else
            {
                effort = (float)(embedded[0] * Math.Pow(kloc, embedded[1]));
            }
            return effort;
        }
        private void Calc_effort_btn_Click(object sender, EventArgs e)
        {
            int kloc = int.Parse(kloc_txt.Text);
            string mode = Type_cmb.SelectedItem.ToString();
            float effort = calc_effort(mode, kloc);
            type_lbl.Text = mode;
            effortRes_txt.Text= effort.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            opening o = new opening();
            o.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Intermediate i = new Intermediate();
            i.Show();
        }

        private void kloc_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void CalculateTime_btn_Click(object sender, EventArgs e)
        {
            int kloc = int.Parse(kloc_txt.Text);
            string type = Type_cmb.SelectedItem.ToString();

            float effort = calc_effort(type, kloc);

            float time;
            if (type == "Organic")
            {
                time = (float)(organic[2] * Math.Pow(effort, organic[3]));

            }
            else if (type == "Semi_detached ")
            {
                time = (float)(semi_detached[2] * Math.Pow(effort, semi_detached[3]));

            }
            else
            {
                time = (float)(embedded[2] * Math.Pow(effort, embedded[3]));

            }
            TimeL.Text = type;
            Time_txt.Text = time.ToString();

        }

        private void TimeL_Click(object sender, EventArgs e)
        {

        }
    }
}

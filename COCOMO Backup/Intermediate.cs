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
    
    public partial class Intermediate : Form
    {
        float calEAF()
        {


            float EAF = CostDrivers.appExperience[PersonAtt2_cmb.SelectedIndex] * CostDrivers.reliability[ProAtt1_cmb.SelectedIndex];

            return EAF;
        }
        float calc_Initial_Effort_IntermeditateCocomo(String type, int Kloc)
        {
            float[] organic = { 3.2f, 1.05f };
            float[] semi_detached = { 3.0f, 1.12f };
            float[] embedded = { 2.8f, 1.20f };

            float effort;

            if (type == "Oragnic")
                effort = (float)(organic[0] * Math.Pow(Kloc, organic[1]));
            else if (type == "Semi_detached")
                effort = (float)(semi_detached[0] * Math.Pow(Kloc, semi_detached[1]));
            else
                effort = (float)(embedded[0] * Math.Pow(Kloc, embedded[1]));

            return effort;



        }
        float calActualEffort(float EAF, float effort)
        {
            return EAF * effort;
        }
        private void set_background(Object sender, PaintEventArgs e)
        {
            Graphics graph = e.Graphics;
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, 80);

            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(101, 78, 163), Color.FromArgb(234, 175, 200), 45f);

            graph.FillRectangle(b, gradient_rectangle);
        }
        public Intermediate()
        {
            this.Paint += new PaintEventHandler(set_background);
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kloc = int.Parse(kloc2_txt.Text);
            string mode = Type2_txt.SelectedItem.ToString().ToLower();

            float effort = calc_Initial_Effort_IntermeditateCocomo(mode, kloc);

            float EAF = calEAF();
            EAF_txt.Text = EAF.ToString();
            ActualEff_txt.Text = calActualEffort(EAF, effort).ToString();
            approxEff_txt.Text = Math.Ceiling(float.Parse(ActualEff_txt.Text)).ToString();
            IntialEst_txt.Text = effort.ToString();
        }
    }
}

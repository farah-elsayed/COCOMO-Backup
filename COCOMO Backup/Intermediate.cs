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


            float EAF = CostDrivers.reliability[ProAtt1_cmb.SelectedIndex] * CostDrivers.databaseSize[ProAtt1_cmb.SelectedIndex] * CostDrivers.productComplexity[ProAtt3_cmb.SelectedIndex]
            * CostDrivers.performance[HardAtt1_cmb.SelectedIndex] * CostDrivers.memory[HardAtt2_cmb.SelectedIndex] * CostDrivers.volatility[HardAtt3_cmb.SelectedIndex] * CostDrivers.turnaboutTime[HardAtt4_cmb.SelectedIndex]
            * CostDrivers.analystCapability[PersonAtt1_cmb.SelectedIndex] * CostDrivers.appExperience[PersonAtt2_cmb.SelectedIndex] * CostDrivers.engCapability[PersonAtt3_cmb.SelectedIndex]
            * CostDrivers.vmExpericence[PersonAtt4_cmb.SelectedIndex] * CostDrivers.progammingLangExp[PersonAtt5_cmb.SelectedIndex] * CostDrivers.SWEmethods[ProjectAtt1_cmb.SelectedIndex] *
            CostDrivers.softwareTools[ProjectAtt2_cmb.SelectedIndex] * CostDrivers.devSchedule[ProjectAtt3_cmb.SelectedIndex];


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
            string mode = Type2_cmb.SelectedItem.ToString().ToLower();

            float effort = calc_Initial_Effort_IntermeditateCocomo(mode, kloc);

            float EAF = calEAF();
            EAF_txt.Text = EAF.ToString();
            ActualEff_txt.Text = calActualEffort(EAF, effort).ToString();
            approxEff_txt.Text = Math.Ceiling(float.Parse(ActualEff_txt.Text)).ToString();
            IntialEst_txt.Text = effort.ToString();
        }

        private void Calc_effort_btn_Click(object sender, EventArgs e)
        {
            int kloc = int.Parse(kloc2_txt.Text);
            string mode = Type2_cmb.SelectedItem.ToString();
            float effort = calc_effort(mode, kloc);
            Effort_lbl.Text = mode;
            effortRes_txt.Text = effort.ToString();
        }

        private void CalculateTime_btn_Click(object sender, EventArgs e)
        {
            int kloc = int.Parse(kloc2_txt.Text);
            string type = Type2_cmb.SelectedItem.ToString();

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
            Time_lbl.Text = type;
            Time_txt.Text = time.ToString();

        }

        private void Intermediate_Load(object sender, EventArgs e)
        {
            ProAtt1_cmb.SelectedItem = "Nominal";
            ProAtt2_cmb.SelectedItem = "Nominal";
            ProAtt3_cmb.SelectedItem = "Nominal";

            HardAtt1_cmb.SelectedItem = "Nominal";
            HardAtt2_cmb.SelectedItem = "Nominal";
            HardAtt3_cmb.SelectedItem = "Nominal";
            HardAtt4_cmb.SelectedItem = "Nominal";

            PersonAtt1_cmb.SelectedItem = "Nominal";
            PersonAtt2_cmb.SelectedItem = "Nominal";
            PersonAtt3_cmb.SelectedItem = "Nominal";
            PersonAtt4_cmb.SelectedItem = "Nominal";
            PersonAtt5_cmb.SelectedItem = "Nominal";

            ProjectAtt1_cmb.SelectedItem = "Nominal";
            ProjectAtt2_cmb.SelectedItem = "Nominal";
            ProjectAtt3_cmb.SelectedItem = "Nominal";
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
            

            
        }

        private void Home_btn_Click(object sender, EventArgs e)
        {
            opening o = new opening();
            o.Show();
        }
    }
}

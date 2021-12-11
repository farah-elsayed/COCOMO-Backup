
namespace COCOMO_Backup
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CalculateTime_btn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Time_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.effortRes_txt = new System.Windows.Forms.TextBox();
            this.type_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kloc_txt = new System.Windows.Forms.TextBox();
            this.Type_cmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Calc_effort_btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.TimeL = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TimeL);
            this.panel1.Controls.Add(this.CalculateTime_btn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Time_txt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.effortRes_txt);
            this.panel1.Controls.Add(this.type_lbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.kloc_txt);
            this.panel1.Controls.Add(this.Type_cmb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Calc_effort_btn);
            this.panel1.Location = new System.Drawing.Point(33, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 465);
            this.panel1.TabIndex = 17;
            // 
            // CalculateTime_btn
            // 
            this.CalculateTime_btn.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateTime_btn.Location = new System.Drawing.Point(657, 301);
            this.CalculateTime_btn.Name = "CalculateTime_btn";
            this.CalculateTime_btn.Size = new System.Drawing.Size(328, 60);
            this.CalculateTime_btn.TabIndex = 20;
            this.CalculateTime_btn.Text = "Calculate Time Development";
            this.CalculateTime_btn.UseVisualStyleBackColor = true;
            this.CalculateTime_btn.Click += new System.EventHandler(this.CalculateTime_btn_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(790, 509);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(316, 42);
            this.button4.TabIndex = 11;
            this.button4.Text = "redirect to intermediate";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(475, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "months";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // Time_txt
            // 
            this.Time_txt.BackColor = System.Drawing.Color.White;
            this.Time_txt.Enabled = false;
            this.Time_txt.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_txt.ForeColor = System.Drawing.Color.Black;
            this.Time_txt.Location = new System.Drawing.Point(185, 293);
            this.Time_txt.Name = "Time_txt";
            this.Time_txt.Size = new System.Drawing.Size(225, 35);
            this.Time_txt.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(445, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "person-month";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // effortRes_txt
            // 
            this.effortRes_txt.BackColor = System.Drawing.Color.White;
            this.effortRes_txt.Enabled = false;
            this.effortRes_txt.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.effortRes_txt.ForeColor = System.Drawing.Color.Black;
            this.effortRes_txt.Location = new System.Drawing.Point(185, 200);
            this.effortRes_txt.Name = "effortRes_txt";
            this.effortRes_txt.Size = new System.Drawing.Size(217, 35);
            this.effortRes_txt.TabIndex = 16;
            // 
            // type_lbl
            // 
            this.type_lbl.AutoSize = true;
            this.type_lbl.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_lbl.Location = new System.Drawing.Point(23, 207);
            this.type_lbl.Name = "type_lbl";
            this.type_lbl.Size = new System.Drawing.Size(20, 28);
            this.type_lbl.TabIndex = 14;
            this.type_lbl.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Project Type";
            // 
            // kloc_txt
            // 
            this.kloc_txt.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kloc_txt.Location = new System.Drawing.Point(185, 21);
            this.kloc_txt.Name = "kloc_txt";
            this.kloc_txt.Size = new System.Drawing.Size(217, 35);
            this.kloc_txt.TabIndex = 13;
            this.kloc_txt.TextChanged += new System.EventHandler(this.kloc_txt_TextChanged);
            // 
            // Type_cmb
            // 
            this.Type_cmb.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type_cmb.FormattingEnabled = true;
            this.Type_cmb.Items.AddRange(new object[] {
            "Organic",
            "Semi_detached",
            "Embedded"});
            this.Type_cmb.Location = new System.Drawing.Point(185, 78);
            this.Type_cmb.Name = "Type_cmb";
            this.Type_cmb.Size = new System.Drawing.Size(217, 36);
            this.Type_cmb.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "KLOC";
            // 
            // Calc_effort_btn
            // 
            this.Calc_effort_btn.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calc_effort_btn.Location = new System.Drawing.Point(657, 200);
            this.Calc_effort_btn.Name = "Calc_effort_btn";
            this.Calc_effort_btn.Size = new System.Drawing.Size(217, 60);
            this.Calc_effort_btn.TabIndex = 0;
            this.Calc_effort_btn.Text = "Calculate Effort";
            this.Calc_effort_btn.UseVisualStyleBackColor = true;
            this.Calc_effort_btn.Click += new System.EventHandler(this.Calc_effort_btn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(33, 519);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 42);
            this.button3.TabIndex = 10;
            this.button3.Text = "Back ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(0, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1361, 578);
            this.panel2.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Ebrima", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(400, 65);
            this.label5.TabIndex = 19;
            this.label5.Text = "COCOMO Model";
            // 
            // TimeL
            // 
            this.TimeL.AutoSize = true;
            this.TimeL.Font = new System.Drawing.Font("Ebrima", 12F);
            this.TimeL.Location = new System.Drawing.Point(23, 283);
            this.TimeL.Name = "TimeL";
            this.TimeL.Size = new System.Drawing.Size(20, 28);
            this.TimeL.TabIndex = 21;
            this.TimeL.Text = "-";
            this.TimeL.Click += new System.EventHandler(this.TimeL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 670);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Basic Model";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox effortRes_txt;
        private System.Windows.Forms.Label type_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kloc_txt;
        private System.Windows.Forms.ComboBox Type_cmb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Calc_effort_btn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button CalculateTime_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Time_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TimeL;
    }
}


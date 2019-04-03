namespace Proje_2_SecimSistemi
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.GrpBxGrafikler = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblE = new System.Windows.Forms.Label();
            this.LblD = new System.Windows.Forms.Label();
            this.LblC = new System.Windows.Forms.Label();
            this.LblB = new System.Windows.Forms.Label();
            this.LblA = new System.Windows.Forms.Label();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbbxIlceSecin = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GrpBxGrafikler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpBxGrafikler
            // 
            this.GrpBxGrafikler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GrpBxGrafikler.Controls.Add(this.chart1);
            this.GrpBxGrafikler.Location = new System.Drawing.Point(4, 12);
            this.GrpBxGrafikler.Name = "GrpBxGrafikler";
            this.GrpBxGrafikler.Size = new System.Drawing.Size(696, 189);
            this.GrpBxGrafikler.TabIndex = 0;
            this.GrpBxGrafikler.TabStop = false;
            this.GrpBxGrafikler.Text = "GRAFİK";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 21);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "PARTİLER";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(690, 165);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblE);
            this.groupBox2.Controls.Add(this.LblD);
            this.groupBox2.Controls.Add(this.LblC);
            this.groupBox2.Controls.Add(this.LblB);
            this.groupBox2.Controls.Add(this.LblA);
            this.groupBox2.Controls.Add(this.progressBar5);
            this.groupBox2.Controls.Add(this.progressBar4);
            this.groupBox2.Controls.Add(this.progressBar3);
            this.groupBox2.Controls.Add(this.progressBar2);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.CmbbxIlceSecin);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(4, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(696, 259);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İLÇE DEĞERLERİ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // LblE
            // 
            this.LblE.AutoSize = true;
            this.LblE.Location = new System.Drawing.Point(607, 207);
            this.LblE.Name = "LblE";
            this.LblE.Size = new System.Drawing.Size(26, 18);
            this.LblE.TabIndex = 16;
            this.LblE.Text = "00";
            this.LblE.Click += new System.EventHandler(this.label11_Click);
            // 
            // LblD
            // 
            this.LblD.AutoSize = true;
            this.LblD.Location = new System.Drawing.Point(607, 177);
            this.LblD.Name = "LblD";
            this.LblD.Size = new System.Drawing.Size(26, 18);
            this.LblD.TabIndex = 15;
            this.LblD.Text = "00";
            this.LblD.Click += new System.EventHandler(this.label10_Click);
            // 
            // LblC
            // 
            this.LblC.AutoSize = true;
            this.LblC.Location = new System.Drawing.Point(607, 145);
            this.LblC.Name = "LblC";
            this.LblC.Size = new System.Drawing.Size(26, 18);
            this.LblC.TabIndex = 14;
            this.LblC.Text = "00";
            // 
            // LblB
            // 
            this.LblB.AutoSize = true;
            this.LblB.Location = new System.Drawing.Point(607, 122);
            this.LblB.Name = "LblB";
            this.LblB.Size = new System.Drawing.Size(26, 18);
            this.LblB.TabIndex = 13;
            this.LblB.Text = "00";
            // 
            // LblA
            // 
            this.LblA.AutoSize = true;
            this.LblA.Location = new System.Drawing.Point(607, 89);
            this.LblA.Name = "LblA";
            this.LblA.Size = new System.Drawing.Size(26, 18);
            this.LblA.TabIndex = 12;
            this.LblA.Text = "00";
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(164, 207);
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(437, 23);
            this.progressBar5.TabIndex = 11;
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(164, 177);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(437, 23);
            this.progressBar4.TabIndex = 10;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(164, 145);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(437, 23);
            this.progressBar3.TabIndex = 9;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(164, 116);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(437, 23);
            this.progressBar2.TabIndex = 8;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(164, 89);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(437, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "E PARTİSİ :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "D PARTİSİ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "C PARTİSİ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "B PARTİSİ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "A PARTİSİ :";
            // 
            // CmbbxIlceSecin
            // 
            this.CmbbxIlceSecin.FormattingEnabled = true;
            this.CmbbxIlceSecin.Location = new System.Drawing.Point(164, 34);
            this.CmbbxIlceSecin.Name = "CmbbxIlceSecin";
            this.CmbbxIlceSecin.Size = new System.Drawing.Size(121, 26);
            this.CmbbxIlceSecin.TabIndex = 1;
            this.CmbbxIlceSecin.Text = "ilçe seçiniz...";
            this.CmbbxIlceSecin.SelectedIndexChanged += new System.EventHandler(this.CmbbxIlceSecin_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "İLÇE SEÇİN :";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 478);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GrpBxGrafikler);
            this.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GRAFİKLER";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.GrpBxGrafikler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpBxGrafikler;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label LblE;
        private System.Windows.Forms.Label LblD;
        private System.Windows.Forms.Label LblC;
        private System.Windows.Forms.Label LblB;
        private System.Windows.Forms.Label LblA;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbbxIlceSecin;
        private System.Windows.Forms.Label label1;
    }
}
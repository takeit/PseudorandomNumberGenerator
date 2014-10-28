namespace PseudoRandomGenerators
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonPoisson = new System.Windows.Forms.RadioButton();
            this.radioButtonGauss = new System.Windows.Forms.RadioButton();
            this.labelLambda = new System.Windows.Forms.Label();
            this.labelM = new System.Windows.Forms.Label();
            this.textBoxLambda = new System.Windows.Forms.TextBox();
            this.textBoxM = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPoissonSettings = new System.Windows.Forms.Panel();
            this.panelGaussSettings = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSigma = new System.Windows.Forms.TextBox();
            this.textBoxMGauss = new System.Windows.Forms.TextBox();
            this.textBoxMaleM = new System.Windows.Forms.TextBox();
            this.labelSigma = new System.Windows.Forms.Label();
            this.labelMaleM = new System.Windows.Forms.Label();
            this.table = new System.Windows.Forms.DataGridView();
            this.chartPoisson = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartGauss = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panelPoissonSettings.SuspendLayout();
            this.panelGaussSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPoisson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGauss)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rozkład:";
            // 
            // radioButtonPoisson
            // 
            this.radioButtonPoisson.AutoSize = true;
            this.radioButtonPoisson.Location = new System.Drawing.Point(51, 90);
            this.radioButtonPoisson.Name = "radioButtonPoisson";
            this.radioButtonPoisson.Size = new System.Drawing.Size(120, 29);
            this.radioButtonPoisson.TabIndex = 1;
            this.radioButtonPoisson.TabStop = true;
            this.radioButtonPoisson.Text = "Poisson";
            this.radioButtonPoisson.UseVisualStyleBackColor = true;
            this.radioButtonPoisson.CheckedChanged += new System.EventHandler(this.radioButtonPoisson_CheckedChanged);
            // 
            // radioButtonGauss
            // 
            this.radioButtonGauss.AutoSize = true;
            this.radioButtonGauss.Location = new System.Drawing.Point(51, 139);
            this.radioButtonGauss.Name = "radioButtonGauss";
            this.radioButtonGauss.Size = new System.Drawing.Size(105, 29);
            this.radioButtonGauss.TabIndex = 2;
            this.radioButtonGauss.TabStop = true;
            this.radioButtonGauss.Text = "Gauss";
            this.radioButtonGauss.UseVisualStyleBackColor = true;
            this.radioButtonGauss.CheckedChanged += new System.EventHandler(this.radioButtonGauss_CheckedChanged);
            // 
            // labelLambda
            // 
            this.labelLambda.AutoSize = true;
            this.labelLambda.Location = new System.Drawing.Point(7, 35);
            this.labelLambda.Name = "labelLambda";
            this.labelLambda.Size = new System.Drawing.Size(47, 25);
            this.labelLambda.TabIndex = 3;
            this.labelLambda.Text = "λ = ";
            // 
            // labelM
            // 
            this.labelM.AutoSize = true;
            this.labelM.Location = new System.Drawing.Point(7, 87);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(54, 25);
            this.labelM.TabIndex = 4;
            this.labelM.Text = "M = ";
            // 
            // textBoxLambda
            // 
            this.textBoxLambda.Location = new System.Drawing.Point(69, 29);
            this.textBoxLambda.Name = "textBoxLambda";
            this.textBoxLambda.Size = new System.Drawing.Size(158, 31);
            this.textBoxLambda.TabIndex = 5;
            this.textBoxLambda.Text = "2";
            // 
            // textBoxM
            // 
            this.textBoxM.Location = new System.Drawing.Point(69, 87);
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.Size = new System.Drawing.Size(158, 31);
            this.textBoxM.TabIndex = 6;
            this.textBoxM.Text = "10000";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(51, 620);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(181, 56);
            this.buttonStart.TabIndex = 7;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panelPoissonSettings);
            this.panel1.Controls.Add(this.panelGaussSettings);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonStart);
            this.panel1.Controls.Add(this.radioButtonPoisson);
            this.panel1.Controls.Add(this.radioButtonGauss);
            this.panel1.Location = new System.Drawing.Point(21, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 705);
            this.panel1.TabIndex = 8;
            // 
            // panelPoissonSettings
            // 
            this.panelPoissonSettings.Controls.Add(this.textBoxLambda);
            this.panelPoissonSettings.Controls.Add(this.labelM);
            this.panelPoissonSettings.Controls.Add(this.labelLambda);
            this.panelPoissonSettings.Controls.Add(this.textBoxM);
            this.panelPoissonSettings.Location = new System.Drawing.Point(20, 192);
            this.panelPoissonSettings.Name = "panelPoissonSettings";
            this.panelPoissonSettings.Size = new System.Drawing.Size(245, 152);
            this.panelPoissonSettings.TabIndex = 13;
            // 
            // panelGaussSettings
            // 
            this.panelGaussSettings.Controls.Add(this.label2);
            this.panelGaussSettings.Controls.Add(this.textBoxSigma);
            this.panelGaussSettings.Controls.Add(this.textBoxMGauss);
            this.panelGaussSettings.Controls.Add(this.textBoxMaleM);
            this.panelGaussSettings.Controls.Add(this.labelSigma);
            this.panelGaussSettings.Controls.Add(this.labelMaleM);
            this.panelGaussSettings.Location = new System.Drawing.Point(20, 192);
            this.panelGaussSettings.Name = "panelGaussSettings";
            this.panelGaussSettings.Size = new System.Drawing.Size(244, 158);
            this.panelGaussSettings.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "M = ";
            // 
            // textBoxSigma
            // 
            this.textBoxSigma.Location = new System.Drawing.Point(72, 12);
            this.textBoxSigma.Name = "textBoxSigma";
            this.textBoxSigma.Size = new System.Drawing.Size(158, 31);
            this.textBoxSigma.TabIndex = 8;
            this.textBoxSigma.Text = "0,5";
            // 
            // textBoxMGauss
            // 
            this.textBoxMGauss.Location = new System.Drawing.Point(72, 112);
            this.textBoxMGauss.Name = "textBoxMGauss";
            this.textBoxMGauss.Size = new System.Drawing.Size(158, 31);
            this.textBoxMGauss.TabIndex = 8;
            this.textBoxMGauss.Text = "10000";
            // 
            // textBoxMaleM
            // 
            this.textBoxMaleM.Location = new System.Drawing.Point(71, 67);
            this.textBoxMaleM.Name = "textBoxMaleM";
            this.textBoxMaleM.Size = new System.Drawing.Size(159, 31);
            this.textBoxMaleM.TabIndex = 11;
            this.textBoxMaleM.Text = "10";
            // 
            // labelSigma
            // 
            this.labelSigma.AutoSize = true;
            this.labelSigma.Location = new System.Drawing.Point(10, 15);
            this.labelSigma.Name = "labelSigma";
            this.labelSigma.Size = new System.Drawing.Size(48, 25);
            this.labelSigma.TabIndex = 9;
            this.labelSigma.Text = "σ = ";
            // 
            // labelMaleM
            // 
            this.labelMaleM.AutoSize = true;
            this.labelMaleM.Location = new System.Drawing.Point(11, 67);
            this.labelMaleM.Name = "labelMaleM";
            this.labelMaleM.Size = new System.Drawing.Size(53, 25);
            this.labelMaleM.TabIndex = 10;
            this.labelMaleM.Text = "m = ";
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(320, 24);
            this.table.Name = "table";
            this.table.RowTemplate.Height = 33;
            this.table.Size = new System.Drawing.Size(486, 705);
            this.table.TabIndex = 9;
            // 
            // chartPoisson
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPoisson.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPoisson.Legends.Add(legend1);
            this.chartPoisson.Location = new System.Drawing.Point(858, 24);
            this.chartPoisson.Name = "chartPoisson";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "Lambda";
            series1.YValuesPerPoint = 6;
            this.chartPoisson.Series.Add(series1);
            this.chartPoisson.Size = new System.Drawing.Size(1188, 705);
            this.chartPoisson.TabIndex = 10;
            this.chartPoisson.Text = "chartPoisson";
            // 
            // chartGauss
            // 
            chartArea2.Name = "ChartArea1";
            this.chartGauss.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartGauss.Legends.Add(legend2);
            this.chartGauss.Location = new System.Drawing.Point(320, 24);
            this.chartGauss.Name = "chartGauss";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Z";
            this.chartGauss.Series.Add(series2);
            this.chartGauss.Size = new System.Drawing.Size(1848, 705);
            this.chartGauss.TabIndex = 11;
            this.chartGauss.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2255, 748);
            this.Controls.Add(this.chartGauss);
            this.Controls.Add(this.chartPoisson);
            this.Controls.Add(this.table);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "PseudoRandom Generators";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelPoissonSettings.ResumeLayout(false);
            this.panelPoissonSettings.PerformLayout();
            this.panelGaussSettings.ResumeLayout(false);
            this.panelGaussSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPoisson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGauss)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonPoisson;
        private System.Windows.Forms.RadioButton radioButtonGauss;
        private System.Windows.Forms.Label labelLambda;
        private System.Windows.Forms.Label labelM;
        private System.Windows.Forms.TextBox textBoxLambda;
        private System.Windows.Forms.TextBox textBoxM;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPoisson;
        private System.Windows.Forms.Panel panelGaussSettings;
        private System.Windows.Forms.TextBox textBoxSigma;
        private System.Windows.Forms.TextBox textBoxMaleM;
        private System.Windows.Forms.Label labelSigma;
        private System.Windows.Forms.Label labelMaleM;
        private System.Windows.Forms.Panel panelPoissonSettings;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGauss;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMGauss;
    }
}


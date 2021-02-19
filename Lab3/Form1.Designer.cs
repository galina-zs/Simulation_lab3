namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.heightLabel = new System.Windows.Forms.Label();
            this.angleLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.heightNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.angleNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.speedNumericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.launchButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerLabel = new System.Windows.Forms.Label();
            this.pauseButton = new System.Windows.Forms.Button();
            this.continueButton = new System.Windows.Forms.Button();
            this.weightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.weightLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.distanceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleNumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedNumericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 150);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(800, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heightLabel.Location = new System.Drawing.Point(12, 22);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(60, 20);
            this.heightLabel.TabIndex = 1;
            this.heightLabel.Text = "Height:";
            // 
            // angleLabel
            // 
            this.angleLabel.AutoSize = true;
            this.angleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.angleLabel.Location = new System.Drawing.Point(12, 58);
            this.angleLabel.Name = "angleLabel";
            this.angleLabel.Size = new System.Drawing.Size(54, 20);
            this.angleLabel.TabIndex = 2;
            this.angleLabel.Text = "Angle:";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speedLabel.Location = new System.Drawing.Point(12, 96);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(60, 20);
            this.speedLabel.TabIndex = 3;
            this.speedLabel.Text = "Speed:";
            // 
            // heightNumericUpDown1
            // 
            this.heightNumericUpDown1.Location = new System.Drawing.Point(93, 22);
            this.heightNumericUpDown1.Name = "heightNumericUpDown1";
            this.heightNumericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.heightNumericUpDown1.TabIndex = 4;
            this.heightNumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.heightNumericUpDown1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // angleNumericUpDown1
            // 
            this.angleNumericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.angleNumericUpDown1.Location = new System.Drawing.Point(93, 58);
            this.angleNumericUpDown1.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.angleNumericUpDown1.Name = "angleNumericUpDown1";
            this.angleNumericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.angleNumericUpDown1.TabIndex = 5;
            this.angleNumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.angleNumericUpDown1.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // speedNumericUpDown2
            // 
            this.speedNumericUpDown2.Location = new System.Drawing.Point(93, 96);
            this.speedNumericUpDown2.Name = "speedNumericUpDown2";
            this.speedNumericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.speedNumericUpDown2.TabIndex = 6;
            this.speedNumericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.speedNumericUpDown2.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // launchButton
            // 
            this.launchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.launchButton.Location = new System.Drawing.Point(485, 19);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(75, 23);
            this.launchButton.TabIndex = 7;
            this.launchButton.Text = "Launch";
            this.launchButton.UseVisualStyleBackColor = true;
            this.launchButton.Click += new System.EventHandler(this.launchButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timerLabel.Location = new System.Drawing.Point(511, 93);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(49, 20);
            this.timerLabel.TabIndex = 8;
            this.timerLabel.Text = "00:00";
            // 
            // pauseButton
            // 
            this.pauseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pauseButton.Location = new System.Drawing.Point(574, 55);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(75, 23);
            this.pauseButton.TabIndex = 9;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // continueButton
            // 
            this.continueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.continueButton.Location = new System.Drawing.Point(485, 55);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(75, 23);
            this.continueButton.TabIndex = 10;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // weightNumericUpDown
            // 
            this.weightNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.weightNumericUpDown.Location = new System.Drawing.Point(324, 58);
            this.weightNumericUpDown.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.weightNumericUpDown.Name = "weightNumericUpDown";
            this.weightNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.weightNumericUpDown.TabIndex = 14;
            this.weightNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.weightNumericUpDown.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // sizeNumericUpDown
            // 
            this.sizeNumericUpDown.DecimalPlaces = 2;
            this.sizeNumericUpDown.Location = new System.Drawing.Point(324, 22);
            this.sizeNumericUpDown.Name = "sizeNumericUpDown";
            this.sizeNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.sizeNumericUpDown.TabIndex = 13;
            this.sizeNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sizeNumericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weightLabel.Location = new System.Drawing.Point(243, 58);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(63, 20);
            this.weightLabel.TabIndex = 12;
            this.weightLabel.Text = "Weight:";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sizeLabel.Location = new System.Drawing.Point(243, 22);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(44, 20);
            this.sizeLabel.TabIndex = 11;
            this.sizeLabel.Text = "Size:";
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.distanceLabel.Location = new System.Drawing.Point(243, 96);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(76, 20);
            this.distanceLabel.TabIndex = 15;
            this.distanceLabel.Text = "Distance:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.weightNumericUpDown);
            this.Controls.Add(this.sizeNumericUpDown);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.launchButton);
            this.Controls.Add(this.speedNumericUpDown2);
            this.Controls.Add(this.angleNumericUpDown1);
            this.Controls.Add(this.heightNumericUpDown1);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.angleLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleNumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedNumericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label angleLabel;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.NumericUpDown heightNumericUpDown1;
        private System.Windows.Forms.NumericUpDown angleNumericUpDown1;
        private System.Windows.Forms.NumericUpDown speedNumericUpDown2;
        private System.Windows.Forms.Button launchButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.NumericUpDown weightNumericUpDown;
        private System.Windows.Forms.NumericUpDown sizeNumericUpDown;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label distanceLabel;
    }
}


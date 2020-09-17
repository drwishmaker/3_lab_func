namespace _3_lab_func
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.graphField = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonBuildGraph = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownMinX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxX = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownStep = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownValueA = new System.Windows.Forms.NumericUpDown();
            this.valueTable = new System.Windows.Forms.DataGridView();
            this.ValueX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.graphField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValueA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueTable)).BeginInit();
            this.SuspendLayout();
            // 
            // graphField
            // 
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisX2.IsStartedFromZero = false;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY2.IsStartedFromZero = false;
            chartArea1.Name = "ChartArea1";
            this.graphField.ChartAreas.Add(chartArea1);
            this.graphField.Location = new System.Drawing.Point(13, 13);
            this.graphField.Margin = new System.Windows.Forms.Padding(4);
            this.graphField.Name = "graphField";
            this.graphField.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            this.graphField.Series.Add(series1);
            this.graphField.Size = new System.Drawing.Size(422, 369);
            this.graphField.TabIndex = 0;
            this.graphField.Text = "chart1";
            // 
            // buttonBuildGraph
            // 
            this.buttonBuildGraph.Location = new System.Drawing.Point(652, 13);
            this.buttonBuildGraph.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBuildGraph.Name = "buttonBuildGraph";
            this.buttonBuildGraph.Size = new System.Drawing.Size(248, 48);
            this.buttonBuildGraph.TabIndex = 1;
            this.buttonBuildGraph.Text = "build graph";
            this.buttonBuildGraph.UseVisualStyleBackColor = true;
            this.buttonBuildGraph.Click += new System.EventHandler(this.buttonBuildGraph_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(649, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "min x:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(777, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "max x:";
            // 
            // numericUpDownMinX
            // 
            this.numericUpDownMinX.DecimalPlaces = 5;
            this.numericUpDownMinX.Location = new System.Drawing.Point(652, 86);
            this.numericUpDownMinX.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownMinX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownMinX.Name = "numericUpDownMinX";
            this.numericUpDownMinX.Size = new System.Drawing.Size(119, 23);
            this.numericUpDownMinX.TabIndex = 4;
            this.numericUpDownMinX.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            // 
            // numericUpDownMaxX
            // 
            this.numericUpDownMaxX.DecimalPlaces = 5;
            this.numericUpDownMaxX.Location = new System.Drawing.Point(780, 86);
            this.numericUpDownMaxX.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownMaxX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownMaxX.Name = "numericUpDownMaxX";
            this.numericUpDownMaxX.Size = new System.Drawing.Size(119, 23);
            this.numericUpDownMaxX.TabIndex = 5;
            this.numericUpDownMaxX.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_3_lab_func.Properties.Resources.Цепная_линия;
            this.pictureBox1.Location = new System.Drawing.Point(13, 377);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(422, 80);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(649, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "step:";
            // 
            // numericUpDownStep
            // 
            this.numericUpDownStep.DecimalPlaces = 3;
            this.numericUpDownStep.Location = new System.Drawing.Point(651, 133);
            this.numericUpDownStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownStep.Name = "numericUpDownStep";
            this.numericUpDownStep.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownStep.TabIndex = 8;
            this.numericUpDownStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(777, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "value a:";
            // 
            // numericUpDownValueA
            // 
            this.numericUpDownValueA.DecimalPlaces = 5;
            this.numericUpDownValueA.Location = new System.Drawing.Point(780, 133);
            this.numericUpDownValueA.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownValueA.Name = "numericUpDownValueA";
            this.numericUpDownValueA.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownValueA.TabIndex = 10;
            this.numericUpDownValueA.Value = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            // 
            // valueTable
            // 
            this.valueTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.valueTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ValueX,
            this.ValueY});
            this.valueTable.Location = new System.Drawing.Point(442, 13);
            this.valueTable.Name = "valueTable";
            this.valueTable.RowHeadersVisible = false;
            this.valueTable.Size = new System.Drawing.Size(203, 444);
            this.valueTable.TabIndex = 11;
            // 
            // ValueX
            // 
            this.ValueX.HeaderText = "X";
            this.ValueX.Name = "ValueX";
            // 
            // ValueY
            // 
            this.ValueY.HeaderText = "Y";
            this.ValueY.Name = "ValueY";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 464);
            this.Controls.Add(this.valueTable);
            this.Controls.Add(this.numericUpDownValueA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownStep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.numericUpDownMaxX);
            this.Controls.Add(this.numericUpDownMinX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBuildGraph);
            this.Controls.Add(this.graphField);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Function graph y = a*ch(x/a)";
            ((System.ComponentModel.ISupportInitialize)(this.graphField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValueA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart graphField;
        private System.Windows.Forms.Button buttonBuildGraph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownMinX;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxX;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownStep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownValueA;
        private System.Windows.Forms.DataGridView valueTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueY;
    }
}


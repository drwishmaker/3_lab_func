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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.graphField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValueA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.graphField.Location = new System.Drawing.Point(0, 28);
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
            this.buttonBuildGraph.Location = new System.Drawing.Point(637, 126);
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
            this.label1.Location = new System.Drawing.Point(635, 28);
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
            this.label2.Location = new System.Drawing.Point(763, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "max x:";
            // 
            // numericUpDownMinX
            // 
            this.numericUpDownMinX.DecimalPlaces = 5;
            this.numericUpDownMinX.Location = new System.Drawing.Point(638, 49);
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
            this.numericUpDownMaxX.Location = new System.Drawing.Point(766, 49);
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
            this.pictureBox1.Location = new System.Drawing.Point(0, 392);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(422, 80);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(635, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "step:";
            // 
            // numericUpDownStep
            // 
            this.numericUpDownStep.DecimalPlaces = 3;
            this.numericUpDownStep.Location = new System.Drawing.Point(637, 96);
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
            this.label4.Location = new System.Drawing.Point(763, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "value a:";
            // 
            // numericUpDownValueA
            // 
            this.numericUpDownValueA.DecimalPlaces = 5;
            this.numericUpDownValueA.Location = new System.Drawing.Point(766, 96);
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
            this.valueTable.Location = new System.Drawing.Point(429, 28);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutProgramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(915, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveToolStripMenuItem.Text = "Save...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.aboutProgramToolStripMenuItem.Text = "About program";
            this.aboutProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 489);
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
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MainMenuStrip = this.menuStrip1;
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SaveFileDialog sfd;
    }
}


namespace Tyuiu.VegerinaVV.Sprint6.Task2.V28
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxTask_VVV = new GroupBox();
            textBoxTask_VVV = new TextBox();
            groupBoxInput_VVV = new GroupBox();
            textBoxStopStep_VVV = new TextBox();
            textBoxStartStep_VVV = new TextBox();
            labelStopStep_VVV = new TextBox();
            labelStartStep_VVV = new TextBox();
            buttonHelp_VVV = new Button();
            buttonDone_VVV = new Button();
            groupBox3 = new GroupBox();
            textBoxResult_VVV = new TextBox();
            chartFunction_VVV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewFunction_VVV = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            groupBoxTask_VVV.SuspendLayout();
            groupBoxInput_VVV.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_VVV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_VVV).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_VVV
            // 
            groupBoxTask_VVV.Controls.Add(textBoxTask_VVV);
            groupBoxTask_VVV.Location = new Point(13, 10);
            groupBoxTask_VVV.Name = "groupBoxTask_VVV";
            groupBoxTask_VVV.Size = new Size(429, 272);
            groupBoxTask_VVV.TabIndex = 0;
            groupBoxTask_VVV.TabStop = false;
            groupBoxTask_VVV.Text = "Условие:";
            // 
            // textBoxTask_VVV
            // 
            textBoxTask_VVV.BackColor = SystemColors.Control;
            textBoxTask_VVV.Location = new Point(13, 34);
            textBoxTask_VVV.Multiline = true;
            textBoxTask_VVV.Name = "textBoxTask_VVV";
            textBoxTask_VVV.Size = new Size(416, 238);
            textBoxTask_VVV.TabIndex = 0;
            textBoxTask_VVV.Text = "Протабулировать функцию (sin(x)-2x)/(3x-1)+sin(x)-3x+2 на заданном диапазоне. Результат вывести в DataGridView и построить график функции.  ";
            // 
            // groupBoxInput_VVV
            // 
            groupBoxInput_VVV.Controls.Add(textBoxStopStep_VVV);
            groupBoxInput_VVV.Controls.Add(textBoxStartStep_VVV);
            groupBoxInput_VVV.Controls.Add(labelStopStep_VVV);
            groupBoxInput_VVV.Controls.Add(labelStartStep_VVV);
            groupBoxInput_VVV.Location = new Point(13, 308);
            groupBoxInput_VVV.Name = "groupBoxInput_VVV";
            groupBoxInput_VVV.Size = new Size(239, 102);
            groupBoxInput_VVV.TabIndex = 1;
            groupBoxInput_VVV.TabStop = false;
            groupBoxInput_VVV.Text = "Ввод данных:";
            // 
            // textBoxStopStep_VVV
            // 
            textBoxStopStep_VVV.Location = new Point(122, 63);
            textBoxStopStep_VVV.Name = "textBoxStopStep_VVV";
            textBoxStopStep_VVV.Size = new Size(102, 27);
            textBoxStopStep_VVV.TabIndex = 3;
            // 
            // textBoxStartStep_VVV
            // 
            textBoxStartStep_VVV.Location = new Point(16, 63);
            textBoxStartStep_VVV.Name = "textBoxStartStep_VVV";
            textBoxStartStep_VVV.Size = new Size(100, 27);
            textBoxStartStep_VVV.TabIndex = 2;
            // 
            // labelStopStep_VVV
            // 
            labelStopStep_VVV.BackColor = SystemColors.Control;
            labelStopStep_VVV.Location = new Point(122, 28);
            labelStopStep_VVV.Name = "labelStopStep_VVV";
            labelStopStep_VVV.Size = new Size(102, 27);
            labelStopStep_VVV.TabIndex = 1;
            labelStopStep_VVV.Text = "Конец шага:";
            // 
            // labelStartStep_VVV
            // 
            labelStartStep_VVV.BackColor = SystemColors.Control;
            labelStartStep_VVV.Location = new Point(16, 28);
            labelStartStep_VVV.Name = "labelStartStep_VVV";
            labelStartStep_VVV.Size = new Size(100, 27);
            labelStartStep_VVV.TabIndex = 0;
            labelStartStep_VVV.Text = "Старт шага:";
            // 
            // buttonHelp_VVV
            // 
            buttonHelp_VVV.BackColor = Color.RoyalBlue;
            buttonHelp_VVV.Location = new Point(258, 327);
            buttonHelp_VVV.Name = "buttonHelp_VVV";
            buttonHelp_VVV.Size = new Size(76, 70);
            buttonHelp_VVV.TabIndex = 2;
            buttonHelp_VVV.Text = "Справка";
            buttonHelp_VVV.UseVisualStyleBackColor = false;
            buttonHelp_VVV.Click += buttonHelp_VVV_Click;
            // 
            // buttonDone_VVV
            // 
            buttonDone_VVV.BackColor = Color.FromArgb(0, 192, 0);
            buttonDone_VVV.Location = new Point(340, 330);
            buttonDone_VVV.Name = "buttonDone_VVV";
            buttonDone_VVV.Size = new Size(132, 64);
            buttonDone_VVV.TabIndex = 3;
            buttonDone_VVV.Text = "Выполнить";
            buttonDone_VVV.UseVisualStyleBackColor = false;
            buttonDone_VVV.Click += buttonDone_VVV_Click;
            buttonDone_VVV.MouseDown += buttonDone_VVV_MouseDown;
            buttonDone_VVV.MouseEnter += buttonDone_VVV_MouseEnter;
            buttonDone_VVV.MouseLeave += buttonDone_VVV_MouseLeave;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxResult_VVV);
            groupBox3.Controls.Add(chartFunction_VVV);
            groupBox3.Controls.Add(dataGridViewFunction_VVV);
            groupBox3.Location = new Point(470, 26);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(561, 373);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод данных:";
            // 
            // textBoxResult_VVV
            // 
            textBoxResult_VVV.BackColor = SystemColors.Control;
            textBoxResult_VVV.Location = new Point(13, 34);
            textBoxResult_VVV.Name = "textBoxResult_VVV";
            textBoxResult_VVV.Size = new Size(91, 27);
            textBoxResult_VVV.TabIndex = 2;
            textBoxResult_VVV.Text = "Результат:";
            // 
            // chartFunction_VVV
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_VVV.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_VVV.Legends.Add(legend1);
            chartFunction_VVV.Location = new Point(110, 60);
            chartFunction_VVV.Name = "chartFunction_VVV";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_VVV.Series.Add(series1);
            chartFunction_VVV.Size = new Size(445, 307);
            chartFunction_VVV.TabIndex = 1;
            chartFunction_VVV.Text = "chart_vvv";
            chartFunction_VVV.Click += chartFunction_VVV_Click;
            // 
            // dataGridViewFunction_VVV
            // 
            dataGridViewFunction_VVV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_VVV.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            dataGridViewFunction_VVV.Location = new Point(13, 60);
            dataGridViewFunction_VVV.Name = "dataGridViewFunction_VVV";
            dataGridViewFunction_VVV.RowHeadersVisible = false;
            dataGridViewFunction_VVV.RowHeadersWidth = 51;
            dataGridViewFunction_VVV.Size = new Size(97, 308);
            dataGridViewFunction_VVV.TabIndex = 0;
            dataGridViewFunction_VVV.CellContentClick += dataGridViewFunction_VVV_CellContentClick;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.Width = 50;
            // 
            // Y
            // 
            Y.HeaderText = "F(X)";
            Y.MinimumWidth = 6;
            Y.Name = "Y";
            Y.Width = 50;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 409);
            Controls.Add(groupBox3);
            Controls.Add(buttonDone_VVV);
            Controls.Add(buttonHelp_VVV);
            Controls.Add(groupBoxInput_VVV);
            Controls.Add(groupBoxTask_VVV);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 28 | Вегерина В. В.";
            groupBoxTask_VVV.ResumeLayout(false);
            groupBoxTask_VVV.PerformLayout();
            groupBoxInput_VVV.ResumeLayout(false);
            groupBoxInput_VVV.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_VVV).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_VVV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_VVV;
        private TextBox textBoxTask_VVV;
        private GroupBox groupBoxInput_VVV;
        private TextBox textBoxStopStep_VVV;
        private TextBox textBoxStartStep_VVV;
        private TextBox labelStopStep_VVV;
        private TextBox labelStartStep_VVV;
        private Button buttonHelp_VVV;
        private Button buttonDone_VVV;
        private GroupBox groupBox3;
        private DataGridView dataGridViewFunction_VVV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_VVV;
        private TextBox textBoxResult_VVV;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
    }
}

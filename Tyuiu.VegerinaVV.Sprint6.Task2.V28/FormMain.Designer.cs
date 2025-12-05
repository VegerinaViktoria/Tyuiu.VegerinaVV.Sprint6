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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxTask_VVV = new GroupBox();
            textBoxTask_VVV = new TextBox();
            groupBoxInput_VVV = new GroupBox();
            textBoxStopStep_VVV = new TextBox();
            textBoxStartStep_VVV = new TextBox();
            labelStopStep_VVV = new TextBox();
            labelStartStep_VVV = new TextBox();
            groupBoxOutput_VVV = new GroupBox();
            dataGridViewFunction_VVV = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            labelResult_VVV = new TextBox();
            chartFunction_VVV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonHelp_VVV = new Button();
            buttonDone_VVV = new Button();
            groupBoxTask_VVV.SuspendLayout();
            groupBoxInput_VVV.SuspendLayout();
            groupBoxOutput_VVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_VVV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction_VVV).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_VVV
            // 
            groupBoxTask_VVV.Controls.Add(textBoxTask_VVV);
            groupBoxTask_VVV.Location = new Point(15, 13);
            groupBoxTask_VVV.Name = "groupBoxTask_VVV";
            groupBoxTask_VVV.Size = new Size(415, 312);
            groupBoxTask_VVV.TabIndex = 0;
            groupBoxTask_VVV.TabStop = false;
            groupBoxTask_VVV.Text = "Условие:";
            // 
            // textBoxTask_VVV
            // 
            textBoxTask_VVV.BackColor = SystemColors.Control;
            textBoxTask_VVV.Location = new Point(-3, 33);
            textBoxTask_VVV.Multiline = true;
            textBoxTask_VVV.Name = "textBoxTask_VVV";
            textBoxTask_VVV.Size = new Size(418, 279);
            textBoxTask_VVV.TabIndex = 0;
            textBoxTask_VVV.Text = "Протабулировать функцию (sin(x)-2x)/(3x-1)+sin(x)-3x+2 на заданном диапазоне. Результат вывести в DataGridView и построить график функции.";
            // 
            // groupBoxInput_VVV
            // 
            groupBoxInput_VVV.Controls.Add(textBoxStopStep_VVV);
            groupBoxInput_VVV.Controls.Add(textBoxStartStep_VVV);
            groupBoxInput_VVV.Controls.Add(labelStopStep_VVV);
            groupBoxInput_VVV.Controls.Add(labelStartStep_VVV);
            groupBoxInput_VVV.Location = new Point(3, 352);
            groupBoxInput_VVV.Name = "groupBoxInput_VVV";
            groupBoxInput_VVV.Size = new Size(260, 101);
            groupBoxInput_VVV.TabIndex = 1;
            groupBoxInput_VVV.TabStop = false;
            groupBoxInput_VVV.Text = "Ввод данных:";
            // 
            // textBoxStopStep_VVV
            // 
            textBoxStopStep_VVV.Location = new Point(128, 60);
            textBoxStopStep_VVV.Name = "textBoxStopStep_VVV";
            textBoxStopStep_VVV.Size = new Size(111, 27);
            textBoxStopStep_VVV.TabIndex = 3;
            // 
            // textBoxStartStep_VVV
            // 
            textBoxStartStep_VVV.Location = new Point(18, 60);
            textBoxStartStep_VVV.Name = "textBoxStartStep_VVV";
            textBoxStartStep_VVV.Size = new Size(104, 27);
            textBoxStartStep_VVV.TabIndex = 2;
            // 
            // labelStopStep_VVV
            // 
            labelStopStep_VVV.BackColor = SystemColors.Control;
            labelStopStep_VVV.Location = new Point(128, 27);
            labelStopStep_VVV.Name = "labelStopStep_VVV";
            labelStopStep_VVV.Size = new Size(111, 27);
            labelStopStep_VVV.TabIndex = 1;
            labelStopStep_VVV.Text = "Конец шага:";
            // 
            // labelStartStep_VVV
            // 
            labelStartStep_VVV.BackColor = SystemColors.Control;
            labelStartStep_VVV.Location = new Point(18, 27);
            labelStartStep_VVV.Name = "labelStartStep_VVV";
            labelStartStep_VVV.Size = new Size(104, 27);
            labelStartStep_VVV.TabIndex = 0;
            labelStartStep_VVV.Text = "Старт шага:";
            // 
            // groupBoxOutput_VVV
            // 
            groupBoxOutput_VVV.Controls.Add(dataGridViewFunction_VVV);
            groupBoxOutput_VVV.Controls.Add(labelResult_VVV);
            groupBoxOutput_VVV.Controls.Add(chartFunction_VVV);
            groupBoxOutput_VVV.Location = new Point(492, 23);
            groupBoxOutput_VVV.Name = "groupBoxOutput_VVV";
            groupBoxOutput_VVV.Size = new Size(573, 430);
            groupBoxOutput_VVV.TabIndex = 2;
            groupBoxOutput_VVV.TabStop = false;
            groupBoxOutput_VVV.Text = "Вывод данных:";
            // 
            // dataGridViewFunction_VVV
            // 
            dataGridViewFunction_VVV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_VVV.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            dataGridViewFunction_VVV.Location = new Point(6, 48);
            dataGridViewFunction_VVV.Name = "dataGridViewFunction_VVV";
            dataGridViewFunction_VVV.RowHeadersVisible = false;
            dataGridViewFunction_VVV.RowHeadersWidth = 51;
            dataGridViewFunction_VVV.ScrollBars = ScrollBars.Vertical;
            dataGridViewFunction_VVV.Size = new Size(116, 376);
            dataGridViewFunction_VVV.TabIndex = 2;
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
            // labelResult_VVV
            // 
            labelResult_VVV.BackColor = SystemColors.Control;
            labelResult_VVV.BorderStyle = BorderStyle.None;
            labelResult_VVV.Location = new Point(6, 23);
            labelResult_VVV.Name = "labelResult_VVV";
            labelResult_VVV.Size = new Size(106, 20);
            labelResult_VVV.TabIndex = 1;
            labelResult_VVV.Text = "Результат:";
            // 
            // chartFunction_VVV
            // 
            chartFunction_VVV.BorderlineWidth = 10;
            chartArea1.Name = "ChartArea1";
            chartFunction_VVV.ChartAreas.Add(chartArea1);
            chartFunction_VVV.Location = new Point(118, 41);
            chartFunction_VVV.Name = "chartFunction_VVV";
            series1.BorderColor = Color.Black;
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.Name = "Series1";
            chartFunction_VVV.Series.Add(series1);
            chartFunction_VVV.Size = new Size(455, 383);
            chartFunction_VVV.TabIndex = 0;
            chartFunction_VVV.Text = "chart_VVV";
            chartFunction_VVV.Click += chartFunction_VVV_Click;
            // 
            // buttonHelp_VVV
            // 
            buttonHelp_VVV.BackColor = SystemColors.Highlight;
            buttonHelp_VVV.Location = new Point(269, 373);
            buttonHelp_VVV.Name = "buttonHelp_VVV";
            buttonHelp_VVV.Size = new Size(80, 72);
            buttonHelp_VVV.TabIndex = 3;
            buttonHelp_VVV.Text = "Справка";
            buttonHelp_VVV.UseVisualStyleBackColor = false;
            buttonHelp_VVV.Click += buttonHelp_VVV_Click;
            // 
            // buttonDone_VVV
            // 
            buttonDone_VVV.BackColor = Color.FromArgb(0, 192, 0);
            buttonDone_VVV.Location = new Point(368, 373);
            buttonDone_VVV.Name = "buttonDone_VVV";
            buttonDone_VVV.Size = new Size(118, 72);
            buttonDone_VVV.TabIndex = 4;
            buttonDone_VVV.Text = "Выполнить";
            buttonDone_VVV.UseVisualStyleBackColor = false;
            buttonDone_VVV.Click += buttonDone_VVV_Click;
            buttonDone_VVV.MouseDown += buttonDone_VVV_MouseDown;
            buttonDone_VVV.MouseEnter += buttonDone_VVV_MouseEnter;
            buttonDone_VVV.MouseLeave += buttonDone_VVV_MouseLeave;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 453);
            Controls.Add(buttonDone_VVV);
            Controls.Add(buttonHelp_VVV);
            Controls.Add(groupBoxOutput_VVV);
            Controls.Add(groupBoxInput_VVV);
            Controls.Add(groupBoxTask_VVV);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 28 | Вегерина В. В.";
            groupBoxTask_VVV.ResumeLayout(false);
            groupBoxTask_VVV.PerformLayout();
            groupBoxInput_VVV.ResumeLayout(false);
            groupBoxInput_VVV.PerformLayout();
            groupBoxOutput_VVV.ResumeLayout(false);
            groupBoxOutput_VVV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_VVV).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction_VVV).EndInit();
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
        private GroupBox groupBoxOutput_VVV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_VVV;
        private DataGridView dataGridViewFunction_VVV;
        private TextBox labelResult_VVV;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
        private Button buttonHelp_VVV;
        private Button buttonDone_VVV;
    }
}

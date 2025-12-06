namespace Tyuiu.VegerinaVV.Sprint6.Task4.V26
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            panelTop_VVV = new Panel();
            buttonSave_VVV = new Button();
            buttonDone_VVV = new Button();
            groupBoxInput_VVV = new GroupBox();
            textBoxStopStep_VVV = new TextBox();
            labelStopStep_VVV = new TextBox();
            textBoxStartStep_VVV = new TextBox();
            labelStartStep_VVV = new TextBox();
            buttonHelp_VVV = new Button();
            groupBoxTask_VVV = new GroupBox();
            textBoxTask_VVV = new TextBox();
            panelLeft_VVV = new Panel();
            groupBoxOutput_VVV = new GroupBox();
            textBoxResuit_VVV = new TextBox();
            panelFill_VVV = new Panel();
            chartFunction_VVV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitterPanel_VVV = new Splitter();
            panelTop_VVV.SuspendLayout();
            groupBoxInput_VVV.SuspendLayout();
            groupBoxTask_VVV.SuspendLayout();
            panelLeft_VVV.SuspendLayout();
            groupBoxOutput_VVV.SuspendLayout();
            panelFill_VVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_VVV).BeginInit();
            SuspendLayout();
            // 
            // panelTop_VVV
            // 
            panelTop_VVV.Controls.Add(buttonSave_VVV);
            panelTop_VVV.Controls.Add(buttonDone_VVV);
            panelTop_VVV.Controls.Add(groupBoxInput_VVV);
            panelTop_VVV.Controls.Add(buttonHelp_VVV);
            panelTop_VVV.Controls.Add(groupBoxTask_VVV);
            panelTop_VVV.Dock = DockStyle.Top;
            panelTop_VVV.Location = new Point(0, 0);
            panelTop_VVV.Name = "panelTop_VVV";
            panelTop_VVV.Size = new Size(945, 119);
            panelTop_VVV.TabIndex = 0;
            // 
            // buttonSave_VVV
            // 
            buttonSave_VVV.BackColor = Color.DodgerBlue;
            buttonSave_VVV.Cursor = Cursors.Hand;
            buttonSave_VVV.Location = new Point(751, 26);
            buttonSave_VVV.Name = "buttonSave_VVV";
            buttonSave_VVV.Size = new Size(101, 56);
            buttonSave_VVV.TabIndex = 4;
            buttonSave_VVV.Text = "Сохранить";
            buttonSave_VVV.UseVisualStyleBackColor = false;
            buttonSave_VVV.Click += buttonSave_VVV_Click;
            // 
            // buttonDone_VVV
            // 
            buttonDone_VVV.BackColor = Color.Green;
            buttonDone_VVV.Cursor = Cursors.Hand;
            buttonDone_VVV.Location = new Point(647, 26);
            buttonDone_VVV.Name = "buttonDone_VVV";
            buttonDone_VVV.Size = new Size(98, 56);
            buttonDone_VVV.TabIndex = 3;
            buttonDone_VVV.Text = "Выполнить";
            buttonDone_VVV.UseVisualStyleBackColor = false;
            buttonDone_VVV.Click += buttonDone_VVV_Click;
            // 
            // groupBoxInput_VVV
            // 
            groupBoxInput_VVV.Controls.Add(textBoxStopStep_VVV);
            groupBoxInput_VVV.Controls.Add(labelStopStep_VVV);
            groupBoxInput_VVV.Controls.Add(textBoxStartStep_VVV);
            groupBoxInput_VVV.Controls.Add(labelStartStep_VVV);
            groupBoxInput_VVV.Location = new Point(410, 3);
            groupBoxInput_VVV.Name = "groupBoxInput_VVV";
            groupBoxInput_VVV.Size = new Size(231, 84);
            groupBoxInput_VVV.TabIndex = 2;
            groupBoxInput_VVV.TabStop = false;
            groupBoxInput_VVV.Text = "Ввод данных:";
            // 
            // textBoxStopStep_VVV
            // 
            textBoxStopStep_VVV.Location = new Point(123, 55);
            textBoxStopStep_VVV.Name = "textBoxStopStep_VVV";
            textBoxStopStep_VVV.Size = new Size(95, 27);
            textBoxStopStep_VVV.TabIndex = 3;
            // 
            // labelStopStep_VVV
            // 
            labelStopStep_VVV.BorderStyle = BorderStyle.None;
            labelStopStep_VVV.Location = new Point(124, 25);
            labelStopStep_VVV.Name = "labelStopStep_VVV";
            labelStopStep_VVV.ReadOnly = true;
            labelStopStep_VVV.Size = new Size(94, 20);
            labelStopStep_VVV.TabIndex = 2;
            labelStopStep_VVV.Text = "Конец шага:";
            // 
            // textBoxStartStep_VVV
            // 
            textBoxStartStep_VVV.Location = new Point(13, 55);
            textBoxStartStep_VVV.Name = "textBoxStartStep_VVV";
            textBoxStartStep_VVV.Size = new Size(96, 27);
            textBoxStartStep_VVV.TabIndex = 1;
            // 
            // labelStartStep_VVV
            // 
            labelStartStep_VVV.BorderStyle = BorderStyle.None;
            labelStartStep_VVV.Location = new Point(13, 25);
            labelStartStep_VVV.Name = "labelStartStep_VVV";
            labelStartStep_VVV.ReadOnly = true;
            labelStartStep_VVV.Size = new Size(96, 20);
            labelStartStep_VVV.TabIndex = 0;
            labelStartStep_VVV.Text = "Старт шага:";
            // 
            // buttonHelp_VVV
            // 
            buttonHelp_VVV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_VVV.BackColor = SystemColors.HotTrack;
            buttonHelp_VVV.Cursor = Cursors.Hand;
            buttonHelp_VVV.Location = new Point(852, 26);
            buttonHelp_VVV.Name = "buttonHelp_VVV";
            buttonHelp_VVV.Size = new Size(90, 56);
            buttonHelp_VVV.TabIndex = 1;
            buttonHelp_VVV.Text = "Справка";
            buttonHelp_VVV.UseVisualStyleBackColor = false;
            buttonHelp_VVV.Click += buttonHelp_VVV_Click;
            // 
            // groupBoxTask_VVV
            // 
            groupBoxTask_VVV.Controls.Add(textBoxTask_VVV);
            groupBoxTask_VVV.Location = new Point(13, 0);
            groupBoxTask_VVV.Name = "groupBoxTask_VVV";
            groupBoxTask_VVV.Size = new Size(391, 119);
            groupBoxTask_VVV.TabIndex = 0;
            groupBoxTask_VVV.TabStop = false;
            groupBoxTask_VVV.Text = "Условие:";
            // 
            // textBoxTask_VVV
            // 
            textBoxTask_VVV.Dock = DockStyle.Fill;
            textBoxTask_VVV.Location = new Point(3, 23);
            textBoxTask_VVV.Multiline = true;
            textBoxTask_VVV.Name = "textBoxTask_VVV";
            textBoxTask_VVV.ReadOnly = true;
            textBoxTask_VVV.Size = new Size(385, 93);
            textBoxTask_VVV.TabIndex = 0;
            textBoxTask_VVV.Text = "Протабулировать функцию 5-3x+(1+sin(x))/(2x-0,5) на заданном диапазоне от -5 до 5. Результат вывести в textBox, построить график функции и сохранить в файл OutPutTask4V26.txt по нажатию кнопки. ";
            // 
            // panelLeft_VVV
            // 
            panelLeft_VVV.Controls.Add(groupBoxOutput_VVV);
            panelLeft_VVV.Dock = DockStyle.Left;
            panelLeft_VVV.Location = new Point(0, 119);
            panelLeft_VVV.Name = "panelLeft_VVV";
            panelLeft_VVV.Padding = new Padding(5);
            panelLeft_VVV.Size = new Size(206, 322);
            panelLeft_VVV.TabIndex = 1;
            // 
            // groupBoxOutput_VVV
            // 
            groupBoxOutput_VVV.Controls.Add(textBoxResuit_VVV);
            groupBoxOutput_VVV.Dock = DockStyle.Fill;
            groupBoxOutput_VVV.Location = new Point(5, 5);
            groupBoxOutput_VVV.Name = "groupBoxOutput_VVV";
            groupBoxOutput_VVV.Size = new Size(196, 312);
            groupBoxOutput_VVV.TabIndex = 0;
            groupBoxOutput_VVV.TabStop = false;
            groupBoxOutput_VVV.Text = "Вывод:";
            // 
            // textBoxResuit_VVV
            // 
            textBoxResuit_VVV.Dock = DockStyle.Fill;
            textBoxResuit_VVV.Location = new Point(3, 23);
            textBoxResuit_VVV.Multiline = true;
            textBoxResuit_VVV.Name = "textBoxResuit_VVV";
            textBoxResuit_VVV.ScrollBars = ScrollBars.Vertical;
            textBoxResuit_VVV.Size = new Size(190, 286);
            textBoxResuit_VVV.TabIndex = 0;
            // 
            // panelFill_VVV
            // 
            panelFill_VVV.Controls.Add(chartFunction_VVV);
            panelFill_VVV.Controls.Add(splitterPanel_VVV);
            panelFill_VVV.Dock = DockStyle.Fill;
            panelFill_VVV.Location = new Point(206, 119);
            panelFill_VVV.Name = "panelFill_VVV";
            panelFill_VVV.Size = new Size(739, 322);
            panelFill_VVV.TabIndex = 2;
            // 
            // chartFunction_VVV
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_VVV.ChartAreas.Add(chartArea1);
            chartFunction_VVV.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartFunction_VVV.Legends.Add(legend1);
            chartFunction_VVV.Location = new Point(4, 0);
            chartFunction_VVV.Name = "chartFunction_VVV";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_VVV.Series.Add(series1);
            chartFunction_VVV.Size = new Size(735, 322);
            chartFunction_VVV.TabIndex = 1;
            chartFunction_VVV.Text = "chart_VVV";
            title1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            title1.ForeColor = Color.FromArgb(0, 0, 192);
            title1.Name = "TitleSin";
            title1.Text = "График функции 5-3x+(1+sin(x))/(2x-0,5)";
            chartFunction_VVV.Titles.Add(title1);
            // 
            // splitterPanel_VVV
            // 
            splitterPanel_VVV.Location = new Point(0, 0);
            splitterPanel_VVV.Name = "splitterPanel_VVV";
            splitterPanel_VVV.Size = new Size(4, 322);
            splitterPanel_VVV.TabIndex = 0;
            splitterPanel_VVV.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 441);
            Controls.Add(panelFill_VVV);
            Controls.Add(panelLeft_VVV);
            Controls.Add(panelTop_VVV);
            MinimumSize = new Size(800, 450);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 26 | Вегерина В. В.";
            panelTop_VVV.ResumeLayout(false);
            groupBoxInput_VVV.ResumeLayout(false);
            groupBoxInput_VVV.PerformLayout();
            groupBoxTask_VVV.ResumeLayout(false);
            groupBoxTask_VVV.PerformLayout();
            panelLeft_VVV.ResumeLayout(false);
            groupBoxOutput_VVV.ResumeLayout(false);
            groupBoxOutput_VVV.PerformLayout();
            panelFill_VVV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_VVV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_VVV;
        private Panel panelLeft_VVV;
        private GroupBox groupBoxOutput_VVV;
        private Panel panelFill_VVV;
        private Splitter splitterPanel_VVV;
        private TextBox textBoxResuit_VVV;
        private GroupBox groupBoxInput_VVV;
        private TextBox labelStartStep_VVV;
        private Button buttonHelp_VVV;
        private GroupBox groupBoxTask_VVV;
        private Button buttonSave_VVV;
        private Button buttonDone_VVV;
        private TextBox textBoxStopStep_VVV;
        private TextBox labelStopStep_VVV;
        private TextBox textBoxStartStep_VVV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_VVV;
        private TextBox textBoxTask_VVV;
    }
}

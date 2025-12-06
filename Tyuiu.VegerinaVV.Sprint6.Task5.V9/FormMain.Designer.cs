namespace Tyuiu.VegerinaVV.Sprint6.Task5.V9
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
            panelTop_VVV = new Panel();
            buttonHelp_VVV = new Button();
            buttonOpenFile_VVV = new Button();
            buttonDone_VVV = new Button();
            groupBoxTask_VVV = new GroupBox();
            textBoxTask_VVV = new TextBox();
            panelLeft_VVV = new Panel();
            groupBoxOutput_VVV = new GroupBox();
            dataGridViewResult_VVV = new DataGridView();
            panelFill_VVV = new Panel();
            chartFunction_VVV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitterPanel_VVV = new Splitter();
            panelTop_VVV.SuspendLayout();
            groupBoxTask_VVV.SuspendLayout();
            panelLeft_VVV.SuspendLayout();
            groupBoxOutput_VVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_VVV).BeginInit();
            panelFill_VVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_VVV).BeginInit();
            SuspendLayout();
            // 
            // panelTop_VVV
            // 
            panelTop_VVV.Controls.Add(buttonHelp_VVV);
            panelTop_VVV.Controls.Add(buttonOpenFile_VVV);
            panelTop_VVV.Controls.Add(buttonDone_VVV);
            panelTop_VVV.Controls.Add(groupBoxTask_VVV);
            panelTop_VVV.Dock = DockStyle.Top;
            panelTop_VVV.Location = new Point(0, 0);
            panelTop_VVV.Name = "panelTop_VVV";
            panelTop_VVV.Size = new Size(937, 103);
            panelTop_VVV.TabIndex = 0;
            // 
            // buttonHelp_VVV
            // 
            buttonHelp_VVV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_VVV.BackColor = SystemColors.Highlight;
            buttonHelp_VVV.Cursor = Cursors.Hand;
            buttonHelp_VVV.Location = new Point(801, 21);
            buttonHelp_VVV.Name = "buttonHelp_VVV";
            buttonHelp_VVV.Size = new Size(106, 65);
            buttonHelp_VVV.TabIndex = 3;
            buttonHelp_VVV.Text = "Справка";
            buttonHelp_VVV.UseVisualStyleBackColor = false;
            buttonHelp_VVV.Click += buttonHelp_VVV_Click;
            // 
            // buttonOpenFile_VVV
            // 
            buttonOpenFile_VVV.BackColor = Color.RoyalBlue;
            buttonOpenFile_VVV.Cursor = Cursors.Hand;
            buttonOpenFile_VVV.Location = new Point(655, 21);
            buttonOpenFile_VVV.Name = "buttonOpenFile_VVV";
            buttonOpenFile_VVV.Size = new Size(118, 67);
            buttonOpenFile_VVV.TabIndex = 2;
            buttonOpenFile_VVV.Text = "Открыть файл";
            buttonOpenFile_VVV.UseVisualStyleBackColor = false;
            buttonOpenFile_VVV.Click += buttonOpenFile_VVV_Click;
            // 
            // buttonDone_VVV
            // 
            buttonDone_VVV.BackColor = Color.FromArgb(0, 192, 0);
            buttonDone_VVV.Cursor = Cursors.Hand;
            buttonDone_VVV.Location = new Point(533, 21);
            buttonDone_VVV.Name = "buttonDone_VVV";
            buttonDone_VVV.Size = new Size(116, 67);
            buttonDone_VVV.TabIndex = 1;
            buttonDone_VVV.Text = "Выполнить";
            buttonDone_VVV.UseVisualStyleBackColor = false;
            buttonDone_VVV.Click += buttonDone_VVV_Click;
            // 
            // groupBoxTask_VVV
            // 
            groupBoxTask_VVV.Controls.Add(textBoxTask_VVV);
            groupBoxTask_VVV.Location = new Point(10, 3);
            groupBoxTask_VVV.Name = "groupBoxTask_VVV";
            groupBoxTask_VVV.Size = new Size(517, 97);
            groupBoxTask_VVV.TabIndex = 0;
            groupBoxTask_VVV.TabStop = false;
            groupBoxTask_VVV.Text = "Условие:";
            // 
            // textBoxTask_VVV
            // 
            textBoxTask_VVV.Location = new Point(6, 18);
            textBoxTask_VVV.Multiline = true;
            textBoxTask_VVV.Name = "textBoxTask_VVV";
            textBoxTask_VVV.ReadOnly = true;
            textBoxTask_VVV.Size = new Size(505, 73);
            textBoxTask_VVV.TabIndex = 0;
            textBoxTask_VVV.Text = "Прочитать данные из файла InPutFileTask5V9.txt. \r\nВывести в dataGridView все элементы равные нулю.\r\nПостроить диаграмму по этим значениям.";
            // 
            // panelLeft_VVV
            // 
            panelLeft_VVV.Controls.Add(groupBoxOutput_VVV);
            panelLeft_VVV.Dock = DockStyle.Left;
            panelLeft_VVV.Location = new Point(0, 103);
            panelLeft_VVV.Name = "panelLeft_VVV";
            panelLeft_VVV.Size = new Size(255, 300);
            panelLeft_VVV.TabIndex = 1;
            // 
            // groupBoxOutput_VVV
            // 
            groupBoxOutput_VVV.Controls.Add(dataGridViewResult_VVV);
            groupBoxOutput_VVV.Dock = DockStyle.Fill;
            groupBoxOutput_VVV.Location = new Point(0, 0);
            groupBoxOutput_VVV.Name = "groupBoxOutput_VVV";
            groupBoxOutput_VVV.Size = new Size(255, 300);
            groupBoxOutput_VVV.TabIndex = 0;
            groupBoxOutput_VVV.TabStop = false;
            groupBoxOutput_VVV.Text = "Вывод данных:";
            // 
            // dataGridViewResult_VVV
            // 
            dataGridViewResult_VVV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_VVV.Dock = DockStyle.Fill;
            dataGridViewResult_VVV.Location = new Point(3, 23);
            dataGridViewResult_VVV.Name = "dataGridViewResult_VVV";
            dataGridViewResult_VVV.RowHeadersVisible = false;
            dataGridViewResult_VVV.RowHeadersWidth = 51;
            dataGridViewResult_VVV.Size = new Size(249, 274);
            dataGridViewResult_VVV.TabIndex = 0;
            // 
            // panelFill_VVV
            // 
            panelFill_VVV.Controls.Add(chartFunction_VVV);
            panelFill_VVV.Dock = DockStyle.Fill;
            panelFill_VVV.Location = new Point(255, 103);
            panelFill_VVV.Name = "panelFill_VVV";
            panelFill_VVV.Size = new Size(682, 300);
            panelFill_VVV.TabIndex = 2;
            // 
            // chartFunction_VVV
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_VVV.ChartAreas.Add(chartArea1);
            chartFunction_VVV.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartFunction_VVV.Legends.Add(legend1);
            chartFunction_VVV.Location = new Point(0, 0);
            chartFunction_VVV.Name = "chartFunction_VVV";
            series1.ChartArea = "ChartArea1";
            series1.Color = Color.ForestGreen;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_VVV.Series.Add(series1);
            chartFunction_VVV.Size = new Size(682, 300);
            chartFunction_VVV.TabIndex = 0;
            chartFunction_VVV.Text = "chart_VVV";
            chartFunction_VVV.Click += chartFunction_VVV_Click;
            // 
            // splitterPanel_VVV
            // 
            splitterPanel_VVV.Location = new Point(255, 103);
            splitterPanel_VVV.Name = "splitterPanel_VVV";
            splitterPanel_VVV.Size = new Size(4, 300);
            splitterPanel_VVV.TabIndex = 3;
            splitterPanel_VVV.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 403);
            Controls.Add(splitterPanel_VVV);
            Controls.Add(panelFill_VVV);
            Controls.Add(panelLeft_VVV);
            Controls.Add(panelTop_VVV);
            MinimumSize = new Size(800, 450);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 9 | Вегерина В. В.";
            panelTop_VVV.ResumeLayout(false);
            groupBoxTask_VVV.ResumeLayout(false);
            groupBoxTask_VVV.PerformLayout();
            panelLeft_VVV.ResumeLayout(false);
            groupBoxOutput_VVV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_VVV).EndInit();
            panelFill_VVV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_VVV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_VVV;
        private Panel panelLeft_VVV;
        private Panel panelFill_VVV;
        private Splitter splitterPanel_VVV;
        private GroupBox groupBoxOutput_VVV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_VVV;
        private GroupBox groupBoxTask_VVV;
        private TextBox textBoxTask_VVV;
        private Button buttonHelp_VVV;
        private Button buttonOpenFile_VVV;
        private Button buttonDone_VVV;
        private DataGridView dataGridViewResult_VVV;
    }
}

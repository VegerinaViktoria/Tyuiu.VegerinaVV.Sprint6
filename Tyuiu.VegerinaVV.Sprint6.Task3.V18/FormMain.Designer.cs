namespace Tyuiu.VegerinaVV.Sprint6.Task3.V18
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxData_VVV = new GroupBox();
            textBoxData_VVV = new TextBox();
            dataGridViewMatrix_VVV = new DataGridView();
            groupBoxOutput_VVV = new GroupBox();
            dataGridViewResult_VVV = new DataGridView();
            labelResult_VVV = new TextBox();
            buttonHelp_VVV = new Button();
            buttonDone_VVV = new Button();
            groupBoxMatrix_VVV = new GroupBox();
            groupBoxData_VVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_VVV).BeginInit();
            groupBoxOutput_VVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_VVV).BeginInit();
            groupBoxMatrix_VVV.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxData_VVV
            // 
            groupBoxData_VVV.Controls.Add(textBoxData_VVV);
            groupBoxData_VVV.Location = new Point(12, 17);
            groupBoxData_VVV.Name = "groupBoxData_VVV";
            groupBoxData_VVV.Size = new Size(333, 315);
            groupBoxData_VVV.TabIndex = 0;
            groupBoxData_VVV.TabStop = false;
            groupBoxData_VVV.Text = "Условие:";
            // 
            // textBoxData_VVV
            // 
            textBoxData_VVV.Location = new Point(0, 29);
            textBoxData_VVV.Multiline = true;
            textBoxData_VVV.Name = "textBoxData_VVV";
            textBoxData_VVV.ReadOnly = true;
            textBoxData_VVV.Size = new Size(323, 286);
            textBoxData_VVV.TabIndex = 0;
            textBoxData_VVV.Text = resources.GetString("textBoxData_VVV.Text");
            // 
            // dataGridViewMatrix_VVV
            // 
            dataGridViewMatrix_VVV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_VVV.ColumnHeadersVisible = false;
            dataGridViewMatrix_VVV.Location = new Point(10, 61);
            dataGridViewMatrix_VVV.Name = "dataGridViewMatrix_VVV";
            dataGridViewMatrix_VVV.RowHeadersVisible = false;
            dataGridViewMatrix_VVV.RowHeadersWidth = 51;
            dataGridViewMatrix_VVV.Size = new Size(270, 245);
            dataGridViewMatrix_VVV.TabIndex = 1;
            // 
            // groupBoxOutput_VVV
            // 
            groupBoxOutput_VVV.Controls.Add(dataGridViewResult_VVV);
            groupBoxOutput_VVV.Controls.Add(labelResult_VVV);
            groupBoxOutput_VVV.Location = new Point(629, 12);
            groupBoxOutput_VVV.Name = "groupBoxOutput_VVV";
            groupBoxOutput_VVV.Size = new Size(308, 320);
            groupBoxOutput_VVV.TabIndex = 2;
            groupBoxOutput_VVV.TabStop = false;
            groupBoxOutput_VVV.Text = "Вывод данных:";
            // 
            // dataGridViewResult_VVV
            // 
            dataGridViewResult_VVV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_VVV.ColumnHeadersVisible = false;
            dataGridViewResult_VVV.Location = new Point(10, 61);
            dataGridViewResult_VVV.Name = "dataGridViewResult_VVV";
            dataGridViewResult_VVV.RowHeadersVisible = false;
            dataGridViewResult_VVV.RowHeadersWidth = 51;
            dataGridViewResult_VVV.Size = new Size(277, 245);
            dataGridViewResult_VVV.TabIndex = 1;
            // 
            // labelResult_VVV
            // 
            labelResult_VVV.BorderStyle = BorderStyle.None;
            labelResult_VVV.Location = new Point(10, 28);
            labelResult_VVV.Name = "labelResult_VVV";
            labelResult_VVV.ReadOnly = true;
            labelResult_VVV.Size = new Size(137, 20);
            labelResult_VVV.TabIndex = 0;
            labelResult_VVV.Text = "Результат:";
            // 
            // buttonHelp_VVV
            // 
            buttonHelp_VVV.Location = new Point(681, 355);
            buttonHelp_VVV.Name = "buttonHelp_VVV";
            buttonHelp_VVV.Size = new Size(47, 44);
            buttonHelp_VVV.TabIndex = 3;
            buttonHelp_VVV.Text = "?";
            buttonHelp_VVV.UseVisualStyleBackColor = true;
            buttonHelp_VVV.Click += buttonHelp_VVV_Click;
            // 
            // buttonDone_VVV
            // 
            buttonDone_VVV.Location = new Point(756, 353);
            buttonDone_VVV.Name = "buttonDone_VVV";
            buttonDone_VVV.Size = new Size(146, 43);
            buttonDone_VVV.TabIndex = 4;
            buttonDone_VVV.Text = "Выполнить";
            buttonDone_VVV.UseVisualStyleBackColor = true;
            buttonDone_VVV.Click += buttonDone_VVV_Click;
            // 
            // groupBoxMatrix_VVV
            // 
            groupBoxMatrix_VVV.Controls.Add(dataGridViewMatrix_VVV);
            groupBoxMatrix_VVV.Location = new Point(341, 12);
            groupBoxMatrix_VVV.Name = "groupBoxMatrix_VVV";
            groupBoxMatrix_VVV.Size = new Size(290, 320);
            groupBoxMatrix_VVV.TabIndex = 5;
            groupBoxMatrix_VVV.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 411);
            Controls.Add(groupBoxMatrix_VVV);
            Controls.Add(buttonDone_VVV);
            Controls.Add(buttonHelp_VVV);
            Controls.Add(groupBoxOutput_VVV);
            Controls.Add(groupBoxData_VVV);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 18 | Вегерина В. В.";
            Load += FormMain_Load;
            groupBoxData_VVV.ResumeLayout(false);
            groupBoxData_VVV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_VVV).EndInit();
            groupBoxOutput_VVV.ResumeLayout(false);
            groupBoxOutput_VVV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_VVV).EndInit();
            groupBoxMatrix_VVV.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxData_VVV;
        private TextBox textBoxData_VVV;
        private DataGridView dataGridViewMatrix_VVV;
        private GroupBox groupBoxOutput_VVV;
        private DataGridView dataGridViewResult_VVV;
        private TextBox labelResult_VVV;
        private Button buttonHelp_VVV;
        private Button buttonDone_VVV;
        private GroupBox groupBoxMatrix_VVV;
    }
}

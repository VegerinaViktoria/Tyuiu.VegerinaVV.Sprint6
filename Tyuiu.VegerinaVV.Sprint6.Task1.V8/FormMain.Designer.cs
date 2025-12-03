namespace Tyuiu.VegerinaVV.Sprint6.Task1.V8
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
            groupBoxTask_VVV = new GroupBox();
            textBoxTask_VVV = new TextBox();
            groupBoxOutput_VVV = new GroupBox();
            labelResult_VVV = new TextBox();
            textBoxResult_VVV = new TextBox();
            groupBoxInput_VVV = new GroupBox();
            textBoxStopStep_VVV = new TextBox();
            textBoxStartStep_VVV = new TextBox();
            labelStopStep_VVV = new TextBox();
            labelStartStep_VVV = new TextBox();
            buttonHelp_VVV = new Button();
            buttonDone_VVV = new Button();
            groupBoxTask_VVV.SuspendLayout();
            groupBoxOutput_VVV.SuspendLayout();
            groupBoxInput_VVV.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_VVV
            // 
            groupBoxTask_VVV.Controls.Add(textBoxTask_VVV);
            groupBoxTask_VVV.Location = new Point(19, 20);
            groupBoxTask_VVV.Name = "groupBoxTask_VVV";
            groupBoxTask_VVV.Size = new Size(502, 304);
            groupBoxTask_VVV.TabIndex = 0;
            groupBoxTask_VVV.TabStop = false;
            groupBoxTask_VVV.Text = "Условие";
            // 
            // textBoxTask_VVV
            // 
            textBoxTask_VVV.BackColor = SystemColors.Control;
            textBoxTask_VVV.BorderStyle = BorderStyle.None;
            textBoxTask_VVV.Location = new Point(6, 26);
            textBoxTask_VVV.Multiline = true;
            textBoxTask_VVV.Name = "textBoxTask_VVV";
            textBoxTask_VVV.Size = new Size(490, 272);
            textBoxTask_VVV.TabIndex = 0;
            textBoxTask_VVV.Text = "Протабулировать функцию cos(x)/(x-0,4)+sin(x)*8*x+2 на заданном диапазоне. Результат вывести в виде таблицы. ";
            // 
            // groupBoxOutput_VVV
            // 
            groupBoxOutput_VVV.Controls.Add(labelResult_VVV);
            groupBoxOutput_VVV.Controls.Add(textBoxResult_VVV);
            groupBoxOutput_VVV.Location = new Point(531, 33);
            groupBoxOutput_VVV.Name = "groupBoxOutput_VVV";
            groupBoxOutput_VVV.Size = new Size(260, 408);
            groupBoxOutput_VVV.TabIndex = 1;
            groupBoxOutput_VVV.TabStop = false;
            groupBoxOutput_VVV.Text = "Вывод данных";
            // 
            // labelResult_VVV
            // 
            labelResult_VVV.BackColor = SystemColors.Menu;
            labelResult_VVV.BorderStyle = BorderStyle.None;
            labelResult_VVV.Location = new Point(11, 26);
            labelResult_VVV.Name = "labelResult_VVV";
            labelResult_VVV.Size = new Size(236, 20);
            labelResult_VVV.TabIndex = 1;
            labelResult_VVV.Text = "Результат:";
            // 
            // textBoxResult_VVV
            // 
            textBoxResult_VVV.BackColor = SystemColors.Control;
            textBoxResult_VVV.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_VVV.Location = new Point(11, 52);
            textBoxResult_VVV.Multiline = true;
            textBoxResult_VVV.Name = "textBoxResult_VVV";
            textBoxResult_VVV.ScrollBars = ScrollBars.Vertical;
            textBoxResult_VVV.Size = new Size(236, 343);
            textBoxResult_VVV.TabIndex = 0;
            // 
            // groupBoxInput_VVV
            // 
            groupBoxInput_VVV.Controls.Add(textBoxStopStep_VVV);
            groupBoxInput_VVV.Controls.Add(textBoxStartStep_VVV);
            groupBoxInput_VVV.Controls.Add(labelStopStep_VVV);
            groupBoxInput_VVV.Controls.Add(labelStartStep_VVV);
            groupBoxInput_VVV.Location = new Point(12, 350);
            groupBoxInput_VVV.Name = "groupBoxInput_VVV";
            groupBoxInput_VVV.Size = new Size(276, 87);
            groupBoxInput_VVV.TabIndex = 2;
            groupBoxInput_VVV.TabStop = false;
            groupBoxInput_VVV.Text = "Ввод данных:";
            // 
            // textBoxStopStep_VVV
            // 
            textBoxStopStep_VVV.Location = new Point(145, 54);
            textBoxStopStep_VVV.Name = "textBoxStopStep_VVV";
            textBoxStopStep_VVV.Size = new Size(125, 27);
            textBoxStopStep_VVV.TabIndex = 3;
            // 
            // textBoxStartStep_VVV
            // 
            textBoxStartStep_VVV.Location = new Point(13, 54);
            textBoxStartStep_VVV.Name = "textBoxStartStep_VVV";
            textBoxStartStep_VVV.Size = new Size(119, 27);
            textBoxStartStep_VVV.TabIndex = 2;
            // 
            // labelStopStep_VVV
            // 
            labelStopStep_VVV.BackColor = SystemColors.Control;
            labelStopStep_VVV.BorderStyle = BorderStyle.None;
            labelStopStep_VVV.Location = new Point(145, 26);
            labelStopStep_VVV.Name = "labelStopStep_VVV";
            labelStopStep_VVV.Size = new Size(125, 20);
            labelStopStep_VVV.TabIndex = 1;
            labelStopStep_VVV.Text = "Конец шага:";
            // 
            // labelStartStep_VVV
            // 
            labelStartStep_VVV.BackColor = SystemColors.Control;
            labelStartStep_VVV.BorderStyle = BorderStyle.None;
            labelStartStep_VVV.Location = new Point(13, 26);
            labelStartStep_VVV.Name = "labelStartStep_VVV";
            labelStartStep_VVV.Size = new Size(119, 20);
            labelStartStep_VVV.TabIndex = 0;
            labelStartStep_VVV.Text = "Старт шага:";
            // 
            // buttonHelp_VVV
            // 
            buttonHelp_VVV.BackColor = Color.DodgerBlue;
            buttonHelp_VVV.Location = new Point(294, 358);
            buttonHelp_VVV.Name = "buttonHelp_VVV";
            buttonHelp_VVV.Size = new Size(85, 70);
            buttonHelp_VVV.TabIndex = 3;
            buttonHelp_VVV.Text = "Справка";
            buttonHelp_VVV.UseVisualStyleBackColor = false;
            buttonHelp_VVV.Click += buttonHelp_VVV_Click;
            // 
            // buttonDone_VVV
            // 
            buttonDone_VVV.BackColor = Color.ForestGreen;
            buttonDone_VVV.Location = new Point(385, 358);
            buttonDone_VVV.Name = "buttonDone_VVV";
            buttonDone_VVV.Size = new Size(140, 70);
            buttonDone_VVV.TabIndex = 4;
            buttonDone_VVV.Text = "Выполнить";
            buttonDone_VVV.UseVisualStyleBackColor = false;
            buttonDone_VVV.Click += buttonDone_VVV_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDone_VVV);
            Controls.Add(buttonHelp_VVV);
            Controls.Add(groupBoxInput_VVV);
            Controls.Add(groupBoxOutput_VVV);
            Controls.Add(groupBoxTask_VVV);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 8 | Вегерина В. В. ";
            groupBoxTask_VVV.ResumeLayout(false);
            groupBoxTask_VVV.PerformLayout();
            groupBoxOutput_VVV.ResumeLayout(false);
            groupBoxOutput_VVV.PerformLayout();
            groupBoxInput_VVV.ResumeLayout(false);
            groupBoxInput_VVV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_VVV;
        private TextBox textBoxTask_VVV;
        private GroupBox groupBoxOutput_VVV;
        private TextBox labelResult_VVV;
        private TextBox textBoxResult_VVV;
        private GroupBox groupBoxInput_VVV;
        private TextBox textBoxStopStep_VVV;
        private TextBox textBoxStartStep_VVV;
        private TextBox labelStopStep_VVV;
        private TextBox labelStartStep_VVV;
        private Button buttonHelp_VVV;
        private Button buttonDone_VVV;
    }
}

namespace Tyuiu.VegerinaVV.Sprint6.Task0.V18
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
            groupBoxCondition_VVV = new GroupBox();
            textBoxCondition_VVV = new TextBox();
            groupBoxInput_VVV = new GroupBox();
            textBoxVarX_VVV = new TextBox();
            labelVarX_VVV = new TextBox();
            groupBoxOutput_VVV = new GroupBox();
            textBoxResult_VVV = new TextBox();
            labelResult_VVV = new TextBox();
            pictureBox_VVV = new PictureBox();
            buttonHelp_VVV = new Button();
            buttonDone_VVV = new Button();
            groupBoxCondition_VVV.SuspendLayout();
            groupBoxInput_VVV.SuspendLayout();
            groupBoxOutput_VVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_VVV).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition_VVV
            // 
            groupBoxCondition_VVV.Controls.Add(textBoxCondition_VVV);
            groupBoxCondition_VVV.Location = new Point(22, 11);
            groupBoxCondition_VVV.Name = "groupBoxCondition_VVV";
            groupBoxCondition_VVV.Size = new Size(365, 219);
            groupBoxCondition_VVV.TabIndex = 0;
            groupBoxCondition_VVV.TabStop = false;
            groupBoxCondition_VVV.Text = "Условие:";
            // 
            // textBoxCondition_VVV
            // 
            textBoxCondition_VVV.Location = new Point(18, 35);
            textBoxCondition_VVV.Multiline = true;
            textBoxCondition_VVV.Name = "textBoxCondition_VVV";
            textBoxCondition_VVV.ReadOnly = true;
            textBoxCondition_VVV.Size = new Size(334, 174);
            textBoxCondition_VVV.TabIndex = 0;
            textBoxCondition_VVV.Text = "Вычислить значение выражения по формуле";
            // 
            // groupBoxInput_VVV
            // 
            groupBoxInput_VVV.Controls.Add(textBoxVarX_VVV);
            groupBoxInput_VVV.Controls.Add(labelVarX_VVV);
            groupBoxInput_VVV.Location = new Point(60, 291);
            groupBoxInput_VVV.Name = "groupBoxInput_VVV";
            groupBoxInput_VVV.Size = new Size(274, 144);
            groupBoxInput_VVV.TabIndex = 1;
            groupBoxInput_VVV.TabStop = false;
            groupBoxInput_VVV.Text = "Ввод:";
            // 
            // textBoxVarX_VVV
            // 
            textBoxVarX_VVV.Location = new Point(61, 76);
            textBoxVarX_VVV.Multiline = true;
            textBoxVarX_VVV.Name = "textBoxVarX_VVV";
            textBoxVarX_VVV.Size = new Size(149, 52);
            textBoxVarX_VVV.TabIndex = 1;
            textBoxVarX_VVV.KeyPress += textBoxVarX_VVV_KeyPress;
            // 
            // labelVarX_VVV
            // 
            labelVarX_VVV.Location = new Point(61, 28);
            labelVarX_VVV.Multiline = true;
            labelVarX_VVV.Name = "labelVarX_VVV";
            labelVarX_VVV.ReadOnly = true;
            labelVarX_VVV.Size = new Size(149, 31);
            labelVarX_VVV.TabIndex = 0;
            labelVarX_VVV.Text = "Переменная X:";
            // 
            // groupBoxOutput_VVV
            // 
            groupBoxOutput_VVV.Controls.Add(textBoxResult_VVV);
            groupBoxOutput_VVV.Controls.Add(labelResult_VVV);
            groupBoxOutput_VVV.Location = new Point(472, 234);
            groupBoxOutput_VVV.Name = "groupBoxOutput_VVV";
            groupBoxOutput_VVV.Size = new Size(275, 142);
            groupBoxOutput_VVV.TabIndex = 2;
            groupBoxOutput_VVV.TabStop = false;
            groupBoxOutput_VVV.Text = "Вывод:";
            // 
            // textBoxResult_VVV
            // 
            textBoxResult_VVV.Location = new Point(76, 81);
            textBoxResult_VVV.Multiline = true;
            textBoxResult_VVV.Name = "textBoxResult_VVV";
            textBoxResult_VVV.ReadOnly = true;
            textBoxResult_VVV.Size = new Size(131, 46);
            textBoxResult_VVV.TabIndex = 1;
            // 
            // labelResult_VVV
            // 
            labelResult_VVV.Location = new Point(73, 30);
            labelResult_VVV.Multiline = true;
            labelResult_VVV.Name = "labelResult_VVV";
            labelResult_VVV.ReadOnly = true;
            labelResult_VVV.Size = new Size(135, 30);
            labelResult_VVV.TabIndex = 0;
            labelResult_VVV.Text = "Результат:";
            // 
            // pictureBox_VVV
            // 
            pictureBox_VVV.Image = Properties.Resources.Снимок144939;
            pictureBox_VVV.Location = new Point(508, 36);
            pictureBox_VVV.Name = "pictureBox_VVV";
            pictureBox_VVV.Size = new Size(229, 99);
            pictureBox_VVV.TabIndex = 3;
            pictureBox_VVV.TabStop = false;
            pictureBox_VVV.Click += pictureBox_VVV_Click;
            // 
            // buttonHelp_VVV
            // 
            buttonHelp_VVV.Location = new Point(489, 392);
            buttonHelp_VVV.Name = "buttonHelp_VVV";
            buttonHelp_VVV.Size = new Size(49, 47);
            buttonHelp_VVV.TabIndex = 4;
            buttonHelp_VVV.Text = "?";
            buttonHelp_VVV.UseVisualStyleBackColor = true;
            buttonHelp_VVV.Click += buttonHelp_VVV_Click;
            // 
            // buttonDone_VVV
            // 
            buttonDone_VVV.Location = new Point(586, 392);
            buttonDone_VVV.Name = "buttonDone_VVV";
            buttonDone_VVV.Size = new Size(151, 45);
            buttonDone_VVV.TabIndex = 5;
            buttonDone_VVV.Text = "Выполнить";
            buttonDone_VVV.UseVisualStyleBackColor = true;
            buttonDone_VVV.Click += buttonDone_VVV_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDone_VVV);
            Controls.Add(buttonHelp_VVV);
            Controls.Add(pictureBox_VVV);
            Controls.Add(groupBoxOutput_VVV);
            Controls.Add(groupBoxInput_VVV);
            Controls.Add(groupBoxCondition_VVV);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 0 | Вариант 18 | Вегерина В.В.";
            groupBoxCondition_VVV.ResumeLayout(false);
            groupBoxCondition_VVV.PerformLayout();
            groupBoxInput_VVV.ResumeLayout(false);
            groupBoxInput_VVV.PerformLayout();
            groupBoxOutput_VVV.ResumeLayout(false);
            groupBoxOutput_VVV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_VVV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_VVV;
        private TextBox textBoxCondition_VVV;
        private GroupBox groupBoxInput_VVV;
        private TextBox textBoxVarX_VVV;
        private TextBox labelVarX_VVV;
        private GroupBox groupBoxOutput_VVV;
        private TextBox textBoxResult_VVV;
        private TextBox labelResult_VVV;
        private PictureBox pictureBox_VVV;
        private Button buttonHelp_VVV;
        private Button buttonDone_VVV;
    }
}

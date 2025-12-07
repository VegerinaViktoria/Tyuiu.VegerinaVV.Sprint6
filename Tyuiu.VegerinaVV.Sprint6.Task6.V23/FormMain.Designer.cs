namespace Tyuiu.VegerinaVV.Sprint6.Task6.V23
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelTask_VVV = new Panel();
            buttonHelp_VVV = new Button();
            buttonDone_VVV = new Button();
            buttonOpenFile_VVV = new Button();
            groupBoxTask_VVV = new GroupBox();
            textBoxTask_VVV = new TextBox();
            panelOutPut = new Panel();
            groupBoxIn_VVV = new GroupBox();
            textBoxIn_VVV = new TextBox();
            panelResult_VVV = new Panel();
            groupBoxResult_VVV = new GroupBox();
            textBoxResult_VVV = new TextBox();
            splitterTask_VVV = new Splitter();
            openFileDialogTask_VVV = new OpenFileDialog();
            toolTipOpenFile_VVV = new ToolTip(components);
            toolTipDone_VVV = new ToolTip(components);
            toolTipHelp_VVV = new ToolTip(components);
            panelTask_VVV.SuspendLayout();
            groupBoxTask_VVV.SuspendLayout();
            panelOutPut.SuspendLayout();
            groupBoxIn_VVV.SuspendLayout();
            panelResult_VVV.SuspendLayout();
            groupBoxResult_VVV.SuspendLayout();
            SuspendLayout();
            // 
            // panelTask_VVV
            // 
            panelTask_VVV.Controls.Add(buttonHelp_VVV);
            panelTask_VVV.Controls.Add(buttonDone_VVV);
            panelTask_VVV.Controls.Add(buttonOpenFile_VVV);
            panelTask_VVV.Controls.Add(groupBoxTask_VVV);
            panelTask_VVV.Dock = DockStyle.Top;
            panelTask_VVV.Location = new Point(0, 0);
            panelTask_VVV.Name = "panelTask_VVV";
            panelTask_VVV.Size = new Size(882, 166);
            panelTask_VVV.TabIndex = 0;
            // 
            // buttonHelp_VVV
            // 
            buttonHelp_VVV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_VVV.Image = Properties.Resources.help;
            buttonHelp_VVV.Location = new Point(758, 15);
            buttonHelp_VVV.Name = "buttonHelp_VVV";
            buttonHelp_VVV.Size = new Size(107, 64);
            buttonHelp_VVV.TabIndex = 3;
            toolTipHelp_VVV.SetToolTip(buttonHelp_VVV, "Сведения о программе");
            buttonHelp_VVV.UseVisualStyleBackColor = true;
            buttonHelp_VVV.Click += buttonHelp_VVV_Click;
            // 
            // buttonDone_VVV
            // 
            buttonDone_VVV.Image = Properties.Resources.page_go;
            buttonDone_VVV.Location = new Point(109, 13);
            buttonDone_VVV.Name = "buttonDone_VVV";
            buttonDone_VVV.Size = new Size(65, 56);
            buttonDone_VVV.TabIndex = 2;
            toolTipDone_VVV.SetToolTip(buttonDone_VVV, "Производит поиск в файле слов, \r\nв которых встречается буквы \"s\" и\r\nвыводит их в результирующую строку\r\n");
            buttonDone_VVV.UseVisualStyleBackColor = true;
            buttonDone_VVV.Click += buttonDone_VVV_Click;
            // 
            // buttonOpenFile_VVV
            // 
            buttonOpenFile_VVV.Image = Properties.Resources.folder_page;
            buttonOpenFile_VVV.Location = new Point(21, 12);
            buttonOpenFile_VVV.Name = "buttonOpenFile_VVV";
            buttonOpenFile_VVV.Size = new Size(64, 59);
            buttonOpenFile_VVV.TabIndex = 1;
            toolTipOpenFile_VVV.SetToolTip(buttonOpenFile_VVV, "Открыть файл\r\nВыберите нужный файл для обработки\r\n\r\n");
            buttonOpenFile_VVV.UseVisualStyleBackColor = true;
            buttonOpenFile_VVV.Click += buttonOpenFile_VVV_Click;
            // 
            // groupBoxTask_VVV
            // 
            groupBoxTask_VVV.Controls.Add(textBoxTask_VVV);
            groupBoxTask_VVV.Location = new Point(5, 77);
            groupBoxTask_VVV.Name = "groupBoxTask_VVV";
            groupBoxTask_VVV.Size = new Size(933, 89);
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
            textBoxTask_VVV.Size = new Size(927, 63);
            textBoxTask_VVV.TabIndex = 0;
            textBoxTask_VVV.Text = resources.GetString("textBoxTask_VVV.Text");
            // 
            // panelOutPut
            // 
            panelOutPut.Controls.Add(groupBoxIn_VVV);
            panelOutPut.Dock = DockStyle.Left;
            panelOutPut.Location = new Point(0, 166);
            panelOutPut.Name = "panelOutPut";
            panelOutPut.Size = new Size(463, 237);
            panelOutPut.TabIndex = 1;
            // 
            // groupBoxIn_VVV
            // 
            groupBoxIn_VVV.Controls.Add(textBoxIn_VVV);
            groupBoxIn_VVV.Dock = DockStyle.Fill;
            groupBoxIn_VVV.Location = new Point(0, 0);
            groupBoxIn_VVV.Name = "groupBoxIn_VVV";
            groupBoxIn_VVV.Padding = new Padding(5);
            groupBoxIn_VVV.Size = new Size(463, 237);
            groupBoxIn_VVV.TabIndex = 0;
            groupBoxIn_VVV.TabStop = false;
            groupBoxIn_VVV.Text = "Ввод:";
            // 
            // textBoxIn_VVV
            // 
            textBoxIn_VVV.Dock = DockStyle.Fill;
            textBoxIn_VVV.Location = new Point(5, 25);
            textBoxIn_VVV.Multiline = true;
            textBoxIn_VVV.Name = "textBoxIn_VVV";
            textBoxIn_VVV.ScrollBars = ScrollBars.Vertical;
            textBoxIn_VVV.Size = new Size(453, 207);
            textBoxIn_VVV.TabIndex = 0;
            // 
            // panelResult_VVV
            // 
            panelResult_VVV.Controls.Add(groupBoxResult_VVV);
            panelResult_VVV.Dock = DockStyle.Fill;
            panelResult_VVV.Location = new Point(463, 166);
            panelResult_VVV.Name = "panelResult_VVV";
            panelResult_VVV.Size = new Size(419, 237);
            panelResult_VVV.TabIndex = 2;
            // 
            // groupBoxResult_VVV
            // 
            groupBoxResult_VVV.Controls.Add(textBoxResult_VVV);
            groupBoxResult_VVV.Dock = DockStyle.Fill;
            groupBoxResult_VVV.Location = new Point(0, 0);
            groupBoxResult_VVV.Name = "groupBoxResult_VVV";
            groupBoxResult_VVV.Padding = new Padding(5);
            groupBoxResult_VVV.Size = new Size(419, 237);
            groupBoxResult_VVV.TabIndex = 0;
            groupBoxResult_VVV.TabStop = false;
            groupBoxResult_VVV.Text = "Вывод:";
            // 
            // textBoxResult_VVV
            // 
            textBoxResult_VVV.Dock = DockStyle.Fill;
            textBoxResult_VVV.Location = new Point(5, 25);
            textBoxResult_VVV.Multiline = true;
            textBoxResult_VVV.Name = "textBoxResult_VVV";
            textBoxResult_VVV.ScrollBars = ScrollBars.Vertical;
            textBoxResult_VVV.Size = new Size(409, 207);
            textBoxResult_VVV.TabIndex = 0;
            // 
            // splitterTask_VVV
            // 
            splitterTask_VVV.Location = new Point(463, 166);
            splitterTask_VVV.Name = "splitterTask_VVV";
            splitterTask_VVV.Size = new Size(10, 237);
            splitterTask_VVV.TabIndex = 3;
            splitterTask_VVV.TabStop = false;
            // 
            // toolTipOpenFile_VVV
            // 
            toolTipOpenFile_VVV.ToolTipIcon = ToolTipIcon.Info;
            toolTipOpenFile_VVV.ToolTipTitle = "Подсказка";
            // 
            // toolTipDone_VVV
            // 
            toolTipDone_VVV.ToolTipIcon = ToolTipIcon.Info;
            toolTipDone_VVV.ToolTipTitle = "Подсказка";
            // 
            // toolTipHelp_VVV
            // 
            toolTipHelp_VVV.ToolTipIcon = ToolTipIcon.Info;
            toolTipHelp_VVV.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 403);
            Controls.Add(splitterTask_VVV);
            Controls.Add(panelResult_VVV);
            Controls.Add(panelOutPut);
            Controls.Add(panelTask_VVV);
            MinimumSize = new Size(900, 450);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 6 | Вариант 23 | Вегерина В. В.";
            panelTask_VVV.ResumeLayout(false);
            groupBoxTask_VVV.ResumeLayout(false);
            groupBoxTask_VVV.PerformLayout();
            panelOutPut.ResumeLayout(false);
            groupBoxIn_VVV.ResumeLayout(false);
            groupBoxIn_VVV.PerformLayout();
            panelResult_VVV.ResumeLayout(false);
            groupBoxResult_VVV.ResumeLayout(false);
            groupBoxResult_VVV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTask_VVV;
        private GroupBox groupBoxTask_VVV;
        private TextBox textBoxTask_VVV;
        private Panel panelOutPut;
        private Panel panelResult_VVV;
        private Splitter splitterTask_VVV;
        private GroupBox groupBoxIn_VVV;
        private TextBox textBoxIn_VVV;
        private GroupBox groupBoxResult_VVV;
        private TextBox textBoxResult_VVV;
        private Button buttonHelp_VVV;
        private Button buttonDone_VVV;
        private Button buttonOpenFile_VVV;
        private OpenFileDialog openFileDialogTask_VVV;
        private ToolTip toolTipOpenFile_VVV;
        private ToolTip toolTipDone_VVV;
        private ToolTip toolTipHelp_VVV;
    }
}

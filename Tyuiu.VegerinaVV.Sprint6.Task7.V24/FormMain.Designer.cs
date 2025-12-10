namespace Tyuiu.VegerinaVV.Sprint6.Task7.V24
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
            panelButton_VVV = new Panel();
            buttonSaveFile_VVV = new Button();
            buttonHelp_VVV = new Button();
            buttonDone_VVV = new Button();
            buttonOpenFile_VVV = new Button();
            panelTask_VVV = new Panel();
            groupBoxTask_VVV = new GroupBox();
            textBoxTask_VVV = new TextBox();
            panelIn_VVV = new Panel();
            groupBoxIn_VVV = new GroupBox();
            dataGridViewIn_VVV = new DataGridView();
            panelOut_VVV = new Panel();
            groupBoxOut_VVV = new GroupBox();
            dataGridViewOut_VVV = new DataGridView();
            splitterTask_VVV = new Splitter();
            openFileDialogTask_VVV = new OpenFileDialog();
            saveFileDialogMatrix_VVV = new SaveFileDialog();
            toolTipButton_VVV = new ToolTip(components);
            panelButton_VVV.SuspendLayout();
            panelTask_VVV.SuspendLayout();
            groupBoxTask_VVV.SuspendLayout();
            panelIn_VVV.SuspendLayout();
            groupBoxIn_VVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_VVV).BeginInit();
            panelOut_VVV.SuspendLayout();
            groupBoxOut_VVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_VVV).BeginInit();
            SuspendLayout();
            // 
            // panelButton_VVV
            // 
            panelButton_VVV.Controls.Add(buttonSaveFile_VVV);
            panelButton_VVV.Controls.Add(buttonHelp_VVV);
            panelButton_VVV.Controls.Add(buttonDone_VVV);
            panelButton_VVV.Controls.Add(buttonOpenFile_VVV);
            panelButton_VVV.Dock = DockStyle.Top;
            panelButton_VVV.Location = new Point(0, 0);
            panelButton_VVV.Name = "panelButton_VVV";
            panelButton_VVV.Size = new Size(843, 85);
            panelButton_VVV.TabIndex = 0;
            // 
            // buttonSaveFile_VVV
            // 
            buttonSaveFile_VVV.FlatStyle = FlatStyle.Flat;
            buttonSaveFile_VVV.Image = Properties.Resources.page_save;
            buttonSaveFile_VVV.Location = new Point(188, 17);
            buttonSaveFile_VVV.Name = "buttonSaveFile_VVV";
            buttonSaveFile_VVV.Size = new Size(59, 54);
            buttonSaveFile_VVV.TabIndex = 3;
            toolTipButton_VVV.SetToolTip(buttonSaveFile_VVV, "Сохранить обработанные данные в файл в формате CSV\r\n");
            buttonSaveFile_VVV.UseVisualStyleBackColor = true;
            buttonSaveFile_VVV.Click += buttonSaveFile_VVV_Click;
            buttonSaveFile_VVV.MouseEnter += buttonSaveFile_VVV_MouseEnter;
            // 
            // buttonHelp_VVV
            // 
            buttonHelp_VVV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_VVV.FlatStyle = FlatStyle.Flat;
            buttonHelp_VVV.Image = Properties.Resources.help;
            buttonHelp_VVV.Location = new Point(721, 17);
            buttonHelp_VVV.Name = "buttonHelp_VVV";
            buttonHelp_VVV.Size = new Size(110, 54);
            buttonHelp_VVV.TabIndex = 2;
            buttonHelp_VVV.UseVisualStyleBackColor = true;
            buttonHelp_VVV.Click += buttonHelp_VVV_Click;
            buttonHelp_VVV.MouseEnter += buttonHelp_VVV_MouseEnter;
            // 
            // buttonDone_VVV
            // 
            buttonDone_VVV.FlatStyle = FlatStyle.Flat;
            buttonDone_VVV.Image = Properties.Resources.page_go;
            buttonDone_VVV.Location = new Point(102, 17);
            buttonDone_VVV.Name = "buttonDone_VVV";
            buttonDone_VVV.Size = new Size(64, 54);
            buttonDone_VVV.TabIndex = 1;
            toolTipButton_VVV.SetToolTip(buttonDone_VVV, "Выполнить обработку данных");
            buttonDone_VVV.UseVisualStyleBackColor = true;
            buttonDone_VVV.Click += buttonDone_VVV_Click;
            buttonDone_VVV.MouseEnter += buttonDone_VVV_MouseEnter;
            // 
            // buttonOpenFile_VVV
            // 
            buttonOpenFile_VVV.FlatStyle = FlatStyle.Flat;
            buttonOpenFile_VVV.Image = Properties.Resources.folder_page;
            buttonOpenFile_VVV.Location = new Point(14, 15);
            buttonOpenFile_VVV.Name = "buttonOpenFile_VVV";
            buttonOpenFile_VVV.Size = new Size(67, 56);
            buttonOpenFile_VVV.TabIndex = 0;
            toolTipButton_VVV.SetToolTip(buttonOpenFile_VVV, "Открыть файл для обработки данных в формате csv\r\n");
            buttonOpenFile_VVV.UseVisualStyleBackColor = true;
            buttonOpenFile_VVV.Click += buttonOpenFile_VVV_Click;
            buttonOpenFile_VVV.MouseEnter += buttonOpenFile_VVV_MouseEnter;
            // 
            // panelTask_VVV
            // 
            panelTask_VVV.Controls.Add(groupBoxTask_VVV);
            panelTask_VVV.Dock = DockStyle.Top;
            panelTask_VVV.Location = new Point(0, 85);
            panelTask_VVV.Name = "panelTask_VVV";
            panelTask_VVV.Size = new Size(843, 101);
            panelTask_VVV.TabIndex = 1;
            // 
            // groupBoxTask_VVV
            // 
            groupBoxTask_VVV.Controls.Add(textBoxTask_VVV);
            groupBoxTask_VVV.Dock = DockStyle.Fill;
            groupBoxTask_VVV.Location = new Point(0, 0);
            groupBoxTask_VVV.Name = "groupBoxTask_VVV";
            groupBoxTask_VVV.Size = new Size(843, 101);
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
            textBoxTask_VVV.Size = new Size(837, 75);
            textBoxTask_VVV.TabIndex = 0;
            textBoxTask_VVV.Text = resources.GetString("textBoxTask_VVV.Text");
            // 
            // panelIn_VVV
            // 
            panelIn_VVV.Controls.Add(groupBoxIn_VVV);
            panelIn_VVV.Dock = DockStyle.Left;
            panelIn_VVV.Location = new Point(0, 186);
            panelIn_VVV.Name = "panelIn_VVV";
            panelIn_VVV.Size = new Size(422, 296);
            panelIn_VVV.TabIndex = 2;
            // 
            // groupBoxIn_VVV
            // 
            groupBoxIn_VVV.Controls.Add(dataGridViewIn_VVV);
            groupBoxIn_VVV.Dock = DockStyle.Fill;
            groupBoxIn_VVV.Location = new Point(0, 0);
            groupBoxIn_VVV.Name = "groupBoxIn_VVV";
            groupBoxIn_VVV.Size = new Size(422, 296);
            groupBoxIn_VVV.TabIndex = 0;
            groupBoxIn_VVV.TabStop = false;
            groupBoxIn_VVV.Text = "Ввод:";
            // 
            // dataGridViewIn_VVV
            // 
            dataGridViewIn_VVV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_VVV.Dock = DockStyle.Fill;
            dataGridViewIn_VVV.Location = new Point(3, 23);
            dataGridViewIn_VVV.Name = "dataGridViewIn_VVV";
            dataGridViewIn_VVV.RowHeadersVisible = false;
            dataGridViewIn_VVV.RowHeadersWidth = 51;
            dataGridViewIn_VVV.Size = new Size(416, 270);
            dataGridViewIn_VVV.TabIndex = 0;
            // 
            // panelOut_VVV
            // 
            panelOut_VVV.Controls.Add(groupBoxOut_VVV);
            panelOut_VVV.Dock = DockStyle.Fill;
            panelOut_VVV.Location = new Point(422, 186);
            panelOut_VVV.Name = "panelOut_VVV";
            panelOut_VVV.Size = new Size(421, 296);
            panelOut_VVV.TabIndex = 3;
            // 
            // groupBoxOut_VVV
            // 
            groupBoxOut_VVV.Controls.Add(dataGridViewOut_VVV);
            groupBoxOut_VVV.Dock = DockStyle.Fill;
            groupBoxOut_VVV.Location = new Point(0, 0);
            groupBoxOut_VVV.Name = "groupBoxOut_VVV";
            groupBoxOut_VVV.Size = new Size(421, 296);
            groupBoxOut_VVV.TabIndex = 0;
            groupBoxOut_VVV.TabStop = false;
            groupBoxOut_VVV.Text = "Вывод:";
            // 
            // dataGridViewOut_VVV
            // 
            dataGridViewOut_VVV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_VVV.Dock = DockStyle.Fill;
            dataGridViewOut_VVV.Location = new Point(3, 23);
            dataGridViewOut_VVV.Name = "dataGridViewOut_VVV";
            dataGridViewOut_VVV.RowHeadersVisible = false;
            dataGridViewOut_VVV.RowHeadersWidth = 51;
            dataGridViewOut_VVV.Size = new Size(415, 270);
            dataGridViewOut_VVV.TabIndex = 0;
            // 
            // splitterTask_VVV
            // 
            splitterTask_VVV.Location = new Point(422, 186);
            splitterTask_VVV.Name = "splitterTask_VVV";
            splitterTask_VVV.Size = new Size(10, 296);
            splitterTask_VVV.TabIndex = 4;
            splitterTask_VVV.TabStop = false;
            // 
            // toolTipButton_VVV
            // 
            toolTipButton_VVV.IsBalloon = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 482);
            Controls.Add(splitterTask_VVV);
            Controls.Add(panelOut_VVV);
            Controls.Add(panelIn_VVV);
            Controls.Add(panelTask_VVV);
            Controls.Add(panelButton_VVV);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 24 | Вегерина В. В.";
            WindowState = FormWindowState.Maximized;
            Load += FormMain_Load;
            panelButton_VVV.ResumeLayout(false);
            panelTask_VVV.ResumeLayout(false);
            groupBoxTask_VVV.ResumeLayout(false);
            groupBoxTask_VVV.PerformLayout();
            panelIn_VVV.ResumeLayout(false);
            groupBoxIn_VVV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_VVV).EndInit();
            panelOut_VVV.ResumeLayout(false);
            groupBoxOut_VVV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_VVV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButton_VVV;
        private Panel panelTask_VVV;
        private Panel panelIn_VVV;
        private Panel panelOut_VVV;
        private Splitter splitterTask_VVV;
        private Button buttonHelp_VVV;
        private Button buttonDone_VVV;
        private Button buttonOpenFile_VVV;
        private GroupBox groupBoxTask_VVV;
        private TextBox textBoxTask_VVV;
        private GroupBox groupBoxIn_VVV;
        private DataGridView dataGridViewIn_VVV;
        private GroupBox groupBoxOut_VVV;
        private DataGridView dataGridViewOut_VVV;
        private Button buttonSaveFile_VVV;
        private OpenFileDialog openFileDialogTask_VVV;
        private SaveFileDialog saveFileDialogMatrix_VVV;
        private ToolTip toolTipButton_VVV;
    }
}

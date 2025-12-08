namespace Tyuiu.VegerinaVV.Sprint6.Task7.V24
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBox_VVV = new PictureBox();
            groupBoxAbout_VVV = new GroupBox();
            textBoxAbout_VVV = new TextBox();
            buttonOK_VVV = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox_VVV).BeginInit();
            groupBoxAbout_VVV.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox_VVV
            // 
            pictureBox_VVV.Image = Properties.Resources.IMG_5798;
            pictureBox_VVV.Location = new Point(26, 62);
            pictureBox_VVV.Name = "pictureBox_VVV";
            pictureBox_VVV.Size = new Size(256, 216);
            pictureBox_VVV.TabIndex = 0;
            pictureBox_VVV.TabStop = false;
            // 
            // groupBoxAbout_VVV
            // 
            groupBoxAbout_VVV.Controls.Add(buttonOK_VVV);
            groupBoxAbout_VVV.Controls.Add(textBoxAbout_VVV);
            groupBoxAbout_VVV.Location = new Point(309, 23);
            groupBoxAbout_VVV.Name = "groupBoxAbout_VVV";
            groupBoxAbout_VVV.Size = new Size(462, 314);
            groupBoxAbout_VVV.TabIndex = 1;
            groupBoxAbout_VVV.TabStop = false;
            // 
            // textBoxAbout_VVV
            // 
            textBoxAbout_VVV.Location = new Point(11, 26);
            textBoxAbout_VVV.Multiline = true;
            textBoxAbout_VVV.Name = "textBoxAbout_VVV";
            textBoxAbout_VVV.ReadOnly = true;
            textBoxAbout_VVV.Size = new Size(441, 229);
            textBoxAbout_VVV.TabIndex = 0;
            textBoxAbout_VVV.Text = resources.GetString("textBoxAbout_VVV.Text");
            // 
            // buttonOK_VVV
            // 
            buttonOK_VVV.Location = new Point(319, 272);
            buttonOK_VVV.Name = "buttonOK_VVV";
            buttonOK_VVV.Size = new Size(107, 31);
            buttonOK_VVV.TabIndex = 1;
            buttonOK_VVV.Text = "OK";
            buttonOK_VVV.UseVisualStyleBackColor = true;
            buttonOK_VVV.Click += buttonOK_VVV_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 381);
            Controls.Add(groupBoxAbout_VVV);
            Controls.Add(pictureBox_VVV);
            Name = "FormAbout";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBox_VVV).EndInit();
            groupBoxAbout_VVV.ResumeLayout(false);
            groupBoxAbout_VVV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox_VVV;
        private GroupBox groupBoxAbout_VVV;
        private Button buttonOK_VVV;
        private TextBox textBoxAbout_VVV;
    }
}
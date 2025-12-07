namespace Tyuiu.VegerinaVV.Sprint6.Task6.V23
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
            pictureBoxAbout_VVV = new PictureBox();
            groupBoxAbout_VVV = new GroupBox();
            buttonOK_VVV = new Button();
            textBoxAbout_VVV = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout_VVV).BeginInit();
            groupBoxAbout_VVV.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxAbout_VVV
            // 
            pictureBoxAbout_VVV.BackgroundImage = Properties.Resources.IMG_5798;
            pictureBoxAbout_VVV.Location = new Point(24, 41);
            pictureBoxAbout_VVV.Name = "pictureBoxAbout_VVV";
            pictureBoxAbout_VVV.Size = new Size(218, 225);
            pictureBoxAbout_VVV.TabIndex = 0;
            pictureBoxAbout_VVV.TabStop = false;
            // 
            // groupBoxAbout_VVV
            // 
            groupBoxAbout_VVV.Controls.Add(buttonOK_VVV);
            groupBoxAbout_VVV.Controls.Add(textBoxAbout_VVV);
            groupBoxAbout_VVV.Location = new Point(294, 45);
            groupBoxAbout_VVV.Name = "groupBoxAbout_VVV";
            groupBoxAbout_VVV.Size = new Size(461, 358);
            groupBoxAbout_VVV.TabIndex = 1;
            groupBoxAbout_VVV.TabStop = false;
            // 
            // buttonOK_VVV
            // 
            buttonOK_VVV.Location = new Point(311, 307);
            buttonOK_VVV.Name = "buttonOK_VVV";
            buttonOK_VVV.Size = new Size(115, 40);
            buttonOK_VVV.TabIndex = 1;
            buttonOK_VVV.Text = "OK";
            buttonOK_VVV.UseVisualStyleBackColor = true;
            buttonOK_VVV.Click += buttonOK_VVV_Click;
            // 
            // textBoxAbout_VVV
            // 
            textBoxAbout_VVV.Location = new Point(13, 32);
            textBoxAbout_VVV.Multiline = true;
            textBoxAbout_VVV.Name = "textBoxAbout_VVV";
            textBoxAbout_VVV.ReadOnly = true;
            textBoxAbout_VVV.Size = new Size(432, 254);
            textBoxAbout_VVV.TabIndex = 0;
            textBoxAbout_VVV.Text = resources.GetString("textBoxAbout_VVV.Text");
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 403);
            Controls.Add(groupBoxAbout_VVV);
            Controls.Add(pictureBoxAbout_VVV);
            Name = "FormAbout";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout_VVV).EndInit();
            groupBoxAbout_VVV.ResumeLayout(false);
            groupBoxAbout_VVV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxAbout_VVV;
        private GroupBox groupBoxAbout_VVV;
        private Button buttonOK_VVV;
        private TextBox textBoxAbout_VVV;
    }
}
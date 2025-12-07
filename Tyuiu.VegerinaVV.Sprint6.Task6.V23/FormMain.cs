using System.Windows.Forms;
using Tyuiu.VegerinaVV.Sprint6.Task6.V23.Lib;
namespace Tyuiu.VegerinaVV.Sprint6.Task6.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService ds = new DataService();

        private void buttonOpenFile_VVV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_VVV.ShowDialog();
            openFilePath = openFileDialogTask_VVV.FileName;
            textBoxIn_VVV.Text = File.ReadAllText(openFilePath);
            groupBoxIn_VVV.Text = groupBoxIn_VVV.Text + " " + openFileDialogTask_VVV.FileName;
            buttonDone_VVV.Enabled = true;
        }

        private void buttonDone_VVV_Click(object sender, EventArgs e)
        {
            textBoxResult_VVV.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_VVV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

    }
}

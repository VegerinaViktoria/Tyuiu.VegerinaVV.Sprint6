using System.IO;
using Tyuiu.VegerinaVV.Sprint6.Task7.V24.Lib;
namespace Tyuiu.VegerinaVV.Sprint6.Task7.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_VVV.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_VVV.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        DataService ds = new DataService();
        static int rows;
        static int columns;
        static string openFilePath;

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace("\n", "\r");
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }
        private void buttonHelp_VVV_Click(object sender, EventArgs e)
        {
            FormAbout FormAbout = new FormAbout();
            FormAbout.ShowDialog();
        }

        private void buttonDone_VVV_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut_VVV.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSaveFile_VVV.Enabled = true;
        }

        private void buttonSaveFile_VVV_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_VVV.FileName = "OutPutFileTask7V24.csv";
            saveFileDialogMatrix_VVV.InitialDirectory = Path.Combine(Path.GetTempPath());
            saveFileDialogMatrix_VVV.ShowDialog();

            string path = saveFileDialogMatrix_VVV.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut_VVV.RowCount;
            int columns = dataGridViewOut_VVV.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut_VVV.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_VVV.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpenFile_VVV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_VVV.ShowDialog();
            openFilePath = openFileDialogTask_VVV.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewIn_VVV.ColumnCount = columns;
            dataGridViewIn_VVV.RowCount = rows;
            dataGridViewOut_VVV.ColumnCount = columns;
            dataGridViewOut_VVV.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_VVV.Columns[i].Width = 40;
                dataGridViewOut_VVV.Columns[i].Width = 40;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn_VVV.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_VVV.Enabled = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewIn_VVV.ColumnCount = 50;
            dataGridViewOut_VVV.ColumnCount = 50;

            dataGridViewOut_VVV.RowCount = 50;
            dataGridViewIn_VVV.RowCount = 50;

            panelIn_VVV.Width = this.Width / 2;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewIn_VVV.Columns[i].Width = 25;
                dataGridViewOut_VVV.Columns[i].Width = 25;
            }
        }

        private void buttonOpenFile_VVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_VVV.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_VVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_VVV.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_VVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_VVV.ToolTipTitle = "Сохранить файл";
        }

        private void buttonHelp_VVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_VVV.ToolTipTitle = "Справка";
        }

    }
}

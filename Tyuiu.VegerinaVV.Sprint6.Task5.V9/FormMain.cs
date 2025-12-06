using Tyuiu.VegerinaVV.Sprint6.Task5.V9.Lib;
namespace Tyuiu.VegerinaVV.Sprint6.Task5.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        string path = @"C:\DataSprint5\InPutDataFileTask5V9.txt";
        private void buttonDone_VVV_Click(object sender, EventArgs e)
        {
            dataGridViewResult_VVV.ColumnCount = 2;
            dataGridViewResult_VVV.Columns[0].Width = 20;
            dataGridViewResult_VVV.Columns[1].Width = 50;

            this.chartFunction_VVV.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunction_VVV.ChartAreas[0].AxisY.Title = "Ось Y";

            chartFunction_VVV.Series[0].Points.Clear();

            double[] numMass = new double[ds.len];

            numMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numMass.Length; i++)
            {
                dataGridViewResult_VVV.Rows.Add(Convert.ToString(i), Convert.ToString(numMass[i]));
                chartFunction_VVV.Series[0].Points.AddXY(i, numMass[i]);
            }
        }

        private void buttonOpenFile_VVV_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_VVV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы ИИПб-25-1 Вегерина Виктория Вячеславовна", "Сообщение", MessageBoxButtons.OK);
        }

        private void chartFunction_VVV_Click(object sender, EventArgs e)
        {

        }
    }
}

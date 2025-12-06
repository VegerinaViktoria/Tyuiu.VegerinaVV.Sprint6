using System;
using System.IO;
using Tyuiu.VegerinaVV.Sprint6.Task4.V26.Lib;
namespace Tyuiu.VegerinaVV.Sprint6.Task4.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonDone_VVV_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_VVV.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_VVV.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_VVV.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_VVV.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResuit_VVV.Text = "";

                chartFunction_VVV.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_VVV.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResuit_VVV.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_VVV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студентка группы ИИПб-25-1 Вегерина Виктория Вячеславовна", "Сообщение", MessageBoxButtons.OK);
        }

        private void buttonSave_VVV_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask4V26.txt");
                File.WriteAllText(path, textBoxResuit_VVV.Text);

                DialogResult dialogResult = MessageBox.Show("Файл" + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

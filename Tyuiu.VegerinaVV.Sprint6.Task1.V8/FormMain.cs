using Tyuiu.VegerinaVV.Sprint6.Task1.V8.Lib;
namespace Tyuiu.VegerinaVV.Sprint6.Task1.V8
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

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_VVV.Text = "";
                textBoxResult_VVV.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_VVV.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxResult_VVV.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,7:d}   | {1, 7:f2}  |", startStep, valueArray[i]);
                    textBoxResult_VVV.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_VVV.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_VVV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы ИИПб-25-1 Вегерина Виктория Вячеславовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    } 
}

using Tyuiu.VegerinaVV.Sprint6.Task2.V28.Lib;
namespace Tyuiu.VegerinaVV.Sprint6.Task2.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_VVV.Titles.Add("График функции (sin(x)-2x)/(3x-1)+sin(x)-3x+2");

                this.chartFunction_VVV.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_VVV.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_VVV.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartFunction_VVV.Series[0].Points.AddXY(startStep, valueArray[i]);

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
            MessageBox.Show("Таск 2 выполнила студентка группы ИИПб-25-1 Вегерина Виктория Вячеславовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void chartFunction_VVV_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonDone_VVV_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_VVV.BackColor = Color.Red;
        }

        private void buttonDone_VVV_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_VVV.BackColor = Color.Green;
        }

        private void buttonDone_VVV_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_VVV.BackColor = Color.Blue;
        }

        private void dataGridViewFunction_VVV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

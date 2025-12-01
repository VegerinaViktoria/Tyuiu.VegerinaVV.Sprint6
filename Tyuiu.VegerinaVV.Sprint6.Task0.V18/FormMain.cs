using Tyuiu.VegerinaVV.Sprint6.Task0.V18.Lib;
namespace Tyuiu.VegerinaVV.Sprint6.Task0.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_VVV_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_VVV.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_VVV.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarX_VVV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_VVV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студентка группы ИИПб-25-1 Вегерина Виктория Вячеславовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox_VVV_Click(object sender, EventArgs e)
        {

        }
    }
}

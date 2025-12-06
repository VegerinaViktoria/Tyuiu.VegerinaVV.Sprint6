using System.Drawing.Drawing2D;
using Tyuiu.VegerinaVV.Sprint6.Task3.V18.Lib;
namespace Tyuiu.VegerinaVV.Sprint6.Task3.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        int[,] mtrx = new int[5, 5] { { -19, -19, 1, 18, 7 },
                                      { 5, 3, -4, -6, -12 },
                                      { -15, 6, 2, 2, -14 },
                                      { -9, -10, 15, -5, -6 },
                                      { -13, -15, -9, 7, 1 } };

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewMatrix_VVV.ColumnCount = columns;
            dataGridViewMatrix_VVV.RowCount = rows;
            dataGridViewResult_VVV.ColumnCount = columns;
            dataGridViewResult_VVV.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_VVV.Columns[i].Width = 50;
                dataGridViewResult_VVV.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_VVV.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void buttonDone_VVV_Click(object sender, EventArgs e)
        {
            int[,] result_matrix = ds.Calculate(mtrx);

            int rows = result_matrix.GetUpperBound(0) + 1;
            int columns = result_matrix.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_VVV.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void buttonHelp_VVV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка группы ИИПб-25-1 Вегерина Виктория Вячеславовна", "Сообщение", MessageBoxButtons.OK);
        }
    }
}

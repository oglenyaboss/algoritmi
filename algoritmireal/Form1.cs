namespace algoritmireal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int n = int.Parse(textBox1.Text);
            double[] arr = new double[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(0, 5);
            }
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 2)
                {
                    arr[i] = 0;
                }
            }
            double sum = 0;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] >= 3 && arr[i] <= 7)
                {
                    sum += arr[i];
                    count++;
                }
            }
            label1.Text = ($"Измененная последовательность: {string.Join(", ", arr)}");
            label2.Text = ($"Сумма элементов от 3 до 7: {sum}");
            label3.Text = ($"Количество элементов от 3 до 7: {count}");


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 12;
            dataGridView1.ColumnCount = 12;
            dataGridView2.RowCount = 12;
            dataGridView2.ColumnCount = 12;
            Random random = new Random();
            double[,] matrix = new double[12, 12];
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    matrix[i, j] = random.Next(0, 10);
                    dataGridView1.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
            for (int i = 0; i < 12; i++)
            {
                for (int j = i; j < 12; j++)
                {
                    matrix[i, j] = 0;
                    dataGridView2.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    dataGridView2.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = "The quick  brown   fox    jumps over the  lazy dog";
            label4.Text = ("Исходная строка: " + s);
            int maxSpaces = 0;
            int currentSpaces = 0;
            foreach (char c in s)
            {
                if (c == ' ')
                {
                    currentSpaces++;
                    if (currentSpaces > maxSpaces)
                    {
                        maxSpaces = currentSpaces;
                    }
                }
                else
                {
                    currentSpaces = 0;
                }
            }
            label5.Text = ($"Максимальное количество идущих подряд пробелов: {maxSpaces}");
            int eCount = 0;
            foreach (char c in s)
            {
                if (c == 'e')
                {
                    eCount++;
                    if (eCount >= 5)
                    {
                        label6.Text = ("В строке есть пять идущих подряд букв 'e'");
                        break;
                    }
                }
                else
                {
                    eCount = 0;
                }
            }
            if (eCount < 5)
            {
                label6.Text = ("В строке нет пяти идущих подряд букв 'e'");
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<(string, double, string)> substances = new List<(string, double, string)> {
            ("Алмаз", 3.52, "Изолятор"),
            ("Кремний", 2.33, "Полупроводник"),
            ("Золото", 19.3, "Проводник"),
            ("Серебро", 10.5, "Проводник"),
            ("Кварц", 2.65, "Изолятор"),
            ("Керамика", 2.5, "Изолятор"),
            ("Силикон", 2.33, "Полупроводник"),
            ("Медь", 8.96, "Проводник"),
            ("Германий", 5.32, "Полупроводник"),
            ("Олово", 7.29, "Проводник")
        };
            // a) Находим удельные веса и названия всех полупроводников
            var semiconductors = substances.Where(s => s.Item3 == "Полупроводник")
                                           .Select(s => (s.Item1, s.Item2))
                                           .ToList();
            label7.Text += ("Удельные веса и названия всех полупроводников: ");
            foreach (var semiconductor in semiconductors)
            {
                label7.Text += ($"{semiconductor.Item1}: {semiconductor.Item2}") + ' ';
            }

            // б) Выбираем данные о проводниках и упорядочиваем их по убыванию удельных весов
            var conductors = substances.Where(s => s.Item3 == "Проводник")
                                       .OrderByDescending(s => s.Item2)
                                       .Select(s => (s.Item1, s.Item2))
                                       .ToList();
            label8.Text += ("\nДанные о проводниках, упорядоченные по убыванию удельных весов: ");
            foreach (var conductor in conductors)
            {
                label8.Text += ($"{conductor.Item1}: {conductor.Item2}" + ' ');
            }

        }
    }
}
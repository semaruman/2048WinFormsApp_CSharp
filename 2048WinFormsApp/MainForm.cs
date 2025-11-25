using _2048Game.Common;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace _2048WinFormsApp
{
    public partial class MainForm : Form
    {
        private const int mapSize = 4;
        private const int blockSize = 100;
        private Label[,] labelsMap;
        private static Random random = new Random();
        private int score = 0;
        private Color[] colors = {
            Color.Brown,
            Color.BlueViolet,
            Color.CadetBlue,
            Color.Aquamarine,
            Color.DarkGreen,
            Color.LightPink,
            Color.LightSalmon
        };

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitMap();
            GenerateNumber();
            theBestScoreLabel.Text = TheBestScoreFile.GetScore().ToString();
        }
        private void InitMap()
        {
            labelsMap = new Label[mapSize, mapSize];
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    var newLabel = CreateLabel(i, j);
                    Controls.Add(newLabel);
                    labelsMap[i, j] = newLabel;
                }
            }
        }
        private void GenerateNumber()
        {
            while (true)
            {
                int randomNumberLabel = random.Next(mapSize * mapSize);
                int indexRow = randomNumberLabel / mapSize;
                int indexCol = randomNumberLabel % mapSize;

                if (labelsMap[indexRow, indexCol].Text == string.Empty)
                {
                    if (random.Next(4) == 0)
                    {
                        labelsMap[indexRow, indexCol].Text = "4";
                    }
                    else
                    {
                        labelsMap[indexRow, indexCol].Text = "2";
                    }
                    break;
                }
            }
        }

        private Label CreateLabel(int indexRow, int indexColumn)
        {
            Label label = new Label();
            label.BackColor = SystemColors.ActiveBorder;
            label.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label.Size = new Size(100, 100);
            label.TabIndex = 0;
            label.Text = $"";
            label.TextAlign = ContentAlignment.MiddleCenter;

            int x = 10 + indexColumn * (blockSize + 6);
            int y = 100 + indexRow * (blockSize + 6);

            label.Location = new Point(x, y);
            return label;
        }
        void ShowScore()
        {
            scoreLabel.Text = score.ToString();
        }
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            bool flag = true;

            if (e.KeyCode == Keys.D)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    for (int j = mapSize - 1; j >= 0; j--)
                    {
                        if (labelsMap[i, j].Text != string.Empty)
                        {
                            for (int k = j - 1; k >= 0; k--)
                            {
                                if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                {
                                    int number = int.Parse(labelsMap[i, k].Text);
                                    flag = false;
                                    score += number * 2;
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    labelsMap[i, j].BackColor = colors[number % colors.Length];
                                    labelsMap[i, k].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }


                for (int i = 0; i < mapSize; i++)
                {
                    for (int j = mapSize - 1; j >= 0; j--)
                    {
                        if (labelsMap[i, j].Text == string.Empty)
                        {
                            for (int k = j - 1; k >= 0; k--)
                            {
                                if (labelsMap[i, k].Text != string.Empty)
                                {
                                    flag = false;
                                    labelsMap[i, j].Text = labelsMap[i, k].Text;
                                    labelsMap[i, j].BackColor = labelsMap[i, k].BackColor;
                                    labelsMap[i, k].Text = string.Empty;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            if (e.KeyCode == Keys.A)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    for (int j = 0; j < mapSize; j++)
                    {
                        if (labelsMap[i, j].Text != string.Empty)
                        {
                            for (int k = j + 1; k < mapSize; k++)
                            {
                                if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                {
                                    flag = false;
                                    int number = int.Parse(labelsMap[i, k].Text);
                                    score += number * 2;
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    labelsMap[i, j].BackColor = colors[number % colors.Length];
                                    labelsMap[i, k].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }


                for (int i = 0; i < mapSize; i++)
                {
                    for (int j = 0; j < mapSize; j++)
                    {
                        if (labelsMap[i, j].Text == string.Empty)
                        {
                            for (int k = j + 1; k < mapSize; k++)
                            {
                                if (labelsMap[i, k].Text != string.Empty)
                                {
                                    flag = false;
                                    labelsMap[i, j].Text = labelsMap[i, k].Text;
                                    labelsMap[i, j].BackColor = labelsMap[i, k].BackColor;
                                    labelsMap[i, k].Text = string.Empty;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            if (e.KeyCode == Keys.W)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    for (int i = 0; i < mapSize; i++)
                    {
                        if (labelsMap[i, j].Text != string.Empty)
                        {
                            for (int k = i + 1; k < mapSize; k++)
                            {
                                if (labelsMap[k, j].Text == labelsMap[i, j].Text && labelsMap[k, j].Text != string.Empty)
                                {
                                    flag = false;
                                    int number = int.Parse(labelsMap[i, j].Text);
                                    score += number * 2;
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    labelsMap[i, j].BackColor = colors[number % colors.Length];
                                    labelsMap[k, j].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }


                for (int j = 0; j < mapSize; j++)
                {
                    for (int i = 0; i < mapSize; i++)
                    {
                        if (labelsMap[i, j].Text == string.Empty)
                        {
                            for (int k = i + 1; k < mapSize; k++)
                            {
                                if (labelsMap[k, j].Text != string.Empty)
                                {
                                    flag = false;
                                    labelsMap[i, j].Text = labelsMap[k, j].Text;
                                    labelsMap[i, j].BackColor = labelsMap[i, k].BackColor;
                                    labelsMap[k, j].Text = string.Empty;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            if (e.KeyCode == Keys.S)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    for (int i = mapSize - 1; i >= 0; i--) // int i = 0; i < mapSize; i++
                    {
                        if (labelsMap[i, j].Text != string.Empty)
                        {
                            for (int k = i - 1; k >= 0; k--)
                            {
                                if (labelsMap[i, j].Text == labelsMap[k, j].Text && labelsMap[k, j].Text != string.Empty)
                                {
                                    flag = false;
                                    int number = int.Parse(labelsMap[i, j].Text);
                                    score += number * 2;
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    labelsMap[i, j].BackColor = colors[number % colors.Length];
                                    labelsMap[k, j].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }


                for (int j = 0; j < mapSize; j++)
                {
                    for (int i = mapSize - 1; i >= 0; i--)
                    {
                        if (labelsMap[i, j].Text == string.Empty)
                        {
                            for (int k = i - 1; k >= 0; k--)
                            {
                                if (labelsMap[k, j].Text != string.Empty)
                                {
                                    flag = false;
                                    labelsMap[i, j].Text = labelsMap[k, j].Text;
                                    labelsMap[i, j].BackColor = labelsMap[i, k].BackColor;
                                    labelsMap[k, j].Text = string.Empty;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            ShowScore();

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        labelsMap[i, j].BackColor = SystemColors.ActiveBorder;
                        flag = false;
                    }
                }
            }
            if (flag)
            {
                MessageBox.Show($"»гра окончена. —чЄт: {score}");

                if (score > Convert.ToInt32(theBestScoreLabel.Text))
                {
                    TheBestScoreFile.Add(score);
                }

                MenuForm form = new MenuForm();
                form.Show();
                Close();
            }
            GenerateNumber();
        }
    }
}

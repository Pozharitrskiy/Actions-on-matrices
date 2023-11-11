using System.Drawing.Drawing2D;
using System.Globalization;

namespace Actions_on_matrix
{
    public partial class UserForm : Form
    {
        List<System.Windows.Forms.TextBox> matrixOneLeft = new List<System.Windows.Forms.TextBox>();
        List<System.Windows.Forms.TextBox> matrixTwoRight = new List<System.Windows.Forms.TextBox>();
        private string _currentUser;
        public UserForm()
        {
            InitializeComponent();
            for (int i = 7; i > 1; i--)
            {
                matrixSizeLeft.Items.Add(i);
                matrixSizeRight.Items.Add(i);
            }
        }

        public UserForm(string currentLine)
        {
            InitializeComponent();
            for (int i = 7; i > 1; i--)
            {
                matrixSizeLeft.Items.Add(i);
                matrixSizeRight.Items.Add(i);
            }
            LoadUserData(currentLine);
        }

        private void LoadUserData(string userLogin)
        {
            if (!File.Exists($"Users\\{userLogin}Info.txt"))
            {
                UpdateUserInfo("0", "0", userLogin);
            }

            using (StreamReader sr = new StreamReader($"Users\\{userLogin}Info.txt"))
            {

                profileEditCount.Text = sr.ReadLine();
                warningsCount.Text = sr.ReadLine();
            }

            using (StreamReader sr = new StreamReader($"Users\\{userLogin}.txt"))
            {
                userLoginBox.Text = sr.ReadLine();
                userPasswordBox.Text = sr.ReadLine();
                userNameBox.Text = sr.ReadLine();
                userSurnameBox.Text = sr.ReadLine();
            }

            label2.Text = userLogin;
            label12.Text = userLogin;
            _currentUser = userLogin;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            string nameLogFile = "UserEditLogs";
            new EditProfileForm(userLoginBox.Text, userPasswordBox.Text, userNameBox.Text, userSurnameBox.Text, false).ShowDialog();
            profileEditCount.Text = (Int32.Parse(warningsCount.Text) + 1).ToString();
            UpdateUserInfo(profileEditCount.Text, warningsCount.Text, _currentUser);
            LoadUserData(userLoginBox.Text);
            UpdateLogInfo("Имя", userNameBox.Text, nameLogFile);
            UpdateLogInfo("Фамилия", userSurnameBox.Text, nameLogFile);
            UpdateLogInfo("Логин", userLoginBox.Text, nameLogFile);
            UpdateLogInfo("Пароль", userPasswordBox.Text, nameLogFile);
        }

        private void UpdateLogInfo(string message, string dataToLog, string user)
        {
            DateTime time;
            time = DateTime.Now;
            using (StreamWriter sw = new StreamWriter($"Users\\{user}.txt", true))
            {
                sw.WriteLine($"{message} - {dataToLog}: {time.ToShortTimeString()}\n");
            }
        }

        private void UpdateUserInfo(string edits, string warnings, string user)
        {
            using (StreamWriter sw = new StreamWriter($"Users\\{user}Info.txt"))
            {
                sw.Write($"\n{edits}\n{warnings}\n");
            }
        }

        private void UpdateLogInfo(string messageToLog, string user)
        {
            DateTime time;
            time = DateTime.Now;
            using (StreamWriter sw = new StreamWriter($"Users\\{user}Log.txt", true))
            {
                sw.Write($"{messageToLog} ; {time.ToShortTimeString()}\n");
            }
        }

        private void matrixSizeLeft_SelectedIndexChanged(object sender, EventArgs e)
        {
            matrixOneLeft.Clear();
            int size = (int)matrixSizeLeft.SelectedItem;

            matrixLeft.Controls.Clear();
            matrixLeft.ColumnCount = size;
            matrixLeft.RowCount = size;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
                    matrixOneLeft.Add(textBox);
                    textBox.Width = 30;
                    textBox.Height = 20;
                    textBox.KeyPress += TextBox_KeyPress;
                    matrixLeft.Controls.Add(textBox, i, j);
                }
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                           && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void matrixSizeRight_SelectedIndexChanged(object sender, EventArgs e)
        {
            matrixTwoRight.Clear();
            int size = (int)matrixSizeRight.SelectedItem;

            matrixRight.Controls.Clear();
            matrixRight.ColumnCount = size;
            matrixRight.RowCount = size;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    System.Windows.Forms.TextBox textBox1 = new System.Windows.Forms.TextBox();
                    matrixTwoRight.Add(textBox1);
                    textBox1.Width = 30;
                    textBox1.Height = 20;
                    textBox1.KeyPress += TextBox_KeyPress;
                    matrixRight.Controls.Add(textBox1, i, j);
                }
            }
        }

        private void actionButton_Click(object sender, EventArgs e)
        {


            if ((int)matrixSizeLeft.SelectedItem != (int)matrixSizeRight.SelectedItem)
            {
                MessageBox.Show("Мартицы должны быть одинакового размера");
            }
            else
            {
                int size = (int)matrixSizeRight.SelectedItem;
                double[,] result = new double[size, size];
                switch (actionBox.SelectedItem.ToString())
                {
                    case "+":
                        for (int i = 0; i < matrixOneLeft.Count; i++)
                        {
                            double a = Double.Parse(matrixOneLeft[i].Text, CultureInfo.InvariantCulture);
                            double b = Double.Parse(matrixTwoRight[i].Text, CultureInfo.InvariantCulture);

                            result[i / size, i % size] = Math.Round(a + b, 2);
                        }
                        break;

                    case "-":
                        for (int i = 0; i < matrixOneLeft.Count; i++)
                        {
                            double a = Double.Parse(matrixOneLeft[i].Text, CultureInfo.InvariantCulture);
                            double b = Double.Parse(matrixTwoRight[i].Text, CultureInfo.InvariantCulture);

                            result[i / size, i % size] = Math.Round(a - b, 2);
                        }
                        break;

                    case "*":
                        for (int i = 0; i < matrixOneLeft.Count; i++)
                        {
                            double a = Double.Parse(matrixOneLeft[i].Text, CultureInfo.InvariantCulture);
                            double b = Double.Parse(matrixTwoRight[i].Text, CultureInfo.InvariantCulture);

                            result[i / size, i % size] = Math.Round(a * b, 2);
                        }
                        break;

                }
                string message = "Результат:" + "\n";

                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        message += result[i, j].ToString().PadLeft(8);
                    }
                    message += "\n";
                }

                MessageBox.Show(message);

            }

        }
    }


}
namespace Actions_on_matrix
{
    partial class AdministratorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            actionButton = new Button();
            actionBox = new ComboBox();
            matrixTwo = new TableLayoutPanel();
            matrixOne = new TableLayoutPanel();
            matrixSizeRight = new ComboBox();
            matrixSizeLeft = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label32 = new Label();
            tabPage2 = new TabPage();
            label12 = new Label();
            label13 = new Label();
            profileEditCount = new Label();
            warningsCount = new Label();
            userPasswordBox = new TextBox();
            userLoginBox = new TextBox();
            userSurnameBox = new TextBox();
            userNameBox = new TextBox();
            editButton = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            tabPage3 = new TabPage();
            label17 = new Label();
            label15 = new Label();
            label26 = new Label();
            deleteButton = new Button();
            addNewAdmin = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            textBox7 = new TextBox();
            comboBox = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(-1, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(980, 585);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.LightCoral;
            tabPage1.Controls.Add(actionButton);
            tabPage1.Controls.Add(actionBox);
            tabPage1.Controls.Add(matrixTwo);
            tabPage1.Controls.Add(matrixOne);
            tabPage1.Controls.Add(matrixSizeRight);
            tabPage1.Controls.Add(matrixSizeLeft);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label32);
            tabPage1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 27);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(972, 554);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Фильтр файлов";
            // 
            // actionButton
            // 
            actionButton.Location = new Point(370, 507);
            actionButton.Name = "actionButton";
            actionButton.Size = new Size(229, 41);
            actionButton.TabIndex = 18;
            actionButton.Text = "Выполнить рассчёт";
            actionButton.UseVisualStyleBackColor = true;
            actionButton.Click += actionButton_Click;
            // 
            // actionBox
            // 
            actionBox.FormattingEnabled = true;
            actionBox.Items.AddRange(new object[] { "+", "-", "*" });
            actionBox.Location = new Point(415, 89);
            actionBox.Name = "actionBox";
            actionBox.Size = new Size(151, 32);
            actionBox.TabIndex = 17;
            // 
            // matrixTwo
            // 
            matrixTwo.ColumnCount = 2;
            matrixTwo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.4F));
            matrixTwo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.6F));
            matrixTwo.Location = new Point(585, 150);
            matrixTwo.Name = "matrixTwo";
            matrixTwo.RowCount = 2;
            matrixTwo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            matrixTwo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            matrixTwo.Size = new Size(374, 351);
            matrixTwo.TabIndex = 16;
            // 
            // matrixOne
            // 
            matrixOne.ColumnCount = 2;
            matrixOne.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.4F));
            matrixOne.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.6F));
            matrixOne.Location = new Point(9, 150);
            matrixOne.Name = "matrixOne";
            matrixOne.RowCount = 2;
            matrixOne.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            matrixOne.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            matrixOne.Size = new Size(387, 351);
            matrixOne.TabIndex = 15;
            // 
            // matrixSizeRight
            // 
            matrixSizeRight.FormattingEnabled = true;
            matrixSizeRight.Location = new Point(808, 89);
            matrixSizeRight.Name = "matrixSizeRight";
            matrixSizeRight.Size = new Size(151, 32);
            matrixSizeRight.TabIndex = 14;
            matrixSizeRight.SelectedIndexChanged += matrixSizeRight_SelectedIndexChanged;
            // 
            // matrixSizeLeft
            // 
            matrixSizeLeft.FormattingEnabled = true;
            matrixSizeLeft.Location = new Point(9, 89);
            matrixSizeLeft.Name = "matrixSizeLeft";
            matrixSizeLeft.Size = new Size(151, 32);
            matrixSizeLeft.TabIndex = 13;
            matrixSizeLeft.SelectedIndexChanged += matrixSizeLeft_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(701, 62);
            label3.Name = "label3";
            label3.Size = new Size(258, 24);
            label3.TabIndex = 12;
            label3.Text = "Выберите размер матрицы";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 62);
            label1.Name = "label1";
            label1.Size = new Size(258, 24);
            label1.TabIndex = 11;
            label1.Text = "Выберите размер матрицы";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(735, 19);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 10;
            label2.Text = "label2";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(539, 19);
            label32.Name = "label32";
            label32.Size = new Size(190, 24);
            label32.TabIndex = 9;
            label32.Text = "Добро пожаловать,";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.LightCoral;
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(profileEditCount);
            tabPage2.Controls.Add(warningsCount);
            tabPage2.Controls.Add(userPasswordBox);
            tabPage2.Controls.Add(userLoginBox);
            tabPage2.Controls.Add(userSurnameBox);
            tabPage2.Controls.Add(userNameBox);
            tabPage2.Controls.Add(editButton);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage2.Location = new Point(4, 27);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(972, 554);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Пользователь";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(706, 18);
            label12.Name = "label12";
            label12.Size = new Size(75, 24);
            label12.TabIndex = 13;
            label12.Text = "label12";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(510, 18);
            label13.Name = "label13";
            label13.Size = new Size(190, 24);
            label13.TabIndex = 12;
            label13.Text = "Добро пожаловать,";
            // 
            // profileEditCount
            // 
            profileEditCount.AutoSize = true;
            profileEditCount.Location = new Point(510, 163);
            profileEditCount.Name = "profileEditCount";
            profileEditCount.Size = new Size(252, 24);
            profileEditCount.TabIndex = 11;
            profileEditCount.Text = "Число редакций профиля:";
            // 
            // warningsCount
            // 
            warningsCount.AutoSize = true;
            warningsCount.Location = new Point(510, 90);
            warningsCount.Name = "warningsCount";
            warningsCount.Size = new Size(235, 24);
            warningsCount.TabIndex = 10;
            warningsCount.Text = "Число предупреждений:";
            // 
            // userPasswordBox
            // 
            userPasswordBox.Location = new Point(194, 201);
            userPasswordBox.Name = "userPasswordBox";
            userPasswordBox.Size = new Size(168, 32);
            userPasswordBox.TabIndex = 9;
            // 
            // userLoginBox
            // 
            userLoginBox.Location = new Point(194, 163);
            userLoginBox.Name = "userLoginBox";
            userLoginBox.Size = new Size(168, 32);
            userLoginBox.TabIndex = 8;
            // 
            // userSurnameBox
            // 
            userSurnameBox.Location = new Point(194, 125);
            userSurnameBox.Name = "userSurnameBox";
            userSurnameBox.Size = new Size(168, 32);
            userSurnameBox.TabIndex = 7;
            // 
            // userNameBox
            // 
            userNameBox.Location = new Point(194, 87);
            userNameBox.Name = "userNameBox";
            userNameBox.Size = new Size(168, 32);
            userNameBox.TabIndex = 6;
            // 
            // editButton
            // 
            editButton.BackColor = Color.White;
            editButton.Location = new Point(12, 264);
            editButton.Name = "editButton";
            editButton.Size = new Size(157, 36);
            editButton.TabIndex = 5;
            editButton.Text = "Редактировать";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 200);
            label8.Name = "label8";
            label8.Size = new Size(91, 24);
            label8.TabIndex = 4;
            label8.Text = "Пароль :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 165);
            label7.Name = "label7";
            label7.Size = new Size(78, 24);
            label7.TabIndex = 3;
            label7.Text = "Логин :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 127);
            label6.Name = "label6";
            label6.Size = new Size(106, 24);
            label6.TabIndex = 2;
            label6.Text = "Фамилия :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 90);
            label5.Name = "label5";
            label5.Size = new Size(60, 24);
            label5.TabIndex = 1;
            label5.Text = "Имя :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 49);
            label4.Name = "label4";
            label4.Size = new Size(157, 24);
            label4.TabIndex = 0;
            label4.Text = "Личные данные";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.LightCoral;
            tabPage3.Controls.Add(label17);
            tabPage3.Controls.Add(label15);
            tabPage3.Controls.Add(label26);
            tabPage3.Controls.Add(deleteButton);
            tabPage3.Controls.Add(addNewAdmin);
            tabPage3.Controls.Add(dataGridView1);
            tabPage3.Controls.Add(textBox7);
            tabPage3.Controls.Add(comboBox);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(label9);
            tabPage3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage3.Location = new Point(4, 27);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(972, 554);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Администрирование";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(745, 25);
            label17.Name = "label17";
            label17.Size = new Size(75, 24);
            label17.TabIndex = 12;
            label17.Text = "label14";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(549, 25);
            label15.Name = "label15";
            label15.Size = new Size(190, 24);
            label15.TabIndex = 11;
            label15.Text = "Добро пожаловать,";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(561, 395);
            label26.Name = "label26";
            label26.Size = new Size(202, 24);
            label26.TabIndex = 8;
            label26.Text = "Количество записей:";
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.White;
            deleteButton.Location = new Point(336, 389);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(111, 37);
            deleteButton.TabIndex = 7;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // addNewAdmin
            // 
            addNewAdmin.BackColor = Color.White;
            addNewAdmin.Location = new Point(9, 389);
            addNewAdmin.Name = "addNewAdmin";
            addNewAdmin.Size = new Size(289, 37);
            addNewAdmin.TabIndex = 6;
            addNewAdmin.Text = "Сделать администратором";
            addNewAdmin.UseVisualStyleBackColor = false;
            addNewAdmin.Click += addNewAdmin_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = Color.Gainsboro;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column2, Column4, Column5, Column6, Column7 });
            dataGridView1.GridColor = SystemColors.GradientActiveCaption;
            dataGridView1.Location = new Point(9, 132);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(933, 251);
            dataGridView1.TabIndex = 5;
            // 
            // Column1
            // 
            Column1.HeaderText = "№";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Логин";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Пароль";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Имя";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Фамилия";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Число предупреждений";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Число редакций профиля";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(461, 78);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(198, 32);
            textBox7.TabIndex = 4;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // comboBox
            // 
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(110, 78);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(198, 32);
            comboBox.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(373, 81);
            label11.Name = "label11";
            label11.Size = new Size(65, 24);
            label11.TabIndex = 2;
            label11.Text = "Поиск";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, 81);
            label10.Name = "label10";
            label10.Size = new Size(86, 24);
            label10.TabIndex = 1;
            label10.Text = "Столбец";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(9, 25);
            label9.Name = "label9";
            label9.Size = new Size(413, 24);
            label9.TabIndex = 0;
            label9.Text = "Список загеристрированных пользователей";
            // 
            // AdministratorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 580);
            Controls.Add(tabControl1);
            Name = "AdministratorForm";
            Text = "AdministratorForm";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox userPasswordBox;
        private TextBox userLoginBox;
        private TextBox userSurnameBox;
        private TextBox userNameBox;
        private Button button4;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TabPage tabPage3;
        private ComboBox comboBox;
        private Label label11;
        private Label label10;
        private Label label9;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private TextBox textBox7;
        private Label label26;
        private Button deleteButton;
        private Button addNewAdmin;
        private Label profileEditCount;
        private Label warningsCount;
        private Label label2;
        private Label label32;
        private Label label12;
        private Label label13;
        private Label label17;
        private Label label15;
        private Button editButton;
        private ComboBox matrixSizeRight;
        private ComboBox matrixSizeLeft;
        private Label label3;
        private Label label1;
        private TableLayoutPanel matrixTwo;
        private TableLayoutPanel matrixOne;
        private ComboBox actionBox;
        private Button actionButton;
    }
}
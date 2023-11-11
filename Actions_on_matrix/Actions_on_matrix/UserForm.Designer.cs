namespace Actions_on_matrix
{
    partial class UserForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button1 = new Button();
            actionBox = new ComboBox();
            matrixRight = new TableLayoutPanel();
            matrixLeft = new TableLayoutPanel();
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
            actionButton = new Button();
            matrixOne = new TableLayoutPanel();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(1, -1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(991, 581);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.LightCoral;
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(actionBox);
            tabPage1.Controls.Add(matrixRight);
            tabPage1.Controls.Add(matrixLeft);
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
            tabPage1.Size = new Size(983, 550);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Фильтр файлов";
            // 
            // button1
            // 
            button1.Location = new Point(372, 501);
            button1.Name = "button1";
            button1.Size = new Size(229, 41);
            button1.TabIndex = 26;
            button1.Text = "Выполнить рассчёт";
            button1.UseVisualStyleBackColor = true;
            button1.Click += actionButton_Click;
            // 
            // actionBox
            // 
            actionBox.FormattingEnabled = true;
            actionBox.Items.AddRange(new object[] { "+", "-", "*" });
            actionBox.Location = new Point(417, 83);
            actionBox.Name = "actionBox";
            actionBox.Size = new Size(151, 32);
            actionBox.TabIndex = 25;
            // 
            // matrixRight
            // 
            matrixRight.ColumnCount = 2;
            matrixRight.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.4F));
            matrixRight.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.6F));
            matrixRight.Location = new Point(587, 144);
            matrixRight.Name = "matrixRight";
            matrixRight.RowCount = 2;
            matrixRight.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            matrixRight.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            matrixRight.Size = new Size(374, 351);
            matrixRight.TabIndex = 24;
            // 
            // matrixLeft
            // 
            matrixLeft.ColumnCount = 2;
            matrixLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.4F));
            matrixLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.6F));
            matrixLeft.Location = new Point(11, 144);
            matrixLeft.Name = "matrixLeft";
            matrixLeft.RowCount = 2;
            matrixLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            matrixLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            matrixLeft.Size = new Size(387, 351);
            matrixLeft.TabIndex = 23;
            // 
            // matrixSizeRight
            // 
            matrixSizeRight.FormattingEnabled = true;
            matrixSizeRight.Location = new Point(810, 83);
            matrixSizeRight.Name = "matrixSizeRight";
            matrixSizeRight.Size = new Size(151, 32);
            matrixSizeRight.TabIndex = 22;
            matrixSizeRight.SelectedIndexChanged += matrixSizeRight_SelectedIndexChanged;
            // 
            // matrixSizeLeft
            // 
            matrixSizeLeft.FormattingEnabled = true;
            matrixSizeLeft.Location = new Point(11, 83);
            matrixSizeLeft.Name = "matrixSizeLeft";
            matrixSizeLeft.Size = new Size(151, 32);
            matrixSizeLeft.TabIndex = 21;
            matrixSizeLeft.SelectedIndexChanged += matrixSizeLeft_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(703, 56);
            label3.Name = "label3";
            label3.Size = new Size(258, 24);
            label3.TabIndex = 20;
            label3.Text = "Выберите размер матрицы";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 56);
            label1.Name = "label1";
            label1.Size = new Size(258, 24);
            label1.TabIndex = 19;
            label1.Text = "Выберите размер матрицы";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(738, 22);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 10;
            label2.Text = "label2";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(542, 22);
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
            tabPage2.Size = new Size(983, 550);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Пользователь";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(709, 21);
            label12.Name = "label12";
            label12.Size = new Size(75, 24);
            label12.TabIndex = 13;
            label12.Text = "label12";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(513, 21);
            label13.Name = "label13";
            label13.Size = new Size(190, 24);
            label13.TabIndex = 12;
            label13.Text = "Добро пожаловать,";
            // 
            // profileEditCount
            // 
            profileEditCount.AutoSize = true;
            profileEditCount.Location = new Point(513, 166);
            profileEditCount.Name = "profileEditCount";
            profileEditCount.Size = new Size(252, 24);
            profileEditCount.TabIndex = 11;
            profileEditCount.Text = "Число редакций профиля:";
            // 
            // warningsCount
            // 
            warningsCount.AutoSize = true;
            warningsCount.Location = new Point(513, 93);
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
            editButton.Click += editButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 203);
            label8.Name = "label8";
            label8.Size = new Size(91, 24);
            label8.TabIndex = 4;
            label8.Text = "Пароль :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 168);
            label7.Name = "label7";
            label7.Size = new Size(78, 24);
            label7.TabIndex = 3;
            label7.Text = "Логин :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 130);
            label6.Name = "label6";
            label6.Size = new Size(106, 24);
            label6.TabIndex = 2;
            label6.Text = "Фамилия :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 93);
            label5.Name = "label5";
            label5.Size = new Size(60, 24);
            label5.TabIndex = 1;
            label5.Text = "Имя :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 52);
            label4.Name = "label4";
            label4.Size = new Size(157, 24);
            label4.TabIndex = 0;
            label4.Text = "Личные данные";
            // 
            // actionButton
            // 
            actionButton.Location = new Point(560, 472);
            actionButton.Name = "actionButton";
            actionButton.Size = new Size(229, 41);
            actionButton.TabIndex = 21;
            actionButton.Text = "Выполнить рассчёт";
            actionButton.UseVisualStyleBackColor = true;
            // 
            // matrixOne
            // 
            matrixOne.ColumnCount = 2;
            matrixOne.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.4F));
            matrixOne.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            matrixOne.Location = new Point(0, 0);
            matrixOne.Name = "matrixOne";
            matrixOne.RowCount = 2;
            matrixOne.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            matrixOne.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            matrixOne.Size = new Size(200, 100);
            matrixOne.TabIndex = 0;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 580);
            Controls.Add(tabControl1);
            Name = "UserForm";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label2;
        private Label label32;
        private TabPage tabPage2;
        private Label label12;
        private Label label13;
        private Label profileEditCount;
        private Label warningsCount;
        private TextBox userPasswordBox;
        private TextBox userLoginBox;
        private TextBox userSurnameBox;
        private TextBox userNameBox;
        private Button editButton;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button actionButton;
        private TableLayoutPanel matrixOne;
        private Button button1;
        private ComboBox actionBox;
        private TableLayoutPanel matrixRight;
        private TableLayoutPanel matrixLeft;
        private ComboBox matrixSizeRight;
        private ComboBox matrixSizeLeft;
        private Label label3;
        private Label label1;
    }
}
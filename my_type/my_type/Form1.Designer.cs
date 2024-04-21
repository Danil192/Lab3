namespace my_type
{
    partial class Form1
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
            comboBoxSystem1 = new ComboBox();
            textBoxInput1 = new TextBox();
            textBoxInput2 = new TextBox();
            textBoxResult = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBoxOperation = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            comboBoxSystem2 = new ComboBox();
            comboBoxSystemResult = new ComboBox();
            label5 = new Label();
            label8 = new Label();
            label9 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // comboBoxSystem1
            // 
            comboBoxSystem1.FormattingEnabled = true;
            comboBoxSystem1.Location = new Point(358, 248);
            comboBoxSystem1.Name = "comboBoxSystem1";
            comboBoxSystem1.Size = new Size(55, 28);
            comboBoxSystem1.TabIndex = 1;
            // 
            // textBoxInput1
            // 
            textBoxInput1.Location = new Point(213, 249);
            textBoxInput1.Name = "textBoxInput1";
            textBoxInput1.Size = new Size(125, 27);
            textBoxInput1.TabIndex = 2;
            // 
            // textBoxInput2
            // 
            textBoxInput2.Location = new Point(213, 300);
            textBoxInput2.Name = "textBoxInput2";
            textBoxInput2.Size = new Size(125, 27);
            textBoxInput2.TabIndex = 3;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(215, 353);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(123, 27);
            textBoxResult.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 246);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 5;
            label1.Text = "Выбор операции";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 226);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 6;
            label2.Text = "Ввод числа 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(213, 279);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 7;
            label3.Text = "Ввод числа 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(213, 330);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 8;
            label4.Text = "Результат";
            // 
            // comboBoxOperation
            // 
            comboBoxOperation.FormattingEnabled = true;
            comboBoxOperation.Location = new Point(100, 269);
            comboBoxOperation.Name = "comboBoxOperation";
            comboBoxOperation.Size = new Size(71, 28);
            comboBoxOperation.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(89, 9);
            label6.Name = "label6";
            label6.Size = new Size(430, 41);
            label6.TabIndex = 12;
            label6.Text = "ЛАБОРАТОРНАЯ РАБОТА №3\r\n";
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(46, 50);
            label7.Name = "label7";
            label7.Size = new Size(525, 171);
            label7.TabIndex = 13;
            label7.Text = "Задание: Создать класс реализующий операции в соответствии с заданием\r\nЧисло, заданное в системе счисления (двоичная, восьмеричная, десятичная шестнадцатеричная)\r\n";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // comboBoxSystem2
            // 
            comboBoxSystem2.FormattingEnabled = true;
            comboBoxSystem2.Items.AddRange(new object[] { "2", "8", "10", "16" });
            comboBoxSystem2.Location = new Point(358, 299);
            comboBoxSystem2.Name = "comboBoxSystem2";
            comboBoxSystem2.Size = new Size(55, 28);
            comboBoxSystem2.TabIndex = 16;
            // 
            // comboBoxSystemResult
            // 
            comboBoxSystemResult.FormattingEnabled = true;
            comboBoxSystemResult.Items.AddRange(new object[] { "2", "8", "10", "16" });
            comboBoxSystemResult.Location = new Point(358, 352);
            comboBoxSystemResult.Name = "comboBoxSystemResult";
            comboBoxSystemResult.Size = new Size(55, 28);
            comboBoxSystemResult.TabIndex = 17;
            // 
            // label5
            // 
            label5.Location = new Point(419, 239);
            label5.Name = "label5";
            label5.Size = new Size(152, 45);
            label5.TabIndex = 18;
            label5.Text = "Система сичиления для 1 числа";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Location = new Point(419, 290);
            label8.Name = "label8";
            label8.Size = new Size(152, 45);
            label8.TabIndex = 19;
            label8.Text = "Система сичиления для 2 числа";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.Location = new Point(419, 343);
            label9.Name = "label9";
            label9.Size = new Size(152, 45);
            label9.TabIndex = 20;
            label9.Text = "Система сичиления для результата";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(178, 388);
            button1.Name = "button1";
            button1.Size = new Size(216, 29);
            button1.TabIndex = 21;
            button1.Text = "Расчитать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 425);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(comboBoxSystemResult);
            Controls.Add(comboBoxSystem2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(comboBoxOperation);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxResult);
            Controls.Add(textBoxInput2);
            Controls.Add(textBoxInput1);
            Controls.Add(comboBoxSystem1);
            Name = "Form1";
            Text = "Системы счисления";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBoxSystem1;
        private TextBox textBoxInput1;
        private TextBox textBoxInput2;
        private TextBox textBoxResult;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxOperation;
        private Label label6;
        private Label label7;
        private ComboBox comboBoxSystem2;
        private ComboBox comboBoxSystemResult;
        private Label label5;
        private Label label8;
        private Label label9;
        private Button button1;
    }
}
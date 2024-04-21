using System;
using System.Windows.Forms;

namespace my_type
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBoxOperation.Items.AddRange(new string[] { "+", "-", "*", "==" });
            comboBoxSystem1.Items.AddRange(new string[] { "2", "8", "10", "16" });
        }
        private void Calculate()
        {
            try
            {
                if (comboBoxSystem1.SelectedItem == null || comboBoxOperation.SelectedItem == null || comboBoxSystem2.SelectedItem == null)
                {
                    MessageBox.Show("Выберите системы счисления и операцию.");
                    return;
                }

                int baseSystem1 = int.Parse(comboBoxSystem1.SelectedItem.ToString());
                int baseSystem2 = int.Parse(comboBoxSystem2.SelectedItem.ToString());
                int baseSystemResult = comboBoxSystemResult.SelectedItem != null ? int.Parse(comboBoxSystemResult.SelectedItem.ToString()) : 10;

                // Проверка валидности чисел перед созданием объектов Number
                if (!Number.IsValidNumber(textBoxInput1.Text, baseSystem1))
                {
                    throw new ArgumentException("Первое число не соответствует выбранной системе счисления.");
                }
                if (!Number.IsValidNumber(textBoxInput2.Text, baseSystem2))
                {
                    throw new ArgumentException("Второе число не соответствует выбранной системе счисления.");
                }

                var num1 = new Number(textBoxInput1.Text, baseSystem1);
                var num2 = new Number(textBoxInput2.Text, baseSystem2);

                Number result;
                switch (comboBoxOperation.SelectedItem.ToString())
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "==":
                        textBoxResult.Text = (num1 == num2).ToString();
                        return;
                    default:
                        throw new InvalidOperationException("Неизвестная операция.");
                }

                // Передаем baseSystemResult в ToString, чтобы отобразить результат в нужной системе счисления
                textBoxResult.Text = result.ToString(baseSystemResult);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ТРПО4.Pages
{
    /// <summary>
    /// Логика взаимодействия для Calculator.xaml
    /// </summary>
    public partial class Calculator : Page
    {
        string leftop = ""; // Левый операнд
        string operation = ""; // Знак операции
        string rightop = ""; // Правый операнд

        public Calculator()
        {
            InitializeComponent();
            // Добавляем обработчик для всех кнопок на гриде
            foreach (UIElement c in LayoutRoot.Children)
            {
                if (c is Button)
                {
                    ((Button)c).Click += Button_Click;
                }
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Получаем текст кнопки
            string s = (string)((Button)e.OriginalSource).Content;
            // Добавляем его в текстовое поле
            textBlock.Text += s;
            int num;
            // Пытаемся преобразовать его в число
            bool result = Int32.TryParse(s, out num);
            // Если текст - это число
            if (result == true)
            {
                // Если операция не задана
                if (operation == "")
                {
                    // Добавляем к левому операнду
                    leftop += s;
                }
                else
                {
                    // Иначе к правому операнду
                    rightop += s;
                }
            }
            // Если было введено не число
            else
            {
                // Если равно, то выводим результат операции
                if (s == "=")
                {
                    Update_RightOp();
                    textBlock.Text += rightop;
                    operation = "";
                }
                // Очищаем поле и переменные
                else if (s == "AC")
                {
                    leftop = "";
                    rightop = "";
                    operation = "";
                    textBlock.Text = "";
                }

                else if (s == "√x")
                {
                    textBlock.Text = Math.Sqrt(Int32.Parse(leftop)).ToString();
                }

                else if (s == "|x|")
                {
                    textBlock.Text = Math.Abs(Int32.Parse(rightop)).ToString();
                }

                else if (s == "x^2")
                {
                    textBlock.Text = Math.Pow(Int32.Parse(leftop), 2).ToString();
                }

                else if (s == "10^x")
                {
                    textBlock.Text = Math.Pow(10, Int32.Parse(leftop)).ToString();
                }

                else if (s == "1/x")
                {
                    int g = (Int32.Parse(leftop));
                    double w = 1 / (double)g;
                    textBlock.Text = (w).ToString();
                }

                else if (s == "log")
                {
                    textBlock.Text = Math.Log10(Int32.Parse(leftop)).ToString();
                }

                else if (s == "y^x")
                {
                    textBlock.Text = Math.Pow(Int32.Parse(rightop), Int32.Parse(leftop)).ToString();
                }

                else if (s == "n!")
                {
                    textBlock.Text = Factorial(Int32.Parse(leftop)).ToString();
                }

                else if (s == "+/-")
                {
                    int g = (Int32.Parse(leftop));
                    textBlock.Text = (-g).ToString();
                }

                else if (s == "sin")
                {
                    textBlock.Text = Math.Sin(Int32.Parse(leftop)).ToString();
                }

                else if (s == "cos")
                {
                    textBlock.Text = Math.Cos(Int32.Parse(leftop)).ToString();
                }

                else if (s == "tan")
                {
                    textBlock.Text = Math.Tan(Int32.Parse(leftop)).ToString();
                }

                else if (s == "%")
                {
                    textBlock.Text = (Int32.Parse(leftop) / (double)100).ToString();
                }

                // Получаем операцию
                else
                {
                    // Если правый операнд уже имеется, то присваиваем его значение левому
                    // операнду, а правый операнд очищаем
                    if (rightop != "")
                    {
                        Update_RightOp();
                        leftop = rightop;
                        rightop = "";
                    }
                    operation = s;
                }
            }
        }
        // Обновляем значение правого операнда
        private void Update_RightOp()
        {
            int num1 = Int32.Parse(leftop);
            int num2 = Int32.Parse(rightop);
            // И выполняем операцию
            switch (operation)
            {
                case "+":
                    rightop = (num1 + num2).ToString();
                    break;
                case "-":
                    rightop = (num1 - num2).ToString();
                    break;
                case "*":
                    rightop = (num1 * num2).ToString();
                    break;
                case "/":
                    rightop = (num1 / num2).ToString();
                    break;
            }
        }
        public int Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}

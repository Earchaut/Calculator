using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace 计算器
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        double AnswerBoxNow = 0;
        double AnswerBoxLast = 0;
        double AnswerBoxPast = 0;
        int Operator = -1;  //加、减、乘、除分别对应1、2、3、4
        int OperatorPast = -1;
        bool isPointNow = false;
        bool isOperatorClick = false;
        bool isOperatorLast = false;
        bool isOperatorPast = false;

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            OperatorLebal.Content = "";
            if (AnswerBox.Text != "0" && !isOperatorClick)
            {
                AnswerBox.Text += 1;
            }
            else AnswerBox.Text = "1";
            isOperatorClick = false;
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            OperatorLebal.Content = "";
            if (AnswerBox.Text != "0" && !isOperatorClick)
            {
                AnswerBox.Text += 2;
            }
            else AnswerBox.Text = "2";
            isOperatorClick = false;
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            OperatorLebal.Content = "";
            if (AnswerBox.Text != "0" && !isOperatorClick)
            {
                AnswerBox.Text += 3;
            }
            else AnswerBox.Text = "3";
            isOperatorClick = false;
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            OperatorLebal.Content = "";
            if (AnswerBox.Text != "0" && !isOperatorClick)
            {
                AnswerBox.Text += 4;
            }
            else AnswerBox.Text = "4";
            isOperatorClick = false;
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            OperatorLebal.Content = "";
            if (AnswerBox.Text != "0" && !isOperatorClick)
            {
                AnswerBox.Text += 5;
            }
            else AnswerBox.Text = "5";
            isOperatorClick = false;
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            OperatorLebal.Content = "";
            if (AnswerBox.Text != "0" && !isOperatorClick)
            {
                AnswerBox.Text += 6;
            }
            else AnswerBox.Text = "6";
            isOperatorClick = false;
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            OperatorLebal.Content = "";
            if (AnswerBox.Text != "0" && !isOperatorClick)
            {
                AnswerBox.Text += 7;
            }
            else AnswerBox.Text = "7";
            isOperatorClick = false;
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            OperatorLebal.Content = "";
            if (AnswerBox.Text != "0" && !isOperatorClick)
            {
                AnswerBox.Text += 8;
            }
            else AnswerBox.Text = "8";
            isOperatorClick = false;
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            OperatorLebal.Content = "";
            if (AnswerBox.Text != "0" && !isOperatorClick)
            {
                AnswerBox.Text += 9;
            }
            else AnswerBox.Text = "9";
            isOperatorClick = false;
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            OperatorLebal.Content = "";
            if (AnswerBox.Text != "0" && !isOperatorClick)
            {
                AnswerBox.Text += 0;
            }
            else AnswerBox.Text = "0";
            isOperatorClick = false;
        }

        private void ButtonPlusMinus_Click(object sender, RoutedEventArgs e)
        {
            AnswerBoxNow = double.Parse(AnswerBox.Text);
            AnswerBoxNow = -AnswerBoxNow;
            AnswerBox.Text = AnswerBoxNow.ToString();
        }

        private void ButtonPoint_Click(object sender, RoutedEventArgs e)
        {
            if (!isPointNow && !isOperatorClick)
            {
                isPointNow = true;
                AnswerBox.Text += ".";
            }
            else if (!isPointNow && isOperatorClick)
            {
                isPointNow = true;
                AnswerBox.Text = "0.";
            }
        }

        private void ButtonDEL_Click(object sender, RoutedEventArgs e)
        {
            if (!isOperatorClick)
            {
                string tmp = AnswerBox.Text;
                if (tmp[tmp.Length - 1] == '.') isPointNow = false;
                tmp = tmp.Substring(0, tmp.Length - 1);
                AnswerBox.Text = tmp;
            }
        }

        private void ButtonAC_Click(object sender, RoutedEventArgs e)
        {
            AnswerBox.Text = "0";
            isPointNow = false;
            isOperatorClick = false;
            isOperatorLast = false;
            AnswerBoxLast = 0;
            AnswerBoxNow = 0;
            AnswerBoxPast = 0;
            OperatorLebal.Content = "";
            Operator = -1;
            OperatorPast = -1;
        }

        private void ButtonMultiply_Click(object sender, RoutedEventArgs e)
        {
            AnswerBoxNow = double.Parse(AnswerBox.Text);
            if (!isOperatorLast)
            {
                AnswerBoxLast = AnswerBoxNow;
            }
            else if (OperatorLebal.Content.ToString() == "")
            {
                if (Operator == 1)
                {
                    AnswerBoxPast = AnswerBoxLast;
                    AnswerBoxLast = AnswerBoxNow;
                    OperatorPast = 1;
                    isOperatorPast = true;
                }
                else if (Operator == 2)
                {
                    AnswerBoxPast = AnswerBoxLast;
                    AnswerBoxLast = AnswerBoxNow;
                    OperatorPast = 2;
                }
                else if (Operator == 3)
                {
                    AnswerBoxLast *= AnswerBoxNow;
                }
                else if (Operator == 4)
                {
                    if (AnswerBoxNow != 0)
                    {
                        AnswerBoxNow = AnswerBoxLast / AnswerBoxNow;
                    }
                    else AnswerBox.Text = "Error";
                }
                AnswerBox.Text = AnswerBoxLast.ToString();
            }
            Operator = 3;
            OperatorLebal.Content = "×";
            isPointNow = false;
            isOperatorClick = true;
            isOperatorLast = true;
        }

        private void ButtonDivide_Click(object sender, RoutedEventArgs e)
        {
            AnswerBoxNow = double.Parse(AnswerBox.Text);
            if (!isOperatorLast)
            {
                AnswerBoxLast = AnswerBoxNow;
            }
            else if (OperatorLebal.Content.ToString() == "")
            {
                if (Operator == 1)
                {
                    AnswerBoxPast = AnswerBoxLast;
                    AnswerBoxLast = AnswerBoxNow;
                    OperatorPast = 1;
                }
                else if (Operator == 2)
                {
                    AnswerBoxPast = AnswerBoxLast;
                    AnswerBoxLast = AnswerBoxNow;
                    OperatorPast = 2;
                }
                else if (Operator == 3)
                {
                    AnswerBoxLast *= AnswerBoxNow;
                }
                else if (Operator == 4)
                {
                    if (AnswerBoxNow != 0)
                    {
                        AnswerBoxNow = AnswerBoxLast / AnswerBoxNow;
                    }
                    else AnswerBox.Text = "Error";
                }
                AnswerBox.Text = AnswerBoxLast.ToString();
            }
            Operator = 4;
            OperatorLebal.Content = "÷";
            isPointNow = false;
            isOperatorClick = true;
            isOperatorLast = true;
        }

        private void ButtonAddition_Click(object sender, RoutedEventArgs e)
        {
            AnswerBoxNow = double.Parse(AnswerBox.Text);
            if (!isOperatorLast)
            {
                AnswerBoxLast = AnswerBoxNow;
            }
            else if (OperatorLebal.Content.ToString() == "")
            {
                if (Operator == 1)
                {
                    AnswerBoxLast += AnswerBoxNow;
                }
                else if (Operator == 2)
                {
                    AnswerBoxLast += -AnswerBoxNow;
                }
                else if (Operator == 3)
                {
                    AnswerBoxLast *= AnswerBoxNow;
                    if (isOperatorPast)
                    {
                        if (OperatorPast == 1)
                        {
                            AnswerBoxLast += AnswerBoxPast;
                            AnswerBoxPast = 0;
                            OperatorPast = -1;
                            isOperatorPast = false;
                        }
                        else if (OperatorPast == 2)
                        {
                            AnswerBoxLast = AnswerBoxPast - AnswerBoxLast;
                            AnswerBoxPast = 0;
                            OperatorPast = -1;
                            isOperatorPast = false;
                        }
                    }
                }
                else if (Operator == 4)
                {
                    if (AnswerBoxNow != 0)
                    {
                        AnswerBoxNow = AnswerBoxLast / AnswerBoxNow;
                        if (isOperatorPast)
                        {
                            if (OperatorPast == 1)
                            {
                                AnswerBoxLast += AnswerBoxPast;
                                AnswerBoxPast = 0;
                                OperatorPast = -1;
                                isOperatorPast = false;
                            }
                            else if (OperatorPast == 2)
                            {
                                AnswerBoxLast = AnswerBoxPast - AnswerBoxLast;
                                AnswerBoxPast = 0;
                                OperatorPast = -1;
                                isOperatorPast = false;
                            }
                        }
                    }
                    else AnswerBox.Text = "Error";
                }
                AnswerBox.Text = AnswerBoxLast.ToString();
            }
            Operator = 1;
            OperatorLebal.Content = "+";
            isPointNow = false;
            isOperatorClick = true;
            isOperatorLast = true;
        }

        private void ButtonSubduction_Click(object sender, RoutedEventArgs e)
        {
            AnswerBoxNow = double.Parse(AnswerBox.Text);
            if (!isOperatorLast)
            {
                AnswerBoxLast = AnswerBoxNow;
            }
            else if (OperatorLebal.Content.ToString() == "")
            {
                if (Operator == 1)
                {
                    AnswerBoxLast += AnswerBoxNow;
                }
                else if (Operator == 2)
                {
                    AnswerBoxLast += -AnswerBoxNow;
                }
                else if (Operator == 3)
                {
                    AnswerBoxLast *= AnswerBoxNow;
                    if (isOperatorPast)
                    {
                        if (OperatorPast == 1)
                        {
                            AnswerBoxLast += AnswerBoxPast;
                            AnswerBoxPast = 0;
                            OperatorPast = -1;
                            isOperatorPast = false;
                        }
                        else if (OperatorPast == 2)
                        {
                            AnswerBoxLast = AnswerBoxPast - AnswerBoxLast;
                            AnswerBoxPast = 0;
                            OperatorPast = -1;
                            isOperatorPast = false;
                        }
                    }
                }
                else if (Operator == 4)
                {
                    if (AnswerBoxNow != 0)
                    {
                        AnswerBoxNow = AnswerBoxLast / AnswerBoxNow;
                        if (isOperatorPast)
                        {
                            if (OperatorPast == 1)
                            {
                                AnswerBoxLast += AnswerBoxPast;
                                AnswerBoxPast = 0;
                                OperatorPast = -1;
                                isOperatorPast = false;
                            }
                            else if (OperatorPast == 2)
                            {
                                AnswerBoxLast = AnswerBoxPast - AnswerBoxLast;
                                AnswerBoxPast = 0;
                                OperatorPast = -1;
                                isOperatorPast = false;
                            }
                        }
                    }
                    else AnswerBox.Text = "Error";
                }
                AnswerBox.Text = AnswerBoxLast.ToString();
            }
            Operator = 2;
            OperatorLebal.Content = "-";
            isPointNow = false;
            isOperatorClick = true;
            isOperatorLast = true;
        }

        private void ButtonEqual_Click(object sender, RoutedEventArgs e)
        {
            AnswerBoxNow = double.Parse(AnswerBox.Text);
            switch (Operator)
            {
                case 1:
                    AnswerBoxNow += AnswerBoxLast;
                    if (OperatorPast == 1)
                    {
                        AnswerBoxNow += AnswerBoxPast;
                    }
                    else if (OperatorPast == 2)
                    {
                        AnswerBoxNow = AnswerBoxLast - AnswerBoxNow;
                    }
                    AnswerBox.Text = AnswerBoxNow.ToString();
                    break;
                case 2:
                    AnswerBoxNow = AnswerBoxLast - AnswerBoxNow;
                    if (OperatorPast == 1)
                    {
                        AnswerBoxNow += AnswerBoxPast;
                    }
                    else if (OperatorPast == 2)
                    {
                        AnswerBoxNow = AnswerBoxLast - AnswerBoxNow;
                    }
                    AnswerBox.Text = AnswerBoxNow.ToString();
                    break;
                case 3:
                    AnswerBoxNow *= AnswerBoxLast;
                    if (OperatorPast == 1)
                    {
                        AnswerBoxNow += AnswerBoxPast;
                    }
                    else if (OperatorPast == 2)
                    {
                        AnswerBoxNow = AnswerBoxLast - AnswerBoxNow;
                    }
                    AnswerBox.Text = AnswerBoxNow.ToString();
                    break;
                case 4:
                    if (AnswerBoxNow != 0)
                    {
                        AnswerBoxNow = AnswerBoxLast / AnswerBoxNow;
                        if (OperatorPast == 1)
                        {
                            AnswerBoxNow += AnswerBoxPast;
                        }
                        else if (OperatorPast == 2)
                        {
                            AnswerBoxNow = AnswerBoxLast - AnswerBoxNow;
                        }
                        AnswerBox.Text = AnswerBoxNow.ToString();
                    }
                    else AnswerBox.Text = "Error";
                    break;
                default:
                    break;
            }
            isPointNow = false;
            isOperatorClick = true;
            isOperatorLast = false;
            isOperatorPast = false;
            Operator = -1;
            OperatorPast = -1;
            AnswerBoxLast = 0;
            AnswerBoxPast = 0;
        }

        private void HelpMenu_Click(object sender, RoutedEventArgs e)
        {
            Help helpwindow = new Help();
            helpwindow.Show();
        }

        private void AboutMenu_Click(object sender, RoutedEventArgs e)
        {
            About aboutwindow = new About();
            aboutwindow.Show();
        }
    }
}

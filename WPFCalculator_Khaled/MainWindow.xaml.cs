using System;
using System.Windows;

namespace WPFCalculator_Khaled
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        // registers to hold user input
        double num1 = 0.0d;
        double num2 = 0.0d;

        String operation = String.Empty;

        public MainWindow()
        {
            InitializeComponent();
        }


        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            // no operation selected, just display the number pressed
            if (operation == String.Empty)
            {
                num1 = (num1 * 10);
                Display.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10);
                Display.Text = num2.ToString();
            }
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            // no operation selected, just display the number pressed
            if (operation == String.Empty)
            {
                // using this kind of logic, what is happening is we're shifting the numbers to the left each time a new number button is being
                // pressed before an operation button is clicked,, in which the case is handled below
                num1 = (num1 * 10) + 1;
                Display.Text = num1.ToString();
            }
            else 
            {
                num2 = (num2 * 10) + 1;
                Display.Text = num2.ToString();
            }
        }


        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            // no operation selected, just display the number pressed
            if (operation == String.Empty)
            {
                num1 = (num1 * 10) + 2;
                Display.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 2;
                Display.Text = num2.ToString();
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            // no operation selected, just display the number pressed
            if (operation == String.Empty)
            {
                num1 = (num1 * 10) + 3;
                Display.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 3;
                Display.Text = num2.ToString();
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            // no operation selected, just display the number pressed
            if (operation == String.Empty)
            {
                num1 = (num1 * 10) + 4;
                Display.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 4;
                Display.Text = num2.ToString();
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            // no operation selected, just display the number pressed
            if (operation == String.Empty)
            {
                num1 = (num1 * 10) + 5;
                Display.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 5;
                Display.Text = num2.ToString();
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            // no operation selected, just display the number pressed
            if (operation == String.Empty)
            {
                num1 = (num1 * 10) + 6;
                Display.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 6;
                Display.Text = num2.ToString();
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            // no operation selected, just display the number pressed
            if (operation == String.Empty)
            {
                num1 = (num1 * 10) + 7;
                Display.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 7;
                Display.Text = num2.ToString();
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            // no operation selected, just display the number pressed
            if (operation == String.Empty)
            {
                num1 = (num1 * 10) + 8;
                Display.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 8;
                Display.Text = num2.ToString();
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            // no operation selected, just display the number pressed
            if (operation == String.Empty)
            {
                num1 = (num1 * 10) + 9;
                Display.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 9;
                Display.Text = num2.ToString();
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            Display.Text = "0"; // when doing an operation the display shows zero and awaits the next number
        }

        private void btnSub_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            Display.Text = "0"; // when doing an operation the display shows zero and awaits the next number
        }

        private void btnMult_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            Display.Text = "0"; // when doing an operation the display shows zero and awaits the next number
        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            Display.Text = "0"; // when doing an operation the display shows zero and awaits the next number
        }


        // when running program, the sqrt button must be clicked first and then the number you wish to find the square root of,
        // unlike traditional calculators where the number you wish to find the square root of is entered first and then the square root button
        private void btnSqrt_Click(object sender, RoutedEventArgs e)
        {
            operation = "sqrt";
            Display.Text = "0"; // when doing an operation the display shows zero and awaits the next number
        }

        private void btnNeg_Click(object sender, RoutedEventArgs e)
        {
            if (operation == String.Empty)
            {
                num1 *= -1;
                Display.Text = num1.ToString();
            }
            else
            {
                num2 *= -1;
                Display.Text = num2.ToString();
            }
        }

        private void btnEq_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    Display.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    Display.Text = (num1 - num2).ToString();
                    break;
                case "*":
                    Display.Text = (num1 * num2).ToString();
                    break;
                case "/":
                    Display.Text = (num1 / num2).ToString();
                    break;
                case "sqrt":
                    Display.Text = (Math.Sqrt(num2)).ToString();
                    break;
            }
        }

        // to clear the current register being entered into, "clear entry"
        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
            if (operation == String.Empty)
            {
                num1 = 0;
                Display.Text = num1.ToString();
            }
            else
            {
                num2 = 0;
                Display.Text = num2.ToString();
            }
        }

        // to clear everything
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            num1 = 0;
            num2 = 0;
            operation = String.Empty;
            Display.Text = "0";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator__{

    public partial class Form1 : Form{

        string[] numbers = {string.Empty, string.Empty};

        string input = string.Empty;

        char function;

        double result = 0;

        private void Reset(){

            numbers[0] = string.Empty;
            numbers[1] = string.Empty;
            input = string.Empty;
            result = 0;
            Display.Text = "0";

        }

        public Form1(){

            InitializeComponent();
        
        }

        private void Display_Click(object sender, EventArgs e){



        }

        private void ButtonClear_Click(object sender, EventArgs e){

            Reset();

        }

        private void ButtonBackspace_Click(object sender, EventArgs e){

            if(Display.Text == "0" || input == string.Empty) { return; }

            input = input.Remove(input.Length - 1, 1);
            result = 0;
            Display.Text = Display.Text.Remove(Display.Text.Length - 1, 1);

        }

        private void ButtonMultiply_Click(object sender, EventArgs e){

            function = '*';
            numbers[0] = input;
            input = string.Empty;

        }

        private void ButtonDivide_Click(object sender, EventArgs e){

            function = '/';
            numbers[0] = input;
            input = string.Empty;

        }

        private void buttonSeven_Click(object sender, EventArgs e){

            Display.Text = string.Empty;
            input += "7";
            Display.Text = input;

        }

        private void ButtonEight_Click(object sender, EventArgs e){

            Display.Text = string.Empty;
            input += "8";
            Display.Text = input;

        }

        private void ButtonNine_Click(object sender, EventArgs e){

            Display.Text = string.Empty;
            input += "9";
            Display.Text = input;

        }

        private void ButtonFour_Click(object sender, EventArgs e){

            Display.Text = string.Empty;
            input += "4";
            Display.Text = input;

        }

        private void ButtonFive_Click(object sender, EventArgs e){

            Display.Text = string.Empty;
            input += "5";
            Display.Text = input;

        }

        private void ButtonSix_Click(object sender, EventArgs e){

            Display.Text = string.Empty;
            input += "6";
            Display.Text = input;

        }

        private void ButtonOne_Click(object sender, EventArgs e){

            Display.Text = string.Empty;
            input += "1";
            Display.Text = input;

        }

        private void ButtonTwo_Click(object sender, EventArgs e){

            Display.Text = string.Empty;
            input += "2";
            Display.Text = input;

        }

        private void ButtonThree_Click(object sender, EventArgs e){

            Display.Text = string.Empty;
            input += "3";
            Display.Text = input;

        }

        private void ButtonZero_Click(object sender, EventArgs e){

            Display.Text = string.Empty;
            input += "0";
            Display.Text = input;

        }

        private void ButtonDecimal_Click(object sender, EventArgs e){

            Display.Text = string.Empty;
            input += ".";
            Display.Text = input;

        }

        private void ButtonEquals_Click(object sender, EventArgs e){

            numbers[1] = input;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(numbers[0]);
            secondNum = Convert.ToDouble(numbers[1]);
            char tempfunction = function;

            Reset();

            bool functionCheck = (tempfunction != '+' || tempfunction != '-' || tempfunction != '/' || tempfunction != '*') ? true : false;

            if (!functionCheck){

                Display.Text = "ERROR";

                return;

            }

            switch (tempfunction){

                case '+':
                    result = firstNum + secondNum;
                    break;

                case '-':
                    result = firstNum - secondNum;
                    break;

                case '/':
                    if(secondNum == 0) { Display.Text = "Cannot divide by zero!"; return; }
                    result = firstNum / secondNum;
                    break;

                case '*':
                    result = firstNum * secondNum;
                    break;

            }

            Display.Text = result.ToString();

        }

        private void ButtonPlus_Click(object sender, EventArgs e){

            function = '+';
            numbers[0] = input;
            input = string.Empty;

        }

        private void ButtonMinus_Click(object sender, EventArgs e){

            function = '-';
            numbers[0] = input;
            input = string.Empty;

        }

    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YeehawCalc
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBoxresult.Text == "0") || isOperationPerformed)
                textBoxresult.Clear();

            isOperationPerformed = false;
            Button button=(Button)sender;
            if (button.Text == ".")
            {
                if(!textBoxresult.Text.Contains("."))
                    textBoxresult.Text = textBoxresult.Text + button.Text;
            }
            else

            textBoxresult.Text = textBoxresult.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                button34.PerformClick();
                operationPerformed = button.Text;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {

                operationPerformed = button.Text;
                resultValue = Double.Parse(textBoxresult.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBoxresult.Text = "0";
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            textBoxresult.Text = "0";
            resultValue = 0;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBoxresult.Text = (resultValue + Double.Parse(textBoxresult.Text)).ToString();
                    break;
                case "-":
                    textBoxresult.Text = (resultValue - Double.Parse(textBoxresult.Text)).ToString();
                    break;
                case "*":
                    textBoxresult.Text = (resultValue * Double.Parse(textBoxresult.Text)).ToString();
                    break;
                case "/":
                    textBoxresult.Text = (resultValue / Double.Parse(textBoxresult.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(textBoxresult.Text);
            labelCurrentOperation.Text = "";
        }

        private void newCalculationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxresult.Clear();
            textBoxresult.Text = "0";
            resultValue = 0;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutYeehawCalcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YeehawCalc version 1.0, made by yeehaw so that I can open source this code to Github, made in VS 2019 with .NET 4.7.2", "About YeehawCalc");
        }

        private void plusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can use this code and add stuff as long as you don't use your modified program to advertise for your business, no matter if you're making money or not. Pretty sure you can use that money to donate to charity :P", "Remember!");
        }

        private void myYoutubeChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/@pasta_real");
        }

        private void myTwitterAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://x.com/yeehawpasta");
        }

        private void myGithubProjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/pastareal");
        }
    }
}

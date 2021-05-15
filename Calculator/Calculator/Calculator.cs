using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    /* AC means all clear
* CE means clear all
* M means memory clear
* M+ means Memory plus
* M- means Memory minus
* Mr means Memory recall
*/
    {//contains my former code having errors that I couldn't debug. Lol
        //// Double finalResult = 0;
        //Double resultValue = 0;
        //string clickedOperator = "";
        //bool isOperationPerformed = false;


        //private void button_click(object sender, EventArgs e)
        //{

        //    //if (isOperationPerformed)
        //    //{
        //    //    textboxdisplay.Clear();
        //    //}
        //    if (isOperationPerformed || (textboxdisplay.Text == "0"))
        //    {
        //        textboxdisplay.Clear();
        //        //labeldatashow.Text = "";
        //    }
        //    Button button = (Button)sender;
        //    isOperationPerformed = false;
        //    if (button.Text == ".")
        //    {
        //        if (!textboxdisplay.Text.Contains("."))
        //        {
        //            textboxdisplay.Text = textboxdisplay.Text + button.Text;
        //            //labeldatashow.Text = labeldatashow.Text + " " + button.Text;
        //        }
        //    }
        //    else
        //    {
        //        textboxdisplay.Text = textboxdisplay.Text + button.Text;
        //        //labeldatashow.Text = labeldatashow.Text + " " + button.Text;
        //    }
        //}

        //private void operator_click(object sender, EventArgs e)
        //{
        //    Button button = (Button)sender;
        //    if (resultValue != 0)
        //    {
        //        equaltobtn.PerformClick();
        //        clickedOperator = button.Text;
        //        labeldatashow.Text = resultValue + " " + clickedOperator;
        //        isOperationPerformed = true;
        //    }
        //    else
        //    {
        //        clickedOperator = button.Text;
        //        resultValue = Double.Parse(textboxdisplay.Text);
        //        labeldatashow.Text = resultValue + " " + clickedOperator;
        //        isOperationPerformed = true;
        //    }

        //}
        //private void timesbtn_Click(object sender, EventArgs e)
        //{
        //    if (resultValue != 0)
        //    {
        //        equaltobtn.PerformClick();
        //        clickedOperator = "x";
        //        labeldatashow.Text = textboxdisplay.Text + " " + "x";
        //        isOperationPerformed = true;
        //    }
        //    else
        //    {
        //        clickedOperator = "x";
        //        resultValue = Double.Parse(textboxdisplay.Text);
        //        labeldatashow.Text = resultValue + " " + clickedOperator;
        //        isOperationPerformed = true;
        //    }
        //}
        //private void equaltobtn_Click(object sender, EventArgs e)
        //{
        //    switch (clickedOperator)
        //    {
        //        case "+":
        //            textboxdisplay.Text = (resultValue + Double.Parse(textboxdisplay.Text)).ToString();
        //            break;
        //        case "-":
        //            textboxdisplay.Text = (resultValue - Double.Parse(textboxdisplay.Text)).ToString();
        //            break;
        //        case "/":
        //            textboxdisplay.Text = (resultValue / Double.Parse(textboxdisplay.Text)).ToString();
        //            break;
        //        case "x":
        //            textboxdisplay.Text = (resultValue * Double.Parse(textboxdisplay.Text)).ToString();
        //            break;
        //        default:
        //            break;
        //    }
        //    resultValue = Double.Parse(textboxdisplay.Text);
        //    labeldatashow.Text = "";
        //}

        //private void Sqrtbtn_Click(object sender, EventArgs e)
        //{

        //}
        //private void Cbtn_Click(object sender, EventArgs e)
        //{
        //    resultValue = 0;
        //    //isOperationPerformed = false;
        //    textboxdisplay.Text = "0";
        //    //labeldatashow.Text = "";
        //}
        //private void CEbtn_Click(object sender, EventArgs e)
        //{
        //    // isOperationPerformed = false;
        //    textboxdisplay.Text = "0";
        //    //labeldatashow.Text = "";
        //}
        //private void delbtn_Click(object sender, EventArgs e)
        //{
        //    if (textboxdisplay.Text.Length != 0)
        //    {
        //        if (labeldatashow.Text.Length > textboxdisplay.Text.Length)
        //        {
        //            labeldatashow.Text = labeldatashow.Text.Remove(labeldatashow.Text.Length - 1);
        //        }
        //        if (labeldatashow.Text != "")
        //        {
        //            labeldatashow.Text = textboxdisplay.Text;
        //            labeldatashow.Text = labeldatashow.Text.Remove(labeldatashow.Text.Length - 1);
        //        }
        //        textboxdisplay.Text = textboxdisplay.Text.Remove(textboxdisplay.Text.Length - 1);
        //    }
        //}

        //private void Mbtn_Click(object sender, EventArgs e)
        //{

        //}

        //private void Mminusbtn_Click(object sender, EventArgs e)
        //{

        //}
        /*.............................................................. .*/
        public Calculator()
        {
            InitializeComponent();
        }
        public void num_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string dis = textboxdisplay.Text;
            if (isOperationClicked) { 
                textboxdisplay.Clear();
                isOperationClicked = false;
            }
            // if display is 0 then clear 0 and add num
            if (dis == "0") 
            {
                switch (btn.Text)
                    {case ".":
                        textboxdisplay.Text += btn.Text;
                    break;
                    case "0":
                        break;
                    case "00":
                        break;
                    default:
                        textboxdisplay.Clear();
                    textboxdisplay.Text += btn.Text;
                    break;
                }
            }
            else
            {
                if (dis.Contains(".") && btn.Text == ".") { }
                else textboxdisplay.Text += btn.Text;
                
            }
            isOperationClicked = false;

        }
        string operatorValue = "";
        Double resultvalue = 0;
        bool isOperationClicked = false;
        public void operatorClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operatorValue = button.Text;
            if(operatorValue == "√")
            {
                labeldatashow.Text = button.Text;
                textboxdisplay.Text = "0";
            }
            else
            {
                labeldatashow.Text = textboxdisplay.Text + " " + operatorValue;
                resultvalue = Double.Parse(textboxdisplay.Text);
                isOperationClicked = true;
            }
        }

        private void equal(object sender, EventArgs e)
        {
            switch (operatorValue)
            {
                case "+":
                    textboxdisplay.Text = (resultvalue + Double.Parse(textboxdisplay.Text)).ToString();
                    break;
                case "-":
                    textboxdisplay.Text = (resultvalue - Double.Parse(textboxdisplay.Text)).ToString();
                    break;
                case "/":
                    textboxdisplay.Text = (resultvalue / Double.Parse(textboxdisplay.Text)).ToString();
                    break;
                case "x":
                    textboxdisplay.Text = (resultvalue * Double.Parse(textboxdisplay.Text)).ToString();
                    break;
                case "√":
                    textboxdisplay.Text = Math.Sqrt(Double.Parse(textboxdisplay.Text)).ToString();
                    break;
                default:
                    break;
            }
            labeldatashow.Text = textboxdisplay.Text;
        }

        private void AC(object sender, EventArgs e)
        {
            resultvalue = 0;
            textboxdisplay.Text = "0";
            labeldatashow.Text = "";
        }
        private void CE(object sender, EventArgs e)
        {
            textboxdisplay.Text = "0";
            labeldatashow.Text = "";
        }

        private void M(object sender, EventArgs e)
        {
            textboxdisplay.Text = "0";
            labeldatashow.Text = "";
        }

        private void Delete(object sender, EventArgs e)
        {
            if (textboxdisplay.Text.Length != 0)
            {
                if (labeldatashow.Text.Length > textboxdisplay.Text.Length)
                {
                    labeldatashow.Text = labeldatashow.Text.Remove(labeldatashow.Text.Length - 1);
                }
                if (labeldatashow.Text != "")
                {
                    labeldatashow.Text = textboxdisplay.Text;
                    labeldatashow.Text = labeldatashow.Text.Remove(labeldatashow.Text.Length - 1);
                }
                textboxdisplay.Text = textboxdisplay.Text.Remove(textboxdisplay.Text.Length - 1);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorTest
{
    public partial class calcMainWindow : Form
    {
        #region globalVaiables
        /*Nullable<int> firstNumInput = null;
        Nullable<int> secondNumInput = null;
        Nullable<int> output = null;*/
        int actionCode = 0; 

        int firstNumInput = 0;
        int secondNumInput = 0; 

        #endregion

        public calcMainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtBoxOutput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnNumOne_Click(object sender, EventArgs e) {

            if (actionCode == 0)
            {
                if (txtBoxOutput.Text == "0")
                {
                    txtBoxOutput.Text = "1";
                    firstNumInput = 1;
                }

                else
                {
                    txtBoxOutput.AppendText("1");
                    firstNumInput = 1;
                }
            }

            else
            {
                txtBoxOutput.Text = "";
                if (txtBoxOutput.Text == "0")
                {
                    txtBoxOutput.Text = "1";
                    secondNumInput = secondNumInput + 1;
                }

                else
                {
                    txtBoxOutput.AppendText("1");
                    secondNumInput = secondNumInput + 1;
                }


            }


        }

        private void btnNumTwo_Click(object sender, EventArgs e)
        {
            if (actionCode == 0)
            {
                if (txtBoxOutput.Text == "0")
                {
                    txtBoxOutput.Text = "2";
                    firstNumInput = 2;
                }

                else
                {
                    txtBoxOutput.AppendText("2");
                    firstNumInput = 2;
                }
            }

            else
            {
                txtBoxOutput.Text = "";
                if (txtBoxOutput.Text == "2")
                {
                    txtBoxOutput.Text = "2";
                    secondNumInput = secondNumInput + 2;
                }

                else
                {
                    txtBoxOutput.AppendText("2");
                    secondNumInput = secondNumInput + 2;
                }


            }

        }

        private void btnNumThree_Click(object sender, EventArgs e)
        {
            if (actionCode == 0)
            {
                if (txtBoxOutput.Text == "0")
                {
                    txtBoxOutput.Text = "3";
                    firstNumInput = 3;
                }

                else
                {
                    txtBoxOutput.AppendText("3");
                    firstNumInput = 3;
                }
            }

            else
            {
                txtBoxOutput.Text = "";
                if (txtBoxOutput.Text == "0")
                {
                    txtBoxOutput.Text = "3";
                    secondNumInput = secondNumInput + 3;
                }

                else
                {
                    txtBoxOutput.AppendText("3");
                    secondNumInput = secondNumInput + 3;
                }


            }


        }

        private void btnNumFour_Click(object sender, EventArgs e)
        {
            if (actionCode == 0)
            {
                if (txtBoxOutput.Text == "0")
                {
                    txtBoxOutput.Text = "4";
                    firstNumInput = 4; 
                }

                else
                {
                    txtBoxOutput.AppendText("4");
                    firstNumInput = 4; 
                }
            }

            else
            {
                txtBoxOutput.Text = ""; 
                if (txtBoxOutput.Text == "0")
                {
                    txtBoxOutput.Text = "4";
                    secondNumInput = secondNumInput + 4; 
                }

                else
                {
                    txtBoxOutput.AppendText("4");
                    secondNumInput = secondNumInput + 4;
                }


            }

            /*if (firstNumInput == null)
            {
                firstNumInput = 4;

            }

            else
            {
                secondNumInput = 4;

            }*/
        }

        private void btnNumFive_Click(object sender, EventArgs e)
        {
            if (actionCode == 0)
            {
                if (txtBoxOutput.Text == "0")
                {
                    txtBoxOutput.Text = "5";
                    firstNumInput = 5;
                }

                else
                {
                    txtBoxOutput.AppendText("5");
                    firstNumInput = 5;
                }
            }

            else
            {
                txtBoxOutput.Text = "";
                if (txtBoxOutput.Text == "5")
                {
                    txtBoxOutput.Text = "5";
                    secondNumInput = secondNumInput + 5;
                }

                else
                {
                    txtBoxOutput.AppendText("5");
                    secondNumInput = secondNumInput + 5;
                }


            }
        }

        private void btnNumSix_Click(object sender, EventArgs e)
        {
            if (actionCode == 0)
            {
                if (txtBoxOutput.Text == "0")
                {
                    txtBoxOutput.Text = "6";
                    firstNumInput = 6;
                }

                else
                {
                    txtBoxOutput.AppendText("6");
                    firstNumInput = 6;
                }
            }

            else
            {
                txtBoxOutput.Text = "";
                if (txtBoxOutput.Text == "0")
                {
                    txtBoxOutput.Text = "6";
                    secondNumInput = secondNumInput + 6;
                }

                else
                {
                    txtBoxOutput.AppendText("6");
                    secondNumInput = secondNumInput + 6;
                }


            }

        }

        private void btnNumSeven_Click(object sender, EventArgs e)
        {

            if (actionCode == 0)
            {
                if (txtBoxOutput.Text == "0")
                {
                    txtBoxOutput.Text = "7";
                    firstNumInput = 7;
                }

                else
                {
                    txtBoxOutput.AppendText("7");
                    firstNumInput = 7;
                }
            }

            else
            {
                txtBoxOutput.Text = "";
                if (txtBoxOutput.Text == "0")
                {
                    txtBoxOutput.Text = "7";
                    secondNumInput = secondNumInput + 7;
                }

                else
                {
                    txtBoxOutput.AppendText("7");
                    secondNumInput = secondNumInput + 7;
                }


            }

        }

        private void btnNumEight_Click(object sender, EventArgs e)
        {

            if (actionCode == 0)
            {
                if (txtBoxOutput.Text == "0")
                {
                    txtBoxOutput.Text = "8";
                    firstNumInput = 8;
                }

                else
                {
                    txtBoxOutput.AppendText("8");
                    firstNumInput = 8;
                }
            }

            else
            {
                txtBoxOutput.Text = "";
                if (txtBoxOutput.Text == "0")
                {
                    txtBoxOutput.Text = "8";
                    secondNumInput = secondNumInput + 8;
                }

                else
                {
                    txtBoxOutput.AppendText("8");
                    secondNumInput = secondNumInput + 8;
                }


            }

        }

        private void btnNumNine_Click(object sender, EventArgs e)
        {

            if (actionCode == 0)
            {
                if (txtBoxOutput.Text == "0")
                {
                    txtBoxOutput.Text = "9";
                    firstNumInput = 9;
                }

                else
                {
                    txtBoxOutput.AppendText("9");
                    secondNumInput = secondNumInput + 9;
                }
            }

            else
            {
                txtBoxOutput.Text = "";
               

                
                
                    txtBoxOutput.AppendText("9");
                    secondNumInput = secondNumInput + 9;
                


            }

        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            actionCode = 1;
           // MessageBox.Show(actionCode.ToString()); 
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            actionCode = 2;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            actionCode = 3;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            actionCode = 4; 
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (actionCode == 1)
            {
                Nullable<int> output = firstNumInput + secondNumInput;
                txtBoxOutput.Text = output.ToString();
                actionCode = 0; 
            }
            if (actionCode == 2)
            {
                Nullable<int> output = firstNumInput - secondNumInput;
                txtBoxOutput.Text = output.ToString();
                actionCode = 0;
            }

            if (actionCode == 3)
            {
                Nullable<int> output = firstNumInput * secondNumInput;
                txtBoxOutput.Text = output.ToString();
                actionCode = 0;
            }

            if (actionCode == 4)
            {
                Nullable<int> output = firstNumInput / secondNumInput;
                txtBoxOutput.Text = output.ToString();
                actionCode = 0;
            }


            /*firstNumInput = null;
            secondNumInput = null;*/
            firstNumInput = 0;
            secondNumInput = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            /*firstNumInput = null;
            secondNumInput = null;*/
            firstNumInput = 0;
            secondNumInput = 0;
            // output = 1;
            txtBoxOutput.Text = "0"; 
            
        }

        private void btnNumZero_Click(object sender, EventArgs e)
        {

        }
    }
}

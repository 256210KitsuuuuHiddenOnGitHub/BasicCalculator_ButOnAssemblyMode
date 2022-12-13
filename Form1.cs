using PrivCalcAssembly;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace BasicCalculator_ButOnAssemblyMode
{
    public partial class FrmBasicCalculator : Form
    {
        //Not Required totally
        public float num1, num2;
        public string patternStringDetect = @"^(\d*\.)?\d+$"; //For Regex

        public FrmBasicCalculator()
        {
            InitializeComponent();
            //Set Default
            cbOperator.SelectedIndex = 0;
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            try
            {
                //Call Assembly class
                CalcAssembly pca = new CalcAssembly();
                num1 = float.Parse(txtBoxNum1.Text);
                num2 = float.Parse(txtBoxNum2.Text);

                switch (cbOperator.Text.ToString())
                {
                    //Addition
                    case "+":
                        txtBoxResults.Text = Convert.ToString(pca.Addition(num1, num2));
                        break;
                    //Subtraction
                    case "-":
                        txtBoxResults.Text = Convert.ToString(pca.Subtraction(num1, num2));
                        break;
                    //Multiplication
                    case "*":
                        txtBoxResults.Text = Convert.ToString(pca.Multiplication(num1, num2));
                        break;
                    //Division
                    case "/":
                        txtBoxResults.Text = Convert.ToString(pca.Division(num1, num2));
                        break;
                    //Else
                    default:
                        //Do Nothing Here
                        break;
                }
            }
            catch (Exception)
            {
                //Double Check
                if(txtBoxNum1.Text.ToString().Trim() == "")
                {
                    lbNum1Err.ForeColor = Color.Red;
                    if (txtBoxNum2.Text.ToString().Trim() == "") {
                        lbNum2Err.ForeColor = Color.Red;
                    }
                    
                }else if (txtBoxNum2.Text.ToString().Trim() == "")
                {
                    lbNum2Err.ForeColor= Color.Red;
                    if (txtBoxNum1.Text.ToString().Trim() == "")
                    {
                        lbNum1Err.ForeColor = Color.Red;
                    }
                }
                else
                {
                    //Do Nothing
                }
                txtBoxResults.Text = "Invalid input, Check Red Marks";
            }

        }

        private void lbNum1Err_Click(object sender, EventArgs e)
        {
            //Do nothing Here
        }

        private void txtBoxNum2_TextChanged(object sender, EventArgs e)
        {
            string box2 = txtBoxNum2.Text.ToString();
            //One Line Mode Tenary Operator
            lbNum2Err.ForeColor = !Regex.IsMatch(box2, patternStringDetect) ? Color.Red : Color.LimeGreen;
        }

        //Show Error Mark Color
        private void txtBoxNum1_TextChanged(object sender, EventArgs e)
        {
            string box1 = txtBoxNum1.Text.ToString();
            //One Line Mode Tenary Operator
            lbNum1Err.ForeColor = !Regex.IsMatch(box1, patternStringDetect) ? Color.Red : Color.LimeGreen;
        }

    }

}
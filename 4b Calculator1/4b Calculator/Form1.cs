namespace _4b_Calculator
{
    public partial class frmCalculator1 : Form
    {
        //Declares Global Variables
        double dblNum1;
        double dblNum2;
        double dblAnswer;


        public frmCalculator1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try //Will catch errors
            {
                //Converts strings to a double data type
                dblNum1 = double.Parse(txtFirstNum.Text);
                dblNum2 = double.Parse(txtSecondNum.Text);

                //Does math based on which radio button is selected
                if (radAdd.Checked == true)
                    dblAnswer = dblNum1 + dblNum2;
                else if (radSub.Checked == true)
                    dblAnswer = dblNum1 - dblNum2;
                else if (radMult.Checked == true)
                    dblAnswer = dblNum1 * dblNum2;
                else
                    dblAnswer = dblNum1 / dblNum2;

                lblAnswer.Text = dblAnswer.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("You entered an invalid data type"); //Makes error message appear
                txtFirstNum.Clear();
                txtSecondNum.Clear();
                txtFirstNum.Focus();
            }
        }

        private void lblSecondNum_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radAdd_CheckedChanged(object sender, EventArgs e)
        {
            lblSign.Text = "+";
        }

        private void radSub_CheckedChanged(object sender, EventArgs e)
        {
            lblSign.Text = "-";
        }

        private void radMult_CheckedChanged(object sender, EventArgs e)
        {
            lblSign.Text = "X";
        }

        private void radDiv_CheckedChanged(object sender, EventArgs e)
        {
            lblSign.Text = "/";
        }


    }
}
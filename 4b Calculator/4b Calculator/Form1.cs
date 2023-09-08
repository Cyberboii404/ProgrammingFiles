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
            dblNum1 = double.Parse(txtFirstNum.Text);
            dblNum2 = double.Parse(txtSecondNum.Text);

            dblAnswer = dblNum1 + dblNum2; //Adds the two numbers together
            lblAnswer.Text = dblAnswer.ToString(); //Converts the answer to a string and puts it in lblAnswer label

        }

        private void lblSecondNum_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
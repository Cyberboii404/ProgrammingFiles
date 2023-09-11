namespace Bob_s_Carpet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double dblLength;
            double dblCost;
            double dblAnswer;

            try
            {
                dblLength = Double.Parse(txtLength.Text);
                dblCost = Double.Parse(txtCost.Text);

                if (rad12.Checked)
                    dblAnswer = width12(dblLength, dblCost);
                else
                    dblAnswer = width15(dblLength, dblCost);

                lblAnswer.Text = "The price of your carpet is " + dblAnswer.ToString("c");
            }

            catch
            {
                txtLength.Clear();
                MessageBox.Show("You entered invalid data");
                txtLength.Focus();
            }
        }

        private double width12 (double L, double C)
        {
            double answer;
            answer = L * C;
            return answer;
        }

        private double width15 (double L, double C)
        {
            double answer;
            answer = L * C * 1.25;
            return answer;
        }
    }
}
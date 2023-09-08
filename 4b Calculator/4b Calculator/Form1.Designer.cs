namespace _4b_Calculator
{
    partial class frmCalculator1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFirstNum = new Label();
            lblSecondNum = new Label();
            lblSign = new Label();
            lblAnswer = new Label();
            btnCalculate = new Button();
            btnExit = new Button();
            txtFirstNum = new TextBox();
            txtSecondNum = new TextBox();
            SuspendLayout();
            // 
            // lblFirstNum
            // 
            lblFirstNum.AutoSize = true;
            lblFirstNum.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblFirstNum.Location = new Point(36, 19);
            lblFirstNum.Name = "lblFirstNum";
            lblFirstNum.Size = new Size(142, 30);
            lblFirstNum.TabIndex = 0;
            lblFirstNum.Text = "First Number";
            // 
            // lblSecondNum
            // 
            lblSecondNum.AutoSize = true;
            lblSecondNum.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSecondNum.Location = new Point(21, 195);
            lblSecondNum.Name = "lblSecondNum";
            lblSecondNum.Size = new Size(172, 30);
            lblSecondNum.TabIndex = 1;
            lblSecondNum.Text = "Second Number";
            lblSecondNum.Click += lblSecondNum_Click;
            // 
            // lblSign
            // 
            lblSign.AutoSize = true;
            lblSign.Location = new Point(94, 133);
            lblSign.Name = "lblSign";
            lblSign.Size = new Size(27, 30);
            lblSign.TabIndex = 2;
            lblSign.Text = "+";
            // 
            // lblAnswer
            // 
            lblAnswer.AutoSize = true;
            lblAnswer.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAnswer.Location = new Point(64, 306);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(86, 30);
            lblAnswer.TabIndex = 3;
            lblAnswer.Text = "Answer";
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.Beige;
            btnCalculate.Location = new Point(50, 340);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(115, 42);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Beige;
            btnExit.Location = new Point(322, 340);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(115, 42);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // txtFirstNum
            // 
            txtFirstNum.Location = new Point(32, 52);
            txtFirstNum.Name = "txtFirstNum";
            txtFirstNum.Size = new Size(150, 35);
            txtFirstNum.TabIndex = 6;
            // 
            // txtSecondNum
            // 
            txtSecondNum.Location = new Point(32, 228);
            txtSecondNum.Name = "txtSecondNum";
            txtSecondNum.Size = new Size(150, 35);
            txtSecondNum.TabIndex = 7;
            // 
            // frmCalculator1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 411);
            Controls.Add(txtSecondNum);
            Controls.Add(txtFirstNum);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(lblAnswer);
            Controls.Add(lblSign);
            Controls.Add(lblSecondNum);
            Controls.Add(lblFirstNum);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "frmCalculator1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstNum;
        private Label lblSecondNum;
        private Label lblSign;
        private Label lblAnswer;
        private Button btnCalculate;
        private Button btnExit;
        private TextBox txtFirstNum;
        private TextBox txtSecondNum;
    }
}
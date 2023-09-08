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
            groupBox1 = new GroupBox();
            radDiv = new RadioButton();
            radMult = new RadioButton();
            radSub = new RadioButton();
            radAdd = new RadioButton();
            groupBox1.SuspendLayout();
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
            btnCalculate.TabIndex = 3;
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
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // txtFirstNum
            // 
            txtFirstNum.Location = new Point(32, 52);
            txtFirstNum.Name = "txtFirstNum";
            txtFirstNum.Size = new Size(150, 35);
            txtFirstNum.TabIndex = 0;
            // 
            // txtSecondNum
            // 
            txtSecondNum.Location = new Point(32, 228);
            txtSecondNum.Name = "txtSecondNum";
            txtSecondNum.Size = new Size(150, 35);
            txtSecondNum.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radDiv);
            groupBox1.Controls.Add(radMult);
            groupBox1.Controls.Add(radSub);
            groupBox1.Controls.Add(radAdd);
            groupBox1.Location = new Point(272, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 302);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select Operation";
            // 
            // radDiv
            // 
            radDiv.AutoSize = true;
            radDiv.Location = new Point(14, 250);
            radDiv.Name = "radDiv";
            radDiv.Size = new Size(89, 34);
            radDiv.TabIndex = 3;
            radDiv.Text = "Divide";
            radDiv.UseVisualStyleBackColor = true;
            radDiv.CheckedChanged += radDiv_CheckedChanged;
            // 
            // radMult
            // 
            radMult.AutoSize = true;
            radMult.Location = new Point(14, 191);
            radMult.Name = "radMult";
            radMult.Size = new Size(106, 34);
            radMult.TabIndex = 2;
            radMult.Text = "Multiply";
            radMult.UseVisualStyleBackColor = true;
            radMult.CheckedChanged += radMult_CheckedChanged;
            // 
            // radSub
            // 
            radSub.AutoSize = true;
            radSub.Location = new Point(14, 132);
            radSub.Name = "radSub";
            radSub.Size = new Size(108, 34);
            radSub.TabIndex = 1;
            radSub.Text = "Subtract";
            radSub.UseVisualStyleBackColor = true;
            radSub.CheckedChanged += radSub_CheckedChanged;
            // 
            // radAdd
            // 
            radAdd.AutoSize = true;
            radAdd.Checked = true;
            radAdd.Location = new Point(14, 73);
            radAdd.Name = "radAdd";
            radAdd.Size = new Size(69, 34);
            radAdd.TabIndex = 0;
            radAdd.TabStop = true;
            radAdd.Text = "Add";
            radAdd.UseVisualStyleBackColor = true;
            radAdd.CheckedChanged += radAdd_CheckedChanged;
            // 
            // frmCalculator1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 411);
            Controls.Add(groupBox1);
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private GroupBox groupBox1;
        private RadioButton radDiv;
        private RadioButton radMult;
        private RadioButton radSub;
        private RadioButton radAdd;
    }
}
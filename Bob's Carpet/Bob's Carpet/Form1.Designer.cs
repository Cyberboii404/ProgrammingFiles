namespace Bob_s_Carpet
{
    partial class Form1
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
            txtLength = new TextBox();
            txtCost = new TextBox();
            lblLength = new Label();
            lblCost = new Label();
            lblBobsCarpet = new Label();
            groupBox1 = new GroupBox();
            rad12 = new RadioButton();
            rad15 = new RadioButton();
            btnCalculate = new Button();
            lblAnswer = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtLength
            // 
            txtLength.Location = new Point(71, 121);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(113, 23);
            txtLength.TabIndex = 0;
            // 
            // txtCost
            // 
            txtCost.Location = new Point(71, 212);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(113, 23);
            txtCost.TabIndex = 1;
            // 
            // lblLength
            // 
            lblLength.AutoSize = true;
            lblLength.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblLength.Location = new Point(71, 101);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(106, 17);
            lblLength.TabIndex = 2;
            lblLength.Text = "Length of Carpet";
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCost.Location = new Point(74, 192);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(87, 17);
            lblCost.TabIndex = 3;
            lblCost.Text = "Cost Per Foot";
            // 
            // lblBobsCarpet
            // 
            lblBobsCarpet.AutoSize = true;
            lblBobsCarpet.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblBobsCarpet.Location = new Point(177, 46);
            lblBobsCarpet.Name = "lblBobsCarpet";
            lblBobsCarpet.Size = new Size(180, 37);
            lblBobsCarpet.TabIndex = 4;
            lblBobsCarpet.Text = "Bob's Carpet";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rad15);
            groupBox1.Controls.Add(rad12);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(296, 101);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 152);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Carpet Width";
            // 
            // rad12
            // 
            rad12.AutoSize = true;
            rad12.Location = new Point(28, 47);
            rad12.Name = "rad12";
            rad12.Size = new Size(70, 21);
            rad12.TabIndex = 0;
            rad12.TabStop = true;
            rad12.Text = "12 Foot";
            rad12.UseVisualStyleBackColor = true;
            // 
            // rad15
            // 
            rad15.AutoSize = true;
            rad15.Location = new Point(28, 87);
            rad15.Name = "rad15";
            rad15.Size = new Size(70, 21);
            rad15.TabIndex = 1;
            rad15.TabStop = true;
            rad15.Text = "15 Foot";
            rad15.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(74, 300);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblAnswer
            // 
            lblAnswer.AutoSize = true;
            lblAnswer.Location = new Point(281, 308);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(0, 15);
            lblAnswer.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 361);
            Controls.Add(lblAnswer);
            Controls.Add(btnCalculate);
            Controls.Add(groupBox1);
            Controls.Add(lblBobsCarpet);
            Controls.Add(lblCost);
            Controls.Add(lblLength);
            Controls.Add(txtCost);
            Controls.Add(txtLength);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLength;
        private TextBox txtCost;
        private Label lblLength;
        private Label lblCost;
        private Label lblBobsCarpet;
        private GroupBox groupBox1;
        private RadioButton rad15;
        private RadioButton rad12;
        private Button btnCalculate;
        private Label lblAnswer;
    }
}
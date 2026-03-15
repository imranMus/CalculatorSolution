namespace calculatorUi
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
            addBtn = new Button();
            minusBtn = new Button();
            multBtn = new Button();
            divBtn = new Button();
            num1 = new TextBox();
            num2 = new TextBox();
            numRes = new TextBox();
            SuspendLayout();
            // 
            // addBtn
            // 
            addBtn.Location = new Point(344, 195);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 29);
            addBtn.TabIndex = 0;
            addBtn.Text = "+";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // minusBtn
            // 
            minusBtn.Location = new Point(344, 230);
            minusBtn.Name = "minusBtn";
            minusBtn.Size = new Size(94, 29);
            minusBtn.TabIndex = 1;
            minusBtn.Text = "-";
            minusBtn.UseVisualStyleBackColor = true;
            minusBtn.Click += minusBtn_Click;
            // 
            // multBtn
            // 
            multBtn.Location = new Point(344, 265);
            multBtn.Name = "multBtn";
            multBtn.Size = new Size(94, 29);
            multBtn.TabIndex = 2;
            multBtn.Text = "x";
            multBtn.UseVisualStyleBackColor = true;
            multBtn.Click += multBtn_Click;
            // 
            // divBtn
            // 
            divBtn.Location = new Point(344, 300);
            divBtn.Name = "divBtn";
            divBtn.Size = new Size(94, 29);
            divBtn.TabIndex = 3;
            divBtn.Text = "÷";
            divBtn.UseVisualStyleBackColor = true;
            divBtn.Click += divBtn_Click;
            // 
            // num1
            // 
            num1.Location = new Point(326, 38);
            num1.Name = "num1";
            num1.Size = new Size(125, 27);
            num1.TabIndex = 4;
            num1.TextChanged += textBox1_TextChanged;
            // 
            // num2
            // 
            num2.Location = new Point(326, 71);
            num2.Name = "num2";
            num2.Size = new Size(125, 27);
            num2.TabIndex = 5;
            // 
            // numRes
            // 
            numRes.Location = new Point(326, 104);
            numRes.Name = "numRes";
            numRes.ReadOnly = true;
            numRes.Size = new Size(125, 27);
            numRes.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numRes);
            Controls.Add(num2);
            Controls.Add(num1);
            Controls.Add(divBtn);
            Controls.Add(multBtn);
            Controls.Add(minusBtn);
            Controls.Add(addBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addBtn;
        private Button minusBtn;
        private Button multBtn;
        private Button divBtn;
        private TextBox num1;
        private TextBox num2;
        private TextBox numRes;
    }
}

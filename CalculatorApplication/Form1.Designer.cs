namespace CalculatorApplication
{
    partial class FrmCalculator
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
            components = new System.ComponentModel.Container();
            txtBoxInput1 = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtBoxInput2 = new TextBox();
            cbOperator = new ComboBox();
            lblDisplayTotal = new Label();
            btnEqual = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtBoxInput1
            // 
            txtBoxInput1.Location = new Point(347, 40);
            txtBoxInput1.Name = "txtBoxInput1";
            txtBoxInput1.Size = new Size(125, 27);
            txtBoxInput1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtBoxInput2
            // 
            txtBoxInput2.Location = new Point(347, 107);
            txtBoxInput2.Name = "txtBoxInput2";
            txtBoxInput2.Size = new Size(125, 27);
            txtBoxInput2.TabIndex = 2;
            txtBoxInput2.TextChanged += txtBoxInput2_TextChanged;
            // 
            // cbOperator
            // 
            cbOperator.FormattingEnabled = true;
            cbOperator.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cbOperator.Location = new Point(386, 73);
            cbOperator.Name = "cbOperator";
            cbOperator.Size = new Size(61, 28);
            cbOperator.TabIndex = 3;
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.AutoSize = true;
            lblDisplayTotal.Location = new Point(400, 150);
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(17, 20);
            lblDisplayTotal.TabIndex = 4;
            lblDisplayTotal.Text = "0";
            // 
            // btnEqual
            // 
            btnEqual.Location = new Point(353, 195);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(94, 29);
            btnEqual.TabIndex = 5;
            btnEqual.Text = "button1";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(193, 43);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 6;
            label1.Text = "Enter First Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 107);
            label2.Name = "label2";
            label2.Size = new Size(154, 20);
            label2.TabIndex = 7;
            label2.Text = "Enter Second Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(271, 150);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 8;
            label3.Text = "Answer";
            // 
            // FrmCalculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEqual);
            Controls.Add(lblDisplayTotal);
            Controls.Add(cbOperator);
            Controls.Add(txtBoxInput2);
            Controls.Add(txtBoxInput1);
            Name = "FrmCalculator";
            Text = "FrmCalculator";
            Load += FrmCalculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxInput1;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtBoxInput2;
        private ComboBox cbOperator;
        private Label lblDisplayTotal;
        private Button btnEqual;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}

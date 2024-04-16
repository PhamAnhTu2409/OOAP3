namespace WinFormsApp1
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

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            manhattanRadioButton = new RadioButton();
            maxRadioButton = new RadioButton();
            euclideanRadioButton = new RadioButton();
            calculateButton = new Button();
            y2TextBox = new TextBox();
            label4 = new Label();
            x2TextBox = new TextBox();
            label3 = new Label();
            y1TextBox = new TextBox();
            label2 = new Label();
            x1TextBox = new TextBox();
            label1 = new Label();
            resultLabel = new Label();
            toolTip1 = new ToolTip(components);
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(manhattanRadioButton);
            groupBox1.Controls.Add(maxRadioButton);
            groupBox1.Controls.Add(euclideanRadioButton);
            groupBox1.Location = new Point(263, 28);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(181, 133);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Calculation Method";
            // 
            // manhattanRadioButton
            // 
            manhattanRadioButton.AutoSize = true;
            manhattanRadioButton.Location = new Point(7, 88);
            manhattanRadioButton.Margin = new Padding(3, 4, 3, 4);
            manhattanRadioButton.Name = "manhattanRadioButton";
            manhattanRadioButton.Size = new Size(101, 24);
            manhattanRadioButton.TabIndex = 2;
            manhattanRadioButton.TabStop = true;
            manhattanRadioButton.Text = "Manhattan";
            manhattanRadioButton.UseVisualStyleBackColor = true;
            manhattanRadioButton.CheckedChanged += manhattanRadioButton_CheckedChanged;
            // 
            // maxRadioButton
            // 
            maxRadioButton.AutoSize = true;
            maxRadioButton.Location = new Point(7, 57);
            maxRadioButton.Margin = new Padding(3, 4, 3, 4);
            maxRadioButton.Name = "maxRadioButton";
            maxRadioButton.Size = new Size(58, 24);
            maxRadioButton.TabIndex = 1;
            maxRadioButton.TabStop = true;
            maxRadioButton.Text = "Max";
            maxRadioButton.UseVisualStyleBackColor = true;
            maxRadioButton.CheckedChanged += maxRadioButton_CheckedChanged;
            // 
            // euclideanRadioButton
            // 
            euclideanRadioButton.AutoSize = true;
            euclideanRadioButton.Location = new Point(7, 27);
            euclideanRadioButton.Margin = new Padding(3, 4, 3, 4);
            euclideanRadioButton.Name = "euclideanRadioButton";
            euclideanRadioButton.Size = new Size(94, 24);
            euclideanRadioButton.TabIndex = 0;
            euclideanRadioButton.TabStop = true;
            euclideanRadioButton.Text = "Euclidean";
            euclideanRadioButton.UseVisualStyleBackColor = true;
            euclideanRadioButton.CheckedChanged += euclideanRadioButton_CheckedChanged;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(27, 216);
            calculateButton.Margin = new Padding(3, 4, 3, 4);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(181, 47);
            calculateButton.TabIndex = 1;
            calculateButton.Text = "Calculate Distance";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // y2TextBox
            // 
            y2TextBox.Location = new Point(101, 151);
            y2TextBox.Margin = new Padding(3, 4, 3, 4);
            y2TextBox.Name = "y2TextBox";
            y2TextBox.Size = new Size(107, 27);
            y2TextBox.TabIndex = 15;
            toolTip1.SetToolTip(y2TextBox, "Enter the y-coordinate of the second point.");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 155);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 14;
            label4.Text = "Y2 = ";
            // 
            // x2TextBox
            // 
            x2TextBox.Location = new Point(101, 112);
            x2TextBox.Margin = new Padding(3, 4, 3, 4);
            x2TextBox.Name = "x2TextBox";
            x2TextBox.Size = new Size(107, 27);
            x2TextBox.TabIndex = 13;
            toolTip1.SetToolTip(x2TextBox, "Enter the x-coordinate of the second point.");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 116);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 12;
            label3.Text = "X2 = ";
            // 
            // y1TextBox
            // 
            y1TextBox.Location = new Point(101, 74);
            y1TextBox.Margin = new Padding(3, 4, 3, 4);
            y1TextBox.Name = "y1TextBox";
            y1TextBox.Size = new Size(107, 27);
            y1TextBox.TabIndex = 11;
            toolTip1.SetToolTip(y1TextBox, "Enter the y-coordinate of the first point.");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 78);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 10;
            label2.Text = "Y1 = ";
            // 
            // x1TextBox
            // 
            x1TextBox.Location = new Point(101, 35);
            x1TextBox.Margin = new Padding(3, 4, 3, 4);
            x1TextBox.Name = "x1TextBox";
            x1TextBox.Size = new Size(107, 27);
            x1TextBox.TabIndex = 9;
            toolTip1.SetToolTip(x1TextBox, "Enter the x-coordinate of the first point.");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 39);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 8;
            label1.Text = "X1 = ";
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(263, 186);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 20);
            resultLabel.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 311);
            Controls.Add(resultLabel);
            Controls.Add(y2TextBox);
            Controls.Add(label4);
            Controls.Add(x2TextBox);
            Controls.Add(label3);
            Controls.Add(y1TextBox);
            Controls.Add(label2);
            Controls.Add(x1TextBox);
            Controls.Add(label1);
            Controls.Add(calculateButton);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Distance Calculator";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton manhattanRadioButton;
        private System.Windows.Forms.RadioButton maxRadioButton;
        private System.Windows.Forms.RadioButton euclideanRadioButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox y2TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox x2TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox y1TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox x1TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

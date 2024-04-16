
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.manhattanResultLabel = new System.Windows.Forms.Label();
            this.maxResultLabel = new System.Windows.Forms.Label();
            this.euclideanResultLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.y2TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.x2TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.y1TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.x1TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.manhattanResultLabel);
            this.groupBox1.Controls.Add(this.maxResultLabel);
            this.groupBox1.Controls.Add(this.euclideanResultLabel);
            this.groupBox1.Controls.Add(this.calculateButton);
            this.groupBox1.Controls.Add(this.y2TextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.x2TextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.y1TextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.x1TextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 262);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // manhattanResultLabel
            // 
            this.manhattanResultLabel.AutoSize = true;
            this.manhattanResultLabel.Location = new System.Drawing.Point(7, 234);
            this.manhattanResultLabel.Name = "manhattanResultLabel";
            this.manhattanResultLabel.Size = new System.Drawing.Size(0, 17);
            this.manhattanResultLabel.TabIndex = 11;
            // 
            // maxResultLabel
            // 
            this.maxResultLabel.AutoSize = true;
            this.maxResultLabel.Location = new System.Drawing.Point(7, 208);
            this.maxResultLabel.Name = "maxResultLabel";
            this.maxResultLabel.Size = new System.Drawing.Size(0, 17);
            this.maxResultLabel.TabIndex = 10;
            // 
            // euclideanResultLabel
            // 
            this.euclideanResultLabel.AutoSize = true;
            this.euclideanResultLabel.Location = new System.Drawing.Point(7, 182);
            this.euclideanResultLabel.Name = "euclideanResultLabel";
            this.euclideanResultLabel.Size = new System.Drawing.Size(0, 17);
            this.euclideanResultLabel.TabIndex = 9;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(6, 145);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(295, 25);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // y2TextBox
            // 
            this.y2TextBox.Location = new System.Drawing.Point(44, 107);
            this.y2TextBox.Name = "y2TextBox";
            this.y2TextBox.Size = new System.Drawing.Size(82, 22);
            this.y2TextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Y2";
            // 
            // x2TextBox
            // 
            this.x2TextBox.Location = new System.Drawing.Point(44, 76);
            this.x2TextBox.Name = "x2TextBox";
            this.x2TextBox.Size = new System.Drawing.Size(82, 22);
            this.x2TextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "X2";
            // 
            // y1TextBox
            // 
            this.y1TextBox.Location = new System.Drawing.Point(44, 45);
            this.y1TextBox.Name = "y1TextBox";
            this.y1TextBox.Size = new System.Drawing.Size(82, 22);
            this.y1TextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y1";
            // 
            // x1TextBox
            // 
            this.x1TextBox.Location = new System.Drawing.Point(44, 14);
            this.x1TextBox.Name = "x1TextBox";
            this.x1TextBox.Size = new System.Drawing.Size(82, 22);
            this.x1TextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "X1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 291);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Distance Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox y2TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox x2TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox y1TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox x1TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label manhattanResultLabel;
        private System.Windows.Forms.Label maxResultLabel;
        private System.Windows.Forms.Label euclideanResultLabel;
    }
}



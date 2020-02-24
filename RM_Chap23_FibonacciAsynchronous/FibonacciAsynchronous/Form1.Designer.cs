namespace FibonacciAsynchronous
{
    partial class AsynchronousTestForm
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
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.inputLabel1 = new System.Windows.Forms.Label();
            this.inputTextBox1 = new System.Windows.Forms.TextBox();
            this.andFibonacci2Label = new System.Windows.Forms.Label();
            this.andFibonacci3Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputTextBox
            // 
            this.outputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTextBox.Location = new System.Drawing.Point(36, 259);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(611, 357);
            this.outputTextBox.TabIndex = 0;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(36, 194);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(344, 45);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start Asynchronous Fibonacci Calls";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // inputLabel1
            // 
            this.inputLabel1.AutoSize = true;
            this.inputLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLabel1.Location = new System.Drawing.Point(36, 64);
            this.inputLabel1.Name = "inputLabel1";
            this.inputLabel1.Size = new System.Drawing.Size(184, 18);
            this.inputLabel1.TabIndex = 2;
            this.inputLabel1.Text = "Enter first number: (1 -100)";
            // 
            // inputTextBox1
            // 
            this.inputTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextBox1.Location = new System.Drawing.Point(250, 60);
            this.inputTextBox1.Name = "inputTextBox1";
            this.inputTextBox1.Size = new System.Drawing.Size(107, 27);
            this.inputTextBox1.TabIndex = 3;
            // 
            // andFibonacci2Label
            // 
            this.andFibonacci2Label.AutoSize = true;
            this.andFibonacci2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.andFibonacci2Label.Location = new System.Drawing.Point(36, 107);
            this.andFibonacci2Label.Name = "andFibonacci2Label";
            this.andFibonacci2Label.Size = new System.Drawing.Size(121, 18);
            this.andFibonacci2Label.TabIndex = 4;
            this.andFibonacci2Label.Text = "Fibonacci (X+1): ";
            // 
            // andFibonacci3Label
            // 
            this.andFibonacci3Label.AutoSize = true;
            this.andFibonacci3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.andFibonacci3Label.Location = new System.Drawing.Point(36, 148);
            this.andFibonacci3Label.Name = "andFibonacci3Label";
            this.andFibonacci3Label.Size = new System.Drawing.Size(117, 18);
            this.andFibonacci3Label.TabIndex = 5;
            this.andFibonacci3Label.Text = "Fibonacci (X+2):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(590, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Calculation of three Fibonacci numbers: Fibonacci(x), Fibonacci(x+1) and Fibonacc" +
    "i(x+2)";
            // 
            // AsynchronousTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 685);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.andFibonacci3Label);
            this.Controls.Add(this.andFibonacci2Label);
            this.Controls.Add(this.inputTextBox1);
            this.Controls.Add(this.inputLabel1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.outputTextBox);
            this.Name = "AsynchronousTestForm";
            this.Text = "Asynchronous Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label inputLabel1;
        private System.Windows.Forms.TextBox inputTextBox1;
        private System.Windows.Forms.Label andFibonacci2Label;
        private System.Windows.Forms.Label andFibonacci3Label;
        private System.Windows.Forms.Label label1;
    }
}


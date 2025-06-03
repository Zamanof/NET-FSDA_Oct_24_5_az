namespace NET_10._EventArgs_Winform
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
            addButton = new Button();
            subtractButton = new Button();
            multipleButton = new Button();
            divideButton = new Button();
            firstValueTextBox = new TextBox();
            secondValueTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Location = new Point(29, 121);
            addButton.Name = "addButton";
            addButton.Size = new Size(125, 42);
            addButton.TabIndex = 0;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            // 
            // subtractButton
            // 
            subtractButton.Location = new Point(160, 121);
            subtractButton.Name = "subtractButton";
            subtractButton.Size = new Size(125, 42);
            subtractButton.TabIndex = 0;
            subtractButton.Text = "Subtract";
            subtractButton.UseVisualStyleBackColor = true;
            // 
            // multipleButton
            // 
            multipleButton.Location = new Point(291, 121);
            multipleButton.Name = "multipleButton";
            multipleButton.Size = new Size(125, 42);
            multipleButton.TabIndex = 0;
            multipleButton.Text = "Multiple";
            multipleButton.UseVisualStyleBackColor = true;
            // 
            // divideButton
            // 
            divideButton.Location = new Point(422, 121);
            divideButton.Name = "divideButton";
            divideButton.Size = new Size(125, 42);
            divideButton.TabIndex = 0;
            divideButton.Text = "Divide";
            divideButton.UseVisualStyleBackColor = true;
            // 
            // firstValueTextBox
            // 
            firstValueTextBox.Location = new Point(141, 39);
            firstValueTextBox.Name = "firstValueTextBox";
            firstValueTextBox.Size = new Size(100, 23);
            firstValueTextBox.TabIndex = 1;
            // 
            // secondValueTextBox
            // 
            secondValueTextBox.Location = new Point(310, 39);
            secondValueTextBox.Name = "secondValueTextBox";
            secondValueTextBox.Size = new Size(100, 23);
            secondValueTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 21);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "First value";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(328, 21);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 2;
            label2.Text = "Second value";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(184, 76);
            label3.Name = "label3";
            label3.Size = new Size(98, 32);
            label3.TabIndex = 3;
            label3.Text = "Result: ";
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            resultLabel.Location = new Point(291, 76);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(28, 32);
            resultLabel.TabIndex = 3;
            resultLabel.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 211);
            Controls.Add(resultLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(secondValueTextBox);
            Controls.Add(firstValueTextBox);
            Controls.Add(divideButton);
            Controls.Add(multipleButton);
            Controls.Add(subtractButton);
            Controls.Add(addButton);
            MaximizeBox = false;
            MaximumSize = new Size(591, 250);
            MinimizeBox = false;
            MinimumSize = new Size(591, 250);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addButton;
        private Button subtractButton;
        private Button multipleButton;
        private Button divideButton;
        private TextBox firstValueTextBox;
        private TextBox secondValueTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label resultLabel;
    }
}

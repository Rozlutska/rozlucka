namespace ooap4laba
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.hourlyRadioButton = new System.Windows.Forms.RadioButton();
            this.pieceworkRadioButton = new System.Windows.Forms.RadioButton();
            this.cslculateButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.rateTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(182, 70);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 0;
            // 
            // positionTextBox
            // 
            this.positionTextBox.Location = new System.Drawing.Point(182, 122);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(100, 22);
            this.positionTextBox.TabIndex = 1;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(182, 221);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 22);
            this.quantityTextBox.TabIndex = 2;
            // 
            // hourlyRadioButton
            // 
            this.hourlyRadioButton.AutoSize = true;
            this.hourlyRadioButton.Location = new System.Drawing.Point(409, 102);
            this.hourlyRadioButton.Name = "hourlyRadioButton";
            this.hourlyRadioButton.Size = new System.Drawing.Size(150, 20);
            this.hourlyRadioButton.TabIndex = 3;
            this.hourlyRadioButton.TabStop = true;
            this.hourlyRadioButton.Text = "Погодинна оплата";
            this.hourlyRadioButton.UseVisualStyleBackColor = true;
            // 
            // pieceworkRadioButton
            // 
            this.pieceworkRadioButton.AutoSize = true;
            this.pieceworkRadioButton.Location = new System.Drawing.Point(409, 152);
            this.pieceworkRadioButton.Name = "pieceworkRadioButton";
            this.pieceworkRadioButton.Size = new System.Drawing.Size(137, 20);
            this.pieceworkRadioButton.TabIndex = 4;
            this.pieceworkRadioButton.TabStop = true;
            this.pieceworkRadioButton.Text = "Відрядна оплата";
            this.pieceworkRadioButton.UseVisualStyleBackColor = true;
            // 
            // cslculateButton
            // 
            this.cslculateButton.Location = new System.Drawing.Point(274, 249);
            this.cslculateButton.Name = "cslculateButton";
            this.cslculateButton.Size = new System.Drawing.Size(196, 23);
            this.cslculateButton.TabIndex = 5;
            this.cslculateButton.Text = "Розрахувати зарплату";
            this.cslculateButton.UseVisualStyleBackColor = true;
            this.cslculateButton.Click += new System.EventHandler(this.cslculateButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(329, 343);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(44, 16);
            this.resultLabel.TabIndex = 6;
            this.resultLabel.Text = "label1";
            // 
            // rateTextBox
            // 
            this.rateTextBox.Location = new System.Drawing.Point(182, 172);
            this.rateTextBox.Name = "rateTextBox";
            this.rateTextBox.Size = new System.Drawing.Size(100, 22);
            this.rateTextBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rateTextBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.cslculateButton);
            this.Controls.Add(this.pieceworkRadioButton);
            this.Controls.Add(this.hourlyRadioButton);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.RadioButton hourlyRadioButton;
        private System.Windows.Forms.RadioButton pieceworkRadioButton;
        private System.Windows.Forms.Button cslculateButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox rateTextBox;
    }
}


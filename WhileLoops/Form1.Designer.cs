
namespace WhileLoops
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.startingLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.startInputbox = new System.Windows.Forms.TextBox();
            this.endingInputbox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(214, 51);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(355, 52);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Fun With Loops!";
            // 
            // startingLabel
            // 
            this.startingLabel.AutoSize = true;
            this.startingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startingLabel.Location = new System.Drawing.Point(218, 176);
            this.startingLabel.Name = "startingLabel";
            this.startingLabel.Size = new System.Drawing.Size(302, 29);
            this.startingLabel.TabIndex = 2;
            this.startingLabel.Text = "Enter A Starting Number:";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endLabel.Location = new System.Drawing.Point(218, 223);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(306, 29);
            this.endLabel.TabIndex = 3;
            this.endLabel.Text = "Enter an Ending Number:";
            // 
            // startInputbox
            // 
            this.startInputbox.Location = new System.Drawing.Point(561, 178);
            this.startInputbox.Name = "startInputbox";
            this.startInputbox.Size = new System.Drawing.Size(100, 26);
            this.startInputbox.TabIndex = 4;
            // 
            // endingInputbox
            // 
            this.endingInputbox.Location = new System.Drawing.Point(561, 227);
            this.endingInputbox.Name = "endingInputbox";
            this.endingInputbox.Size = new System.Drawing.Size(100, 26);
            this.endingInputbox.TabIndex = 5;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(539, 272);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(122, 34);
            this.convertButton.TabIndex = 6;
            this.convertButton.Text = "Show Values";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.Red;
            this.outputLabel.Location = new System.Drawing.Point(119, 346);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(349, 55);
            this.outputLabel.TabIndex = 7;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(704, 400);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 38);
            this.resetButton.TabIndex = 8;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.endingInputbox);
            this.Controls.Add(this.startInputbox);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.startingLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label startingLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.TextBox startInputbox;
        private System.Windows.Forms.TextBox endingInputbox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button resetButton;
    }
}


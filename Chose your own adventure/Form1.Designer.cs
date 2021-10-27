
namespace Chose_your_own_adventure
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
            this.outputLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.optionOneLabel = new System.Windows.Forms.Label();
            this.optionTwoLabel = new System.Windows.Forms.Label();
            this.optionThreeLabel = new System.Windows.Forms.Label();
            this.optionOneButton = new System.Windows.Forms.Button();
            this.optionTwoButton = new System.Windows.Forms.Button();
            this.optionTheeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.outputLabel.Location = new System.Drawing.Point(27, 23);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(321, 59);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(30, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 240);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // optionOneLabel
            // 
            this.optionOneLabel.AutoSize = true;
            this.optionOneLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.optionOneLabel.Location = new System.Drawing.Point(79, 350);
            this.optionOneLabel.Name = "optionOneLabel";
            this.optionOneLabel.Size = new System.Drawing.Size(35, 13);
            this.optionOneLabel.TabIndex = 2;
            this.optionOneLabel.Text = "label1";
            // 
            // optionTwoLabel
            // 
            this.optionTwoLabel.AutoSize = true;
            this.optionTwoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.optionTwoLabel.Location = new System.Drawing.Point(79, 399);
            this.optionTwoLabel.Name = "optionTwoLabel";
            this.optionTwoLabel.Size = new System.Drawing.Size(35, 13);
            this.optionTwoLabel.TabIndex = 5;
            this.optionTwoLabel.Text = "label2";
            // 
            // optionThreeLabel
            // 
            this.optionThreeLabel.AutoSize = true;
            this.optionThreeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.optionThreeLabel.Location = new System.Drawing.Point(79, 448);
            this.optionThreeLabel.Name = "optionThreeLabel";
            this.optionThreeLabel.Size = new System.Drawing.Size(35, 13);
            this.optionThreeLabel.TabIndex = 7;
            this.optionThreeLabel.Text = "label3";
            // 
            // optionOneButton
            // 
            this.optionOneButton.Location = new System.Drawing.Point(32, 340);
            this.optionOneButton.Name = "optionOneButton";
            this.optionOneButton.Size = new System.Drawing.Size(31, 33);
            this.optionOneButton.TabIndex = 8;
            this.optionOneButton.UseVisualStyleBackColor = true;
            this.optionOneButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // optionTwoButton
            // 
            this.optionTwoButton.Location = new System.Drawing.Point(31, 389);
            this.optionTwoButton.Name = "optionTwoButton";
            this.optionTwoButton.Size = new System.Drawing.Size(31, 33);
            this.optionTwoButton.TabIndex = 9;
            this.optionTwoButton.UseVisualStyleBackColor = true;
            this.optionTwoButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // optionTheeButton
            // 
            this.optionTheeButton.Location = new System.Drawing.Point(31, 438);
            this.optionTheeButton.Name = "optionTheeButton";
            this.optionTheeButton.Size = new System.Drawing.Size(31, 33);
            this.optionTheeButton.TabIndex = 10;
            this.optionTheeButton.UseVisualStyleBackColor = true;
            this.optionTheeButton.Click += new System.EventHandler(this.optionTheeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(383, 436);
            this.Controls.Add(this.optionTheeButton);
            this.Controls.Add(this.optionTwoButton);
            this.Controls.Add(this.optionOneButton);
            this.Controls.Add(this.optionThreeLabel);
            this.Controls.Add(this.optionTwoLabel);
            this.Controls.Add(this.optionOneLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.outputLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label optionOneLabel;
        private System.Windows.Forms.Label optionTwoLabel;
        private System.Windows.Forms.Label optionThreeLabel;
        private System.Windows.Forms.Button optionOneButton;
        private System.Windows.Forms.Button optionTwoButton;
        private System.Windows.Forms.Button optionTheeButton;
    }
}



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
            this.optionButtonOne = new System.Windows.Forms.PictureBox();
            this.optionButtonTwo = new System.Windows.Forms.PictureBox();
            this.optionTwoLabel = new System.Windows.Forms.Label();
            this.optionThreeLabel = new System.Windows.Forms.Label();
            this.optionThreeButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionButtonOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionButtonTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionThreeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.outputLabel.Location = new System.Drawing.Point(28, 42);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(35, 13);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(31, 74);
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
            // optionButtonOne
            // 
            this.optionButtonOne.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.optionButtonOne.Location = new System.Drawing.Point(33, 341);
            this.optionButtonOne.Name = "optionButtonOne";
            this.optionButtonOne.Size = new System.Drawing.Size(30, 32);
            this.optionButtonOne.TabIndex = 3;
            this.optionButtonOne.TabStop = false;
            this.optionButtonOne.Click += new System.EventHandler(this.optionButtonOne_Click);
            // 
            // optionButtonTwo
            // 
            this.optionButtonTwo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.optionButtonTwo.Location = new System.Drawing.Point(33, 389);
            this.optionButtonTwo.Name = "optionButtonTwo";
            this.optionButtonTwo.Size = new System.Drawing.Size(30, 32);
            this.optionButtonTwo.TabIndex = 4;
            this.optionButtonTwo.TabStop = false;
            this.optionButtonTwo.Click += new System.EventHandler(this.optionButtonTwo_Click);
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
            // optionThreeButton
            // 
            this.optionThreeButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.optionThreeButton.Location = new System.Drawing.Point(33, 438);
            this.optionThreeButton.Name = "optionThreeButton";
            this.optionThreeButton.Size = new System.Drawing.Size(30, 32);
            this.optionThreeButton.TabIndex = 6;
            this.optionThreeButton.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(383, 498);
            this.Controls.Add(this.optionThreeLabel);
            this.Controls.Add(this.optionThreeButton);
            this.Controls.Add(this.optionTwoLabel);
            this.Controls.Add(this.optionButtonTwo);
            this.Controls.Add(this.optionButtonOne);
            this.Controls.Add(this.optionOneLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.outputLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionButtonOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionButtonTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionThreeButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label optionOneLabel;
        private System.Windows.Forms.PictureBox optionButtonOne;
        private System.Windows.Forms.PictureBox optionButtonTwo;
        private System.Windows.Forms.Label optionTwoLabel;
        private System.Windows.Forms.Label optionThreeLabel;
        private System.Windows.Forms.PictureBox optionThreeButton;
    }
}


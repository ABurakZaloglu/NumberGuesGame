
namespace NumberGuess
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
            this.btnGameStarter = new System.Windows.Forms.Button();
            this.txtGues = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lstGuesedNumbers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGameStarter
            // 
            this.btnGameStarter.Location = new System.Drawing.Point(666, 330);
            this.btnGameStarter.Name = "btnGameStarter";
            this.btnGameStarter.Size = new System.Drawing.Size(133, 50);
            this.btnGameStarter.TabIndex = 0;
            this.btnGameStarter.Text = "New Game";
            this.btnGameStarter.UseVisualStyleBackColor = true;
            this.btnGameStarter.Click += new System.EventHandler(this.btnGameStarter_Click);
            // 
            // txtGues
            // 
            this.txtGues.Location = new System.Drawing.Point(325, 121);
            this.txtGues.Name = "txtGues";
            this.txtGues.Size = new System.Drawing.Size(199, 20);
            this.txtGues.TabIndex = 1;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(361, 147);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(128, 24);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check Gues";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lstGuesedNumbers
            // 
            this.lstGuesedNumbers.FormattingEnabled = true;
            this.lstGuesedNumbers.Location = new System.Drawing.Point(13, 64);
            this.lstGuesedNumbers.Name = "lstGuesedNumbers";
            this.lstGuesedNumbers.Size = new System.Drawing.Size(184, 316);
            this.lstGuesedNumbers.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstGuesedNumbers);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtGues);
            this.Controls.Add(this.btnGameStarter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGameStarter;
        private System.Windows.Forms.TextBox txtGues;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.ListBox lstGuesedNumbers;
    }
}



namespace task2
{
    partial class WF_Guess_Num
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WF_Guess_Num));
            this.userGuessNum = new System.Windows.Forms.TextBox();
            this.gameAnswer = new System.Windows.Forms.Label();
            this.guessEnter = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userGuessNum
            // 
            this.userGuessNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.userGuessNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userGuessNum.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userGuessNum.ForeColor = System.Drawing.Color.Black;
            this.userGuessNum.Location = new System.Drawing.Point(126, 75);
            this.userGuessNum.MaxLength = 3;
            this.userGuessNum.Name = "userGuessNum";
            this.userGuessNum.Size = new System.Drawing.Size(121, 33);
            this.userGuessNum.TabIndex = 0;
            this.userGuessNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userGuessNum.TextChanged += new System.EventHandler(this.userGuessNum_TextChanged);
            // 
            // gameAnswer
            // 
            this.gameAnswer.AutoSize = true;
            this.gameAnswer.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameAnswer.Location = new System.Drawing.Point(47, 198);
            this.gameAnswer.Name = "gameAnswer";
            this.gameAnswer.Size = new System.Drawing.Size(0, 22);
            this.gameAnswer.TabIndex = 1;
            this.gameAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guessEnter
            // 
            this.guessEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guessEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guessEnter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.guessEnter.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessEnter.Location = new System.Drawing.Point(144, 114);
            this.guessEnter.Name = "guessEnter";
            this.guessEnter.Size = new System.Drawing.Size(85, 54);
            this.guessEnter.TabIndex = 2;
            this.guessEnter.Text = "Угадать!";
            this.guessEnter.UseVisualStyleBackColor = false;
            this.guessEnter.Click += new System.EventHandler(this.guessEnter_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Black;
            this.exitButton.Location = new System.Drawing.Point(265, 289);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(77, 31);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Сдаться";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // WF_Guess_Num
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(364, 341);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.guessEnter);
            this.Controls.Add(this.gameAnswer);
            this.Controls.Add(this.userGuessNum);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(380, 380);
            this.MinimumSize = new System.Drawing.Size(380, 380);
            this.Name = "WF_Guess_Num";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Угадай число!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userGuessNum;
        private System.Windows.Forms.Label gameAnswer;
        private System.Windows.Forms.Button guessEnter;
        private System.Windows.Forms.Button exitButton;
    }
}


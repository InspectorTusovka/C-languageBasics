
namespace lesson_7
{
    partial class WF_Game_Double
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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WF_Game_Double));
            this.exitButton = new System.Windows.Forms.Button();
            this.numLabelGame = new System.Windows.Forms.Label();
            this.plusButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.revertButton = new System.Windows.Forms.Button();
            this.commandCounter = new System.Windows.Forms.Label();
            this.gameNumber = new System.Windows.Forms.Label();
            this.commandCounterInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.Info;
            this.exitButton.Location = new System.Drawing.Point(182, 350);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(85, 35);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Сдаться";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // numLabelGame
            // 
            this.numLabelGame.AutoSize = true;
            this.numLabelGame.Font = new System.Drawing.Font("Baskerville Old Face", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLabelGame.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.numLabelGame.Location = new System.Drawing.Point(68, 207);
            this.numLabelGame.Name = "numLabelGame";
            this.numLabelGame.Size = new System.Drawing.Size(28, 31);
            this.numLabelGame.TabIndex = 7;
            this.numLabelGame.Text = "1";
            // 
            // plusButton
            // 
            this.plusButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.plusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusButton.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold);
            this.plusButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.plusButton.Location = new System.Drawing.Point(306, 173);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(95, 95);
            this.plusButton.TabIndex = 5;
            this.plusButton.Text = "+1";
            this.plusButton.UseVisualStyleBackColor = false;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.multiplyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.multiplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiplyButton.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiplyButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.multiplyButton.Location = new System.Drawing.Point(306, 56);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(95, 95);
            this.multiplyButton.TabIndex = 4;
            this.multiplyButton.Text = "x2";
            this.multiplyButton.UseVisualStyleBackColor = false;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // revertButton
            // 
            this.revertButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.revertButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.revertButton.Enabled = false;
            this.revertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.revertButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.revertButton.Location = new System.Drawing.Point(306, 286);
            this.revertButton.Name = "revertButton";
            this.revertButton.Size = new System.Drawing.Size(95, 55);
            this.revertButton.TabIndex = 8;
            this.revertButton.Text = "Отмена хода";
            this.revertButton.UseVisualStyleBackColor = false;
            this.revertButton.Click += new System.EventHandler(this.revertButton_Click);
            // 
            // commandCounter
            // 
            this.commandCounter.AutoSize = true;
            this.commandCounter.Font = new System.Drawing.Font("Baskerville Old Face", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandCounter.Location = new System.Drawing.Point(160, 315);
            this.commandCounter.Name = "commandCounter";
            this.commandCounter.Size = new System.Drawing.Size(24, 27);
            this.commandCounter.TabIndex = 9;
            this.commandCounter.Text = "0";
            // 
            // gameNumber
            // 
            this.gameNumber.AutoSize = true;
            this.gameNumber.Font = new System.Drawing.Font("Baskerville Old Face", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameNumber.ForeColor = System.Drawing.SystemColors.Desktop;
            this.gameNumber.Location = new System.Drawing.Point(68, 90);
            this.gameNumber.Name = "gameNumber";
            this.gameNumber.Size = new System.Drawing.Size(0, 31);
            this.gameNumber.TabIndex = 10;
            // 
            // commandCounterInfo
            // 
            this.commandCounterInfo.AutoSize = true;
            this.commandCounterInfo.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandCounterInfo.Location = new System.Drawing.Point(12, 319);
            this.commandCounterInfo.Name = "commandCounterInfo";
            this.commandCounterInfo.Size = new System.Drawing.Size(142, 22);
            this.commandCounterInfo.TabIndex = 11;
            this.commandCounterInfo.Text = "Совершено ходов:";
            // 
            // WF_Game_Double
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.ControlBox = false;
            this.Controls.Add(this.commandCounterInfo);
            this.Controls.Add(this.gameNumber);
            this.Controls.Add(this.commandCounter);
            this.Controls.Add(this.revertButton);
            this.Controls.Add(this.numLabelGame);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.exitButton);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(450, 450);
            this.MinimumSize = new System.Drawing.Size(450, 450);
            this.Name = "WF_Game_Double";
            this.Text = "В игре";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label numLabelGame;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button revertButton;
        private System.Windows.Forms.Label commandCounter;
        private System.Windows.Forms.Label gameNumber;
        private System.Windows.Forms.Label commandCounterInfo;
    }
}

namespace lesson_7
{
    partial class WF_Double
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WF_Double));
            this.multiplyButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.numLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // multiplyButton
            // 
            this.multiplyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.multiplyButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.multiplyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.multiplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiplyButton.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiplyButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.multiplyButton.Location = new System.Drawing.Point(16, 40);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(95, 95);
            this.multiplyButton.TabIndex = 0;
            this.multiplyButton.Text = "x2";
            this.multiplyButton.UseVisualStyleBackColor = false;
            this.multiplyButton.Click += new System.EventHandler(this.Multiply_buttonClick);
            // 
            // plusButton
            // 
            this.plusButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.plusButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.plusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusButton.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold);
            this.plusButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.plusButton.Location = new System.Drawing.Point(16, 157);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(95, 95);
            this.plusButton.TabIndex = 1;
            this.plusButton.Text = "+1";
            this.plusButton.UseVisualStyleBackColor = false;
            this.plusButton.Click += new System.EventHandler(this.Plus_buttonClick);
            // 
            // playButton
            // 
            this.playButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.playButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.playButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playButton.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.playButton.Location = new System.Drawing.Point(134, 262);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(71, 27);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "Играть!";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.Play_buttonClick);
            // 
            // numLabel
            // 
            this.numLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numLabel.AutoSize = true;
            this.numLabel.Font = new System.Drawing.Font("Baskerville Old Face", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numLabel.Location = new System.Drawing.Point(42, 141);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(25, 27);
            this.numLabel.TabIndex = 3;
            this.numLabel.Text = "1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.multiplyButton);
            this.panel1.Controls.Add(this.plusButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(211, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 311);
            this.panel1.TabIndex = 4;
            // 
            // WF_Double
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.numLabel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(450, 450);
            this.MinimumSize = new System.Drawing.Size(350, 350);
            this.Name = "WF_Double";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удвоитель";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label numLabel;
        private System.Windows.Forms.Panel panel1;
    }
}


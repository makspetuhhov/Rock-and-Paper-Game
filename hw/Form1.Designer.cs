namespace hw
{
    partial class Game
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.OutputLabel = new System.Windows.Forms.Label();
            this.RockButton = new System.Windows.Forms.Button();
            this.PaperButton = new System.Windows.Forms.Button();
            this.ScissonsButton = new System.Windows.Forms.Button();
            this.PlayAgainButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OutputLabel
            // 
            this.OutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OutputLabel.Location = new System.Drawing.Point(13, 13);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(237, 60);
            this.OutputLabel.TabIndex = 0;
            // 
            // RockButton
            // 
            this.RockButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RockButton.Location = new System.Drawing.Point(12, 88);
            this.RockButton.Name = "RockButton";
            this.RockButton.Size = new System.Drawing.Size(75, 23);
            this.RockButton.TabIndex = 1;
            this.RockButton.Text = "Rock";
            this.RockButton.UseVisualStyleBackColor = true;
            this.RockButton.Click += new System.EventHandler(this.RockButton_Click);
            // 
            // PaperButton
            // 
            this.PaperButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PaperButton.Location = new System.Drawing.Point(94, 88);
            this.PaperButton.Name = "PaperButton";
            this.PaperButton.Size = new System.Drawing.Size(75, 23);
            this.PaperButton.TabIndex = 2;
            this.PaperButton.Text = "Paper";
            this.PaperButton.UseVisualStyleBackColor = true;
            this.PaperButton.Click += new System.EventHandler(this.PaperButton_Click);
            // 
            // ScissonsButton
            // 
            this.ScissonsButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ScissonsButton.Location = new System.Drawing.Point(175, 88);
            this.ScissonsButton.Name = "ScissonsButton";
            this.ScissonsButton.Size = new System.Drawing.Size(75, 23);
            this.ScissonsButton.TabIndex = 3;
            this.ScissonsButton.Text = "Scissors";
            this.ScissonsButton.UseVisualStyleBackColor = true;
            this.ScissonsButton.Click += new System.EventHandler(this.ScrissonsButton_Click);
            // 
            // PlayAgainButton
            // 
            this.PlayAgainButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PlayAgainButton.Location = new System.Drawing.Point(94, 117);
            this.PlayAgainButton.Name = "PlayAgainButton";
            this.PlayAgainButton.Size = new System.Drawing.Size(75, 23);
            this.PlayAgainButton.TabIndex = 4;
            this.PlayAgainButton.Text = "Play Again";
            this.PlayAgainButton.UseVisualStyleBackColor = true;
            this.PlayAgainButton.Click += new System.EventHandler(this.PlayAgainButton_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 154);
            this.Controls.Add(this.PlayAgainButton);
            this.Controls.Add(this.ScissonsButton);
            this.Controls.Add(this.PaperButton);
            this.Controls.Add(this.RockButton);
            this.Controls.Add(this.OutputLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Button RockButton;
        private System.Windows.Forms.Button PaperButton;
        private System.Windows.Forms.Button ScissonsButton;
        private System.Windows.Forms.Button PlayAgainButton;
    }
}


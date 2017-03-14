namespace FormsSnake
{
    partial class FormHighscores
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
            this.lbHighscores = new System.Windows.Forms.ListBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbHighscores
            // 
            this.lbHighscores.FormattingEnabled = true;
            this.lbHighscores.Location = new System.Drawing.Point(13, 13);
            this.lbHighscores.Name = "lbHighscores";
            this.lbHighscores.Size = new System.Drawing.Size(429, 355);
            this.lbHighscores.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(13, 377);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(429, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Zurücksetzen";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FormHighscores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 412);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lbHighscores);
            this.Name = "FormHighscores";
            this.Text = "Highscores";
            this.Load += new System.EventHandler(this.FormHighscores_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbHighscores;
        private System.Windows.Forms.Button btnReset;
    }
}
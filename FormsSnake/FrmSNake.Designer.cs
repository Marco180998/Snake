namespace FormsSnake
{
    partial class FrmSnake
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlSnake = new System.Windows.Forms.Panel();
            this.SnakeTimer = new System.Windows.Forms.Timer(this.components);
            this.BtnPlayer1 = new System.Windows.Forms.Button();
            this.btnPlayer2 = new System.Windows.Forms.Button();
            this.SpeedTb = new System.Windows.Forms.TrackBar();
            this.btnTimer = new System.Windows.Forms.Button();
            this.btnHighscore = new System.Windows.Forms.Button();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblScore1 = new System.Windows.Forms.Label();
            this.DifficultyCb = new System.Windows.Forms.ComboBox();
            this.lblSchwierigkeit = new System.Windows.Forms.Label();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.tbPlayer = new System.Windows.Forms.TextBox();
            this.btnPause = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSnake.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTb)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSnake
            // 
            this.pnlSnake.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSnake.Controls.Add(this.label1);
            this.pnlSnake.Location = new System.Drawing.Point(12, 79);
            this.pnlSnake.Name = "pnlSnake";
            this.pnlSnake.Size = new System.Drawing.Size(731, 404);
            this.pnlSnake.TabIndex = 0;
            this.pnlSnake.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form_PreviewKeyDown);
            // 
            // SnakeTimer
            // 
            this.SnakeTimer.Interval = 500;
            this.SnakeTimer.Tick += new System.EventHandler(this.SnakeTimer_Tick);
            // 
            // BtnPlayer1
            // 
            this.BtnPlayer1.Location = new System.Drawing.Point(12, 12);
            this.BtnPlayer1.Name = "BtnPlayer1";
            this.BtnPlayer1.Size = new System.Drawing.Size(75, 23);
            this.BtnPlayer1.TabIndex = 0;
            this.BtnPlayer1.Text = "Spieler 1";
            this.BtnPlayer1.UseVisualStyleBackColor = true;
            this.BtnPlayer1.Click += new System.EventHandler(this.ButtonSpieler1_Clicked);
            this.BtnPlayer1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form_PreviewKeyDown);
            // 
            // btnPlayer2
            // 
            this.btnPlayer2.Location = new System.Drawing.Point(93, 12);
            this.btnPlayer2.Name = "btnPlayer2";
            this.btnPlayer2.Size = new System.Drawing.Size(75, 23);
            this.btnPlayer2.TabIndex = 3;
            this.btnPlayer2.Text = "Spieler 2";
            this.btnPlayer2.UseVisualStyleBackColor = true;
            this.btnPlayer2.Click += new System.EventHandler(this.btnPlayer2_Click);
            this.btnPlayer2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form_PreviewKeyDown);
            // 
            // SpeedTb
            // 
            this.SpeedTb.LargeChange = 50;
            this.SpeedTb.Location = new System.Drawing.Point(266, 28);
            this.SpeedTb.Maximum = 200;
            this.SpeedTb.Minimum = 15;
            this.SpeedTb.Name = "SpeedTb";
            this.SpeedTb.Size = new System.Drawing.Size(104, 45);
            this.SpeedTb.TabIndex = 3;
            this.SpeedTb.TickFrequency = 50;
            this.SpeedTb.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.SpeedTb.Value = 50;
            this.SpeedTb.Scroll += new System.EventHandler(this.SpeedTb_Scroll);
            this.SpeedTb.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form_PreviewKeyDown);
            // 
            // btnTimer
            // 
            this.btnTimer.Location = new System.Drawing.Point(175, 12);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(85, 23);
            this.btnTimer.TabIndex = 5;
            this.btnTimer.Text = "Start / Stop";
            this.btnTimer.UseVisualStyleBackColor = true;
            this.btnTimer.Click += new System.EventHandler(this.ButtonTimer_Clicked);
            this.btnTimer.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form_PreviewKeyDown);
            // 
            // btnHighscore
            // 
            this.btnHighscore.Location = new System.Drawing.Point(12, 41);
            this.btnHighscore.Name = "btnHighscore";
            this.btnHighscore.Size = new System.Drawing.Size(75, 23);
            this.btnHighscore.TabIndex = 6;
            this.btnHighscore.Text = "Highscores";
            this.btnHighscore.UseVisualStyleBackColor = true;
            this.btnHighscore.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form_PreviewKeyDown);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.ForeColor = System.Drawing.Color.White;
            this.lblSpeed.Location = new System.Drawing.Point(275, 12);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(85, 13);
            this.lblSpeed.TabIndex = 7;
            this.lblSpeed.Text = "Geschwindigkeit";
            // 
            // lblScore1
            // 
            this.lblScore1.AutoSize = true;
            this.lblScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore1.ForeColor = System.Drawing.Color.White;
            this.lblScore1.Location = new System.Drawing.Point(590, 11);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(152, 24);
            this.lblScore1.TabIndex = 8;
            this.lblScore1.Text = "Player 1 Score: 0";
            this.lblScore1.Click += new System.EventHandler(this.lblScore1_Click);
            // 
            // DifficultyCb
            // 
            this.DifficultyCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DifficultyCb.FormattingEnabled = true;
            this.DifficultyCb.Items.AddRange(new object[] {
            "Leicht",
            "Solala",
            "Schwer"});
            this.DifficultyCb.Location = new System.Drawing.Point(376, 28);
            this.DifficultyCb.Name = "DifficultyCb";
            this.DifficultyCb.Size = new System.Drawing.Size(102, 21);
            this.DifficultyCb.TabIndex = 9;
            this.DifficultyCb.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form_PreviewKeyDown);
            // 
            // lblSchwierigkeit
            // 
            this.lblSchwierigkeit.AutoSize = true;
            this.lblSchwierigkeit.ForeColor = System.Drawing.Color.White;
            this.lblSchwierigkeit.Location = new System.Drawing.Point(395, 12);
            this.lblSchwierigkeit.Name = "lblSchwierigkeit";
            this.lblSchwierigkeit.Size = new System.Drawing.Size(70, 13);
            this.lblSchwierigkeit.TabIndex = 10;
            this.lblSchwierigkeit.Text = "Schwierigkeit";
            // 
            // lblScore2
            // 
            this.lblScore2.AutoSize = true;
            this.lblScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore2.ForeColor = System.Drawing.Color.White;
            this.lblScore2.Location = new System.Drawing.Point(591, 35);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(152, 24);
            this.lblScore2.TabIndex = 11;
            this.lblScore2.Text = "Player 2 Score: 0";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.ForeColor = System.Drawing.Color.White;
            this.lblPlayer.Location = new System.Drawing.Point(510, 12);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(39, 13);
            this.lblPlayer.TabIndex = 12;
            this.lblPlayer.Text = "Spieler";
            // 
            // tbPlayer
            // 
            this.tbPlayer.Location = new System.Drawing.Point(484, 29);
            this.tbPlayer.Name = "tbPlayer";
            this.tbPlayer.Size = new System.Drawing.Size(100, 20);
            this.tbPlayer.TabIndex = 13;
            this.tbPlayer.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form_PreviewKeyDown);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(175, 41);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(85, 23);
            this.btnPause.TabIndex = 14;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            this.btnPause.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form_PreviewKeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(363, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "dank memes";
            // 
            // FrmSnake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(755, 495);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.tbPlayer);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblScore2);
            this.Controls.Add(this.lblSchwierigkeit);
            this.Controls.Add(this.DifficultyCb);
            this.Controls.Add(this.lblScore1);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.btnHighscore);
            this.Controls.Add(this.btnTimer);
            this.Controls.Add(this.SpeedTb);
            this.Controls.Add(this.BtnPlayer1);
            this.Controls.Add(this.btnPlayer2);
            this.Controls.Add(this.pnlSnake);
            this.Name = "FrmSnake";
            this.Text = "Snake";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSnake_FormClosing);
            this.Load += new System.EventHandler(this.FrmSnake_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form_PreviewKeyDown);
            this.pnlSnake.ResumeLayout(false);
            this.pnlSnake.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSnake;
        private System.Windows.Forms.Timer SnakeTimer;
        private System.Windows.Forms.Button BtnPlayer1;
        private System.Windows.Forms.Button btnPlayer2;
        private System.Windows.Forms.TrackBar SpeedTb;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.Button btnHighscore;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblScore1;
        private System.Windows.Forms.ComboBox DifficultyCb;
        private System.Windows.Forms.Label lblSchwierigkeit;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.TextBox tbPlayer;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label label1;
    }
}


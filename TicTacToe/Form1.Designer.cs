namespace TicTacToe
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
            tableLayoutPanel1 = new TableLayoutPanel();
            b9 = new Button();
            b8 = new Button();
            b7 = new Button();
            b6 = new Button();
            b5 = new Button();
            b4 = new Button();
            b2 = new Button();
            b1 = new Button();
            b3 = new Button();
            btnRestart = new Button();
            txtPlayer1 = new TextBox();
            txtPlayer2 = new TextBox();
            btnStart = new Button();
            lblScore = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Olive;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(b9, 2, 2);
            tableLayoutPanel1.Controls.Add(b8, 1, 2);
            tableLayoutPanel1.Controls.Add(b7, 0, 2);
            tableLayoutPanel1.Controls.Add(b6, 2, 1);
            tableLayoutPanel1.Controls.Add(b5, 1, 1);
            tableLayoutPanel1.Controls.Add(b4, 0, 1);
            tableLayoutPanel1.Controls.Add(b2, 1, 0);
            tableLayoutPanel1.Controls.Add(b1, 0, 0);
            tableLayoutPanel1.Controls.Add(b3, 2, 0);
            tableLayoutPanel1.Location = new Point(50, 150);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(440, 445);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // b9
            // 
            b9.BackColor = Color.LavenderBlush;
            b9.Dock = DockStyle.Fill;
            b9.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 162);
            b9.Location = new Point(295, 299);
            b9.Name = "b9";
            b9.Size = new Size(142, 143);
            b9.TabIndex = 8;
            b9.UseVisualStyleBackColor = false;
            b9.Click += btn_click;
            // 
            // b8
            // 
            b8.BackColor = Color.LavenderBlush;
            b8.Dock = DockStyle.Fill;
            b8.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            b8.Location = new Point(149, 299);
            b8.Name = "b8";
            b8.Size = new Size(140, 143);
            b8.TabIndex = 7;
            b8.UseVisualStyleBackColor = false;
            b8.Click += btn_click;
            // 
            // b7
            // 
            b7.BackColor = Color.LavenderBlush;
            b7.Dock = DockStyle.Fill;
            b7.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            b7.Location = new Point(3, 299);
            b7.Name = "b7";
            b7.Size = new Size(140, 143);
            b7.TabIndex = 6;
            b7.UseVisualStyleBackColor = false;
            b7.Click += btn_click;
            // 
            // b6
            // 
            b6.BackColor = Color.LavenderBlush;
            b6.Dock = DockStyle.Fill;
            b6.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            b6.Location = new Point(295, 151);
            b6.Name = "b6";
            b6.Size = new Size(142, 142);
            b6.TabIndex = 5;
            b6.UseVisualStyleBackColor = false;
            b6.Click += btn_click;
            // 
            // b5
            // 
            b5.BackColor = Color.LavenderBlush;
            b5.Dock = DockStyle.Fill;
            b5.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            b5.Location = new Point(149, 151);
            b5.Name = "b5";
            b5.Size = new Size(140, 142);
            b5.TabIndex = 4;
            b5.UseVisualStyleBackColor = false;
            b5.Click += btn_click;
            // 
            // b4
            // 
            b4.BackColor = Color.LavenderBlush;
            b4.Dock = DockStyle.Fill;
            b4.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            b4.Location = new Point(3, 151);
            b4.Name = "b4";
            b4.Size = new Size(140, 142);
            b4.TabIndex = 3;
            b4.UseVisualStyleBackColor = false;
            b4.Click += btn_click;
            // 
            // b2
            // 
            b2.BackColor = Color.LavenderBlush;
            b2.Dock = DockStyle.Fill;
            b2.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            b2.Location = new Point(149, 3);
            b2.Name = "b2";
            b2.Size = new Size(140, 142);
            b2.TabIndex = 1;
            b2.UseVisualStyleBackColor = false;
            b2.Click += btn_click;
            // 
            // b1
            // 
            b1.BackColor = Color.LavenderBlush;
            b1.Dock = DockStyle.Fill;
            b1.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            b1.Location = new Point(3, 3);
            b1.Name = "b1";
            b1.Size = new Size(140, 142);
            b1.TabIndex = 0;
            b1.UseVisualStyleBackColor = false;
            b1.Click += btn_click;
            // 
            // b3
            // 
            b3.BackColor = Color.LavenderBlush;
            b3.Dock = DockStyle.Fill;
            b3.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            b3.Location = new Point(295, 3);
            b3.Name = "b3";
            b3.Size = new Size(142, 142);
            b3.TabIndex = 2;
            b3.UseVisualStyleBackColor = false;
            b3.Click += btn_click;
            // 
            // btnRestart
            // 
            btnRestart.BackColor = Color.Olive;
            btnRestart.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnRestart.ForeColor = Color.White;
            btnRestart.Location = new Point(199, 612);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(140, 40);
            btnRestart.TabIndex = 1;
            btnRestart.Text = "RESTART\r\n";
            btnRestart.UseVisualStyleBackColor = false;
            btnRestart.Click += btnRestart_Click;
            // 
            // txtPlayer1
            // 
            txtPlayer1.Font = new Font("Segoe UI", 12F);
            txtPlayer1.Location = new Point(50, 30);
            txtPlayer1.Name = "txtPlayer1";
            txtPlayer1.PlaceholderText = "Player 1";
            txtPlayer1.Size = new Size(200, 29);
            txtPlayer1.TabIndex = 2;
            // 
            // txtPlayer2
            // 
            txtPlayer2.Font = new Font("Segoe UI", 12F);
            txtPlayer2.Location = new Point(256, 30);
            txtPlayer2.Name = "txtPlayer2";
            txtPlayer2.PlaceholderText = "Player 2";
            txtPlayer2.Size = new Size(200, 29);
            txtPlayer2.TabIndex = 3;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.Olive;
            btnStart.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(199, 612);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(140, 40);
            btnStart.TabIndex = 4;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblScore.ForeColor = Color.DarkRed;
            lblScore.Location = new Point(50, 62);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(70, 30);
            lblScore.TabIndex = 5;
            lblScore.Text = "Skor:  ";
            lblScore.Visible = false;
            lblScore.Click += lblScore_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(600, 750);
            Controls.Add(lblScore);
            Controls.Add(btnStart);
            Controls.Add(txtPlayer2);
            Controls.Add(txtPlayer1);
            Controls.Add(btnRestart);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Tic Tac Toe - Skorlu Versiyon";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button b9;
        private Button b8;
        private Button b7;
        private Button b6;
        private Button b5;
        private Button b4;
        private Button b3;
        private Button b2;
        private Button b1;
        private Button btnRestart;
        private TextBox txtPlayer1;
        private TextBox txtPlayer2;
        private Button btnStart;
        private Label lblScore;
    }
}
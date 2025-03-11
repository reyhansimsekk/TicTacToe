namespace TicTacToe
{
    public partial class Form1 : Form
    {
        int nr = 0;
        int scoreX = 0, scoreO = 0; 
        string playerX = "", playerO = ""; 

        public Form1()
        {
            InitializeComponent();
            btnRestart.Visible = false;
            lblScore.Visible = false; 
        }

        // start button
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPlayer1.Text) || string.IsNullOrEmpty(txtPlayer2.Text))
            {
                MessageBox.Show("Please enter your names!");
                return;
            }

            playerX = txtPlayer1.Text;
            playerO = txtPlayer2.Text;
            lblScore.Text = $"{playerX}: {scoreX} - {playerO}: {scoreO}";

            // Hide name part
            txtPlayer1.Visible = txtPlayer2.Visible = btnStart.Visible = false;
            lblScore.Visible = true;
        }

        private void btn_click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(playerX) || string.IsNullOrEmpty(playerO))
            {
                MessageBox.Show("Please enter your names!");
                return;
            }

            nr++;
            Button b = (Button)sender;
            b.Text = (nr % 2 != 0) ? "X" : "O";
            b.Enabled = false;

            // row,column, diagonal check
            if ((b1.Text == b2.Text && b2.Text == b3.Text && !b1.Enabled) ||
                (b4.Text == b5.Text && b5.Text == b6.Text && !b4.Enabled) ||
                (b7.Text == b8.Text && b8.Text == b9.Text && !b7.Enabled) ||
                (b1.Text == b4.Text && b4.Text == b7.Text && !b1.Enabled) ||
                (b2.Text == b5.Text && b5.Text == b8.Text && !b2.Enabled) ||
                (b3.Text == b6.Text && b6.Text == b9.Text && !b3.Enabled) ||
                (b1.Text == b5.Text && b5.Text == b9.Text && !b1.Enabled) ||
                (b3.Text == b5.Text && b5.Text == b7.Text && !b3.Enabled))
            {
                string winner = (nr % 2 != 0) ? playerX : playerO;
                MessageBox.Show($"{winner} is winner!");

                // updating score
                if (nr % 2 != 0) scoreX++;
                else scoreO++;
                lblScore.Text = $"{playerX}: {scoreX} - {playerO}: {scoreO}";

                DisableAllButtons();
                btnRestart.Visible = true;
            }
            else if (nr == 9)
            {
                MessageBox.Show("It is a draw!");
                DisableAllButtons();
                btnRestart.Visible = true;
            }
        }

        // lock all buttons
        private void DisableAllButtons()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is Button btn) btn.Enabled = false;
            }
        }

        // restart
        private void RestartGame()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is Button btn)
                {
                    btn.Text = "";
                    btn.Enabled = true;
                }
            }
            nr = 0;
            btnRestart.Visible = false;
            txtPlayer1.Visible = txtPlayer2.Visible = btnStart.Visible = true;
            lblScore.Visible = false;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }
    }
}
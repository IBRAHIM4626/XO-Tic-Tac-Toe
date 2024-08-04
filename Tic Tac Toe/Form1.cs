namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        bool turn = true; //true = x, false = o;
        int turn_count = 0;
        int addOneToScore = 0;
        Button[,] arr;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            arr = new Button[,] { {btn1, btn2, btn3 },
                                  {btn4, btn5, btn6 },
                                  {btn7, btn8, btn9 } };
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;


            if (turn)
            {
                btn.Text = "X";
            }
            else
            {
                btn.Text = "O";
            }
            turn = !turn;
            btn.Enabled = false;

            turn_count++;
            checkWinner();
        }

        //check winner
        private void checkWinner()
        {
            bool is_winner = false;

            //all checks
            if ((btn1.Text == btn2.Text && btn2.Text == btn3.Text && btn2.Text != "") ||
               (btn4.Text == btn5.Text && btn5.Text == btn6.Text && btn5.Text != "") ||
               (btn7.Text == btn8.Text && btn8.Text == btn9.Text && btn8.Text != "") ||
               (btn1.Text == btn4.Text && btn4.Text == btn7.Text && btn4.Text != "") ||
               (btn2.Text == btn5.Text && btn5.Text == btn8.Text && btn5.Text != "") ||
               (btn3.Text == btn6.Text && btn6.Text == btn9.Text && btn6.Text != "") ||
               (btn1.Text == btn5.Text && btn5.Text == btn9.Text && btn5.Text != "") ||
               (btn3.Text == btn5.Text && btn5.Text == btn7.Text && btn5.Text != "")
                )
            {
                is_winner = true;
            }

            if (is_winner)
            {
                disable_Buttons();
                string winner = "";

                if (turn)
                {
                    winner = "O";
                    addOneToScore = Convert.ToInt32(lbl_playerO.Text);
                    lbl_playerO.Text = Convert.ToString(addOneToScore + 1);
                }
                else
                {
                    winner = "X";
                    addOneToScore = Convert.ToInt32(lbl_playerX.Text);
                    lbl_playerX.Text = Convert.ToString(addOneToScore + 1);
                }
                MessageBox.Show(winner + " is Winner!");
            }
            else
            {
                if (turn_count == 9)
                {
                    MessageBox.Show("Draw!");
                }
            }
        }

        private void btn_newGame_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;

            //try
            //{
            //    foreach (Control c in Controls)
            //    {
            //        Button b = (Button)c;
            //        b.Enabled = true;
            //        b.Text = "";
            //    }
            //}
            //catch { }
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";

            lbl_playerX.Text = "0";
            lbl_playerO.Text = "0";
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            //turn = true;
            turn_count = 0;

            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
        }
        void disable_Buttons()
        {
            //try
            //{
            //    foreach (Control c in Controls)
            //    {
            //        Button b = (Button)c;
            //        b.Enabled = false;
            //    }
            //}
            //catch { }
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
        }

    }
}

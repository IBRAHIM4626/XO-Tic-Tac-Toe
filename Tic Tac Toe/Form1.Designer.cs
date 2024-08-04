namespace Tic_Tac_Toe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_newGame = new Button();
            btn_reset = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            label1 = new Label();
            lbl_playerX = new Label();
            label2 = new Label();
            lbl_playerO = new Label();
            btn_exit = new Button();
            SuspendLayout();
            // 
            // btn_newGame
            // 
            btn_newGame.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_newGame.Location = new Point(601, 144);
            btn_newGame.Name = "btn_newGame";
            btn_newGame.Size = new Size(154, 44);
            btn_newGame.TabIndex = 0;
            btn_newGame.Text = "New Game";
            btn_newGame.UseVisualStyleBackColor = true;
            btn_newGame.Click += btn_newGame_Click;
            // 
            // btn_reset
            // 
            btn_reset.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_reset.Location = new Point(601, 204);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(154, 44);
            btn_reset.TabIndex = 1;
            btn_reset.Text = "Reset";
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold);
            btn1.Location = new Point(115, 144);
            btn1.Name = "btn1";
            btn1.Size = new Size(70, 70);
            btn1.TabIndex = 2;
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn_click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold);
            btn2.Location = new Point(191, 144);
            btn2.Name = "btn2";
            btn2.Size = new Size(70, 70);
            btn2.TabIndex = 3;
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn_click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold);
            btn3.Location = new Point(267, 144);
            btn3.Name = "btn3";
            btn3.Size = new Size(70, 70);
            btn3.TabIndex = 3;
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn_click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold);
            btn4.Location = new Point(115, 215);
            btn4.Name = "btn4";
            btn4.Size = new Size(70, 70);
            btn4.TabIndex = 2;
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn_click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold);
            btn5.Location = new Point(191, 215);
            btn5.Name = "btn5";
            btn5.Size = new Size(70, 70);
            btn5.TabIndex = 3;
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn_click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold);
            btn6.Location = new Point(267, 215);
            btn6.Name = "btn6";
            btn6.Size = new Size(70, 70);
            btn6.TabIndex = 3;
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn_click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold);
            btn7.Location = new Point(115, 291);
            btn7.Name = "btn7";
            btn7.Size = new Size(70, 70);
            btn7.TabIndex = 2;
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn_click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold);
            btn8.Location = new Point(191, 291);
            btn8.Name = "btn8";
            btn8.Size = new Size(70, 70);
            btn8.TabIndex = 3;
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn_click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold);
            btn9.Location = new Point(267, 291);
            btn9.Name = "btn9";
            btn9.Size = new Size(70, 70);
            btn9.TabIndex = 3;
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn_click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 21);
            label1.Name = "label1";
            label1.Size = new Size(173, 54);
            label1.TabIndex = 4;
            label1.Text = "Player X:";
            // 
            // lbl_playerX
            // 
            lbl_playerX.BackColor = Color.White;
            lbl_playerX.BorderStyle = BorderStyle.Fixed3D;
            lbl_playerX.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_playerX.Location = new Point(195, 21);
            lbl_playerX.Name = "lbl_playerX";
            lbl_playerX.Size = new Size(45, 54);
            lbl_playerX.TabIndex = 5;
            lbl_playerX.Text = "0";
            lbl_playerX.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(414, 21);
            label2.Name = "label2";
            label2.Size = new Size(179, 54);
            label2.TabIndex = 4;
            label2.Text = "Player O:";
            // 
            // lbl_playerO
            // 
            lbl_playerO.BackColor = Color.White;
            lbl_playerO.BorderStyle = BorderStyle.Fixed3D;
            lbl_playerO.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_playerO.Location = new Point(593, 21);
            lbl_playerO.Name = "lbl_playerO";
            lbl_playerO.Size = new Size(45, 54);
            lbl_playerO.TabIndex = 5;
            lbl_playerO.Text = "0";
            lbl_playerO.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_exit
            // 
            btn_exit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_exit.Location = new Point(601, 394);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(154, 44);
            btn_exit.TabIndex = 1;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_playerO);
            Controls.Add(lbl_playerX);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn9);
            Controls.Add(btn6);
            Controls.Add(btn3);
            Controls.Add(btn8);
            Controls.Add(btn5);
            Controls.Add(btn2);
            Controls.Add(btn7);
            Controls.Add(btn4);
            Controls.Add(btn1);
            Controls.Add(btn_exit);
            Controls.Add(btn_reset);
            Controls.Add(btn_newGame);
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            Text = "Tic Tac Toe";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_newGame;
        private Button btn_reset;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Label label1;
        private Label lbl_playerX;
        private Label label2;
        private Label lbl_playerO;
        private Button btn_exit;
    }
}

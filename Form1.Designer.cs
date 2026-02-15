namespace MyTic_Tac_ToeGameProject
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
            this.lblTurn = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.lblwinner = new System.Windows.Forms.Label();
            this.btnRestartGame = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblinprogress = new System.Windows.Forms.Label();
            this.lblGamelogo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTurn.Font = new System.Drawing.Font("Georgia", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.White;
            this.lblTurn.Location = new System.Drawing.Point(101, 264);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(211, 39);
            this.lblTurn.TabIndex = 0;
            this.lblTurn.Text = "Game Over";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(602, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 116);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
       
            // 
            // button3
            // 
            this.button3.Image = global::MyTic_Tac_ToeGameProject.Properties.Resources.question_mark_96;
            this.button3.Location = new System.Drawing.Point(1216, 232);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 116);
            this.button3.TabIndex = 3;
            this.button3.Tag = "?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.Image = global::MyTic_Tac_ToeGameProject.Properties.Resources.question_mark_96;
            this.button4.Location = new System.Drawing.Point(599, 428);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 114);
            this.button4.TabIndex = 4;
            this.button4.Tag = "?";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.Image = global::MyTic_Tac_ToeGameProject.Properties.Resources.question_mark_96;
            this.button5.Location = new System.Drawing.Point(907, 428);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 114);
            this.button5.TabIndex = 5;
            this.button5.Tag = "?";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.Image = global::MyTic_Tac_ToeGameProject.Properties.Resources.question_mark_96;
            this.button6.Location = new System.Drawing.Point(1216, 428);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(154, 114);
            this.button6.TabIndex = 6;
            this.button6.Tag = "?";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.Image = global::MyTic_Tac_ToeGameProject.Properties.Resources.question_mark_96;
            this.button7.Location = new System.Drawing.Point(599, 605);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(145, 111);
            this.button7.TabIndex = 7;
            this.button7.Tag = "?";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.Image = global::MyTic_Tac_ToeGameProject.Properties.Resources.question_mark_96;
            this.button8.Location = new System.Drawing.Point(907, 605);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(150, 111);
            this.button8.TabIndex = 8;
            this.button8.Tag = "?";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button9
            // 
            this.button9.Image = global::MyTic_Tac_ToeGameProject.Properties.Resources.question_mark_96;
            this.button9.Location = new System.Drawing.Point(1216, 605);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(154, 111);
            this.button9.TabIndex = 9;
            this.button9.Tag = "?";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // lblwinner
            // 
            this.lblwinner.AutoSize = true;
            this.lblwinner.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblwinner.Font = new System.Drawing.Font("Georgia", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwinner.ForeColor = System.Drawing.Color.Yellow;
            this.lblwinner.Location = new System.Drawing.Point(90, 361);
            this.lblwinner.Name = "lblwinner";
            this.lblwinner.Size = new System.Drawing.Size(150, 39);
            this.lblwinner.TabIndex = 10;
            this.lblwinner.Text = "Winner";
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.AutoEllipsis = true;
            this.btnRestartGame.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRestartGame.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestartGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRestartGame.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRestartGame.Location = new System.Drawing.Point(23, 536);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(334, 58);
            this.btnRestartGame.TabIndex = 11;
            this.btnRestartGame.Text = "Restart Game";
            this.btnRestartGame.UseVisualStyleBackColor = false;
            this.btnRestartGame.Click += new System.EventHandler(this.btnRestartGame_Click);
            // 
            // button10
            // 
            this.button10.Image = global::MyTic_Tac_ToeGameProject.Properties.Resources.question_mark_96;
            this.button10.Location = new System.Drawing.Point(602, 232);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(142, 116);
            this.button10.TabIndex = 1;
            this.button10.Tag = "?";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.Image = global::MyTic_Tac_ToeGameProject.Properties.Resources.question_mark_96;
            this.button2.Location = new System.Drawing.Point(907, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 116);
            this.button2.TabIndex = 2;
            this.button2.Tag = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // lblinprogress
            // 
            this.lblinprogress.AutoSize = true;
            this.lblinprogress.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblinprogress.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinprogress.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblinprogress.Location = new System.Drawing.Point(76, 428);
            this.lblinprogress.Name = "lblinprogress";
            this.lblinprogress.Size = new System.Drawing.Size(230, 38);
            this.lblinprogress.TabIndex = 12;
            this.lblinprogress.Text = "In Progresss";
            // 
            // lblGamelogo
            // 
            this.lblGamelogo.AutoSize = true;
            this.lblGamelogo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGamelogo.Font = new System.Drawing.Font("Mongolian Baiti", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGamelogo.ForeColor = System.Drawing.Color.White;
            this.lblGamelogo.Location = new System.Drawing.Point(730, 50);
            this.lblGamelogo.Name = "lblGamelogo";
            this.lblGamelogo.Size = new System.Drawing.Size(481, 63);
            this.lblGamelogo.TabIndex = 13;
            this.lblGamelogo.Text = "Tic-Tac-Toe Game";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(111, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 43);
            this.label1.TabIndex = 14;
            this.label1.Text = "Turn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1754, 759);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGamelogo);
            this.Controls.Add(this.lblinprogress);
            this.Controls.Add(this.btnRestartGame);
            this.Controls.Add(this.lblwinner);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTurn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label lblwinner;
        private System.Windows.Forms.Button btnRestartGame;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblinprogress;
        private System.Windows.Forms.Label lblGamelogo;
        private System.Windows.Forms.Label label1;
    }
}


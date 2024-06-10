
namespace X_O
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlayerTurn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb0 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb8 = new System.Windows.Forms.PictureBox();
            this.pb7 = new System.Windows.Forms.PictureBox();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.lblComputerScore = new System.Windows.Forms.Label();
            this.btnCheatingMode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(1, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(318, 45);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Tic-Tac-Toe Game";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(41, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 45);
            this.label1.TabIndex = 11;
            this.label1.Text = "Turn";
            // 
            // lblPlayerTurn
            // 
            this.lblPlayerTurn.AutoSize = true;
            this.lblPlayerTurn.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTurn.ForeColor = System.Drawing.Color.White;
            this.lblPlayerTurn.Location = new System.Drawing.Point(26, 105);
            this.lblPlayerTurn.Name = "lblPlayerTurn";
            this.lblPlayerTurn.Size = new System.Drawing.Size(149, 45);
            this.lblPlayerTurn.TabIndex = 12;
            this.lblPlayerTurn.Tag = "X";
            this.lblPlayerTurn.Text = "Player 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(26, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 45);
            this.label3.TabIndex = 13;
            this.label3.Text = "Winner";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.Lime;
            this.lblWinner.Location = new System.Drawing.Point(9, 195);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(206, 45);
            this.lblWinner.TabIndex = 14;
            this.lblWinner.Text = "In Progress";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(29, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 53);
            this.button1.TabIndex = 15;
            this.button1.Text = "Restart Game";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pb2
            // 
            this.pb2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb2.Image = global::X_O.Properties.Resources.question_mark_96;
            this.pb2.Location = new System.Drawing.Point(572, 60);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(70, 70);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb2.TabIndex = 1;
            this.pb2.TabStop = false;
            this.pb2.Tag = "?";
            // 
            // pb1
            // 
            this.pb1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb1.Image = global::X_O.Properties.Resources.question_mark_96;
            this.pb1.Location = new System.Drawing.Point(477, 60);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(70, 70);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 2;
            this.pb1.TabStop = false;
            this.pb1.Tag = "?";
            // 
            // pb0
            // 
            this.pb0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb0.Image = global::X_O.Properties.Resources.question_mark_96;
            this.pb0.Location = new System.Drawing.Point(385, 60);
            this.pb0.Name = "pb0";
            this.pb0.Size = new System.Drawing.Size(70, 70);
            this.pb0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb0.TabIndex = 3;
            this.pb0.TabStop = false;
            this.pb0.Tag = "?";
            // 
            // pb5
            // 
            this.pb5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb5.Image = global::X_O.Properties.Resources.question_mark_96;
            this.pb5.Location = new System.Drawing.Point(572, 156);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(70, 70);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb5.TabIndex = 4;
            this.pb5.TabStop = false;
            this.pb5.Tag = "?";
            // 
            // pb4
            // 
            this.pb4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb4.Image = global::X_O.Properties.Resources.question_mark_96;
            this.pb4.Location = new System.Drawing.Point(477, 156);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(70, 70);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb4.TabIndex = 5;
            this.pb4.TabStop = false;
            this.pb4.Tag = "?";
            // 
            // pb3
            // 
            this.pb3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb3.Image = global::X_O.Properties.Resources.question_mark_96;
            this.pb3.Location = new System.Drawing.Point(385, 156);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(70, 70);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb3.TabIndex = 6;
            this.pb3.TabStop = false;
            this.pb3.Tag = "?";
            // 
            // pb8
            // 
            this.pb8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb8.Image = global::X_O.Properties.Resources.question_mark_96;
            this.pb8.Location = new System.Drawing.Point(572, 255);
            this.pb8.Name = "pb8";
            this.pb8.Size = new System.Drawing.Size(70, 70);
            this.pb8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb8.TabIndex = 7;
            this.pb8.TabStop = false;
            this.pb8.Tag = "?";
            // 
            // pb7
            // 
            this.pb7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb7.Image = global::X_O.Properties.Resources.question_mark_96;
            this.pb7.Location = new System.Drawing.Point(477, 255);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(70, 70);
            this.pb7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb7.TabIndex = 8;
            this.pb7.TabStop = false;
            this.pb7.Tag = "?";
            // 
            // pb6
            // 
            this.pb6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb6.Image = global::X_O.Properties.Resources.question_mark_96;
            this.pb6.Location = new System.Drawing.Point(385, 255);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(70, 70);
            this.pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb6.TabIndex = 9;
            this.pb6.TabStop = false;
            this.pb6.Tag = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 45);
            this.label2.TabIndex = 16;
            this.label2.Text = "Computer  -";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(219, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 45);
            this.label4.TabIndex = 17;
            this.label4.Text = "Player 1";
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerScore.ForeColor = System.Drawing.Color.White;
            this.lblPlayerScore.Location = new System.Drawing.Point(272, 387);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(0, 45);
            this.lblPlayerScore.TabIndex = 18;
            // 
            // lblComputerScore
            // 
            this.lblComputerScore.AutoSize = true;
            this.lblComputerScore.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerScore.ForeColor = System.Drawing.Color.White;
            this.lblComputerScore.Location = new System.Drawing.Point(85, 387);
            this.lblComputerScore.Name = "lblComputerScore";
            this.lblComputerScore.Size = new System.Drawing.Size(0, 45);
            this.lblComputerScore.TabIndex = 19;
            // 
            // btnCheatingMode
            // 
            this.btnCheatingMode.BackColor = System.Drawing.Color.Red;
            this.btnCheatingMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheatingMode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheatingMode.ForeColor = System.Drawing.Color.White;
            this.btnCheatingMode.Location = new System.Drawing.Point(453, 379);
            this.btnCheatingMode.Name = "btnCheatingMode";
            this.btnCheatingMode.Size = new System.Drawing.Size(180, 53);
            this.btnCheatingMode.TabIndex = 20;
            this.btnCheatingMode.Tag = "off";
            this.btnCheatingMode.Text = "Cheating Mode Off";
            this.btnCheatingMode.UseVisualStyleBackColor = false;
            this.btnCheatingMode.Click += new System.EventHandler(this.btnCheatingMode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCheatingMode);
            this.Controls.Add(this.lblComputerScore);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPlayerTurn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pb6);
            this.Controls.Add(this.pb7);
            this.Controls.Add(this.pb8);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb0);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.pb2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "XO Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlayerTurn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb0;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb8;
        private System.Windows.Forms.PictureBox pb7;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Label lblComputerScore;
        private System.Windows.Forms.Button btnCheatingMode;
        private System.Windows.Forms.PictureBox pb2;
    }
}


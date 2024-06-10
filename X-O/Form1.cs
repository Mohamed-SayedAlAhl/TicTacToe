using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;




namespace X_O
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Image> images = new Dictionary<string, Image>();
        stGameStatus GameStatus;
        struct stGameStatus
        {
           public byte NumberOfMoves ;
            public byte ComputerWinnitngTimes;
            public byte PlayerWinnitngTimes;

        }
        public Form1()
        {
            InitializeComponent();
            GameStatus.NumberOfMoves = 0;

            GameStatus.ComputerWinnitngTimes=0;
            GameStatus.PlayerWinnitngTimes =0;
            pb0.Click += PictureBox_Click;
            pb1.Click += PictureBox_Click;
            pb2.Click += PictureBox_Click;
            pb3.Click += PictureBox_Click;
            pb4.Click += PictureBox_Click;
            pb5.Click += PictureBox_Click;
            pb6.Click += PictureBox_Click;
            pb7.Click += PictureBox_Click;
            pb8.Click += PictureBox_Click;


           
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            

            images["X"] = Properties.Resources.X;
            images["O"] = Properties.Resources.O;
            images["question"] = Properties.Resources.question_mark_96;
        }
       
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.White;

            Pen pen = new Pen(White);
            pen.Width = 10;


            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(pen, 466, 40, 466, 340);
            e.Graphics.DrawLine(pen, 556, 40, 556, 340);


            e.Graphics.DrawLine(pen, 360, 140, 660, 140);
            e.Graphics.DrawLine(pen, 360, 240, 660, 240);

            //DrawGrid(e.Graphics, this.ClientSize.Width, this.ClientSize.Height);


            return;

        }

        void DisableAllPictureBoxes()
        {
            pb0.Enabled = false;
            pb1.Enabled = false;
            pb2.Enabled = false;
            pb3.Enabled = false;
            pb4.Enabled = false;
            pb5.Enabled = false;
            pb6.Enabled = false;
            pb7.Enabled = false;
            pb8.Enabled = false;
        }
        void EnableAllPictureBoxes()
        {
            pb0.Enabled = true;
            pb1.Enabled = true;
            pb2.Enabled = true;
            pb3.Enabled = true;
            pb4.Enabled = true;
            pb5.Enabled = true;
            pb6.Enabled = true;
            pb7.Enabled = true;
            pb8.Enabled = true;
        }
        void HighlightWinner(PictureBox[] pictureBoxes)
        {
            pictureBoxes[0].BackColor = Color.YellowGreen;
            pictureBoxes[1].BackColor = Color.YellowGreen;
            pictureBoxes[2].BackColor = Color.YellowGreen;
        }

        void ShowGameOverMessage()
        {
            MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void ChangeScores()
        {
            if (lblWinner.Text == " Computer")
            {
                GameStatus.ComputerWinnitngTimes++;
                lblComputerScore.Text = GameStatus.ComputerWinnitngTimes.ToString();
            }
             else
            {
                GameStatus.PlayerWinnitngTimes++;
                lblPlayerScore.Text = GameStatus.PlayerWinnitngTimes.ToString();
            }
        }
        void PerformWinningSenario(PictureBox[] pictureBoxes)
        {
            HighlightWinner(pictureBoxes);
            DisableAllPictureBoxes();
            lblPlayerTurn.Text = "Game Over";
            lblWinner.Text = pictureBoxes[0].Tag.ToString() == "X" ? " Player 1" : " Computer";
            ChangeScores();
            ShowGameOverMessage();
        }
        bool IsSameMark(PictureBox[] pictureBoxes)
        {
            return (pictureBoxes[0].Tag == pictureBoxes[1].Tag && pictureBoxes[1].Tag == pictureBoxes[2].Tag);
        }
        bool CheckIfPictureBoxesNotEmpty(PictureBox[] pictureBoxes)
        {
           return pictureBoxes[0].Tag.ToString() != "?" && pictureBoxes[1].Tag.ToString() != "?" && pictureBoxes[2].Tag.ToString() != "?";
        }
        bool CheckWinner()
        {
   

            PictureBox[]Row1 ={ pb0, pb1, pb2 } ;
            PictureBox[]Row2 ={ pb3, pb4, pb5 } ;
            PictureBox[] Row3 = { pb6, pb7, pb8 };
            PictureBox[] Col1={ pb0, pb3, pb6 } ;
            PictureBox[] Col2= { pb1, pb4, pb7 } ;
            PictureBox[] Col3={ pb2, pb5, pb8 } ;
            PictureBox[] D1={ pb0, pb4, pb8 }   ;
            PictureBox[] D2 = { pb2, pb4, pb6 };


            PictureBox[][] WinConditions = new PictureBox[][]
            {
               Row1 ,Row2 ,Row3,Col1,Col2,Col3,D1, D2 
            };


            foreach(PictureBox[] Condition in WinConditions)
            {
                if (CheckIfPictureBoxesNotEmpty(Condition) && IsSameMark(Condition))
                {
                    PerformWinningSenario(Condition);
                    return true;
                }
            }

            if (CheckIfPictureBoxesNotEmpty(WinConditions[0]) && CheckIfPictureBoxesNotEmpty(WinConditions[1]) && CheckIfPictureBoxesNotEmpty(WinConditions[2]))
            {
               
                DisableAllPictureBoxes();
                lblPlayerTurn.Text = "Game Over";
                lblWinner.Text =  " Draw";
                ShowGameOverMessage();
                return true;
            }
            return false;

        }
        void ChangePhotoBasedOnPlayer(PictureBox P) 
        {
          string Player = lblPlayerTurn.Tag.ToString();

          P .Image = images[Player];

        }

        void PlayerMove<T>(object sender)where T:Control
        {
          
            if (((T)sender).Tag.ToString() == "?")
            {
                ChangePhotoBasedOnPlayer((PictureBox)sender);
                GameStatus.NumberOfMoves ++;
                //((PictureBox)sender).Enabled = false;
                ((PictureBox)sender).Tag = lblPlayerTurn.Tag.ToString() == "X" ? "X" : "O";
                lblPlayerTurn.Text= lblPlayerTurn.Tag.ToString() == "X" ? "Computer" : "Player 1";
                lblPlayerTurn.Tag = lblPlayerTurn.Tag.ToString() == "X" ? "O" : "X";

                CheckWinner();

            }
           
            else 

            {
                MessageBox.Show("Wrong Choice", "Wrong Choice", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }




        }
        bool ComputerMovement(PictureBox[] pictureBoxes,bool Attack=true)
        {
            string Symbol=" ";
            if (Attack)
                Symbol = "O";
            else
                Symbol = "X";

            if (pictureBoxes[0].Tag.ToString() == "?" && pictureBoxes[1].Tag.ToString() == "?" && pictureBoxes[2].Tag.ToString() == "?")
                return false;
            if (pictureBoxes[0].Tag.ToString() == Symbol && pictureBoxes[1].Tag.ToString() == Symbol)
            {
                if (GameStatus.NumberOfMoves<9 && pictureBoxes[2].Tag.ToString() == "?")
                {
                    PlayerMove<PictureBox>(pictureBoxes[2]);
                    return true;
                }
                   
            }
            if (pictureBoxes[1].Tag.ToString() == Symbol && pictureBoxes[2].Tag.ToString() == Symbol)
            {
                if (GameStatus.NumberOfMoves < 9 && pictureBoxes[0].Tag.ToString() == "?")
                {
                    PlayerMove<PictureBox>(pictureBoxes[0]);
                    return true;
                }
                   
            }
            if (pictureBoxes[0].Tag.ToString() == Symbol && pictureBoxes[2].Tag.ToString() == Symbol)
            {
                if (GameStatus.NumberOfMoves < 9 && pictureBoxes[1].Tag.ToString() == "?")
                {
                    PlayerMove<PictureBox>(pictureBoxes[1]);
                    return true;
                }
                   
            }

            return false;

        }
        void ComputerTurn()
        {
            DisableAllPictureBoxes();
            PictureBox[] pictureBoxes = { pb0, pb1, pb2, pb3, pb4, pb5, pb6, pb7, pb8 };

            Random Rnd = new Random();

            int RandomNumber=Rnd.Next(0, 8);

            byte NumberOfMovements = 1;
            byte Counter = 0;
            bool DefenseExist = false;

            PictureBox[] Row1 = { pb0, pb1, pb2 };
            PictureBox[] Row2 = { pb3, pb4, pb5 };
            PictureBox[] Row3 = { pb6, pb7, pb8 };
            PictureBox[] Col1 = { pb0, pb3, pb6 };
            PictureBox[] Col2 = { pb1, pb4, pb7 };
            PictureBox[] Col3 = { pb2, pb5, pb8 };
            PictureBox[] D1 = { pb0, pb4, pb8 };
            PictureBox[] D2 = { pb2, pb4, pb6 };

            PictureBox[][] WinConditions = new PictureBox[][]
            {
               Row1 ,Row2 ,Row3,Col1,Col2,Col3,D1, D2 
            };

            if (GameStatus.NumberOfMoves == 1)
            {
                while (pictureBoxes[RandomNumber].Tag.ToString() != "?")
                {
                    RandomNumber = Rnd.Next(0, 8);
                }

                if (GameStatus.NumberOfMoves < 9 && pictureBoxes[RandomNumber].Tag.ToString() == "?")
                {
                    PlayerMove<PictureBox>(pictureBoxes[RandomNumber]);
                   
                    return;
                }
                    
               
            }
            else 
            {
                foreach (var Condition in WinConditions)
                {
                    
                    if (ComputerMovement(Condition))
                    {
                        
                        return;
                    }
                       
                  
                }

               

                if (btnCheatingMode.Tag.ToString() == "on")
                {
                    NumberOfMovements =2;

                }


                do
                {
                    if (DefenseExist)
                    {
                        lblPlayerTurn.Text = "Computer";
                        lblPlayerTurn.Tag = "O";
                        DefenseExist = false;
                    }

                    foreach (var Condition in WinConditions)
                    {


                        if (ComputerMovement(Condition, false))
                        {
                            
                            Counter++;

                            if (Counter < NumberOfMovements)
                            {
                                DefenseExist = true;
                                break;
                            }
                               

                            if (Counter == NumberOfMovements)
                                return;
                            
                                
                        }


                    }

                    if (!DefenseExist&&Counter!=0)
                    {
                        lblPlayerTurn.Text = "Player 1";
                        lblPlayerTurn.Tag = "X";
                        return;
                    }
                        

                } while (DefenseExist);









            }


                foreach (var box in pictureBoxes)
                {
                    if (box.Tag.ToString() == "?" && GameStatus.NumberOfMoves < 9)
                    {
                        PlayerMove<PictureBox>(box);
                        
                        return;
                    }

                }
        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            

           
            PlayerMove<PictureBox>(sender);


            DateTime startTime = DateTime.Now;
            TimeSpan delay = TimeSpan.FromSeconds(1.5); //1.5 s delay

            while (DateTime.Now - startTime < delay)
            {
                Application.DoEvents(); // Allow the application to remain responsive
            }

            // When Game Ends all Picture Boxes are disables so if it is disabled computer won't play
            if (lblWinner.Text == "In Progress" && lblPlayerTurn.Tag.ToString()=="O")
            {
                ComputerTurn();
                if (lblWinner.Text == "In Progress")
                    EnableAllPictureBoxes();
               
            }
               
            else
                return;



        }
        private void button1_Click(object sender, EventArgs e)
        {
            PictureBox[] pictureBoxes = { pb0, pb1, pb2, pb3, pb4, pb5, pb6, pb7, pb8 };

            for (int i=0;i<= pictureBoxes.Length-1; i++)
            {
                pictureBoxes[i].BackColor = Color.Transparent;
                pictureBoxes[i].Image = images["question"];
                pictureBoxes[i].Tag= "?" ;
            }
            EnableAllPictureBoxes();
            lblPlayerTurn.Text = "Player 1";
            lblPlayerTurn.Tag = "X";
            lblWinner.Text = "In Progress";

           

            GameStatus.NumberOfMoves = 0;

        }


      

        private void btnCheatingMode_Click(object sender, EventArgs e)
        {
            if(btnCheatingMode.Tag.ToString()=="off")
            {
                btnCheatingMode.Tag = "on";
                btnCheatingMode.Text = "Cheating Mode On";
                btnCheatingMode.BackColor = Color.Green;
            }
            else
            {
                btnCheatingMode.Tag = "off";
                btnCheatingMode.Text = "Cheating Mode Off";
                btnCheatingMode.BackColor = Color.Red;
            }
        }

        

       
    }
}

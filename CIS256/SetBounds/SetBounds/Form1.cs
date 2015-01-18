using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Media;


namespace SetBounds
{
    public partial class frmHorseRace : Form
    {
        int intStart = 12;
        int intEnd = 835;
        int csharpWins, rubyWins, pythonWins;
        double csharp, ruby, python, bets, totBalance = 100;
       
        Random myRan = new Random();
       

        public frmHorseRace()


        {
            InitializeComponent();

            //To fix BG image flicker
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
           
           
        }


        private void button1_Click(object sender, EventArgs e)
        {
            txtBetamt.Enabled = false;
            this.csharpavatar.Image = global::SetBounds.Properties.Resources.csharp_animated_horse;
            this.rubyavatar.Image = global::SetBounds.Properties.Resources.ruby_animated_horse;
            this.pythonavatar.Image = global::SetBounds.Properties.Resources.python_animated_horse;
            pictureBox4.Visible = false;

            SoundPlayer player = new SoundPlayer(Properties.Resources.final_project_they_re_off);
            player.Play();

           

            while (intStart < intEnd)
            {
                var sw1 = Stopwatch.StartNew();
                               
                int myMove = myRan.Next(0, 20);
                intStart = intStart + myMove;
                Thread.Sleep(102);
                               
                csharpavatar.SetBounds(intStart, 0, 0, 0, BoundsSpecified.X);
                this.Refresh();
                if ((csharpavatar.Location.X >= intEnd)&&(csharpavatar.Location.X>rubyavatar.Location.X)&&(csharpavatar.Location.X > pythonavatar.Location.X))
                {
                    
                    this.csharpavatar.Image = global::SetBounds.Properties.Resources.csharp_wins;
                    this.rubyavatar.Image = global::SetBounds.Properties.Resources.ruby_lose;
                    this.pythonavatar.Image = global::SetBounds.Properties.Resources.pyton_lose;

                    SoundPlayer player1 = new SoundPlayer(Properties.Resources.final_project_chsarp);
                    player1.Play();

                    

                    csharpavatar.Location = new Point(855, 60);
                    rubyavatar.Location = new Point(855, 187);
                    pythonavatar.Location = new Point(855, 311);
                    
                    MessageBox.Show("See Sharpie Wins!", "The Winner");


                    csharpWins += 1;
                    lblSeesharpiewins.Text = csharpWins.ToString();
                    if (ckBets.Checked == true)
                    {
                       
                        csharpBet();
                    }
                   

               
                    break;}

                sw1.Stop();
                TimeSpan csharp = sw1.Elapsed;
                csharp = sw1.Elapsed;
                lblcsharptime.Text = csharp.TotalMilliseconds.ToString();

                var sw2 = Stopwatch.StartNew();
              
                int myMove2 = myRan.Next(0, 20);
                intStart = intStart + myMove2;
                Thread.Sleep(100);
                
               
                rubyavatar.SetBounds(intStart, 0, 0, 0, BoundsSpecified.X);
                this.Refresh();
                if ((rubyavatar.Location.X >= intEnd) && (rubyavatar.Location.X > csharpavatar.Location.X) && (rubyavatar.Location.X > pythonavatar.Location.X))
                {
                    
                    this.csharpavatar.Image = global::SetBounds.Properties.Resources.csharp_lose;
                    this.rubyavatar.Image = global::SetBounds.Properties.Resources.ruby_wins;
                    this.pythonavatar.Image = global::SetBounds.Properties.Resources.pyton_lose;

                    csharpavatar.Location = new Point(855, 60);
                    rubyavatar.Location = new Point(855, 187);
                    pythonavatar.Location = new Point(855, 311);

                    SoundPlayer player2 = new SoundPlayer(Properties.Resources.final_project_ruby);
                    player2.Play();

                   

                    MessageBox.Show("Ruby Baby Wins!", "The Winner");

                    


                    rubyWins += 1;
                    lblRubywins.Text = rubyWins.ToString();

                    if (ckBets.Checked == true)
                    {
                      
                        rubyBet();
                    }
                    

                  
                    break;}


                sw2.Stop();
                TimeSpan ruby = sw2.Elapsed;
                ruby = sw2.Elapsed;
                lblRubytime.Text = ruby.TotalMilliseconds.ToString(); 

                var sw3 = Stopwatch.StartNew();
               
                int myMove3 = myRan.Next(0, 20);
                intStart = intStart + myMove3;
                Thread.Sleep(100);
                pythonavatar.SetBounds(intStart, 0, 0, 0, BoundsSpecified.X);
                this.Refresh();

                if ((pythonavatar.Location.X >= intEnd) && (pythonavatar.Location.X > rubyavatar.Location.X) && (pythonavatar.Location.X > csharpavatar.Location.X))
                {
                  

                    this.pythonavatar.Image = global::SetBounds.Properties.Resources.python_wins;
                    this.rubyavatar.Image = global::SetBounds.Properties.Resources.ruby_lose;
                    this.csharpavatar.Image = global::SetBounds.Properties.Resources.csharp_lose;

                    csharpavatar.Location = new Point(855, 60);
                    rubyavatar.Location = new Point(855, 187);
                    pythonavatar.Location = new Point(855, 311);

                    SoundPlayer player3 = new SoundPlayer(Properties.Resources.final_project_python);
                    player3.Play();

                   
                     
                    MessageBox.Show("Python'll Bite Wins!", "The Winner");

                    

                    pythonWins += 1;
                    lblPythonwins.Text = pythonWins.ToString();

                    if (ckBets.Checked == true)
                    { 
                      
                        pythonBet();
                    }
                    
                   
                    break;}

                sw3.Stop();
                TimeSpan python = sw3.Elapsed;
                python = sw3.Elapsed;
                lblPythontime.Text = (python.TotalMilliseconds).ToString();
                           
            }
            
         
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            intEnd = this.Size.Width - 80;
            intStart = 12;
            csharpavatar.SetBounds(11, 42, 0, 0, BoundsSpecified.Location);

            intEnd = this.Size.Width - 80;
            intStart = 12;
            rubyavatar.SetBounds(11, 230, 0, 0, BoundsSpecified.Location);

            intEnd = this.Size.Width - 80;
            intStart = 12;
            pythonavatar.SetBounds(11, 505, 0, 0, BoundsSpecified.Location);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            this.pythonavatar.Image = global::SetBounds.Properties.Resources.python_start;
            this.csharpavatar.Image = global::SetBounds.Properties.Resources.csharp_start;
            this.rubyavatar.Image = global::SetBounds.Properties.Resources.ruby_start;

            txtBetamt.Focus();

           
            { groupBox1.Enabled = false; }

           
            
        }

        private void button2_Click(object sender, EventArgs e )
        {
           
            this.csharpavatar.Image = global::SetBounds.Properties.Resources.csharp_start;
            this.rubyavatar.Image = global::SetBounds.Properties.Resources.ruby_start;
            this.pythonavatar.Image = global::SetBounds.Properties.Resources.python_start;
            csharp = 0;
            ruby = 0;
            python = 0;
         
           
            intStart = 11;
            csharpavatar.SetBounds(intStart, 0, 0, 0, BoundsSpecified.X);
            rubyavatar.SetBounds(intStart, 0, 0, 0, BoundsSpecified.X);
            pythonavatar.SetBounds(intStart, 0, 0, 0, BoundsSpecified.X);
            lblcsharptime.Text = csharp.ToString();
            lblPythontime.Text = python.ToString();
            lblRubytime.Text = ruby.ToString();
            pictureBox4.Visible = true;

            txtBetamt.Clear();
            txtBetamt.Focus();
            txtBetamt.Enabled = true;
            ckBets.Checked = false;

           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (totBalance > 0)
            { MessageBox.Show("Are you sure you want to quit?  You still have " + totBalance.ToString("c") + " in your betting account"); }
            
            this.Close();
            
        }


        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a desktop application for CIS 256.  All code written by G. Lee");
        }

        

        private void txtBetamt_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.txtBetamt, "Bets may be up to $100 or your total balance");
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.csharpavatar, "See Sharpie - A staple of the .Net house");
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.rubyavatar, "Ruby Baby - She's fast and smooth");
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pythonavatar, "Python'll Bite - Lean and quick");
        }

        private void csharpBet()
        { 
            bets = double.Parse(txtBetamt.Text);
            
            
            if (radCsharp.Checked==true)
              
            {
              

                totBalance += bets;
                lblBalance.Text = totBalance.ToString("c");


            }

            else
            {
                totBalance -= bets;
                lblBalance.Text = totBalance.ToString("c");

            }

            if (totBalance <= 0)
            { MessageBox.Show("Sorry, you've gone bust"); }

        }

        private void rubyBet()
        {
            bets = double.Parse(txtBetamt.Text);
          

            if (radRuby.Checked == true)
             {
              

                totBalance += bets;
                lblBalance.Text = totBalance.ToString("c");


            }

            else
            {
                totBalance -= bets;
                lblBalance.Text = totBalance.ToString("c");

            }

            if (totBalance <= 0)
            { MessageBox.Show("Sorry, you've gone bust"); }
        }

        private void pythonBet()
        {
            bets = double.Parse(txtBetamt.Text);
           

            if (radPython.Checked == true)
            {


                totBalance += bets;
                lblBalance.Text = totBalance.ToString("c");


            }

            else
            {
                totBalance -= bets;
                lblBalance.Text = totBalance.ToString("c");

            }
            if(totBalance <=0 )
            {MessageBox.Show("Sorry, you've gone bust");}
        }


            
       

        private void radCsharp_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.radCsharp, "Pick See Sharpie to win!");
        }

         

        private void radRuby_MouseEnter_1(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.radRuby, "Pick Ruby Baby to win!");
        }

        private void radPython_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.radPython, "Pick Python'll Bite to win!");
        }

        private void ckBets_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBets.Checked == true)
            {
                groupBox1.Enabled = true;
                txtBetamt.Focus();

            }
            else
            {
                groupBox1.Enabled = false;
            }
        }

        

       
            
       

      
        
    }
}

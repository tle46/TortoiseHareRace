using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TortoiseHareProject
{
    public partial class Form1 : Form
    {
        //Contenders
        Turtle turtle1;
        Hare hare1;

        //Y location of hare and turtle
        int harey = 150;
        int turtley = 100;

        //Interval value of tick function. Represents reciprocal function when compared to speed.
        int speed = 40;

        //Total outcomes
        int turwins = 0;
        int harwins = 0;
        int ties = 0;

        //Outcomes for session
        int sbites = 0;
        int sturwins = 0;
        int sharwins = 0;
        int sties = 0;

        //Picture mode
        bool picturemode = false;

        public class Contender
        {
            protected int position;
            protected int totalsteps;
            protected Color cntColor;
            protected int moverange;
            protected int jumprange;
            protected int xmarg = 25;
            protected bool picturemode;

            //Default constructor
            public Contender()
            {
                position = 0;
                jumprange = 10; //Default is 10 for totalstep of 70
                moverange = 700; //Default is 700
                totalsteps = moverange/jumprange;
                cntColor = Color.Black;
            }

            //Constructor with arguments position, steps and color
            public Contender(int pos, int nosteps, Color col)
            {
                SetPosition(pos);
                totalsteps = nosteps/jumprange;
                cntColor = col;
            }

            //Checks if is winner
            public bool isWinner()
            {
                if(position >= totalsteps)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            //Set position to positive i
            public void SetPosition(int i)
            {
                if(i < 0)
                {
                    i = 0;
                }
                position = i;
            }

            //Set step
            public void SetStep(int step)
            {
                totalsteps = step;
            }

            //Set color
            public void SetColor(Color col)
            {
                cntColor = col;
            }

            //Get position
            public int GetPosition()
            {
                return position;
            }

            //Get step
            public int GetStep()
            {
                return totalsteps;
            }

            //Get color
            public Color GetColor()
            {
                return cntColor;
            }

            //Get X margin
            public int Getxmarg()
            {
                return xmarg;
            }

            //Get jump range
            public int Getjumprange()
            {
                return jumprange;
            }
        }

        public class Turtle : Contender
        {
            //Random number generator
            Random randomgen;

            //Instansiate random number generator
            public Turtle() : base()
            {
                randomgen = new Random();
            }

            //Instansiate random number generator
            public Turtle(int pos, int nosteps, Color col) : base(pos, nosteps, col)
            {
                randomgen = new Random();
            }

            //Update position
            public void updatePosition()
            {
                int index, moves;

                //Generate random number
                index = randomgen.Next(0, 100);

                //Declares moves based on generated number
                if(index < 50)
                {
                    moves = 3;
                }
                else if (index < 70)
                {
                    moves = -6;
                }
                else
                {
                    moves = 1;
                }

                //Moves the position
                SetPosition(position + moves);
            }

            //Draws
            public void draw(Graphics g, int yloc)
            {
                //Size of contender animation
                int size = 20;
                
                //Create drawing deviced
                SolidBrush myBrush = new SolidBrush(cntColor);
                Pen myPen = new Pen(Color.Black, 2);

                myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;

                //Draw track line
                g.DrawLine(myPen, xmarg, yloc + size/2, xmarg + moverange, yloc + size/2);

                //Draw turtle as circle
                g.FillEllipse(myBrush, position * jumprange + xmarg, yloc, size, size);
            }
        }

        public class Hare : Contender
        {
            //Random number generator
            Random randomgen;

            //Instantiate random number generator
            public Hare() : base()
            {
                 randomgen= new Random();
            }

            //Instantiate random number generator
            public Hare(int pos, int nosteps, Color col) : base(pos, nosteps, col)
            {
                randomgen = new Random();
            }

            //Update position
            public void updatePosition()
            {
                int index, moves;

                //Generate random number
                index = randomgen.Next(0, 100);

                //Sets number of moves based on generated number
                if (index < 20)
                {
                    moves = 0;
                }
                else if (index < 40)
                {
                    moves = 9;
                }
                else if (index < 50)
                {
                    moves = -12;
                }
                else if (index < 80)
                {
                    moves = 1;
                }
                else
                {
                    moves = -2;
                }

                //Moves position accordingly
                SetPosition(position + moves);
            }

            //Draw
            public void draw(Graphics g, int yloc)
            {
                //Size of square
                int size = 20;
                
                //Drawing
                SolidBrush myBrush = new SolidBrush(cntColor);
                Pen myPen = new Pen(Color.Black, 2);

                myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;

                //Draws track
                g.DrawLine(myPen, xmarg, yloc + size / 2, xmarg + moverange, yloc + size / 2);

                //Draws rectangular hare
                g.FillRectangle(myBrush, position * jumprange + xmarg, yloc, size, size);
            }
        }

        public Form1()
        {
            InitializeComponent();

            //Creates turtle and hare
            turtle1 = new Turtle();
            hare1 = new Hare();

            //Checks if the save file already exists, if not, creates save file
            if (!File.Exists("RaceResults.txt"))
            {
                SaveFile();
            }

            //Set picture mode
            picturemode = false;
            rbDraw.Checked = true;

            //Reads file
            ReadFile();

            //Updates scoreboards
            UpdateSScoreboard();
            UpdateScoreboard();

            /*
            //FOR TESTING PURPOSES DELETE ***********************************************************************************
            int i = 0;

            //Runs 1000000 races and updates results
            while (i <= 1000000)
            {
                hare1.updatePosition();

                turtle1.updatePosition();

                //pictureBox1.Invalidate();

                //pbBarGraph.Invalidate();

                if (hare1.GetPosition() == turtle1.GetPosition())
                {
                    sbites++;
                    //MessageBox.Show("Ouch");
                }

                if (hare1.isWinner() && turtle1.isWinner())
                {
                    Reset();
                    ties++;
                    sties++;
                    //MessageBox.Show("There is a tie");
                    i++;
                }
                else if (hare1.isWinner())
                {
                    Reset();
                    harwins++;
                    sharwins++;
                    //MessageBox.Show("Hare is the winner");
                    i++;
                }
                else if (turtle1.isWinner())
                {
                    Reset();
                    turwins++;
                    sturwins++;
                    //MessageBox.Show("Turtle is the winner");
                    i++;
                }

                //UpdateScoreboard();
                //SaveFile();
            }

            UpdateScoreboard();
            UpdateSScoreboard();
            //DELETE ABOVE *****************************************************************************************
            */
            pbBarGraph.Invalidate();
        }

        //On event picture box paint
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //Draws turtle and hare
            turtle1.draw(g, turtley);
            hare1.draw(g, harey);

            //Set picturemode according to variable value
            if (picturemode)
            {
                pbTurtle.Visible = true;
                pbHare.Visible = true;

                pbTurtle.Location = new Point(turtle1.GetPosition() * turtle1.Getjumprange() + turtle1.Getxmarg(), turtley + pictureBox1.Location.Y - 20);
                pbHare.Location = new Point(hare1.GetPosition() * hare1.Getjumprange() + hare1.Getxmarg(), harey + pictureBox1.Location.Y - 20);
            }
            else
            {
                pbTurtle.Visible = false;
                pbHare.Visible = false;
            }
        }

        //On each timer tick
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Advances positions
            hare1.updatePosition();
            turtle1.updatePosition();

            //Update picture box
            pictureBox1.Invalidate();

            if (hare1.GetPosition() == turtle1.GetPosition())
            {
                sbites++;
                MessageBox.Show("Ouch! The animals bit each other at position " + turtle1.GetPosition());
                StatDisplay();
            }

            if(hare1.isWinner() && turtle1.isWinner())
            {
                Reset();
                ties++;
                sties++;
                MessageBox.Show("There is a tie");
                StatDisplay();
            }
            else if (hare1.isWinner())
            {
                Reset();
                harwins++;
                sharwins++;
                MessageBox.Show("Hare is the winner");
                StatDisplay();
            }
            else if (turtle1.isWinner())
            {
                Reset();
                turwins++;
                sturwins++;
                MessageBox.Show("Turtle is the winner");
                StatDisplay();
            }

            
        }

        //When statistics update is needed
        public void StatDisplay()
        {
            //Update bar graph
            pbBarGraph.Invalidate();

            //Update
            UpdateScoreboard();
            UpdateSScoreboard();

            //Save file
            SaveFile();
        }

        //Start the simulation when button is clicked
        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Interval = speed;

            timer1.Start();
        }

        //Pause simulation
        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        //Reset
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        //Resets positions, timer and update picture box to match
        public void Reset()
        {
            hare1.SetPosition(0);
            turtle1.SetPosition(0);

            timer1.Stop();

            pictureBox1.Invalidate();
        }

        //Update total scoreboard list box
        public void UpdateScoreboard()
        {
            //Clear
            lbScoreboard.Items.Clear();

            //Write results
            lbScoreboard.Items.Add("Turtle wins: " + turwins);
            lbScoreboard.Items.Add("Hare wins: " + harwins);
            lbScoreboard.Items.Add("Ties: " + ties);
        }

        //Update Session scoreboard
        public void UpdateSScoreboard()
        {
            //Clear
            lbSScoreboard.Items.Clear();

            //Write results
            lbSScoreboard.Items.Add("Turtle wins: " + sturwins);
            lbSScoreboard.Items.Add("Hare wins: " + sharwins);
            lbSScoreboard.Items.Add("Ties: " + sties);
            lbSScoreboard.Items.Add(" ");
            lbSScoreboard.Items.Add("Bites: " + sbites);
        }

        //Set speed
        private void btnSet_Click(object sender, EventArgs e)
        {
            double calc, input;

            input = Convert.ToDouble(nudSpeed.Value);

            //Speed (in timerticks/second) is represented by reciprocal function:
            //f(x) = 1000 miliseconds / g(x) miliseconds per timertick

            //Variable speed (timertick interval) is represented by reciprocal function:
            //g(x) = 1000/ (0.989898x + 1.010101)
            //such that g(1) = 500 and g(100) = 10

            //As g(x) is a reciprocal function, f(x) is simplified to a LINEAR function

            //In the code g(x) is represented by calc, which is then assigned to speed as a rounded number

            calc = 1000 / (0.989898 * input + 1.010101);

            //Assign rounded integer calc to speed
            speed = Convert.ToInt32(calc); 
        }

        //Draws bar graph
        public void DrawBarGraph(Graphics g)
        {
            //Margins of graph
            int xmarg = 0;
            int ymarg = 0;

            //Length of each axis
            int totalwidth = 300;
            int totalheight = 300;

            //Distance between bars
            int spacing = 75;

            //Width of bars
            int barwidth = 20;

            //Total games played
            int totalgames;

            //Size of bar in decimal form
            double turtlesize, haresize, tiesize;

            //Calculate total games
            totalgames = turwins + harwins + ties;

            //Calculate turtle bar size
            if (turwins == 0)
            {
                turtlesize = 0;
            }
            else
            {
                turtlesize = (double)turwins / (double)totalgames;
            }

            //Calculate hare bar size
            if (harwins == 0)
            {
                haresize = 0;
            }
            else
            {
                haresize = (double)harwins / (double)totalgames;
            }

            //Calculate tie bar size
            if (ties == 0)
            {
                tiesize = 0;
            }
            else
            {
                tiesize = (double)ties / (double)totalgames;
            }

            //Drawing
            SolidBrush myBrush = new SolidBrush(Color.Black);
            Pen myPen = new Pen(Color.Black, 2);
            Pen myDottedPen = new Pen(Color.Black, 2);

            myDottedPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;

            //Draw vertical axis
            g.DrawLine(myPen, xmarg, ymarg, xmarg, ymarg + totalheight);

            //Draw horizontal axis
            g.DrawLine(myPen, xmarg, ymarg + totalheight, xmarg + totalwidth, xmarg + totalheight);

            //Draw guidlines
            g.DrawLine(myDottedPen, xmarg + totalwidth / 4, ymarg, xmarg + totalwidth / 4, ymarg + totalheight);
            g.DrawLine(myDottedPen, xmarg + totalwidth / 2, ymarg, xmarg + totalwidth / 2, ymarg + totalheight);
            g.DrawLine(myDottedPen, xmarg + 3 * totalwidth / 4, ymarg, xmarg + 3 * totalwidth / 4, ymarg + totalheight);
            g.DrawLine(myDottedPen, xmarg + totalwidth, ymarg, xmarg + totalwidth, ymarg + totalheight);

            //Turtle bar
            g.FillRectangle(myBrush, xmarg , ymarg + spacing, Convert.ToInt32(turtlesize * (double)totalwidth), barwidth);

            //Hare bar
            g.FillRectangle(myBrush, xmarg , ymarg + 2 * spacing, Convert.ToInt32(haresize * (double)totalwidth), barwidth);

            //Tie bar
            g.FillRectangle(myBrush, xmarg , ymarg + 3 * spacing, Convert.ToInt32(tiesize * (double)totalwidth), barwidth);
        }

        //Calls method that draws bar graph
        private void pbBarGraph_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            DrawBarGraph(g);
        }

        //Saves results
        public void SaveFile()
        {
            TextWriter tw = new StreamWriter("RaceResults.txt");

            //Writes all 3 results splitted with commas
            tw.Write(turwins + ",");
            tw.Write(harwins + ",");
            tw.Write(ties + ",");
            tw.Close();
        }

        //Reads total results from file
        public void ReadFile()
        {
            string[] splittedInput;
            string input;
            
            TextReader tr = new StreamReader("RaceResults.txt");

            while ((input = tr.ReadLine()) != null)
            {
                //Splits the lines of text between commas and assigns them to variable
                splittedInput = input.Split(',');
                turwins = Convert.ToInt32(splittedInput[0]);
                harwins = Convert.ToInt32(splittedInput[1]);
                ties = Convert.ToInt32(splittedInput[2]);
            }
            tr.Close();
        }

        //Reset Total Stats
        public void ResetStat()
        {
            turwins = 0;
            harwins = 0;
            ties = 0;
            
            //Update graph and total scoreboard
            pbBarGraph.Invalidate();
            UpdateScoreboard();
        }

        //Reset Session Stats
        public void ResetSStat()
        {
            sturwins = 0;
            sharwins = 0;
            sties = 0;
            sbites = 0;

            //Update Session Score Board
            UpdateSScoreboard();
        }

        //Reset Score
        private void btnResscore_Click(object sender, EventArgs e)
        {
            ResetStat();
            Reset();

            SaveFile();
        }

        //Reset Session Score
        private void btnSResscore_Click(object sender, EventArgs e)
        {
            ResetSStat();

            SaveFile();
        }

        //Assigns picture mode value
        private void rbPic_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPic.Checked == true)
            {
                picturemode = true;
                pbTurtle.Visible = true;
                pbHare.Visible = true;
            }
            else
            {
                picturemode = false;
                pbTurtle.Visible = false;
                pbHare.Visible = false;
            }
        }

        //Assigns picture mode value
        private void rbDraw_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDraw.Checked == true)
            {
                picturemode = false;
                pbTurtle.Visible = false;
                pbHare.Visible = false;
            }
            else
            {
                picturemode = true;
                pbTurtle.Visible = true;
                pbHare.Visible = true;
            }
        }

        //Change turtle color
        private void btnTurcol_Click(object sender, EventArgs e)
        {
            //Pick color in color dialogue
            ColorDialog coldlg = new ColorDialog();

            //Set the color
            if (coldlg.ShowDialog() == DialogResult.OK)
            {
                turtle1.SetColor(coldlg.Color);
            }

            //Update picture box
            pictureBox1.Invalidate();
        }

        //Change hare color
        private void btnHarcol_Click(object sender, EventArgs e)
        {
            //Pick color in color dialogue
            ColorDialog coldlg = new ColorDialog();

            //Set color
            if (coldlg.ShowDialog() == DialogResult.OK)
            {
                hare1.SetColor(coldlg.Color);
            }

            //Update picture box
            pictureBox1.Invalidate();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

    }
}

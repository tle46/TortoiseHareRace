namespace TortoiseHareProject
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnHarcol = new System.Windows.Forms.Button();
            this.btnTurcol = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPic = new System.Windows.Forms.RadioButton();
            this.rbDraw = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudSpeed = new System.Windows.Forms.NumericUpDown();
            this.btnSet = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbSScoreboard = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSResscore = new System.Windows.Forms.Button();
            this.pbBarGraph = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pbTurtle = new System.Windows.Forms.PictureBox();
            this.pbHare = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnResscore = new System.Windows.Forms.Button();
            this.lbScoreboard = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTurtle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHare)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(775, 250);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(16, 313);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(150, 50);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(172, 313);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(150, 50);
            this.btnPause.TabIndex = 1;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(328, 313);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(150, 50);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnHarcol
            // 
            this.btnHarcol.Location = new System.Drawing.Point(25, 60);
            this.btnHarcol.Name = "btnHarcol";
            this.btnHarcol.Size = new System.Drawing.Size(110, 23);
            this.btnHarcol.TabIndex = 1;
            this.btnHarcol.Text = "Hare";
            this.btnHarcol.UseVisualStyleBackColor = true;
            this.btnHarcol.Click += new System.EventHandler(this.btnHarcol_Click);
            // 
            // btnTurcol
            // 
            this.btnTurcol.Location = new System.Drawing.Point(25, 31);
            this.btnTurcol.Name = "btnTurcol";
            this.btnTurcol.Size = new System.Drawing.Size(110, 23);
            this.btnTurcol.TabIndex = 0;
            this.btnTurcol.Text = "Turtle";
            this.btnTurcol.UseVisualStyleBackColor = true;
            this.btnTurcol.Click += new System.EventHandler(this.btnTurcol_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTurcol);
            this.groupBox1.Controls.Add(this.btnHarcol);
            this.groupBox1.Location = new System.Drawing.Point(16, 378);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change Color";
            // 
            // rbPic
            // 
            this.rbPic.AutoSize = true;
            this.rbPic.Location = new System.Drawing.Point(19, 54);
            this.rbPic.Name = "rbPic";
            this.rbPic.Size = new System.Drawing.Size(112, 21);
            this.rbPic.TabIndex = 1;
            this.rbPic.TabStop = true;
            this.rbPic.Text = "Picture Mode";
            this.rbPic.UseVisualStyleBackColor = true;
            this.rbPic.CheckedChanged += new System.EventHandler(this.rbPic_CheckedChanged);
            // 
            // rbDraw
            // 
            this.rbDraw.AutoSize = true;
            this.rbDraw.Location = new System.Drawing.Point(19, 27);
            this.rbDraw.Name = "rbDraw";
            this.rbDraw.Size = new System.Drawing.Size(100, 21);
            this.rbDraw.TabIndex = 0;
            this.rbDraw.TabStop = true;
            this.rbDraw.Text = "Draw Mode";
            this.rbDraw.UseVisualStyleBackColor = true;
            this.rbDraw.CheckedChanged += new System.EventHandler(this.rbDraw_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbDraw);
            this.groupBox2.Controls.Add(this.rbPic);
            this.groupBox2.Location = new System.Drawing.Point(172, 378);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Graphics Mode";
            // 
            // nudSpeed
            // 
            this.nudSpeed.Location = new System.Drawing.Point(25, 30);
            this.nudSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpeed.Name = "nudSpeed";
            this.nudSpeed.Size = new System.Drawing.Size(110, 22);
            this.nudSpeed.TabIndex = 0;
            this.nudSpeed.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(25, 59);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(110, 23);
            this.btnSet.TabIndex = 1;
            this.btnSet.Text = "Set Speed";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSet);
            this.groupBox3.Controls.Add(this.nudSpeed);
            this.groupBox3.Location = new System.Drawing.Point(328, 378);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(150, 100);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Speed (1-100)";
            // 
            // lbSScoreboard
            // 
            this.lbSScoreboard.FormattingEnabled = true;
            this.lbSScoreboard.ItemHeight = 16;
            this.lbSScoreboard.Location = new System.Drawing.Point(22, 23);
            this.lbSScoreboard.Name = "lbSScoreboard";
            this.lbSScoreboard.Size = new System.Drawing.Size(99, 84);
            this.lbSScoreboard.TabIndex = 12;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSResscore);
            this.groupBox4.Controls.Add(this.lbSScoreboard);
            this.groupBox4.Location = new System.Drawing.Point(494, 313);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(159, 165);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Scoreboard";
            // 
            // btnSResscore
            // 
            this.btnSResscore.Location = new System.Drawing.Point(22, 119);
            this.btnSResscore.Name = "btnSResscore";
            this.btnSResscore.Size = new System.Drawing.Size(99, 23);
            this.btnSResscore.TabIndex = 0;
            this.btnSResscore.Text = "Reset Score";
            this.btnSResscore.UseVisualStyleBackColor = true;
            this.btnSResscore.Click += new System.EventHandler(this.btnSResscore_Click);
            // 
            // pbBarGraph
            // 
            this.pbBarGraph.Location = new System.Drawing.Point(914, 99);
            this.pbBarGraph.Name = "pbBarGraph";
            this.pbBarGraph.Size = new System.Drawing.Size(300, 300);
            this.pbBarGraph.TabIndex = 15;
            this.pbBarGraph.TabStop = false;
            this.pbBarGraph.Paint += new System.Windows.Forms.PaintEventHandler(this.pbBarGraph_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(907, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "0%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1059, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "50%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1198, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "100%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(844, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Turtle Win";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(850, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Hare Win";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(880, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Tie";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(911, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(286, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Total Game Result vs. Outcome Percentage";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(980, 415);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "25%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1130, 415);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "75%";
            // 
            // pbTurtle
            // 
            this.pbTurtle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbTurtle.BackgroundImage")));
            this.pbTurtle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbTurtle.Location = new System.Drawing.Point(27, 120);
            this.pbTurtle.Name = "pbTurtle";
            this.pbTurtle.Size = new System.Drawing.Size(91, 46);
            this.pbTurtle.TabIndex = 25;
            this.pbTurtle.TabStop = false;
            // 
            // pbHare
            // 
            this.pbHare.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbHare.BackgroundImage")));
            this.pbHare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbHare.Location = new System.Drawing.Point(27, 172);
            this.pbHare.Name = "pbHare";
            this.pbHare.Size = new System.Drawing.Size(81, 66);
            this.pbHare.TabIndex = 26;
            this.pbHare.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnResscore);
            this.groupBox5.Controls.Add(this.lbScoreboard);
            this.groupBox5.Location = new System.Drawing.Point(662, 313);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(159, 165);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Total Scoreboard";
            // 
            // btnResscore
            // 
            this.btnResscore.Location = new System.Drawing.Point(22, 119);
            this.btnResscore.Name = "btnResscore";
            this.btnResscore.Size = new System.Drawing.Size(99, 23);
            this.btnResscore.TabIndex = 0;
            this.btnResscore.Text = "Reset Score";
            this.btnResscore.UseVisualStyleBackColor = true;
            this.btnResscore.Click += new System.EventHandler(this.btnResscore_Click);
            // 
            // lbScoreboard
            // 
            this.lbScoreboard.FormattingEnabled = true;
            this.lbScoreboard.ItemHeight = 16;
            this.lbScoreboard.Location = new System.Drawing.Point(22, 23);
            this.lbScoreboard.Name = "lbScoreboard";
            this.lbScoreboard.Size = new System.Drawing.Size(99, 84);
            this.lbScoreboard.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1282, 503);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.pbHare);
            this.Controls.Add(this.pbTurtle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbBarGraph);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Turtle and Hare Race";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBarGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTurtle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHare)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnHarcol;
        private System.Windows.Forms.Button btnTurcol;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPic;
        private System.Windows.Forms.RadioButton rbDraw;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudSpeed;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbSScoreboard;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pbBarGraph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pbTurtle;
        private System.Windows.Forms.PictureBox pbHare;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnResscore;
        private System.Windows.Forms.ListBox lbScoreboard;
        private System.Windows.Forms.Button btnSResscore;
    }
}


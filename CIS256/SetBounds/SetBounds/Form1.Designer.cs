namespace SetBounds
{
    partial class frmHorseRace
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnNewrace = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblcsharptime = new System.Windows.Forms.Label();
            this.lblRubytime = new System.Windows.Forms.Label();
            this.lblPythontime = new System.Windows.Forms.Label();
            this.pythonavatar = new System.Windows.Forms.PictureBox();
            this.rubyavatar = new System.Windows.Forms.PictureBox();
            this.csharpavatar = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startRaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.l = new System.Windows.Forms.Label();
            this.lblRubywins = new System.Windows.Forms.Label();
            this.lblPythonwins = new System.Windows.Forms.Label();
            this.lblSeesharpiewins = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radPython = new System.Windows.Forms.RadioButton();
            this.radRuby = new System.Windows.Forms.RadioButton();
            this.radCsharp = new System.Windows.Forms.RadioButton();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBetamt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ckBets = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pythonavatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubyavatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.csharpavatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.FlatAppearance.BorderSize = 5;
            this.btnStart.Location = new System.Drawing.Point(11, 426);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(98, 32);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "They\'re Off!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNewrace
            // 
            this.btnNewrace.Location = new System.Drawing.Point(11, 469);
            this.btnNewrace.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewrace.Name = "btnNewrace";
            this.btnNewrace.Size = new System.Drawing.Size(98, 32);
            this.btnNewrace.TabIndex = 4;
            this.btnNewrace.Text = "&New Race";
            this.btnNewrace.UseVisualStyleBackColor = true;
            this.btnNewrace.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(369, 479);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "See Sharpie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(542, 479);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ruby Baby:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(710, 479);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Python\'ll Bite:";
            // 
            // lblcsharptime
            // 
            this.lblcsharptime.AutoSize = true;
            this.lblcsharptime.BackColor = System.Drawing.Color.Transparent;
            this.lblcsharptime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblcsharptime.Location = new System.Drawing.Point(455, 479);
            this.lblcsharptime.Name = "lblcsharptime";
            this.lblcsharptime.Size = new System.Drawing.Size(14, 13);
            this.lblcsharptime.TabIndex = 8;
            this.lblcsharptime.Text = "0";
            // 
            // lblRubytime
            // 
            this.lblRubytime.AutoSize = true;
            this.lblRubytime.BackColor = System.Drawing.Color.Transparent;
            this.lblRubytime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRubytime.Location = new System.Drawing.Point(620, 479);
            this.lblRubytime.Name = "lblRubytime";
            this.lblRubytime.Size = new System.Drawing.Size(14, 13);
            this.lblRubytime.TabIndex = 9;
            this.lblRubytime.Text = "0";
            // 
            // lblPythontime
            // 
            this.lblPythontime.AutoSize = true;
            this.lblPythontime.BackColor = System.Drawing.Color.Transparent;
            this.lblPythontime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPythontime.Location = new System.Drawing.Point(801, 479);
            this.lblPythontime.Name = "lblPythontime";
            this.lblPythontime.Size = new System.Drawing.Size(14, 13);
            this.lblPythontime.TabIndex = 10;
            this.lblPythontime.Text = "0";
            // 
            // pythonavatar
            // 
            this.pythonavatar.Image = global::SetBounds.Properties.Resources.horse;
            this.pythonavatar.Location = new System.Drawing.Point(11, 311);
            this.pythonavatar.Margin = new System.Windows.Forms.Padding(2);
            this.pythonavatar.Name = "pythonavatar";
            this.pythonavatar.Size = new System.Drawing.Size(135, 101);
            this.pythonavatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pythonavatar.TabIndex = 3;
            this.pythonavatar.TabStop = false;
            this.pythonavatar.MouseHover += new System.EventHandler(this.pictureBox3_MouseHover);
            // 
            // rubyavatar
            // 
            this.rubyavatar.Image = global::SetBounds.Properties.Resources.horse;
            this.rubyavatar.Location = new System.Drawing.Point(11, 187);
            this.rubyavatar.Margin = new System.Windows.Forms.Padding(2);
            this.rubyavatar.Name = "rubyavatar";
            this.rubyavatar.Size = new System.Drawing.Size(135, 101);
            this.rubyavatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rubyavatar.TabIndex = 2;
            this.rubyavatar.TabStop = false;
            this.rubyavatar.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // csharpavatar
            // 
            this.csharpavatar.Image = global::SetBounds.Properties.Resources.horse;
            this.csharpavatar.Location = new System.Drawing.Point(11, 60);
            this.csharpavatar.Margin = new System.Windows.Forms.Padding(2);
            this.csharpavatar.Name = "csharpavatar";
            this.csharpavatar.Size = new System.Drawing.Size(135, 107);
            this.csharpavatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.csharpavatar.TabIndex = 1;
            this.csharpavatar.TabStop = false;
            this.csharpavatar.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.DarkRed;
            this.pictureBox4.Location = new System.Drawing.Point(154, 48);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(7, 373);
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(11, 509);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 32);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.DarkRed;
            this.pictureBox5.Location = new System.Drawing.Point(848, 48);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(7, 373);
            this.pictureBox5.TabIndex = 20;
            this.pictureBox5.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startRaceToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(467, 517);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(203, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startRaceToolStripMenuItem
            // 
            this.startRaceToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startRaceToolStripMenuItem.Name = "startRaceToolStripMenuItem";
            this.startRaceToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.startRaceToolStripMenuItem.Text = "Start Race";
            this.startRaceToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.button2_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.infoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.BackColor = System.Drawing.Color.Transparent;
            this.l.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l.Location = new System.Drawing.Point(677, 441);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(103, 17);
            this.l.TabIndex = 16;
            this.l.Text = "Python\'ll Bite";
            // 
            // lblRubywins
            // 
            this.lblRubywins.AutoSize = true;
            this.lblRubywins.BackColor = System.Drawing.Color.Transparent;
            this.lblRubywins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRubywins.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRubywins.Location = new System.Drawing.Point(650, 441);
            this.lblRubywins.Name = "lblRubywins";
            this.lblRubywins.Size = new System.Drawing.Size(17, 17);
            this.lblRubywins.TabIndex = 15;
            this.lblRubywins.Text = "0";
            // 
            // lblPythonwins
            // 
            this.lblPythonwins.AutoSize = true;
            this.lblPythonwins.BackColor = System.Drawing.Color.Transparent;
            this.lblPythonwins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPythonwins.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPythonwins.Location = new System.Drawing.Point(786, 441);
            this.lblPythonwins.Name = "lblPythonwins";
            this.lblPythonwins.Size = new System.Drawing.Size(17, 17);
            this.lblPythonwins.TabIndex = 17;
            this.lblPythonwins.Text = "0";
            // 
            // lblSeesharpiewins
            // 
            this.lblSeesharpiewins.AutoSize = true;
            this.lblSeesharpiewins.BackColor = System.Drawing.Color.Transparent;
            this.lblSeesharpiewins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeesharpiewins.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSeesharpiewins.Location = new System.Drawing.Point(531, 441);
            this.lblSeesharpiewins.Name = "lblSeesharpiewins";
            this.lblSeesharpiewins.Size = new System.Drawing.Size(17, 17);
            this.lblSeesharpiewins.TabIndex = 13;
            this.lblSeesharpiewins.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(428, 441);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "See Sharpie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(380, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Wins:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(558, 441);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ruby Baby";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radPython);
            this.groupBox1.Controls.Add(this.radRuby);
            this.groupBox1.Controls.Add(this.radCsharp);
            this.groupBox1.Controls.Add(this.lblBalance);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtBetamt);
            this.groupBox1.Location = new System.Drawing.Point(135, 436);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 102);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // radPython
            // 
            this.radPython.AutoSize = true;
            this.radPython.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPython.Location = new System.Drawing.Point(132, 79);
            this.radPython.Name = "radPython";
            this.radPython.Size = new System.Drawing.Size(85, 17);
            this.radPython.TabIndex = 8;
            this.radPython.TabStop = true;
            this.radPython.Text = "Python\'ll Bite";
            this.radPython.UseVisualStyleBackColor = true;
            this.radPython.MouseEnter += new System.EventHandler(this.radPython_MouseEnter);
            // 
            // radRuby
            // 
            this.radRuby.AutoSize = true;
            this.radRuby.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRuby.Location = new System.Drawing.Point(132, 57);
            this.radRuby.Name = "radRuby";
            this.radRuby.Size = new System.Drawing.Size(77, 17);
            this.radRuby.TabIndex = 7;
            this.radRuby.TabStop = true;
            this.radRuby.Text = "Ruby Baby";
            this.radRuby.UseVisualStyleBackColor = true;
            this.radRuby.MouseEnter += new System.EventHandler(this.radRuby_MouseEnter_1);
            // 
            // radCsharp
            // 
            this.radCsharp.AutoSize = true;
            this.radCsharp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCsharp.Location = new System.Drawing.Point(132, 36);
            this.radCsharp.Name = "radCsharp";
            this.radCsharp.Size = new System.Drawing.Size(83, 17);
            this.radCsharp.TabIndex = 6;
            this.radCsharp.TabStop = true;
            this.radCsharp.Text = "See Sharpie";
            this.radCsharp.UseVisualStyleBackColor = true;
            this.radCsharp.MouseEnter += new System.EventHandler(this.radCsharp_MouseEnter);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(79, 79);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(31, 13);
            this.lblBalance.TabIndex = 5;
            this.lblBalance.Text = "$100";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Your Balance:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Bet Amt:";
            // 
            // txtBetamt
            // 
            this.txtBetamt.Location = new System.Drawing.Point(48, 41);
            this.txtBetamt.Name = "txtBetamt";
            this.txtBetamt.Size = new System.Drawing.Size(62, 20);
            this.txtBetamt.TabIndex = 1;
            this.txtBetamt.MouseEnter += new System.EventHandler(this.txtBetamt_MouseEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.ckBets);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(135, 441);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 30);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(113, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "(check to enter bets)";
            // 
            // ckBets
            // 
            this.ckBets.AutoSize = true;
            this.ckBets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBets.Location = new System.Drawing.Point(92, 11);
            this.ckBets.Name = "ckBets";
            this.ckBets.Size = new System.Drawing.Size(15, 14);
            this.ckBets.TabIndex = 11;
            this.ckBets.UseVisualStyleBackColor = true;
            this.ckBets.CheckedChanged += new System.EventHandler(this.ckBets_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(6, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Wanna Bet?";
            // 
            // frmHorseRace
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SetBounds.Properties.Resources.race_bg3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1032, 550);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lblPythonwins);
            this.Controls.Add(this.l);
            this.Controls.Add(this.lblRubywins);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblSeesharpiewins);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPythontime);
            this.Controls.Add(this.lblRubytime);
            this.Controls.Add(this.lblcsharptime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNewrace);
            this.Controls.Add(this.pythonavatar);
            this.Controls.Add(this.rubyavatar);
            this.Controls.Add(this.csharpavatar);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHorseRace";
            this.Text = "SCC Downs";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pythonavatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubyavatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.csharpavatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox csharpavatar;
        private System.Windows.Forms.PictureBox rubyavatar;
        private System.Windows.Forms.PictureBox pythonavatar;
        private System.Windows.Forms.Button btnNewrace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblcsharptime;
        private System.Windows.Forms.Label lblRubytime;
        private System.Windows.Forms.Label lblPythontime;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startRaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label lblRubywins;
        private System.Windows.Forms.Label lblPythonwins;
        private System.Windows.Forms.Label lblSeesharpiewins;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBetamt;
        private System.Windows.Forms.RadioButton radPython;
        private System.Windows.Forms.RadioButton radRuby;
        private System.Windows.Forms.RadioButton radCsharp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox ckBets;
        private System.Windows.Forms.Label label6;
        
    }
}


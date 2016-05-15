namespace Убиј_го_кртот
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
            this.molePb = new System.Windows.Forms.PictureBox();
            this.timerInterval = new System.Windows.Forms.Timer(this.components);
            this.randomTimeMole = new System.Windows.Forms.Timer(this.components);
            this.poeniLbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.играToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.мениToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рестартToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.исклучиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помошToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.vremeLbl = new System.Windows.Forms.Label();
            this.vremeTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.molePb)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // molePb
            // 
            this.molePb.BackColor = System.Drawing.Color.Transparent;
            this.molePb.Location = new System.Drawing.Point(412, 250);
            this.molePb.Name = "molePb";
            this.molePb.Size = new System.Drawing.Size(96, 117);
            this.molePb.TabIndex = 0;
            this.molePb.TabStop = false;
            this.molePb.Click += new System.EventHandler(this.molePb_Click);
            // 
            // timerInterval
            // 
            this.timerInterval.Enabled = true;
            this.timerInterval.Interval = 61000;
            this.timerInterval.Tick += new System.EventHandler(this.timerInterval_Tick);
            // 
            // randomTimeMole
            // 
            this.randomTimeMole.Enabled = true;
            this.randomTimeMole.Interval = 2000;
            this.randomTimeMole.Tick += new System.EventHandler(this.randomTimeMole_Tick);
            // 
            // poeniLbl
            // 
            this.poeniLbl.AutoSize = true;
            this.poeniLbl.BackColor = System.Drawing.Color.Transparent;
            this.poeniLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poeniLbl.Location = new System.Drawing.Point(12, 24);
            this.poeniLbl.Name = "poeniLbl";
            this.poeniLbl.Size = new System.Drawing.Size(124, 31);
            this.poeniLbl.TabIndex = 1;
            this.poeniLbl.Text = "Поени: 0";
            this.poeniLbl.TextChanged += new System.EventHandler(this.poeniLbl_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.играToolStripMenuItem,
            this.помошToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // играToolStripMenuItem
            // 
            this.играToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.мениToolStripMenuItem,
            this.рестартToolStripMenuItem,
            this.исклучиToolStripMenuItem});
            this.играToolStripMenuItem.Name = "играToolStripMenuItem";
            this.играToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.играToolStripMenuItem.Text = "Игра";
            // 
            // мениToolStripMenuItem
            // 
            this.мениToolStripMenuItem.Name = "мениToolStripMenuItem";
            this.мениToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.мениToolStripMenuItem.Text = "Мени";
            this.мениToolStripMenuItem.Click += new System.EventHandler(this.мениToolStripMenuItem_Click);
            // 
            // рестартToolStripMenuItem
            // 
            this.рестартToolStripMenuItem.Name = "рестартToolStripMenuItem";
            this.рестартToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.рестартToolStripMenuItem.Text = "Рестарт";
            this.рестартToolStripMenuItem.Click += new System.EventHandler(this.рестартToolStripMenuItem_Click);
            // 
            // исклучиToolStripMenuItem
            // 
            this.исклучиToolStripMenuItem.Name = "исклучиToolStripMenuItem";
            this.исклучиToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.исклучиToolStripMenuItem.Text = "Излез";
            this.исклучиToolStripMenuItem.Click += new System.EventHandler(this.исклучиToolStripMenuItem_Click);
            // 
            // помошToolStripMenuItem
            // 
            this.помошToolStripMenuItem.Name = "помошToolStripMenuItem";
            this.помошToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.помошToolStripMenuItem.Text = "Помош";
            this.помошToolStripMenuItem.Click += new System.EventHandler(this.помошToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Преостанато време:";
            // 
            // vremeLbl
            // 
            this.vremeLbl.AutoSize = true;
            this.vremeLbl.BackColor = System.Drawing.Color.Transparent;
            this.vremeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vremeLbl.Location = new System.Drawing.Point(423, 55);
            this.vremeLbl.Name = "vremeLbl";
            this.vremeLbl.Size = new System.Drawing.Size(132, 63);
            this.vremeLbl.TabIndex = 4;
            this.vremeLbl.Text = "1:00";
            // 
            // vremeTimer
            // 
            this.vremeTimer.Enabled = true;
            this.vremeTimer.Interval = 1000;
            this.vremeTimer.Tick += new System.EventHandler(this.vremeTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Убиј_го_кртот.Resource1.slug1;
            this.pictureBox1.Location = new System.Drawing.Point(698, 465);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 95);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Убиј_го_кртот.Resource1.slug2;
            this.pictureBox2.Location = new System.Drawing.Point(360, 479);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(299, 81);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::Убиј_го_кртот.Resource1.slug3;
            this.pictureBox3.Location = new System.Drawing.Point(0, 455);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(256, 105);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Куршуми:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox4.Location = new System.Drawing.Point(19, 96);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(185, 29);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox4_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(219, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 31);
            this.label3.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Убиј_го_кртот.Resource1.backgroundddd;
            this.ClientSize = new System.Drawing.Size(984, 559);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.vremeLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.poeniLbl);
            this.Controls.Add(this.molePb);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Убиј го кртот";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.molePb)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox molePb;
        private System.Windows.Forms.Timer timerInterval;
        private System.Windows.Forms.Timer randomTimeMole;
        private System.Windows.Forms.Label poeniLbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem играToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem мениToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem исклучиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помошToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label vremeLbl;
        private System.Windows.Forms.Timer vremeTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolStripMenuItem рестартToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;






    }
}


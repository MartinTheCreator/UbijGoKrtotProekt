using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Resources;

namespace Убиј_го_кртот
{
    public partial class Form1 : Form
    {
        int poeniPerKill;
        bool killed;
        Bitmap alive;
        Bitmap dead;
        Bitmap target;
        Mole mole;
        //String[] trashTalk;
        //string trash;
        Form2 form;
        bool zheton;
        int poeni;
        int bullets;
        int nextX;
        bool shootingLock;
        Form3 prompt;
        bool lockShoot;
        public Form1(Form2 form)
        {
            InitializeComponent();
            nextX = 0;
            bullets = 8;
            

            poeni = 0;
            this.form = form;
            
            zheton = true;

            
            this.DoubleBuffered = true;
            lockShoot = true;


            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            UpdateStyles();

           
            
            

            poeniPerKill = 10;
            mole = new Mole();
            killed = false;
            alive = new Bitmap(Resource1.Mole, new Size(mole.getWidth(),mole.getHeight()));
            dead = new Bitmap(Resource1.killedMole, new Size(mole.getWidth(), mole.getHeight()));
            target = new Bitmap(Resource1.Target, new Size(70, 70));
            molePb.BackgroundImage = alive;
            //newMole();
            newGame();

        }
        
        public void newMole()
        {
            Random r = new Random();
            //Random r2 = new Random();
            int x1= r.Next(0,880);
            int y1 = r.Next(200,400);

           // Bitmap bmp = new Bitmap(Resource1.Mole, new Size(96, 117));
            molePb.BackgroundImage = alive;
            //mole.newMole(molePb,ref alive);

            molePb.Location = new Point(x1,y1);
            killed = false;
            checkSpeed();     
        }

        public void deadMole()
        {
            if (lockShoot == true)
            {
                molePb.BackgroundImage = dead;
                //mole.deadMole(molePb,ref dead);
                Graphics g = CreateGraphics();
                //Font font = new Font("Stencil", 18, FontStyle.Regular);
                //g.DrawString()
                mole.DrawScore(g, molePb);
                lockShoot = false;

                string strTmp = poeniLbl.Text.Split(' ')[1];
                int tmp = Convert.ToInt16(strTmp);
                tmp += poeniPerKill;
                poeni = tmp;
                poeniLbl.Text = "Поени: " + poeni.ToString();

            }
        }

        public void checkSpeed() {
            
            if (poeni >= 50)
            {
                randomTimeMole.Interval = 1500;
            }
            else if (poeni >= 100)
            {
                randomTimeMole.Interval = 1000;
            }
            else if (poeni >= 150)
            {
                randomTimeMole.Interval = 500;
            }
        }

        private void timerInterval_Tick(object sender, EventArgs e)
        {
            randomTimeMole.Stop();
            zheton = false;
            timerInterval.Stop();
            vremeTimer.Stop();
            //poeni= poeniPerKill;


            //string stringce = "Поени: " + poeni.ToString() + ". Внесете го вашето име:";
            //string promptValue = Prompt.ShowDialog(stringce, "Внесете го вашето име");

            prompt = new Form3(poeni);
            prompt.ShowDialog();
            
            

            //string str="Вашето време заврши.Вашите поени изнесуваат " + poeni + " !Нова игра?"; 
            string str = "Нова игра?";
            DialogResult result = MessageBox.Show(str,"Времето заврши", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

           
            if (result == DialogResult.Yes) {
                newGame();
            }
            else if (result == DialogResult.No) {
                form.Show();
                this.Close();
            }
        }

        private void newGame() {
            timerInterval.Interval = 61000;
            vremeTimer.Interval = 1000;
            randomTimeMole.Interval = 2000;
            vremeLbl.ForeColor = Color.Black;
            vremeLbl.Text = "1:00";
            label3.Text = "";
            
            poeni = 0;
            poeniLbl.Text = "Поени: " + poeni.ToString();
            zheton = true;
            newMole();
            sekundi = 60;
            timerInterval.Start();
            randomTimeMole.Start();
            vremeTimer.Start();
            Invalidate();
            shootingLock = true;
            reload();
            
        }

        

        private void randomTimeMole_Tick(object sender, EventArgs e)
        {
            lockShoot = true;
            newMole();
            Invalidate();
           
        }

        private void molePb_Click(object sender, EventArgs e)
        {
            
           
            if (zheton == true && shootingLock == true)
            {
                /*string strTmp = poeniLbl.Text.Split(' ')[1];
                int tmp = Convert.ToInt16(strTmp);
                tmp += poeniPerKill;
                poeni = tmp;
                poeniLbl.Text = "Поени: " + poeni.ToString();*/

                shooting();

                

                killed = true;
                deadMole();
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            miss(sender, e);
        }

        public void miss(object sender, MouseEventArgs e) 
        {

            if (shootingLock == true && lockShoot==true)
            {
                Graphics gs = CreateGraphics();
                Bitmap shotImg = new Bitmap(Resource1.BulletHole, new Size(40, 40));
                gs.DrawImage(shotImg, new Point(e.X - 20, e.Y - 20));

                
                lockShoot = false;

            }

        }

       

       /* public void swear() {

            
                Graphics gm = CreateGraphics();

                int xT = molePb.Location.X + 40;
                int yT = molePb.Location.Y - 90;

                Rectangle rec = new Rectangle(xT, yT, 150, 80);
                gm.FillEllipse(Brushes.White, rec);

                Font font = new Font("Stencil", 18, FontStyle.Regular);
                gm.DrawString(trash, font, Brushes.Black, xT + 25, yT + 30);
                //swearing = true;
                Invalidate();
        }*/

        private void исклучиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
        int sekundi = 60;
        

        private void vremeTimer_Tick(object sender, EventArgs e)
        {
           
            sekundi -= 1;
            if (sekundi == 20)
            {
                vremeLbl.ForeColor = Color.Orange;
            }
            else if (sekundi == 10)
            {
                vremeLbl.ForeColor = Color.Red;
            }

            vremeLbl.Text = String.Format("0:{0:00}", sekundi);
        }

       

        private void refresh_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void poeniLbl_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void мениToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            form.Show();
            this.Dispose();
        }

        private void рестартToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newGame();
        }
        
        private void pictureBox4_Paint(object sender, PaintEventArgs e)
        {
           
            Graphics g = e.Graphics;

            paintBullets(g);
        }

        private void paintBullets(Graphics g) {
            
                nextX = 0;
                Bitmap img = new Bitmap(Resource1.bullet, new Size(50, 30));

                for (int i = 0; i < bullets; i++)
                {
                    g.DrawImage(img, new Point(nextX, 0));
                    nextX = nextX + 20;
                }
            
        }

        private void shooting() {


            if (bullets == 1) { 
                label3.Text= "Притисни 'Space' за наполнување на шаржерот";
                shootingLock=false;
            }

            if (lockShoot == true)
            {

                bullets = bullets - 1;
                pictureBox4.Refresh();
            }
        }





        private void Form1_Click(object sender, EventArgs e)
        {
            
            shooting();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            shooting();
            lockShoot = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) {
                reload();
            }
        }

        public void reload() {
            bullets = 8;
            pictureBox4.Refresh();
            label3.Text = "";
            shootingLock = true;
        }

        private void помошToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           
            timerInterval.Stop();
            randomTimeMole.Stop();
            vremeTimer.Stop();
            DialogResult result = MessageBox.Show("Правила на игра:\n Пукате во кртот се додека не ви се потроши муницијата.Кога ќе ви се потроши муницијата го стискате 'Space' копчето на тастатура за да го наполните шаржерот. Играта трае 60 секунди и потребно е да направите што е можно повеќе поени.", "Помош", MessageBoxButtons.OK);
            if (result == DialogResult.OK) {
                timerInterval.Interval = (sekundi+1)*1000;
                MessageBox.Show(timerInterval.Interval.ToString());
                timerInterval.Start();
                randomTimeMole.Start();
                vremeTimer.Start();
            }
        }

        
    }
}

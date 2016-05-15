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
namespace Убиј_го_кртот
{
    public partial class Form2 : Form
    {
        int x;
        string[] hsText;

        string fullPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))
            + @"\highscores.txt";   //pateka na tekst file za highscores
        public Form2()
        {
            InitializeComponent();
            x = 0;
            label2.Location = new Point(-100,126);

            hsText = Resource1.HighScore.Split('\n');


            Application.EnableVisualStyles();
            label3.Text = "";
            textBox1.Hide();
            listBox1.Hide();
            
        }

        


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label2.Location.X != 190)
            {
                label2.Location = new Point(x+=10, 126);
            }
            else {
                timer1.Stop();
                timer2.Stop();
            }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap bmp = new Bitmap(Resource1.signFinal, new Size(200, 300));
            g.DrawImage(bmp, new Point(200, 300));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Show();
            textBox1.Hide();
            listBox1.Items.Clear();
            int tmp;

            if (hsText.Length < 5)
            {
                tmp = hsText.Length;
            }
            else {
                tmp = 5;
            }
           
            //MessageBox.Show(wanted_path + @"\highscores.txt");

            StreamReader sw = new StreamReader(fullPath);

           // MessageBox.Show(sw.ReadLine());

            string strTmp;
            int br=1;
            listBox1.Items.Add("Wall of fame:");
            while ((strTmp=sw.ReadLine()) != null) {
                listBox1.Items.Add(br.ToString() + ". " + strTmp);
                br++;
            }

            sw.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form1 form = new Form1(this);
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Hide();
            textBox1.Show();
            textBox1.Text = "Правила на игра:" + Environment.NewLine + "Пукате во кртот се додека не ви се потроши муницијата.Кога ќе ви се потроши муницијата го стискате 'Space' копчето на тастатура за да го наполните шаржерот. Играта трае 60 секунди и потребно е да направите што е можно повеќе поени.";
        }
    }
}

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
    public partial class Form3 : Form
    {
        int poeni { get; set; }
        string fullPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))
            + @"\highscores.txt";   //pateka na tekst file za highscores

        public Form3(int x)
        {
            InitializeComponent();
            poeni = x;
            label1.Text = "Внесете го вашето име:";

            listBox1.Items.Clear();

            //MessageBox.Show(wanted_path + @"\highscores.txt");

            StreamReader sw = new StreamReader(fullPath);

           // MessageBox.Show(sw.ReadLine());

            string strTmp;

            int br = 1;
            while ((strTmp=sw.ReadLine()) != null) {
                listBox1.Items.Add(br.ToString() + ". "+strTmp);
                br++;
            }

            sw.Close();

        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (textBox1.Text == "") {
                textBox1.Text = "unknown";
            }
           //  StreamWriter sw = new StreamWriter(fullPath);
          //  sw.Close(); ova ti e potrebno pred da pravis stream reader :)
    
            StreamReader sr = new StreamReader(fullPath);

             string[] strTmp = new string[10];
             int i=0;
             string str;

             while ((str = sr.ReadLine()) != null) {
                 strTmp[i] = str;
                    i++;
             }

            sr.Close();                              //tuka go zatvaras streamreader
            StreamWriter sw = new StreamWriter(fullPath); //  i mozes da pisuvas
            string inputWord = poeni.ToString() +" "+ textBox1.Text;
            MessageBox.Show(inputWord);

            int numPlayers=i;
            int flag = 0;

            string[] strTmp2= new string[numPlayers+1];
            int j=0;
            string[] tmp1, tmp2;
            for (i = 0; i < numPlayers; i++) {
                tmp1 = inputWord.Split(' ');
                tmp2 = strTmp[i].Split(' ');
                if (Convert.ToInt16(tmp1[0]) > Convert.ToInt16(tmp2[0])&& flag==0)
                {
                    strTmp2[j] = inputWord;
                    flag = 1;
                    j++;
                    if (j == 9)
                        break;
                    strTmp2[j] = strTmp[i]; //inace ke skokne 1 igrac
                   j++;
                }
                else {
                    strTmp2[j] = strTmp[i];
                    j++;
                    if (j == 9)
                        break;
                }
                if (j < 9 && flag == 0)
                {
                    strTmp2[j] = inputWord;
                }
            }
           // if(flag==0)
          //      strTmp2
            
            
            for (i = 0; i < strTmp2.Length; i++) {
                sw.WriteLine(strTmp2[i]);
                
            }


           
            sw.Close();
            this.Close();
        }

    }
}

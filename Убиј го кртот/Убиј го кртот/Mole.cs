using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace Убиј_го_кртот
{
    public class Mole
    {
        private readonly int height;
        private readonly int width;
        public int _posX;
        public int _posY;

        public Mole()
        {
            height = 117;
            width = 96;
            
        }

        public void DrawScore(Graphics g, PictureBox molePb)
        {
            //Bitmap img = new Bitmap(Resource1.Mole, new Size(height, width));
            //g.DrawImage(img, new Point(_posX, _posY));
            
            Font font = new Font("Stencil", 40, FontStyle.Regular);
            g.DrawString("+10", font, Brushes.Gold, new Point(molePb.Location.X - 20, molePb.Location.Y - 60));
            
            //MessageBox.Show(molePb.Location.X.ToString());
            
        }
        public void newMole(PictureBox pb, Bitmap bmp)
        {
            Random r = new Random();

            int x1 = r.Next(0, 880);
            int y1 = r.Next(200, 400);

            pb.BackgroundImage = bmp;
            pb.Location = new Point(x1, y1);
        }

        public void deadMole(PictureBox pb, Bitmap bmp)
        {
            pb.BackgroundImage = bmp;
        }

        public int getHeight() {
            return height;
        }
        public int getWidth() {
            return width;
        }

       

    }
}

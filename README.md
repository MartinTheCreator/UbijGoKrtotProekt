# Убиј го кртот

![finki ukim logo](http://old.finki.ukim.mk/Style/images/frontEnd/layout/finki-logo-10.jpg)
![](https://raw.githubusercontent.com/MartinTheCreator/UbijGoKrtotProekt/master/resursi/signFinal.png)
![](https://raw.githubusercontent.com/MartinTheCreator/UbijGoKrtotProekt/master/resursi/Screenshot_1.png)
![](https://raw.githubusercontent.com/MartinTheCreator/UbijGoKrtotProekt/master/resursi/Screenshot_3.png)


Како тема на проектот одбравме имплементација на една постара добро познатаадиктивна аркадна игра„Whack-a-mole“. Играта е многу едноставна за учење но тешка за напредување. 
•	Со помош на маусот корисникот контролира виртуелна пушка и истата ја користи за да го убие кртот. 
•	Пушката има ограничен број куршуми после чие трошење треба да се репетира. 
•	Со тек на време кртовите стануваат побрзи и потешки за погодување.

Опис на решението:
Податоците се зачувани на следниот начин:
•	Сите користени ресурси надвор од изворниот код се чуваат во папката за ресурси „Resource1“.
•	Позицијата на кртот и неговите повикувања се чуваат во класата Mole
•	Почетното мени се наоѓа во класата Form2, тоа се состои од копчиња за почеток на игра,правила на играта, преглед на најдобри играчи и излез од играта. Истотака класата содржи тајмер со кој се анимира движењето на текстот „Македонска верзија“.
•	Во класата Form1 се содржи самата игра. До оваа форма се престигнува со притискање на копчето „Нова Игра“ во Form2. Со помош на тајмерот „vremeTimer“ се променува текстот за преостанато време додека тајмерот „timerInterval“ го содржи времето пред крај на играта. Со тајмерот randomTimeMoleсе определува брзината на кртот, а со тајмерот timerZaPcovkaи функцијата swear() се пробува неуспешна имплементација на балонче за пцовка кога играчот ке го промаши кртот.

Дел од сорс-кодот:


        privatevoid pictureBox4_Paint(object sender, PaintEventArgs e)
        {

                Graphics g = e.Graphics;
        
                    paintBullets(g);
        }

        private void paintBullets(Graphics g) {
                            nextX = 0;
                Bitmap img = newBitmap(Resource1.bullet, newSize(50, 30));
                
                for (int i = 0; i < bullets; i++)
                            {
                                g.DrawImage(img, newPoint(nextX, 0));
                                nextX = nextX + 20;
                            }
        }

        privatevoid shooting() {
        
        
                if (bullets == 1) { 
                                label3.Text= "Притисни 'Space' за наполнување на шаржерот";
                                shootingLock=false;
                }
                
                bullets = bullets - 1;
                pictureBox4.Refresh();
        }

Со овој код е представен системот на куршуми во пушката. Shooting е метода која кога е повикана доколку има куршуми испукува куршум и ја освежува сликата за куршуми, доколку бројот на куршуми е 1 одкако ќе се испука куршумот пушката заглавува и чека евент односно притискање на копчето space.

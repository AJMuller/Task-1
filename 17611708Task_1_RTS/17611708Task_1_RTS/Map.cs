using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _17611708Task_1_RTS
{
    class Map
    {
        public MeleeUnit[] MeleeEagle = new MeleeUnit[5];
        public MeleeUnit[] MeleeWolf = new MeleeUnit[5];
        public RangedUnit[] RangedEagle = new RangedUnit[5];
        public RangedUnit[] RangedWolf = new RangedUnit[5];
        private Random r = new Random();
       // private Form1 myform;
        

        public void GenerateUnits()
        {
            
            for(int x = 0; x <5; x++)
            {  

                
                MeleeEagle[x] = new MeleeUnit();
                MeleeEagle[x].Health = 50;
                MeleeEagle[x].Speed = r.Next(1,4);
                MeleeEagle[x].Symbol = "MeleeEagle.jpg";
                MeleeEagle[x].Team = "Eagles";
                MeleeEagle[x].XPosition = r.Next(0,20);
                MeleeEagle[x].YPosition = r.Next(0, 20);
                   
                
                RangedEagle[x] = new RangedUnit();
                RangedEagle[x].AttackRange = r.Next(2, 5);
                RangedEagle[x].Health = 40;
                RangedEagle[x].Speed = r.Next(1, 4);
                RangedEagle[x].Symbol = "RangedEagle.jpg";
                RangedEagle[x].Team = "Eagles";
                RangedEagle[x].XPosition = r.Next(0, 20);
                RangedEagle[x].YPosition = r.Next(0, 20);


                MeleeWolf[x] = new MeleeUnit();
                MeleeWolf[x].Health = 50;
                MeleeWolf[x].Speed = r.Next(1, 4);
                MeleeWolf[x].Symbol = "MeleeWolf.jpg";
                MeleeWolf[x].Team = "Wolves";
                MeleeWolf[x].XPosition = r.Next(0, 20);
                MeleeWolf[x].YPosition = r.Next(0, 20);

                RangedWolf[x] = new RangedUnit();
                RangedWolf[x].AttackRange = r.Next(2, 5);
                RangedWolf[x].Health = 40;
                RangedWolf[x].Speed = r.Next(1, 4);
                RangedWolf[x].Symbol = "RangedWolf.jpg";
                RangedWolf[x].Team = "Wolves";
                RangedWolf[x].XPosition = r.Next(0, 20);
                RangedWolf[x].YPosition = r.Next(0, 20);

            }
        }
        public void GenerateMap(Form myForm)
        {
            Point newLocation ;
            Size newSize ;
            int count1=0;
            for (int y= 0; y<20; y++)
            {
                count1 = count1 + 25;
                int Counter = 0;
                for(int c = 0; c<20;c++)
                {
                    string pic = "empty.jpg";
                    Counter = Counter + 25;
                    PictureBox myPictureBox = new PictureBox();

                    newLocation = new Point(Counter, count1);
                    newSize = new Size(20,20);
                    

                    myPictureBox.Location = newLocation;
                    myPictureBox.Size = newSize;

                    for (int d = 0; d< 5; d++)
                    {
                        if ((MeleeEagle[d].XPosition == c) && (MeleeEagle[d].YPosition == y))
                        {
                            pic = MeleeEagle[d].Symbol;
                        }
                        else if (RangedEagle[d].XPosition == c && RangedEagle[d].YPosition == y)
                        {
                            pic = RangedEagle[d].Symbol;
                        }
                        else if (MeleeWolf[d].XPosition == c && MeleeWolf[d].YPosition == y)
                        {
                            pic = MeleeWolf[d].Symbol;
                        }
                        else if (RangedWolf[d].XPosition == c && RangedWolf[d].YPosition == y)
                        {
                            pic = RangedWolf[d].Symbol;
                        }

                    }

                    Bitmap image = new Bitmap(pic);
                    myPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    myPictureBox.Image = (Image)image;

                  
                    
                    myForm.Controls.Add(myPictureBox);

                }

                
            }

        }
    }
}

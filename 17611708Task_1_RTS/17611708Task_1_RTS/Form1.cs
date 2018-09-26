using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17611708Task_1_RTS
{
    public partial class Form1 : Form
    {
        Map myMap = new Map();
        public Form1()
        {
            InitializeComponent();
            myMap.GenerateUnits();
            myMap.GenerateMap(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void updater()
        {
            
            for (int m = 0; m < 5; m++)
            {
                Unit Closest = myMap.MeleeEagle[0];
                double Distance = 20;
                double newDistance;
                //myMap.MeleeEagle[m]
                for (int w = 0; w < 5; w++)
                {
                    newDistance= Math.Sqrt(Math.Pow((myMap.MeleeEagle[m].XPosition - myMap.MeleeWolf[w].XPosition), 2) + Math.Pow((myMap.MeleeEagle[m].YPosition - myMap.MeleeWolf[w].YPosition), 2));
                    if(newDistance<Distance)
                    {
                        Closest = myMap.MeleeWolf[w];
                    }

                }
                for (int w = 0; w < 5; w++)
                {
                    newDistance = Math.Sqrt(Math.Pow((myMap.MeleeEagle[m].XPosition - myMap.RangedWolf[w].XPosition), 2) + Math.Pow((myMap.MeleeEagle[m].YPosition - myMap.RangedWolf[w].YPosition), 2));
                    if (newDistance < Distance)
                    {
                        Closest = myMap.RangedWolf[w];
                    }

                }
                myMap.MeleeEagle[m].Move(Closest);
                //myMap.GenerateMap(this);


            }
            for (int m = 0; m < 5; m++)
            {
                Unit Closest = myMap.RangedEagle[0];
                double Distance = 20;
                double newDistance;
                //myMap.MeleeEagle[m]
                for (int w = 0; w < 5; w++)
                {
                    newDistance = Math.Sqrt(Math.Pow((myMap.RangedEagle[m].XPosition - myMap.MeleeWolf[w].XPosition), 2) + Math.Pow((myMap.RangedEagle[m].YPosition - myMap.MeleeWolf[w].YPosition), 2));
                    if (newDistance < Distance)
                    {
                        Closest = myMap.MeleeWolf[w];
                    }

                }
                for (int w = 0; w < 5; w++)
                {
                    newDistance = Math.Sqrt(Math.Pow((myMap.RangedEagle[m].XPosition - myMap.RangedWolf[w].XPosition), 2) + Math.Pow((myMap.RangedEagle[m].YPosition - myMap.RangedWolf[w].YPosition), 2));
                    if (newDistance < Distance)
                    {
                        Closest = myMap.RangedWolf[w];
                    }

                }
                myMap.MeleeEagle[m].Move(Closest);
                myMap.GenerateMap(this);
                if(myMap.MeleeEagle[m].IsInRange(Closest))
                {
                    myMap.MeleeEagle[m].Battle(Closest);
                }


            }

        }

        private void ticker_Tick(object sender, EventArgs e)
        {
            updater();
        }

        
    }
}

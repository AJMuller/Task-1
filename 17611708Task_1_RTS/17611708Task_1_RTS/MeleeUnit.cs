using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17611708Task_1_RTS
{
    class MeleeUnit : Unit
    {
       
        

        public int Health
        {
            get { return base.health; }
            set { base.health = value; }
        }
        public int Speed
        {
            get { return base.speed ; }
            set { base.speed  = value; }
        }

        public int XPosition
        {
            get { return base.xPosition; }
            set { base.xPosition = value; }
        }
        public int YPosition
        {
            get { return base.yPosition; }
            set { base.yPosition = value; }
        }
        public int Attack
        {
            get { return base.attack; }
            set { base.attack = value; }
        }
        public int AttackRange 
        {
            set { base.attackRange = 1; }
        }
        public string Team
        {
            get { return base.team; }
            set { base.team = value; }
        }
        public string Symbol
        {
            get { return base.symbol; }
            set { base.symbol = value; }
        }

        public override void Move(Unit Enemy)
        {
            //throw new NotImplementedException();
            
            

            if (Enemy.GetType() == typeof(MeleeUnit))
            {
                MeleeUnit m = (MeleeUnit)Enemy;
                bool x = true;
                for (int d = 0; d < speed; d++)
                {


                    if (x)
                    {
                        if (XPosition < m.XPosition)
                        {
                            XPosition++;
                            x = false;

                        }
                        else if (XPosition > m.XPosition)
                        {
                            XPosition--;
                            x = false;

                        }
                        else
                        {
                            if (yPosition < m.YPosition)
                            {
                                YPosition++;
                                x = true;

                            }
                            else if (YPosition > m.YPosition)
                            {
                                YPosition--;
                                x = true;

                            }

                        }
                    }
                    else if (x == false)
                    {
                        if (yPosition < m.YPosition)
                        {
                            YPosition++;

                        }
                        else if (YPosition > m.YPosition)
                        {
                            YPosition--;

                        }

                    }


                }
            }
            else
            {

                RangedUnit m = (RangedUnit)Enemy;
                bool x = true;
                for(int d= 0; d < speed; d++)
                {
                      
                    
                    if(x)
                    {
                        if (XPosition < m.XPosition)
                        {
                            XPosition++;
                            x = false;
    
                        }
                        else if (XPosition > m.XPosition)
                        {
                             XPosition--;
                            x = false;

                        }
                        else
                        {
                            if (yPosition < m.YPosition)
                            {
                                YPosition++;
                                x = true;

                            }
                            else if (YPosition > m.YPosition)
                            {
                                YPosition--;
                                x = true;

                            }

                        }
                    }
                    else if (x == false)
                    {
                        if (yPosition < m.YPosition)
                        {
                            YPosition++;

                        }
                        else if (YPosition > m.YPosition)
                        {
                            YPosition--;

                        }

                    }
                    

                }
                





            }

            
        
            


        }

        public override void Battle(Unit enemy)
        {
            if (enemy.GetType() == typeof(MeleeUnit))
            {
                MeleeUnit m = (MeleeUnit)enemy;

                m.health = m.health - attack;

            }
            else
            {
                RangedUnit m = (RangedUnit)enemy;
                m.Health = m.Health - attack;

            }
        }

        public override void Destroy()
        {
            throw new NotImplementedException();
        }

        public override string toString()
        {
            throw new NotImplementedException();
        }

        public override Unit Closest()
        {
            throw new NotImplementedException();
        }

        public override bool IsInRange(Unit Enemy)
        {
            
            if (Enemy.GetType() == typeof(MeleeUnit))
            {
                MeleeUnit m = (MeleeUnit)Enemy;
                if (((xPosition - attackRange) >= m.XPosition) && ((xPosition + attackRange) <= m.XPosition))
                {
                    if (((yPosition - attackRange) >= m.YPosition) && ((yPosition + attackRange) <= m.YPosition))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;

                }
            }
            else
            {
                RangedUnit m = (RangedUnit)Enemy;

                if (((xPosition - attackRange ) >= m.XPosition )&&((xPosition + attackRange) <= m.XPosition))
                {
                    if (((yPosition - attackRange) >= m.YPosition) && ((yPosition + attackRange) <= m.YPosition))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;

                }
                

            }
            

            
        }

        


    }  
}

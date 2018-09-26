using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17611708Task_1_RTS
{
    abstract class Unit
    {
        protected int xPosition, yPosition, health, speed, attack, attackRange;
        protected string team, symbol;

        public Unit()
        {

        }

        abstract public void Move(Unit Enemy);
        abstract public void Battle(Unit enemy);
        abstract public bool IsInRange(Unit Enemy);
        abstract public Unit Closest();
        abstract public void Destroy();
        abstract public string toString();
            
    }
}

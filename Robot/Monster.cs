using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class Monster : Boss, IMovementPath
    {

        public Monster(string myName,int myHeart, int myAttack, int myMagic, bool myLiving)
        {
            
            Name = myName;
            HeartPeice = myHeart;
            Attack = myAttack;
            MagicPower = myMagic;
            Living = myLiving;
        }
        public List<int> startPos()
        {
            int startPosX = 0;
            int startPosY = 0;
            List<int> coordinates = new List<int>();
            coordinates[1] = startPosX;
            coordinates[2] = startPosY;
            Console.WriteLine("boss starting position: " + startPosX + "," + startPosY);
            return coordinates;
            
        }
        //time was running short so I wanted to push this to github
        public int movement()
        {
            return 0;
        }


        public void Print()
        {
            Console.WriteLine("Name: "+ Name);
            Console.WriteLine("Peices of Heart: "+ HeartPeice);
            Console.WriteLine("Attack: " + Attack);
            Console.WriteLine("Magic Power: " + MagicPower);
            Console.WriteLine("Living: " + Living);
            Console.WriteLine("HP: " + HP);
            Console.WriteLine("Evil: " + Evil);
            
            
        }
    }
}


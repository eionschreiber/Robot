using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class Monster : Boss
    {

        public Monster(string myName,int myHeart, int myAttack, int myMagic, bool myLiving)
        {
            
            Name = myName;
            HeartPeice = myHeart;
            Attack = myAttack;
            MagicPower = myMagic;
            Living = myLiving;
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


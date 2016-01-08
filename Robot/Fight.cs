using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class Fight : IMovementPath
    {
        Random rand = new Random();
        public void addAttack(Monster mont)
        {
            looseHealth(mont);
            
        }
        public void looseHealth(Monster mont)
        {
            
            mont.Health -= mont.MagicPower + mont.Attack;
        
            Console.WriteLine(mont.Name + " remaining HP after backfired attack: " + mont.Health);
            
        }

        public int moveDown()
        {
            
            throw new NotImplementedException();
        }

        public int moveLeft()
        {
            throw new NotImplementedException();
        }

        public int moveRight()
        {
            throw new NotImplementedException();
        }

        public int moveUp()
        {
            throw new NotImplementedException();
        }
    }
}

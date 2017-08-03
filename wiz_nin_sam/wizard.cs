using System;

namespace wiz_nin_sam
{
    public class Wizard: Human
    {
        public Wizard(string person): base(person) {
            intelligence = 25;
            health = 50;
        }
        
        public void heal() {
            health += 10 * intelligence;
        }

        public void fireball(object thing) {
            Human enemy = thing as Human;
            if (enemy != null) {
                Random rand = new Random();
                enemy.health -= rand.Next(20,51);
            }
        }
    }
}
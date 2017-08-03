using System;

namespace terminal_rpg
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
            Enemy enemy = thing as Enemy;
            if (enemy != null) {
                Random rand = new Random();
                enemy.health -= rand.Next(20,51);
            }
        }
    }
}
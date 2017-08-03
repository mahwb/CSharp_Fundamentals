using System;

namespace terminal_rpg
{
    public class Samurai: Human
    {
        public static int count;

        public Samurai(string person): base(person) {
            count++;
            health = 200;
        }

        public void death_blow(object thing) {
            Enemy enemy = thing as Enemy;
            if (enemy != null) {
                if (enemy.health < 50) {
                    enemy.health = 0;
                }
            }
        }

        public void meditate() {
            health = 200;
        }

        public static void how_many() {
            Console.WriteLine(count);
        }
    }
}
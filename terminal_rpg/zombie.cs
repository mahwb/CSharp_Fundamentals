namespace terminal_rpg
{
    public class Zombie: Enemy
    {
        public Zombie(string person): base(person) {
            strength = 6;
        }

        public void bite(object thing) {
            Human enemy = thing as Human;
            if (enemy != null) {
                enemy.health -= 30;
            }
        }
    }
}
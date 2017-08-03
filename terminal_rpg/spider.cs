namespace terminal_rpg
{
    public class Spider: Enemy
    {
        public Spider(string person): base(person) {
            dexterity = 5;
        }

        public void web(object thing) {
            Human enemy = thing as Human;
            if (enemy != null) {
                enemy.health -= dexterity * 2;
            }
        }
    }
}
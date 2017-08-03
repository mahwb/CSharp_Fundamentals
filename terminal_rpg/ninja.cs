namespace terminal_rpg
{
    public class Ninja: Human
    {
        public Ninja(string person): base(person) {
            dexterity = 175;
        }

        public void steal(object obj) {
            Enemy enemy = obj as Enemy;
            if (enemy != null) {
                attack(enemy);
                health += 10;
            }
        }

        public void get_away() {
            health -= 15;
        }
    }
}
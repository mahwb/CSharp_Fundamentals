using System;

namespace terminal_rpg
{
    public class Enemy 
    {
        public string name;
        public int health { get; set; }
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int dexterity { get; set; }

        public Enemy(string person)
        {
            name = person;
            strength = 5;
            intelligence = 5;
            dexterity = 5;
            health = 120;
        }

        public void attack(object obj)
        {
            Human enemy = obj as Human;
            if(enemy == null) {
                Console.WriteLine("Failed Attack");
            }
            else {
                enemy.health -= strength * 5;
            }
        }
    }
}
using System;

namespace animals
{
    public abstract class Animal
    {
        protected string name {get; set;}
        protected int weight {get; set;}
        protected int nLegs {get; set;}
        protected int health {get; set;}

        protected Animal(string name) {
            this.name = name;
            this.weight = 10;
            this.nLegs = 4;
            this.health = 100;
        }
        
        protected Animal(string name, int weight, int nLegs, int health) {
            this.name = name;
            this.weight = weight;
            this.nLegs = nLegs;
            this.health = health;
        }

        protected string Speak(string s) {
            Console.WriteLine(s);
            return s;
        }

        protected void Move(string m) {
            if (m == "jump") {
                health -= 2;
            } else if (m == "fly") {
                health += 5;
            } else {
                health -= 1;
            }
            Console.WriteLine(this.health);
        }   
    }
}
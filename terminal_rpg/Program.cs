using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

namespace terminal_rpg
{
    class Program
    {
        static void Main(string[] args)
        {   
            List<object> units = reset();
            Console.WriteLine(state(units));
            while (game(units)) {
                foreach (object unit in units) {
                    if (unit is Human) {
                        Human thing = unit as Human;
                        Console.WriteLine("What do you want to do {0}?", thing.name);
                        string InputLine = Console.ReadLine();
                        // string[] split_str = InputLine.ToLower().Split(new Char [] {' '});
                        if (InputLine == "end") {
                            Console.WriteLine("Ended turn.");
                            continue;
                        } else if (InputLine == "attack" || InputLine == "att") {
                            Console.WriteLine("Who you want to attack?");
                            string attackWho = Console.ReadLine();
                            object who = get_unit(attackWho.ToLower(), units);
                            if (who != null) {
                                thing.attack(who);
                                Enemy enemy = who as Enemy;
                                Console.WriteLine("Attacked {0}.", enemy.name);
                            }
                        } else if (InputLine == "state") { 
                            Console.WriteLine(state(units));
                        }
                    }
                }
                Console.WriteLine(state(units));
            }
        }

        // resets game state
        static List<object> reset() {
            Wizard wiz = new Wizard("Gandalf");
            Ninja nin = new Ninja("Gaiden");
            Samurai sam = new Samurai("Jack");
            Zombie zom1 = new Zombie("Zombie 1");
            Zombie zom2 = new Zombie("Zombie 2");
            Spider spi = new Spider("Shelob");

            List<object> chars = new List<object>() {wiz, nin, sam, zom1, zom2, spi};
            return chars;
        }

        static bool game(List<object> units) {
            foreach (object unit in units) {
                if (unit is Human) {
                    Human person = unit as Human;
                    if (person.health <= 0) {
                        return false;
                    } 
                } else {
                    Enemy thing = unit as Enemy;
                    if (thing.health <= 0) {
                        return false;
                    } 
                }
            }
            return true;
        }

        // returns the state of the game (unit hp)
        static string state(List<object> units) {
            string result = "";
            foreach (object unit in units) {
                if (unit is Human) {
                    Human thing = unit as Human;
                    result += thing.name + " - " + thing.health + "hp\n";
                } else {
                    Enemy thing = unit as Enemy;
                    result += thing.name + " - " + thing.health + "hp\n";
                }
            }
            return result;
        }
        
        // get unit
        static object get_unit(string name, List<object> units) {
            foreach (object unit in units) {
                if (unit is Human) {
                    Human thing = unit as Human;
                    if (thing.name.ToLower() == name) {
                        return thing;
                    }
                } else {
                    Enemy thing = unit as Enemy;
                    if (thing.name.ToLower() == name) {
                        return thing;
                    }
                }
            }
            Console.WriteLine("Can't find that unit.");
            return null;
        }

        // ask questions
        static void askQuestions() {

        }
    }
}

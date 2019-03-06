using System;

namespace survive_the_night
{
    abstract class Character
    {
        public string name {get; set;}
        public int health {get;set;}
        public string skill {get;set;}
        public int attackPower {get;set;}
        public int runPower {get;set;}
        public bool IsEvent {get;set;}
        public int eventTimer {get;set;}
        public string description {get;set;}
        public string abilityDesc {get;set;}

        public Character()
        {
        }

        abstract public void GetInfo();
        abstract public void EventSet();
        abstract public void Skill(Monster monster);
        // abstract public int Attack();
        // abstract public bool Run();
        
        public virtual int Attack(Character monster)
        {
            Random rand = new Random();
            int dmg = rand.Next(3*attackPower/4, attackPower);
            monster.health -= dmg;
            System.Console.WriteLine($"Attacked {monster.name} for {dmg} damage");
            System.Console.WriteLine($"{monster.name} has {monster.health} remaining");
            return monster.health;
        }

        public bool Run()
        {
            Random rand = new Random();
            if (rand.Next(runPower) == 0)
                return true;
            return false;
        }
    }
}
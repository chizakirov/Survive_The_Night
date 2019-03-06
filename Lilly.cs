using System;

namespace survive_the_night
{
    class Lilly: Character
    {
        public Monster charmedMonster{get;set;}

        public Lilly()
        {
            health = 75;
            skill = "charm monster";
            name = "Lilly";
            attackPower = 10;
            runPower = 2;
            charmedMonster = null;
            description = 
                "Cute, small, girl in a cold, hard, world. Lilly got separated from her parents last night and the mists\n are beginning to rise.";
            abilityDesc = 
                "Lilly's charming nature gives her a shot at ingratiating her with even the meanest of foes. If\n she suceeds in charming a monster, she can keep it as a fighting pet for a time.";
        }

        public override int Attack(Character monster)
        {
            if(charmedMonster == null)
                return(base.Attack(monster));

            Random rand = new Random();
            int dmg = rand.Next(3*charmedMonster.attackPower/4, charmedMonster.attackPower);
            monster.health -= dmg;
            System.Console.WriteLine($"Attacked for {dmg} damage");
            System.Console.WriteLine($"Monster has {monster.health} remaining");
            return monster.health;
    
        }   

        public override void GetInfo()
        {
            System.Console.WriteLine($"Name: {name}\n\n\rHealth: {health}\n\n\rSkill: {skill}\n\n\r Description: {description}\n\n\r Skill Desc: {abilityDesc}");
        }

        public override void EventSet()
        {   
            charmedMonster = null;
            base.IsEvent = false;
        }

        public override void Skill(Monster monster)
        {   
            if(charmedMonster != null)
                {
                System.Console.WriteLine("Don't be greedy");
                return;
                }
            if(monster.name == "Godzilla")
                System.Console.WriteLine("Are you serious?");
            else
            {
                Random rand = new Random();
                if (rand.Next(2) == 0)
                    charmedMonster = monster;
            }
            base.eventTimer = 4;
            base.IsEvent = true;
            
        }
    }
}
namespace survive_the_night
{
    abstract class Monster : Character
    {
        public int rarity {get;set;}
    }

    class ShadowThing: Monster
    {
        public ShadowThing()
        {
            rarity = 4;
            name = "Shadow Thing";
            health = 90;
            attackPower = 80;
            description = 
                "Better stay in the light, no telling in what shade the shadow thing lurks. It's invisible tendrils will cradle you do to death before you know it even there";
        }

        public override void GetInfo()
        {
            System.Console.WriteLine($"Name: {name}\n\rHealth: {health}\n\r Description: {description}\n\r");
        }
        public override void EventSet(){}
        public override void Skill(Monster monster){}

    }
    
    class Godzilla: Monster
    {
        public Godzilla()
        {
            rarity = 15;
            name = "Godzilla";
            health = 2000;
            attackPower = 500;
            description = "You're screwed!! Better run!";
        }

        public override void GetInfo()
        {
            System.Console.WriteLine($"Name: {name}\n\rHealth: {health}\n\r Description: {description}\n\r");
        }
        public override void EventSet(){}
        public override void Skill(Monster monster){}

    }
    class MysteryGhost: Monster
    {
        public MysteryGhost()
        {
            rarity = 7;
            name = "MysteryGhost";
            health = 50;
            attackPower = 40;
            description = 
                "Look! It's Tommy, the headless ghost of the boy who stood up on the roller coaster 30 years ago. He looks sadly at you";
        }

        public override void GetInfo()
        {
            System.Console.WriteLine($"Name: {name}\n\rHealth: {health}\n\r Description: {description}\n\r");
        }
        public override void EventSet(){}
        public override void Skill(Monster monster){}

    }
    class Union: Monster
    {
        public Union()
        {
            rarity = 10;
            name = "Union of Disgruntled Roller Coaster Operators";
            health = 150;
            attackPower = 10;
            description = 
                "Legion of prebuscent angry pimpled gangly teenagers. They are chewing a lot of bubblegum, and and here for long awaited revenge.";
        }

        public override void GetInfo()
        {
            System.Console.WriteLine($"Name: {name}\n\rHealth: {health}\n\r Description: {description}\n\r");
        }
        public override void EventSet(){}
        public override void Skill(Monster monster){}

    }
    class SpiderHorde: Monster
    {
        public SpiderHorde()
        {
            rarity = 6;
            name = "Horde of Tiny Spiders";
            health = 30;
            attackPower = 60;
            description = "AHHH!! Spider's everywhere!";
        }

        public override void GetInfo()
        {
            System.Console.WriteLine($"Name: {name}\n\rHealth: {health}\n\r Description: {description}\n\r");
        }
        public override void EventSet(){}
        public override void Skill(Monster monster){}
    }
    
}

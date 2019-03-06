
namespace survive_the_night
{
    class Luffy: Character
    {
        public bool axe {get;set;}

        public Luffy()
        {
            health = 200;
            skill = "throw axe";
            name = "Luffy";
            attackPower = 40;
            runPower = 5;
            axe = true;
            description = 
                "Luffy wandered down from the nearby mountain in search of the fabled three horned goat.\nNow he's lost in the maze of haunted clowns and decrepit roller coasters, with nothing but\n his axe and rugged good looks to save him";
            abilityDesc = 
                "Luffy may throw his heavy axe to instantly kill any monster he runs across, but cannot use it\n again until he finds it in 3 hours";
            
        }

        public override void GetInfo()
        {
            System.Console.WriteLine($"Name: {name}\n\n\rHealth: {health}\n\n\rSkill: {skill}\n\n\r Description: {description}\n\n\r Skill Desc: {abilityDesc}");
        }

        public override void EventSet()
        {   
            axe = true;
            base.IsEvent = false;
        }

        public override void Skill(Monster monster)
        {   
            if(!axe)
                {
                System.Console.WriteLine("No axe to throw");
                return;
                }
            if(monster.name == "Godzilla")
                System.Console.WriteLine("Are you serious?");
            else
                monster.health = 0;
            axe = false;
            base.eventTimer = 3;
            base.IsEvent = true;
            
        }
    }
}
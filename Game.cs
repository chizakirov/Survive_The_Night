using System;
using System.Collections.Generic;

namespace survive_the_night
{
    class Game
    {   
        private string player {get;set;}
        private int hour {get;set;}
        public Character character {get;set;}
        public List<Monster> monsters {get;set;}
        public Character[] characters {get;set;}
        private int battleTurn {get;set;}
        public Game(string playerName)
        {
            player = playerName;
            hour = 0;
            battleTurn = 2;
            characters = new Character[]
            {
                new Lilly(),
                new Luffy()
            };

            monsters = new List<Monster>
            {
                new Godzilla(),
                new ShadowThing(),
                new SpiderHorde(),
                new MysteryGhost(),
                new Union()
            };
        }
        public void ChooseCharacter()
        {
            Console.Clear();
            Console.WriteLine("Choose Your Character:\n\r\n\r Lilly \n\r Luffy");
            Character selectedCharacter = null;
            string input = Console.ReadLine();
            for (int i = 0; i < characters.Length; i++)
            {
                if (characters[i].name == input)
                    selectedCharacter = characters[i];
            }
            if (selectedCharacter == null)
                {
                System.Console.WriteLine("not a character, try again");
                Console.Clear();
                ChooseCharacter();
                }
            DisplayCharacter(selectedCharacter);
        }

        public void DisplayCharacter(Character Character)
        {   
            Console.Clear();
            Character.GetInfo();
            System.Console.WriteLine("\n\n\n Hit enter to continue or type n to go back");
            if (Console.ReadLine() == "n")
                ChooseCharacter();
            else character = Character;
                EnterGame();
        }

        public void EnterGame()
        {
            Console.Clear();
            System.Console.WriteLine(
                "A cold wind rises. A rusted metal metropolis of broken amusement rides litters the landscape. The\n last rays of light for the day begin to fade away, and they bring what remains of your hope with\n it\n\n\n");
            System.Console.WriteLine("###############     SURVIVE THE NIGHT        #################");
            System.Console.WriteLine("Press ENTER if you dare");
            string input = Console.ReadLine();
            nextHour();
        }

        public void checkCharacterEvents()
        {
            if (character.IsEvent )
                if(character.eventTimer == 0) 
                    character.EventSet();
                else 
                    character.eventTimer -= 1;
        }

        public void nextHour()
        {
            battleTurn = 2;
            hour  += 1;
            checkCharacterEvents();
            Console.Clear();
            Random rand = new Random();

            foreach (Monster monster in monsters)
            {
                if (rand.Next(monster.rarity) == 0)
                {
                    Battle(monster);
                    return;
                }
               
            }
            System.Console.WriteLine("You caught a break. Lucky You. No monsters found you this hour");
            Console.ReadLine();
            nextHour();
            
        }

        private void Battle(Monster monster)
        {

            monster.GetInfo();

            if (monster.health <= 0)
            {   
                monsters.Remove(monster);
                System.Console.WriteLine("You scraped by this time\n\n Hit enter to see how the next on turns out");
                Console.ReadLine();
                nextHour();
            }

            if (battleTurn%2 == 0)
            {
                battleTurn++;
                System.Console.WriteLine($"\n\n\r Scared Yet?Type 'attack' to attack, 'run' to run, or skillto use {character.skill}");
                string input = Console.ReadLine();
                if (input == "attack")
                {
                    character.Attack(monster);
                    Battle(monster);
                }
                if (input == "run")
                {
                    if(character.Run())
                        nextHour();
                    else
                        Battle(monster);
                }
                if (input == "skill")
                {
                    character.Skill(monster);
                    Battle(monster);
                }
            }

            else
            {
                monster.Attack(character);
                battleTurn++;
                Battle(monster);
            }
            


        }       
    }
}
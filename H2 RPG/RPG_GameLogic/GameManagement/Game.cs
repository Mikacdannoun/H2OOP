using RPG_GameLogic.Enum;
using RPG_GameLogic.Units;
using System.Security.Cryptography.X509Certificates;

namespace RPG_GameLogic.GameManagement
{
    public class Game
    {
        private Player player;
        private Enemy[] bots;
        private int numOfBots = 3;

        public Game() 
        {
            player = new Player();
            bots = new Enemy[numOfBots];
            for (int i = 0; i < numOfBots; i++)
            {
                bots[i] = new Enemy();
            }
        }

        public async Task Start()
        {
            Console.WriteLine("Welcome to Rock-Paper-Scissors RPG!");
            
            while(player.Health > 0)
            {
                for (int i = 0; i < numOfBots; i++)
                {
                    Console.WriteLine($"Fight with Enemy {i + 1}");
                    FightWithBot(i);
                    if (player.Health <= 0)
                    {
                        break;
                    }
                    Console.WriteLine($"You Defeated Bot {i + 1}!\n");
                }

                Console.WriteLine("You defeated the bots!!!");

            }
            
        }

        private void FightWithBot(int botIndex)
        {
            while (bots[botIndex].Health > 0 && player.Health > 0)
            {
                Thread playerThread = new Thread(() =>
                {
                    lock (player)
                    {
                        //Choose PowerUp
                        player.ChoosePowerUp();
                    }

                    lock (player)
                    {
                        //Choose Move
                        player.ChooseAction();
                    }
                });

                Thread botThread = new Thread(() =>
                {
                    lock (bots[botIndex])
                    {
                        //enemy chooses action
                        bots[botIndex].ChooseAction();
                    }
                });

                playerThread.Start();
                botThread.Start();
                playerThread.Join();
                botThread.Join();

                Console.WriteLine($"the player chose: {player.CurrentChoice} while the enemy chose {bots[botIndex].CurrentChoice}");

                int result = DetermineWinner(player.CurrentChoice, bots[botIndex].CurrentChoice);
                if (result == 1)
                {
                    bots[botIndex].TakeDamage(player.Strength);
                    player.ShowStrength();
                }
                else if (result == -1)
                {
                    if (player.HasRerollPowerUp)
                    {
                        Console.WriteLine("Player used reroll power-up! The round is a draw.");
                    }
                    else
                    {
                        player.TakeDamage(bots[botIndex].Strength);
                    }
                }
                else
                {
                    Console.WriteLine("This round was a draw");
                }

                player.HasRerollPowerUp = false;
                player.Strength = 1;
                Console.WriteLine($"the player chose: {player.CurrentChoice} while the enemy chose {bots[botIndex].CurrentChoice}");
                Console.WriteLine();
                Console.WriteLine($"Player Health: {player.Health}");
                Console.WriteLine($"Enemy {botIndex + 1} Health: {bots[botIndex].Health}");
            }
            Console.Clear();
        }

        private int DetermineWinner (Choice playerChoice, Choice enemyChoice)
        {
            if (playerChoice == enemyChoice)
            {
                return 0; // Draw
            }
            else if ((playerChoice == Choice.Rock && enemyChoice == Choice.Scissors) ||
                     (playerChoice == Choice.Paper && enemyChoice == Choice.Rock) ||
                     (playerChoice == Choice.Scissors && enemyChoice == Choice.Paper))
            {
                return 1; // Player wins
            }
            else
            {
                return -1; // Bot wins
            }
        }

    }
}

using RPG_GameLogic.Classes;
using RPG_GameLogic.Enum;
using RPG_GameLogic.Interfaces;
using RPG_GameLogic.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPG_GameLogic.Units
{
    public class Player : Character
    {
        public int Strength { get; set; }
        public bool HasRerollPowerUp { get; set; }

        private Strength strengthPowerUp = new Strength();
        private Reroll rerollPowerUp = new Reroll();

        public override void ChooseAction()
        {
            Console.WriteLine("Choose your action (1 for Rock, 2 for Paper, 3 for Scissors");
            int choice = Convert.ToInt32(Console.ReadLine());
            CurrentChoice = (Choice)choice - 1;
        }

        public override void ChoosePowerUp()
        {
            Console.WriteLine("Choose your PowerUp (1 for Reroll, 2 for Strength");
            int powerUpChoice = Convert.ToInt32(Console.ReadLine());
            PowerUpChoice = (PowerUpType)powerUpChoice -1;

            if (PowerUpChoice == PowerUpType.Strength) 
            {
                ApplyStrengthPowerUp();
            }
            else if (PowerUpChoice == PowerUpType.Reroll)
            {
                ApplyRerollPowerUp();
            }
        }

        private void ApplyStrengthPowerUp()
        {
            strengthPowerUp.ApplyPowerUp();

            Strength += 1;
            Console.WriteLine($"Current strength is {Strength}");
        }

        private void ApplyRerollPowerUp()
        {
            rerollPowerUp.ApplyPowerUp();
            HasRerollPowerUp = true;
        }

        public void ShowStrength()
        {
            Console.WriteLine(Strength);
        }

        public override void TakeDamage(int enemyStrength)
        {
            Health -= enemyStrength;
        }



        public Player()
        {
            Health = 3;
            Strength = 1;
        }

    }
}

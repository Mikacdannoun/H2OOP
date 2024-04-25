using RPG_GameLogic.Classes;
using RPG_GameLogic.Enum;
using RPG_GameLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_GameLogic.Units
{
    internal class Enemy : Character
    {
        public int Strength { get; protected set; }

        public override void ChooseAction()
        {
            Random rand = new Random();
            CurrentChoice = (Choice)rand.Next(0, 3);
        }

        public override void ChoosePowerUp()
        {
            Console.WriteLine("No PowerUps for enemies");
        }

        public override void TakeDamage(int playerStrength)
        {
            Health -= playerStrength;
        }

        public Enemy()
        {
            Health = 3;
            Strength = 1;
        }
    }
}

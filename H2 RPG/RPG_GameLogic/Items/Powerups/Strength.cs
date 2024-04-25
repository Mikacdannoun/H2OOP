using RPG_GameLogic.Interfaces;
using RPG_GameLogic.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_GameLogic.Items.Weapons
{
    public class Strength : IPowerUp
    {
        public void ApplyPowerUp()
        {
            Console.WriteLine("If you hit your next attack it deals double damage!");
        }
    }
}

using RPG_GameLogic.Interfaces;
using RPG_GameLogic.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_GameLogic.Items.Weapons
{
    public class Reroll : IPowerUp
    {
        public void ApplyPowerUp()
        {

            Console.WriteLine("Any loss will now become a draw");
        }
    }
}

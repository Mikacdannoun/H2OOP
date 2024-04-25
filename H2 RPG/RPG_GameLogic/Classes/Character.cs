using RPG_GameLogic.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_GameLogic.Classes
{
    public abstract class Character
    {
        public Choice CurrentChoice { get; set; }

        public PowerUpType PowerUpChoice { get; set; }

        public int Health { get; protected set; }

        public abstract void ChooseAction();

        public abstract void ChoosePowerUp();

        public abstract void TakeDamage(int opponentStrength);
    }
}

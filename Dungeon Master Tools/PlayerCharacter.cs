using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Master_Tools
{
    class PlayerCharacter
    {
        public string name;
        public int level;
        public int experience;
        public int currentHitPoints;
        public int hitPoints;
        public int armorClass;
        public string race;
        public string primaryClass;
        public string subClass;
        public bool active;

        public PlayerCharacter(string name, string race, string primaryClass, int level, int hitPoints, int armorClass)
        {
            this.name = name;
            this.race = race;
            this.primaryClass = primaryClass;
            this.level = level;
            this.hitPoints = hitPoints;
            currentHitPoints = hitPoints;
            this.armorClass = armorClass;
            subClass = null;
            active = true;
        }

        public PlayerCharacter()
        {
            name = null;
            race = null;
            primaryClass = null;
            subClass = null;
            level = 0;
            hitPoints = 0;
            currentHitPoints = 0;
            armorClass = 0;
            experience = 0;
            active = true;
        }

    }
}

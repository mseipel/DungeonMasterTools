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
        public int primaryClassLevel;
        public int subClassLevel;
        public int experience;
        public int currentHitPoints;
        public int hitPoints;
        public int armorClass;
        public string race;
        public string primaryClass;
        public string subClass;
        public bool active;

        public PlayerCharacter(string name, string race, string primaryClass, int primaryClassLevel, string subClass, int subClassLevel, int hitPoints, int armorClass)
        {
            this.name = name;
            this.race = race;
            this.primaryClass = primaryClass;
            this.primaryClassLevel = primaryClassLevel;
            this.hitPoints = hitPoints;
            currentHitPoints = hitPoints;
            this.armorClass = armorClass;
            this.subClass = subClass;
            this.subClassLevel = subClassLevel;
            active = true;
        }

        public PlayerCharacter()
        {
            name = null;
            race = null;
            primaryClass = null;
            subClass = null;
            subClassLevel = 0;
            primaryClassLevel = 0;
            hitPoints = 0;
            currentHitPoints = 0;
            armorClass = 0;
            experience = 0;
            active = true;
        }

        public override string ToString()
        {
            return String.Format("{0},{1},{2}-{3}/{4}-{5},{6}/{7},{8}", name, race, primaryClass, primaryClassLevel, subClass, subClassLevel, currentHitPoints, hitPoints, armorClass);
        }

    }
}

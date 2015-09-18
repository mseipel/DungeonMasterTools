using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Master_Tools
{
    class NonPlayerCharacter
    {
        public string name;
        public int level;
        public int hitPoints;
        public int armorClass;
        private string race { get; set; }
        private string primaryClass { get; set; }
        private string subClass { get; set; }

        public NonPlayerCharacter(string name, string race, string primaryClass, int level, int hitPoints, int armorClass)
        {
            this.name = name;
            this.race = race;
            this.primaryClass = primaryClass;
            this.level = level;
            this.hitPoints = hitPoints;
            this.armorClass = armorClass;
            subClass = null;
        }

        public NonPlayerCharacter()
        {
            name = null;
            race = null;
            primaryClass = null;
            subClass = null;
            level = 0;
            hitPoints = 0;
            armorClass = 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Master_Tools
{
    static class GameManagement
    {
        public static List<PlayerCharacter> playerCharacters;
        static List<NonPlayerCharacter> npcs;
        public static Dictionary<int, int> levelChart = new Dictionary<int, int>();

        public static bool Initialize()
        {
            //If saved file does not exist, create it and initialize everything as a fresh game.
            playerCharacters = new List<PlayerCharacter>();
            npcs = new List<NonPlayerCharacter>();
            return true;
        }

        public static bool PopulateLevelChart()
        {
            levelChart.Add(1, 0);
            levelChart.Add(2, 300);
            levelChart.Add(3, 900);
            levelChart.Add(4, 2700);
            levelChart.Add(5, 6500);
            levelChart.Add(6, 14000);
            levelChart.Add(7, 23000);
            levelChart.Add(8, 34000);
            levelChart.Add(9, 48000);
            levelChart.Add(10, 64000);
            levelChart.Add(11, 85000);
            levelChart.Add(12, 100000);
            levelChart.Add(13, 120000);
            levelChart.Add(14, 140000);
            levelChart.Add(15, 165000);
            levelChart.Add(16, 195000);
            levelChart.Add(17, 225000);
            levelChart.Add(18, 265000);
            levelChart.Add(19, 305000);
            levelChart.Add(20, 355000);
            return true;
        }
    }
}

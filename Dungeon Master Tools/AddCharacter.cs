using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dungeon_Master_Tools
{
    public partial class AddCharacter : Form
    {
        public AddCharacter()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (CreateCharacter())
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Error in Character Creation.");
            }
        }

        private bool CreateCharacter()
        {
            PlayerCharacter player = new PlayerCharacter();
            player.name = CharacterNameTextBox.Text;
            player.race = CharacterRaceTextBox.Text;
            player.primaryClass = CharacterClassTextBox.Text;
            player.subClass = null;
            player.armorClass = (int)CharacterArmorClassNum.Value;
            player.hitPoints = (int)CharacterHitPointsNum.Value;
            player.currentHitPoints = (int)CharacterHitPointsNum.Value;
            player.level = Convert.ToInt32(CharacterArmorClassNum.Value);
            GameManagement.playerCharacters.Add(player);
            return true;
        }
    }
}

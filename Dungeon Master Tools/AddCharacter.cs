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
        }

        private bool CreateCharacter()
        {
            PlayerCharacter player = new PlayerCharacter();
            try
            {
                //Name
                if (CharacterNameTextBox.Text == String.Empty)
                {
                    throw new NoNullAllowedException("Name cannot be empty");
                }
                else
                {
                    player.name = CharacterNameTextBox.Text;
                }

                //Race
                if (CharacterRaceTextBox.Text == String.Empty)
                {
                    throw new NoNullAllowedException("Race cannot be empty");
                }
                else
                {
                    player.race = CharacterRaceTextBox.Text;
                }

                //Class and Subclass
                if (CharacterClassTextBox.Text == String.Empty)
                {
                    throw new NoNullAllowedException("Class cannot be empty");
                }
                else
                {
                    player.primaryClass = CharacterClassTextBox.Text;
                    player.subClass = null;
                }

                //Get number values
                player.armorClass = (int)CharacterArmorClassNum.Value;
                player.hitPoints = (int)CharacterHitPointsNum.Value;
                player.currentHitPoints = (int)CharacterHitPointsNum.Value;
                player.level = Convert.ToInt32(CharacterArmorClassNum.Value);

                //Create player
                GameManagement.playerCharacters.Add(player);
                return true;
            }
            catch(NoNullAllowedException e){
                MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}

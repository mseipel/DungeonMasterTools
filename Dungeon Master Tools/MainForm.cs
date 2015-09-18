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
    public partial class MainForm : Form
    {
        const int PLAYER_PANEL_WIDTH = 200;
        const int PLAYER_NAME_TOP = 5;
        const int PLAYER_HPL_TOP = 30;
        const int PLAYER_HPD_TOP = 28;
        const int PLAYER_HPD_LEFT = 35;

        public MainForm()
        {
            GameManagement.Initialize();
            InitializeComponent();
        }

        private void AddPlayerButton_Click(object sender, EventArgs e)
        {
            var form = new AddCharacter();
            form.ShowDialog(this);
            RefreshPlayerCharactersPanel();
        }

        public void RefreshPlayerCharactersPanel()
        {
            PopulatePlayerCharactersPanel();
            PlayerCharacterPanel.Refresh();
        }

        public void PopulatePlayerCharactersPanel()
        {
            if(GameManagement.playerCharacters.Count != 0)
            {
                PlayerCharacter player = GameManagement.playerCharacters[GameManagement.playerCharacters.Count-1];

                //New display panel per player
                Panel newPanel = new Panel();
                newPanel.Name = String.Format("NewPanel{0}", GameManagement.playerCharacters.Count);
                newPanel.BorderStyle = BorderStyle.FixedSingle;
                newPanel.AutoSize = true;
                newPanel.Parent = PlayerCharacterPanel;
                newPanel.Width = PLAYER_PANEL_WIDTH;

                //Display Player Information
                Label charName = new Label();
                charName.Name = "CharName";
                charName.Text = player.name;
                charName.Parent = newPanel;
                charName.Top += PLAYER_NAME_TOP;
             
                //Hit points
                Label hpL = new Label();
                hpL.Name = "HPLabel";
                hpL.Text = "HP:";
                hpL.Parent = newPanel;
                hpL.Width = 30;
                hpL.Top += PLAYER_HPL_TOP;
                NumericUpDown hpD = new NumericUpDown();
                hpD.Name = "HPDisplay";
                hpD.Value = player.hitPoints;
                hpD.Parent = newPanel;
                hpD.Width = 35;
                hpD.Top += PLAYER_HPD_TOP;
                hpD.Left += PLAYER_HPD_LEFT;

                //Move Button
                AddPlayerButton.Top += newPanel.Height + 5;

                //Show components
                newPanel.Show();
                charName.Show();
                hpL.Show();
                hpD.Show();
            }
        }
    }
}

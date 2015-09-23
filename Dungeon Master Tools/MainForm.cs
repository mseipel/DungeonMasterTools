﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dungeon_Master_Tools
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            GameManagement.Initialize();
            InitializeComponent();
        }

        private void AddPlayerButton_Click(object sender, EventArgs e)
        {
            var form = new AddCharacter();
            form.ShowDialog(this);
            AddPlayerCharacterToPanel();
        }

        private void HealPlayerButton_Click(object sender, EventArgs e)
        {
            //Get control objects needed
            Button b = (Button)sender;
            int playerIndex = Convert.ToInt32(b.Name.Substring(b.Name.Length - 1));
            TextBox hpMod = this.PlayerCharacterPanel.Controls.Find("HPModTextBox" + playerIndex, true).FirstOrDefault() as TextBox;
            
            //Get Player
            PlayerCharacter player = GameManagement.playerCharacters[playerIndex];
            player.currentHitPoints += Convert.ToInt32(hpMod.Text);
            
            //Update HPDisp
            Label hpDisp = this.PlayerCharacterPanel.Controls.Find("HPDisp" + playerIndex, true).FirstOrDefault() as Label;
            hpDisp.Text = String.Format("HP: {0}/{1}", player.currentHitPoints, player.hitPoints);
        }

        private void DamagePlayerButton_Click(object sender, EventArgs e)
        {
            //Get control objects needed
            Button b = (Button)sender;
            int playerIndex = Convert.ToInt32(b.Name.Substring(b.Name.Length - 1));
            TextBox hpMod = this.PlayerCharacterPanel.Controls.Find("HPModTextBox" + playerIndex, true).FirstOrDefault() as TextBox;

            //Get Player
            PlayerCharacter player = GameManagement.playerCharacters[playerIndex];
            player.currentHitPoints -= Convert.ToInt32(hpMod.Text);

            //Update HPDisp
            Label hpDisp = this.PlayerCharacterPanel.Controls.Find("HPDisp" + playerIndex, true).FirstOrDefault() as Label;
            hpDisp.Text = String.Format("HP: {0}/{1}", player.currentHitPoints, player.hitPoints);
        }

        public bool AddPlayerCharacterToPanel()
        {
            if(GameManagement.playerCharacters.Count != 0)
            {
                int playerIndex = GameManagement.playerCharacters.Count-1;
                PlayerCharacter player = GameManagement.playerCharacters[playerIndex];

                if (this.PlayerCharacterPanel.Controls.Find("pcPanel" + player.name, true).Count() > 0)
                {
                    return false;
                }

                Panel pcPanel1 = new Panel();
                pcPanel1.Parent = this.PlayerCharacterPanel;
                
                Label CharNameDisp = new Label();
                Label RaceClassDisp = new Label();
                Button MoreInfoButton = new Button();
                Label ArmorClassDisp = new Label();
                Label LevelDisp = new Label();
                Label HPDisp = new Label();
                Button DamageBtn = new Button();
                Button HealButton = new Button();
                TextBox HPModTextBox = new TextBox();
                
                // 
                // pcPanel1
                // 
                pcPanel1.Controls.Add(DamageBtn);
                pcPanel1.Controls.Add(HealButton);
                pcPanel1.Controls.Add(HPModTextBox);
                pcPanel1.Controls.Add(MoreInfoButton);
                pcPanel1.Controls.Add(ArmorClassDisp);
                pcPanel1.Controls.Add(LevelDisp);
                pcPanel1.Controls.Add(HPDisp);
                pcPanel1.Controls.Add(RaceClassDisp);
                pcPanel1.Controls.Add(CharNameDisp);
                pcPanel1.Location = new System.Drawing.Point(3, 3);
                pcPanel1.Name = "pcPanel" + player.name;
                pcPanel1.Size = new System.Drawing.Size(219, 82);
                pcPanel1.TabIndex = 0;
                
                // 
                // CharNameDisp
                // 
                CharNameDisp.AutoSize = true;
                CharNameDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
                CharNameDisp.Location = new System.Drawing.Point(4, 4);
                CharNameDisp.Name = "CharNameDisp" + playerIndex;
                CharNameDisp.Size = new System.Drawing.Size(91, 20);
                CharNameDisp.TabIndex = 0;
                CharNameDisp.Text = player.name;
                CharNameDisp.Parent = pcPanel1;
                CharNameDisp.Show();
                
                // 
                // RaceClassDisp
                // 
                RaceClassDisp.AutoSize = true;
                RaceClassDisp.Location = new System.Drawing.Point(5, 39);
                RaceClassDisp.Name = "RaceClassDisp" + playerIndex;
                RaceClassDisp.Size = new System.Drawing.Size(70, 13);
                RaceClassDisp.TabIndex = 1;
                
                if(player.subClass == null)
                {
                    RaceClassDisp.Text = String.Format("{0}, {1}", player.race, player.primaryClass);
                }
                else
                {
                    RaceClassDisp.Text = String.Format("{0}, {1}/{2}", player.race, player.primaryClass, player.subClass);
                }
                
                RaceClassDisp.Parent = pcPanel1;
                RaceClassDisp.Show();
                
                // 
                // HPDisp
                // 
                HPDisp.AutoSize = false;
                HPDisp.Location = new System.Drawing.Point(139, 39);
                HPDisp.Name = "HPDisp" + playerIndex;
                HPDisp.Size = new System.Drawing.Size(77, 13);
                HPDisp.TabIndex = 2;
                HPDisp.Text = String.Format("HP: {0}/{1}", player.currentHitPoints, player.hitPoints);
                HPDisp.TextAlign = ContentAlignment.MiddleRight;
                HPDisp.Parent = pcPanel1;
                HPDisp.Show();
                
                // 
                // LevelDisp
                // 
                LevelDisp.AutoSize = true;
                LevelDisp.Location = new System.Drawing.Point(5, 26);
                LevelDisp.Name = "LevelDisp" + playerIndex;
                LevelDisp.Size = new System.Drawing.Size(45, 13);
                LevelDisp.TabIndex = 3;
                LevelDisp.Text = String.Format("Level: {0}", player.primaryClassLevel);
                LevelDisp.Parent = pcPanel1;
                LevelDisp.Show();

                // 
                // ArmorClassDisp
                // 
                ArmorClassDisp.AutoSize = false;
                ArmorClassDisp.Location = new System.Drawing.Point(139, 26);
                ArmorClassDisp.Name = "ArmorClassDisp" + playerIndex;
                ArmorClassDisp.Size = new System.Drawing.Size(77, 13);
                ArmorClassDisp.TabIndex = 4;
                ArmorClassDisp.Text = String.Format("AC: {0}", player.armorClass);
                ArmorClassDisp.TextAlign = ContentAlignment.MiddleRight;
                ArmorClassDisp.Parent = pcPanel1;
                ArmorClassDisp.Show();

                // 
                // MoreInfoButton
                // 
                MoreInfoButton.Location = new System.Drawing.Point(8, 52);
                MoreInfoButton.Name = "MoreInfoButton" + playerIndex;
                MoreInfoButton.Size = new System.Drawing.Size(35, 23);
                MoreInfoButton.TabIndex = 5;
                MoreInfoButton.Text = "...";
                MoreInfoButton.UseVisualStyleBackColor = true;
                MoreInfoButton.Parent = pcPanel1;
                MoreInfoButton.Show();
                
                // 
                // HealButton
                // 
                HealButton.Location = new System.Drawing.Point(131, 52);
                HealButton.Name = "HealButton" + playerIndex;
                HealButton.Size = new System.Drawing.Size(20, 23);
                HealButton.TabIndex = 7;
                HealButton.Text = "+";
                HealButton.UseVisualStyleBackColor = true;
                HealButton.Parent = pcPanel1;
                HealButton.Click += new System.EventHandler(this.HealPlayerButton_Click);
                HealButton.Show();
                
                // 
                // DamageBtn
                // 
                DamageBtn.Location = new System.Drawing.Point(195, 52);
                DamageBtn.Name = "DamageBtn" + playerIndex;
                DamageBtn.Size = new System.Drawing.Size(20, 23);
                DamageBtn.TabIndex = 8;
                DamageBtn.Text = "-";
                DamageBtn.UseVisualStyleBackColor = true;
                DamageBtn.Parent = pcPanel1;
                DamageBtn.Click += new System.EventHandler(this.DamagePlayerButton_Click);
                DamageBtn.Show();
                
                // 
                // HPModTextBox
                // 
                HPModTextBox.Location = new System.Drawing.Point(152, 54);
                HPModTextBox.Name = "HPModTextBox" + playerIndex;
                HPModTextBox.Size = new System.Drawing.Size(43, 20);
                HPModTextBox.TabIndex = 6;
                HPModTextBox.Parent = pcPanel1;
                HPModTextBox.Show();

                //Cleanup
                CharNameDisp = null;
                RaceClassDisp = null;
                MoreInfoButton = null;
                ArmorClassDisp = null;
                LevelDisp = null;
                HPDisp = null;
                DamageBtn = null;
                HealButton = null;
                HPModTextBox = null;
            }

            return true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text file (.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog1.Title = "Save Game";
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.FileName = "DnD_Campaign";
            saveFileDialog1.ShowDialog();
            string path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal),"DungeonMasterTools",saveFileDialog1.FileName);

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@path))
                {
                    file.WriteLine("##########PLAYERS##########");
                    foreach (PlayerCharacter p in GameManagement.playerCharacters)
                    {
                        file.WriteLine(p.ToString());
                    }
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream s;
            StreamReader sr;
            string line;
            string[] splitLine;
            string section = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((s = openFileDialog1.OpenFile()) != null)
                    {
                        using (sr = new StreamReader(s))
                        {
                            while ((line = sr.ReadLine()) != null)
                            {
                                if (line.Contains('#'))
                                {
                                    splitLine = line.Split('#');
                                    for (int i = 0; i < splitLine.Length; i++)
                                    {
                                        if (!String.Empty.Equals(splitLine[i]))
                                        {
                                            section = splitLine[i];
                                        }
                                    }
                                }
                                else if (line.Contains(','))
                                {
                                    splitLine = line.Split(',');

                                    if (section.Equals("PLAYERS"))
                                    {
                                        PlayerCharacter p = new PlayerCharacter();
                                        p.name = splitLine[0];
                                        p.race = splitLine[1];
                                        p.primaryClass = splitLine[2].Split('/')[0].Split('-')[0];
                                        p.primaryClassLevel = Convert.ToInt32(splitLine[2].Split('/')[0].Split('-')[1]);
                                        p.currentHitPoints = Convert.ToInt32(splitLine[3].Split('/')[0]);
                                        p.hitPoints = Convert.ToInt32(splitLine[3].Split('/')[1]);
                                        p.armorClass = Convert.ToInt32(splitLine[4]);
                                        GameManagement.playerCharacters.Add(p);
                                        p = null;
                                        AddPlayerCharacterToPanel();
                                    }
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}

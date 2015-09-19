﻿namespace Dungeon_Master_Tools
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PlayerCharacterPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddPlayerButton = new System.Windows.Forms.Button();
            this.PlayerCharactersLabel = new System.Windows.Forms.Label();
            this.ButtonSideBar = new System.Windows.Forms.Panel();
            this.RemovePlayerButton = new System.Windows.Forms.Button();
            this.ButtonSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayerCharacterPanel
            // 
            this.PlayerCharacterPanel.AutoSize = true;
            this.PlayerCharacterPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PlayerCharacterPanel.Location = new System.Drawing.Point(190, 26);
            this.PlayerCharacterPanel.Name = "PlayerCharacterPanel";
            this.PlayerCharacterPanel.Size = new System.Drawing.Size(225, 118);
            this.PlayerCharacterPanel.TabIndex = 0;
            this.PlayerCharacterPanel.Tag = "";
            // 
            // AddPlayerButton
            // 
            this.AddPlayerButton.Location = new System.Drawing.Point(3, 4);
            this.AddPlayerButton.Name = "AddPlayerButton";
            this.AddPlayerButton.Size = new System.Drawing.Size(166, 23);
            this.AddPlayerButton.TabIndex = 0;
            this.AddPlayerButton.Text = "Add Player";
            this.AddPlayerButton.UseVisualStyleBackColor = true;
            this.AddPlayerButton.Click += new System.EventHandler(this.AddPlayerButton_Click);
            // 
            // PlayerCharactersLabel
            // 
            this.PlayerCharactersLabel.AutoSize = true;
            this.PlayerCharactersLabel.Location = new System.Drawing.Point(190, 9);
            this.PlayerCharactersLabel.Name = "PlayerCharactersLabel";
            this.PlayerCharactersLabel.Size = new System.Drawing.Size(90, 13);
            this.PlayerCharactersLabel.TabIndex = 0;
            this.PlayerCharactersLabel.Text = "Player Characters";
            // 
            // ButtonSideBar
            // 
            this.ButtonSideBar.Controls.Add(this.RemovePlayerButton);
            this.ButtonSideBar.Controls.Add(this.AddPlayerButton);
            this.ButtonSideBar.Location = new System.Drawing.Point(12, 9);
            this.ButtonSideBar.Name = "ButtonSideBar";
            this.ButtonSideBar.Size = new System.Drawing.Size(172, 569);
            this.ButtonSideBar.TabIndex = 1;
            // 
            // RemovePlayerButton
            // 
            this.RemovePlayerButton.Location = new System.Drawing.Point(3, 33);
            this.RemovePlayerButton.Name = "RemovePlayerButton";
            this.RemovePlayerButton.Size = new System.Drawing.Size(166, 23);
            this.RemovePlayerButton.TabIndex = 1;
            this.RemovePlayerButton.Text = "Remove Player";
            this.RemovePlayerButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 590);
            this.Controls.Add(this.ButtonSideBar);
            this.Controls.Add(this.PlayerCharactersLabel);
            this.Controls.Add(this.PlayerCharacterPanel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ButtonSideBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PlayerCharacterPanel;
        private System.Windows.Forms.Button AddPlayerButton;
        private System.Windows.Forms.Label PlayerCharactersLabel;
        private System.Windows.Forms.Panel ButtonSideBar;
        private System.Windows.Forms.Button RemovePlayerButton;
    }
}


namespace Dungeon_Master_Tools
{
    partial class AddCharacter
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
            this.CharacterNameLabel = new System.Windows.Forms.Label();
            this.CharacterNameTextBox = new System.Windows.Forms.TextBox();
            this.CharacterLevelLabel = new System.Windows.Forms.Label();
            this.CharacterClassTextBox = new System.Windows.Forms.TextBox();
            this.CharacterClassLabel = new System.Windows.Forms.Label();
            this.CharacterHitPointsLabel = new System.Windows.Forms.Label();
            this.CharacterArmorClassLabel = new System.Windows.Forms.Label();
            this.CharacterRaceTextBox = new System.Windows.Forms.TextBox();
            this.CharacterRaceLabel = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.CharacterLevelNum = new System.Windows.Forms.NumericUpDown();
            this.CharacterHitPointsNum = new System.Windows.Forms.NumericUpDown();
            this.CharacterArmorClassNum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterLevelNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterHitPointsNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterArmorClassNum)).BeginInit();
            this.SuspendLayout();
            // 
            // CharacterNameLabel
            // 
            this.CharacterNameLabel.AutoSize = true;
            this.CharacterNameLabel.Location = new System.Drawing.Point(12, 12);
            this.CharacterNameLabel.Name = "CharacterNameLabel";
            this.CharacterNameLabel.Size = new System.Drawing.Size(38, 13);
            this.CharacterNameLabel.TabIndex = 0;
            this.CharacterNameLabel.Text = "Name:";
            // 
            // CharacterNameTextBox
            // 
            this.CharacterNameTextBox.Location = new System.Drawing.Point(54, 9);
            this.CharacterNameTextBox.Name = "CharacterNameTextBox";
            this.CharacterNameTextBox.Size = new System.Drawing.Size(218, 20);
            this.CharacterNameTextBox.TabIndex = 0;
            // 
            // CharacterLevelLabel
            // 
            this.CharacterLevelLabel.AutoSize = true;
            this.CharacterLevelLabel.Location = new System.Drawing.Point(14, 38);
            this.CharacterLevelLabel.Name = "CharacterLevelLabel";
            this.CharacterLevelLabel.Size = new System.Drawing.Size(36, 13);
            this.CharacterLevelLabel.TabIndex = 2;
            this.CharacterLevelLabel.Text = "Level:";
            // 
            // CharacterClassTextBox
            // 
            this.CharacterClassTextBox.Location = new System.Drawing.Point(163, 61);
            this.CharacterClassTextBox.Name = "CharacterClassTextBox";
            this.CharacterClassTextBox.Size = new System.Drawing.Size(109, 20);
            this.CharacterClassTextBox.TabIndex = 5;
            // 
            // CharacterClassLabel
            // 
            this.CharacterClassLabel.AutoSize = true;
            this.CharacterClassLabel.Location = new System.Drawing.Point(122, 64);
            this.CharacterClassLabel.Name = "CharacterClassLabel";
            this.CharacterClassLabel.Size = new System.Drawing.Size(35, 13);
            this.CharacterClassLabel.TabIndex = 4;
            this.CharacterClassLabel.Text = "Class:";
            // 
            // CharacterHitPointsLabel
            // 
            this.CharacterHitPointsLabel.AutoSize = true;
            this.CharacterHitPointsLabel.Location = new System.Drawing.Point(23, 64);
            this.CharacterHitPointsLabel.Name = "CharacterHitPointsLabel";
            this.CharacterHitPointsLabel.Size = new System.Drawing.Size(25, 13);
            this.CharacterHitPointsLabel.TabIndex = 6;
            this.CharacterHitPointsLabel.Text = "HP:";
            // 
            // CharacterArmorClassLabel
            // 
            this.CharacterArmorClassLabel.AutoSize = true;
            this.CharacterArmorClassLabel.Location = new System.Drawing.Point(23, 90);
            this.CharacterArmorClassLabel.Name = "CharacterArmorClassLabel";
            this.CharacterArmorClassLabel.Size = new System.Drawing.Size(24, 13);
            this.CharacterArmorClassLabel.TabIndex = 8;
            this.CharacterArmorClassLabel.Text = "AC:";
            // 
            // CharacterRaceTextBox
            // 
            this.CharacterRaceTextBox.Location = new System.Drawing.Point(163, 35);
            this.CharacterRaceTextBox.Name = "CharacterRaceTextBox";
            this.CharacterRaceTextBox.Size = new System.Drawing.Size(109, 20);
            this.CharacterRaceTextBox.TabIndex = 4;
            // 
            // CharacterRaceLabel
            // 
            this.CharacterRaceLabel.AutoSize = true;
            this.CharacterRaceLabel.Location = new System.Drawing.Point(122, 38);
            this.CharacterRaceLabel.Name = "CharacterRaceLabel";
            this.CharacterRaceLabel.Size = new System.Drawing.Size(36, 13);
            this.CharacterRaceLabel.TabIndex = 10;
            this.CharacterRaceLabel.Text = "Race:";
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(66, 119);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(163, 23);
            this.CreateButton.TabIndex = 12;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // CharacterLevelNum
            // 
            this.CharacterLevelNum.Location = new System.Drawing.Point(57, 35);
            this.CharacterLevelNum.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.CharacterLevelNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CharacterLevelNum.Name = "CharacterLevelNum";
            this.CharacterLevelNum.Size = new System.Drawing.Size(59, 20);
            this.CharacterLevelNum.TabIndex = 1;
            this.CharacterLevelNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CharacterHitPointsNum
            // 
            this.CharacterHitPointsNum.Location = new System.Drawing.Point(57, 61);
            this.CharacterHitPointsNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CharacterHitPointsNum.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.CharacterHitPointsNum.Name = "CharacterHitPointsNum";
            this.CharacterHitPointsNum.Size = new System.Drawing.Size(59, 20);
            this.CharacterHitPointsNum.TabIndex = 2;
            this.CharacterHitPointsNum.Select(0, this.CharacterHitPointsNum.Value.ToString().Length);
            // 
            // CharacterArmorClassNum
            // 
            this.CharacterArmorClassNum.Location = new System.Drawing.Point(57, 87);
            this.CharacterArmorClassNum.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.CharacterArmorClassNum.Name = "CharacterArmorClassNum";
            this.CharacterArmorClassNum.Size = new System.Drawing.Size(59, 20);
            this.CharacterArmorClassNum.TabIndex = 3;
            this.CharacterArmorClassNum.Select(0, this.CharacterArmorClassNum.Value.ToString().Length);
            // 
            // AddCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 154);
            this.Controls.Add(this.CharacterArmorClassNum);
            this.Controls.Add(this.CharacterHitPointsNum);
            this.Controls.Add(this.CharacterLevelNum);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.CharacterRaceTextBox);
            this.Controls.Add(this.CharacterRaceLabel);
            this.Controls.Add(this.CharacterArmorClassLabel);
            this.Controls.Add(this.CharacterHitPointsLabel);
            this.Controls.Add(this.CharacterClassTextBox);
            this.Controls.Add(this.CharacterClassLabel);
            this.Controls.Add(this.CharacterLevelLabel);
            this.Controls.Add(this.CharacterNameTextBox);
            this.Controls.Add(this.CharacterNameLabel);
            this.Name = "AddCharacter";
            this.Text = "AddCharacter";
            ((System.ComponentModel.ISupportInitialize)(this.CharacterLevelNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterHitPointsNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterArmorClassNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CharacterNameLabel;
        private System.Windows.Forms.TextBox CharacterNameTextBox;
        private System.Windows.Forms.Label CharacterLevelLabel;
        private System.Windows.Forms.TextBox CharacterClassTextBox;
        private System.Windows.Forms.Label CharacterClassLabel;
        private System.Windows.Forms.Label CharacterHitPointsLabel;
        private System.Windows.Forms.Label CharacterArmorClassLabel;
        private System.Windows.Forms.TextBox CharacterRaceTextBox;
        private System.Windows.Forms.Label CharacterRaceLabel;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.NumericUpDown CharacterLevelNum;
        private System.Windows.Forms.NumericUpDown CharacterHitPointsNum;
        private System.Windows.Forms.NumericUpDown CharacterArmorClassNum;
    }
}
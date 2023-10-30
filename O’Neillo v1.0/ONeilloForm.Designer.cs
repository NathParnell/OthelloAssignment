
namespace O_Neillo_v1._0
{
    partial class ONeilloForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ONeilloForm));
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.menuItemGame = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.speakStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.panelPlayers = new System.Windows.Forms.Panel();
            this.lblPlayer2Turn = new System.Windows.Forms.Label();
            this.lblPlayer1Turn = new System.Windows.Forms.Label();
            this.pictureBoxWhite = new System.Windows.Forms.PictureBox();
            this.pictureBoxBlack = new System.Windows.Forms.PictureBox();
            this.txtBoxPlayer2Name = new System.Windows.Forms.TextBox();
            this.lblPlayer2Tokens = new System.Windows.Forms.Label();
            this.txtBoxPlayer1Name = new System.Windows.Forms.TextBox();
            this.lblPlayer1Tokens = new System.Windows.Forms.Label();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar.SuspendLayout();
            this.panelPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWhite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlack)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemGame,
            this.menuItemSettings,
            this.menuItemHelp});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(632, 28);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuStrip1";
            // 
            // menuItemGame
            // 
            this.menuItemGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.saveGameToolStripMenuItem,
            this.restoreGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuItemGame.Name = "menuItemGame";
            this.menuItemGame.Size = new System.Drawing.Size(62, 24);
            this.menuItemGame.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // saveGameToolStripMenuItem
            // 
            this.saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
            this.saveGameToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.saveGameToolStripMenuItem.Text = "Save Game";
            this.saveGameToolStripMenuItem.Click += new System.EventHandler(this.saveGameToolStripMenuItem_Click);
            // 
            // restoreGameToolStripMenuItem
            // 
            this.restoreGameToolStripMenuItem.Name = "restoreGameToolStripMenuItem";
            this.restoreGameToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.restoreGameToolStripMenuItem.Text = "Restore Game";
            this.restoreGameToolStripMenuItem.Click += new System.EventHandler(this.restoreGameToolStripMenuItem_Click);
            // 
            // menuItemSettings
            // 
            this.menuItemSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speakStripMenuItem});
            this.menuItemSettings.Name = "menuItemSettings";
            this.menuItemSettings.Size = new System.Drawing.Size(76, 24);
            this.menuItemSettings.Text = "Settings";
            // 
            // speakStripMenuItem
            // 
            this.speakStripMenuItem.Name = "speakStripMenuItem";
            this.speakStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.speakStripMenuItem.Text = "Speak";
            this.speakStripMenuItem.Click += new System.EventHandler(this.speakToolStripMenuItem_Click);
            // 
            // menuItemHelp
            // 
            this.menuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuItemHelp.Name = "menuItemHelp";
            this.menuItemHelp.Size = new System.Drawing.Size(55, 24);
            this.menuItemHelp.Text = "Help";
            // 
            // panelPlayers
            // 
            this.panelPlayers.BackColor = System.Drawing.Color.SteelBlue;
            this.panelPlayers.Controls.Add(this.lblPlayer2Turn);
            this.panelPlayers.Controls.Add(this.lblPlayer1Turn);
            this.panelPlayers.Controls.Add(this.pictureBoxWhite);
            this.panelPlayers.Controls.Add(this.pictureBoxBlack);
            this.panelPlayers.Controls.Add(this.txtBoxPlayer2Name);
            this.panelPlayers.Controls.Add(this.lblPlayer2Tokens);
            this.panelPlayers.Controls.Add(this.txtBoxPlayer1Name);
            this.panelPlayers.Controls.Add(this.lblPlayer1Tokens);
            this.panelPlayers.Location = new System.Drawing.Point(12, 491);
            this.panelPlayers.Name = "panelPlayers";
            this.panelPlayers.Size = new System.Drawing.Size(608, 100);
            this.panelPlayers.TabIndex = 2;
            // 
            // lblPlayer2Turn
            // 
            this.lblPlayer2Turn.AutoSize = true;
            this.lblPlayer2Turn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPlayer2Turn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Turn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPlayer2Turn.Location = new System.Drawing.Point(474, 23);
            this.lblPlayer2Turn.Name = "lblPlayer2Turn";
            this.lblPlayer2Turn.Size = new System.Drawing.Size(65, 20);
            this.lblPlayer2Turn.TabIndex = 7;
            this.lblPlayer2Turn.Text = "To Play";
            // 
            // lblPlayer1Turn
            // 
            this.lblPlayer1Turn.AutoSize = true;
            this.lblPlayer1Turn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPlayer1Turn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Turn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPlayer1Turn.Location = new System.Drawing.Point(167, 23);
            this.lblPlayer1Turn.Name = "lblPlayer1Turn";
            this.lblPlayer1Turn.Size = new System.Drawing.Size(65, 20);
            this.lblPlayer1Turn.TabIndex = 6;
            this.lblPlayer1Turn.Text = "To Play";
            // 
            // pictureBoxWhite
            // 
            this.pictureBoxWhite.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxWhite.Image")));
            this.pictureBoxWhite.Location = new System.Drawing.Point(390, 55);
            this.pictureBoxWhite.Name = "pictureBoxWhite";
            this.pictureBoxWhite.Size = new System.Drawing.Size(29, 27);
            this.pictureBoxWhite.TabIndex = 5;
            this.pictureBoxWhite.TabStop = false;
            // 
            // pictureBoxBlack
            // 
            this.pictureBoxBlack.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBlack.Image")));
            this.pictureBoxBlack.Location = new System.Drawing.Point(81, 55);
            this.pictureBoxBlack.Name = "pictureBoxBlack";
            this.pictureBoxBlack.Size = new System.Drawing.Size(29, 27);
            this.pictureBoxBlack.TabIndex = 4;
            this.pictureBoxBlack.TabStop = false;
            // 
            // txtBoxPlayer2Name
            // 
            this.txtBoxPlayer2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPlayer2Name.Location = new System.Drawing.Point(440, 55);
            this.txtBoxPlayer2Name.Name = "txtBoxPlayer2Name";
            this.txtBoxPlayer2Name.Size = new System.Drawing.Size(145, 27);
            this.txtBoxPlayer2Name.TabIndex = 3;
            // 
            // lblPlayer2Tokens
            // 
            this.lblPlayer2Tokens.AutoSize = true;
            this.lblPlayer2Tokens.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Tokens.Location = new System.Drawing.Point(325, 53);
            this.lblPlayer2Tokens.Name = "lblPlayer2Tokens";
            this.lblPlayer2Tokens.Size = new System.Drawing.Size(45, 29);
            this.lblPlayer2Tokens.TabIndex = 2;
            this.lblPlayer2Tokens.Text = "2X";
            // 
            // txtBoxPlayer1Name
            // 
            this.txtBoxPlayer1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPlayer1Name.Location = new System.Drawing.Point(132, 55);
            this.txtBoxPlayer1Name.Name = "txtBoxPlayer1Name";
            this.txtBoxPlayer1Name.Size = new System.Drawing.Size(145, 27);
            this.txtBoxPlayer1Name.TabIndex = 1;
            // 
            // lblPlayer1Tokens
            // 
            this.lblPlayer1Tokens.AutoSize = true;
            this.lblPlayer1Tokens.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Tokens.Location = new System.Drawing.Point(20, 55);
            this.lblPlayer1Tokens.Name = "lblPlayer1Tokens";
            this.lblPlayer1Tokens.Size = new System.Drawing.Size(45, 29);
            this.lblPlayer1Tokens.TabIndex = 0;
            this.lblPlayer1Tokens.Text = "2X";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ONeilloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(632, 603);
            this.Controls.Add(this.panelPlayers);
            this.Controls.Add(this.menuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuBar;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ONeilloForm";
            this.Text = "O\'Neillo v1.0";
            this.Load += new System.EventHandler(this.ONeilloForm_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.panelPlayers.ResumeLayout(false);
            this.panelPlayers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWhite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem menuItemGame;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemSettings;
        private System.Windows.Forms.ToolStripMenuItem menuItemHelp;
        private System.Windows.Forms.Panel panelPlayers;
        private System.Windows.Forms.Label lblPlayer1Tokens;
        private System.Windows.Forms.TextBox txtBoxPlayer2Name;
        private System.Windows.Forms.Label lblPlayer2Tokens;
        private System.Windows.Forms.TextBox txtBoxPlayer1Name;
        private System.Windows.Forms.ToolStripMenuItem speakStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreGameToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxWhite;
        private System.Windows.Forms.PictureBox pictureBoxBlack;
        private System.Windows.Forms.Label lblPlayer2Turn;
        private System.Windows.Forms.Label lblPlayer1Turn;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}


namespace Octoslots
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ipBox = new System.Windows.Forms.TextBox();
            this.connectBox = new System.Windows.Forms.Button();
            this.disconnectBox = new System.Windows.Forms.Button();
            this.IPLabel = new System.Windows.Forms.Label();
            this.gameVerLabel = new System.Windows.Forms.Label();
            this.autoRefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.checkBoxP3 = new System.Windows.Forms.CheckBox();
            this.checkBoxP5 = new System.Windows.Forms.CheckBox();
            this.creditLabel = new System.Windows.Forms.Label();
            this.BKOOL999Label = new System.Windows.Forms.Label();
            this.checkBoxP1 = new System.Windows.Forms.CheckBox();
            this.checkBoxP2 = new System.Windows.Forms.CheckBox();
            this.checkBoxP4 = new System.Windows.Forms.CheckBox();
            this.checkBoxP6 = new System.Windows.Forms.CheckBox();
            this.checkBoxP7 = new System.Windows.Forms.CheckBox();
            this.checkBoxP8 = new System.Windows.Forms.CheckBox();
            this.playerPicBox = new System.Windows.Forms.PictureBox();
            this.modeComboBox = new System.Windows.Forms.ComboBox();
            this.modeLabel = new System.Windows.Forms.Label();
            this.toolTipP1 = new System.Windows.Forms.ToolTip(this.components);
            this.toggleGenderButton = new System.Windows.Forms.Button();
            this.sfxNormalRadio = new System.Windows.Forms.RadioButton();
            this.sfxEliteRadio = new System.Windows.Forms.RadioButton();
            this.sfxCombineRadio = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.singlePlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPlayerPokeCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.playerPicBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ipBox
            // 
            resources.ApplyResources(this.ipBox, "ipBox");
            this.ipBox.Name = "ipBox";
            this.ipBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IPBox_KeyDown);
            // 
            // connectBox
            // 
            resources.ApplyResources(this.connectBox, "connectBox");
            this.connectBox.Name = "connectBox";
            this.connectBox.UseVisualStyleBackColor = true;
            this.connectBox.Click += new System.EventHandler(this.connectBox_Click);
            // 
            // disconnectBox
            // 
            resources.ApplyResources(this.disconnectBox, "disconnectBox");
            this.disconnectBox.Name = "disconnectBox";
            this.disconnectBox.UseVisualStyleBackColor = true;
            this.disconnectBox.Click += new System.EventHandler(this.disconnectBox_Click);
            // 
            // IPLabel
            // 
            resources.ApplyResources(this.IPLabel, "IPLabel");
            this.IPLabel.Name = "IPLabel";
            // 
            // gameVerLabel
            // 
            resources.ApplyResources(this.gameVerLabel, "gameVerLabel");
            this.gameVerLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.gameVerLabel.Name = "gameVerLabel";
            // 
            // autoRefreshTimer
            // 
            this.autoRefreshTimer.Interval = 1200;
            this.autoRefreshTimer.Tick += new System.EventHandler(this.autoRefreshTimer_Tick);
            // 
            // checkBoxP3
            // 
            this.checkBoxP3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.checkBoxP3, "checkBoxP3");
            this.checkBoxP3.ForeColor = System.Drawing.Color.White;
            this.checkBoxP3.Name = "checkBoxP3";
            this.checkBoxP3.UseVisualStyleBackColor = false;
            this.checkBoxP3.CheckedChanged += new System.EventHandler(this.checkBoxP3_CheckedChanged);
            this.checkBoxP3.TextChanged += new System.EventHandler(this.checkBoxAllPlayers_TextChanged);
            // 
            // checkBoxP5
            // 
            this.checkBoxP5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.checkBoxP5, "checkBoxP5");
            this.checkBoxP5.ForeColor = System.Drawing.Color.White;
            this.checkBoxP5.Name = "checkBoxP5";
            this.checkBoxP5.UseVisualStyleBackColor = false;
            this.checkBoxP5.CheckedChanged += new System.EventHandler(this.checkBoxP5_CheckedChanged);
            this.checkBoxP5.TextChanged += new System.EventHandler(this.checkBoxAllPlayers_TextChanged);
            // 
            // creditLabel
            // 
            resources.ApplyResources(this.creditLabel, "creditLabel");
            this.creditLabel.Name = "creditLabel";
            // 
            // BKOOL999Label
            // 
            resources.ApplyResources(this.BKOOL999Label, "BKOOL999Label");
            this.BKOOL999Label.Name = "BKOOL999Label";
            // 
            // checkBoxP1
            // 
            this.checkBoxP1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.checkBoxP1, "checkBoxP1");
            this.checkBoxP1.ForeColor = System.Drawing.Color.White;
            this.checkBoxP1.Name = "checkBoxP1";
            this.toolTipP1.SetToolTip(this.checkBoxP1, resources.GetString("checkBoxP1.ToolTip"));
            this.checkBoxP1.UseVisualStyleBackColor = false;
            this.checkBoxP1.CheckedChanged += new System.EventHandler(this.checkBoxP1_CheckedChanged);
            this.checkBoxP1.TextChanged += new System.EventHandler(this.checkBoxAllPlayers_TextChanged);
            // 
            // checkBoxP2
            // 
            this.checkBoxP2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.checkBoxP2, "checkBoxP2");
            this.checkBoxP2.ForeColor = System.Drawing.Color.White;
            this.checkBoxP2.Name = "checkBoxP2";
            this.checkBoxP2.UseVisualStyleBackColor = false;
            this.checkBoxP2.CheckedChanged += new System.EventHandler(this.checkBoxP2_CheckedChanged);
            this.checkBoxP2.TextChanged += new System.EventHandler(this.checkBoxAllPlayers_TextChanged);
            // 
            // checkBoxP4
            // 
            this.checkBoxP4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.checkBoxP4, "checkBoxP4");
            this.checkBoxP4.ForeColor = System.Drawing.Color.White;
            this.checkBoxP4.Name = "checkBoxP4";
            this.checkBoxP4.UseVisualStyleBackColor = false;
            this.checkBoxP4.CheckedChanged += new System.EventHandler(this.checkBoxP4_CheckedChanged);
            this.checkBoxP4.TextChanged += new System.EventHandler(this.checkBoxAllPlayers_TextChanged);
            // 
            // checkBoxP6
            // 
            this.checkBoxP6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.checkBoxP6, "checkBoxP6");
            this.checkBoxP6.ForeColor = System.Drawing.Color.White;
            this.checkBoxP6.Name = "checkBoxP6";
            this.checkBoxP6.UseVisualStyleBackColor = false;
            this.checkBoxP6.CheckedChanged += new System.EventHandler(this.checkBoxP6_CheckedChanged);
            this.checkBoxP6.TextChanged += new System.EventHandler(this.checkBoxAllPlayers_TextChanged);
            // 
            // checkBoxP7
            // 
            this.checkBoxP7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.checkBoxP7, "checkBoxP7");
            this.checkBoxP7.ForeColor = System.Drawing.Color.White;
            this.checkBoxP7.Name = "checkBoxP7";
            this.checkBoxP7.UseVisualStyleBackColor = false;
            this.checkBoxP7.CheckedChanged += new System.EventHandler(this.checkBoxP7_CheckedChanged);
            this.checkBoxP7.TextChanged += new System.EventHandler(this.checkBoxAllPlayers_TextChanged);
            // 
            // checkBoxP8
            // 
            this.checkBoxP8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.checkBoxP8, "checkBoxP8");
            this.checkBoxP8.ForeColor = System.Drawing.Color.White;
            this.checkBoxP8.Name = "checkBoxP8";
            this.checkBoxP8.UseVisualStyleBackColor = false;
            this.checkBoxP8.CheckedChanged += new System.EventHandler(this.checkBoxP8_CheckedChanged);
            this.checkBoxP8.TextChanged += new System.EventHandler(this.checkBoxAllPlayers_TextChanged);
            // 
            // playerPicBox
            // 
            this.playerPicBox.Image = global::Octoslots.Properties.Resources.Splatoon_Player_Slots_Full;
            resources.ApplyResources(this.playerPicBox, "playerPicBox");
            this.playerPicBox.Name = "playerPicBox";
            this.playerPicBox.TabStop = false;
            // 
            // modeComboBox
            // 
            this.modeComboBox.FormattingEnabled = true;
            this.modeComboBox.Items.AddRange(new object[] {
            resources.GetString("modeComboBox.Items"),
            resources.GetString("modeComboBox.Items1"),
            resources.GetString("modeComboBox.Items2")});
            resources.ApplyResources(this.modeComboBox, "modeComboBox");
            this.modeComboBox.Name = "modeComboBox";
            // 
            // modeLabel
            // 
            resources.ApplyResources(this.modeLabel, "modeLabel");
            this.modeLabel.Name = "modeLabel";
            // 
            // toolTipP1
            // 
            this.toolTipP1.AutoPopDelay = 4200;
            this.toolTipP1.BackColor = System.Drawing.Color.Transparent;
            this.toolTipP1.InitialDelay = 900;
            this.toolTipP1.ReshowDelay = 50;
            // 
            // toggleGenderButton
            // 
            resources.ApplyResources(this.toggleGenderButton, "toggleGenderButton");
            this.toggleGenderButton.Name = "toggleGenderButton";
            this.toggleGenderButton.Click += new System.EventHandler(this.toggleGenderButton_Click);
            // 
            // sfxNormalRadio
            // 
            resources.ApplyResources(this.sfxNormalRadio, "sfxNormalRadio");
            this.sfxNormalRadio.Checked = true;
            this.sfxNormalRadio.Name = "sfxNormalRadio";
            this.sfxNormalRadio.TabStop = true;
            this.sfxNormalRadio.UseVisualStyleBackColor = true;
            this.sfxNormalRadio.CheckedChanged += new System.EventHandler(this.sfxNormalRadio_CheckedChanged);
            // 
            // sfxEliteRadio
            // 
            resources.ApplyResources(this.sfxEliteRadio, "sfxEliteRadio");
            this.sfxEliteRadio.Name = "sfxEliteRadio";
            this.sfxEliteRadio.UseVisualStyleBackColor = true;
            this.sfxEliteRadio.CheckedChanged += new System.EventHandler(this.sfxEliteRadio_CheckedChanged);
            // 
            // sfxCombineRadio
            // 
            resources.ApplyResources(this.sfxCombineRadio, "sfxCombineRadio");
            this.sfxCombineRadio.Name = "sfxCombineRadio";
            this.sfxCombineRadio.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singlePlayerToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // singlePlayerToolStripMenuItem
            // 
            this.singlePlayerToolStripMenuItem.Name = "singlePlayerToolStripMenuItem";
            resources.ApplyResources(this.singlePlayerToolStripMenuItem, "singlePlayerToolStripMenuItem");
            this.singlePlayerToolStripMenuItem.Click += new System.EventHandler(this.singlePlayerToolStripMenuItem_Click);
            // 
            // mainPlayerPokeCheck
            // 
            resources.ApplyResources(this.mainPlayerPokeCheck, "mainPlayerPokeCheck");
            this.mainPlayerPokeCheck.Name = "mainPlayerPokeCheck";
            this.toolTipP1.SetToolTip(this.mainPlayerPokeCheck, resources.GetString("mainPlayerPokeCheck.ToolTip"));
            this.mainPlayerPokeCheck.UseVisualStyleBackColor = true;
            this.mainPlayerPokeCheck.CheckedChanged += new System.EventHandler(this.mainPlayerPokeCheck_CheckedChanged);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPlayerPokeCheck);
            this.Controls.Add(this.sfxNormalRadio);
            this.Controls.Add(this.toggleGenderButton);
            this.Controls.Add(this.modeLabel);
            this.Controls.Add(this.modeComboBox);
            this.Controls.Add(this.checkBoxP8);
            this.Controls.Add(this.checkBoxP7);
            this.Controls.Add(this.checkBoxP6);
            this.Controls.Add(this.checkBoxP4);
            this.Controls.Add(this.checkBoxP2);
            this.Controls.Add(this.checkBoxP1);
            this.Controls.Add(this.checkBoxP5);
            this.Controls.Add(this.checkBoxP3);
            this.Controls.Add(this.BKOOL999Label);
            this.Controls.Add(this.creditLabel);
            this.Controls.Add(this.gameVerLabel);
            this.Controls.Add(this.IPLabel);
            this.Controls.Add(this.disconnectBox);
            this.Controls.Add(this.connectBox);
            this.Controls.Add(this.ipBox);
            this.Controls.Add(this.playerPicBox);
            this.Controls.Add(this.sfxCombineRadio);
            this.Controls.Add(this.sfxEliteRadio);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playerPicBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.Button connectBox;
        private System.Windows.Forms.Label IPLabel;
        private System.Windows.Forms.Label gameVerLabel;
        private System.Windows.Forms.Timer autoRefreshTimer;
        private System.Windows.Forms.CheckBox checkBoxP3;
        private System.Windows.Forms.CheckBox checkBoxP5;

        private System.Windows.Forms.Label creditLabel;
        private System.Windows.Forms.Label BKOOL999Label;
        private System.Windows.Forms.CheckBox checkBoxP1;
        private System.Windows.Forms.CheckBox checkBoxP2;
        private System.Windows.Forms.CheckBox checkBoxP4;
        private System.Windows.Forms.CheckBox checkBoxP6;
        private System.Windows.Forms.CheckBox checkBoxP7;
        private System.Windows.Forms.CheckBox checkBoxP8;
        private System.Windows.Forms.PictureBox playerPicBox;
        private System.Windows.Forms.ComboBox modeComboBox;
        private System.Windows.Forms.Label modeLabel;
        private System.Windows.Forms.ToolTip toolTipP1;
        private System.Windows.Forms.Button toggleGenderButton;
        private System.Windows.Forms.RadioButton sfxNormalRadio;
        private System.Windows.Forms.RadioButton sfxEliteRadio;
        private System.Windows.Forms.RadioButton sfxCombineRadio;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem singlePlayerToolStripMenuItem;
        private System.Windows.Forms.Button disconnectBox;
        private System.Windows.Forms.CheckBox mainPlayerPokeCheck;
    }
}


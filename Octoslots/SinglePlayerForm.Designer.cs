namespace Octoslots
{
    partial class SinglePlayerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SinglePlayerForm));
            this.label1 = new System.Windows.Forms.Label();
            this.radioInklingGirl = new System.Windows.Forms.RadioButton();
            this.radioInklingBoy = new System.Windows.Forms.RadioButton();
            this.radioAllGenders = new System.Windows.Forms.RadioButton();
            this.radioInklingsOnly = new System.Windows.Forms.RadioButton();
            this.singlePlayerGroup = new System.Windows.Forms.GroupBox();
            this.singlePlayerCheck = new System.Windows.Forms.CheckBox();
            this.singlePlayerGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // radioInklingGirl
            // 
            this.radioInklingGirl.Checked = true;
            resources.ApplyResources(this.radioInklingGirl, "radioInklingGirl");
            this.radioInklingGirl.Name = "radioInklingGirl";
            this.radioInklingGirl.TabStop = true;
            this.radioInklingGirl.UseVisualStyleBackColor = true;
            this.radioInklingGirl.CheckedChanged += new System.EventHandler(this.radioInklingGirl_CheckedChanged);
            // 
            // radioInklingBoy
            // 
            resources.ApplyResources(this.radioInklingBoy, "radioInklingBoy");
            this.radioInklingBoy.Name = "radioInklingBoy";
            this.radioInklingBoy.UseVisualStyleBackColor = true;
            this.radioInklingBoy.CheckedChanged += new System.EventHandler(this.radioInklingBoy_CheckedChanged);
            // 
            // radioAllGenders
            // 
            resources.ApplyResources(this.radioAllGenders, "radioAllGenders");
            this.radioAllGenders.Name = "radioAllGenders";
            this.radioAllGenders.UseVisualStyleBackColor = true;
            this.radioAllGenders.CheckedChanged += new System.EventHandler(this.radioAllGenders_CheckedChanged);
            // 
            // radioInklingsOnly
            // 
            resources.ApplyResources(this.radioInklingsOnly, "radioInklingsOnly");
            this.radioInklingsOnly.Name = "radioInklingsOnly";
            this.radioInklingsOnly.UseVisualStyleBackColor = true;
            this.radioInklingsOnly.CheckedChanged += new System.EventHandler(this.radioInklingsOnly_CheckedChanged);
            // 
            // singlePlayerGroup
            // 
            this.singlePlayerGroup.Controls.Add(this.radioAllGenders);
            this.singlePlayerGroup.Controls.Add(this.radioInklingsOnly);
            this.singlePlayerGroup.Controls.Add(this.radioInklingGirl);
            this.singlePlayerGroup.Controls.Add(this.radioInklingBoy);
            resources.ApplyResources(this.singlePlayerGroup, "singlePlayerGroup");
            this.singlePlayerGroup.Name = "singlePlayerGroup";
            this.singlePlayerGroup.TabStop = false;
            // 
            // singlePlayerCheck
            // 
            resources.ApplyResources(this.singlePlayerCheck, "singlePlayerCheck");
            this.singlePlayerCheck.Name = "singlePlayerCheck";
            this.singlePlayerCheck.UseVisualStyleBackColor = true;
            this.singlePlayerCheck.CheckedChanged += new System.EventHandler(this.singlePlayerCheck_CheckedChanged);
            // 
            // SinglePlayerForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.singlePlayerCheck);
            this.Controls.Add(this.singlePlayerGroup);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SinglePlayerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SinglePlayerForm_FormClosing);
            this.singlePlayerGroup.ResumeLayout(false);
            this.singlePlayerGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.CheckBox singlePlayerCheck;
        public System.Windows.Forms.GroupBox singlePlayerGroup;
        private System.Windows.Forms.RadioButton radioInklingGirl;
        private System.Windows.Forms.RadioButton radioInklingBoy;
        private System.Windows.Forms.RadioButton radioAllGenders;
        private System.Windows.Forms.RadioButton radioInklingsOnly;
    }
}
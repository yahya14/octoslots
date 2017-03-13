namespace Octoslots
{
    partial class Checker
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
            this.updateRTB = new System.Windows.Forms.RichTextBox();
            this.webButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // updateRTB
            // 
            this.updateRTB.BackColor = System.Drawing.SystemColors.Control;
            this.updateRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.updateRTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.updateRTB.Location = new System.Drawing.Point(13, 16);
            this.updateRTB.Name = "updateRTB";
            this.updateRTB.ReadOnly = true;
            this.updateRTB.Size = new System.Drawing.Size(275, 132);
            this.updateRTB.TabIndex = 0;
            this.updateRTB.Text = "";
            // 
            // webButton
            // 
            this.webButton.Location = new System.Drawing.Point(28, 154);
            this.webButton.Name = "webButton";
            this.webButton.Size = new System.Drawing.Size(107, 23);
            this.webButton.TabIndex = 1;
            this.webButton.Text = "Download Now!";
            this.webButton.UseVisualStyleBackColor = true;
            this.webButton.Click += new System.EventHandler(this.webButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(181, 155);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(74, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // Checker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 190);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.webButton);
            this.Controls.Add(this.updateRTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Checker";
            this.Text = "New Update Available";
            this.Load += new System.EventHandler(this.Checker_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox updateRTB;
        private System.Windows.Forms.Button webButton;
        private System.Windows.Forms.Button okButton;
    }
}
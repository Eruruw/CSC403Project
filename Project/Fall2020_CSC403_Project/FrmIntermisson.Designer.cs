namespace Fall2020_CSC403_Project
{
    partial class FrmIntermisson
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
            this.Continue_Button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Continue_Button
            // 
            this.Continue_Button.Location = new System.Drawing.Point(498, 339);
            this.Continue_Button.Name = "Continue_Button";
            this.Continue_Button.Size = new System.Drawing.Size(137, 57);
            this.Continue_Button.TabIndex = 0;
            this.Continue_Button.Text = "Continue";
            this.Continue_Button.UseVisualStyleBackColor = true;
            this.Continue_Button.Click += new System.EventHandler(this.Continue_Button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 62);
            this.button1.TabIndex = 1;
            this.button1.Text = "Return to Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmIntermisson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.IntermissionBackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Continue_Button);
            this.Name = "FrmIntermisson";
            this.Text = "Dungeon Slayer 3000";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Continue_Button;
        private System.Windows.Forms.Button button1;
    }
}
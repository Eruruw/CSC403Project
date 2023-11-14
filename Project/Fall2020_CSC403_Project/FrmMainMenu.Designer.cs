namespace Fall2020_CSC403_Project
{
    partial class FrmMainMenu
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
            this.MainMenuPanel = new System.Windows.Forms.Panel();
            this.LevelSelectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PlayButton = new System.Windows.Forms.Button();
            this.LevelSelectPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Level_2_Button = new System.Windows.Forms.Button();
            this.Level_1_Button = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MainMenuPanel.SuspendLayout();
            this.LevelSelectPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.forgotten_wastes;
            this.MainMenuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainMenuPanel.Controls.Add(this.LevelSelectPanel);
            this.MainMenuPanel.Controls.Add(this.LevelSelectButton);
            this.MainMenuPanel.Controls.Add(this.label1);
            this.MainMenuPanel.Controls.Add(this.PlayButton);
            this.MainMenuPanel.Location = new System.Drawing.Point(-10, -6);
            this.MainMenuPanel.Margin = new System.Windows.Forms.Padding(6);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.Size = new System.Drawing.Size(2012, 1110);
            this.MainMenuPanel.TabIndex = 3;
            // 
            // LevelSelectButton
            // 
            this.LevelSelectButton.Location = new System.Drawing.Point(830, 775);
            this.LevelSelectButton.Margin = new System.Windows.Forms.Padding(6);
            this.LevelSelectButton.Name = "LevelSelectButton";
            this.LevelSelectButton.Size = new System.Drawing.Size(274, 88);
            this.LevelSelectButton.TabIndex = 2;
            this.LevelSelectButton.Text = "Level Select";
            this.LevelSelectButton.UseVisualStyleBackColor = true;
            this.LevelSelectButton.Click += new System.EventHandler(this.LevelSelectButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(700, 260);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dungeon Slayer 3000";
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.Transparent;
            this.PlayButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PlayButton.Location = new System.Drawing.Point(830, 619);
            this.PlayButton.Margin = new System.Windows.Forms.Padding(6);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(274, 88);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // LevelSelectPanel
            // 
            this.LevelSelectPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LevelSelectPanel.Controls.Add(this.tableLayoutPanel1);
            this.LevelSelectPanel.Controls.Add(this.BackButton);
            this.LevelSelectPanel.Controls.Add(this.label2);
            this.LevelSelectPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LevelSelectPanel.Location = new System.Drawing.Point(0, 0);
            this.LevelSelectPanel.Margin = new System.Windows.Forms.Padding(6);
            this.LevelSelectPanel.Name = "LevelSelectPanel";
            this.LevelSelectPanel.Size = new System.Drawing.Size(2012, 1110);
            this.LevelSelectPanel.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 594F));
            this.tableLayoutPanel1.Controls.Add(this.Level_2_Button, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Level_1_Button, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(28, 525);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1882, 540);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // Level_2_Button
            // 
            this.Level_2_Button.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.level2Thumb;
            this.Level_2_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Level_2_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Level_2_Button.ForeColor = System.Drawing.Color.White;
            this.Level_2_Button.Location = new System.Drawing.Point(650, 6);
            this.Level_2_Button.Margin = new System.Windows.Forms.Padding(6);
            this.Level_2_Button.Name = "Level_2_Button";
            this.Level_2_Button.Size = new System.Drawing.Size(632, 258);
            this.Level_2_Button.TabIndex = 1;
            this.Level_2_Button.Text = "Level 2";
            this.Level_2_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Level_2_Button.UseVisualStyleBackColor = true;
            // 
            // Level_1_Button
            // 
            this.Level_1_Button.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.level1Thumb;
            this.Level_1_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Level_1_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Level_1_Button.ForeColor = System.Drawing.Color.White;
            this.Level_1_Button.Location = new System.Drawing.Point(6, 6);
            this.Level_1_Button.Margin = new System.Windows.Forms.Padding(6);
            this.Level_1_Button.Name = "Level_1_Button";
            this.Level_1_Button.Size = new System.Drawing.Size(632, 258);
            this.Level_1_Button.TabIndex = 0;
            this.Level_1_Button.Text = "Level 1";
            this.Level_1_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Level_1_Button.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(50, 31);
            this.BackButton.Margin = new System.Windows.Forms.Padding(6);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(206, 92);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(692, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(565, 108);
            this.label2.TabIndex = 0;
            this.label2.Text = "Level Select";
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1924, 1062);
            this.Controls.Add(this.MainMenuPanel);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmMainMenu";
            this.Text = "FrmMainMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMainMenu_FormClosing);
            this.MainMenuPanel.ResumeLayout(false);
            this.MainMenuPanel.PerformLayout();
            this.LevelSelectPanel.ResumeLayout(false);
            this.LevelSelectPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LevelSelectButton;
        private System.Windows.Forms.Panel MainMenuPanel;
        private System.Windows.Forms.Panel LevelSelectPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Level_2_Button;
        private System.Windows.Forms.Button Level_1_Button;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label2;
    }
}
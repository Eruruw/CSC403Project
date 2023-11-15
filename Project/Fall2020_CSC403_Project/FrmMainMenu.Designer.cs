using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMenu));
            this.MainMenuPanel = new System.Windows.Forms.Panel();
            this.LevelSelectPanel = new System.Windows.Forms.Panel();
            this.Help_Panel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Level_2_Button = new System.Windows.Forms.Button();
            this.Level_1_Button = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LevelSelectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PlayButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.MainMenuPanel.SuspendLayout();
            this.LevelSelectPanel.SuspendLayout();
            this.Help_Panel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.forgotten_wastes;
            this.MainMenuPanel.Controls.Add(this.LevelSelectPanel);
            this.MainMenuPanel.Controls.Add(this.button1);
            this.MainMenuPanel.Controls.Add(this.LevelSelectButton);
            this.MainMenuPanel.Controls.Add(this.label1);
            this.MainMenuPanel.Controls.Add(this.PlayButton);
            this.MainMenuPanel.Location = new System.Drawing.Point(-20, -12);
            this.MainMenuPanel.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.Size = new System.Drawing.Size(2004, 1096);
            this.MainMenuPanel.TabIndex = 3;
            // 
            // LevelSelectPanel
            // 
            this.LevelSelectPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LevelSelectPanel.Controls.Add(this.Help_Panel);
            this.LevelSelectPanel.Controls.Add(this.tableLayoutPanel1);
            this.LevelSelectPanel.Controls.Add(this.BackButton);
            this.LevelSelectPanel.Controls.Add(this.label2);
            this.LevelSelectPanel.Location = new System.Drawing.Point(0, 0);
            this.LevelSelectPanel.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.LevelSelectPanel.Name = "LevelSelectPanel";
            this.LevelSelectPanel.Size = new System.Drawing.Size(2000, 1104);
            this.LevelSelectPanel.TabIndex = 4;
            // 
            // Help_Panel
            // 
            this.Help_Panel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Help_Panel.Controls.Add(this.label12);
            this.Help_Panel.Controls.Add(this.label11);
            this.Help_Panel.Controls.Add(this.label10);
            this.Help_Panel.Controls.Add(this.label9);
            this.Help_Panel.Controls.Add(this.label8);
            this.Help_Panel.Controls.Add(this.label7);
            this.Help_Panel.Controls.Add(this.label6);
            this.Help_Panel.Controls.Add(this.label5);
            this.Help_Panel.Controls.Add(this.label4);
            this.Help_Panel.Controls.Add(this.label3);
            this.Help_Panel.Controls.Add(this.button2);
            this.Help_Panel.Location = new System.Drawing.Point(0, 0);
            this.Help_Panel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Help_Panel.Name = "Help_Panel";
            this.Help_Panel.Size = new System.Drawing.Size(1990, 1104);
            this.Help_Panel.TabIndex = 3;
            this.Help_Panel.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(870, 1567);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(803, 51);
            this.label11.TabIndex = 9;
            this.label11.Text = "7. View the move list in the pause menu! ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(660, 750);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(995, 51);
            this.label10.TabIndex = 8;
            this.label10.Text = "6. To activate the inventory, press the items menu! ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(660, 665);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(735, 51);
            this.label9.TabIndex = 7;
            this.label9.Text = "5. Press the right arrow to move right!";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(660, 583);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(683, 51);
            this.label8.TabIndex = 6;
            this.label8.Text = "4. Press the left arrow to move left!";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 25);
            this.label7.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(658, 500);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(773, 51);
            this.label6.TabIndex = 4;
            this.label6.Text = "3. Press the down arrow to move down!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(654, 415);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(670, 51);
            this.label5.TabIndex = 3;
            this.label5.Text = "2. Press the Up arrow to move up!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(658, 337);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(598, 51);
            this.label4.TabIndex = 2;
            this.label4.Text = "1. Press P to pause the game!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(714, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(473, 85);
            this.label3.TabIndex = 1;
            this.label3.Text = "HELP MENU";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(56, 65);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 85);
            this.button2.TabIndex = 0;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 598F));
            this.tableLayoutPanel1.Controls.Add(this.Level_2_Button, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Level_1_Button, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(44, 506);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1910, 577);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // Level_2_Button
            // 
            this.Level_2_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Level_2_Button.BackgroundImage")));
            this.Level_2_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Level_2_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Level_2_Button.ForeColor = System.Drawing.Color.White;
            this.Level_2_Button.Location = new System.Drawing.Point(662, 6);
            this.Level_2_Button.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Level_2_Button.Name = "Level_2_Button";
            this.Level_2_Button.Size = new System.Drawing.Size(644, 276);
            this.Level_2_Button.TabIndex = 1;
            this.Level_2_Button.Text = "Level 2";
            this.Level_2_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Level_2_Button.UseVisualStyleBackColor = true;
            this.Level_2_Button.Click += new System.EventHandler(this.Level_2_Button_Click_1);
            // 
            // Level_1_Button
            // 
            this.Level_1_Button.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.level1Thumb;
            this.Level_1_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Level_1_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Level_1_Button.ForeColor = System.Drawing.Color.White;
            this.Level_1_Button.Location = new System.Drawing.Point(6, 6);
            this.Level_1_Button.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Level_1_Button.Name = "Level_1_Button";
            this.Level_1_Button.Size = new System.Drawing.Size(644, 276);
            this.Level_1_Button.TabIndex = 0;
            this.Level_1_Button.Text = "Level 1";
            this.Level_1_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Level_1_Button.UseVisualStyleBackColor = true;
            this.Level_1_Button.Click += new System.EventHandler(this.Level_1_Button_Click_1);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(50, 31);
            this.BackButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(206, 92);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(782, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(565, 108);
            this.label2.TabIndex = 0;
            this.label2.Text = "Level Select";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(856, 827);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 94);
            this.button1.TabIndex = 5;
            this.button1.Text = "Help Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // LevelSelectButton
            // 
            this.LevelSelectButton.Location = new System.Drawing.Point(856, 663);
            this.LevelSelectButton.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.LevelSelectButton.Name = "LevelSelectButton";
            this.LevelSelectButton.Size = new System.Drawing.Size(252, 106);
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
            this.label1.Location = new System.Drawing.Point(726, 206);
            this.label1.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dungeon Slayer 3000";
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.Transparent;
            this.PlayButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PlayButton.Location = new System.Drawing.Point(856, 517);
            this.PlayButton.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(252, 98);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(291, 841);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(1483, 51);
            this.label12.TabIndex = 10;
            this.label12.Text = "7. To view a detailed list of your moves, use the move list in the pause menu!";
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1958, 1075);
            this.Controls.Add(this.MainMenuPanel);
            this.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.Name = "FrmMainMenu";
            this.Text = "FrmMainMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMainMenu_FormClosing);
            this.MainMenuPanel.ResumeLayout(false);
            this.MainMenuPanel.PerformLayout();
            this.LevelSelectPanel.ResumeLayout(false);
            this.LevelSelectPanel.PerformLayout();
            this.Help_Panel.ResumeLayout(false);
            this.Help_Panel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LevelSelectButton;
        private System.Windows.Forms.Panel LevelSelectPanel;
        private System.Windows.Forms.Panel MainMenuPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Level_2_Button;
        private System.Windows.Forms.Button Level_1_Button;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label2;

        //public Panel MainMenuPanel { get; private set; }

        private System.Windows.Forms.Panel Help_Panel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private Label label12;
    }
}
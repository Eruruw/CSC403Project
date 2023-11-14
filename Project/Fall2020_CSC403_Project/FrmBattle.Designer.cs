namespace Fall2020_CSC403_Project
{
    partial class FrmBattle
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
            this.btnAttack = new System.Windows.Forms.Button();
            this.lblPlayerHealthFull = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEnemyHealthFull = new System.Windows.Forms.Label();
            this.tmrFinalBattle = new System.Windows.Forms.Timer(this.components);
            this.btnFlee = new System.Windows.Forms.Button();
            this.potion_button = new System.Windows.Forms.Button();
            this.Potion_image = new System.Windows.Forms.PictureBox();
            this.picBossBattle = new System.Windows.Forms.PictureBox();
            this.picEnemy = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.lblPlayerMP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPlayerTP = new System.Windows.Forms.Label();
            this.btnMagic = new System.Windows.Forms.Button();
            this.btnSkills = new System.Windows.Forms.Button();
            this.btnBackMagic = new System.Windows.Forms.Button();
            this.btnPray = new System.Windows.Forms.Button();
            this.btnPyro = new System.Windows.Forms.Button();
            this.btnCutter = new System.Windows.Forms.Button();
            this.btnBackTech = new System.Windows.Forms.Button();
            this.btnMeditate = new System.Windows.Forms.Button();
            this.btnStrike = new System.Windows.Forms.Button();
            this.btnFocus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Potion_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossBattle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAttack
            // 
            this.btnAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttack.Location = new System.Drawing.Point(110, 829);
            this.btnAttack.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(256, 83);
            this.btnAttack.TabIndex = 2;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // lblPlayerHealthFull
            // 
            this.lblPlayerHealthFull.BackColor = System.Drawing.Color.Green;
            this.lblPlayerHealthFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHealthFull.ForeColor = System.Drawing.Color.White;
            this.lblPlayerHealthFull.Location = new System.Drawing.Point(142, 115);
            this.lblPlayerHealthFull.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPlayerHealthFull.Name = "lblPlayerHealthFull";
            this.lblPlayerHealthFull.Size = new System.Drawing.Size(452, 38);
            this.lblPlayerHealthFull.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(1030, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(458, 44);
            this.label2.TabIndex = 5;
            // 
            // lblEnemyHealthFull
            // 
            this.lblEnemyHealthFull.BackColor = System.Drawing.Color.Green;
            this.lblEnemyHealthFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyHealthFull.ForeColor = System.Drawing.Color.White;
            this.lblEnemyHealthFull.Location = new System.Drawing.Point(1032, 115);
            this.lblEnemyHealthFull.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEnemyHealthFull.Name = "lblEnemyHealthFull";
            this.lblEnemyHealthFull.Size = new System.Drawing.Size(452, 38);
            this.lblEnemyHealthFull.TabIndex = 6;
            // 
            // tmrFinalBattle
            // 
            this.tmrFinalBattle.Interval = 5600;
            this.tmrFinalBattle.Tick += new System.EventHandler(this.tmrFinalBattle_Tick);
            // 
            // btnFlee
            // 
            this.btnFlee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlee.Location = new System.Drawing.Point(110, 923);
            this.btnFlee.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnFlee.Name = "btnFlee";
            this.btnFlee.Size = new System.Drawing.Size(256, 83);
            this.btnFlee.TabIndex = 8;
            this.btnFlee.Text = "Flee";
            this.btnFlee.UseVisualStyleBackColor = true;
            this.btnFlee.Click += new System.EventHandler(this.btnFlee_Click);
            // 
            // potion_button
            // 
            this.potion_button.BackColor = System.Drawing.Color.Black;
            this.potion_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.potion_button.Location = new System.Drawing.Point(644, 873);
            this.potion_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.potion_button.Name = "potion_button";
            this.potion_button.Size = new System.Drawing.Size(114, 90);
            this.potion_button.TabIndex = 9;
            this.potion_button.Text = "Take A Chance";
            this.potion_button.UseVisualStyleBackColor = false;
            this.potion_button.Click += new System.EventHandler(this.potion_button_Click);
            // 
            // Potion_image
            // 
            this.Potion_image.Image = global::Fall2020_CSC403_Project.Properties.Resources.Full_Black;
            this.Potion_image.Location = new System.Drawing.Point(140, 48);
            this.Potion_image.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Potion_image.Name = "Potion_image";
            this.Potion_image.Size = new System.Drawing.Size(134, 62);
            this.Potion_image.TabIndex = 10;
            this.Potion_image.TabStop = false;
            // 
            // picBossBattle
            // 
            this.picBossBattle.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.battle_screen;
            this.picBossBattle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBossBattle.Location = new System.Drawing.Point(1560, 1083);
            this.picBossBattle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.picBossBattle.Name = "picBossBattle";
            this.picBossBattle.Size = new System.Drawing.Size(60, 54);
            this.picBossBattle.TabIndex = 7;
            this.picBossBattle.TabStop = false;
            this.picBossBattle.Visible = false;
            // 
            // picEnemy
            // 
            this.picEnemy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picEnemy.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_koolaid;
            this.picEnemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picEnemy.Location = new System.Drawing.Point(1030, 265);
            this.picEnemy.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.picEnemy.Name = "picEnemy";
            this.picEnemy.Size = new System.Drawing.Size(454, 510);
            this.picEnemy.TabIndex = 1;
            this.picEnemy.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPlayer.Location = new System.Drawing.Point(140, 265);
            this.picPlayer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(454, 510);
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // lblPlayerMP
            // 
            this.lblPlayerMP.BackColor = System.Drawing.Color.Blue;
            this.lblPlayerMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerMP.ForeColor = System.Drawing.Color.White;
            this.lblPlayerMP.Location = new System.Drawing.Point(142, 162);
            this.lblPlayerMP.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPlayerMP.Name = "lblPlayerMP";
            this.lblPlayerMP.Size = new System.Drawing.Size(452, 38);
            this.lblPlayerMP.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(140, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 44);
            this.label1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(140, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(458, 44);
            this.label3.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(140, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(458, 44);
            this.label4.TabIndex = 13;
            // 
            // lblPlayerTP
            // 
            this.lblPlayerTP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(255)))));
            this.lblPlayerTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTP.ForeColor = System.Drawing.Color.White;
            this.lblPlayerTP.Location = new System.Drawing.Point(142, 208);
            this.lblPlayerTP.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPlayerTP.Name = "lblPlayerTP";
            this.lblPlayerTP.Size = new System.Drawing.Size(452, 38);
            this.lblPlayerTP.TabIndex = 14;
            // 
            // btnMagic
            // 
            this.btnMagic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMagic.Location = new System.Drawing.Point(378, 829);
            this.btnMagic.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnMagic.Name = "btnMagic";
            this.btnMagic.Size = new System.Drawing.Size(256, 83);
            this.btnMagic.TabIndex = 15;
            this.btnMagic.Text = "Magic";
            this.btnMagic.UseVisualStyleBackColor = true;
            this.btnMagic.Click += new System.EventHandler(this.btnMagic_Click);
            // 
            // btnSkills
            // 
            this.btnSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkills.Location = new System.Drawing.Point(378, 923);
            this.btnSkills.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSkills.Name = "btnSkills";
            this.btnSkills.Size = new System.Drawing.Size(256, 83);
            this.btnSkills.TabIndex = 16;
            this.btnSkills.Text = "Skills";
            this.btnSkills.UseVisualStyleBackColor = true;
            this.btnSkills.Click += new System.EventHandler(this.btnSkills_Click);
            // 
            // btnBackMagic
            // 
            this.btnBackMagic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackMagic.Location = new System.Drawing.Point(378, 923);
            this.btnBackMagic.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnBackMagic.Name = "btnBackMagic";
            this.btnBackMagic.Size = new System.Drawing.Size(256, 83);
            this.btnBackMagic.TabIndex = 20;
            this.btnBackMagic.Text = "Back";
            this.btnBackMagic.UseVisualStyleBackColor = true;
            this.btnBackMagic.Visible = false;
            this.btnBackMagic.Click += new System.EventHandler(this.btnBackMagic_Click);
            // 
            // btnPray
            // 
            this.btnPray.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPray.Location = new System.Drawing.Point(378, 829);
            this.btnPray.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnPray.Name = "btnPray";
            this.btnPray.Size = new System.Drawing.Size(256, 83);
            this.btnPray.TabIndex = 19;
            this.btnPray.Text = "Pray";
            this.btnPray.UseVisualStyleBackColor = true;
            this.btnPray.Visible = false;
            this.btnPray.Click += new System.EventHandler(this.btnPray_Click);
            // 
            // btnPyro
            // 
            this.btnPyro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPyro.Location = new System.Drawing.Point(110, 923);
            this.btnPyro.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnPyro.Name = "btnPyro";
            this.btnPyro.Size = new System.Drawing.Size(256, 83);
            this.btnPyro.TabIndex = 18;
            this.btnPyro.Text = "Pyroclasm";
            this.btnPyro.UseVisualStyleBackColor = true;
            this.btnPyro.Visible = false;
            this.btnPyro.Click += new System.EventHandler(this.btnPyro_Click);
            // 
            // btnCutter
            // 
            this.btnCutter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCutter.Location = new System.Drawing.Point(110, 829);
            this.btnCutter.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCutter.Name = "btnCutter";
            this.btnCutter.Size = new System.Drawing.Size(256, 83);
            this.btnCutter.TabIndex = 17;
            this.btnCutter.Text = "Cutter";
            this.btnCutter.UseVisualStyleBackColor = true;
            this.btnCutter.Visible = false;
            this.btnCutter.Click += new System.EventHandler(this.btnCutter_Click);
            // 
            // btnBackTech
            // 
            this.btnBackTech.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackTech.Location = new System.Drawing.Point(378, 923);
            this.btnBackTech.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnBackTech.Name = "btnBackTech";
            this.btnBackTech.Size = new System.Drawing.Size(256, 83);
            this.btnBackTech.TabIndex = 24;
            this.btnBackTech.Text = "Back";
            this.btnBackTech.UseVisualStyleBackColor = true;
            this.btnBackTech.Visible = false;
            this.btnBackTech.Click += new System.EventHandler(this.btnBackTech_Click);
            // 
            // btnMeditate
            // 
            this.btnMeditate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeditate.Location = new System.Drawing.Point(378, 829);
            this.btnMeditate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnMeditate.Name = "btnMeditate";
            this.btnMeditate.Size = new System.Drawing.Size(256, 83);
            this.btnMeditate.TabIndex = 23;
            this.btnMeditate.Text = "Meditate";
            this.btnMeditate.UseVisualStyleBackColor = true;
            this.btnMeditate.Visible = false;
            this.btnMeditate.Click += new System.EventHandler(this.btnMeditate_Click);
            // 
            // btnStrike
            // 
            this.btnStrike.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStrike.Location = new System.Drawing.Point(110, 923);
            this.btnStrike.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnStrike.Name = "btnStrike";
            this.btnStrike.Size = new System.Drawing.Size(256, 83);
            this.btnStrike.TabIndex = 22;
            this.btnStrike.Text = "Strike";
            this.btnStrike.UseVisualStyleBackColor = true;
            this.btnStrike.Visible = false;
            this.btnStrike.Click += new System.EventHandler(this.btnStrike_Click);
            // 
            // btnFocus
            // 
            this.btnFocus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFocus.Location = new System.Drawing.Point(110, 829);
            this.btnFocus.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnFocus.Name = "btnFocus";
            this.btnFocus.Size = new System.Drawing.Size(256, 83);
            this.btnFocus.TabIndex = 21;
            this.btnFocus.Text = "Focus";
            this.btnFocus.UseVisualStyleBackColor = true;
            this.btnFocus.Visible = false;
            this.btnFocus.Click += new System.EventHandler(this.btnFocus_Click);
            // 
            // FrmBattle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1644, 1063);
            this.Controls.Add(this.btnSkills);
            this.Controls.Add(this.btnMagic);
            this.Controls.Add(this.picBossBattle);
            this.Controls.Add(this.Potion_image);
            this.Controls.Add(this.potion_button);
            this.Controls.Add(this.btnFlee);
            this.Controls.Add(this.lblEnemyHealthFull);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPlayerHealthFull);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.picEnemy);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.lblPlayerMP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPlayerTP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBackMagic);
            this.Controls.Add(this.btnPray);
            this.Controls.Add(this.btnPyro);
            this.Controls.Add(this.btnCutter);
            this.Controls.Add(this.btnBackTech);
            this.Controls.Add(this.btnMeditate);
            this.Controls.Add(this.btnStrike);
            this.Controls.Add(this.btnFocus);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmBattle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fight!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBattle_FormClosing);
            this.Load += new System.EventHandler(this.FrmBattle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Potion_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossBattle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picEnemy;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Label lblPlayerHealthFull;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEnemyHealthFull;
        private System.Windows.Forms.PictureBox picBossBattle;
        private System.Windows.Forms.Timer tmrFinalBattle;
        private System.Windows.Forms.Button btnFlee;
        private System.Windows.Forms.Button potion_button;
        private System.Windows.Forms.PictureBox Potion_image;
        private System.Windows.Forms.Label lblPlayerMP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPlayerTP;
        private System.Windows.Forms.Button btnMagic;
        private System.Windows.Forms.Button btnSkills;
        private System.Windows.Forms.Button btnBackMagic;
        private System.Windows.Forms.Button btnPray;
        private System.Windows.Forms.Button btnPyro;
        private System.Windows.Forms.Button btnCutter;
        private System.Windows.Forms.Button btnBackTech;
        private System.Windows.Forms.Button btnMeditate;
        private System.Windows.Forms.Button btnStrike;
        private System.Windows.Forms.Button btnFocus;
    }
}
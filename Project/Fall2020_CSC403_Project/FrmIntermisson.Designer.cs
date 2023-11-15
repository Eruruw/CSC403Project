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
            this.Store_Panel = new System.Windows.Forms.Panel();
            this.back_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.potion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.store_button = new System.Windows.Forms.Button();
            this.Money = new System.Windows.Forms.Label();
            this.MoneyVal = new System.Windows.Forms.Label();
            this.Store_Panel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            // Store_Panel
            // 
            this.Store_Panel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Store_Panel.Controls.Add(this.MoneyVal);
            this.Store_Panel.Controls.Add(this.Money);
            this.Store_Panel.Controls.Add(this.back_button);
            this.Store_Panel.Controls.Add(this.tableLayoutPanel1);
            this.Store_Panel.Controls.Add(this.label1);
            this.Store_Panel.Location = new System.Drawing.Point(0, 0);
            this.Store_Panel.Name = "Store_Panel";
            this.Store_Panel.Size = new System.Drawing.Size(805, 456);
            this.Store_Panel.TabIndex = 2;
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(15, 14);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(110, 39);
            this.back_button.TabIndex = 2;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 208F));
            this.tableLayoutPanel1.Controls.Add(this.potion, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(82, 212);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(632, 191);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // potion
            // 
            this.potion.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.potion.Image = global::Fall2020_CSC403_Project.Properties.Resources.Full_Black;
            this.potion.Location = new System.Drawing.Point(3, 3);
            this.potion.Name = "potion";
            this.potion.Size = new System.Drawing.Size(206, 89);
            this.potion.TabIndex = 0;
            this.potion.Text = "Health Potion: $100";
            this.potion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.potion.UseVisualStyleBackColor = false;
            this.potion.Click += new System.EventHandler(this.potion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Store";
            // 
            // store_button
            // 
            this.store_button.Location = new System.Drawing.Point(322, 339);
            this.store_button.Name = "store_button";
            this.store_button.Size = new System.Drawing.Size(130, 62);
            this.store_button.TabIndex = 3;
            this.store_button.Text = "Enter the Store";
            this.store_button.UseVisualStyleBackColor = true;
            this.store_button.Click += new System.EventHandler(this.store_button_Click);
            // 
            // Money
            // 
            this.Money.AutoSize = true;
            this.Money.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Money.Location = new System.Drawing.Point(627, 71);
            this.Money.Name = "Money";
            this.Money.Size = new System.Drawing.Size(73, 24);
            this.Money.TabIndex = 3;
            this.Money.Text = "Money:";
            // 
            // MoneyVal
            // 
            this.MoneyVal.AutoSize = true;
            this.MoneyVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneyVal.Location = new System.Drawing.Point(638, 95);
            this.MoneyVal.Name = "MoneyVal";
            this.MoneyVal.Size = new System.Drawing.Size(40, 18);
            this.MoneyVal.TabIndex = 4;
            this.MoneyVal.Text = "$100";
            // 
            // FrmIntermisson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.IntermissionBackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Store_Panel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Continue_Button);
            this.Controls.Add(this.store_button);
            this.Name = "FrmIntermisson";
            this.Text = "Dungeon Slayer 3000";
            this.Store_Panel.ResumeLayout(false);
            this.Store_Panel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Continue_Button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel Store_Panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button potion;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button store_button;
        private System.Windows.Forms.Label MoneyVal;
        private System.Windows.Forms.Label Money;
    }
}
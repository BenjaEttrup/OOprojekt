namespace OOprojekt
{
    partial class FightSystem
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
            this.btnRun = new System.Windows.Forms.Button();
            this.btnFight = new System.Windows.Forms.Button();
            this.prbMonsterHealth = new System.Windows.Forms.ProgressBar();
            this.lblMonsterName = new System.Windows.Forms.Label();
            this.lblPlayerHealth = new System.Windows.Forms.Label();
            this.lblPlayerCP = new System.Windows.Forms.Label();
            this.lblMonsterCP = new System.Windows.Forms.Label();
            this.txbMonsterDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMonsterLvl = new System.Windows.Forms.Label();
            this.lblMonsterHealth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(23, 213);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(113, 28);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnFight
            // 
            this.btnFight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFight.Location = new System.Drawing.Point(182, 213);
            this.btnFight.Name = "btnFight";
            this.btnFight.Size = new System.Drawing.Size(110, 28);
            this.btnFight.TabIndex = 1;
            this.btnFight.Text = "Fight";
            this.btnFight.UseVisualStyleBackColor = true;
            this.btnFight.Click += new System.EventHandler(this.btnFight_Click);
            // 
            // prbMonsterHealth
            // 
            this.prbMonsterHealth.Location = new System.Drawing.Point(17, 37);
            this.prbMonsterHealth.Name = "prbMonsterHealth";
            this.prbMonsterHealth.Size = new System.Drawing.Size(276, 23);
            this.prbMonsterHealth.TabIndex = 2;
            // 
            // lblMonsterName
            // 
            this.lblMonsterName.AutoSize = true;
            this.lblMonsterName.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonsterName.Location = new System.Drawing.Point(19, 63);
            this.lblMonsterName.Name = "lblMonsterName";
            this.lblMonsterName.Size = new System.Drawing.Size(48, 18);
            this.lblMonsterName.TabIndex = 4;
            this.lblMonsterName.Text = "Name:";
            // 
            // lblPlayerHealth
            // 
            this.lblPlayerHealth.AutoSize = true;
            this.lblPlayerHealth.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHealth.Location = new System.Drawing.Point(13, 146);
            this.lblPlayerHealth.Name = "lblPlayerHealth";
            this.lblPlayerHealth.Size = new System.Drawing.Size(53, 18);
            this.lblPlayerHealth.TabIndex = 6;
            this.lblPlayerHealth.Text = "Health";
            // 
            // lblPlayerCP
            // 
            this.lblPlayerCP.AutoSize = true;
            this.lblPlayerCP.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerCP.Location = new System.Drawing.Point(13, 166);
            this.lblPlayerCP.Name = "lblPlayerCP";
            this.lblPlayerCP.Size = new System.Drawing.Size(27, 18);
            this.lblPlayerCP.TabIndex = 7;
            this.lblPlayerCP.Text = "CP";
            // 
            // lblMonsterCP
            // 
            this.lblMonsterCP.AutoSize = true;
            this.lblMonsterCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonsterCP.Location = new System.Drawing.Point(258, 12);
            this.lblMonsterCP.Name = "lblMonsterCP";
            this.lblMonsterCP.Size = new System.Drawing.Size(34, 20);
            this.lblMonsterCP.TabIndex = 8;
            this.lblMonsterCP.Text = "CP:";
            // 
            // txbMonsterDescription
            // 
            this.txbMonsterDescription.Location = new System.Drawing.Point(16, 86);
            this.txbMonsterDescription.Multiline = true;
            this.txbMonsterDescription.Name = "txbMonsterDescription";
            this.txbMonsterDescription.Size = new System.Drawing.Size(276, 33);
            this.txbMonsterDescription.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Charlemagne Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Monsters Stats";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Your Stats";
            // 
            // lblMonsterLvl
            // 
            this.lblMonsterLvl.AutoSize = true;
            this.lblMonsterLvl.Location = new System.Drawing.Point(224, 17);
            this.lblMonsterLvl.Name = "lblMonsterLvl";
            this.lblMonsterLvl.Size = new System.Drawing.Size(21, 13);
            this.lblMonsterLvl.TabIndex = 12;
            this.lblMonsterLvl.Text = "Lvl";
            // 
            // lblMonsterHealth
            // 
            this.lblMonsterHealth.AutoSize = true;
            this.lblMonsterHealth.BackColor = System.Drawing.Color.Transparent;
            this.lblMonsterHealth.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonsterHealth.Location = new System.Drawing.Point(205, 63);
            this.lblMonsterHealth.Name = "lblMonsterHealth";
            this.lblMonsterHealth.Size = new System.Drawing.Size(57, 18);
            this.lblMonsterHealth.TabIndex = 13;
            this.lblMonsterHealth.Text = "Health:";
            // 
            // FightSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 281);
            this.Controls.Add(this.lblMonsterHealth);
            this.Controls.Add(this.lblMonsterLvl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbMonsterDescription);
            this.Controls.Add(this.lblMonsterCP);
            this.Controls.Add(this.lblPlayerCP);
            this.Controls.Add(this.lblPlayerHealth);
            this.Controls.Add(this.lblMonsterName);
            this.Controls.Add(this.prbMonsterHealth);
            this.Controls.Add(this.btnFight);
            this.Controls.Add(this.btnRun);
            this.Name = "FightSystem";
            this.Text = "Monster Fight";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FightSystem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnFight;
        private System.Windows.Forms.ProgressBar prbMonsterHealth;
        private System.Windows.Forms.Label lblMonsterName;
        private System.Windows.Forms.Label lblPlayerHealth;
        private System.Windows.Forms.Label lblPlayerCP;
        private System.Windows.Forms.Label lblMonsterCP;
        private System.Windows.Forms.TextBox txbMonsterDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMonsterLvl;
        private System.Windows.Forms.Label lblMonsterHealth;
    }
}
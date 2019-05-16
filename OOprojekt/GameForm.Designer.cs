namespace OOprojekt
{
    partial class GameForm
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
            this.lblTitel = new System.Windows.Forms.Label();
            this.lblStats = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            this.lstInventory = new System.Windows.Forms.ListBox();
            this.btnUseItem = new System.Windows.Forms.Button();
            this.btnNextTurn = new System.Windows.Forms.Button();
            this.lblInventoryTitel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHealthNumber = new System.Windows.Forms.Label();
            this.lblCPNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.Location = new System.Drawing.Point(109, 9);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(204, 25);
            this.lblTitel.TabIndex = 0;
            this.lblTitel.Text = "????????????????";
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStats.Location = new System.Drawing.Point(119, 284);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(74, 23);
            this.lblStats.TabIndex = 1;
            this.lblStats.Text = "STATS";
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealth.Location = new System.Drawing.Point(120, 307);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(61, 18);
            this.lblHealth.TabIndex = 2;
            this.lblHealth.Text = "Health:";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCP.Location = new System.Drawing.Point(120, 325);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(33, 18);
            this.lblCP.TabIndex = 3;
            this.lblCP.Text = "CP:";
            // 
            // lstInventory
            // 
            this.lstInventory.FormattingEnabled = true;
            this.lstInventory.Location = new System.Drawing.Point(303, 94);
            this.lstInventory.Name = "lstInventory";
            this.lstInventory.Size = new System.Drawing.Size(120, 173);
            this.lstInventory.TabIndex = 4;
            // 
            // btnUseItem
            // 
            this.btnUseItem.Location = new System.Drawing.Point(303, 273);
            this.btnUseItem.Name = "btnUseItem";
            this.btnUseItem.Size = new System.Drawing.Size(120, 23);
            this.btnUseItem.TabIndex = 5;
            this.btnUseItem.Text = "Use selected item";
            this.btnUseItem.UseVisualStyleBackColor = true;
            this.btnUseItem.Click += new System.EventHandler(this.btnUseItem_Click);
            // 
            // btnNextTurn
            // 
            this.btnNextTurn.Location = new System.Drawing.Point(331, 317);
            this.btnNextTurn.Name = "btnNextTurn";
            this.btnNextTurn.Size = new System.Drawing.Size(92, 30);
            this.btnNextTurn.TabIndex = 6;
            this.btnNextTurn.Text = "Next turn";
            this.btnNextTurn.UseVisualStyleBackColor = true;
            this.btnNextTurn.Click += new System.EventHandler(this.btnNextTurn_Click);
            // 
            // lblInventoryTitel
            // 
            this.lblInventoryTitel.AutoSize = true;
            this.lblInventoryTitel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryTitel.Location = new System.Drawing.Point(299, 67);
            this.lblInventoryTitel.Name = "lblInventoryTitel";
            this.lblInventoryTitel.Size = new System.Drawing.Size(85, 21);
            this.lblInventoryTitel.TabIndex = 7;
            this.lblInventoryTitel.Text = "Inventory";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 184);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblHealthNumber
            // 
            this.lblHealthNumber.AutoSize = true;
            this.lblHealthNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealthNumber.Location = new System.Drawing.Point(183, 307);
            this.lblHealthNumber.Name = "lblHealthNumber";
            this.lblHealthNumber.Size = new System.Drawing.Size(16, 18);
            this.lblHealthNumber.TabIndex = 9;
            this.lblHealthNumber.Text = "0";
            // 
            // lblCPNumber
            // 
            this.lblCPNumber.AutoSize = true;
            this.lblCPNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPNumber.Location = new System.Drawing.Point(183, 325);
            this.lblCPNumber.Name = "lblCPNumber";
            this.lblCPNumber.Size = new System.Drawing.Size(16, 18);
            this.lblCPNumber.TabIndex = 10;
            this.lblCPNumber.Text = "0";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 359);
            this.Controls.Add(this.lblCPNumber);
            this.Controls.Add(this.lblHealthNumber);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblInventoryTitel);
            this.Controls.Add(this.btnNextTurn);
            this.Controls.Add(this.btnUseItem);
            this.Controls.Add(this.lstInventory);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.lblTitel);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.ListBox lstInventory;
        private System.Windows.Forms.Button btnUseItem;
        private System.Windows.Forms.Button btnNextTurn;
        private System.Windows.Forms.Label lblInventoryTitel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHealthNumber;
        private System.Windows.Forms.Label lblCPNumber;
    }
}
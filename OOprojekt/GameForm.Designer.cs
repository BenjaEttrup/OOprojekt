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
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.Location = new System.Drawing.Point(187, 9);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(53, 25);
            this.lblTitel.TabIndex = 0;
            this.lblTitel.Text = "Titel";
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStats.Location = new System.Drawing.Point(165, 67);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(49, 24);
            this.lblStats.TabIndex = 1;
            this.lblStats.Text = "Stats";
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealth.Location = new System.Drawing.Point(166, 94);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(47, 16);
            this.lblHealth.TabIndex = 2;
            this.lblHealth.Text = "Health";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCP.Location = new System.Drawing.Point(166, 110);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(23, 15);
            this.lblCP.TabIndex = 3;
            this.lblCP.Text = "CP";
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
            // 
            // btnNextTurn
            // 
            this.btnNextTurn.Location = new System.Drawing.Point(331, 317);
            this.btnNextTurn.Name = "btnNextTurn";
            this.btnNextTurn.Size = new System.Drawing.Size(92, 30);
            this.btnNextTurn.TabIndex = 6;
            this.btnNextTurn.Text = "Next turn";
            this.btnNextTurn.UseVisualStyleBackColor = true;
            // 
            // lblInventoryTitel
            // 
            this.lblInventoryTitel.AutoSize = true;
            this.lblInventoryTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryTitel.Location = new System.Drawing.Point(299, 67);
            this.lblInventoryTitel.Name = "lblInventoryTitel";
            this.lblInventoryTitel.Size = new System.Drawing.Size(86, 24);
            this.lblInventoryTitel.TabIndex = 7;
            this.lblInventoryTitel.Text = "Inventory";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 359);
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
    }
}
namespace InventoryManagement
{
    partial class InventoryManager
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
            this.itemsLabel = new System.Windows.Forms.Label();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.supplyLabel = new System.Windows.Forms.Label();
            this.newPriceTextBox = new System.Windows.Forms.TextBox();
            this.updatePriceButton = new System.Windows.Forms.Button();
            this.updateSupplyButton = new System.Windows.Forms.Button();
            this.newSupplyTextBox = new System.Windows.Forms.TextBox();
            this.addNameTextBox = new System.Windows.Forms.TextBox();
            this.addPriceTextBox = new System.Windows.Forms.TextBox();
            this.addSupplyTextBox = new System.Windows.Forms.TextBox();
            this.addPriceLabel = new System.Windows.Forms.Label();
            this.addNameLabel = new System.Windows.Forms.Label();
            this.addSupplyLabel = new System.Windows.Forms.Label();
            this.addItemButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itemsLabel
            // 
            this.itemsLabel.AutoSize = true;
            this.itemsLabel.Location = new System.Drawing.Point(9, 9);
            this.itemsLabel.Name = "itemsLabel";
            this.itemsLabel.Size = new System.Drawing.Size(35, 13);
            this.itemsLabel.TabIndex = 0;
            this.itemsLabel.Text = "Items:";
            // 
            // itemsListBox
            // 
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.Location = new System.Drawing.Point(12, 25);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(270, 225);
            this.itemsListBox.TabIndex = 1;
            this.itemsListBox.SelectedIndexChanged += new System.EventHandler(this.itemsListBox_SelectedIndexChanged);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(305, 38);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(0, 13);
            this.priceLabel.TabIndex = 2;
            // 
            // supplyLabel
            // 
            this.supplyLabel.AutoSize = true;
            this.supplyLabel.Location = new System.Drawing.Point(305, 73);
            this.supplyLabel.Name = "supplyLabel";
            this.supplyLabel.Size = new System.Drawing.Size(0, 13);
            this.supplyLabel.TabIndex = 3;
            // 
            // newPriceTextBox
            // 
            this.newPriceTextBox.Location = new System.Drawing.Point(182, 259);
            this.newPriceTextBox.Name = "newPriceTextBox";
            this.newPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.newPriceTextBox.TabIndex = 4;
            this.newPriceTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.newPriceTextBox_KeyDown);
            // 
            // updatePriceButton
            // 
            this.updatePriceButton.Location = new System.Drawing.Point(288, 257);
            this.updatePriceButton.Name = "updatePriceButton";
            this.updatePriceButton.Size = new System.Drawing.Size(85, 23);
            this.updatePriceButton.TabIndex = 5;
            this.updatePriceButton.Text = "Update Price";
            this.updatePriceButton.UseVisualStyleBackColor = true;
            this.updatePriceButton.Click += new System.EventHandler(this.updatePriceButton_Click);
            // 
            // updateSupplyButton
            // 
            this.updateSupplyButton.Location = new System.Drawing.Point(288, 283);
            this.updateSupplyButton.Name = "updateSupplyButton";
            this.updateSupplyButton.Size = new System.Drawing.Size(85, 23);
            this.updateSupplyButton.TabIndex = 7;
            this.updateSupplyButton.Text = "Update Supply";
            this.updateSupplyButton.UseVisualStyleBackColor = true;
            this.updateSupplyButton.Click += new System.EventHandler(this.updateSupplyButton_Click);
            // 
            // newSupplyTextBox
            // 
            this.newSupplyTextBox.Location = new System.Drawing.Point(182, 285);
            this.newSupplyTextBox.Name = "newSupplyTextBox";
            this.newSupplyTextBox.Size = new System.Drawing.Size(100, 20);
            this.newSupplyTextBox.TabIndex = 6;
            this.newSupplyTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.newSupplyTextBox_KeyDown);
            // 
            // addNameTextBox
            // 
            this.addNameTextBox.Location = new System.Drawing.Point(65, 259);
            this.addNameTextBox.Name = "addNameTextBox";
            this.addNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.addNameTextBox.TabIndex = 8;
            this.addNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addNameTextBox_KeyDown);
            // 
            // addPriceTextBox
            // 
            this.addPriceTextBox.Location = new System.Drawing.Point(65, 285);
            this.addPriceTextBox.Name = "addPriceTextBox";
            this.addPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.addPriceTextBox.TabIndex = 9;
            this.addPriceTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addPriceTextBox_KeyDown);
            // 
            // addSupplyTextBox
            // 
            this.addSupplyTextBox.Location = new System.Drawing.Point(65, 311);
            this.addSupplyTextBox.Name = "addSupplyTextBox";
            this.addSupplyTextBox.Size = new System.Drawing.Size(100, 20);
            this.addSupplyTextBox.TabIndex = 10;
            this.addSupplyTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addSupplyTextBox_KeyDown);
            // 
            // addPriceLabel
            // 
            this.addPriceLabel.AutoSize = true;
            this.addPriceLabel.Location = new System.Drawing.Point(12, 288);
            this.addPriceLabel.Name = "addPriceLabel";
            this.addPriceLabel.Size = new System.Drawing.Size(34, 13);
            this.addPriceLabel.TabIndex = 12;
            this.addPriceLabel.Text = "Price:";
            // 
            // addNameLabel
            // 
            this.addNameLabel.AutoSize = true;
            this.addNameLabel.Location = new System.Drawing.Point(12, 262);
            this.addNameLabel.Name = "addNameLabel";
            this.addNameLabel.Size = new System.Drawing.Size(38, 13);
            this.addNameLabel.TabIndex = 11;
            this.addNameLabel.Text = "Name:";
            // 
            // addSupplyLabel
            // 
            this.addSupplyLabel.AutoSize = true;
            this.addSupplyLabel.Location = new System.Drawing.Point(12, 314);
            this.addSupplyLabel.Name = "addSupplyLabel";
            this.addSupplyLabel.Size = new System.Drawing.Size(42, 13);
            this.addSupplyLabel.TabIndex = 13;
            this.addSupplyLabel.Text = "Supply:";
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(80, 337);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(85, 23);
            this.addItemButton.TabIndex = 14;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Supply:";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(288, 110);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(85, 23);
            this.removeButton.TabIndex = 17;
            this.removeButton.Text = "Remove Item";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // InventoryManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 369);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.addSupplyLabel);
            this.Controls.Add(this.addPriceLabel);
            this.Controls.Add(this.addNameLabel);
            this.Controls.Add(this.addSupplyTextBox);
            this.Controls.Add(this.addPriceTextBox);
            this.Controls.Add(this.addNameTextBox);
            this.Controls.Add(this.updateSupplyButton);
            this.Controls.Add(this.newSupplyTextBox);
            this.Controls.Add(this.updatePriceButton);
            this.Controls.Add(this.newPriceTextBox);
            this.Controls.Add(this.supplyLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.itemsListBox);
            this.Controls.Add(this.itemsLabel);
            this.Name = "InventoryManager";
            this.Text = "Inventory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InventoryManager_FormClosing);
            this.Load += new System.EventHandler(this.InventoryManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemsLabel;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label supplyLabel;
        private System.Windows.Forms.TextBox newPriceTextBox;
        private System.Windows.Forms.Button updatePriceButton;
        private System.Windows.Forms.Button updateSupplyButton;
        private System.Windows.Forms.TextBox newSupplyTextBox;
        private System.Windows.Forms.TextBox addNameTextBox;
        private System.Windows.Forms.TextBox addPriceTextBox;
        private System.Windows.Forms.TextBox addSupplyTextBox;
        private System.Windows.Forms.Label addPriceLabel;
        private System.Windows.Forms.Label addNameLabel;
        private System.Windows.Forms.Label addSupplyLabel;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button removeButton;
    }
}


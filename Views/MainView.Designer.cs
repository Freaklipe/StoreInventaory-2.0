namespace StoreInventaory_2._0.Views
{
    partial class MainView
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
            this.panel_main = new System.Windows.Forms.Panel();
            this.btn_store = new System.Windows.Forms.Button();
            this.btn_product = new System.Windows.Forms.Button();
            this.btn_inventory = new System.Windows.Forms.Button();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.btn_store);
            this.panel_main.Controls.Add(this.btn_product);
            this.panel_main.Controls.Add(this.btn_inventory);
            this.panel_main.Location = new System.Drawing.Point(1, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(147, 556);
            this.panel_main.TabIndex = 0;
            // 
            // btn_store
            // 
            this.btn_store.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_store.Location = new System.Drawing.Point(3, 203);
            this.btn_store.Name = "btn_store";
            this.btn_store.Size = new System.Drawing.Size(141, 44);
            this.btn_store.TabIndex = 2;
            this.btn_store.Text = "Store";
            this.btn_store.UseVisualStyleBackColor = true;
            // 
            // btn_product
            // 
            this.btn_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_product.Location = new System.Drawing.Point(3, 148);
            this.btn_product.Name = "btn_product";
            this.btn_product.Size = new System.Drawing.Size(141, 44);
            this.btn_product.TabIndex = 1;
            this.btn_product.Text = "Product";
            this.btn_product.UseVisualStyleBackColor = true;
            // 
            // btn_inventory
            // 
            this.btn_inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inventory.Location = new System.Drawing.Point(3, 98);
            this.btn_inventory.Name = "btn_inventory";
            this.btn_inventory.Size = new System.Drawing.Size(141, 44);
            this.btn_inventory.TabIndex = 0;
            this.btn_inventory.Text = "Inventory";
            this.btn_inventory.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 557);
            this.Controls.Add(this.panel_main);
            this.IsMdiContainer = true;
            this.Name = "MainView";
            this.Text = "MainView";
            this.panel_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Button btn_store;
        private System.Windows.Forms.Button btn_product;
        private System.Windows.Forms.Button btn_inventory;
    }
}
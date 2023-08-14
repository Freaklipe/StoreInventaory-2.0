namespace StoreInventaory_2._0.Views
{
    partial class PricipalView
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
            this.tbc_principal = new System.Windows.Forms.TabControl();
            this.tbp_principal = new System.Windows.Forms.TabPage();
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_restore = new System.Windows.Forms.Button();
            this.btn_viewDeleted = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.dgv_list = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.tbp_productDetail = new System.Windows.Forms.TabPage();
            this.btnPD_cancel = new System.Windows.Forms.Button();
            this.btnPD_save = new System.Windows.Forms.Button();
            this.txtPD_description = new System.Windows.Forms.TextBox();
            this.txtPD_name = new System.Windows.Forms.TextBox();
            this.txtPD_code = new System.Windows.Forms.TextBox();
            this.lblPD_description = new System.Windows.Forms.Label();
            this.lblPD_name = new System.Windows.Forms.Label();
            this.lblPD_code = new System.Windows.Forms.Label();
            this.tbp_storeDetail = new System.Windows.Forms.TabPage();
            this.btnSD_cancel = new System.Windows.Forms.Button();
            this.btnSD_save = new System.Windows.Forms.Button();
            this.txtSD_description = new System.Windows.Forms.TextBox();
            this.txtSD_address = new System.Windows.Forms.TextBox();
            this.txtSD_name = new System.Windows.Forms.TextBox();
            this.txtSD_id = new System.Windows.Forms.TextBox();
            this.lblSD_description = new System.Windows.Forms.Label();
            this.lblSD_address = new System.Windows.Forms.Label();
            this.lblSD_name = new System.Windows.Forms.Label();
            this.lblSD_id = new System.Windows.Forms.Label();
            this.tbp_inventoryDetail = new System.Windows.Forms.TabPage();
            this.CBXID_store = new System.Windows.Forms.ComboBox();
            this.txtID_price = new System.Windows.Forms.TextBox();
            this.lblID_price = new System.Windows.Forms.Label();
            this.txtID_stock = new System.Windows.Forms.TextBox();
            this.lblI_stock = new System.Windows.Forms.Label();
            this.lblID_store = new System.Windows.Forms.Label();
            this.btnID_cancel = new System.Windows.Forms.Button();
            this.btnID_save = new System.Windows.Forms.Button();
            this.txtID_name = new System.Windows.Forms.TextBox();
            this.txtID_code = new System.Windows.Forms.TextBox();
            this.lblID_nameProduct = new System.Windows.Forms.Label();
            this.lblID_codeProduct = new System.Windows.Forms.Label();
            this.pnl_principal = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.tbc_principal.SuspendLayout();
            this.tbp_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).BeginInit();
            this.tbp_productDetail.SuspendLayout();
            this.tbp_storeDetail.SuspendLayout();
            this.tbp_inventoryDetail.SuspendLayout();
            this.pnl_principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbc_principal
            // 
            this.tbc_principal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbc_principal.Controls.Add(this.tbp_principal);
            this.tbc_principal.Controls.Add(this.tbp_productDetail);
            this.tbc_principal.Controls.Add(this.tbp_storeDetail);
            this.tbc_principal.Controls.Add(this.tbp_inventoryDetail);
            this.tbc_principal.Location = new System.Drawing.Point(0, 74);
            this.tbc_principal.Name = "tbc_principal";
            this.tbc_principal.SelectedIndex = 0;
            this.tbc_principal.Size = new System.Drawing.Size(800, 376);
            this.tbc_principal.TabIndex = 5;
            // 
            // tbp_principal
            // 
            this.tbp_principal.Controls.Add(this.btn_return);
            this.tbp_principal.Controls.Add(this.btn_restore);
            this.tbp_principal.Controls.Add(this.btn_viewDeleted);
            this.tbp_principal.Controls.Add(this.btn_edit);
            this.tbp_principal.Controls.Add(this.btn_delete);
            this.tbp_principal.Controls.Add(this.btn_add);
            this.tbp_principal.Controls.Add(this.dgv_list);
            this.tbp_principal.Controls.Add(this.btn_search);
            this.tbp_principal.Controls.Add(this.txt_search);
            this.tbp_principal.Location = new System.Drawing.Point(4, 22);
            this.tbp_principal.Name = "tbp_principal";
            this.tbp_principal.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_principal.Size = new System.Drawing.Size(792, 350);
            this.tbp_principal.TabIndex = 0;
            this.tbp_principal.Text = "List";
            this.tbp_principal.UseVisualStyleBackColor = true;
            // 
            // btn_return
            // 
            this.btn_return.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_return.Location = new System.Drawing.Point(693, 319);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(91, 23);
            this.btn_return.TabIndex = 12;
            this.btn_return.Tag = "1";
            this.btn_return.Text = "Return";
            this.btn_return.UseVisualStyleBackColor = true;
            // 
            // btn_restore
            // 
            this.btn_restore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_restore.Location = new System.Drawing.Point(693, 290);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Size = new System.Drawing.Size(91, 23);
            this.btn_restore.TabIndex = 11;
            this.btn_restore.Tag = "1";
            this.btn_restore.Text = "Restore";
            this.btn_restore.UseVisualStyleBackColor = true;
            // 
            // btn_viewDeleted
            // 
            this.btn_viewDeleted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_viewDeleted.Location = new System.Drawing.Point(693, 94);
            this.btn_viewDeleted.Name = "btn_viewDeleted";
            this.btn_viewDeleted.Size = new System.Drawing.Size(91, 23);
            this.btn_viewDeleted.TabIndex = 6;
            this.btn_viewDeleted.Text = "View Deleted";
            this.btn_viewDeleted.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_edit.Location = new System.Drawing.Point(693, 8);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(91, 23);
            this.btn_edit.TabIndex = 5;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.Location = new System.Drawing.Point(693, 65);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(91, 23);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Tag = "0";
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.Location = new System.Drawing.Point(693, 36);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(91, 23);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // dgv_list
            // 
            this.dgv_list.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgv_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_list.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list.Location = new System.Drawing.Point(9, 36);
            this.dgv_list.Name = "dgv_list";
            this.dgv_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_list.Size = new System.Drawing.Size(678, 306);
            this.dgv_list.TabIndex = 2;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.Location = new System.Drawing.Point(6, 6);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(91, 23);
            this.btn_search.TabIndex = 1;
            this.btn_search.Tag = "1";
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_search.Location = new System.Drawing.Point(103, 8);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(584, 20);
            this.txt_search.TabIndex = 0;
            // 
            // tbp_productDetail
            // 
            this.tbp_productDetail.Controls.Add(this.btnPD_cancel);
            this.tbp_productDetail.Controls.Add(this.btnPD_save);
            this.tbp_productDetail.Controls.Add(this.txtPD_description);
            this.tbp_productDetail.Controls.Add(this.txtPD_name);
            this.tbp_productDetail.Controls.Add(this.txtPD_code);
            this.tbp_productDetail.Controls.Add(this.lblPD_description);
            this.tbp_productDetail.Controls.Add(this.lblPD_name);
            this.tbp_productDetail.Controls.Add(this.lblPD_code);
            this.tbp_productDetail.Location = new System.Drawing.Point(4, 22);
            this.tbp_productDetail.Name = "tbp_productDetail";
            this.tbp_productDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_productDetail.Size = new System.Drawing.Size(792, 350);
            this.tbp_productDetail.TabIndex = 2;
            this.tbp_productDetail.Text = "Product Detail";
            this.tbp_productDetail.UseVisualStyleBackColor = true;
            // 
            // btnPD_cancel
            // 
            this.btnPD_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPD_cancel.Location = new System.Drawing.Point(477, 216);
            this.btnPD_cancel.Name = "btnPD_cancel";
            this.btnPD_cancel.Size = new System.Drawing.Size(195, 49);
            this.btnPD_cancel.TabIndex = 19;
            this.btnPD_cancel.Text = "Cancel";
            this.btnPD_cancel.UseVisualStyleBackColor = true;
            // 
            // btnPD_save
            // 
            this.btnPD_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPD_save.Location = new System.Drawing.Point(138, 216);
            this.btnPD_save.Name = "btnPD_save";
            this.btnPD_save.Size = new System.Drawing.Size(195, 49);
            this.btnPD_save.TabIndex = 18;
            this.btnPD_save.Text = "Save";
            this.btnPD_save.UseVisualStyleBackColor = true;
            // 
            // txtPD_description
            // 
            this.txtPD_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPD_description.Location = new System.Drawing.Point(431, 62);
            this.txtPD_description.Multiline = true;
            this.txtPD_description.Name = "txtPD_description";
            this.txtPD_description.Size = new System.Drawing.Size(296, 94);
            this.txtPD_description.TabIndex = 17;
            // 
            // txtPD_name
            // 
            this.txtPD_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPD_name.Location = new System.Drawing.Point(71, 136);
            this.txtPD_name.Name = "txtPD_name";
            this.txtPD_name.Size = new System.Drawing.Size(296, 20);
            this.txtPD_name.TabIndex = 15;
            // 
            // txtPD_code
            // 
            this.txtPD_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPD_code.Location = new System.Drawing.Point(71, 62);
            this.txtPD_code.Name = "txtPD_code";
            this.txtPD_code.ReadOnly = true;
            this.txtPD_code.Size = new System.Drawing.Size(57, 20);
            this.txtPD_code.TabIndex = 14;
            // 
            // lblPD_description
            // 
            this.lblPD_description.AutoSize = true;
            this.lblPD_description.Location = new System.Drawing.Point(428, 46);
            this.lblPD_description.Name = "lblPD_description";
            this.lblPD_description.Size = new System.Drawing.Size(60, 13);
            this.lblPD_description.TabIndex = 13;
            this.lblPD_description.Text = "Description";
            // 
            // lblPD_name
            // 
            this.lblPD_name.AutoSize = true;
            this.lblPD_name.Location = new System.Drawing.Point(68, 120);
            this.lblPD_name.Name = "lblPD_name";
            this.lblPD_name.Size = new System.Drawing.Size(35, 13);
            this.lblPD_name.TabIndex = 11;
            this.lblPD_name.Text = "Name";
            // 
            // lblPD_code
            // 
            this.lblPD_code.AutoSize = true;
            this.lblPD_code.Location = new System.Drawing.Point(68, 46);
            this.lblPD_code.Name = "lblPD_code";
            this.lblPD_code.Size = new System.Drawing.Size(32, 13);
            this.lblPD_code.TabIndex = 10;
            this.lblPD_code.Text = "Code";
            // 
            // tbp_storeDetail
            // 
            this.tbp_storeDetail.Controls.Add(this.btnSD_cancel);
            this.tbp_storeDetail.Controls.Add(this.btnSD_save);
            this.tbp_storeDetail.Controls.Add(this.txtSD_description);
            this.tbp_storeDetail.Controls.Add(this.txtSD_address);
            this.tbp_storeDetail.Controls.Add(this.txtSD_name);
            this.tbp_storeDetail.Controls.Add(this.txtSD_id);
            this.tbp_storeDetail.Controls.Add(this.lblSD_description);
            this.tbp_storeDetail.Controls.Add(this.lblSD_address);
            this.tbp_storeDetail.Controls.Add(this.lblSD_name);
            this.tbp_storeDetail.Controls.Add(this.lblSD_id);
            this.tbp_storeDetail.Location = new System.Drawing.Point(4, 22);
            this.tbp_storeDetail.Name = "tbp_storeDetail";
            this.tbp_storeDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_storeDetail.Size = new System.Drawing.Size(792, 350);
            this.tbp_storeDetail.TabIndex = 3;
            this.tbp_storeDetail.Text = "Store Detail";
            this.tbp_storeDetail.UseVisualStyleBackColor = true;
            // 
            // btnSD_cancel
            // 
            this.btnSD_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSD_cancel.Location = new System.Drawing.Point(479, 255);
            this.btnSD_cancel.Name = "btnSD_cancel";
            this.btnSD_cancel.Size = new System.Drawing.Size(195, 49);
            this.btnSD_cancel.TabIndex = 29;
            this.btnSD_cancel.Text = "Cancel";
            this.btnSD_cancel.UseVisualStyleBackColor = true;
            // 
            // btnSD_save
            // 
            this.btnSD_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSD_save.Location = new System.Drawing.Point(113, 255);
            this.btnSD_save.Name = "btnSD_save";
            this.btnSD_save.Size = new System.Drawing.Size(195, 49);
            this.btnSD_save.TabIndex = 28;
            this.btnSD_save.Text = "Save";
            this.btnSD_save.UseVisualStyleBackColor = true;
            // 
            // txtSD_description
            // 
            this.txtSD_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSD_description.Location = new System.Drawing.Point(431, 62);
            this.txtSD_description.Multiline = true;
            this.txtSD_description.Name = "txtSD_description";
            this.txtSD_description.Size = new System.Drawing.Size(296, 133);
            this.txtSD_description.TabIndex = 27;
            // 
            // txtSD_address
            // 
            this.txtSD_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSD_address.Location = new System.Drawing.Point(68, 175);
            this.txtSD_address.Name = "txtSD_address";
            this.txtSD_address.Size = new System.Drawing.Size(296, 20);
            this.txtSD_address.TabIndex = 26;
            // 
            // txtSD_name
            // 
            this.txtSD_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSD_name.Location = new System.Drawing.Point(68, 119);
            this.txtSD_name.Name = "txtSD_name";
            this.txtSD_name.Size = new System.Drawing.Size(296, 20);
            this.txtSD_name.TabIndex = 25;
            // 
            // txtSD_id
            // 
            this.txtSD_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSD_id.Location = new System.Drawing.Point(68, 62);
            this.txtSD_id.Name = "txtSD_id";
            this.txtSD_id.ReadOnly = true;
            this.txtSD_id.Size = new System.Drawing.Size(57, 20);
            this.txtSD_id.TabIndex = 24;
            // 
            // lblSD_description
            // 
            this.lblSD_description.AutoSize = true;
            this.lblSD_description.Location = new System.Drawing.Point(428, 46);
            this.lblSD_description.Name = "lblSD_description";
            this.lblSD_description.Size = new System.Drawing.Size(60, 13);
            this.lblSD_description.TabIndex = 23;
            this.lblSD_description.Text = "Description";
            // 
            // lblSD_address
            // 
            this.lblSD_address.AutoSize = true;
            this.lblSD_address.Location = new System.Drawing.Point(65, 159);
            this.lblSD_address.Name = "lblSD_address";
            this.lblSD_address.Size = new System.Drawing.Size(45, 13);
            this.lblSD_address.TabIndex = 22;
            this.lblSD_address.Text = "Address";
            // 
            // lblSD_name
            // 
            this.lblSD_name.AutoSize = true;
            this.lblSD_name.Location = new System.Drawing.Point(65, 103);
            this.lblSD_name.Name = "lblSD_name";
            this.lblSD_name.Size = new System.Drawing.Size(35, 13);
            this.lblSD_name.TabIndex = 21;
            this.lblSD_name.Text = "Name";
            // 
            // lblSD_id
            // 
            this.lblSD_id.AutoSize = true;
            this.lblSD_id.Location = new System.Drawing.Point(68, 46);
            this.lblSD_id.Name = "lblSD_id";
            this.lblSD_id.Size = new System.Drawing.Size(18, 13);
            this.lblSD_id.TabIndex = 20;
            this.lblSD_id.Text = "ID";
            // 
            // tbp_inventoryDetail
            // 
            this.tbp_inventoryDetail.Controls.Add(this.CBXID_store);
            this.tbp_inventoryDetail.Controls.Add(this.txtID_price);
            this.tbp_inventoryDetail.Controls.Add(this.lblID_price);
            this.tbp_inventoryDetail.Controls.Add(this.txtID_stock);
            this.tbp_inventoryDetail.Controls.Add(this.lblI_stock);
            this.tbp_inventoryDetail.Controls.Add(this.lblID_store);
            this.tbp_inventoryDetail.Controls.Add(this.btnID_cancel);
            this.tbp_inventoryDetail.Controls.Add(this.btnID_save);
            this.tbp_inventoryDetail.Controls.Add(this.txtID_name);
            this.tbp_inventoryDetail.Controls.Add(this.txtID_code);
            this.tbp_inventoryDetail.Controls.Add(this.lblID_nameProduct);
            this.tbp_inventoryDetail.Controls.Add(this.lblID_codeProduct);
            this.tbp_inventoryDetail.Location = new System.Drawing.Point(4, 22);
            this.tbp_inventoryDetail.Name = "tbp_inventoryDetail";
            this.tbp_inventoryDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_inventoryDetail.Size = new System.Drawing.Size(792, 350);
            this.tbp_inventoryDetail.TabIndex = 4;
            this.tbp_inventoryDetail.Text = "Inventory Detail";
            this.tbp_inventoryDetail.UseVisualStyleBackColor = true;
            // 
            // CBXID_store
            // 
            this.CBXID_store.FormattingEnabled = true;
            this.CBXID_store.Location = new System.Drawing.Point(103, 138);
            this.CBXID_store.Name = "CBXID_store";
            this.CBXID_store.Size = new System.Drawing.Size(150, 21);
            this.CBXID_store.TabIndex = 37;
            // 
            // txtID_price
            // 
            this.txtID_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID_price.Location = new System.Drawing.Point(542, 139);
            this.txtID_price.Name = "txtID_price";
            this.txtID_price.Size = new System.Drawing.Size(150, 20);
            this.txtID_price.TabIndex = 36;
            // 
            // lblID_price
            // 
            this.lblID_price.AutoSize = true;
            this.lblID_price.Location = new System.Drawing.Point(539, 123);
            this.lblID_price.Name = "lblID_price";
            this.lblID_price.Size = new System.Drawing.Size(31, 13);
            this.lblID_price.TabIndex = 35;
            this.lblID_price.Text = "Price";
            // 
            // txtID_stock
            // 
            this.txtID_stock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID_stock.Location = new System.Drawing.Point(333, 139);
            this.txtID_stock.Name = "txtID_stock";
            this.txtID_stock.Size = new System.Drawing.Size(150, 20);
            this.txtID_stock.TabIndex = 34;
            // 
            // lblI_stock
            // 
            this.lblI_stock.AutoSize = true;
            this.lblI_stock.Location = new System.Drawing.Point(330, 123);
            this.lblI_stock.Name = "lblI_stock";
            this.lblI_stock.Size = new System.Drawing.Size(35, 13);
            this.lblI_stock.TabIndex = 33;
            this.lblI_stock.Text = "Stock";
            // 
            // lblID_store
            // 
            this.lblID_store.AutoSize = true;
            this.lblID_store.Location = new System.Drawing.Point(100, 123);
            this.lblID_store.Name = "lblID_store";
            this.lblID_store.Size = new System.Drawing.Size(32, 13);
            this.lblID_store.TabIndex = 32;
            this.lblID_store.Text = "Store";
            // 
            // btnID_cancel
            // 
            this.btnID_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnID_cancel.Location = new System.Drawing.Point(448, 231);
            this.btnID_cancel.Name = "btnID_cancel";
            this.btnID_cancel.Size = new System.Drawing.Size(195, 49);
            this.btnID_cancel.TabIndex = 31;
            this.btnID_cancel.Text = "Cancel";
            this.btnID_cancel.UseVisualStyleBackColor = true;
            // 
            // btnID_save
            // 
            this.btnID_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnID_save.Location = new System.Drawing.Point(142, 231);
            this.btnID_save.Name = "btnID_save";
            this.btnID_save.Size = new System.Drawing.Size(195, 49);
            this.btnID_save.TabIndex = 30;
            this.btnID_save.Text = "Save";
            this.btnID_save.UseVisualStyleBackColor = true;
            // 
            // txtID_name
            // 
            this.txtID_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID_name.Location = new System.Drawing.Point(333, 86);
            this.txtID_name.Name = "txtID_name";
            this.txtID_name.ReadOnly = true;
            this.txtID_name.Size = new System.Drawing.Size(150, 20);
            this.txtID_name.TabIndex = 29;
            // 
            // txtID_code
            // 
            this.txtID_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID_code.Location = new System.Drawing.Point(103, 86);
            this.txtID_code.Name = "txtID_code";
            this.txtID_code.ReadOnly = true;
            this.txtID_code.Size = new System.Drawing.Size(69, 20);
            this.txtID_code.TabIndex = 28;
            // 
            // lblID_nameProduct
            // 
            this.lblID_nameProduct.AutoSize = true;
            this.lblID_nameProduct.Location = new System.Drawing.Point(330, 70);
            this.lblID_nameProduct.Name = "lblID_nameProduct";
            this.lblID_nameProduct.Size = new System.Drawing.Size(35, 13);
            this.lblID_nameProduct.TabIndex = 27;
            this.lblID_nameProduct.Text = "Name";
            // 
            // lblID_codeProduct
            // 
            this.lblID_codeProduct.AutoSize = true;
            this.lblID_codeProduct.Location = new System.Drawing.Point(100, 70);
            this.lblID_codeProduct.Name = "lblID_codeProduct";
            this.lblID_codeProduct.Size = new System.Drawing.Size(32, 13);
            this.lblID_codeProduct.TabIndex = 26;
            this.lblID_codeProduct.Text = "Code";
            // 
            // pnl_principal
            // 
            this.pnl_principal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_principal.Controls.Add(this.btn_close);
            this.pnl_principal.Controls.Add(this.lbl_title);
            this.pnl_principal.Location = new System.Drawing.Point(0, 1);
            this.pnl_principal.Name = "pnl_principal";
            this.pnl_principal.Size = new System.Drawing.Size(800, 67);
            this.pnl_principal.TabIndex = 4;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(763, 4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(32, 29);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(26, 20);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(45, 24);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Title";
            // 
            // PricipalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbc_principal);
            this.Controls.Add(this.pnl_principal);
            this.Name = "PricipalView";
            this.Text = "PricipalView";
            this.tbc_principal.ResumeLayout(false);
            this.tbp_principal.ResumeLayout(false);
            this.tbp_principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).EndInit();
            this.tbp_productDetail.ResumeLayout(false);
            this.tbp_productDetail.PerformLayout();
            this.tbp_storeDetail.ResumeLayout(false);
            this.tbp_storeDetail.PerformLayout();
            this.tbp_inventoryDetail.ResumeLayout(false);
            this.tbp_inventoryDetail.PerformLayout();
            this.pnl_principal.ResumeLayout(false);
            this.pnl_principal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbc_principal;
        private System.Windows.Forms.TabPage tbp_principal;
        private System.Windows.Forms.Button btn_viewDeleted;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dgv_list;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.TabPage tbp_productDetail;
        private System.Windows.Forms.Button btnPD_cancel;
        private System.Windows.Forms.Button btnPD_save;
        private System.Windows.Forms.TextBox txtPD_description;
        private System.Windows.Forms.TextBox txtPD_name;
        private System.Windows.Forms.TextBox txtPD_code;
        private System.Windows.Forms.Label lblPD_description;
        private System.Windows.Forms.Label lblPD_name;
        private System.Windows.Forms.Label lblPD_code;
        private System.Windows.Forms.Panel pnl_principal;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Button btn_restore;
        private System.Windows.Forms.TabPage tbp_storeDetail;
        private System.Windows.Forms.Button btnSD_cancel;
        private System.Windows.Forms.Button btnSD_save;
        private System.Windows.Forms.TextBox txtSD_description;
        private System.Windows.Forms.TextBox txtSD_address;
        private System.Windows.Forms.TextBox txtSD_name;
        private System.Windows.Forms.TextBox txtSD_id;
        private System.Windows.Forms.Label lblSD_description;
        private System.Windows.Forms.Label lblSD_address;
        private System.Windows.Forms.Label lblSD_name;
        private System.Windows.Forms.Label lblSD_id;
        private System.Windows.Forms.TabPage tbp_inventoryDetail;
        private System.Windows.Forms.ComboBox CBXID_store;
        private System.Windows.Forms.TextBox txtID_price;
        private System.Windows.Forms.Label lblID_price;
        private System.Windows.Forms.TextBox txtID_stock;
        private System.Windows.Forms.Label lblI_stock;
        private System.Windows.Forms.Label lblID_store;
        private System.Windows.Forms.Button btnID_cancel;
        private System.Windows.Forms.Button btnID_save;
        private System.Windows.Forms.TextBox txtID_name;
        private System.Windows.Forms.TextBox txtID_code;
        private System.Windows.Forms.Label lblID_nameProduct;
        private System.Windows.Forms.Label lblID_codeProduct;
    }
}
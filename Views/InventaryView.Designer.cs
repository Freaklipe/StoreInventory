namespace StoreInventory.Views
{
    partial class InventaryView
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
            this.panel_inventary = new System.Windows.Forms.Panel();
            this.btnInventary_close = new System.Windows.Forms.Button();
            this.lbl_titleInventary = new System.Windows.Forms.Label();
            this.tbp_ID = new System.Windows.Forms.TabPage();
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
            this.tbp_I = new System.Windows.Forms.TabPage();
            this.btnI_edit = new System.Windows.Forms.Button();
            this.dgvI_list = new System.Windows.Forms.DataGridView();
            this.btnI_search = new System.Windows.Forms.Button();
            this.txtI_search = new System.Windows.Forms.TextBox();
            this.tbc_inventary = new System.Windows.Forms.TabControl();
            this.panel_inventary.SuspendLayout();
            this.tbp_ID.SuspendLayout();
            this.tbp_I.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvI_list)).BeginInit();
            this.tbc_inventary.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_inventary
            // 
            this.panel_inventary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_inventary.Controls.Add(this.btnInventary_close);
            this.panel_inventary.Controls.Add(this.lbl_titleInventary);
            this.panel_inventary.Location = new System.Drawing.Point(0, 1);
            this.panel_inventary.Name = "panel_inventary";
            this.panel_inventary.Size = new System.Drawing.Size(800, 67);
            this.panel_inventary.TabIndex = 4;
            // 
            // btnInventary_close
            // 
            this.btnInventary_close.Location = new System.Drawing.Point(763, 4);
            this.btnInventary_close.Name = "btnInventary_close";
            this.btnInventary_close.Size = new System.Drawing.Size(32, 29);
            this.btnInventary_close.TabIndex = 1;
            this.btnInventary_close.Text = "X";
            this.btnInventary_close.UseVisualStyleBackColor = true;
            // 
            // lbl_titleInventary
            // 
            this.lbl_titleInventary.AutoSize = true;
            this.lbl_titleInventary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titleInventary.Location = new System.Drawing.Point(26, 20);
            this.lbl_titleInventary.Name = "lbl_titleInventary";
            this.lbl_titleInventary.Size = new System.Drawing.Size(85, 24);
            this.lbl_titleInventary.TabIndex = 0;
            this.lbl_titleInventary.Text = "Inventary";
            // 
            // tbp_ID
            // 
            this.tbp_ID.Controls.Add(this.CBXID_store);
            this.tbp_ID.Controls.Add(this.txtID_price);
            this.tbp_ID.Controls.Add(this.lblID_price);
            this.tbp_ID.Controls.Add(this.txtID_stock);
            this.tbp_ID.Controls.Add(this.lblI_stock);
            this.tbp_ID.Controls.Add(this.lblID_store);
            this.tbp_ID.Controls.Add(this.btnID_cancel);
            this.tbp_ID.Controls.Add(this.btnID_save);
            this.tbp_ID.Controls.Add(this.txtID_name);
            this.tbp_ID.Controls.Add(this.txtID_code);
            this.tbp_ID.Controls.Add(this.lblID_nameProduct);
            this.tbp_ID.Controls.Add(this.lblID_codeProduct);
            this.tbp_ID.Location = new System.Drawing.Point(4, 22);
            this.tbp_ID.Name = "tbp_ID";
            this.tbp_ID.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_ID.Size = new System.Drawing.Size(792, 350);
            this.tbp_ID.TabIndex = 2;
            this.tbp_ID.Text = "Detail";
            this.tbp_ID.UseVisualStyleBackColor = true;
            // 
            // CBXID_store
            // 
            this.CBXID_store.FormattingEnabled = true;
            this.CBXID_store.Location = new System.Drawing.Point(71, 114);
            this.CBXID_store.Name = "CBXID_store";
            this.CBXID_store.Size = new System.Drawing.Size(150, 21);
            this.CBXID_store.TabIndex = 25;
            // 
            // txtID_price
            // 
            this.txtID_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID_price.Location = new System.Drawing.Point(510, 115);
            this.txtID_price.Name = "txtID_price";
            this.txtID_price.Size = new System.Drawing.Size(150, 20);
            this.txtID_price.TabIndex = 24;
            // 
            // lblID_price
            // 
            this.lblID_price.AutoSize = true;
            this.lblID_price.Location = new System.Drawing.Point(507, 99);
            this.lblID_price.Name = "lblID_price";
            this.lblID_price.Size = new System.Drawing.Size(31, 13);
            this.lblID_price.TabIndex = 23;
            this.lblID_price.Text = "Price";
            // 
            // txtID_stock
            // 
            this.txtID_stock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID_stock.Location = new System.Drawing.Point(301, 115);
            this.txtID_stock.Name = "txtID_stock";
            this.txtID_stock.Size = new System.Drawing.Size(150, 20);
            this.txtID_stock.TabIndex = 22;
            // 
            // lblI_stock
            // 
            this.lblI_stock.AutoSize = true;
            this.lblI_stock.Location = new System.Drawing.Point(298, 99);
            this.lblI_stock.Name = "lblI_stock";
            this.lblI_stock.Size = new System.Drawing.Size(35, 13);
            this.lblI_stock.TabIndex = 21;
            this.lblI_stock.Text = "Stock";
            // 
            // lblID_store
            // 
            this.lblID_store.AutoSize = true;
            this.lblID_store.Location = new System.Drawing.Point(68, 99);
            this.lblID_store.Name = "lblID_store";
            this.lblID_store.Size = new System.Drawing.Size(32, 13);
            this.lblID_store.TabIndex = 20;
            this.lblID_store.Text = "Store";
            // 
            // btnID_cancel
            // 
            this.btnID_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnID_cancel.Location = new System.Drawing.Point(416, 207);
            this.btnID_cancel.Name = "btnID_cancel";
            this.btnID_cancel.Size = new System.Drawing.Size(195, 49);
            this.btnID_cancel.TabIndex = 19;
            this.btnID_cancel.Text = "Cancel";
            this.btnID_cancel.UseVisualStyleBackColor = true;
            // 
            // btnID_save
            // 
            this.btnID_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnID_save.Location = new System.Drawing.Point(110, 207);
            this.btnID_save.Name = "btnID_save";
            this.btnID_save.Size = new System.Drawing.Size(195, 49);
            this.btnID_save.TabIndex = 18;
            this.btnID_save.Text = "Save";
            this.btnID_save.UseVisualStyleBackColor = true;
            // 
            // txtID_name
            // 
            this.txtID_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID_name.Location = new System.Drawing.Point(301, 62);
            this.txtID_name.Name = "txtID_name";
            this.txtID_name.Size = new System.Drawing.Size(150, 20);
            this.txtID_name.TabIndex = 15;
            // 
            // txtID_code
            // 
            this.txtID_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID_code.Location = new System.Drawing.Point(71, 62);
            this.txtID_code.Name = "txtID_code";
            this.txtID_code.Size = new System.Drawing.Size(69, 20);
            this.txtID_code.TabIndex = 14;
            // 
            // lblID_nameProduct
            // 
            this.lblID_nameProduct.AutoSize = true;
            this.lblID_nameProduct.Location = new System.Drawing.Point(298, 46);
            this.lblID_nameProduct.Name = "lblID_nameProduct";
            this.lblID_nameProduct.Size = new System.Drawing.Size(35, 13);
            this.lblID_nameProduct.TabIndex = 11;
            this.lblID_nameProduct.Text = "Name";
            // 
            // lblID_codeProduct
            // 
            this.lblID_codeProduct.AutoSize = true;
            this.lblID_codeProduct.Location = new System.Drawing.Point(68, 46);
            this.lblID_codeProduct.Name = "lblID_codeProduct";
            this.lblID_codeProduct.Size = new System.Drawing.Size(32, 13);
            this.lblID_codeProduct.TabIndex = 10;
            this.lblID_codeProduct.Text = "Code";
            // 
            // tbp_I
            // 
            this.tbp_I.Controls.Add(this.btnI_edit);
            this.tbp_I.Controls.Add(this.dgvI_list);
            this.tbp_I.Controls.Add(this.btnI_search);
            this.tbp_I.Controls.Add(this.txtI_search);
            this.tbp_I.Location = new System.Drawing.Point(4, 22);
            this.tbp_I.Name = "tbp_I";
            this.tbp_I.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_I.Size = new System.Drawing.Size(792, 350);
            this.tbp_I.TabIndex = 0;
            this.tbp_I.Text = "Inventary";
            this.tbp_I.UseVisualStyleBackColor = true;
            // 
            // btnI_edit
            // 
            this.btnI_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnI_edit.Location = new System.Drawing.Point(693, 6);
            this.btnI_edit.Name = "btnI_edit";
            this.btnI_edit.Size = new System.Drawing.Size(91, 23);
            this.btnI_edit.TabIndex = 5;
            this.btnI_edit.Text = "Edit";
            this.btnI_edit.UseVisualStyleBackColor = true;
            // 
            // dgvI_list
            // 
            this.dgvI_list.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvI_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvI_list.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvI_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvI_list.Location = new System.Drawing.Point(9, 36);
            this.dgvI_list.Name = "dgvI_list";
            this.dgvI_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvI_list.Size = new System.Drawing.Size(775, 306);
            this.dgvI_list.TabIndex = 2;
            // 
            // btnI_search
            // 
            this.btnI_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnI_search.Location = new System.Drawing.Point(6, 6);
            this.btnI_search.Name = "btnI_search";
            this.btnI_search.Size = new System.Drawing.Size(91, 23);
            this.btnI_search.TabIndex = 1;
            this.btnI_search.Tag = "1";
            this.btnI_search.Text = "Search";
            this.btnI_search.UseVisualStyleBackColor = true;
            // 
            // txtI_search
            // 
            this.txtI_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtI_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtI_search.Location = new System.Drawing.Point(103, 8);
            this.txtI_search.Name = "txtI_search";
            this.txtI_search.Size = new System.Drawing.Size(584, 20);
            this.txtI_search.TabIndex = 0;
            // 
            // tbc_inventary
            // 
            this.tbc_inventary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbc_inventary.Controls.Add(this.tbp_I);
            this.tbc_inventary.Controls.Add(this.tbp_ID);
            this.tbc_inventary.Location = new System.Drawing.Point(0, 74);
            this.tbc_inventary.Name = "tbc_inventary";
            this.tbc_inventary.SelectedIndex = 0;
            this.tbc_inventary.Size = new System.Drawing.Size(800, 376);
            this.tbc_inventary.TabIndex = 5;
            // 
            // InventaryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbc_inventary);
            this.Controls.Add(this.panel_inventary);
            this.Name = "InventaryView";
            this.Text = "InventaryView";
            this.panel_inventary.ResumeLayout(false);
            this.panel_inventary.PerformLayout();
            this.tbp_ID.ResumeLayout(false);
            this.tbp_ID.PerformLayout();
            this.tbp_I.ResumeLayout(false);
            this.tbp_I.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvI_list)).EndInit();
            this.tbc_inventary.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_inventary;
        private System.Windows.Forms.Button btnInventary_close;
        private System.Windows.Forms.Label lbl_titleInventary;
        private System.Windows.Forms.TabPage tbp_ID;
        private System.Windows.Forms.Button btnID_cancel;
        private System.Windows.Forms.Button btnID_save;
        private System.Windows.Forms.TextBox txtID_name;
        private System.Windows.Forms.TextBox txtID_code;
        private System.Windows.Forms.Label lblID_nameProduct;
        private System.Windows.Forms.Label lblID_codeProduct;
        private System.Windows.Forms.TabPage tbp_I;
        private System.Windows.Forms.Button btnI_edit;
        private System.Windows.Forms.DataGridView dgvI_list;
        private System.Windows.Forms.Button btnI_search;
        private System.Windows.Forms.TextBox txtI_search;
        private System.Windows.Forms.TabControl tbc_inventary;
        private System.Windows.Forms.TextBox txtID_price;
        private System.Windows.Forms.Label lblID_price;
        private System.Windows.Forms.TextBox txtID_stock;
        private System.Windows.Forms.Label lblI_stock;
        private System.Windows.Forms.Label lblID_store;
        private System.Windows.Forms.ComboBox CBXID_store;
    }
}
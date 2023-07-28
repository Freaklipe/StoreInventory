namespace StoreInventory.Views
{
    partial class ProductView
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
            this.tbc_product = new System.Windows.Forms.TabControl();
            this.tbp_PIO = new System.Windows.Forms.TabPage();
            this.btnPIO_viewDeleted = new System.Windows.Forms.Button();
            this.btnPIO_edit = new System.Windows.Forms.Button();
            this.btnPIO_delete = new System.Windows.Forms.Button();
            this.btnPIO_add = new System.Windows.Forms.Button();
            this.dgvPIO_list = new System.Windows.Forms.DataGridView();
            this.btnPIO_search = new System.Windows.Forms.Button();
            this.txtPIO_search = new System.Windows.Forms.TextBox();
            this.tbp_POS = new System.Windows.Forms.TabPage();
            this.btnPOS_return = new System.Windows.Forms.Button();
            this.btnPOS_restore = new System.Windows.Forms.Button();
            this.dgvPOS_list = new System.Windows.Forms.DataGridView();
            this.btnPOS_search = new System.Windows.Forms.Button();
            this.txtPOS_search = new System.Windows.Forms.TextBox();
            this.tbp_PD = new System.Windows.Forms.TabPage();
            this.btnPD_cancel = new System.Windows.Forms.Button();
            this.btnPD_save = new System.Windows.Forms.Button();
            this.txtPD_description = new System.Windows.Forms.TextBox();
            this.txtPD_name = new System.Windows.Forms.TextBox();
            this.txtPD_code = new System.Windows.Forms.TextBox();
            this.lblPD_description = new System.Windows.Forms.Label();
            this.lblPD_name = new System.Windows.Forms.Label();
            this.lblPD_code = new System.Windows.Forms.Label();
            this.panel_product = new System.Windows.Forms.Panel();
            this.btnProduct_close = new System.Windows.Forms.Button();
            this.lbl_titleProduct = new System.Windows.Forms.Label();
            this.tbc_product.SuspendLayout();
            this.tbp_PIO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPIO_list)).BeginInit();
            this.tbp_POS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPOS_list)).BeginInit();
            this.tbp_PD.SuspendLayout();
            this.panel_product.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbc_product
            // 
            this.tbc_product.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbc_product.Controls.Add(this.tbp_PIO);
            this.tbc_product.Controls.Add(this.tbp_POS);
            this.tbc_product.Controls.Add(this.tbp_PD);
            this.tbc_product.Location = new System.Drawing.Point(0, 74);
            this.tbc_product.Name = "tbc_product";
            this.tbc_product.SelectedIndex = 0;
            this.tbc_product.Size = new System.Drawing.Size(800, 376);
            this.tbc_product.TabIndex = 3;
            // 
            // tbp_PIO
            // 
            this.tbp_PIO.Controls.Add(this.btnPIO_viewDeleted);
            this.tbp_PIO.Controls.Add(this.btnPIO_edit);
            this.tbp_PIO.Controls.Add(this.btnPIO_delete);
            this.tbp_PIO.Controls.Add(this.btnPIO_add);
            this.tbp_PIO.Controls.Add(this.dgvPIO_list);
            this.tbp_PIO.Controls.Add(this.btnPIO_search);
            this.tbp_PIO.Controls.Add(this.txtPIO_search);
            this.tbp_PIO.Location = new System.Drawing.Point(4, 22);
            this.tbp_PIO.Name = "tbp_PIO";
            this.tbp_PIO.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_PIO.Size = new System.Drawing.Size(792, 350);
            this.tbp_PIO.TabIndex = 0;
            this.tbp_PIO.Text = "In Stock";
            this.tbp_PIO.UseVisualStyleBackColor = true;
            // 
            // btnPIO_viewDeleted
            // 
            this.btnPIO_viewDeleted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPIO_viewDeleted.Location = new System.Drawing.Point(693, 123);
            this.btnPIO_viewDeleted.Name = "btnPIO_viewDeleted";
            this.btnPIO_viewDeleted.Size = new System.Drawing.Size(91, 23);
            this.btnPIO_viewDeleted.TabIndex = 6;
            this.btnPIO_viewDeleted.Text = "View Deleted";
            this.btnPIO_viewDeleted.UseVisualStyleBackColor = true;
            // 
            // btnPIO_edit
            // 
            this.btnPIO_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPIO_edit.Location = new System.Drawing.Point(693, 65);
            this.btnPIO_edit.Name = "btnPIO_edit";
            this.btnPIO_edit.Size = new System.Drawing.Size(91, 23);
            this.btnPIO_edit.TabIndex = 5;
            this.btnPIO_edit.Text = "Edit";
            this.btnPIO_edit.UseVisualStyleBackColor = true;
            // 
            // btnPIO_delete
            // 
            this.btnPIO_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPIO_delete.Location = new System.Drawing.Point(693, 94);
            this.btnPIO_delete.Name = "btnPIO_delete";
            this.btnPIO_delete.Size = new System.Drawing.Size(91, 23);
            this.btnPIO_delete.TabIndex = 4;
            this.btnPIO_delete.Tag = "delete";
            this.btnPIO_delete.Text = "Delete";
            this.btnPIO_delete.UseVisualStyleBackColor = true;
            // 
            // btnPIO_add
            // 
            this.btnPIO_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPIO_add.Location = new System.Drawing.Point(693, 36);
            this.btnPIO_add.Name = "btnPIO_add";
            this.btnPIO_add.Size = new System.Drawing.Size(91, 23);
            this.btnPIO_add.TabIndex = 3;
            this.btnPIO_add.Text = "Add";
            this.btnPIO_add.UseVisualStyleBackColor = true;
            // 
            // dgvPIO_list
            // 
            this.dgvPIO_list.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvPIO_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPIO_list.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPIO_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPIO_list.Location = new System.Drawing.Point(9, 36);
            this.dgvPIO_list.Name = "dgvPIO_list";
            this.dgvPIO_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPIO_list.Size = new System.Drawing.Size(678, 306);
            this.dgvPIO_list.TabIndex = 2;
            // 
            // btnPIO_search
            // 
            this.btnPIO_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPIO_search.Location = new System.Drawing.Point(6, 6);
            this.btnPIO_search.Name = "btnPIO_search";
            this.btnPIO_search.Size = new System.Drawing.Size(91, 23);
            this.btnPIO_search.TabIndex = 1;
            this.btnPIO_search.Tag = "1";
            this.btnPIO_search.Text = "Search";
            this.btnPIO_search.UseVisualStyleBackColor = true;
            // 
            // txtPIO_search
            // 
            this.txtPIO_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPIO_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPIO_search.Location = new System.Drawing.Point(103, 8);
            this.txtPIO_search.Name = "txtPIO_search";
            this.txtPIO_search.Size = new System.Drawing.Size(584, 20);
            this.txtPIO_search.TabIndex = 0;
            // 
            // tbp_POS
            // 
            this.tbp_POS.Controls.Add(this.btnPOS_return);
            this.tbp_POS.Controls.Add(this.btnPOS_restore);
            this.tbp_POS.Controls.Add(this.dgvPOS_list);
            this.tbp_POS.Controls.Add(this.btnPOS_search);
            this.tbp_POS.Controls.Add(this.txtPOS_search);
            this.tbp_POS.Location = new System.Drawing.Point(4, 22);
            this.tbp_POS.Name = "tbp_POS";
            this.tbp_POS.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_POS.Size = new System.Drawing.Size(792, 350);
            this.tbp_POS.TabIndex = 1;
            this.tbp_POS.Text = "Out Stock";
            this.tbp_POS.UseVisualStyleBackColor = true;
            // 
            // btnPOS_return
            // 
            this.btnPOS_return.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPOS_return.Location = new System.Drawing.Point(695, 66);
            this.btnPOS_return.Name = "btnPOS_return";
            this.btnPOS_return.Size = new System.Drawing.Size(91, 23);
            this.btnPOS_return.TabIndex = 10;
            this.btnPOS_return.Tag = "1";
            this.btnPOS_return.Text = "Return";
            this.btnPOS_return.UseVisualStyleBackColor = true;
            // 
            // btnPOS_restore
            // 
            this.btnPOS_restore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPOS_restore.Location = new System.Drawing.Point(694, 37);
            this.btnPOS_restore.Name = "btnPOS_restore";
            this.btnPOS_restore.Size = new System.Drawing.Size(91, 23);
            this.btnPOS_restore.TabIndex = 9;
            this.btnPOS_restore.Tag = "restore";
            this.btnPOS_restore.Text = "Restore";
            this.btnPOS_restore.UseVisualStyleBackColor = true;
            // 
            // dgvPOS_list
            // 
            this.dgvPOS_list.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvPOS_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPOS_list.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPOS_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPOS_list.Location = new System.Drawing.Point(10, 37);
            this.dgvPOS_list.Name = "dgvPOS_list";
            this.dgvPOS_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPOS_list.Size = new System.Drawing.Size(678, 306);
            this.dgvPOS_list.TabIndex = 8;
            // 
            // btnPOS_search
            // 
            this.btnPOS_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPOS_search.Location = new System.Drawing.Point(7, 7);
            this.btnPOS_search.Name = "btnPOS_search";
            this.btnPOS_search.Size = new System.Drawing.Size(91, 23);
            this.btnPOS_search.TabIndex = 7;
            this.btnPOS_search.Tag = "0";
            this.btnPOS_search.Text = "Search";
            this.btnPOS_search.UseVisualStyleBackColor = true;
            // 
            // txtPOS_search
            // 
            this.txtPOS_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPOS_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPOS_search.Location = new System.Drawing.Point(104, 9);
            this.txtPOS_search.Name = "txtPOS_search";
            this.txtPOS_search.Size = new System.Drawing.Size(584, 20);
            this.txtPOS_search.TabIndex = 6;
            // 
            // tbp_PD
            // 
            this.tbp_PD.Controls.Add(this.btnPD_cancel);
            this.tbp_PD.Controls.Add(this.btnPD_save);
            this.tbp_PD.Controls.Add(this.txtPD_description);
            this.tbp_PD.Controls.Add(this.txtPD_name);
            this.tbp_PD.Controls.Add(this.txtPD_code);
            this.tbp_PD.Controls.Add(this.lblPD_description);
            this.tbp_PD.Controls.Add(this.lblPD_name);
            this.tbp_PD.Controls.Add(this.lblPD_code);
            this.tbp_PD.Location = new System.Drawing.Point(4, 22);
            this.tbp_PD.Name = "tbp_PD";
            this.tbp_PD.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_PD.Size = new System.Drawing.Size(792, 350);
            this.tbp_PD.TabIndex = 2;
            this.tbp_PD.Text = "Detail";
            this.tbp_PD.UseVisualStyleBackColor = true;
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
            // panel_product
            // 
            this.panel_product.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_product.Controls.Add(this.btnProduct_close);
            this.panel_product.Controls.Add(this.lbl_titleProduct);
            this.panel_product.Location = new System.Drawing.Point(0, 1);
            this.panel_product.Name = "panel_product";
            this.panel_product.Size = new System.Drawing.Size(800, 67);
            this.panel_product.TabIndex = 2;
            // 
            // btnProduct_close
            // 
            this.btnProduct_close.Location = new System.Drawing.Point(763, 4);
            this.btnProduct_close.Name = "btnProduct_close";
            this.btnProduct_close.Size = new System.Drawing.Size(32, 29);
            this.btnProduct_close.TabIndex = 1;
            this.btnProduct_close.Text = "X";
            this.btnProduct_close.UseVisualStyleBackColor = true;
            // 
            // lbl_titleProduct
            // 
            this.lbl_titleProduct.AutoSize = true;
            this.lbl_titleProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titleProduct.Location = new System.Drawing.Point(26, 20);
            this.lbl_titleProduct.Name = "lbl_titleProduct";
            this.lbl_titleProduct.Size = new System.Drawing.Size(84, 24);
            this.lbl_titleProduct.TabIndex = 0;
            this.lbl_titleProduct.Text = "Products";
            // 
            // ProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbc_product);
            this.Controls.Add(this.panel_product);
            this.Name = "ProductView";
            this.Text = "ProductView";
            this.tbc_product.ResumeLayout(false);
            this.tbp_PIO.ResumeLayout(false);
            this.tbp_PIO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPIO_list)).EndInit();
            this.tbp_POS.ResumeLayout(false);
            this.tbp_POS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPOS_list)).EndInit();
            this.tbp_PD.ResumeLayout(false);
            this.tbp_PD.PerformLayout();
            this.panel_product.ResumeLayout(false);
            this.panel_product.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbc_product;
        private System.Windows.Forms.TabPage tbp_PIO;
        private System.Windows.Forms.Button btnPIO_edit;
        private System.Windows.Forms.Button btnPIO_delete;
        private System.Windows.Forms.Button btnPIO_add;
        private System.Windows.Forms.DataGridView dgvPIO_list;
        private System.Windows.Forms.Button btnPIO_search;
        private System.Windows.Forms.TextBox txtPIO_search;
        private System.Windows.Forms.TabPage tbp_POS;
        private System.Windows.Forms.Panel panel_product;
        private System.Windows.Forms.Button btnProduct_close;
        private System.Windows.Forms.Label lbl_titleProduct;
        private System.Windows.Forms.Button btnPOS_restore;
        private System.Windows.Forms.DataGridView dgvPOS_list;
        private System.Windows.Forms.Button btnPOS_search;
        private System.Windows.Forms.TextBox txtPOS_search;
        private System.Windows.Forms.TabPage tbp_PD;
        private System.Windows.Forms.Button btnPD_cancel;
        private System.Windows.Forms.Button btnPD_save;
        private System.Windows.Forms.TextBox txtPD_description;
        private System.Windows.Forms.TextBox txtPD_name;
        private System.Windows.Forms.TextBox txtPD_code;
        private System.Windows.Forms.Label lblPD_description;
        private System.Windows.Forms.Label lblPD_name;
        private System.Windows.Forms.Label lblPD_code;
        private System.Windows.Forms.Button btnPIO_viewDeleted;
        private System.Windows.Forms.Button btnPOS_return;
    }
}
namespace StoreInventory.Views
{
    partial class StoreView
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
            this.panel_store = new System.Windows.Forms.Panel();
            this.btnStore_close = new System.Windows.Forms.Button();
            this.lbl_titleStore = new System.Windows.Forms.Label();
            this.tbc_store = new System.Windows.Forms.TabControl();
            this.tbp_ActiveStore = new System.Windows.Forms.TabPage();
            this.btnAS_viewDeleted = new System.Windows.Forms.Button();
            this.btnAS_edit = new System.Windows.Forms.Button();
            this.btnAS_delete = new System.Windows.Forms.Button();
            this.btnAS_add = new System.Windows.Forms.Button();
            this.dgvAS_list = new System.Windows.Forms.DataGridView();
            this.btnAS_search = new System.Windows.Forms.Button();
            this.txtAS_search = new System.Windows.Forms.TextBox();
            this.tbp_DeletedStore = new System.Windows.Forms.TabPage();
            this.btnDS_return = new System.Windows.Forms.Button();
            this.btnDS_restore = new System.Windows.Forms.Button();
            this.dgvDS_list = new System.Windows.Forms.DataGridView();
            this.btnDS_search = new System.Windows.Forms.Button();
            this.txtDS_search = new System.Windows.Forms.TextBox();
            this.tbp_StoreDetail = new System.Windows.Forms.TabPage();
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
            this.panel_store.SuspendLayout();
            this.tbc_store.SuspendLayout();
            this.tbp_ActiveStore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAS_list)).BeginInit();
            this.tbp_DeletedStore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS_list)).BeginInit();
            this.tbp_StoreDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_store
            // 
            this.panel_store.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_store.Controls.Add(this.btnStore_close);
            this.panel_store.Controls.Add(this.lbl_titleStore);
            this.panel_store.Location = new System.Drawing.Point(0, 1);
            this.panel_store.Name = "panel_store";
            this.panel_store.Size = new System.Drawing.Size(800, 67);
            this.panel_store.TabIndex = 0;
            // 
            // btnStore_close
            // 
            this.btnStore_close.Location = new System.Drawing.Point(763, 4);
            this.btnStore_close.Name = "btnStore_close";
            this.btnStore_close.Size = new System.Drawing.Size(32, 29);
            this.btnStore_close.TabIndex = 1;
            this.btnStore_close.Text = "X";
            this.btnStore_close.UseVisualStyleBackColor = true;
            // 
            // lbl_titleStore
            // 
            this.lbl_titleStore.AutoSize = true;
            this.lbl_titleStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titleStore.Location = new System.Drawing.Point(26, 20);
            this.lbl_titleStore.Name = "lbl_titleStore";
            this.lbl_titleStore.Size = new System.Drawing.Size(63, 24);
            this.lbl_titleStore.TabIndex = 0;
            this.lbl_titleStore.Text = "Stores";
            // 
            // tbc_store
            // 
            this.tbc_store.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbc_store.Controls.Add(this.tbp_ActiveStore);
            this.tbc_store.Controls.Add(this.tbp_DeletedStore);
            this.tbc_store.Controls.Add(this.tbp_StoreDetail);
            this.tbc_store.Location = new System.Drawing.Point(0, 74);
            this.tbc_store.Name = "tbc_store";
            this.tbc_store.SelectedIndex = 0;
            this.tbc_store.Size = new System.Drawing.Size(800, 376);
            this.tbc_store.TabIndex = 1;
            // 
            // tbp_ActiveStore
            // 
            this.tbp_ActiveStore.Controls.Add(this.btnAS_viewDeleted);
            this.tbp_ActiveStore.Controls.Add(this.btnAS_edit);
            this.tbp_ActiveStore.Controls.Add(this.btnAS_delete);
            this.tbp_ActiveStore.Controls.Add(this.btnAS_add);
            this.tbp_ActiveStore.Controls.Add(this.dgvAS_list);
            this.tbp_ActiveStore.Controls.Add(this.btnAS_search);
            this.tbp_ActiveStore.Controls.Add(this.txtAS_search);
            this.tbp_ActiveStore.Location = new System.Drawing.Point(4, 22);
            this.tbp_ActiveStore.Name = "tbp_ActiveStore";
            this.tbp_ActiveStore.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_ActiveStore.Size = new System.Drawing.Size(792, 350);
            this.tbp_ActiveStore.TabIndex = 0;
            this.tbp_ActiveStore.Text = "Active";
            this.tbp_ActiveStore.UseVisualStyleBackColor = true;
            // 
            // btnAS_viewDeleted
            // 
            this.btnAS_viewDeleted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAS_viewDeleted.Location = new System.Drawing.Point(693, 123);
            this.btnAS_viewDeleted.Name = "btnAS_viewDeleted";
            this.btnAS_viewDeleted.Size = new System.Drawing.Size(91, 23);
            this.btnAS_viewDeleted.TabIndex = 6;
            this.btnAS_viewDeleted.Text = "View Deleted";
            this.btnAS_viewDeleted.UseVisualStyleBackColor = true;
            // 
            // btnAS_edit
            // 
            this.btnAS_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAS_edit.Location = new System.Drawing.Point(693, 65);
            this.btnAS_edit.Name = "btnAS_edit";
            this.btnAS_edit.Size = new System.Drawing.Size(91, 23);
            this.btnAS_edit.TabIndex = 5;
            this.btnAS_edit.Text = "Edit";
            this.btnAS_edit.UseVisualStyleBackColor = true;
            // 
            // btnAS_delete
            // 
            this.btnAS_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAS_delete.Location = new System.Drawing.Point(693, 94);
            this.btnAS_delete.Name = "btnAS_delete";
            this.btnAS_delete.Size = new System.Drawing.Size(91, 23);
            this.btnAS_delete.TabIndex = 4;
            this.btnAS_delete.Text = "Delete";
            this.btnAS_delete.UseVisualStyleBackColor = true;
            // 
            // btnAS_add
            // 
            this.btnAS_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAS_add.Location = new System.Drawing.Point(693, 36);
            this.btnAS_add.Name = "btnAS_add";
            this.btnAS_add.Size = new System.Drawing.Size(91, 23);
            this.btnAS_add.TabIndex = 3;
            this.btnAS_add.Text = "Add";
            this.btnAS_add.UseVisualStyleBackColor = true;
            // 
            // dgvAS_list
            // 
            this.dgvAS_list.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvAS_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAS_list.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAS_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAS_list.Location = new System.Drawing.Point(9, 36);
            this.dgvAS_list.Name = "dgvAS_list";
            this.dgvAS_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAS_list.Size = new System.Drawing.Size(678, 306);
            this.dgvAS_list.TabIndex = 2;
            // 
            // btnAS_search
            // 
            this.btnAS_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAS_search.Location = new System.Drawing.Point(6, 6);
            this.btnAS_search.Name = "btnAS_search";
            this.btnAS_search.Size = new System.Drawing.Size(91, 23);
            this.btnAS_search.TabIndex = 1;
            this.btnAS_search.Text = "Search";
            this.btnAS_search.UseVisualStyleBackColor = true;
            // 
            // txtAS_search
            // 
            this.txtAS_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAS_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAS_search.Location = new System.Drawing.Point(103, 8);
            this.txtAS_search.Name = "txtAS_search";
            this.txtAS_search.Size = new System.Drawing.Size(584, 20);
            this.txtAS_search.TabIndex = 0;
            // 
            // tbp_DeletedStore
            // 
            this.tbp_DeletedStore.Controls.Add(this.btnDS_return);
            this.tbp_DeletedStore.Controls.Add(this.btnDS_restore);
            this.tbp_DeletedStore.Controls.Add(this.dgvDS_list);
            this.tbp_DeletedStore.Controls.Add(this.btnDS_search);
            this.tbp_DeletedStore.Controls.Add(this.txtDS_search);
            this.tbp_DeletedStore.Location = new System.Drawing.Point(4, 22);
            this.tbp_DeletedStore.Name = "tbp_DeletedStore";
            this.tbp_DeletedStore.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_DeletedStore.Size = new System.Drawing.Size(792, 350);
            this.tbp_DeletedStore.TabIndex = 1;
            this.tbp_DeletedStore.Text = "Deleted";
            this.tbp_DeletedStore.UseVisualStyleBackColor = true;
            // 
            // btnDS_return
            // 
            this.btnDS_return.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDS_return.Location = new System.Drawing.Point(693, 66);
            this.btnDS_return.Name = "btnDS_return";
            this.btnDS_return.Size = new System.Drawing.Size(91, 23);
            this.btnDS_return.TabIndex = 10;
            this.btnDS_return.Text = "Return";
            this.btnDS_return.UseVisualStyleBackColor = true;
            // 
            // btnDS_restore
            // 
            this.btnDS_restore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDS_restore.Location = new System.Drawing.Point(694, 37);
            this.btnDS_restore.Name = "btnDS_restore";
            this.btnDS_restore.Size = new System.Drawing.Size(91, 23);
            this.btnDS_restore.TabIndex = 9;
            this.btnDS_restore.Text = "Restore";
            this.btnDS_restore.UseVisualStyleBackColor = true;
            // 
            // dgvDS_list
            // 
            this.dgvDS_list.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvDS_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDS_list.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDS_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDS_list.Location = new System.Drawing.Point(10, 37);
            this.dgvDS_list.Name = "dgvDS_list";
            this.dgvDS_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDS_list.Size = new System.Drawing.Size(678, 306);
            this.dgvDS_list.TabIndex = 8;
            // 
            // btnDS_search
            // 
            this.btnDS_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDS_search.Location = new System.Drawing.Point(7, 7);
            this.btnDS_search.Name = "btnDS_search";
            this.btnDS_search.Size = new System.Drawing.Size(91, 23);
            this.btnDS_search.TabIndex = 7;
            this.btnDS_search.Text = "Search";
            this.btnDS_search.UseVisualStyleBackColor = true;
            // 
            // txtDS_search
            // 
            this.txtDS_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDS_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDS_search.Location = new System.Drawing.Point(104, 9);
            this.txtDS_search.Name = "txtDS_search";
            this.txtDS_search.Size = new System.Drawing.Size(584, 20);
            this.txtDS_search.TabIndex = 6;
            // 
            // tbp_StoreDetail
            // 
            this.tbp_StoreDetail.Controls.Add(this.btnSD_cancel);
            this.tbp_StoreDetail.Controls.Add(this.btnSD_save);
            this.tbp_StoreDetail.Controls.Add(this.txtSD_description);
            this.tbp_StoreDetail.Controls.Add(this.txtSD_address);
            this.tbp_StoreDetail.Controls.Add(this.txtSD_name);
            this.tbp_StoreDetail.Controls.Add(this.txtSD_id);
            this.tbp_StoreDetail.Controls.Add(this.lblSD_description);
            this.tbp_StoreDetail.Controls.Add(this.lblSD_address);
            this.tbp_StoreDetail.Controls.Add(this.lblSD_name);
            this.tbp_StoreDetail.Controls.Add(this.lblSD_id);
            this.tbp_StoreDetail.Location = new System.Drawing.Point(4, 22);
            this.tbp_StoreDetail.Name = "tbp_StoreDetail";
            this.tbp_StoreDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_StoreDetail.Size = new System.Drawing.Size(792, 350);
            this.tbp_StoreDetail.TabIndex = 2;
            this.tbp_StoreDetail.Text = "Detail";
            this.tbp_StoreDetail.UseVisualStyleBackColor = true;
            // 
            // btnSD_cancel
            // 
            this.btnSD_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSD_cancel.Location = new System.Drawing.Point(479, 255);
            this.btnSD_cancel.Name = "btnSD_cancel";
            this.btnSD_cancel.Size = new System.Drawing.Size(195, 49);
            this.btnSD_cancel.TabIndex = 19;
            this.btnSD_cancel.Text = "Cancel";
            this.btnSD_cancel.UseVisualStyleBackColor = true;
            // 
            // btnSD_save
            // 
            this.btnSD_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSD_save.Location = new System.Drawing.Point(113, 255);
            this.btnSD_save.Name = "btnSD_save";
            this.btnSD_save.Size = new System.Drawing.Size(195, 49);
            this.btnSD_save.TabIndex = 18;
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
            this.txtSD_description.TabIndex = 17;
            // 
            // txtSD_address
            // 
            this.txtSD_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSD_address.Location = new System.Drawing.Point(68, 175);
            this.txtSD_address.Name = "txtSD_address";
            this.txtSD_address.Size = new System.Drawing.Size(296, 20);
            this.txtSD_address.TabIndex = 16;
            // 
            // txtSD_name
            // 
            this.txtSD_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSD_name.Location = new System.Drawing.Point(68, 119);
            this.txtSD_name.Name = "txtSD_name";
            this.txtSD_name.Size = new System.Drawing.Size(296, 20);
            this.txtSD_name.TabIndex = 15;
            // 
            // txtSD_id
            // 
            this.txtSD_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSD_id.Location = new System.Drawing.Point(68, 62);
            this.txtSD_id.Name = "txtSD_id";
            this.txtSD_id.Size = new System.Drawing.Size(57, 20);
            this.txtSD_id.TabIndex = 14;
            // 
            // lblSD_description
            // 
            this.lblSD_description.AutoSize = true;
            this.lblSD_description.Location = new System.Drawing.Point(428, 46);
            this.lblSD_description.Name = "lblSD_description";
            this.lblSD_description.Size = new System.Drawing.Size(60, 13);
            this.lblSD_description.TabIndex = 13;
            this.lblSD_description.Text = "Description";
            // 
            // lblSD_address
            // 
            this.lblSD_address.AutoSize = true;
            this.lblSD_address.Location = new System.Drawing.Point(65, 159);
            this.lblSD_address.Name = "lblSD_address";
            this.lblSD_address.Size = new System.Drawing.Size(45, 13);
            this.lblSD_address.TabIndex = 12;
            this.lblSD_address.Text = "Address";
            // 
            // lblSD_name
            // 
            this.lblSD_name.AutoSize = true;
            this.lblSD_name.Location = new System.Drawing.Point(65, 103);
            this.lblSD_name.Name = "lblSD_name";
            this.lblSD_name.Size = new System.Drawing.Size(35, 13);
            this.lblSD_name.TabIndex = 11;
            this.lblSD_name.Text = "Name";
            // 
            // lblSD_id
            // 
            this.lblSD_id.AutoSize = true;
            this.lblSD_id.Location = new System.Drawing.Point(68, 46);
            this.lblSD_id.Name = "lblSD_id";
            this.lblSD_id.Size = new System.Drawing.Size(18, 13);
            this.lblSD_id.TabIndex = 10;
            this.lblSD_id.Text = "ID";
            // 
            // StoreView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbc_store);
            this.Controls.Add(this.panel_store);
            this.Name = "StoreView";
            this.Text = "StoreView";
            this.panel_store.ResumeLayout(false);
            this.panel_store.PerformLayout();
            this.tbc_store.ResumeLayout(false);
            this.tbp_ActiveStore.ResumeLayout(false);
            this.tbp_ActiveStore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAS_list)).EndInit();
            this.tbp_DeletedStore.ResumeLayout(false);
            this.tbp_DeletedStore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS_list)).EndInit();
            this.tbp_StoreDetail.ResumeLayout(false);
            this.tbp_StoreDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_store;
        private System.Windows.Forms.TabControl tbc_store;
        private System.Windows.Forms.TabPage tbp_ActiveStore;
        private System.Windows.Forms.TabPage tbp_DeletedStore;
        private System.Windows.Forms.Label lbl_titleStore;
        private System.Windows.Forms.TextBox txtAS_search;
        private System.Windows.Forms.DataGridView dgvAS_list;
        private System.Windows.Forms.Button btnAS_search;
        private System.Windows.Forms.Button btnAS_edit;
        private System.Windows.Forms.Button btnAS_delete;
        private System.Windows.Forms.Button btnAS_add;
        private System.Windows.Forms.Button btnStore_close;
        private System.Windows.Forms.TabPage tbp_StoreDetail;
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
        private System.Windows.Forms.Button btnDS_restore;
        private System.Windows.Forms.DataGridView dgvDS_list;
        private System.Windows.Forms.Button btnDS_search;
        private System.Windows.Forms.TextBox txtDS_search;
        private System.Windows.Forms.Button btnAS_viewDeleted;
        private System.Windows.Forms.Button btnDS_return;
    }
}
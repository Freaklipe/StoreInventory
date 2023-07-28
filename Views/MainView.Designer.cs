namespace StoreInventory.Views
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
            this.btn_stores = new System.Windows.Forms.Button();
            this.btn_products = new System.Windows.Forms.Button();
            this.btn_inventary = new System.Windows.Forms.Button();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.btn_stores);
            this.panel_main.Controls.Add(this.btn_products);
            this.panel_main.Controls.Add(this.btn_inventary);
            this.panel_main.Location = new System.Drawing.Point(2, 1);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(155, 446);
            this.panel_main.TabIndex = 1;
            // 
            // btn_stores
            // 
            this.btn_stores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stores.Location = new System.Drawing.Point(0, 125);
            this.btn_stores.Name = "btn_stores";
            this.btn_stores.Size = new System.Drawing.Size(155, 37);
            this.btn_stores.TabIndex = 2;
            this.btn_stores.Text = "Stores";
            this.btn_stores.UseVisualStyleBackColor = true;
            // 
            // btn_products
            // 
            this.btn_products.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_products.Location = new System.Drawing.Point(0, 82);
            this.btn_products.Name = "btn_products";
            this.btn_products.Size = new System.Drawing.Size(155, 37);
            this.btn_products.TabIndex = 1;
            this.btn_products.Text = "Products";
            this.btn_products.UseVisualStyleBackColor = true;
            // 
            // btn_inventary
            // 
            this.btn_inventary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inventary.Location = new System.Drawing.Point(0, 39);
            this.btn_inventary.Name = "btn_inventary";
            this.btn_inventary.Size = new System.Drawing.Size(155, 37);
            this.btn_inventary.TabIndex = 0;
            this.btn_inventary.Text = "Inventary";
            this.btn_inventary.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 449);
            this.Controls.Add(this.panel_main);
            this.IsMdiContainer = true;
            this.Name = "MainView";
            this.Text = "MainView";
            this.panel_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Button btn_products;
        private System.Windows.Forms.Button btn_inventary;
        private System.Windows.Forms.Button btn_stores;
    }
}
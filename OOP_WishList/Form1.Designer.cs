namespace OOP_WishList
{
    partial class MainForm
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
            this.dgvWishlist = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblItem1 = new System.Windows.Forms.Label();
            this.lblItem2 = new System.Windows.Forms.Label();
            this.btnAddWish = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtItem1 = new System.Windows.Forms.TextBox();
            this.txtItem1Price = new System.Windows.Forms.TextBox();
            this.txtItem2 = new System.Windows.Forms.TextBox();
            this.lblItem1Price = new System.Windows.Forms.Label();
            this.lblItem2Price = new System.Windows.Forms.Label();
            this.txtItem2Price = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWishlist)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWishlist
            // 
            this.dgvWishlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWishlist.Location = new System.Drawing.Point(344, 52);
            this.dgvWishlist.Name = "dgvWishlist";
            this.dgvWishlist.Size = new System.Drawing.Size(420, 351);
            this.dgvWishlist.TabIndex = 0;
            this.dgvWishlist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWishlist_CellContentClick);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 55);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Your Name:";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblItem1
            // 
            this.lblItem1.AutoSize = true;
            this.lblItem1.Location = new System.Drawing.Point(12, 100);
            this.lblItem1.Name = "lblItem1";
            this.lblItem1.Size = new System.Drawing.Size(39, 13);
            this.lblItem1.TabIndex = 2;
            this.lblItem1.Text = "Gift 1:";
            // 
            // lblItem2
            // 
            this.lblItem2.AutoSize = true;
            this.lblItem2.Location = new System.Drawing.Point(12, 191);
            this.lblItem2.Name = "lblItem2";
            this.lblItem2.Size = new System.Drawing.Size(39, 13);
            this.lblItem2.TabIndex = 3;
            this.lblItem2.Text = "Gift 2:";
            // 
            // btnAddWish
            // 
            this.btnAddWish.Location = new System.Drawing.Point(99, 262);
            this.btnAddWish.Name = "btnAddWish";
            this.btnAddWish.Size = new System.Drawing.Size(130, 23);
            this.btnAddWish.TabIndex = 4;
            this.btnAddWish.Text = "Save Wish";
            this.btnAddWish.UseVisualStyleBackColor = true;
            this.btnAddWish.Click += new System.EventHandler(this.btnAddWish_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(99, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(130, 20);
            this.txtName.TabIndex = 5;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtItem1
            // 
            this.txtItem1.Location = new System.Drawing.Point(99, 97);
            this.txtItem1.Name = "txtItem1";
            this.txtItem1.Size = new System.Drawing.Size(130, 20);
            this.txtItem1.TabIndex = 6;
            this.txtItem1.TextChanged += new System.EventHandler(this.txtItem1_TextChanged);
            // 
            // txtItem1Price
            // 
            this.txtItem1Price.Location = new System.Drawing.Point(99, 137);
            this.txtItem1Price.Name = "txtItem1Price";
            this.txtItem1Price.Size = new System.Drawing.Size(130, 20);
            this.txtItem1Price.TabIndex = 7;
            this.txtItem1Price.TextChanged += new System.EventHandler(this.txtItem1Price_TextChanged);
            // 
            // txtItem2
            // 
            this.txtItem2.Location = new System.Drawing.Point(99, 184);
            this.txtItem2.Name = "txtItem2";
            this.txtItem2.Size = new System.Drawing.Size(130, 20);
            this.txtItem2.TabIndex = 8;
            this.txtItem2.TextChanged += new System.EventHandler(this.txtItem2_TextChanged);
            // 
            // lblItem1Price
            // 
            this.lblItem1Price.AutoSize = true;
            this.lblItem1Price.Location = new System.Drawing.Point(12, 140);
            this.lblItem1Price.Name = "lblItem1Price";
            this.lblItem1Price.Size = new System.Drawing.Size(62, 13);
            this.lblItem1Price.TabIndex = 9;
            this.lblItem1Price.Text = "Gift 1 Price:";
            // 
            // lblItem2Price
            // 
            this.lblItem2Price.AutoSize = true;
            this.lblItem2Price.Location = new System.Drawing.Point(12, 227);
            this.lblItem2Price.Name = "lblItem2Price";
            this.lblItem2Price.Size = new System.Drawing.Size(62, 13);
            this.lblItem2Price.TabIndex = 10;
            this.lblItem2Price.Text = "Gift 2 Price:";
            // 
            // txtItem2Price
            // 
            this.txtItem2Price.Location = new System.Drawing.Point(99, 227);
            this.txtItem2Price.Name = "txtItem2Price";
            this.txtItem2Price.Size = new System.Drawing.Size(130, 20);
            this.txtItem2Price.TabIndex = 11;
            this.txtItem2Price.TextChanged += new System.EventHandler(this.txtItem2Price_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtItem2Price);
            this.Controls.Add(this.lblItem2Price);
            this.Controls.Add(this.lblItem1Price);
            this.Controls.Add(this.txtItem2);
            this.Controls.Add(this.txtItem1Price);
            this.Controls.Add(this.txtItem1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnAddWish);
            this.Controls.Add(this.lblItem2);
            this.Controls.Add(this.lblItem1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dgvWishlist);
            this.Name = "MainForm";
            this.Text = "My Wishlist Planner";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWishlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWishlist;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblItem1;
        private System.Windows.Forms.Label lblItem2;
        private System.Windows.Forms.Button btnAddWish;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtItem1;
        private System.Windows.Forms.TextBox txtItem1Price;
        private System.Windows.Forms.TextBox txtItem2;
        private System.Windows.Forms.Label lblItem1Price;
        private System.Windows.Forms.Label lblItem2Price;
        private System.Windows.Forms.TextBox txtItem2Price;
    }
}


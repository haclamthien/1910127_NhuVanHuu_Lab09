
namespace Enity_Framework
{
    partial class Form1
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
            this.tv_Category = new System.Windows.Forms.TreeView();
            this.lv_food = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_addCategory = new System.Windows.Forms.Button();
            this.btn_reload_category = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add_food = new System.Windows.Forms.Button();
            this.btn_reload_food = new System.Windows.Forms.Button();
            this.btn_remove_food = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // tv_Category
            // 
            this.tv_Category.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tv_Category.Location = new System.Drawing.Point(13, 34);
            this.tv_Category.Name = "tv_Category";
            this.tv_Category.Size = new System.Drawing.Size(276, 404);
            this.tv_Category.TabIndex = 0;
            this.tv_Category.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_Category_AfterSelect);
            this.tv_Category.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_Category_NodeMouseDoubleClick);
            // 
            // lv_food
            // 
            this.lv_food.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_food.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lv_food.FullRowSelect = true;
            this.lv_food.GridLines = true;
            this.lv_food.HideSelection = false;
            this.lv_food.Location = new System.Drawing.Point(296, 34);
            this.lv_food.MultiSelect = false;
            this.lv_food.Name = "lv_food";
            this.lv_food.Size = new System.Drawing.Size(689, 404);
            this.lv_food.TabIndex = 1;
            this.lv_food.UseCompatibleStateImageBehavior = false;
            this.lv_food.View = System.Windows.Forms.View.Details;
            this.lv_food.DoubleClick += new System.EventHandler(this.lv_food_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh mục";
            // 
            // btn_addCategory
            // 
            this.btn_addCategory.Location = new System.Drawing.Point(246, 4);
            this.btn_addCategory.Name = "btn_addCategory";
            this.btn_addCategory.Size = new System.Drawing.Size(42, 23);
            this.btn_addCategory.TabIndex = 3;
            this.btn_addCategory.Text = "+";
            this.btn_addCategory.UseVisualStyleBackColor = true;
            this.btn_addCategory.Click += new System.EventHandler(this.btn_addCategory_Click);
            // 
            // btn_reload_category
            // 
            this.btn_reload_category.Location = new System.Drawing.Point(198, 4);
            this.btn_reload_category.Name = "btn_reload_category";
            this.btn_reload_category.Size = new System.Drawing.Size(42, 23);
            this.btn_reload_category.TabIndex = 3;
            this.btn_reload_category.Text = "R";
            this.btn_reload_category.UseVisualStyleBackColor = true;
            this.btn_reload_category.Click += new System.EventHandler(this.btn_reload_category_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thực đơn";
            // 
            // btn_add_food
            // 
            this.btn_add_food.Location = new System.Drawing.Point(943, 5);
            this.btn_add_food.Name = "btn_add_food";
            this.btn_add_food.Size = new System.Drawing.Size(42, 23);
            this.btn_add_food.TabIndex = 3;
            this.btn_add_food.Text = "+";
            this.btn_add_food.UseVisualStyleBackColor = true;
            this.btn_add_food.Click += new System.EventHandler(this.btn_add_food_Click);
            // 
            // btn_reload_food
            // 
            this.btn_reload_food.Location = new System.Drawing.Point(847, 5);
            this.btn_reload_food.Name = "btn_reload_food";
            this.btn_reload_food.Size = new System.Drawing.Size(42, 23);
            this.btn_reload_food.TabIndex = 3;
            this.btn_reload_food.Text = "R";
            this.btn_reload_food.UseVisualStyleBackColor = true;
            this.btn_reload_food.Click += new System.EventHandler(this.btn_reload_food_Click);
            // 
            // btn_remove_food
            // 
            this.btn_remove_food.Location = new System.Drawing.Point(895, 5);
            this.btn_remove_food.Name = "btn_remove_food";
            this.btn_remove_food.Size = new System.Drawing.Size(42, 23);
            this.btn_remove_food.TabIndex = 3;
            this.btn_remove_food.Text = "-";
            this.btn_remove_food.UseVisualStyleBackColor = true;
            this.btn_remove_food.Click += new System.EventHandler(this.btn_remove_food_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã số";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên đồ ăn/thức uống";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ĐV Tính";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giá bán";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nhóm mặt hàng";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ghi chú";
            this.columnHeader6.Width = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 450);
            this.Controls.Add(this.btn_reload_food);
            this.Controls.Add(this.btn_reload_category);
            this.Controls.Add(this.btn_remove_food);
            this.Controls.Add(this.btn_add_food);
            this.Controls.Add(this.btn_addCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv_food);
            this.Controls.Add(this.tv_Category);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tv_Category;
        private System.Windows.Forms.ListView lv_food;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_addCategory;
        private System.Windows.Forms.Button btn_reload_category;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add_food;
        private System.Windows.Forms.Button btn_reload_food;
        private System.Windows.Forms.Button btn_remove_food;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}


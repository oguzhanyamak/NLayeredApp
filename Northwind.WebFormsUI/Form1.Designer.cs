
namespace Northwind.WebFormsUI
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
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxCatName = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxProductName = new System.Windows.Forms.GroupBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxProductAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbxCategory_add = new System.Windows.Forms.ComboBox();
            this.tbxQuantity_add = new System.Windows.Forms.TextBox();
            this.tbxStock_add = new System.Windows.Forms.TextBox();
            this.tbxUnitprice_Add = new System.Windows.Forms.TextBox();
            this.tbxProductName_add = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Update = new System.Windows.Forms.Button();
            this.cbxCategory_Update = new System.Windows.Forms.ComboBox();
            this.tbxQuantity_Update = new System.Windows.Forms.TextBox();
            this.tbxStock_Update = new System.Windows.Forms.TextBox();
            this.tbxUnitPrice_Update = new System.Windows.Forms.TextBox();
            this.tbxProductName_Update = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxCatName.SuspendLayout();
            this.gbxProductName.SuspendLayout();
            this.gbxProductAdd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(12, 344);
            this.dgwProduct.Margin = new System.Windows.Forms.Padding(4);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.Size = new System.Drawing.Size(1084, 185);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // gbxCatName
            // 
            this.gbxCatName.Controls.Add(this.cbxCategory);
            this.gbxCatName.Controls.Add(this.label1);
            this.gbxCatName.Location = new System.Drawing.Point(12, 12);
            this.gbxCatName.Name = "gbxCatName";
            this.gbxCatName.Size = new System.Drawing.Size(418, 100);
            this.gbxCatName.TabIndex = 1;
            this.gbxCatName.TabStop = false;
            this.gbxCatName.Text = "groupBox1";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(78, 35);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(121, 24);
            this.cbxCategory.TabIndex = 0;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori";
            // 
            // gbxProductName
            // 
            this.gbxProductName.Controls.Add(this.tbxProductName);
            this.gbxProductName.Controls.Add(this.label2);
            this.gbxProductName.Location = new System.Drawing.Point(12, 118);
            this.gbxProductName.Name = "gbxProductName";
            this.gbxProductName.Size = new System.Drawing.Size(418, 100);
            this.gbxProductName.TabIndex = 2;
            this.gbxProductName.TabStop = false;
            this.gbxProductName.Text = "groupBox2";
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(78, 42);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(121, 22);
            this.tbxProductName.TabIndex = 2;
            this.tbxProductName.TextChanged += new System.EventHandler(this.tbxProductName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Adı";
            // 
            // gbxProductAdd
            // 
            this.gbxProductAdd.Controls.Add(this.btnAdd);
            this.gbxProductAdd.Controls.Add(this.cbxCategory_add);
            this.gbxProductAdd.Controls.Add(this.tbxQuantity_add);
            this.gbxProductAdd.Controls.Add(this.tbxStock_add);
            this.gbxProductAdd.Controls.Add(this.tbxUnitprice_Add);
            this.gbxProductAdd.Controls.Add(this.tbxProductName_add);
            this.gbxProductAdd.Controls.Add(this.label8);
            this.gbxProductAdd.Controls.Add(this.label7);
            this.gbxProductAdd.Controls.Add(this.label6);
            this.gbxProductAdd.Controls.Add(this.label5);
            this.gbxProductAdd.Controls.Add(this.label4);
            this.gbxProductAdd.Controls.Add(this.label3);
            this.gbxProductAdd.Location = new System.Drawing.Point(494, 13);
            this.gbxProductAdd.Name = "gbxProductAdd";
            this.gbxProductAdd.Size = new System.Drawing.Size(263, 240);
            this.gbxProductAdd.TabIndex = 3;
            this.gbxProductAdd.TabStop = false;
            this.gbxProductAdd.Text = "Ürün Ekle";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(10, 217);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxCategory_add
            // 
            this.cbxCategory_add.FormattingEnabled = true;
            this.cbxCategory_add.Location = new System.Drawing.Point(119, 62);
            this.cbxCategory_add.Name = "cbxCategory_add";
            this.cbxCategory_add.Size = new System.Drawing.Size(121, 24);
            this.cbxCategory_add.TabIndex = 10;
            // 
            // tbxQuantity_add
            // 
            this.tbxQuantity_add.Location = new System.Drawing.Point(119, 177);
            this.tbxQuantity_add.Name = "tbxQuantity_add";
            this.tbxQuantity_add.Size = new System.Drawing.Size(121, 22);
            this.tbxQuantity_add.TabIndex = 9;
            // 
            // tbxStock_add
            // 
            this.tbxStock_add.Location = new System.Drawing.Point(119, 141);
            this.tbxStock_add.Name = "tbxStock_add";
            this.tbxStock_add.Size = new System.Drawing.Size(121, 22);
            this.tbxStock_add.TabIndex = 8;
            // 
            // tbxUnitprice_Add
            // 
            this.tbxUnitprice_Add.Location = new System.Drawing.Point(119, 99);
            this.tbxUnitprice_Add.Name = "tbxUnitprice_Add";
            this.tbxUnitprice_Add.Size = new System.Drawing.Size(121, 22);
            this.tbxUnitprice_Add.TabIndex = 7;
            // 
            // tbxProductName_add
            // 
            this.tbxProductName_add.Location = new System.Drawing.Point(119, 22);
            this.tbxProductName_add.Name = "tbxProductName_add";
            this.tbxProductName_add.Size = new System.Drawing.Size(121, 22);
            this.tbxProductName_add.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Birim Adedi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Stok Adedi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Birim Fiyatı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Kategori";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ürün Adı :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Update);
            this.groupBox1.Controls.Add(this.cbxCategory_Update);
            this.groupBox1.Controls.Add(this.tbxQuantity_Update);
            this.groupBox1.Controls.Add(this.tbxStock_Update);
            this.groupBox1.Controls.Add(this.tbxUnitPrice_Update);
            this.groupBox1.Controls.Add(this.tbxProductName_Update);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Location = new System.Drawing.Point(807, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 240);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Güncelle";
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(10, 217);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(102, 23);
            this.Update.TabIndex = 11;
            this.Update.Text = "Güncelle";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // cbxCategory_Update
            // 
            this.cbxCategory_Update.FormattingEnabled = true;
            this.cbxCategory_Update.Location = new System.Drawing.Point(119, 62);
            this.cbxCategory_Update.Name = "cbxCategory_Update";
            this.cbxCategory_Update.Size = new System.Drawing.Size(121, 24);
            this.cbxCategory_Update.TabIndex = 10;
            // 
            // tbxQuantity_Update
            // 
            this.tbxQuantity_Update.Location = new System.Drawing.Point(119, 177);
            this.tbxQuantity_Update.Name = "tbxQuantity_Update";
            this.tbxQuantity_Update.Size = new System.Drawing.Size(121, 22);
            this.tbxQuantity_Update.TabIndex = 9;
            // 
            // tbxStock_Update
            // 
            this.tbxStock_Update.Location = new System.Drawing.Point(119, 141);
            this.tbxStock_Update.Name = "tbxStock_Update";
            this.tbxStock_Update.Size = new System.Drawing.Size(121, 22);
            this.tbxStock_Update.TabIndex = 8;
            // 
            // tbxUnitPrice_Update
            // 
            this.tbxUnitPrice_Update.Location = new System.Drawing.Point(119, 99);
            this.tbxUnitPrice_Update.Name = "tbxUnitPrice_Update";
            this.tbxUnitPrice_Update.Size = new System.Drawing.Size(121, 22);
            this.tbxUnitPrice_Update.TabIndex = 7;
            // 
            // tbxProductName_Update
            // 
            this.tbxProductName_Update.Location = new System.Drawing.Point(119, 22);
            this.tbxProductName_Update.Name = "tbxProductName_Update";
            this.tbxProductName_Update.Size = new System.Drawing.Size(121, 22);
            this.tbxProductName_Update.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Birim Adedi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Stok Adedi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "Birim Fiyatı";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "Kategori";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 16);
            this.label13.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Ürün Adı :";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(967, 314);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 542);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxProductAdd);
            this.Controls.Add(this.gbxProductName);
            this.Controls.Add(this.gbxCatName);
            this.Controls.Add(this.dgwProduct);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxCatName.ResumeLayout(false);
            this.gbxCatName.PerformLayout();
            this.gbxProductName.ResumeLayout(false);
            this.gbxProductName.PerformLayout();
            this.gbxProductAdd.ResumeLayout(false);
            this.gbxProductAdd.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbxCatName;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxProductName;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxProductAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbxCategory_add;
        private System.Windows.Forms.TextBox tbxQuantity_add;
        private System.Windows.Forms.TextBox tbxStock_add;
        private System.Windows.Forms.TextBox tbxUnitprice_Add;
        private System.Windows.Forms.TextBox tbxProductName_add;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.ComboBox cbxCategory_Update;
        private System.Windows.Forms.TextBox tbxQuantity_Update;
        private System.Windows.Forms.TextBox tbxStock_Update;
        private System.Windows.Forms.TextBox tbxUnitPrice_Update;
        private System.Windows.Forms.TextBox tbxProductName_Update;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnDelete;
    }
}


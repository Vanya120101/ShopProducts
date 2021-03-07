
namespace ShopProducts.Views.Controlls
{
    partial class CartControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserProductsTable = new System.Windows.Forms.DataGridView();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductsQuantityBox = new System.Windows.Forms.TextBox();
            this.AddProductIntoCartButton = new System.Windows.Forms.Button();
            this.ProductsNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.NameProductForDeleteBox = new System.Windows.Forms.TextBox();
            this.DeleteProductFromCartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UserProductsTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserProductsTable
            // 
            this.UserProductsTable.BackgroundColor = System.Drawing.Color.White;
            this.UserProductsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserProductsTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UserProductsTable.Location = new System.Drawing.Point(0, 169);
            this.UserProductsTable.Name = "UserProductsTable";
            this.UserProductsTable.RowHeadersWidth = 51;
            this.UserProductsTable.RowTemplate.Height = 24;
            this.UserProductsTable.Size = new System.Drawing.Size(725, 300);
            this.UserProductsTable.TabIndex = 24;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(669, 20);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 29);
            this.ErrorLabel.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "Количество";
            // 
            // ProductsQuantityBox
            // 
            this.ProductsQuantityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductsQuantityBox.Location = new System.Drawing.Point(180, 60);
            this.ProductsQuantityBox.Name = "ProductsQuantityBox";
            this.ProductsQuantityBox.Size = new System.Drawing.Size(100, 34);
            this.ProductsQuantityBox.TabIndex = 23;
            // 
            // AddProductIntoCartButton
            // 
            this.AddProductIntoCartButton.AutoSize = true;
            this.AddProductIntoCartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddProductIntoCartButton.FlatAppearance.BorderSize = 0;
            this.AddProductIntoCartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProductIntoCartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddProductIntoCartButton.Location = new System.Drawing.Point(30, 110);
            this.AddProductIntoCartButton.Name = "AddProductIntoCartButton";
            this.AddProductIntoCartButton.Size = new System.Drawing.Size(252, 41);
            this.AddProductIntoCartButton.TabIndex = 21;
            this.AddProductIntoCartButton.Text = "Добавить в корзину";
            this.AddProductIntoCartButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddProductIntoCartButton.UseVisualStyleBackColor = true;
            this.AddProductIntoCartButton.Click += new System.EventHandler(this.AddProductIntoCartButton_Click);
            // 
            // ProductsNameBox
            // 
            this.ProductsNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductsNameBox.Location = new System.Drawing.Point(180, 20);
            this.ProductsNameBox.Name = "ProductsNameBox";
            this.ProductsNameBox.Size = new System.Drawing.Size(100, 34);
            this.ProductsNameBox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Название";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.NameProductForDeleteBox);
            this.panel1.Controls.Add(this.DeleteProductFromCartButton);
            this.panel1.Controls.Add(this.ErrorLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ProductsNameBox);
            this.panel1.Controls.Add(this.AddProductIntoCartButton);
            this.panel1.Controls.Add(this.ProductsQuantityBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 163);
            this.panel1.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(356, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 29);
            this.label3.TabIndex = 26;
            this.label3.Text = "Название";
            // 
            // NameProductForDeleteBox
            // 
            this.NameProductForDeleteBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameProductForDeleteBox.Location = new System.Drawing.Point(506, 20);
            this.NameProductForDeleteBox.Name = "NameProductForDeleteBox";
            this.NameProductForDeleteBox.Size = new System.Drawing.Size(100, 34);
            this.NameProductForDeleteBox.TabIndex = 27;
            // 
            // DeleteProductFromCartButton
            // 
            this.DeleteProductFromCartButton.AutoSize = true;
            this.DeleteProductFromCartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteProductFromCartButton.FlatAppearance.BorderSize = 0;
            this.DeleteProductFromCartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteProductFromCartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteProductFromCartButton.Location = new System.Drawing.Point(356, 110);
            this.DeleteProductFromCartButton.Name = "DeleteProductFromCartButton";
            this.DeleteProductFromCartButton.Size = new System.Drawing.Size(262, 41);
            this.DeleteProductFromCartButton.TabIndex = 28;
            this.DeleteProductFromCartButton.Text = "Удалить из корзины";
            this.DeleteProductFromCartButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteProductFromCartButton.UseVisualStyleBackColor = true;
            this.DeleteProductFromCartButton.Click += new System.EventHandler(this.DeleteProductFromCartButton_Click);
            // 
            // CartControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UserProductsTable);
            this.Name = "CartControl";
            this.Size = new System.Drawing.Size(725, 469);
            ((System.ComponentModel.ISupportInitialize)(this.UserProductsTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView UserProductsTable;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProductsQuantityBox;
        private System.Windows.Forms.Button AddProductIntoCartButton;
        private System.Windows.Forms.TextBox ProductsNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameProductForDeleteBox;
        private System.Windows.Forms.Button DeleteProductFromCartButton;
    }
}

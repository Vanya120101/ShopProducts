
namespace ShopProducts.Views
{
    partial class ShopProductsMainForm
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
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.FileMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.SelectTabPage = new System.Windows.Forms.TabPage();
            this.ProductsTable = new System.Windows.Forms.DataGridView();
            this.InsertTabPage = new System.Windows.Forms.TabPage();
            this.UpdateTabPage = new System.Windows.Forms.TabPage();
            this.DeleteTabPage = new System.Windows.Forms.TabPage();
            this.BastetTabPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.NameAddProductBox = new System.Windows.Forms.TextBox();
            this.PriceAddProductBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.ErrorAddProductLabel = new System.Windows.Forms.Label();
            this.ErrorUpdateProductLabel = new System.Windows.Forms.Label();
            this.UpdateProductButton = new System.Windows.Forms.Button();
            this.PriceProductUpdateBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NameProductUpdateBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.IdProductUpdateBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.IdProductDeleteBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ErrorDeleteLabel = new System.Windows.Forms.Label();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            this.IdProductBasketBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AddProductBasketButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MainMenu.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.SelectTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsTable)).BeginInit();
            this.InsertTabPage.SuspendLayout();
            this.UpdateTabPage.SuspendLayout();
            this.DeleteTabPage.SuspendLayout();
            this.BastetTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMainMenu,
            this.ToolsMainMenu,
            this.HelpMainMenu});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(800, 30);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "menuStrip2";
            // 
            // FileMainMenu
            // 
            this.FileMainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitMainMenu});
            this.FileMainMenu.Name = "FileMainMenu";
            this.FileMainMenu.Size = new System.Drawing.Size(59, 24);
            this.FileMainMenu.Text = "Файл";
            // 
            // ExitMainMenu
            // 
            this.ExitMainMenu.Name = "ExitMainMenu";
            this.ExitMainMenu.Size = new System.Drawing.Size(136, 26);
            this.ExitMainMenu.Text = "Выход";
            // 
            // ToolsMainMenu
            // 
            this.ToolsMainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshMainMenu});
            this.ToolsMainMenu.Name = "ToolsMainMenu";
            this.ToolsMainMenu.Size = new System.Drawing.Size(117, 24);
            this.ToolsMainMenu.Text = "Инструменты";
            // 
            // RefreshMainMenu
            // 
            this.RefreshMainMenu.Name = "RefreshMainMenu";
            this.RefreshMainMenu.Size = new System.Drawing.Size(161, 26);
            this.RefreshMainMenu.Text = "Обновить";
            // 
            // HelpMainMenu
            // 
            this.HelpMainMenu.Name = "HelpMainMenu";
            this.HelpMainMenu.Size = new System.Drawing.Size(81, 24);
            this.HelpMainMenu.Text = "Справка";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.SelectTabPage);
            this.TabControl.Controls.Add(this.InsertTabPage);
            this.TabControl.Controls.Add(this.UpdateTabPage);
            this.TabControl.Controls.Add(this.DeleteTabPage);
            this.TabControl.Controls.Add(this.BastetTabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TabControl.Location = new System.Drawing.Point(0, 30);
            this.TabControl.Name = "TabControl";
            this.TabControl.Padding = new System.Drawing.Point(10, 10);
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(800, 420);
            this.TabControl.TabIndex = 2;
            // 
            // SelectTabPage
            // 
            this.SelectTabPage.Controls.Add(this.ProductsTable);
            this.SelectTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectTabPage.Location = new System.Drawing.Point(4, 48);
            this.SelectTabPage.Name = "SelectTabPage";
            this.SelectTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SelectTabPage.Size = new System.Drawing.Size(792, 368);
            this.SelectTabPage.TabIndex = 0;
            this.SelectTabPage.Text = "Select";
            this.SelectTabPage.UseVisualStyleBackColor = true;
            // 
            // ProductsTable
            // 
            this.ProductsTable.BackgroundColor = System.Drawing.Color.White;
            this.ProductsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductsTable.GridColor = System.Drawing.Color.Black;
            this.ProductsTable.Location = new System.Drawing.Point(3, 3);
            this.ProductsTable.Name = "ProductsTable";
            this.ProductsTable.ReadOnly = true;
            this.ProductsTable.RowHeadersWidth = 51;
            this.ProductsTable.RowTemplate.Height = 24;
            this.ProductsTable.Size = new System.Drawing.Size(786, 362);
            this.ProductsTable.TabIndex = 0;
            // 
            // InsertTabPage
            // 
            this.InsertTabPage.Controls.Add(this.ErrorAddProductLabel);
            this.InsertTabPage.Controls.Add(this.AddProductButton);
            this.InsertTabPage.Controls.Add(this.PriceAddProductBox);
            this.InsertTabPage.Controls.Add(this.label3);
            this.InsertTabPage.Controls.Add(this.NameAddProductBox);
            this.InsertTabPage.Controls.Add(this.label1);
            this.InsertTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsertTabPage.Location = new System.Drawing.Point(4, 48);
            this.InsertTabPage.Name = "InsertTabPage";
            this.InsertTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.InsertTabPage.Size = new System.Drawing.Size(792, 368);
            this.InsertTabPage.TabIndex = 1;
            this.InsertTabPage.Text = "Insert";
            this.InsertTabPage.UseVisualStyleBackColor = true;
            // 
            // UpdateTabPage
            // 
            this.UpdateTabPage.Controls.Add(this.IdProductUpdateBox);
            this.UpdateTabPage.Controls.Add(this.label6);
            this.UpdateTabPage.Controls.Add(this.ErrorUpdateProductLabel);
            this.UpdateTabPage.Controls.Add(this.UpdateProductButton);
            this.UpdateTabPage.Controls.Add(this.PriceProductUpdateBox);
            this.UpdateTabPage.Controls.Add(this.label4);
            this.UpdateTabPage.Controls.Add(this.NameProductUpdateBox);
            this.UpdateTabPage.Controls.Add(this.label5);
            this.UpdateTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateTabPage.Location = new System.Drawing.Point(4, 48);
            this.UpdateTabPage.Name = "UpdateTabPage";
            this.UpdateTabPage.Size = new System.Drawing.Size(792, 368);
            this.UpdateTabPage.TabIndex = 2;
            this.UpdateTabPage.Text = "Update";
            this.UpdateTabPage.UseVisualStyleBackColor = true;
            // 
            // DeleteTabPage
            // 
            this.DeleteTabPage.Controls.Add(this.IdProductDeleteBox);
            this.DeleteTabPage.Controls.Add(this.label2);
            this.DeleteTabPage.Controls.Add(this.ErrorDeleteLabel);
            this.DeleteTabPage.Controls.Add(this.DeleteProductButton);
            this.DeleteTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteTabPage.Location = new System.Drawing.Point(4, 48);
            this.DeleteTabPage.Name = "DeleteTabPage";
            this.DeleteTabPage.Size = new System.Drawing.Size(792, 368);
            this.DeleteTabPage.TabIndex = 3;
            this.DeleteTabPage.Text = "Delete";
            this.DeleteTabPage.UseVisualStyleBackColor = true;
            // 
            // BastetTabPage
            // 
            this.BastetTabPage.Controls.Add(this.dataGridView1);
            this.BastetTabPage.Controls.Add(this.IdProductBasketBox);
            this.BastetTabPage.Controls.Add(this.label7);
            this.BastetTabPage.Controls.Add(this.label8);
            this.BastetTabPage.Controls.Add(this.AddProductBasketButton);
            this.BastetTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BastetTabPage.Location = new System.Drawing.Point(4, 48);
            this.BastetTabPage.Name = "BastetTabPage";
            this.BastetTabPage.Size = new System.Drawing.Size(792, 368);
            this.BastetTabPage.TabIndex = 4;
            this.BastetTabPage.Text = "Корзина";
            this.BastetTabPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // NameAddProductBox
            // 
            this.NameAddProductBox.Location = new System.Drawing.Point(200, 50);
            this.NameAddProductBox.Name = "NameAddProductBox";
            this.NameAddProductBox.Size = new System.Drawing.Size(100, 34);
            this.NameAddProductBox.TabIndex = 1;
            // 
            // PriceAddProductBox
            // 
            this.PriceAddProductBox.Location = new System.Drawing.Point(200, 100);
            this.PriceAddProductBox.Name = "PriceAddProductBox";
            this.PriceAddProductBox.Size = new System.Drawing.Size(100, 34);
            this.PriceAddProductBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Цена";
            // 
            // AddProductButton
            // 
            this.AddProductButton.AutoSize = true;
            this.AddProductButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddProductButton.FlatAppearance.BorderSize = 0;
            this.AddProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProductButton.Location = new System.Drawing.Point(30, 150);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(135, 41);
            this.AddProductButton.TabIndex = 6;
            this.AddProductButton.Text = "Добавить";
            this.AddProductButton.UseVisualStyleBackColor = true;
            // 
            // ErrorAddProductLabel
            // 
            this.ErrorAddProductLabel.AutoSize = true;
            this.ErrorAddProductLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorAddProductLabel.Location = new System.Drawing.Point(351, 54);
            this.ErrorAddProductLabel.Name = "ErrorAddProductLabel";
            this.ErrorAddProductLabel.Size = new System.Drawing.Size(0, 29);
            this.ErrorAddProductLabel.TabIndex = 7;
            this.ErrorAddProductLabel.Visible = false;
            // 
            // ErrorUpdateProductLabel
            // 
            this.ErrorUpdateProductLabel.AutoSize = true;
            this.ErrorUpdateProductLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorUpdateProductLabel.Location = new System.Drawing.Point(345, 47);
            this.ErrorUpdateProductLabel.Name = "ErrorUpdateProductLabel";
            this.ErrorUpdateProductLabel.Size = new System.Drawing.Size(0, 29);
            this.ErrorUpdateProductLabel.TabIndex = 13;
            this.ErrorUpdateProductLabel.Visible = false;
            // 
            // UpdateProductButton
            // 
            this.UpdateProductButton.AutoSize = true;
            this.UpdateProductButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateProductButton.FlatAppearance.BorderSize = 0;
            this.UpdateProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateProductButton.Location = new System.Drawing.Point(30, 200);
            this.UpdateProductButton.Name = "UpdateProductButton";
            this.UpdateProductButton.Size = new System.Drawing.Size(138, 41);
            this.UpdateProductButton.TabIndex = 12;
            this.UpdateProductButton.Text = "Обновить";
            this.UpdateProductButton.UseVisualStyleBackColor = true;
            // 
            // PriceProductUpdateBox
            // 
            this.PriceProductUpdateBox.Location = new System.Drawing.Point(200, 150);
            this.PriceProductUpdateBox.Name = "PriceProductUpdateBox";
            this.PriceProductUpdateBox.Size = new System.Drawing.Size(100, 34);
            this.PriceProductUpdateBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Цена";
            // 
            // NameProductUpdateBox
            // 
            this.NameProductUpdateBox.Location = new System.Drawing.Point(200, 100);
            this.NameProductUpdateBox.Name = "NameProductUpdateBox";
            this.NameProductUpdateBox.Size = new System.Drawing.Size(100, 34);
            this.NameProductUpdateBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Название";
            // 
            // IdProductUpdateBox
            // 
            this.IdProductUpdateBox.Location = new System.Drawing.Point(200, 50);
            this.IdProductUpdateBox.Name = "IdProductUpdateBox";
            this.IdProductUpdateBox.Size = new System.Drawing.Size(100, 34);
            this.IdProductUpdateBox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "ID продукта";
            // 
            // IdProductDeleteBox
            // 
            this.IdProductDeleteBox.Location = new System.Drawing.Point(200, 50);
            this.IdProductDeleteBox.Name = "IdProductDeleteBox";
            this.IdProductDeleteBox.Size = new System.Drawing.Size(100, 34);
            this.IdProductDeleteBox.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "ID продукта";
            // 
            // ErrorDeleteLabel
            // 
            this.ErrorDeleteLabel.AutoSize = true;
            this.ErrorDeleteLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorDeleteLabel.Location = new System.Drawing.Point(371, 43);
            this.ErrorDeleteLabel.Name = "ErrorDeleteLabel";
            this.ErrorDeleteLabel.Size = new System.Drawing.Size(0, 29);
            this.ErrorDeleteLabel.TabIndex = 21;
            this.ErrorDeleteLabel.Visible = false;
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.AutoSize = true;
            this.DeleteProductButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteProductButton.FlatAppearance.BorderSize = 0;
            this.DeleteProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteProductButton.Location = new System.Drawing.Point(30, 100);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(138, 41);
            this.DeleteProductButton.TabIndex = 20;
            this.DeleteProductButton.Text = "Удалить";
            this.DeleteProductButton.UseVisualStyleBackColor = true;
            // 
            // IdProductBasketBox
            // 
            this.IdProductBasketBox.Location = new System.Drawing.Point(200, 50);
            this.IdProductBasketBox.Name = "IdProductBasketBox";
            this.IdProductBasketBox.Size = new System.Drawing.Size(100, 34);
            this.IdProductBasketBox.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 29);
            this.label7.TabIndex = 26;
            this.label7.Text = "ID продукта";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(369, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 29);
            this.label8.TabIndex = 25;
            this.label8.Visible = false;
            // 
            // AddProductBasketButton
            // 
            this.AddProductBasketButton.AutoSize = true;
            this.AddProductBasketButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddProductBasketButton.FlatAppearance.BorderSize = 0;
            this.AddProductBasketButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProductBasketButton.Location = new System.Drawing.Point(30, 100);
            this.AddProductBasketButton.Name = "AddProductBasketButton";
            this.AddProductBasketButton.Size = new System.Drawing.Size(138, 41);
            this.AddProductBasketButton.TabIndex = 24;
            this.AddProductBasketButton.Text = "Добавить";
            this.AddProductBasketButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(346, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(446, 368);
            this.dataGridView1.TabIndex = 28;
            // 
            // ShopProductsMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.MainMenu);
            this.Name = "ShopProductsMainForm";
            this.Text = "ShopProductsMainForm";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.SelectTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsTable)).EndInit();
            this.InsertTabPage.ResumeLayout(false);
            this.InsertTabPage.PerformLayout();
            this.UpdateTabPage.ResumeLayout(false);
            this.UpdateTabPage.PerformLayout();
            this.DeleteTabPage.ResumeLayout(false);
            this.DeleteTabPage.PerformLayout();
            this.BastetTabPage.ResumeLayout(false);
            this.BastetTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem FileMainMenu;
        private System.Windows.Forms.ToolStripMenuItem ToolsMainMenu;
        private System.Windows.Forms.ToolStripMenuItem HelpMainMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitMainMenu;
        private System.Windows.Forms.ToolStripMenuItem RefreshMainMenu;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage SelectTabPage;
        private System.Windows.Forms.TabPage InsertTabPage;
        private System.Windows.Forms.TabPage UpdateTabPage;
        private System.Windows.Forms.TabPage DeleteTabPage;
        private System.Windows.Forms.TabPage BastetTabPage;
        private System.Windows.Forms.DataGridView ProductsTable;
        private System.Windows.Forms.Label ErrorAddProductLabel;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.TextBox PriceAddProductBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameAddProductBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdProductUpdateBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ErrorUpdateProductLabel;
        private System.Windows.Forms.Button UpdateProductButton;
        private System.Windows.Forms.TextBox PriceProductUpdateBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameProductUpdateBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IdProductDeleteBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ErrorDeleteLabel;
        private System.Windows.Forms.Button DeleteProductButton;
        private System.Windows.Forms.TextBox IdProductBasketBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button AddProductBasketButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
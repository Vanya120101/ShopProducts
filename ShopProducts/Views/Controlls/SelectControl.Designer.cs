
namespace ShopProducts.Views.Controlls
{
    partial class SelectControl
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
            this.ProductsTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsTable
            // 
            this.ProductsTable.BackgroundColor = System.Drawing.Color.White;
            this.ProductsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductsTable.Location = new System.Drawing.Point(0, 0);
            this.ProductsTable.Name = "ProductsTable";
            this.ProductsTable.RowHeadersWidth = 51;
            this.ProductsTable.RowTemplate.Height = 24;
            this.ProductsTable.Size = new System.Drawing.Size(704, 482);
            this.ProductsTable.TabIndex = 0;
            // 
            // SelectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.ProductsTable);
            this.Name = "SelectControl";
            this.Size = new System.Drawing.Size(704, 482);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductsTable;
    }
}


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
            this.CountProductBox = new System.Windows.Forms.TextBox();
            this.AddCartProductButton = new System.Windows.Forms.Button();
            this.NameProductBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.ErrorLabel.Location = new System.Drawing.Point(350, 20);
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
            // CountProductBox
            // 
            this.CountProductBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountProductBox.Location = new System.Drawing.Point(180, 60);
            this.CountProductBox.Name = "CountProductBox";
            this.CountProductBox.Size = new System.Drawing.Size(100, 34);
            this.CountProductBox.TabIndex = 23;
            // 
            // AddCartProductButton
            // 
            this.AddCartProductButton.AutoSize = true;
            this.AddCartProductButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddCartProductButton.FlatAppearance.BorderSize = 0;
            this.AddCartProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCartProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCartProductButton.Location = new System.Drawing.Point(30, 110);
            this.AddCartProductButton.Name = "AddCartProductButton";
            this.AddCartProductButton.Size = new System.Drawing.Size(252, 41);
            this.AddCartProductButton.TabIndex = 21;
            this.AddCartProductButton.Text = "Добавить в корзину";
            this.AddCartProductButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddCartProductButton.UseVisualStyleBackColor = true;
            // 
            // NameProductBox
            // 
            this.NameProductBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameProductBox.Location = new System.Drawing.Point(180, 20);
            this.NameProductBox.Name = "NameProductBox";
            this.NameProductBox.Size = new System.Drawing.Size(100, 34);
            this.NameProductBox.TabIndex = 18;
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
            this.panel1.Controls.Add(this.ErrorLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.NameProductBox);
            this.panel1.Controls.Add(this.AddCartProductButton);
            this.panel1.Controls.Add(this.CountProductBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 163);
            this.panel1.TabIndex = 26;
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
        private System.Windows.Forms.TextBox CountProductBox;
        private System.Windows.Forms.Button AddCartProductButton;
        private System.Windows.Forms.TextBox NameProductBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

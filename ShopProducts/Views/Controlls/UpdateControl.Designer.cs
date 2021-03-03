
namespace ShopProducts.Views.Controlls
{
    partial class UpdateControl
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
            this.UpdateProductButton = new System.Windows.Forms.Button();
            this.ProductsNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductsPriceBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.ProductsQuantityBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UpdateProductButton
            // 
            this.UpdateProductButton.AutoSize = true;
            this.UpdateProductButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateProductButton.FlatAppearance.BorderSize = 0;
            this.UpdateProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateProductButton.Location = new System.Drawing.Point(30, 180);
            this.UpdateProductButton.Name = "UpdateProductButton";
            this.UpdateProductButton.Size = new System.Drawing.Size(133, 41);
            this.UpdateProductButton.TabIndex = 21;
            this.UpdateProductButton.Text = "Добавить";
            this.UpdateProductButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateProductButton.UseVisualStyleBackColor = true;
            this.UpdateProductButton.Click += new System.EventHandler(this.UpdateProductButton_Click);
            // 
            // ProductsNameBox
            // 
            this.ProductsNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductsNameBox.Location = new System.Drawing.Point(180, 60);
            this.ProductsNameBox.Name = "ProductsNameBox";
            this.ProductsNameBox.Size = new System.Drawing.Size(100, 34);
            this.ProductsNameBox.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(30, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "Название";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProductsPriceBox
            // 
            this.ProductsPriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductsPriceBox.Location = new System.Drawing.Point(180, 140);
            this.ProductsPriceBox.Name = "ProductsPriceBox";
            this.ProductsPriceBox.Size = new System.Drawing.Size(100, 34);
            this.ProductsPriceBox.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "Цена";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(350, 20);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 29);
            this.ErrorLabel.TabIndex = 26;
            // 
            // ProductsQuantityBox
            // 
            this.ProductsQuantityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductsQuantityBox.Location = new System.Drawing.Point(180, 100);
            this.ProductsQuantityBox.Name = "ProductsQuantityBox";
            this.ProductsQuantityBox.Size = new System.Drawing.Size(100, 34);
            this.ProductsQuantityBox.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(30, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 29);
            this.label4.TabIndex = 29;
            this.label4.Text = "Количество";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UpdateControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ProductsQuantityBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.ProductsPriceBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UpdateProductButton);
            this.Controls.Add(this.ProductsNameBox);
            this.Controls.Add(this.label3);
            this.Name = "UpdateControl";
            this.Size = new System.Drawing.Size(566, 476);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateProductButton;
        private System.Windows.Forms.TextBox ProductsNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProductsPriceBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.TextBox ProductsQuantityBox;
        private System.Windows.Forms.Label label4;
    }
}

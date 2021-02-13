
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
            this.MainMenu.SuspendLayout();
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
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TabControl.Location = new System.Drawing.Point(0, 30);
            this.TabControl.Multiline = true;
            this.TabControl.Name = "TabControl";
            this.TabControl.Padding = new System.Drawing.Point(10, 10);
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(800, 420);
            this.TabControl.TabIndex = 2;
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
    }
}
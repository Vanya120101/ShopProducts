
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopProductsMainForm));
            this.TabControl = new System.Windows.Forms.TabControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.FileMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Multiline = true;
            this.TabControl.Name = "TabControl";
            this.TabControl.Padding = new System.Drawing.Point(10, 10);
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(800, 370);
            this.TabControl.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.MainMenu);
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 80);
            this.panel2.TabIndex = 2;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ImageKey = "Close";
            this.CloseButton.ImageList = this.ImageList;
            this.CloseButton.Location = new System.Drawing.Point(750, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(50, 50);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "Close");
            // 
            // MainMenu
            // 
            this.MainMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMainMenu,
            this.ToolsMainMenu,
            this.HelpMainMenu});
            this.MainMenu.Location = new System.Drawing.Point(0, 52);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(800, 28);
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
            this.ExitMainMenu.Click += new System.EventHandler(this.ExitMainMenu_Click);
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
            this.RefreshMainMenu.Click += new System.EventHandler(this.RefreshMainMenu_Click);
            // 
            // HelpMainMenu
            // 
            this.HelpMainMenu.Name = "HelpMainMenu";
            this.HelpMainMenu.Size = new System.Drawing.Size(81, 24);
            this.HelpMainMenu.Text = "Справка";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TabControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 370);
            this.panel1.TabIndex = 3;
            // 
            // ShopProductsMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShopProductsMainForm";
            this.Text = "ShopProductsMainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ImageList ImageList;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem FileMainMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitMainMenu;
        private System.Windows.Forms.ToolStripMenuItem ToolsMainMenu;
        private System.Windows.Forms.ToolStripMenuItem RefreshMainMenu;
        private System.Windows.Forms.ToolStripMenuItem HelpMainMenu;
        private System.Windows.Forms.Panel panel1;
    }
}
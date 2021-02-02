namespace RugFactory
{
    partial class MainWindow
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
            this.alfombrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.almacenadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trabajosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hechosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pendientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fallosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alfombrasToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.trabajosToolStripMenuItem,
            this.configuracionToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1756, 28);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // alfombrasToolStripMenuItem
            // 
            this.alfombrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradasToolStripMenuItem,
            this.almacenadasToolStripMenuItem});
            this.alfombrasToolStripMenuItem.Name = "alfombrasToolStripMenuItem";
            this.alfombrasToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.alfombrasToolStripMenuItem.Text = "Alfombras";
            // 
            // entradasToolStripMenuItem
            // 
            this.entradasToolStripMenuItem.Name = "entradasToolStripMenuItem";
            this.entradasToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.entradasToolStripMenuItem.Text = "Entradas";
            this.entradasToolStripMenuItem.Click += new System.EventHandler(this.entradasToolStripMenuItem_Click);
            // 
            // almacenadasToolStripMenuItem
            // 
            this.almacenadasToolStripMenuItem.Name = "almacenadasToolStripMenuItem";
            this.almacenadasToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.almacenadasToolStripMenuItem.Text = "Consulta";
            this.almacenadasToolStripMenuItem.Click += new System.EventHandler(this.almacenadasToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // trabajosToolStripMenuItem
            // 
            this.trabajosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hechosToolStripMenuItem,
            this.pendientesToolStripMenuItem});
            this.trabajosToolStripMenuItem.Name = "trabajosToolStripMenuItem";
            this.trabajosToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.trabajosToolStripMenuItem.Text = "Trabajos";
            // 
            // hechosToolStripMenuItem
            // 
            this.hechosToolStripMenuItem.Name = "hechosToolStripMenuItem";
            this.hechosToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.hechosToolStripMenuItem.Text = "Hechos";
            // 
            // pendientesToolStripMenuItem
            // 
            this.pendientesToolStripMenuItem.Name = "pendientesToolStripMenuItem";
            this.pendientesToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.pendientesToolStripMenuItem.Text = "Pendientes";
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fallosToolStripMenuItem});
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.configuracionToolStripMenuItem.Text = "Configuracion";
            // 
            // fallosToolStripMenuItem
            // 
            this.fallosToolStripMenuItem.Name = "fallosToolStripMenuItem";
            this.fallosToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.fallosToolStripMenuItem.Text = "Fallos";
            this.fallosToolStripMenuItem.Click += new System.EventHandler(this.fallosToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1756, 500);
            this.Controls.Add(this.MainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindow_Load);
        
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem alfombrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem almacenadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trabajosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hechosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pendientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fallosToolStripMenuItem;
    }
}


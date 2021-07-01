namespace SearchCompany
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoVendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarTodosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.novoItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atendenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarTodosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.novoAtendenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarVendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarItensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarAtendentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue;
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listagemToolStripMenuItem,
            this.novoClienteToolStripMenuItem,
            this.alterarClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.clientesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(126, 32);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // listagemToolStripMenuItem
            // 
            this.listagemToolStripMenuItem.BackColor = System.Drawing.Color.Salmon;
            this.listagemToolStripMenuItem.Name = "listagemToolStripMenuItem";
            this.listagemToolStripMenuItem.Size = new System.Drawing.Size(208, 32);
            this.listagemToolStripMenuItem.Text = "Listar Todos";
            this.listagemToolStripMenuItem.Click += new System.EventHandler(this.listagemToolStripMenuItem_Click);
            // 
            // novoClienteToolStripMenuItem
            // 
            this.novoClienteToolStripMenuItem.BackColor = System.Drawing.Color.MistyRose;
            this.novoClienteToolStripMenuItem.Name = "novoClienteToolStripMenuItem";
            this.novoClienteToolStripMenuItem.Size = new System.Drawing.Size(208, 32);
            this.novoClienteToolStripMenuItem.Text = "Novo Cliente";
            this.novoClienteToolStripMenuItem.Click += new System.EventHandler(this.novoClienteToolStripMenuItem_Click);
            // 
            // alterarClienteToolStripMenuItem
            // 
            this.alterarClienteToolStripMenuItem.Name = "alterarClienteToolStripMenuItem";
            this.alterarClienteToolStripMenuItem.Size = new System.Drawing.Size(208, 32);
            this.alterarClienteToolStripMenuItem.Text = "Alterar Cliente";
            this.alterarClienteToolStripMenuItem.Click += new System.EventHandler(this.alterarClienteToolStripMenuItem_Click);
            // 
            // vendedoresToolStripMenuItem
            // 
            this.vendedoresToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue;
            this.vendedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarTodosToolStripMenuItem,
            this.novoVendedorToolStripMenuItem});
            this.vendedoresToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.vendedoresToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.vendedoresToolStripMenuItem.Name = "vendedoresToolStripMenuItem";
            this.vendedoresToolStripMenuItem.Size = new System.Drawing.Size(126, 32);
            this.vendedoresToolStripMenuItem.Text = "Vendedores";
            // 
            // listarTodosToolStripMenuItem
            // 
            this.listarTodosToolStripMenuItem.BackColor = System.Drawing.Color.Salmon;
            this.listarTodosToolStripMenuItem.Name = "listarTodosToolStripMenuItem";
            this.listarTodosToolStripMenuItem.Size = new System.Drawing.Size(223, 32);
            this.listarTodosToolStripMenuItem.Text = "Listar Todos";
            // 
            // novoVendedorToolStripMenuItem
            // 
            this.novoVendedorToolStripMenuItem.BackColor = System.Drawing.Color.MistyRose;
            this.novoVendedorToolStripMenuItem.Name = "novoVendedorToolStripMenuItem";
            this.novoVendedorToolStripMenuItem.Size = new System.Drawing.Size(223, 32);
            this.novoVendedorToolStripMenuItem.Text = "Novo Vendedor";
            // 
            // itensToolStripMenuItem
            // 
            this.itensToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue;
            this.itensToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarTodosToolStripMenuItem1,
            this.novoItemToolStripMenuItem});
            this.itensToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.itensToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.itensToolStripMenuItem.Name = "itensToolStripMenuItem";
            this.itensToolStripMenuItem.Size = new System.Drawing.Size(126, 32);
            this.itensToolStripMenuItem.Text = "Itens";
            // 
            // listarTodosToolStripMenuItem1
            // 
            this.listarTodosToolStripMenuItem1.BackColor = System.Drawing.Color.Salmon;
            this.listarTodosToolStripMenuItem1.Name = "listarTodosToolStripMenuItem1";
            this.listarTodosToolStripMenuItem1.Size = new System.Drawing.Size(187, 32);
            this.listarTodosToolStripMenuItem1.Text = "Listar Todos";
            // 
            // novoItemToolStripMenuItem
            // 
            this.novoItemToolStripMenuItem.BackColor = System.Drawing.Color.MistyRose;
            this.novoItemToolStripMenuItem.Name = "novoItemToolStripMenuItem";
            this.novoItemToolStripMenuItem.Size = new System.Drawing.Size(187, 32);
            this.novoItemToolStripMenuItem.Text = "Novo Item";
            // 
            // atendenteToolStripMenuItem
            // 
            this.atendenteToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue;
            this.atendenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarTodosToolStripMenuItem2,
            this.novoAtendenteToolStripMenuItem});
            this.atendenteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.atendenteToolStripMenuItem.ForeColor = System.Drawing.SystemColors.InfoText;
            this.atendenteToolStripMenuItem.Name = "atendenteToolStripMenuItem";
            this.atendenteToolStripMenuItem.Size = new System.Drawing.Size(126, 32);
            this.atendenteToolStripMenuItem.Text = "Atendente";
            // 
            // listarTodosToolStripMenuItem2
            // 
            this.listarTodosToolStripMenuItem2.BackColor = System.Drawing.Color.Salmon;
            this.listarTodosToolStripMenuItem2.Name = "listarTodosToolStripMenuItem2";
            this.listarTodosToolStripMenuItem2.Size = new System.Drawing.Size(229, 32);
            this.listarTodosToolStripMenuItem2.Text = "Listar Todos";
            // 
            // novoAtendenteToolStripMenuItem
            // 
            this.novoAtendenteToolStripMenuItem.BackColor = System.Drawing.Color.MistyRose;
            this.novoAtendenteToolStripMenuItem.Name = "novoAtendenteToolStripMenuItem";
            this.novoAtendenteToolStripMenuItem.Size = new System.Drawing.Size(229, 32);
            this.novoAtendenteToolStripMenuItem.Text = "Novo Atendente";
            // 
            // gerenteToolStripMenuItem
            // 
            this.gerenteToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue;
            this.gerenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarClientesToolStripMenuItem,
            this.listarVendedoresToolStripMenuItem,
            this.listarItensToolStripMenuItem,
            this.listarAtendentesToolStripMenuItem});
            this.gerenteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.gerenteToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gerenteToolStripMenuItem.Name = "gerenteToolStripMenuItem";
            this.gerenteToolStripMenuItem.Size = new System.Drawing.Size(126, 32);
            this.gerenteToolStripMenuItem.Text = "Gerente";
            // 
            // listarClientesToolStripMenuItem
            // 
            this.listarClientesToolStripMenuItem.BackColor = System.Drawing.Color.MediumAquamarine;
            this.listarClientesToolStripMenuItem.Name = "listarClientesToolStripMenuItem";
            this.listarClientesToolStripMenuItem.Size = new System.Drawing.Size(238, 32);
            this.listarClientesToolStripMenuItem.Text = "Listar Clientes";
            // 
            // listarVendedoresToolStripMenuItem
            // 
            this.listarVendedoresToolStripMenuItem.BackColor = System.Drawing.Color.Aquamarine;
            this.listarVendedoresToolStripMenuItem.Name = "listarVendedoresToolStripMenuItem";
            this.listarVendedoresToolStripMenuItem.Size = new System.Drawing.Size(238, 32);
            this.listarVendedoresToolStripMenuItem.Text = "Listar Vendedores";
            // 
            // listarItensToolStripMenuItem
            // 
            this.listarItensToolStripMenuItem.BackColor = System.Drawing.Color.Turquoise;
            this.listarItensToolStripMenuItem.Name = "listarItensToolStripMenuItem";
            this.listarItensToolStripMenuItem.Size = new System.Drawing.Size(238, 32);
            this.listarItensToolStripMenuItem.Text = "Listar Itens";
            // 
            // listarAtendentesToolStripMenuItem
            // 
            this.listarAtendentesToolStripMenuItem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.listarAtendentesToolStripMenuItem.Name = "listarAtendentesToolStripMenuItem";
            this.listarAtendentesToolStripMenuItem.Size = new System.Drawing.Size(238, 32);
            this.listarAtendentesToolStripMenuItem.Text = "Listar Atendentes";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 6);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.vendedoresToolStripMenuItem,
            this.itensToolStripMenuItem,
            this.gerenteToolStripMenuItem,
            this.atendenteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(127, 541);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.GhostWhite;
            this.linkLabel1.Location = new System.Drawing.Point(127, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(244, 33);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "SISTEMA ONLINE";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImage = global::SearchCompany.Properties.Resources.imagem_fundo1;
            this.ClientSize = new System.Drawing.Size(997, 541);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.ShowInTaskbar = false;
            this.Text = "frmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarTodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoVendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarTodosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem novoItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atendenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarTodosToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem novoAtendenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarVendedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarItensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarAtendentesToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolStripMenuItem alterarClienteToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}
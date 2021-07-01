namespace SearchCompany
{
    partial class frmClientesListagem
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnNovoCliente = new System.Windows.Forms.Button();
            this.gridClientes = new System.Windows.Forms.DataGridView();
            this.txtNomeBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTAGEM DE PACIENTES";
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.BackColor = System.Drawing.Color.Gold;
            this.btnNovoCliente.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoCliente.Location = new System.Drawing.Point(380, 9);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Size = new System.Drawing.Size(117, 32);
            this.btnNovoCliente.TabIndex = 1;
            this.btnNovoCliente.Text = "NOVO CLIENTE";
            this.btnNovoCliente.UseVisualStyleBackColor = false;
            this.btnNovoCliente.Click += new System.EventHandler(this.btnNovoCliente_Click);
            // 
            // gridClientes
            // 
            this.gridClientes.AllowUserToAddRows = false;
            this.gridClientes.AllowUserToDeleteRows = false;
            this.gridClientes.BackgroundColor = System.Drawing.Color.Snow;
            this.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClientes.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.gridClientes.Location = new System.Drawing.Point(12, 126);
            this.gridClientes.Name = "gridClientes";
            this.gridClientes.ReadOnly = true;
            this.gridClientes.Size = new System.Drawing.Size(490, 295);
            this.gridClientes.TabIndex = 2;
            // 
            // txtNomeBuscar
            // 
            this.txtNomeBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeBuscar.Location = new System.Drawing.Point(12, 81);
            this.txtNomeBuscar.Name = "txtNomeBuscar";
            this.txtNomeBuscar.Size = new System.Drawing.Size(485, 29);
            this.txtNomeBuscar.TabIndex = 3;
            this.txtNomeBuscar.TextChanged += new System.EventHandler(this.txtNomeBuscar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(156, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "INFORME PARTE DO NOME:";
            // 
            // frmClientesListagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImage = global::SearchCompany.Properties.Resources.backgroundCliente1;
            this.ClientSize = new System.Drawing.Size(517, 436);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeBuscar);
            this.Controls.Add(this.gridClientes);
            this.Controls.Add(this.btnNovoCliente);
            this.Controls.Add(this.label1);
            this.Name = "frmClientesListagem";
            this.Text = "frmClientesListagem";
            this.Load += new System.EventHandler(this.frmClientesListagem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNovoCliente;
        private System.Windows.Forms.DataGridView gridClientes;
        private System.Windows.Forms.TextBox txtNomeBuscar;
        private System.Windows.Forms.Label label2;
    }
}
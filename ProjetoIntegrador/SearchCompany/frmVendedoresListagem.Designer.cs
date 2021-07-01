namespace SearchCompany
{
    partial class frmVendedoresListagem
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
            this.btnNovoVendedor = new System.Windows.Forms.Button();
            this.gridVendedores = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridVendedores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTAGEM DE VENDEDORES";
            // 
            // btnNovoVendedor
            // 
            this.btnNovoVendedor.BackColor = System.Drawing.Color.Gold;
            this.btnNovoVendedor.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoVendedor.Location = new System.Drawing.Point(194, 381);
            this.btnNovoVendedor.Name = "btnNovoVendedor";
            this.btnNovoVendedor.Size = new System.Drawing.Size(144, 34);
            this.btnNovoVendedor.TabIndex = 1;
            this.btnNovoVendedor.Text = "NOVO VENDEDOR";
            this.btnNovoVendedor.UseVisualStyleBackColor = false;
            this.btnNovoVendedor.Click += new System.EventHandler(this.btnNovoVendedor_Click);
            // 
            // gridVendedores
            // 
            this.gridVendedores.BackgroundColor = System.Drawing.Color.White;
            this.gridVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVendedores.Location = new System.Drawing.Point(45, 130);
            this.gridVendedores.Name = "gridVendedores";
            this.gridVendedores.ReadOnly = true;
            this.gridVendedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridVendedores.Size = new System.Drawing.Size(430, 245);
            this.gridVendedores.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(149, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "INFORME AS INICIAIS:";
            // 
            // txtNomeBuscar
            // 
            this.txtNomeBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeBuscar.Location = new System.Drawing.Point(74, 79);
            this.txtNomeBuscar.Name = "txtNomeBuscar";
            this.txtNomeBuscar.Size = new System.Drawing.Size(383, 29);
            this.txtNomeBuscar.TabIndex = 5;
            this.txtNomeBuscar.TextChanged += new System.EventHandler(this.txtNomeBuscar_TextChanged);
            // 
            // frmVendedoresListagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SearchCompany.Properties.Resources.backgroundCliente1;
            this.ClientSize = new System.Drawing.Size(517, 417);
            this.Controls.Add(this.txtNomeBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridVendedores);
            this.Controls.Add(this.btnNovoVendedor);
            this.Controls.Add(this.label1);
            this.Name = "frmVendedoresListagem";
            this.Text = "frmVendedoresListagem";
            ((System.ComponentModel.ISupportInitialize)(this.gridVendedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNovoVendedor;
        private System.Windows.Forms.DataGridView gridVendedores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeBuscar;
    }
}
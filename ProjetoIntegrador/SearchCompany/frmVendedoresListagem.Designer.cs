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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTAGEM DE VENDEDORES";
            // 
            // btnNovoVendedor
            // 
            this.btnNovoVendedor.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoVendedor.Location = new System.Drawing.Point(179, 44);
            this.btnNovoVendedor.Name = "btnNovoVendedor";
            this.btnNovoVendedor.Size = new System.Drawing.Size(153, 34);
            this.btnNovoVendedor.TabIndex = 1;
            this.btnNovoVendedor.Text = "NOVO VENDEDOR";
            this.btnNovoVendedor.UseVisualStyleBackColor = true;
            this.btnNovoVendedor.Click += new System.EventHandler(this.btnNovoVendedor_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(42, 108);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(430, 278);
            this.dataGridView2.TabIndex = 3;
            // 
            // frmVendedoresListagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 417);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnNovoVendedor);
            this.Controls.Add(this.label1);
            this.Name = "frmVendedoresListagem";
            this.Text = "frmVendedoresListagem";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNovoVendedor;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}
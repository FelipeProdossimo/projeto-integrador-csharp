namespace SearchCompany
{
    partial class frmAtendenteListagem
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
            this.txtNomeBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridAtendentes = new System.Windows.Forms.DataGridView();
            this.btnNovoAtendente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridAtendentes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 32.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(-7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(622, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTAGEM DE ATENDENTES";
            // 
            // txtNomeBuscar
            // 
            this.txtNomeBuscar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeBuscar.ForeColor = System.Drawing.Color.Black;
            this.txtNomeBuscar.Location = new System.Drawing.Point(199, 95);
            this.txtNomeBuscar.Name = "txtNomeBuscar";
            this.txtNomeBuscar.Size = new System.Drawing.Size(205, 22);
            this.txtNomeBuscar.TabIndex = 1;
            this.txtNomeBuscar.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(208, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "ESCREVA AS INICIAIS:";
            // 
            // gridAtendentes
            // 
            this.gridAtendentes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gridAtendentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAtendentes.Location = new System.Drawing.Point(55, 123);
            this.gridAtendentes.Name = "gridAtendentes";
            this.gridAtendentes.Size = new System.Drawing.Size(492, 280);
            this.gridAtendentes.TabIndex = 3;
            // 
            // btnNovoAtendente
            // 
            this.btnNovoAtendente.BackColor = System.Drawing.Color.White;
            this.btnNovoAtendente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoAtendente.ForeColor = System.Drawing.Color.Black;
            this.btnNovoAtendente.Location = new System.Drawing.Point(212, 409);
            this.btnNovoAtendente.Name = "btnNovoAtendente";
            this.btnNovoAtendente.Size = new System.Drawing.Size(179, 30);
            this.btnNovoAtendente.TabIndex = 4;
            this.btnNovoAtendente.Text = "NOVO ATENDENTE";
            this.btnNovoAtendente.UseVisualStyleBackColor = false;
            this.btnNovoAtendente.Click += new System.EventHandler(this.btnNovoAtendente_Click);
            // 
            // frmAtendenteListagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SearchCompany.Properties.Resources.background_orange_solid;
            this.ClientSize = new System.Drawing.Size(606, 450);
            this.Controls.Add(this.btnNovoAtendente);
            this.Controls.Add(this.gridAtendentes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeBuscar);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Name = "frmAtendenteListagem";
            this.Text = "frmAtendenteListagem";
            ((System.ComponentModel.ISupportInitialize)(this.gridAtendentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridAtendentes;
        private System.Windows.Forms.Button btnNovoAtendente;
    }
}
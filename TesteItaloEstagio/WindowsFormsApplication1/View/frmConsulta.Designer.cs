namespace WindowsFormsApplication1
{
    partial class frmConsulta
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
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBusca = new System.Windows.Forms.Button();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.btnBuscarTudo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(93, 41);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 22);
            this.txtCod.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "cod";
            // 
            // btnBusca
            // 
            this.btnBusca.Location = new System.Drawing.Point(208, 39);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(155, 24);
            this.btnBusca.TabIndex = 2;
            this.btnBusca.Text = "buscar";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // dgvResultados
            // 
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Location = new System.Drawing.Point(47, 81);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.RowTemplate.Height = 24;
            this.dgvResultados.Size = new System.Drawing.Size(926, 396);
            this.dgvResultados.TabIndex = 18;
            // 
            // btnBuscarTudo
            // 
            this.btnBuscarTudo.Location = new System.Drawing.Point(717, 38);
            this.btnBuscarTudo.Name = "btnBuscarTudo";
            this.btnBuscarTudo.Size = new System.Drawing.Size(256, 24);
            this.btnBuscarTudo.TabIndex = 19;
            this.btnBuscarTudo.Text = "buscar todos endereços";
            this.btnBuscarTudo.UseVisualStyleBackColor = true;
            this.btnBuscarTudo.Click += new System.EventHandler(this.btnBuscarTudo_Click);
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 571);
            this.Controls.Add(this.btnBuscarTudo);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCod);
            this.Name = "frmConsulta";
            this.Text = "frmConsulta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Button btnBuscarTudo;
    }
}
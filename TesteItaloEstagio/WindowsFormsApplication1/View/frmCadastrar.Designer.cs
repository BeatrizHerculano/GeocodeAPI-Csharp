namespace WindowsFormsApplication1
{
    partial class frmCadastrar
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
            this.btnConsumir = new System.Windows.Forms.Button();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblLat = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLong = new System.Windows.Forms.Label();
            this.btnCad = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConsumir
            // 
            this.btnConsumir.Location = new System.Drawing.Point(415, 21);
            this.btnConsumir.Name = "btnConsumir";
            this.btnConsumir.Size = new System.Drawing.Size(99, 34);
            this.btnConsumir.TabIndex = 0;
            this.btnConsumir.Text = "Buscar";
            this.btnConsumir.UseVisualStyleBackColor = true;
            this.btnConsumir.Click += new System.EventHandler(this.btnConsumir_Click);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(93, 27);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(307, 22);
            this.txtEndereco.TabIndex = 1;
            // 
            // lblLat
            // 
            this.lblLat.AutoSize = true;
            this.lblLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLat.Location = new System.Drawing.Point(178, 91);
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(19, 15);
            this.lblLat.TabIndex = 2;
            this.lblLat.Text = "---";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(178, 69);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(23, 17);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "---";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Endereço completo: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Latitude:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Longetude";
            // 
            // lblLong
            // 
            this.lblLong.AutoSize = true;
            this.lblLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLong.Location = new System.Drawing.Point(178, 117);
            this.lblLong.Name = "lblLong";
            this.lblLong.Size = new System.Drawing.Size(19, 15);
            this.lblLong.TabIndex = 7;
            this.lblLong.Text = "---";
            // 
            // btnCad
            // 
            this.btnCad.Location = new System.Drawing.Point(391, 150);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(123, 40);
            this.btnCad.TabIndex = 8;
            this.btnCad.Text = "cadastrar";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Endereço:";
            // 
            // frmCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 217);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.lblLong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblLat);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.btnConsumir);
            this.Name = "frmCadastrar";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsumir;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblLat;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLong;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.Label label4;
    }
}


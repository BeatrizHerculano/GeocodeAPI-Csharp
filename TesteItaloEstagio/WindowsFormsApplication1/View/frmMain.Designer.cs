namespace WindowsFormsApplication1
{
    partial class frmMain
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
            this.btnCad = new System.Windows.Forms.Button();
            this.btnCons = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCad
            // 
            this.btnCad.Location = new System.Drawing.Point(69, 34);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(164, 74);
            this.btnCad.TabIndex = 0;
            this.btnCad.Text = "Consumir API";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // btnCons
            // 
            this.btnCons.Location = new System.Drawing.Point(69, 133);
            this.btnCons.Name = "btnCons";
            this.btnCons.Size = new System.Drawing.Size(164, 74);
            this.btnCons.TabIndex = 1;
            this.btnCons.Text = "Consultar";
            this.btnCons.UseVisualStyleBackColor = true;
            this.btnCons.Click += new System.EventHandler(this.btnCons_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btnCons);
            this.Controls.Add(this.btnCad);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.Button btnCons;
    }
}
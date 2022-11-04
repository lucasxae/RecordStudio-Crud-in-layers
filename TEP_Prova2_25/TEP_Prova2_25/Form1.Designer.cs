namespace TEP_Prova2_25
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_altura = new System.Windows.Forms.Label();
            this.lbl_base = new System.Windows.Forms.Label();
            this.txt_base = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.txt_altura = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_altura
            // 
            this.lbl_altura.AutoSize = true;
            this.lbl_altura.Location = new System.Drawing.Point(57, 213);
            this.lbl_altura.Name = "lbl_altura";
            this.lbl_altura.Size = new System.Drawing.Size(50, 13);
            this.lbl_altura.TabIndex = 0;
            this.lbl_altura.Text = "ALTURA";
            // 
            // lbl_base
            // 
            this.lbl_base.AutoSize = true;
            this.lbl_base.Location = new System.Drawing.Point(57, 109);
            this.lbl_base.Name = "lbl_base";
            this.lbl_base.Size = new System.Drawing.Size(35, 13);
            this.lbl_base.TabIndex = 1;
            this.lbl_base.Text = "BASE";
            // 
            // txt_base
            // 
            this.txt_base.Location = new System.Drawing.Point(136, 102);
            this.txt_base.Multiline = true;
            this.txt_base.Name = "txt_base";
            this.txt_base.Size = new System.Drawing.Size(128, 30);
            this.txt_base.TabIndex = 3;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(93, 279);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(143, 42);
            this.btn_calcular.TabIndex = 5;
            this.btn_calcular.Text = "CALCULAR AREA";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // txt_altura
            // 
            this.txt_altura.Location = new System.Drawing.Point(136, 196);
            this.txt_altura.Multiline = true;
            this.txt_altura.Name = "txt_altura";
            this.txt_altura.Size = new System.Drawing.Size(128, 30);
            this.txt_altura.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 382);
            this.Controls.Add(this.txt_altura);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.txt_base);
            this.Controls.Add(this.lbl_base);
            this.Controls.Add(this.lbl_altura);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_altura;
        private System.Windows.Forms.Label lbl_base;
        private System.Windows.Forms.TextBox txt_base;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.TextBox txt_altura;
    }
}


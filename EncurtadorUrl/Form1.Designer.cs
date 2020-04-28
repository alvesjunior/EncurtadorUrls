namespace EncurtadorUrl
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
            this.numerosWhats = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.qtdUrl = new System.Windows.Forms.Label();
            this.linksFinais = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // numerosWhats
            // 
            this.numerosWhats.Location = new System.Drawing.Point(15, 87);
            this.numerosWhats.Multiline = true;
            this.numerosWhats.Name = "numerosWhats";
            this.numerosWhats.Size = new System.Drawing.Size(388, 248);
            this.numerosWhats.TabIndex = 0;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(377, 363);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(123, 55);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Número de Urls";
            // 
            // qtdUrl
            // 
            this.qtdUrl.AutoSize = true;
            this.qtdUrl.Location = new System.Drawing.Point(134, 401);
            this.qtdUrl.Name = "qtdUrl";
            this.qtdUrl.Size = new System.Drawing.Size(16, 17);
            this.qtdUrl.TabIndex = 4;
            this.qtdUrl.Text = "0";
            // 
            // linksFinais
            // 
            this.linksFinais.Location = new System.Drawing.Point(423, 87);
            this.linksFinais.Name = "linksFinais";
            this.linksFinais.Size = new System.Drawing.Size(365, 248);
            this.linksFinais.TabIndex = 7;
            this.linksFinais.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linksFinais);
            this.Controls.Add(this.qtdUrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.numerosWhats);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numerosWhats;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label qtdUrl;
        private System.Windows.Forms.RichTextBox linksFinais;
    }
}


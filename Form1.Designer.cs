namespace Generator
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
            this.Chute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroJogador = new System.Windows.Forms.TextBox();
            this.Resposta = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Chute
            // 
            this.Chute.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Chute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chute.Location = new System.Drawing.Point(336, 219);
            this.Chute.Name = "Chute";
            this.Chute.Size = new System.Drawing.Size(124, 37);
            this.Chute.TabIndex = 0;
            this.Chute.Text = "Chutar";
            this.Chute.UseVisualStyleBackColor = false;
            this.Chute.Click += new System.EventHandler(this.Chute_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(0, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "O seu número foi gerado! Tente advinhá-lo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNumeroJogador
            // 
            this.txtNumeroJogador.Location = new System.Drawing.Point(347, 193);
            this.txtNumeroJogador.Name = "txtNumeroJogador";
            this.txtNumeroJogador.Size = new System.Drawing.Size(98, 20);
            this.txtNumeroJogador.TabIndex = 2;
            this.txtNumeroJogador.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Resposta
            // 
            this.Resposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resposta.Location = new System.Drawing.Point(3, 70);
            this.Resposta.Name = "Resposta";
            this.Resposta.Size = new System.Drawing.Size(797, 23);
            this.Resposta.TabIndex = 3;
            this.Resposta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Resposta.Click += new System.EventHandler(this.Resposta_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(663, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 32);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Fechar";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(347, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.Resposta);
            this.Controls.Add(this.txtNumeroJogador);
            this.Controls.Add(this.Chute);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuessGame";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Chute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroJogador;
        private System.Windows.Forms.Label Resposta;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
    }
}


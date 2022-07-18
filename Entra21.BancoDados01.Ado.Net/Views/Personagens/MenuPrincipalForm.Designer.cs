namespace Entra21.BancoDados01.Ado.Net.Views.Personagens
{
    partial class MenuPrincipalForm
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
            this.buttonEditora = new System.Windows.Forms.Button();
            this.buttonPersonagens = new System.Windows.Forms.Button();
            this.buttonTiposPersonagens = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEditora
            // 
            this.buttonEditora.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEditora.Location = new System.Drawing.Point(12, 12);
            this.buttonEditora.Name = "buttonEditora";
            this.buttonEditora.Size = new System.Drawing.Size(174, 176);
            this.buttonEditora.TabIndex = 0;
            this.buttonEditora.Text = "Editora";
            this.buttonEditora.UseVisualStyleBackColor = true;
            // 
            // buttonPersonagens
            // 
            this.buttonPersonagens.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPersonagens.Location = new System.Drawing.Point(192, 12);
            this.buttonPersonagens.Name = "buttonPersonagens";
            this.buttonPersonagens.Size = new System.Drawing.Size(195, 176);
            this.buttonPersonagens.TabIndex = 2;
            this.buttonPersonagens.Text = "Personagens";
            this.buttonPersonagens.UseVisualStyleBackColor = true;
            this.buttonPersonagens.Click += new System.EventHandler(this.buttonPersonagens_Click);
            // 
            // buttonTiposPersonagens
            // 
            this.buttonTiposPersonagens.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTiposPersonagens.Location = new System.Drawing.Point(393, 12);
            this.buttonTiposPersonagens.Name = "buttonTiposPersonagens";
            this.buttonTiposPersonagens.Size = new System.Drawing.Size(193, 176);
            this.buttonTiposPersonagens.TabIndex = 3;
            this.buttonTiposPersonagens.Text = "Tipos de Personagens";
            this.buttonTiposPersonagens.UseVisualStyleBackColor = true;
            this.buttonTiposPersonagens.Click += new System.EventHandler(this.buttonTiposPersonagens_Click);
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 196);
            this.Controls.Add(this.buttonTiposPersonagens);
            this.Controls.Add(this.buttonPersonagens);
            this.Controls.Add(this.buttonEditora);
            this.Name = "MenuPrincipalForm";
            this.Text = "MenuPrincipalForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonEditora;
        private Button buttonPersonagens;
        private Button buttonTiposPersonagens;
    }
}
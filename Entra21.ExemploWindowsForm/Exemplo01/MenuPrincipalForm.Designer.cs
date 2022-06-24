namespace Entra21.ExemploWindowsForm.Exemplo01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalForm));
            this.buttonCadastroEndereco = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCadastroEndereco
            // 
            this.buttonCadastroEndereco.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCadastroEndereco.Image = global::Entra21.ExemploWindowsForm.Properties.Resources.logo_alfinete_google_maps_256;
            this.buttonCadastroEndereco.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonCadastroEndereco.Location = new System.Drawing.Point(25, 43);
            this.buttonCadastroEndereco.Name = "buttonCadastroEndereco";
            this.buttonCadastroEndereco.Size = new System.Drawing.Size(306, 305);
            this.buttonCadastroEndereco.TabIndex = 0;
            this.buttonCadastroEndereco.Text = "Endereço";
            this.buttonCadastroEndereco.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCadastroEndereco.UseVisualStyleBackColor = true;
            this.buttonCadastroEndereco.Click += new System.EventHandler(this.buttonCadastroEndereco_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(397, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(310, 305);
            this.button2.TabIndex = 1;
            this.button2.Text = "Paciente";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 362);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonCadastroEndereco);
            this.Name = "MenuPrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipalForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonCadastroEndereco;
        private Button button2;
    }
}
namespace Entra21.ExemploWindowsForm.Exemplo01
{
    partial class PacientesForm
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
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelAltura = new System.Windows.Forms.Label();
            this.textBoxAltura = new System.Windows.Forms.TextBox();
            this.textBoxPeso = new System.Windows.Forms.TextBox();
            this.labelPeso = new System.Windows.Forms.Label();
            this.labelImc = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAltura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelValorImc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEditar
            // 
            this.buttonEditar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEditar.Location = new System.Drawing.Point(287, 12);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(96, 37);
            this.buttonEditar.TabIndex = 0;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonApagar.Location = new System.Drawing.Point(389, 12);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(94, 38);
            this.buttonApagar.TabIndex = 1;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(498, 37);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(40, 15);
            this.labelNome.TabIndex = 2;
            this.labelNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(498, 55);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(273, 23);
            this.textBoxNome.TabIndex = 3;
            // 
            // labelAltura
            // 
            this.labelAltura.AutoSize = true;
            this.labelAltura.Location = new System.Drawing.Point(498, 99);
            this.labelAltura.Name = "labelAltura";
            this.labelAltura.Size = new System.Drawing.Size(39, 15);
            this.labelAltura.TabIndex = 4;
            this.labelAltura.Text = "Altura";
            // 
            // textBoxAltura
            // 
            this.textBoxAltura.Location = new System.Drawing.Point(498, 117);
            this.textBoxAltura.Name = "textBoxAltura";
            this.textBoxAltura.Size = new System.Drawing.Size(273, 23);
            this.textBoxAltura.TabIndex = 5;
            // 
            // textBoxPeso
            // 
            this.textBoxPeso.Location = new System.Drawing.Point(498, 172);
            this.textBoxPeso.Name = "textBoxPeso";
            this.textBoxPeso.Size = new System.Drawing.Size(273, 23);
            this.textBoxPeso.TabIndex = 6;
            // 
            // labelPeso
            // 
            this.labelPeso.AutoSize = true;
            this.labelPeso.Location = new System.Drawing.Point(498, 154);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(32, 15);
            this.labelPeso.TabIndex = 7;
            this.labelPeso.Text = "Peso";
            // 
            // labelImc
            // 
            this.labelImc.AutoSize = true;
            this.labelImc.Location = new System.Drawing.Point(498, 205);
            this.labelImc.Name = "labelImc";
            this.labelImc.Size = new System.Drawing.Size(32, 15);
            this.labelImc.TabIndex = 8;
            this.labelImc.Text = "IMC:";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSalvar.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSalvar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSalvar.Location = new System.Drawing.Point(646, 201);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(125, 37);
            this.buttonSalvar.TabIndex = 9;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnNome,
            this.ColumnAltura,
            this.ColumnPeso,
            this.ColumnImc});
            this.dataGridView1.Location = new System.Drawing.Point(7, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(476, 383);
            this.dataGridView1.TabIndex = 10;
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Código";
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            // 
            // ColumnAltura
            // 
            this.ColumnAltura.HeaderText = "Altura";
            this.ColumnAltura.Name = "ColumnAltura";
            this.ColumnAltura.ReadOnly = true;
            // 
            // ColumnPeso
            // 
            this.ColumnPeso.HeaderText = "Peso";
            this.ColumnPeso.Name = "ColumnPeso";
            this.ColumnPeso.ReadOnly = true;
            // 
            // ColumnImc
            // 
            this.ColumnImc.HeaderText = "IMC";
            this.ColumnImc.Name = "ColumnImc";
            this.ColumnImc.ReadOnly = true;
            // 
            // labelValorImc
            // 
            this.labelValorImc.AutoSize = true;
            this.labelValorImc.Location = new System.Drawing.Point(536, 205);
            this.labelValorImc.Name = "labelValorImc";
            this.labelValorImc.Size = new System.Drawing.Size(31, 15);
            this.labelValorImc.TabIndex = 11;
            this.labelValorImc.Text = "0000";
            // 
            // PacientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelValorImc);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.labelImc);
            this.Controls.Add(this.labelPeso);
            this.Controls.Add(this.textBoxPeso);
            this.Controls.Add(this.textBoxAltura);
            this.Controls.Add(this.labelAltura);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonEditar);
            this.Name = "PacientesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PacientesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonEditar;
        private Button buttonApagar;
        private Label labelNome;
        private TextBox textBoxNome;
        private Label labelAltura;
        private TextBox textBoxAltura;
        private TextBox textBoxPeso;
        private Label labelPeso;
        private Label labelImc;
        private Button buttonSalvar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnCodigo;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnAltura;
        private DataGridViewTextBoxColumn ColumnPeso;
        private DataGridViewTextBoxColumn ColumnImc;
        private Label labelValorImc;
    }
}
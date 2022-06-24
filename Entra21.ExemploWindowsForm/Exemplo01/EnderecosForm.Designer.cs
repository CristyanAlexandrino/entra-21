namespace Entra21.ExemploWindowsForm.Exemplo01
{
    partial class EnderecosForm
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
            this.labelEndereco = new System.Windows.Forms.Label();
            this.maskedTextBoxCep = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelCep = new System.Windows.Forms.Label();
            this.labelEnderecoCompleto = new System.Windows.Forms.Label();
            this.textBoxEnderecoCompleto = new System.Windows.Forms.TextBox();
            this.labelPaciente = new System.Windows.Forms.Label();
            this.comboBoxPaciente = new System.Windows.Forms.ComboBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEndereco.Location = new System.Drawing.Point(14, 36);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(127, 37);
            this.labelEndereco.TabIndex = 0;
            this.labelEndereco.Text = "Endereço";
            // 
            // maskedTextBoxCep
            // 
            this.maskedTextBoxCep.Location = new System.Drawing.Point(864, 71);
            this.maskedTextBoxCep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maskedTextBoxCep.Mask = "99999-999";
            this.maskedTextBoxCep.Name = "maskedTextBoxCep";
            this.maskedTextBoxCep.Size = new System.Drawing.Size(114, 27);
            this.maskedTextBoxCep.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.Endereco,
            this.Cep,
            this.paciente});
            this.dataGridView1.Location = new System.Drawing.Point(12, 84);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(846, 338);
            this.dataGridView1.TabIndex = 2;
            // 
            // labelCep
            // 
            this.labelCep.AutoSize = true;
            this.labelCep.Location = new System.Drawing.Point(864, 47);
            this.labelCep.Name = "labelCep";
            this.labelCep.Size = new System.Drawing.Size(34, 20);
            this.labelCep.TabIndex = 3;
            this.labelCep.Text = "CEP";
            // 
            // labelEnderecoCompleto
            // 
            this.labelEnderecoCompleto.AutoSize = true;
            this.labelEnderecoCompleto.Location = new System.Drawing.Point(864, 128);
            this.labelEnderecoCompleto.Name = "labelEnderecoCompleto";
            this.labelEnderecoCompleto.Size = new System.Drawing.Size(141, 20);
            this.labelEnderecoCompleto.TabIndex = 4;
            this.labelEnderecoCompleto.Text = "Endereço Completo";
            // 
            // textBoxEnderecoCompleto
            // 
            this.textBoxEnderecoCompleto.Location = new System.Drawing.Point(864, 152);
            this.textBoxEnderecoCompleto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxEnderecoCompleto.Name = "textBoxEnderecoCompleto";
            this.textBoxEnderecoCompleto.Size = new System.Drawing.Size(385, 27);
            this.textBoxEnderecoCompleto.TabIndex = 5;
            // 
            // labelPaciente
            // 
            this.labelPaciente.AutoSize = true;
            this.labelPaciente.Location = new System.Drawing.Point(978, 202);
            this.labelPaciente.Name = "labelPaciente";
            this.labelPaciente.Size = new System.Drawing.Size(64, 20);
            this.labelPaciente.TabIndex = 6;
            this.labelPaciente.Text = "Paciente";
            // 
            // comboBoxPaciente
            // 
            this.comboBoxPaciente.DisplayMember = "Nome";
            this.comboBoxPaciente.FormattingEnabled = true;
            this.comboBoxPaciente.Items.AddRange(new object[] {
            ""});
            this.comboBoxPaciente.Location = new System.Drawing.Point(978, 226);
            this.comboBoxPaciente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxPaciente.Name = "comboBoxPaciente";
            this.comboBoxPaciente.Size = new System.Drawing.Size(271, 28);
            this.comboBoxPaciente.TabIndex = 7;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(1018, 273);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(98, 45);
            this.buttonSalvar.TabIndex = 8;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(406, 26);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 45);
            this.button2.TabIndex = 9;
            this.button2.Text = "Apagar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(299, 24);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(101, 48);
            this.buttonEditar.TabIndex = 10;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(1153, 273);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(96, 45);
            this.buttonCancelar.TabIndex = 11;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Código";
            this.ColumnCodigo.MinimumWidth = 6;
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            this.ColumnCodigo.Visible = false;
            this.ColumnCodigo.Width = 125;
            // 
            // Endereco
            // 
            this.Endereco.HeaderText = "Endereço Completo";
            this.Endereco.MinimumWidth = 120;
            this.Endereco.Name = "Endereco";
            this.Endereco.ReadOnly = true;
            this.Endereco.Width = 250;
            // 
            // Cep
            // 
            this.Cep.HeaderText = "CEP";
            this.Cep.MinimumWidth = 6;
            this.Cep.Name = "Cep";
            this.Cep.ReadOnly = true;
            this.Cep.Width = 125;
            // 
            // paciente
            // 
            this.paciente.HeaderText = "Paciente";
            this.paciente.MinimumWidth = 6;
            this.paciente.Name = "paciente";
            this.paciente.ReadOnly = true;
            this.paciente.Width = 125;
            // 
            // EnderecosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 435);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.comboBoxPaciente);
            this.Controls.Add(this.labelPaciente);
            this.Controls.Add(this.textBoxEnderecoCompleto);
            this.Controls.Add(this.labelEnderecoCompleto);
            this.Controls.Add(this.labelCep);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.maskedTextBoxCep);
            this.Controls.Add(this.labelEndereco);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EnderecosForm";
            this.Text = "EnderecosForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelEndereco;
        private MaskedTextBox maskedTextBoxCep;
        private DataGridView dataGridView1;
        private Label labelCep;
        private Label labelEnderecoCompleto;
        private TextBox textBoxEnderecoCompleto;
        private Label labelPaciente;
        private ComboBox comboBoxPaciente;
        private Button buttonSalvar;
        private Button button2;
        private Button buttonEditar;
        private Button buttonCancelar;
        private DataGridViewTextBoxColumn ColumnCodigo;
        private DataGridViewTextBoxColumn Endereco;
        private DataGridViewTextBoxColumn Cep;
        private DataGridViewTextBoxColumn paciente;
    }
}
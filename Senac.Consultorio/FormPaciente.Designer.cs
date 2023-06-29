namespace Senac.Consultorio
{
    partial class FormPaciente
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCadastrar = new Button();
            txtEndereco = new TextBox();
            txtPeso = new TextBox();
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            txtCPF = new TextBox();
            txtAltura = new TextBox();
            dtpDataNascimento = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            lblQuantidadedePacientes = new Label();
            groupBox2 = new GroupBox();
            label8 = new Label();
            cmbListaPacientes = new ComboBox();
            label9 = new Label();
            txtAlergiamedicamento = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(539, 405);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 33;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(12, 280);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(602, 23);
            txtEndereco.TabIndex = 32;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(369, 191);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(245, 23);
            txtPeso.TabIndex = 31;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 27);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(245, 23);
            txtNome.TabIndex = 30;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(369, 104);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(245, 23);
            txtTelefone.TabIndex = 29;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(12, 104);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(245, 23);
            txtCPF.TabIndex = 28;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(12, 191);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(245, 23);
            txtAltura.TabIndex = 27;
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Location = new Point(369, 27);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(245, 23);
            dtpDataNascimento.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 262);
            label7.Name = "label7";
            label7.Size = new Size(66, 15);
            label7.TabIndex = 25;
            label7.Text = "ENDEREÇO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(369, 173);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 24;
            label6.Text = "PESO:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(369, 86);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 23;
            label5.Text = "TELEFONE:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 173);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 22;
            label4.Text = "ALTURA:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 86);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 21;
            label3.Text = "CPF:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(369, 9);
            label2.Name = "label2";
            label2.Size = new Size(132, 15);
            label2.TabIndex = 20;
            label2.Text = "DATA DE NASCIMENTO:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 19;
            label1.Text = "NOME:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblQuantidadedePacientes);
            groupBox1.Location = new Point(682, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(355, 121);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "QUANTIDADE DE PACIENTES";
            // 
            // lblQuantidadedePacientes
            // 
            lblQuantidadedePacientes.AutoSize = true;
            lblQuantidadedePacientes.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuantidadedePacientes.ForeColor = SystemColors.ButtonHighlight;
            lblQuantidadedePacientes.Location = new Point(79, 37);
            lblQuantidadedePacientes.Name = "lblQuantidadedePacientes";
            lblQuantidadedePacientes.Size = new Size(32, 37);
            lblQuantidadedePacientes.TabIndex = 0;
            lblQuantidadedePacientes.Text = "0";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(cmbListaPacientes);
            groupBox2.Location = new Point(682, 193);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(355, 142);
            groupBox2.TabIndex = 35;
            groupBox2.TabStop = false;
            groupBox2.Text = "CARREGAR PACIENTE";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 34);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 1;
            label8.Text = "PACIENTE";
            // 
            // cmbListaPacientes
            // 
            cmbListaPacientes.DisplayMember = "Nome";
            cmbListaPacientes.FormattingEnabled = true;
            cmbListaPacientes.Location = new Point(6, 61);
            cmbListaPacientes.Name = "cmbListaPacientes";
            cmbListaPacientes.Size = new Size(343, 23);
            cmbListaPacientes.TabIndex = 0;
            cmbListaPacientes.ValueMember = "CPF";
            cmbListaPacientes.SelectedIndexChanged += cmbListaPacientes_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 340);
            label9.Name = "label9";
            label9.Size = new Size(154, 15);
            label9.TabIndex = 36;
            label9.Text = "ALERGIA A MEDICAMENTO:";
            // 
            // txtAlergiamedicamento
            // 
            txtAlergiamedicamento.Location = new Point(12, 358);
            txtAlergiamedicamento.Name = "txtAlergiamedicamento";
            txtAlergiamedicamento.Size = new Size(602, 23);
            txtAlergiamedicamento.TabIndex = 37;
            // 
            // FormPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1198, 667);
            Controls.Add(txtAlergiamedicamento);
            Controls.Add(label9);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnCadastrar);
            Controls.Add(txtEndereco);
            Controls.Add(txtPeso);
            Controls.Add(txtNome);
            Controls.Add(txtTelefone);
            Controls.Add(txtCPF);
            Controls.Add(txtAltura);
            Controls.Add(dtpDataNascimento);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormPaciente";
            Text = "Consultorio";
            Load += FormPaciente_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrar;
        private TextBox txtEndereco;
        private TextBox txtPeso;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private TextBox txtCPF;
        private TextBox txtAltura;
        private DateTimePicker dtpDataNascimento;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private Label lblQuantidadedePacientes;
        private GroupBox groupBox2;
        private Label label8;
        private ComboBox cmbListaPacientes;
        private Label label9;
        private TextBox txtAlergiamedicamento;
    }
}
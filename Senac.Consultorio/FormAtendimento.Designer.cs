namespace Senac.Consultorio
{
    partial class FormAtendimento
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
            label1 = new Label();
            label2 = new Label();
            cmbProcedimento = new ComboBox();
            cmbPaciente = new ComboBox();
            btnAtender = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 51);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "PACIENTE:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 151);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 1;
            label2.Text = "PROCEDIMENTO:";
            // 
            // cmbProcedimento
            // 
            cmbProcedimento.FormattingEnabled = true;
            cmbProcedimento.Location = new Point(44, 169);
            cmbProcedimento.Name = "cmbProcedimento";
            cmbProcedimento.Size = new Size(205, 23);
            cmbProcedimento.TabIndex = 2;
            // 
            // cmbPaciente
            // 
            cmbPaciente.FormattingEnabled = true;
            cmbPaciente.Location = new Point(44, 69);
            cmbPaciente.Name = "cmbPaciente";
            cmbPaciente.Size = new Size(205, 23);
            cmbPaciente.TabIndex = 3;
            // 
            // btnAtender
            // 
            btnAtender.Location = new Point(44, 259);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(75, 23);
            btnAtender.TabIndex = 4;
            btnAtender.Text = "ATENDER";
            btnAtender.UseVisualStyleBackColor = true;
            // 
            // FormAtendimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 314);
            Controls.Add(btnAtender);
            Controls.Add(cmbPaciente);
            Controls.Add(cmbProcedimento);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAtendimento";
            Text = "FormAtendimento";
            Load += FormAtendimento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbProcedimento;
        private ComboBox cmbPaciente;
        private Button btnAtender;
    }
}
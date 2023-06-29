using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Senac.Consultorio
{
    public partial class FormAtendimento : Form
    {
        public FormAtendimento()
        {
            InitializeComponent();
        }

        private void FormAtendimento_Load(object sender, EventArgs e)
        {

        }
        public void CriarMockup()
        {
            Medico medico1 = new Medico();
            medico1.Nome = "GERALDO";
            medico1.CRM = "0000";
            medico1.Especialidade = "CLINICO GERAL";
            medico1.DataNascimento = new DateTime(1980, 02, 15);

            Medico medico2 = new Medico();
            medico2.Nome = "DILMA";
            medico2.CRM = "1111";
            medico2.Especialidade = "NEUROLOGISTA";
            medico2.DataNascimento = new DateTime(1980, 02, 02);

            Medico medico3 = new Medico();
            medico3.Nome = "LULA";
            medico3.CRM = "2222";
            medico3.Especialidade = "CARDIOLOGISTA";
            medico3.DataNascimento = new DateTime(2000, 02, 02);

            // Procedimentos   
            Procedimento procedimento = new Procedimento();
            procedimento.AreaMedica = "Cardiologia";
            procedimento.Nome = "Esteira";
            procedimento.MedicoProcedimento = medico3;

            cmbProcedimento.Items.Add(procedimento);

            procedimento = new Procedimento();
            procedimento.AreaMedica = "Clinico Geral";
            procedimento.Nome = "Ecocardiograma";
            procedimento.MedicoProcedimento = medico3;

            cmbProcedimento.Items.Add(procedimento);

            procedimento = new Procedimento();
            procedimento.AreaMedica = "Clinico Geral";
            procedimento.Nome = "Ultrasonografia";
            procedimento.MedicoProcedimento = medico1;

            cmbProcedimento.Items.Add(procedimento);

            procedimento = new Procedimento();
            procedimento.AreaMedica = "Clinico Geral";
            procedimento.Nome = "Mamografia";
            procedimento.MedicoProcedimento = medico1;

            cmbProcedimento.Items.Add(procedimento);

            procedimento = new Procedimento();
            procedimento.AreaMedica = "Neurologista";
            procedimento.Nome = "Eletroencefalograma";
            procedimento.MedicoProcedimento = medico2;

            cmbProcedimento.Items.Add(procedimento);

            procedimento = new Procedimento();
            procedimento.AreaMedica = "Neurologista";
            procedimento.Nome = "Ressonância Magnetica";
            procedimento.MedicoProcedimento = medico2;

            cmbProcedimento.Items.Add(procedimento);



        }
    }
}

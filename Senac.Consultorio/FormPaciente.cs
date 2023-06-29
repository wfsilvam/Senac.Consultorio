namespace Senac.Consultorio
{
    public partial class FormPaciente : Form
    {
        List<Paciente> pacientes = new List<Paciente>();
        public FormPaciente()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Criar uma intância de Pacientes.
            Paciente pacienteConsultorio = new Paciente();

            pacienteConsultorio.Nome = txtNome.Text;
            pacienteConsultorio.CPF = txtCPF.Text;
            pacienteConsultorio.DataNascimento = dtpDataNascimento.Value;
            pacienteConsultorio.Telefone = txtTelefone.Text;
            pacienteConsultorio.Altura = Convert.ToDecimal(txtAltura.Text);
            pacienteConsultorio.Peso = Convert.ToDecimal(txtPeso.Text);
            pacienteConsultorio.Endereco = txtEndereco.Text;
            pacienteConsultorio.Alergiamedicamento = txtAlergiamedicamento.Text;

            MessageBox.Show("O paciente " + pacienteConsultorio.Nome + " foi cadastrado.");
            //Insere um paciente em uma lista
            pacientes.Add(pacienteConsultorio);
            //.Count vai retornar itens que eu tenho na minha lista
            lblQuantidadedePacientes.Text = pacientes.Count().ToString();

            cmbListaPacientes.Items.Add(pacienteConsultorio);
        }

        private void cmbListaPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //1. pegar o cpf do paciente selecionado
            Paciente pacienteSelecionado = cmbListaPacientes.SelectedItem as Paciente;
            string cpf = pacienteSelecionado.CPF;

            //2. Buscar os dados do paciente selecionado na minha Lista
            // Use o Where quando quiser buscar com uma condição (QUANDO)
            Paciente paciente = pacientes.Where(p => p.CPF == cpf).First();

            //3. Carregar os dados nos campos do formulário
            CarregaDadosPaciente(paciente);


        }

        // Visibilidade
        // Tipo de retorno (Use void quando não quiser retornar nada)
        // nome do método
        // Entre parenteses vem todos os parâmetros

        public void CarregaDadosPaciente(Paciente dadosPaciente)
        {
            txtNome.Text = dadosPaciente.Nome;
            txtCPF.Text = dadosPaciente.CPF;
            dtpDataNascimento.Value = dadosPaciente.DataNascimento;
            txtTelefone.Text = Text = dadosPaciente.Telefone;
            txtAltura.Text = dadosPaciente.Altura.ToString();
            txtPeso.Text = dadosPaciente.Peso.ToString();
            txtEndereco.Text = dadosPaciente.Endereco;
            txtAlergiamedicamento.Text = dadosPaciente.Alergiamedicamento;


        }
        public void CriaPacientesMockup()

        {

            Paciente paciente = new Paciente();
            cmbListaPacientes.Items.Add(paciente);
            paciente.Nome = "LARISSA";
            paciente.Altura = 1.60m;
            paciente.Alergiamedicamento = "Dipirona";
            paciente.Telefone = "00000 - 00000";
            paciente.DataNascimento = new DateTime(1989, 09, 28);
            paciente.Endereco = "Rua  1";
            paciente.CPF = "000.000.000.00";
            paciente.Peso = 60;

            pacientes.Add(paciente);
            cmbListaPacientes.Items.Add(paciente);

            paciente = new Paciente();
            paciente.Nome = "THAYS";
            paciente.Altura = 1.50m;
            paciente.Alergiamedicamento = "PARACETAMOL";
            paciente.Telefone = "00000 - 00000";
            paciente.DataNascimento = new DateTime(2000, 09, 28);
            paciente.Endereco = "Rua  2";
            paciente.CPF = "000.000.000.11";
            paciente.Peso = 55;

            pacientes.Add(paciente);
            cmbListaPacientes.Items.Add(paciente);


            paciente = new Paciente();
            paciente.Nome = "THAYLOR";
            paciente.Altura = 1.75m;
            paciente.Alergiamedicamento = "SORO";
            paciente.Telefone = "00000 - 00000";
            paciente.DataNascimento = new DateTime(2003, 09, 28);
            paciente.Endereco = "Rua  1";
            paciente.CPF = "000.000.000.22";
            paciente.Peso = 85;

            pacientes.Add(paciente);
            cmbListaPacientes.Items.Add(paciente);


            paciente = new Paciente();
            paciente.Nome = "DIANA";
            paciente.Altura = 1.60m;
            paciente.Alergiamedicamento = "PLASTICO";
            paciente.Telefone = "00000 - 00000";
            paciente.DataNascimento = new DateTime(2000, 06, 07);
            paciente.Endereco = "Rua  1";
            paciente.CPF = "000.000.000.33";
            paciente.Peso = 55;

            pacientes.Add(paciente);
            cmbListaPacientes.Items.Add(paciente);


        }

        private void FormPaciente_Load(object sender, EventArgs e)
        {
            CriaPacientesMockup();
            lblQuantidadedePacientes.Text = pacientes.Count().ToString();
        }
    }
}
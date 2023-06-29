using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senac.Consultorio
{
    public class Atendimento
    {
        public DateTime DataHoraAtendimento { get; set; }
        public Paciente PacienteAtendido { get; set; }
        public Atendimento Procedimento { get; set; }


    }
}

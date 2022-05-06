using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaOCP
{
    public class ModeloFuncionario
    {
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string EnderecoEmail { get; set; }
        public bool TemCargoGerente { get; set; } = false;
        public bool TemCargoExecutivo { get; set; } = false;
    }
}

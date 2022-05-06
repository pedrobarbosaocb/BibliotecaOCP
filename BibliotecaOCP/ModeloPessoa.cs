using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaOCP
{
    public class ModeloPessoa
    {
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public TipoFuncionario CargoFuncionario { get; set; } = TipoFuncionario.Assistente;
    }
}

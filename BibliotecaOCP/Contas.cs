using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaOCP
{
    public class Contas
    {
        public ModeloFuncionario Create(ModeloPessoa pessoa)
        {
            ModeloFuncionario output = new ModeloFuncionario();
            output.PrimeiroNome = pessoa.PrimeiroNome;
            output.UltimoNome = pessoa.UltimoNome;
            output.EnderecoEmail = $"{pessoa.PrimeiroNome.Substring(0, 1)}{pessoa.UltimoNome}@castgroup.com";

            //if(pessoa.Employee == TipoFuncionario.Manager)
            //{
            //    output.IsManager = true;
            //}

            switch (pessoa.CargoFuncionario)
            {
                /*
                case TipoFuncionario.Assistente:
                    break;
                case TipoFuncionario.DesenvolvedorTrainee:
                    break;
                case TipoFuncionario.Supervisor:
                    break;
                */
                case TipoFuncionario.Gerente:
                    output.TemCargoGerente = true;
                    break;
                case TipoFuncionario.Executivo:
                    output.TemCargoExecutivo = true;
                    break;
                default:
                    break;
            }

            return output;
        }
    }
}

using System;
using System.Collections.Generic;
using BibliotecaOCP;

namespace Aula80_OCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ModeloPessoa> candidatos = new List<ModeloPessoa>
            {
                new ModeloPessoa{ PrimeiroNome = "Ana", UltimoNome = "Beatriz" },
                new ModeloPessoa{ PrimeiroNome = "Bia", UltimoNome = "Cezar", CargoFuncionario = TipoFuncionario.Gerente},
                new ModeloPessoa{ PrimeiroNome = "Cris", UltimoNome = "Duarte" },
                new ModeloPessoa{ PrimeiroNome = "Dilma", UltimoNome = "Ester" },
                new ModeloPessoa{ PrimeiroNome = "Elaine", UltimoNome = "Fonseca" },
                new ModeloPessoa{ PrimeiroNome = "Fabiana", UltimoNome = "Gabriela", CargoFuncionario = TipoFuncionario.Executivo }
            };

            List<ModeloFuncionario> funcionarios = new List<ModeloFuncionario>();
            Contas processadorConta = new Contas();

            //Alimentou a lista funcionarios
            foreach (var pessoa in candidatos)
            {
                funcionarios.Add(processadorConta.Create(pessoa));
            }

            foreach (var fuc in funcionarios)
            {
                Console.WriteLine($"É gerente: {(fuc.TemCargoGerente ? "sim" : "não")}\t | É executivo: {(fuc.TemCargoExecutivo ? "sim" : "não")}\t | {fuc.PrimeiroNome} {fuc.UltimoNome}: {fuc.EnderecoEmail} ");
            }
        }
    }
}

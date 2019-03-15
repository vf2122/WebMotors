using System;
using WebMotors.Domain.Commands;
using WebMotors.Domain.Commands.Entities;

namespace WebMotors.Service.Api.Models
{
    public class CadastrarAnuncioWebMotorsModel
    {
        public CadastrarAnuncioWebMotorsModel(string marca, string modelo, string versao, int ano, int quilometragem, string observacao)
        {
            Marca = marca;
            Modelo = modelo;
            Versao = versao;
            Ano = ano;
            Quilometragem = quilometragem;
            Observacao = observacao;
        }

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Versao { get; set; }
        public int Ano { get; set; }
        public int Quilometragem { get; set; }
        public string Observacao { get; set; }

        internal Command ToCommand()
        {
            var command = new CadastrarAnuncioWebMotorsCommand(
                this.Marca,
                this.Modelo,
                this.Versao,
                this.Ano,
                this.Quilometragem,
                this.Observacao);

            return command;
        }
    }
}
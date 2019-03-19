using WebMotors.Domain.Commands.Entities;

namespace WebMotors.Application.Models
{
    public class AlterarAnuncioWebMotorsModel
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Versao { get; set; }
        public int Ano { get; set; }
        public int Quilometragem { get; set; }
        public string Observacao { get; set; }

        public AlterarAnuncioWebMotorsCommand ToCommand()
        {
            var command = new AlterarAnuncioWebMotorsCommand(
                this.Id,
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
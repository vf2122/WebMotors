using FluentValidation;
using prmToolkit.NotificationPattern;

namespace WebMotors.Domain.Commands.Entities
{
    public class AlterarAnuncioWebMotorsCommand : AbstractValidator<Command>
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Versao { get; set; }
        public int Ano { get; set; }
        public int Quilometragem { get; set; }
        public string Observacao { get; set; }

        public AlterarAnuncioWebMotorsCommand(string Marca, string Modelo, string Versao, int Ano, int Quilometragem, string Observacao)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Versao = Versao;
            this.Ano = Ano;
            this.Quilometragem = Quilometragem;
            this.Observacao = Observacao;

            
            new AddNotifications<AlterarAnuncioWebMotorsCommand>(this)
                .IfNullOrInvalidLength(x => x.Marca, 3, 45)
                .IfNullOrInvalidLength(x => x.Modelo, 3, 45)
                .IfNullOrInvalidLength(x => x.Versao, 3, 45)
                .IfTrue(x => x.Ano > 1900, "Digite um ano válido. Ex: 1994")
                .IfNull(x => x.Ano)
                .IfNull(x => x.Quilometragem)
                .IfTrue(x => !string.IsNullOrEmpty(x.Observacao) && x.Observacao.Length < 15);
        }

    }
    public class Validate : AbstractValidator<AlterarAnuncioWebMotorsCommand>
    {
        public Validate(AlterarAnuncioWebMotorsCommand t)
        {
            t.RuleFor(x => x.)
        }
    }
}

using WebMotors.Domain.Commands.Entities;
using WebMotors.Domain.Entities;
using WebMotors.Domain.Interfaces;
using WebMotors.Domain.Interfaces.CommandHandler;

namespace WebMotors.Domain.CommandHandlers.Entities
{
    public class AnuncioWebmotorsCommandHandler : CommandHandler<AnuncioWebmotors>, 
        ICommandHandler<CadastrarAnuncioWebMotorsCommand>, 
        ICommandHandler<AlterarAnuncioWebMotorsCommand>,
        ICommandHandler<RemoverAnuncioWebMotorsCommand>
    {
        public AnuncioWebmotorsCommandHandler(IRepositoryBase<AnuncioWebmotors> repository) : base(repository)
        {
        }

        public void handler(CadastrarAnuncioWebMotorsCommand command)
        {
            if (command.IsInvalid())
            {
                this.AddNotifications(command);
                return;
            }

            var anuncio = new AnuncioWebmotors(command.Marca, command.Modelo, command.Versao, command.Ano, command.Quilometragem, command.Observacao);

            if (anuncio.IsInvalid())
            {
                this.AddNotifications(anuncio);
                return;
            }

            _repository.Add(anuncio);
        }

        public void handler(AlterarAnuncioWebMotorsCommand command)
        {
            if (command.IsInvalid())
            {
                this.AddNotifications(command);
                return;
            }

            var anuncio = new AnuncioWebmotors(command.Marca, command.Modelo, command.Versao, command.Ano, command.Quilometragem, command.Observacao);

            if (anuncio.IsInvalid())
            {
                this.AddNotifications(anuncio);
                return;
            }

            _repository.Update(anuncio);
        }

        public void handler(RemoverAnuncioWebMotorsCommand command)
        {
            if (command.IsInvalid())
            {
                this.AddNotifications(command);
                return;
            }

            var anuncio = _repository.GetById(command.Id);

            if (anuncio.IsInvalid())
            {
                this.AddNotifications(anuncio);
                return;
            }

            _repository.Remove(anuncio);
        }
    }
}

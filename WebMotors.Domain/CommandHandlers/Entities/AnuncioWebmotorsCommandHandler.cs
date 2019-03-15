using WebMotors.Domain.Commands.Entities;
using WebMotors.Domain.Entities;
using WebMotors.Domain.Interfaces.CommandHandler;
using WebMotors.Domain.Interfaces.Entities;

namespace WebMotors.Domain.CommandHandlers.Entities
{
    public class AnuncioWebMotorsCommandHandler : CommandHandler<AnuncioWebmotors>, 
        ICommandHandler<CadastrarAnuncioWebMotorsCommand>, 
        ICommandHandler<AlterarAnuncioWebMotorsCommand>,
        ICommandHandler<RemoverAnuncioWebMotorsCommand>
    {
        public AnuncioWebMotorsCommandHandler(IAnuncioWebmotorsRepository repository) : base(repository)
        {
        }

        public void handle(CadastrarAnuncioWebMotorsCommand command)
        {
            var anuncio = new AnuncioWebmotors(command.Marca, command.Modelo, command.Versao, command.Ano, command.Quilometragem, command.Observacao);

            _repository.Add(anuncio);
        }

        public void handle(AlterarAnuncioWebMotorsCommand command)
        {
            var anuncio = _repository.GetById(command.Id);

            anuncio.SetAno(command.Ano);
            anuncio.SetMarca(command.Marca);
            anuncio.SetModelo(command.Modelo);
            anuncio.SetVersao(command.Versao);
            anuncio.SetQuilometragem(command.Quilometragem);
            anuncio.SetObservacao(command.Observacao);

            _repository.Update(anuncio);
        }

        public void handle(RemoverAnuncioWebMotorsCommand command)
        {
            var anuncio = _repository.GetById(command.Id);

            _repository.Remove(anuncio);
        }
    }
}

using MediatR;
using System.Threading;
using System.Threading.Tasks;
using WebMotors.Domain.Commands.Entities;
using WebMotors.Domain.Entities;
using WebMotors.Domain.Interfaces.CommandHandler;
using WebMotors.Domain.Interfaces.Entities;

namespace WebMotors.Domain.CommandHandlers.Entities
{
    public class AnuncioWebMotorsCommandHandler : CommandHandler<AnuncioWebmotors>, 
        IRequestHandler<CadastrarAnuncioWebMotorsCommand, bool>,
        IRequestHandler<AlterarAnuncioWebMotorsCommand, bool>,
        IRequestHandler<RemoverAnuncioWebMotorsCommand, bool>
    {
        public AnuncioWebMotorsCommandHandler(IAnuncioWebmotorsRepository repository) : base(repository)
        {
        }

        public Task<bool> Handle(CadastrarAnuncioWebMotorsCommand command, CancellationToken cancellationToken)
        {
            var anuncio = new AnuncioWebmotors(command.Marca, command.Modelo, command.Versao, command.Ano, command.Quilometragem, command.Observacao);

            _repository.Add(anuncio);

            return Task.FromResult(true);
        }

        public Task<bool> Handle(AlterarAnuncioWebMotorsCommand command, CancellationToken cancellationToken)
        {
            var anuncio = _repository.GetById(command.Id);

            anuncio.SetAno(command.Ano);
            anuncio.SetMarca(command.Marca);
            anuncio.SetModelo(command.Modelo);
            anuncio.SetVersao(command.Versao);
            anuncio.SetQuilometragem(command.Quilometragem);
            anuncio.SetObservacao(command.Observacao);

            _repository.Update(anuncio);

            return Task.FromResult(true);
        }

        public Task<bool> Handle(RemoverAnuncioWebMotorsCommand command, CancellationToken cancellationToken)
        {
            var anuncio = _repository.GetById(command.Id);

            _repository.Remove(anuncio);

            return Task.FromResult(true);
        }


    }
}

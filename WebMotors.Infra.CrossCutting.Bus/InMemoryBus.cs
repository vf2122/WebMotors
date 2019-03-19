using MediatR;
using System.Threading.Tasks;
using WebMotors.Domain.Commands;
using WebMotors.Domain.Interfaces.Bus;

namespace WebMotors.Infra.CrossCutting.Bus
{
    public class InMemoryBus : IMediatorHandler
    {
        private readonly IMediator _mediator;

        public InMemoryBus(IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task SendCommand<T>(T command) where T : Command
        {
            return _mediator.Send(command, new System.Threading.CancellationToken());
        }
    }
}

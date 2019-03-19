using System.Threading.Tasks;
using WebMotors.Domain.Commands;

namespace WebMotors.Domain.Interfaces.Bus
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : Command;
    }
}

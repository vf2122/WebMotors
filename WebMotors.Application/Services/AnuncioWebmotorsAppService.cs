using System.Collections.Generic;
using System.Linq;
using WebMotors.Application.Interfaces.Entities;
using WebMotors.Application.Models;
using WebMotors.Domain.Interfaces.Bus;
using WebMotors.Domain.Interfaces.Entities;

namespace WebMotors.Application.Services
{
    public class AnuncioWebmotorsAppService : IAnuncioWebmotorsAppService
    {
        private readonly IMediatorHandler _bus;
        private readonly IAnuncioWebmotorsRepository _repo;

        public AnuncioWebmotorsAppService(IMediatorHandler bus, IAnuncioWebmotorsRepository repo)
        {
            _bus = bus;
            _repo = repo;
        }

        public IEnumerable<AnuncioWebMotorsModel> GetAll()
        {
            return _repo.GetAll().Select(x => { return (AnuncioWebMotorsModel)x; }).ToList();
        }

        public AnuncioWebMotorsModel GetById(int id)
        {
            return (AnuncioWebMotorsModel)_repo.GetById(id);
        }

        public void Register(CadastrarAnuncioWebMotorsModel anuncioCadastrarViewModel)
        {
            _bus.SendCommand(anuncioCadastrarViewModel.ToCommand());
        }

        public void Remove(RemoverAnuncioWebMotorsModel anuncioRemoverViewModel)
        {
            _bus.SendCommand(anuncioRemoverViewModel.ToCommand());
        }

        public void Update(AlterarAnuncioWebMotorsModel anuncioAlterarViewModel)
        {
            _bus.SendCommand(anuncioAlterarViewModel.ToCommand());
        }
    }
}

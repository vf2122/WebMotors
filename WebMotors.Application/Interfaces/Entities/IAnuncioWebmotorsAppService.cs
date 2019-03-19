using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMotors.Application.Models;

namespace WebMotors.Application.Interfaces.Entities
{
    public interface IAnuncioWebmotorsAppService
    {
        void Register(CadastrarAnuncioWebMotorsModel anuncioCadastrarViewModel);
        IEnumerable<AnuncioWebMotorsModel> GetAll();
        AnuncioWebMotorsModel GetById(int id);
        void Update(AlterarAnuncioWebMotorsModel anuncioAlterarViewModel);
        void Remove(RemoverAnuncioWebMotorsModel anuncioRemoverViewModel);
    }
}

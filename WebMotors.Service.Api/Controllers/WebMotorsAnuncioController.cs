using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebMotors.Domain.Commands;
using WebMotors.Domain.Interfaces.CommandHandler;
using WebMotors.Domain.Interfaces.Entities;
using WebMotors.Service.Api.Models;

namespace WebMotors.Service.Api.Controllers
{
    public class WebMotorsAnuncioController : ApiController
    {
        private readonly IAnuncioWebmotorsRepository _repo;
        private readonly ICommandHandler<Command> _handler;

        public WebMotorsAnuncioController(
            IAnuncioWebmotorsRepository repo,
            ICommandHandler<Command> handler
            )
        {
            _repo = repo;
            _handler = handler;
        }

        // GET api/values
        public IEnumerable<AnuncioWebMotorsModel> Get()
        {
            return _repo.GetAll().Select(x => { return (AnuncioWebMotorsModel)x; }).ToList();
        }

        // GET api/values/5
        public AnuncioWebMotorsModel Get(int id)
        {
            return (AnuncioWebMotorsModel)_repo.GetById(id);
        }

        // POST api/values
        public void Post([FromBody]CadastrarAnuncioWebMotorsModel model)
        {
            _handler.handle(model.ToCommand());
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]AlterarAnuncioWebMotorsModel model)
        {
            _handler.handle(model.ToCommand());
        }

        // DELETE api/values/5
        public void Delete(RemoverAnuncioWebMotorsModel model)
        {
            _handler.handle(model.ToCommand());
        }
    }
}

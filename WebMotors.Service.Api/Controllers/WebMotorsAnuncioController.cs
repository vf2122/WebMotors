using System.Collections.Generic;
using System.Web.Http;
using WebMotors.Application.Interfaces.Entities;
using WebMotors.Application.Models;

namespace WebMotors.Service.Api.Controllers
{
    public class WebMotorsAnuncioController : ApiController
    {
        private readonly IAnuncioWebmotorsAppService _app;

        public WebMotorsAnuncioController(IAnuncioWebmotorsAppService app)
        {
            _app = app;
        }


        // GET api/values
        public IEnumerable<AnuncioWebMotorsModel> Get()
        {
            return _app.GetAll();
        }

        // GET api/values/5
        public AnuncioWebMotorsModel Get(int id)
        {
            return _app.GetById(id);
        }

        // POST api/values
        public void Post([FromBody]CadastrarAnuncioWebMotorsModel model)
        {
            _app.Register(model);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]AlterarAnuncioWebMotorsModel model)
        {
            _app.Update(model);
        }

        // DELETE api/values/5
        public void Delete(RemoverAnuncioWebMotorsModel model)
        {
            _app.Remove(model);
        }
    }
}

using Infra.Data.EFM.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var _repo = new AnuncioWebmotorsRepository();

            var command = new WebMotors.Domain.Commands.Entities.CadastrarAnuncioWebMotorsCommand(
                "Chevrolet",
                "Prisma",
                "basica",
                2010,
                0,
                "");

            var commandHandler = new WebMotors.Domain.CommandHandlers.Entities.AnuncioWebmotorsCommandHandler(_repo);
            commandHandler.handler(command);

        }
    }
}
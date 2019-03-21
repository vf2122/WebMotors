using System.Data.Entity;
using WebMotors.Domain.Entities;

namespace Infra.Data.EFM.Context
{
    public class Context : DbContext
    {
        public Context() : base (@"Data Source=LAPTOP-236K86F0\SQLEXPRESS;Initial Catalog=teste_webmotors;Integrated Security=True")
        {
        }

        public DbSet<AnuncioWebmotors> AnuncioWebmotors { get; set; }
    }
}

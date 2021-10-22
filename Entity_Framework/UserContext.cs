using System.Data.Entity;

namespace Entity_Framework
{
    public class UserContext : DbContext
    {
        public UserContext() : base("DbConnection")  // определяет контекст данных, используемый для взаимодействия с базой данных.
        { }
        public DbSet<User> Users { get; set; }
    }
}

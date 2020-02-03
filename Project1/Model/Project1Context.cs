using System.Data.Entity;

namespace Project1.Model
{
    public class Project1Context :DbContext, IAnimalContext
    {
        public Project1Context() : base()
        {

        }
        public Project1Context(string connectionString)
        {
            Database.Connection.ConnectionString = connectionString;
        }
    public virtual DbSet<Animal> Animals { get; set; }
    }
}
